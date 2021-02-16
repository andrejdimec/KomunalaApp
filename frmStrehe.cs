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

namespace Komunala
{
    public partial class frmStrehe : Form
    {

        SqlConnection con = frmMain.c;
        SqlConnection con2 = frmMain.c2;
        SqlConnection con3 = frmMain.c3;
        SqlConnection con9 = frmMain.c9;
        SqlConnection con6 = frmMain.c6;
        SqlDataAdapter adapt;

        SqlCommand cmd;
        SqlDataReader rdr = null;

        SqlCommand cmd2;
        SqlDataReader rdr2 = null;

        SqlCommand cmd3;
        SqlDataReader rdr3 = null;

        SqlDataReader rdr9 = null;
        SqlCommand cmd9;

        SqlDataReader rdr6 = null;
        SqlCommand cmd6;

        static DataTable dt, dt2, dt3, dt4;
        string q,q2,q3,q6,q9;

        string idx_sta, hsmid_gl;
        string st_nen,sta_sid, st_stanovanj, st_poslovnih_prostorov;

        // obračun
        string oobjectid, osta_sid, ohs_mid, olastnik, ostanovalec, oplacnik, ocadis, onaslov_pl, ohs_pl, olabela_pl;

        private void button1_Click(object sender, EventArgs e)
        {
            Pripravi_seznam();
        }

        string ohd_pl, opt_pl, optime_pl, odrzava_pl, ost_stanovanja, oraba_id, oraba_ime;
        int ovecstanovanjska, oodobreno,ost_prostorov;
        double on_tloris, on_tloris_skupaj, oprocent, ostreha_skupaj, ostreha_delez;

        private void Strehe() // informacije o celi bazi streh
        {
            q2 = "select count(*) from ren_strehe";
            cmd2 = new SqlCommand(q2, con2);
            con2.Open();
            int vseh_zapisov = (Int32)cmd2.ExecuteScalar();
            label16.Text = vseh_zapisov.ToString();
            con2.Close();

            string q6 = "SELECT SUM (povrsina) FROM ren_strehe";
            cmd6 = new SqlCommand(q6, con6);
            con6.Open();
            double vsota_streh = (double)cmd6.ExecuteScalar();
            label3.Text = vsota_streh.ToString("N2");
            con6.Close();
        }

        private void Nalozi_strehe_stavbe(int vhod)  // strehe, ki spadajo k naloženi stavbi
        {
            q6 = "SELECT hsmid_gl FROM ren_strehe  where id = @idx"; // poišči glavni hsmid
            cmd6 = new SqlCommand(q6, con6);
            cmd6.Parameters.AddWithValue("@idx", vhod);
            con6.Open();
            hsmid_gl = (string)cmd6.ExecuteScalar();
            con6.Close();

            q2 = "select count(*) from ren_strehe where hsmid_gl=@idx";  // preštej koliko streh spada h glavni
            cmd2 = new SqlCommand(q2, con2);
            cmd2.Parameters.AddWithValue("@idx", hsmid_gl);
            con2.Open();
            label8.Text = Convert.ToString((Int32)cmd2.ExecuteScalar());
            con2.Close();

            q6 = "SELECT SUM (povrsina) FROM ren_strehe where hsmid_gl=@idx";  // seštej površino streh, ki spadajo k glavni
            cmd6 = new SqlCommand(q6, con6);
            cmd6.Parameters.AddWithValue("@idx", hsmid_gl);
            con6.Open();
            double vsota_streh = (double)cmd6.ExecuteScalar();
            label20.Text = vsota_streh.ToString("N2");
            con6.Close();


            dgvps.RowHeadersVisible = false;
            string q = "select id,ObjectID,hsmid,glavna_streha,povrsina from ren_strehe where hsmid_gl=@idx order by glavna_streha desc";  // preštej koliko streh spada h glavni

            var da = new SqlDataAdapter(q, con);
            da.SelectCommand.Parameters.AddWithValue("@idx",hsmid_gl);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dgvps.DataSource = dt;
            dgvps.ReadOnly = true;
            dgvps.Columns[0].Visible = false;
            dgvps.Columns[1].Width = 80;
            dgvps.Columns[2].Width = 90;
            dgvps.Columns[3].Width = 60;
            dgvps.Columns[4].Width = 84;
            dgvps.Columns[1].HeaderText = "  ObjectID";
            dgvps.Columns[2].HeaderText = "    HS mid";
            dgvps.Columns[3].HeaderText = " Glavna";
            dgvps.Columns[4].HeaderText = "  Površina";
            this.dgvps.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvps.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvps.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvps.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvps.Columns[4].DefaultCellStyle.Format = "0.00";
        }

