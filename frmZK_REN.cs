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
        static DataTable dt2;

        string izbr_ko_id, izbr_ko;

        string parc_st, ko_st, oznaka_parc, pos_list, letnica, stevilka, ozn_nac, povrsina, boniteta, raba_zemljisca, id_postopka, urejenost, stev_stavbe;
        int aktivni_tab;
        string emso, delez_ste, delez_ime, pos_list2, delez_parcele;
        int idx_parc;

        private void tb2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                dgv1.Focus();
        }

        private void dgv1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            idx_parc = Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Nalozi_parcelo(idx_parc);
        }

        private void cbKo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // menjaj dgv1
            tb2.Text = "";
            Vpisi_dgv_parcele();
        }

        int idelez_ste, idelez_ime;
        string q, q2;

        Dictionary<string, string> koDict = new Dictionary<string, string>();

        private void tb2_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "parcela LIKE '" + tb2.Text + "%'";
            dgv1.DataSource = dv;
        }


        public frmZK_REN()
        {
            InitializeComponent();
        }

        private void Cb_ko()  // napolni cb_ko
        {
            string q = "select * from tbl_ko order by ko_id";
            try
            {
                cmd2 = new SqlCommand(q, con2);
                con2.Open();
                rdr2 = cmd2.ExecuteReader();
                cbKo.Items.Clear();
                koDict.Add("0", "Vse KO");
                while (rdr2.Read())
                {
                    string ko_id = (string)rdr2["ko_id"];
                    string ko_ime = (string)rdr2["ko_ime"];
                    int tid = (int)rdr2["Id"];
                    koDict.Add(ko_id, ko_id + " - " + ko_ime);
                }
                //cbKo.Items.Add("Vse KO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: dodaj vse skupine v cb1  " + ex.Message);
            }
            finally
            {
                rdr2.Close();
                con2.Close();
                cbKo.DataSource = koDict.ToArray();
                cbKo.DisplayMember = "Value";
                cbKo.ValueMember = "Key";
            }
        }

        private void Pocisti()
        {
            l5.Text = ""; l6.Text = "";
        }

        private void Pripravi(int vhod)
        {
            if (vhod == 4) // parcele
            {
                Cb_ko();
                Vpisi_dgv_parcele();
            }
        }

        private void Vpisi_dgv_parcele()
        {
            izbr_ko_id= ((KeyValuePair<string, string>)cbKo.SelectedItem).Key;
            
            dgv1.RowHeadersVisible = false;

            //var da = new SqlDataAdapter(q, con3);
            if (izbr_ko_id=="0") // prikaži parcele za vse ko
            {
                q = "select id,parcela,povrsina,sif_ko from tbl_vk6_zk_parcele order by parcela asc, sif_ko, povrsina desc";
                var da = new SqlDataAdapter(q, con3);
                dt = new DataTable();
                da.Fill(dt);
                dgv1.DataSource = dt;
                dgv1.ReadOnly = true;
                dgv1.Columns["id"].Visible = false;
                dgv1.Columns["povrsina"].Visible = false;
                dgv1.Columns["parcela"].Width = 90;
                dgv1.Columns["sif_ko"].Width = 60;
                dgv1.Columns["povrsina"].Width = 60;
                dgv1.Columns["sif_ko"].HeaderText = "KO";
                dgv1.Columns["parcela"].HeaderText = "Parcela";
                dgv1.Columns["povrsina"].HeaderText = "Površina";
            }
            else
            {
                q = "select id,parcela,povrsina,sif_ko from tbl_vk6_zk_parcele where sif_ko=@idx order by parcela asc, povrsina desc";
                var da = new SqlDataAdapter(q, con3);
                da.SelectCommand.Parameters.Add("@idx", izbr_ko_id);
                dt = new DataTable();
                da.Fill(dt);
                dgv1.DataSource = dt;
                dgv1.ReadOnly = true;
                dgv1.Columns["id"].Visible = false;
                dgv1.Columns["povrsina"].Visible = false;
                dgv1.Columns["parcela"].Width = 90;
                dgv1.Columns["sif_ko"].Width = 60;
                dgv1.Columns["povrsina"].Width = 60;
                dgv1.Columns["sif_ko"].HeaderText = "KO";
                dgv1.Columns["parcela"].HeaderText = "Parcela";
                dgv1.Columns["povrsina"].HeaderText = "Površina";
            }

            //this.dgv5.Columns["labela"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tb2.Focus();
        }


        private void frmZK_REN_Load(object sender, EventArgs e)
        {
            aktivni_tab = 4; // po parcelah
            this.tc.SelectedTab = this.tpParcele;
            Pripravi(aktivni_tab); // pripravi za po parcelah
            Pocisti();
            tb2.Focus();
        }

        private void Lastnik()
        {
            string q = "select * from tbl_vk5_zk_posest where pos_list = @idx and sif_ko=@idx2";
            try
            {
                cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@idx", pos_list);
                cmd.Parameters.AddWithValue("@idx2", ko_st);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    emso = (string)rdr["emso"];

                    // naloži lastnike v mrežo
                    dgv2.RowHeadersVisible = false;
                    string q2 = "select * from tbl_vk1_zk_osebe where emso = @idx_emso";
                    var da2 = new SqlDataAdapter(q2, con2);
                    da2.SelectCommand.Parameters.Add("@idx_emso", emso);
                    //da2.SelectCommand.Parameters.Add("@idx2", "0" + ko_st);
                    dt2 = new DataTable();
                    da2.Fill(dt2);
                    dgv2.DataSource = dt2;
                    dgv2.ReadOnly = true;

                    //dgv5.Columns[0].Visible = false;
                    //dgv5.Columns[1].Visible = false;
                    //dgv5.Columns["priimek1"].Width = 170;
                    //dgv5.Columns["priimek2"].Width = 100;
                    //dgv5.Columns["priimek2"].Visible = false;
                    //dgv5.Columns["ime1"].Width = 100;
                    //dgv5.Columns["ime2"].Width = 100;
                    dgv2.Columns["id"].Visible = false;


                    idelez_ime = (int)rdr["delez_ime"];
                    idelez_ste = (int)rdr["delez_ste"];
                    delez_ime = Convert.ToString(idelez_ime);
                    delez_ste = Convert.ToString(idelez_ste);
                    delez_parcele = delez_ste + "/" + delez_ime;
                    pos_list2 = (string)rdr["pos_list"];
                    //MessageBox.Show(emso + " delež: " + delez_parcele + " Posestni list: " + pos_list2);
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
        }

        private void Posestni_list()
        {
            dgv5.RowHeadersVisible = false;
            string q5 = "select * from tbl_vk5_zk_posest where pos_list = @idx and sif_ko=@idx2";
            var da = new SqlDataAdapter(q5, con3);
            da.SelectCommand.Parameters.Add("@idx", pos_list);
            da.SelectCommand.Parameters.Add("@idx2", ko_st);
            dt = new DataTable();
            da.Fill(dt);
            dgv5.DataSource = dt;
            dgv5.ReadOnly = true;
            dgv5.Columns["id"].Visible = false;
        }

        private void Nalozi_parcelo(int vhod)
        {
            string q = "select * from tbl_vk6_zk_parcele where id = @idx"; //+ sort;
            try
            {
                cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@idx", vhod);
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
            //l16.Text = stev_stavbe;
            Posestni_list();
            Lastnik();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmIsci_parc sec = new frmIsci_parc ();
            sec.ShowDialog();

            // MessageBox.Show(Convert.ToString(frmMain.id_parcele));
            
            if (frmMain.id_parcele!=-99)
            {
               // Nalozi_parcelo();
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
                 //   Nalozi_parcelo();
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
