using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.EPFPageObjectFactory;
using CrystalDecisions.CrystalReports.EMFServerMessageFactory;
using System.Globalization;


namespace Komunala
{
    public partial class frmCenikt_Izpis : Form
    {
        SqlConnection con = frmMain.c;
        SqlConnection con2 = frmMain.c2;
        SqlConnection con3 = frmMain.c3;
        SqlCommand cmd;
        SqlDataReader rdr = null;
        SqlDataAdapter adapt, adapt2;
        ReportDocument cryrpt = new ReportDocument();
        SqlCommand cmd2;
        SqlDataReader rdr2 = null;
        SqlCommand cmd3;
        SqlDataReader rdr3 = null;
        DataSet ds = new DataSet();
        crCeniktrg crpt = new crCeniktrg();

        int i, ii, idx_skupina, id_stor, id_storitev, id_em, id_ddv, id_skupina;
        string q, q1, q2, q3, tm, tl, sid_stor, str_storitev, str_em, str_ddv, str_cena, str_cena95, str_cena22, str_skupina;
        double cena_tmp, float_ddv;
        string sidx_skupina;

        public frmCenikt_Izpis()
        {
            InitializeComponent();
        }

        private void frmCenikt_Izpis_Load(object sender, EventArgs e)
        {
            Zacasna_tabela();
            try
            {
                q = "select * from tblskupinestoritev";
                cmd = new SqlCommand(q, con);
                SqlDataAdapter da = new SqlDataAdapter(q, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "tblskupinestoritev");

                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    sidx_skupina = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    idx_skupina = Convert.ToInt32(sidx_skupina);
                    q2 = "select * from tblCenik_tmp where skupina = @skupina_id";
                    cmd = new SqlCommand(q2, con);
                    SqlDataAdapter da2 = new SqlDataAdapter(q2, con);
                    da2.SelectCommand.Parameters.Add("@skupina_id", idx_skupina);
                    da2.Fill(ds, "tblCenik_tmp");
                }
                crpt.SetDataSource(ds);
                crvCenikt.ReportSource = crpt;
                crvCenikt.Zoom(2);
                Dodatni_tekst();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka pri odpiranju cenika: " + ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                    crvCenikt.Refresh();
                }
            }

        }


        private void Zacasna_tabela()
        {

            // izprazni bazo z začasnim cenikom
            q3 = "delete from tblcenik_tmp";
            try
            {
                cmd3 = new SqlCommand(q3, con3);
                con3.Open();
                cmd3.ExecuteNonQuery();
                con3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: izprazni tabelo : " + ex.Message);
            }

            // napiši začasno tabelo cenik
            q2 = "select * from tbl_Cenik_trg";
            try
            {
                cmd = new SqlCommand(q2, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    id_storitev = (int)rdr["storitev"];
                    id_em = (int)rdr["em"];
                    cena_tmp = (double)rdr["cena_obcina"];
                    double cena_zacasno22 = cena_tmp * 1.22;
                    double cena_zacasno95 = cena_tmp * 1.095;
                    id_skupina = (int)rdr["skupina"];
                    str_cena = cena_tmp.ToString("F2");
                    str_cena22 = cena_zacasno22.ToString("F2");
                    str_cena95 = cena_zacasno95.ToString("F2");

                    // preberi em
                    q3 = "select em from tbl_enote where id = @indeks";
                    try
                    {
                        cmd3 = new SqlCommand(q3, con3);
                        con3.Open();
                        cmd3.Parameters.AddWithValue("@indeks", id_em);
                        cmd3.ExecuteNonQuery();
                        str_em = (string)cmd3.ExecuteScalar();
                        con3.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka: naziv_em : " + ex.Message);
                    }

                    // preberi storitev
                    q3 = "select storitev from tblStoritve where id = @indeks";
                    try
                    {
                        cmd3 = new SqlCommand(q3, con3);
                        con3.Open();
                        cmd3.Parameters.AddWithValue("@indeks", id_storitev);
                        cmd3.ExecuteNonQuery();
                        str_storitev = (string)cmd3.ExecuteScalar();
                        con3.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka: najdi storitev : " + ex.Message);
                    }

                    // preberi skupino storitev
                    q3 = "select skupina from tblSkupinestoritev where id = @indeks";
                    try
                    {
                        cmd3 = new SqlCommand(q3, con3);
                        con3.Open();
                        cmd3.Parameters.AddWithValue("@indeks", id_skupina);
                        cmd3.ExecuteNonQuery();
                        str_skupina = (string)cmd3.ExecuteScalar();
                        con3.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka: najdi skupino storitev : " + ex.Message);
                    }

                    // napiši bazo z začasnim cenikom
                    try
                    {
                        q = "insert into tblcenik_tmp(skupina,storitev,em,ddv,cena,cena95,cena22,fcena,fcena22,fcena95) values(@tskupina,@tstoritev,@tem,@tddv,@tcena,@tcena95,@tcena22,@fcena,@fcena22,@fcena95)";
                        cmd2 = new SqlCommand(q, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@tskupina", id_skupina);
                        cmd2.Parameters.AddWithValue("@tstoritev", str_storitev);
                        cmd2.Parameters.AddWithValue("@tem", str_em);
                        cmd2.Parameters.AddWithValue("@tddv", 1);
                        cmd2.Parameters.AddWithValue("@tcena", str_cena);
                        cmd2.Parameters.AddWithValue("@tcena95", str_cena95);
                        cmd2.Parameters.AddWithValue("@tcena22", str_cena22);
                        cmd2.Parameters.AddWithValue("@fcena", cena_tmp);
                        cmd2.Parameters.AddWithValue("@fcena22", cena_tmp * 1.22);
                        cmd2.Parameters.AddWithValue("@fcena95", cena_tmp * 1.095);
                        cmd2.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka insert: " + ex.Message);
                    }
                    finally
                    {
                        if (con2 != null)
                        {
                            con2.Close();
                        }
                    }
                } // while reader
            } // try reader
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: reader : " + ex.Message);
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (con != null)
                {
                    con.Close();
                    crvCenikt.Refresh();
                }
            }

        }


        private void Dodatni_tekst()
        {
            // Korekcija cen
            TextObject tt4 = (TextObject)crpt.ReportDefinition.Sections["Section1"].ReportObjects["ttekst_t_1"];
            tt4.Text = frmMain.tekst_t_1;
            // direktor
            TextObject tt5 = (TextObject)crpt.ReportDefinition.Sections["Section4"].ReportObjects["tdirektor"];
            tt5.Text = frmMain.direktor;
            // datum na prvi strani
            string str_tmp = "Gornja Radgona, " + frmMain.datum_t_1;
            TextObject tt6 = (TextObject)crpt.ReportDefinition.Sections["Section1"].ReportObjects["tdatum_t_2"];
            tt6.Text = str_tmp;
            // velja od
            str_tmp = "Cenik velja od " + frmMain.datum_t_2;
            TextObject tt7 = (TextObject)crpt.ReportDefinition.Sections["Section4"].ReportObjects["tdatum_t_1"];
            tt7.Text = str_tmp;
            // nad prvo stranjo cenika
            //TextObject tt8 = (TextObject)crpt.ReportDefinition.Sections["Section1"].ReportObjects["ttekst_t_2"];
            //tt8.Text = frmMain.tekst_t_2;
        }

    }
}