        private void Poisci_naslove(string vhod)
        {
            // naloži naslove stavbe v mrežo
            dgvn.RowHeadersVisible = false;
            string q2 = "SELECT tbl_hise.naslov AS nas, tbl_hise.labela AS lab, tbl_ren_stavba_naslovi.sta_sid AS stasid, tbl_ren_stavba_naslovi.hs_mid " +
                "AS hsmid FROM tbl_ren_stavba_naslovi INNER JOIN tbl_hise ON tbl_ren_stavba_naslovi.hs_mid = tbl_hise.hsmid WHERE(tbl_ren_stavba_naslovi.sta_sid = @idx)";
            var da2 = new SqlDataAdapter(q2, con2);
            da2.SelectCommand.Parameters.Add("@idx", vhod);
            dt2 = new DataTable();
            da2.Fill(dt2);
            con2.Close();
            dgvn.DataSource = dt2;
            dgvn.ReadOnly = true;
            dgvn.Columns[2].Visible = false;
            dgvn.Columns[3].Visible = false;
            dgvn.Columns[0].Width = 235;
            dgvn.Columns[1].Width = 80;
            dgvn.Columns[0].HeaderText = "Naslov";
            dgvn.Columns[1].HeaderText = "      HŠ";
            this.dgvn.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dgvd_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            string idx_dst = dgvd.Rows[e.RowIndex].Cells[0].Value.ToString();

            //q6 = "SELECT dst_sid FROM ren_deli_stavb  where id = @idx"; 
            //cmd6 = new SqlCommand(q6, con6);
            //cmd6.Parameters.AddWithValue("@idx", idx_dst);
            //con6.Open();
            //string dst_sid = (string)cmd6.ExecuteScalar();
            //con6.Close();

            string nen_id_s = st_nen_id(idx_dst);
            Poisci_lastnike_delov(nen_id_s);
        }

