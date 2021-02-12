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
    public partial class frmZK_REN : Form
    {

        SqlConnection con = frmMain.c;
        SqlConnection con2 = frmMain.c2;
        SqlConnection con3 = frmMain.c3;
        SqlDataAdapter adapt;

        SqlCommand cmd;
        SqlDataReader rdr = null;

        SqlCommand cmd2;
        SqlDataReader rdr2 = null;

        SqlCommand cmd3;
        SqlDataReader rdr3 = null;

        static DataTable dt;

        string izbr_ko_id, izbr_ko;

        string parc_st, ko_st, oznaka_parc, pos_list, letnica, stevilka, ozn_nac, povrsina, boniteta, raba_zemljisca, id_postopka, urejenost, stev_stavbe;
        int aktivni_tab;

        private void tb2_TextChanged(object sender, EventArgs e)
        {

        }

        string emso, delez_ste, delez_ime,pos_list2,delez_parcele;
        int idelez_ste, idelez_ime;
        
        public frmZK_REN()
        {
            InitializeComponent();
        }

        private void Cb_ko()  // napolni cb_ko
        {
            q2 = "select * from tblskupinestoritev order by skupina";
            try
            {
                cmd2 = new SqlCommand(q2, con2);
                con2.Open();
                rdr2 = cmd2.ExecuteReader();
                cb1.Items.Clear();
                while (rdr2.Read())
                {
                    string zacasna_skupina = (string)rdr2["Skupina"];
                    int tindeks = (int)rdr2["Indeks"];
                    int tid_indeks = (int)rdr2["Id"];
                    cb1.Items.Add(zacasna_skupina);
                }
                cb1.Items.Add(vse_skupine_storitev);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: dodaj vse skupine v cb1  " + ex.Message);
            }
            finally
            {
                if (rdr2 != null)
                {
                    rdr2.Close();
                }
                if (con2 != null)
                {
                    con2.Close();
                }
            }

        }

        private void Pocisti()
        {
            l5.Text = ""; l6.Text = "";
        }

        private void Pripravi(int vhod)
        {
            panParcela.Visible = true;
        }

        private void frmZK_REN_Load(object sender, EventArgs e)
        {
            aktivni_tab = 4; // po parcelah
            Pripravi(aktivni_tab); // pripravi za po parcelah
            Pocisti();

        }
        
        private void Posestni_list()
        {
            //string q = "select * from tbl_vk5_zk_posest where pos_list = @idx"; //+ sort;
            //try
            //{
            //    cmd = new SqlCommand(q, con);
            //    cmd.Parameters.AddWithValue("@idx", pos_list);
            //    con.Open();
            //    rdr = cmd.ExecuteReader();
            //    while (rdr.Read())
            //    {
            //        emso = (string)rdr["emso"];
            //        idelez_ime = (int)rdr["delez_ime"];
            //        idelez_ste = (int)rdr["delez_ste"];
            //        delez_ime = Convert.ToString(idelez_ime);
            //        delez_ste = Convert.ToString(idelez_ste);
            //        delez_parcele = delez_ste + "/" + delez_ime;
            //        pos_list2 = (string)rdr["pos_list"];
            //        MessageBox.Show(emso + " delež: " + delez_parcele+" Posestni list: "+pos_list2);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Napaka rdr: " + ex.Message);
            //}
            //finally
            //{
            //    rdr.Close();
            //    con.Close();
            //}

            dgv5.RowHeadersVisible = false;

            string q = "select * from tbl_vk5_zk_posest where pos_list = @idx and sif_ko=@idx2";

            var da = new SqlDataAdapter(q, con3);
            da.SelectCommand.Parameters.Add("@idx", pos_list);
            da.SelectCommand.Parameters.Add("@idx2", "0"+ko_st);
            dt = new DataTable();
            da.Fill(dt);
            dgv5.DataSource = dt;
            dgv5.ReadOnly = true;

            //dgv5.Columns[0].Visible = false;
            //dgv5.Columns[1].Visible = false;
            //dgv5.Columns["priimek1"].Width = 170;
            //dgv5.Columns["priimek2"].Width = 100;
            //dgv5.Columns["priimek2"].Visible = false;
            //dgv5.Columns["ime1"].Width = 100;
            //dgv5.Columns["ime2"].Width = 100;
            dgv5.Columns["id"].Visible = false;
            //dgv5.Columns["sif_ko"].Visible = false;
            //dgv5.Columns["parcela"].Width = 200;
            //dgv5.Columns["povrsina"].Width = 80;


        }

        private void Nalozi_parcelo()
        {
            panParcela.Visible = true;
            string q = "select * from tbl_vk6_zk_parcele where id = @idx"; //+ sort;
            try
            {
                cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@idx", frmMain.id_parcele);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    parc_st = (string)rdr["parcela"];
                    ko_st = (string)rdr["sif_ko"];
                    oznaka_parc = (string)rdr["oznaka_parc"];
                    pos_list = (string)rdr["pos_list"];
                    stevilka = (string)rdr["stevilka"];
                    letnica = (string)rdr["letnica"];
                    ozn_nac = (string)rdr["ozn_nac"];
                    povrsina = Convert.ToString((int)rdr["povrsina"]);
                    boniteta = (string)rdr["boniteta"];
                    raba_zemljisca = (string)rdr["raba_zemljisca"];
                    id_postopka = (string)rdr["id_postopka"];
                    urejenost = (string)rdr["urejenost"];
                    stev_stavbe = (string)rdr["stev_stavbe"];
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
            
            l5.Text = parc_st;
            l6.Text = ko_st+" - "+frmMain.ime_ko;
            if (oznaka_parc == "0")
                l7.Text = "0 - Zemljiška parcela";
            else if (oznaka_parc == "1")
                l7.Text = "1 - Stavbna parcela";
            else
                l7.Text = "Neznano";
            l8.Text = pos_list;
            l9.Text = letnica + " (Štev.:" + stevilka + ")";
            if (ozn_nac == "0")
                l10.Text = "0 - Ni nacionalizirano";
            else if (ozn_nac == "1")
                l10.Text = "1 - Nacionalizirano";
            else
                l10.Text = "Neznano";
            l11.Text = povrsina + " m2";
            l12.Text = boniteta;
            if (raba_zemljisca == "220")
                l13.Text = "220 - Zemljišče pod stavbo";
            else if (raba_zemljisca == "221")
                l13.Text = "221 - Zemljišče pod stavbo pred l. 2006";
            else if (raba_zemljisca == "800")
                l13.Text = "800 - Zemljišče";
            else
                l13.Text = "Neznano";
            l14.Text = id_postopka;
            if (urejenost == "0")
                l15.Text = "0 - Neurejena";
            else if (urejenost == "1")
                l15.Text = "1 - Urejena";
            else
                l15.Text = "Neznano";
            l16.Text = stev_stavbe;
            Posestni_list();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmIsci_parc sec = new frmIsci_parc ();
            sec.ShowDialog();

            // MessageBox.Show(Convert.ToString(frmMain.id_parcele));
            
            if (frmMain.id_parcele!=-99)
            {
                Nalozi_parcelo();
            }
        }

        private void frmZK_REN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                frmIsci_parc sec = new frmIsci_parc();
                sec.ShowDialog();

                // MessageBox.Show(Convert.ToString(frmMain.id_parcele));

                if (frmMain.id_parcele != -99)
                {
                    Nalozi_parcelo();
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
