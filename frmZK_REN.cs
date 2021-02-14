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
        SqlConnection con9 = frmMain.c9;
        SqlDataAdapter adapt;

        SqlCommand cmd;
        SqlDataReader rdr = null;

        SqlCommand cmd2;
        SqlDataReader rdr2 = null;

        SqlCommand cmd3;
        SqlDataReader rdr3 = null;

        SqlDataReader rdr9 = null;
        SqlCommand cmd9;

        static DataTable dt,dt2,dt3,dt4;
        
        string izbr_ko_id, izbr_ko;

        string parc_st, ko_st, oznaka_parc, pos_list, letnica, stevilka, ozn_nac, povrsina, boniteta, raba_zemljisca, id_postopka, urejenost, stev_stavbe;
        int aktivni_tab;
        string emso, delez_ste, delez_ime, pos_list2, delez_parcele;
        int idx_parc;
        string pc_mid, x, y, nen_id_p;
        bool aktivno;
        string pc_nen;
        string delez_proc_last, delez_str_last, ime_last, leto_last, naslov_last;
        int idx_last;
        // stavbe
        string sta_sid, st_etaz, st_stanovanj, st_poslovnih_prostorov, id_tip_stavbe, leto_izg_sta, leto_obn_strehe, leto_obn_fasade, stev, idx_hsmid;
        int idx_sta;
        string naslov_stavbe,idx_hise;
        int stalno, zacasno, voda, kanalizacija, greznica, odpadki;

        private void dgvn_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            idx_hise = dgvn.Rows[e.RowIndex].Cells[3].Value.ToString();
            //idx_hsmid = dgv3.Rows[e.RowIndex].Cells[3].Value.ToString();
            Nalozi_naslov(idx_hise);

        }

        private void tpParcele_Click(object sender, EventArgs e)
        {

        }

        private void tpNaslovi_Enter(object sender, EventArgs e)
        {
            Zacetek_naslovi();

        }

        string ko_temp;

        private void dgv2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (aktivno)
            {
                idx_last = Convert.ToInt32(dgv2.Rows[e.RowIndex].Cells[0].Value.ToString());

                Nalozi_lastnika(idx_last);
            }
        }

        private void tpParcele_Enter(object sender, EventArgs e)
        {
            Zacetek_parcele();
        }

        //double x, y;

        private void tb2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                dgv1.Focus();
        }

        private void tbNas_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "naslov LIKE '" + tbNas.Text + "%'";
            dgv3.DataSource = dv;

        }

        private void tbNas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                dgv3.Focus();
        }

        private void dgv3_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            idx_sta = Convert.ToInt32(dgv3.Rows[e.RowIndex].Cells[1].Value.ToString());
            idx_hsmid = dgv3.Rows[e.RowIndex].Cells[3].Value.ToString();
            Nalozi_stavbo(idx_sta);

        }

        private void dgv1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (aktivno)
            {
                idx_parc = Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells[0].Value.ToString());

                Nalozi_parcelo(idx_parc);
            }
        }

        private void cbKo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // menjaj dgv1
            tb2.Text = "";
            aktivno = false;
            Vpisi_dgv_parcele();
            aktivno = true;
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
            }
            cbKo.DataSource = koDict.ToArray();
            cbKo.DisplayMember = "Value";
            cbKo.ValueMember = "Key";
        }

        private void Pocisti()
        {
            l5.Text = ""; l6.Text = "";
        }

        private void Pripravi(int vhod)
        {
            if (vhod == 4) // parcele
            {
                //aktivno = false;
                //Cb_ko();
                //Vpisi_dgv_parcele();
            }
        }

        private string pc_nen_id(string vhod)
        // najdi nen_id za parcelo
        {
            string q9;
            string res = "NA";

            try
            {
                q9 = "select * from tbl_ren_sestavine where pc_mid = @idx";
                cmd9 = new SqlCommand(q9, con9);
                con9.Open();
                cmd9.Parameters.AddWithValue("@idx", vhod);
                rdr9 = cmd9.ExecuteReader();
                while (rdr9.Read())
                {
                    pc_nen = (String)rdr9["nen_id"];  // določi namid stalnega
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
            if (pc_nen != null)
                res = pc_nen;
            return res;
        }

        //private string Stavba_p(string vhod)
        //{

        //    string q9;
        //    string res = "";
        //    ko_temp = "Ni zadetka";
        //    try
        //    {
        //        q9 = "select hsmid, naslov,labela,pt_stev,posta from tbl_hise where hsmid = @idx";
        //        cmd9 = new SqlCommand(q9, con9);
        //        cmd9.Parameters.AddWithValue("@idx", vhod);
        //        con9.Open();
        //        rdr9 = cmd9.ExecuteReader();
        //        while (rdr9.Read())
        //        {
        //            string nas = (String)rdr9["naslov"];  // določi namid stalnega
        //            string lab = (String)rdr9["labela"];
        //            string pt = (String)rdr9["pt_stev"];
        //            string posta = (String)rdr9["posta"];
        //            int stalno = (int)rdr9["stalno"];
        //            int zacasno = (int)rdr9["zacasno"];
        //            int skupaj = stalno + zacasno;

        //            if (vrsta == "naslov")
        //                ko_temp = nas + " " + lab + ", " + pt + " " + posta;
        //            if (vrsta == "prebivalci")
        //            {
        //                ko_temp = Convert.ToString(skupaj) + " (" + Convert.ToString(zacasno) + " začasno)";
        //            }
        //            if (vrsta == "storitve")
        //                ko_temp = nas + " " + lab + ", " + pt + " " + posta;

        //        }
        //    }
        //    catch (Exception ex2)
        //    {
        //        MessageBox.Show("Napaka reader: " + ex2.Message);
        //    }
        //    finally
        //    {
        //        rdr9.Close();
        //        con9.Close();
        //    }
        //    if (ko_temp != null)
        //        res = ko_temp;
        //    return res;
        //}

        private void Stavba(string vhod)  // vrni podatke o naslovu
        {
            string q9;
            try
            {
                q9 = "select * from tbl_hise where hsmid = @idx";
                cmd9 = new SqlCommand(q9, con9);
                cmd9.Parameters.AddWithValue("@idx", vhod);
                con9.Open();
                rdr9 = cmd9.ExecuteReader();
                while (rdr9.Read())
                {
                    string nas = (String)rdr9["naslov"];  // določi namid stalnega
                    string lab = (String)rdr9["labela"];
                    string pt = (String)rdr9["pt_stev"];
                    string posta = (String)rdr9["posta"];
                    stalno = (int)rdr9["stalno"];
                    zacasno = (int)rdr9["zacasno"];
                    voda = (int)rdr9["voda"];
                    kanalizacija = (int)rdr9["kanalizacija"];
                    greznica = (int)rdr9["greznica"];
                    odpadki = (int)rdr9["smeti"];
                    naslov_stavbe = nas + " " + lab + ", " + pt + " " + posta;
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
        }

        private void Nalozi_naslov(string vhod1)
        {
            label35.Text = ""; label17.Text = ""; label2.Text = ""; label48.Text = ""; label50.Text = "";
            Stavba(vhod1);
            int preb = stalno + zacasno;
            string preb_temp = preb.ToString() + "  (" + zacasno.ToString() + ")";
            label17.Text = preb_temp;
            label35.Text = naslov_stavbe;
            if (voda == 1) label6.Text = "da";
            if (kanalizacija == 1) label2.Text = "da";
            if (odpadki == 1) label50.Text = "da";
            if (greznica == 1) label48.Text = "da";
        }

        private string ko_ime(string vhod)
        // naziv KO
        {
            
            string q9;
            string res = "";
            ko_temp = "Ni zadetka";
            try
            {
                q9 = "select * from tbl_ko where ko_id = @idx";
                cmd9 = new SqlCommand(q9, con9);
                cmd9.Parameters.AddWithValue("@idx", vhod);
                con9.Open();
                rdr9 = cmd9.ExecuteReader();
                while (rdr9.Read())
                {
                    ko_temp = (String)rdr9["ko_ime"];  // določi namid stalnega
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
            if (ko_temp != null)
                res = ko_temp;
            return res;
        }
        private void Vpisi_dgv_naslove()
        {
            //izbr_ko_id = ((KeyValuePair<string, string>)cbKo.SelectedItem).Key;

            dgv3.RowHeadersVisible = false;

            //var da = new SqlDataAdapter(q, con3);
            q = "SELECT tbl_ren_stavba_naslovi.Id, tbl_ren_stavba_naslovi.sta_sid, tbl_hise.naslov, tbl_ren_stavba_naslovi.hs_mid, tbl_hise.labela " +
                "FROM tbl_hise INNER JOIN tbl_ren_stavba_naslovi ON tbl_hise.hsmid = tbl_ren_stavba_naslovi.hs_mid order by tbl_hise.naslov, tbl_hise.labela";
            var da = new SqlDataAdapter(q, con3);
            dt = new DataTable();
            da.Fill(dt);
            dgv3.DataSource = dt;
            dgv3.ReadOnly = true;
            dgv3.Columns[0].Visible = false;
            dgv3.Columns[1].Visible = false;
            
            //dgv1.Columns["povrsina"].Visible = false;
            dgv3.Columns[2].Width = 150;
            dgv3.Columns[3].Visible = false;
            dgv3.Columns[4].Width = 68;
            //dgv1.Columns["ko_sifko"].Width = 60;
            ////dgv1.Columns["povrsina"].Width = 60;
            //dgv1.Columns["ko_sifko"].HeaderText = "KO";
            dgv3.Columns[2].HeaderText = "Naslov";
            dgv3.Columns[4].HeaderText = "     HŠ";
            this.dgv3.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

            private void Vpisi_dgv_parcele()
        {
            izbr_ko_id= ((KeyValuePair<string, string>)cbKo.SelectedItem).Key;
            
            dgv1.RowHeadersVisible = false;

            //var da = new SqlDataAdapter(q, con3);
            if (izbr_ko_id=="0") // prikaži parcele za vse ko
            {
                q = "select id,parcela,ko_sifko from tbl_ren_parcele order by parcela asc, ko_sifko";
                var da = new SqlDataAdapter(q, con3);
                dt = new DataTable();
                da.Fill(dt);
                dgv1.DataSource = dt;
                dgv1.ReadOnly = true;
                dgv1.Columns["id"].Visible = false;
                //dgv1.Columns["povrsina"].Visible = false;
                dgv1.Columns["parcela"].Width = 90;
                dgv1.Columns["ko_sifko"].Width = 60;
                //dgv1.Columns["povrsina"].Width = 60;
                dgv1.Columns["ko_sifko"].HeaderText = "KO";
                dgv1.Columns["parcela"].HeaderText = "Parcela";
                //dgv1.Columns["povrsina"].HeaderText = "Površina";
            }
            else
            {
                q = "select id,parcela,ko_sifko from tbl_ren_parcele where ko_sifko=@idx order by parcela asc";
                var da = new SqlDataAdapter(q, con3);
                da.SelectCommand.Parameters.Add("@idx", izbr_ko_id);
                dt = new DataTable();
                da.Fill(dt);
                dgv1.DataSource = dt;
                dgv1.ReadOnly = true;
                dgv1.Columns["id"].Visible = false;
                dgv1.Columns["parcela"].Width = 90;
                dgv1.Columns["ko_sifko"].Width = 60;
                dgv1.Columns["ko_sifko"].HeaderText = "KO";
                dgv1.Columns["parcela"].HeaderText = "Parcela";
            }
            aktivno = true;
            //this.dgv5.Columns["labela"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tb2.Focus();
        }

        private void Zacetek_parcele()
        {
            aktivni_tab = 4;
            aktivno = false;
            // Cb_ko();
            Vpisi_dgv_parcele();
            Pocisti();

            // id prvega zapisa
            q = "select * FROM tbl_ren_parcele order by parcela asc";
            cmd = new SqlCommand(q, con);
            con.Open();
            int prvi_z = (int)cmd.ExecuteScalar();
            con.Close();
           
            Nalozi_parcelo(prvi_z);  // samo prvič
            tb2.Focus();
        }

        private void Zacetek_naslovi()
        {
            aktivni_tab = 1;
            aktivno = false;
            // Cb_ko();
            Vpisi_dgv_naslove();
            dgv3.Refresh();
            //tbNas.Text = "a";
            
            //Pocisti();

            //// id prvega zapisa
            //q = "select * FROM tbl_ren_parcele order by parcela asc";
            //cmd = new SqlCommand(q, con);
            //con.Open();
            //int prvi_z = (int)cmd.ExecuteScalar();
            //con.Close();

            //Nalozi_parcelo(prvi_z);  // samo prvič
            tbNas.Focus();

        }

        private void frmZK_REN_Load(object sender, EventArgs e)
        {
            //aktivni_tab = 4; // po parcelah
            Cb_ko();
            Zacetek_naslovi();
            aktivni_tab = 1;
            tbNas.Focus();
            //this.tc.SelectedTab = this.tpParcele;
            //this.tc.SelectedTab = this.tpNaslovi;
        }

        private void Lastnik_parcele(string vhod)
        {
            // naloži lastnike v mrežo
            dgv2.RowHeadersVisible = false;
            string q2 = "select id,nen_id,ime, naslov,delez_str  from tbl_ren_lastniki where nen_id = @idx order by delez_proc desc, leto asc";
            var da2 = new SqlDataAdapter(q2, con2);
            da2.SelectCommand.Parameters.Add("@idx", vhod);
            dt2 = new DataTable();
            da2.Fill(dt2);
            dgv2.DataSource = dt2;
            dgv2.ReadOnly = true;
            dgv2.Columns["nen_id"].Visible = false;
            dgv2.Columns["ime"].Width = 400;
            dgv2.Columns["naslov"].Width = 300;
            dgv2.Columns["delez_str"].Width = 60;
            dgv2.Columns["ime"].HeaderText = "Priimek in ime / podjetje";
            dgv2.Columns["naslov"].HeaderText = "Naslov";
            dgv2.Columns["delez_str"].HeaderText = "Del.";
            //dgv2.Columns["delez_str"].
            dgv2.Columns["naslov"].Visible = false;
            dgv2.Columns["id"].Visible = false;
            this.dgv2.Columns["delez_str"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv2.Columns["delez_str"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void Poisci_naslove (string vhod)
        {
            // naloži naslove stavbe v mrežo
            dgvn.RowHeadersVisible = false;
            string q2 = "SELECT tbl_hise.naslov AS nas, tbl_hise.labela AS lab, tbl_ren_stavba_naslovi.sta_sid AS stasid, tbl_ren_stavba_naslovi.hs_mid " +
                "AS hsmid FROM tbl_ren_stavba_naslovi INNER JOIN tbl_hise ON tbl_ren_stavba_naslovi.hs_mid = tbl_hise.hsmid WHERE(tbl_ren_stavba_naslovi.sta_sid = @idx)";
            var da2 = new SqlDataAdapter(q2, con2);
            da2.SelectCommand.Parameters.Add("@idx", vhod);
            dt2 = new DataTable();
            da2.Fill(dt2);
            dgvn.DataSource = dt2;
            dgvn.ReadOnly = true;
            dgvn.Columns[2].Visible = false;
            dgvn.Columns[3].Visible = false;
            dgvn.Columns[0].Width = 230;
            dgvn.Columns[1].Width = 80;
            dgvn.Columns[0].HeaderText = "Naslov";
            dgvn.Columns[1].HeaderText = "      HŠ";
            this.dgvn.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void Poisci_dele_stavb(string vhod)
        {
            // naloži naslove stavbe v mrežo
            dgvd.RowHeadersVisible = false;
            string q2 = "SELECT tbl_hise.naslov AS nas, tbl_hise.labela AS lab, tbl_ren_stavba_naslovi.sta_sid AS stasid, tbl_ren_stavba_naslovi.hs_mid " +
                "AS hsmid FROM tbl_ren_stavba_naslovi INNER JOIN tbl_hise ON tbl_ren_stavba_naslovi.hs_mid = tbl_hise.hsmid WHERE(tbl_ren_stavba_naslovi.sta_sid = @idx)";
            var da3 = new SqlDataAdapter(q2, con2);
            da3.SelectCommand.Parameters.Add("@idx", vhod);
            dt3 = new DataTable();
            da3.Fill(dt3);
            dgvd.DataSource = dt3;
            dgvd.ReadOnly = true;
            dgvd.Columns[2].Visible = false;
            dgvd.Columns[3].Visible = false;
            dgvd.Columns[0].Width = 230;
            dgvd.Columns[1].Width = 80;
            dgvd.Columns[0].HeaderText = "Naslov";
            dgvd.Columns[1].HeaderText = "      HŠ";
            this.dgvd.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void Poisci_lastnike_delov(string vhod)
        {
            // naloži naslove stavbe v mrežo
            dgvn.RowHeadersVisible = false;
            string q2 = "SELECT tbl_hise.naslov AS nas, tbl_hise.labela AS lab, tbl_ren_stavba_naslovi.sta_sid AS stasid, tbl_ren_stavba_naslovi.hs_mid " +
                "AS hsmid FROM tbl_ren_stavba_naslovi INNER JOIN tbl_hise ON tbl_ren_stavba_naslovi.hs_mid = tbl_hise.hsmid WHERE(tbl_ren_stavba_naslovi.sta_sid = @idx)";
            var da2 = new SqlDataAdapter(q2, con2);
            da2.SelectCommand.Parameters.Add("@idx", vhod);
            dt2 = new DataTable();
            da2.Fill(dt2);
            dgvn.DataSource = dt2;
            dgvn.ReadOnly = true;
            dgvn.Columns[2].Visible = false;
            dgvn.Columns[3].Visible = false;
            dgvn.Columns[0].Width = 230;
            dgvn.Columns[1].Width = 80;
            dgvn.Columns[0].HeaderText = "Naslov";
            dgvn.Columns[1].HeaderText = "      HŠ";
            this.dgvn.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        private void Nalozi_stavbo(int vhod)
        {
            string q = "select * from tbl_ren_stavbe where sta_sid = @idx"; //+ sort;
            try
            {
                //MessageBox.Show(vhod.ToString());
                cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@idx", vhod);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    sta_sid = (string)rdr["sta_sid"];
                    stev = (string)rdr["stev"];
                    st_etaz=Convert.ToString((int)rdr["st_etaz"]);
                    st_stanovanj= Convert.ToString((int)rdr["st_stanovanj"]);
                    st_poslovnih_prostorov = Convert.ToString((int)rdr["st_poslovnih_prostorov"]);
                    leto_izg_sta = (string)rdr["leto_izg_sta"];
                    leto_obn_fasade = (string)rdr["leto_obn_fasade"];
                    leto_obn_strehe = (string)rdr["leto_obn_strehe"];
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
            label13.Text = sta_sid;
            label36.Text = stev;
            label20.Text = st_etaz;
            label21.Text = st_stanovanj;
            label18.Text = st_poslovnih_prostorov;
            label39.Text = leto_izg_sta;
            label38.Text = leto_obn_strehe;
            label42.Text = leto_obn_fasade;
            Poisci_naslove(sta_sid);
            Poisci_dele_stavbe(sta_sid);
        }


        private void Nalozi_parcelo(int vhod)
        {
            string q = "select * from tbl_ren_parcele where id = @idx"; //+ sort;
            try
            {
                cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@idx", vhod);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    parc_st = (string)rdr["parcela"];
                    ko_st = (string)rdr["ko_sifko"];
                    povrsina = Convert.ToString((double)rdr["povrsina"]);
                    boniteta = (string)rdr["boniteta"];
                    x = Convert.ToString((double)rdr["x"]);
                    y = Convert.ToString((double)rdr["y"]);
                    pc_mid = (string)rdr["pc_mid"];
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
            //dgv1.Refresh();
            string kotemp;
            kotemp = "ni";
            kotemp = ko_ime(ko_st);
            //MessageBox.Show(parc_st);
            l5.Text = parc_st;
            l6.Text = ko_st + " - " + kotemp;
            l11.Text = povrsina + " m2";
            l12.Text = pc_mid;
            l13.Text = x;
            l14.Text = y;
            nen_id_p = pc_nen_id(pc_mid);
            l15.Text = nen_id_p;
            Lastnik_parcele(nen_id_p);
            //l5.Refresh();

            //l12.Text = boniteta;
        }
        private void Nalozi_lastnika(int vhod)
        {
            string delez="";
            string q = "select * from tbl_ren_lastniki where id = @idx"; //+ sort;
            try
            {
                cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@idx", vhod);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ime_last = (string)rdr["ime"];
                    naslov_last = (string)rdr["naslov"];
                    leto_last = (string)rdr["leto"];
                    delez_str_last = (string)rdr["delez_str"];
                    delez_proc_last = string.Format("{0:F2}", (double)rdr["delez_proc"]);
                    delez_proc_last = delez_proc_last + " %";
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
            delez = delez_str_last + "     (" + delez_proc_last + ")";
            label28.Text = ime_last;
            label16.Text = naslov_last;
            label19.Text = leto_last;
            label15.Text = delez;
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