        private void Poisci_dele_stavbe(string vhod)  // con2
        {
            // naloži naslove stavbe v mrežo
            dgvd.RowHeadersVisible = false;

            string q3 = "SELECT tbl_ren_deli_stavb.dst_sid,tbl_ren_deli_stavb.id, ren_Sifranti.ime as ime, tbl_ren_stavbe.sta_sid AS Expr1, tbl_ren_deli_stavb.stevstan AS Expr3, tbl_ren_deli_stavb.stevstan AS st_stan, " +
                "tbl_ren_deli_stavb.dejanska_raba, tbl_ren_deli_stavb.st_etaze, tbl_ren_deli_stavb.st_nadstropja FROM tbl_ren_stavbe INNER JOIN " +
                "tbl_ren_deli_stavb ON tbl_ren_stavbe.sta_sid = tbl_ren_deli_stavb.sta_sid INNER JOIN ren_Sifranti ON tbl_ren_deli_stavb.dejanska_raba = ren_Sifranti.idsif " +
                "WHERE(tbl_ren_stavbe.sta_sid = @idx) order by ime desc, st_stan asc";
            //string q2 = "SELECT tbl_hise.naslov AS nas, tbl_hise.labela AS lab, tbl_ren_stavba_naslovi.sta_sid AS stasid, tbl_ren_stavba_naslovi.hs_mid " +
            //    "AS hsmid FROM tbl_ren_stavba_naslovi INNER JOIN tbl_hise ON tbl_ren_stavba_naslovi.hs_mid = tbl_hise.hsmid WHERE(tbl_ren_stavba_naslovi.sta_sid = @idx)";
            var da3 = new SqlDataAdapter(q3, con2);
            da3.SelectCommand.Parameters.Add("@idx", vhod);
            dt3 = new DataTable();
            da3.Fill(dt3);
            con2.Close();
            dgvd.DataSource = dt3;
            dgvd.ReadOnly = true;
            //dgvd.Columns[].Visible = false;
            dgvd.Columns[0].Visible = false;
            dgvd.Columns[1].Visible = false;
            dgvd.Columns[3].Visible = false;
            dgvd.Columns[4].Visible = false;
            //dgvd.Columns[3].Visible = false;
            dgvd.Columns[2].Width = 235;
            dgvd.Columns[3].Width = 80;
            dgvd.Columns[2].HeaderText = "Dejanska raba dela stavbe";
            dgvd.Columns[5].HeaderText = "   Št. stan.";
            this.dgvd.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void Poisci_lastnike_delov(string vhod)  // vhod = nen_id
        {
            // naloži naslove stavbe v mrežo
            //MessageBox.Show(vhod);
            dgvld.RowHeadersVisible = false;
            string q2 = "select id,nen_id,ime, naslov,delez_str  from tbl_ren_lastniki where nen_id = @idx order by delez_proc desc, leto asc";
            var da4 = new SqlDataAdapter(q2, con2);
            da4.SelectCommand.Parameters.Add("@idx", vhod);
            dt4 = new DataTable();
            da4.Fill(dt4);
            con2.Close();
            dgvld.DataSource = dt4;
            dgvld.ReadOnly = true;
            dgvld.ReadOnly = true;
            dgvld.Columns["nen_id"].Visible = false;
            dgvld.Columns["ime"].Width = 235;
            dgvld.Columns["delez_str"].Width = 80;
            dgvld.Columns["ime"].HeaderText = "Priimek in ime / podjetje";
            dgvld.Columns["delez_str"].HeaderText = "   Del.";
            //dgv2.Columns["delez_str"].
            dgvld.Columns["naslov"].Visible = false;
            dgvld.Columns["id"].Visible = false;
            this.dgvld.Columns["delez_str"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvld.Columns["delez_str"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        private void Nalozi_stavbo(string vhod)
        {
            string q = "select * from tbl_ren_stavbe where sta_sid = @idx"; //+ sort;
            try
            {
                cmd6 = new SqlCommand(q, con6);
                cmd6.Parameters.AddWithValue("@idx", vhod);
                con6.Open();
                rdr6 = cmd6.ExecuteReader();
                while (rdr6.Read())
                {
                    sta_sid = (string)rdr6["sta_sid"];
                    st_stanovanj = Convert.ToString((int)rdr6["st_stanovanj"]);
                    st_poslovnih_prostorov = Convert.ToString((int)rdr6["st_poslovnih_prostorov"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka rdr: " + ex.Message);
            }
            finally
            {
                rdr6.Close();
                con6.Close();
            }

            label13.Text = sta_sid;
            label21.Text = st_stanovanj;
            label18.Text = st_poslovnih_prostorov;
        }
        private void Nalozi_del_stavbe(string id_dela, string nam_raba)
        {
            string st_stanovanja = "";
            string st_etaze = "";
            string st_nadstropja = "";
            double upor_povrsina = 0;
            double tloris = 0;
            double visina = 0;
            string okna = "";
            string inštalacije = "";
            string dst_sid = "";

            string q = "select * from tbl_ren_deli_stavb where id = @idx"; //+ sort;
            try
            {
                //MessageBox.Show(vhod.ToString());
                cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@idx", id_dela);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    st_stanovanja = (string)rdr["stevstan"];
                    st_etaze = (string)rdr["st_etaze"];
                    st_nadstropja = (string)rdr["st_nadstropja"];
                    upor_povrsina = (double)rdr["upor_pov_stan"];
                    tloris = (double)rdr["neto_tloris_pov_dst"];
                    visina = (double)rdr["svetla_visina_etaze"];
                    okna = (string)rdr["leto_obn_oken"];
                    inštalacije = (string)rdr["leto_obn_inst"];
                    dst_sid = (string)rdr["dst_sid"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka rdr: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }

            // najdi naslov
            //label65.Text = nam_raba;
            //label55.Text = st_stanovanja;
            //label61.Text = st_etaze;
            //label62.Text = st_nadstropja;
            //label68.Text = okna;
            //label57.Text = tloris.ToString("N2") + " m2";
            //label58.Text = upor_povrsina.ToString("N2") + " m2";
            //label66.Text = inštalacije;
            //string nen_id_s = st_nen_id(dst_sid);
            //Poisci_lastnike_delov(nen_id_s);
        }


        private void cb_vec_CheckedChanged(object sender, EventArgs e)
        {
            Vpisi_dgv_stavbe();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void dgvs_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            idx_sta = dgvs.Rows[e.RowIndex].Cells[1].Value.ToString();
            int idx_strehe = Convert.ToInt32(dgvs.Rows[e.RowIndex].Cells[0].Value.ToString());
            Nalozi_stavbo(idx_sta);
            Nalozi_strehe_stavbe(idx_strehe);
            Poisci_dele_stavbe(idx_sta);
            Poisci_naslove(idx_sta);
        }

        public frmStrehe()
        {
            InitializeComponent();
        }

        private void frmStrehe_Load(object sender, EventArgs e)
        {
            this.Text = frmMain.nazivPrograma;
            ls.Text = "";
            Strehe();
            Vpisi_dgv_stavbe();

        }


        private string st_nen_id(string vhod)
        // najdi nen_id za del stavbe
        {
            string q9;
            string res = "NA";
            //MessageBox.Show(vhod);
            try
            {
                q9 = "select * from tbl_ren_sestavine where dst_sid = @idx";
                cmd9 = new SqlCommand(q9, con9);
                con9.Open();
                cmd9.Parameters.AddWithValue("@idx", vhod);
                rdr9 = cmd9.ExecuteReader();
                while (rdr9.Read())
                {
                    st_nen = (String)rdr9["nen_id"];  // določi namid stalnega
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Napaka reader: " + ex2.Message);
            }
            finally
            {
                rdr9.Close();
                con9.Close();
            }
            if (st_nen != null)
                res = st_nen;
            return res;
        }

        private void Vpisi_dgv_stavbe()
        {
            dgvs.RowHeadersVisible = false;
            if (cb_vec.Checked)
                    q = "SELECT ren_Strehe.Id, ren_Strehe.SID AS sid, ren_Strehe.OM_naslov AS nasl, tbl_ren_stavbe.st_stanovanj AS stan, tbl_ren_stavbe.st_poslovnih_prostorov AS posl, tbl_ren_stavbe.sta_sid,ren_Strehe.ObjectId FROM ren_Strehe " +
                        "LEFT JOIN tbl_ren_stavbe ON ren_Strehe.SID = tbl_ren_stavbe.sta_sid WHERE(tbl_ren_stavbe.st_stanovanj + tbl_ren_stavbe.st_poslovnih_prostorov > 1) AND (ren_Strehe.Glavna_streha = N'1') order by nasl";
            else
                q = "SELECT ren_Strehe.Id, ren_Strehe.SID AS sid, ren_Strehe.OM_naslov AS nasl, tbl_ren_stavbe.st_stanovanj AS stan, tbl_ren_stavbe.st_poslovnih_prostorov AS posl, tbl_ren_stavbe.sta_sid FROM ren_Strehe " +
                    "LEFT JOIN tbl_ren_stavbe ON ren_Strehe.SID = tbl_ren_stavbe.sta_sid WHERE (ren_Strehe.Glavna_streha = N'1') order by nasl";

            var da = new SqlDataAdapter(q, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dgvs.DataSource = dt;
            dgvs.ReadOnly = true;
            dgvs.Columns[0].Visible = false;
            dgvs.Columns[5].Visible = false;
            dgvs.Columns[1].Width = 80;
            dgvs.Columns[2].Width = 185;
            dgvs.Columns[3].Width = 30;
            dgvs.Columns[4].Width = 30;
            dgvs.Columns[1].HeaderText = "ID";
            dgvs.Columns[2].HeaderText = "Naslov";
            dgvs.Columns[3].HeaderText = "St";
            dgvs.Columns[4].HeaderText = "Po";
            this.dgvs.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvs.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            lstavb.Text = "("+dgvs.Rows.Count.ToString()+")";
        }

        private void Zapisi_OM()
        {
            try
            {
                string query = "Insert into strehe_za_obracun (objectid,sta_sid,hs_mid,lastnik,stanovalec,placnik,cadis,naslov_pl,hs_pl,hd_pl,labela_pl,pt_pl,ptime_pl,drzava_pl,st_prostorov,vecstanovanjska,st_stanovanja,raba_id,raba_ime,n_tloris,n_tloris_skupaj,procent,streha_skupaj,streha_delez,odobreno) " +
                    "values (@objectid,@sta_sid,@hs_mid,@lastnik,@stanovalec,@placnik,@cadis,@naslov_pl,@hs_pl,@hd_pl,@labela_pl,@pt_pl,@ptime_pl,@drzava_pl,@st_prostorov,@vecstanovanjska,@st_stanovanja,@raba_id,@raba_ime,@n_tloris,@n_tloris_skupaj,@procent,@streha_skupaj,@streha_delez,@odobreno)";
                cmd = new SqlCommand(query, con);
                con.Open();

                cmd.Parameters.AddWithValue("@objectid", oobjectid);
                cmd.Parameters.AddWithValue("@sta_sid", osta_sid);
                cmd.Parameters.AddWithValue("@hs_mid", ohs_mid);
                cmd.Parameters.AddWithValue("@lastnik", olastnik);
                cmd.Parameters.AddWithValue("@stanovalec", ostanovalec);
                cmd.Parameters.AddWithValue("@placnik", oplacnik);
                cmd.Parameters.AddWithValue("@cadis", ocadis);
                cmd.Parameters.AddWithValue("@naslov_pl", onaslov_pl);
                cmd.Parameters.AddWithValue("@hs_pl", ohs_pl);
                cmd.Parameters.AddWithValue("@hd_pl", ohd_pl);
                cmd.Parameters.AddWithValue("@labela_pl", olabela_pl);
                cmd.Parameters.AddWithValue("@pt_pl", opt_pl);
                cmd.Parameters.AddWithValue("@ptime_pl", optime_pl);
                cmd.Parameters.AddWithValue("@drzava_pl", odrzava_pl);
                cmd.Parameters.AddWithValue("@st_prostorov", ost_prostorov);
                cmd.Parameters.AddWithValue("@vecstanovanjska", ovecstanovanjska);
                cmd.Parameters.AddWithValue("@st_stanovanja", ost_stanovanja);
                cmd.Parameters.AddWithValue("@raba_id", oraba_id);
                cmd.Parameters.AddWithValue("@raba_ime", oraba_ime);
                cmd.Parameters.AddWithValue("@n_tloris", on_tloris);
                cmd.Parameters.AddWithValue("@n_tloris_skupaj", on_tloris_skupaj);
                cmd.Parameters.AddWithValue("@procent", oprocent);
                cmd.Parameters.AddWithValue("@streha_skupaj", ostreha_skupaj);
                cmd.Parameters.AddWithValue("@streha_delez", ostreha_delez);
                cmd.Parameters.AddWithValue("@odobreno", oodobreno);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka pri pisanju: " + ex.Message);
            }
        }
        private void Izprazni_obracun()
        {
            string query = "delete from strehe_za_obracun";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        private void Pripravi_seznam()

        {

            Izprazni_obracun();
            string q; int stevec=0;
            //MessageBox.Show(vhod);
            try
            {
                q = "select objectid,sid,hsmid_gl,povrsina,om_ime from ren_strehe where (glavna_streha = 1) and (id<900)";
                cmd2 = new SqlCommand(q, con2);
                con2.Open();
                rdr = cmd2.ExecuteReader();
                // while (stevec<100)
                while (rdr.Read())
                {
                    stevec++; ls.Text = stevec.ToString(); ls.Refresh();
                    
                    // preberi vse glavne iz tabele strehe
                    oobjectid = (String)rdr["objectid"];
                    ohs_mid = (String)rdr["hsmid_gl"];
                    osta_sid = (String)rdr["sid"];
                    ocadis = (String)rdr["om_ime"];
                    ostreha_skupaj = (double)rdr["povrsina"];

                    try
                    {
                        // poisci dele stavb in za vsak del z ustrezno rabo napiši en record
                        string q3 = "SELECT tbl_ren_deli_stavb.dst_sid,tbl_ren_deli_stavb.id, ren_Sifranti.ime as ime, tbl_ren_stavbe.sta_sid AS Expr1, tbl_ren_deli_stavb.stevstan AS Expr3, tbl_ren_deli_stavb.stevstan AS st_stan, " +
                        "tbl_ren_deli_stavb.dejanska_raba, tbl_ren_deli_stavb.st_etaze, tbl_ren_deli_stavb.st_nadstropja FROM tbl_ren_stavbe INNER JOIN " +
                        "tbl_ren_deli_stavb ON tbl_ren_stavbe.sta_sid = tbl_ren_deli_stavb.sta_sid INNER JOIN ren_Sifranti ON tbl_ren_deli_stavb.dejanska_raba = ren_Sifranti.idsif " +
                        "WHERE(tbl_ren_stavbe.sta_sid = @idx)";
                        cmd3 = new SqlCommand(q3, con3);
                        cmd3.Parameters.AddWithValue("@idx", osta_sid);
                        con3.Open();
                        rdr3 = cmd3.ExecuteReader();
                        while (rdr3.Read())
                        {
                            //oraba_id=(String)rdr3["raba_id"];
                            oraba_id = (String)rdr3["dejanska_raba"];
                        }
                    }
                    catch (Exception ex2) // q3
                    {
                        MessageBox.Show("Napaka - pripravi seznam " + ex2.Message);
                    }
                    finally
                    {
                        rdr3.Close();
                        con3.Close();
                    }


                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Napaka - pripravi seznam " + ex2.Message);
            }
            finally
            {
                rdr.Close();
                con2.Close();
            }
        }
        private void Variable()
        {
            oobjectid = ""; 
            osta_sid = ""; 
            ohs_mid = ""; 
            olastnik = "";
            ostanovalec = "";
            oplacnik = "";
            ocadis = "";
            onaslov_pl = "";
            ohs_pl = "";
            ohd_pl = "";
            olabela_pl = "";
            opt_pl = "";
            optime_pl = "";
            odrzava_pl = "";
            ost_stanovanja = "";
            oraba_id = "";
            oraba_ime = "";
            ost_prostorov = 0;
            ovecstanovanjska = 0;
            on_tloris = 0;
            on_tloris_skupaj = 0;
            oprocent = 0;
            ostreha_skupaj = 0;
            ostreha_delez = 0;
            oodobreno = 0;

        }
    }
}
