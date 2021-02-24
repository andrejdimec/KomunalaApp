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
using System.IO;

namespace Komunala
{
    public partial class frmZK_REN : Form
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
        string idx_dela_stavbe, st_nen;
        int stevec;
        string sp = " ";
        string str_stevec, napisi, opomba,lastnik;
        List<string> izvoz_vrsta = new List<string>();
        private const char tab = ';';




        private void dgvd_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            idx_dela_stavbe = dgvd.Rows[e.RowIndex].Cells[0].Value.ToString();
            string idx_nam_raba = dgvd.Rows[e.RowIndex].Cells[1].Value.ToString();
            Nalozi_del_stavbe(idx_dela_stavbe,idx_nam_raba);
        }

        private void dgvld_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            idx_last = Convert.ToInt32(dgvld.Rows[e.RowIndex].Cells[0].Value.ToString());
            Nalozi_lastnika_dela_stavbe(idx_last);
        }

        private void tpNaslovi_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void Izvoz(string datoteka)
        {
            StreamWriter w = new StreamWriter(new FileStream(datoteka, FileMode.Create, FileAccess.Write));
            stevec = 0;
            w.WriteLine(sp);
            w.WriteLine("Seznam za obračun odvajanja padavinske vode s streh");
            w.WriteLine(sp);
            izvoz_vrsta.Clear();
            Seznam_izvoz();
            //            izvoz_vrsta.Sort();
            stevec = 1;
            w.WriteLine("Zap." + tab + "PC_MID" + tab + "Lastnik");
            foreach (string zactmp in izvoz_vrsta)
            {
                str_stevec = Convert.ToString(stevec);
                napisi = str_stevec + tab + zactmp;
                w.WriteLine(napisi);
                stevec++;
            }
            w.WriteLine(sp);
            w.Close();
        }

        // naredi seznam parcel za izvoz
        private void Seznam_izvoz()
        {
            int stev = 0;
            string q = "select pc_mid from tbl_ren_parcele";
            try
            {
                cmd = new SqlCommand(q, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    stev++;
                    lst.Text = stev.ToString();
                    lst.Refresh();
                    pc_mid = (string)rdr["pc_mid"];
                    nen_id_p = pc_nen_id(pc_mid);

                    // poišči lastnika z največjim deležem
                    try
                    {
                        string q6 = "select ime from tbl_ren_lastniki where nen_id = @idx order by delez_proc desc, leto asc";
                        cmd6 = new SqlCommand(q6, con6);
                        con6.Open();
                        cmd6.Parameters.AddWithValue("@idx", nen_id_p);
                        rdr6 = cmd6.ExecuteReader();
                        int prvi = 0;
                        while (rdr6.Read())
                        {
                            string temp_lastnik = (String)rdr6["ime"];
                            if (prvi == 0)
                                lastnik = temp_lastnik;
                            prvi++;
                        }
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show("Napaka reader: " + ex2.Message);
                    }
                    finally
                    {
                        rdr6.Close();
                        con6.Close();
                    }
                    string vrsta = pc_mid + tab + lastnik;
                    izvoz_vrsta.Add(vrsta);
                    stevec++;
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
            lst.Text = "OK";
        }




        private void button3_Click_1(object sender, EventArgs e)
        {
            // izvoz za kataster
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "Seznam parcel z lastniki.csv";

            save.Filter = "Ločeno s podpičjem | *.csv";

            if (save.ShowDialog() == DialogResult.OK)
                Izvoz(save.FileName);

        }

        private void dgvn_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            idx_hise = dgvn.Rows[e.RowIndex].Cells[3].Value.ToString();
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
                q9 = "select nen_id from tbl_ren_sestavine where pc_mid = @idx";
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

        private string st_nen_id(string vhod)
        // najdi nen_id za del stavbe
        {
            string q9;
            string res = "NA";

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
            if (voda == 1) 
                label6.Text = "da";
                    else 
                label6.Text ="";
            if (kanalizacija == 1) 
                label2.Text = "da";
            else
                label2.Text = "";
            if (odpadki == 1) 
                label50.Text = "da";
            else
                label50.Text = "";
            if (greznica == 1) 
                label48.Text = "da";
            else
                label48.Text = "";
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
            con3.Close();
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
                con3.Close();
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
                con3.Close();
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
            this.BackColor = frmMain.barva_form_back; // Form ozadje
            this.Text = frmMain.nazivPrograma; // Form tekst
            lpodatki.Text = "Podatki: "+frmMain.podatki_ren;
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
            con2.Close();
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
            con2.Close();
            dgvn.DataSource = dt2;
            dgvn.ReadOnly = true;
            dgvn.Columns[2].Visible = false;
            dgvn.Columns[3].Visible = false;
            dgvn.Columns[0].Width = 295;
            dgvn.Columns[1].Width = 80;
            dgvn.Columns[0].HeaderText = "Naslov";
            dgvn.Columns[1].HeaderText = "      HŠ";
            this.dgvn.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void Poisci_dele_stavbe(string vhod)  // con2
        {
            // naloži naslove stavbe v mrežo
            dgvd.RowHeadersVisible = false;

            string q3 = "SELECT tbl_ren_deli_stavb.id, ren_Sifranti.ime as ime, tbl_ren_stavbe.sta_sid AS Expr1, tbl_ren_deli_stavb.stevstan AS Expr3, tbl_ren_deli_stavb.stevstan AS st_stan, " +
                "tbl_ren_deli_stavb.dejanska_raba, tbl_ren_deli_stavb.st_etaze, tbl_ren_deli_stavb.st_nadstropja FROM tbl_ren_stavbe INNER JOIN " +
                "tbl_ren_deli_stavb ON tbl_ren_stavbe.sta_sid = tbl_ren_deli_stavb.sta_sid INNER JOIN ren_Sifranti ON tbl_ren_deli_stavb.dejanska_raba = ren_Sifranti.idsif " +
                "WHERE(tbl_ren_stavbe.sta_sid = @idx) order by ime desc, st_stan asc";
            //string q2 = "SELECT tbl_hise.naslov AS nas, tbl_hise.labela AS lab, tbl_ren_stavba_naslovi.sta_sid AS stasid, tbl_ren_stavba_naslovi.hs_mid " +
            //    "AS hsmid FROM tbl_ren_stavba_naslovi INNER JOIN tbl_hise ON tbl_ren_stavba_naslovi.hs_mid = tbl_hise.hsmid WHERE(tbl_ren_stavba_naslovi.sta_sid = @idx)";
            var da3 = new SqlDataAdapter(q3, con6);
            da3.SelectCommand.Parameters.Add("@idx", vhod);
            dt3 = new DataTable();
            da3.Fill(dt3);
            con6.Close();
            dgvd.DataSource = dt3;
            dgvd.ReadOnly = true;
            //dgvd.Columns[].Visible = false;
            dgvd.Columns[0].Visible = false;
            dgvd.Columns[2].Visible = false;
            dgvd.Columns[3].Visible = false;
            //dgvd.Columns[3].Visible = false;
            dgvd.Columns[1].Width = 295;
            dgvd.Columns[2].Width = 80;
            dgvd.Columns[1].HeaderText = "Dejanska raba dela stavbe";
            dgvd.Columns[4].HeaderText = "   Št. stan.";
            this.dgvd.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void Poisci_lastnike_delov(string vhod)  // vhod = nen_id
        {
            // naloži naslove stavbe v mrežo
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
            dgvld.Columns["ime"].Width = 295;
            dgvld.Columns["delez_str"].Width = 80;
            dgvld.Columns["ime"].HeaderText = "Priimek in ime / podjetje";
            dgvld.Columns["delez_str"].HeaderText = "   Del.";
            //dgv2.Columns["delez_str"].
            dgvld.Columns["naslov"].Visible = false;
            dgvld.Columns["id"].Visible = false;
            this.dgvld.Columns["delez_str"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvld.Columns["delez_str"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        private void Nalozi_stavbo(int vhod)
        {
            string q = "select * from tbl_ren_stavbe where sta_sid = @idx"; //+ sort;
            try
            {
                //MessageBox.Show(vhod.ToString());
                cmd6 = new SqlCommand(q, con6);
                cmd6.Parameters.AddWithValue("@idx", vhod);
                con6.Open();
                rdr6 = cmd6.ExecuteReader();
                while (rdr6.Read())
                {
                    sta_sid = (string)rdr6["sta_sid"];
                    stev = (string)rdr6["stev"];
                    st_etaz=Convert.ToString((int)rdr6["st_etaz"]);
                    st_stanovanj= Convert.ToString((int)rdr6["st_stanovanj"]);
                    st_poslovnih_prostorov = Convert.ToString((int)rdr6["st_poslovnih_prostorov"]);
                    leto_izg_sta = (string)rdr6["leto_izg_sta"];
                    leto_obn_fasade = (string)rdr6["leto_obn_fasade"];
                    leto_obn_strehe = (string)rdr6["leto_obn_strehe"];
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

            // najdi naslov
            label13.Text = sta_sid;
            label36.Text = stev;
            label20.Text = st_etaz;
            label21.Text = st_stanovanj;
            label18.Text = st_poslovnih_prostorov;
            label70.Text = leto_izg_sta;
            label38.Text = leto_obn_strehe;
            label42.Text = leto_obn_fasade;
            label39.Text = "";
            Poisci_naslove(sta_sid);
            Poisci_dele_stavbe(sta_sid);
        }
        private void Nalozi_del_stavbe(string id_dela, string nam_raba )
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
                    st_etaze=(string)rdr["st_etaze"];
                    st_nadstropja= (string)rdr["st_nadstropja"];
                    upor_povrsina= (double)rdr["upor_pov_stan"];
                    tloris= (double)rdr["neto_tloris_pov_dst"];
                    visina= (double)rdr["svetla_visina_etaze"];
                    okna= (string)rdr["leto_obn_oken"];
                    inštalacije= (string)rdr["leto_obn_inst"];
                    dst_sid= (string)rdr["dst_sid"];
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
            label65.Text = nam_raba;
            label55.Text = st_stanovanja;
            label61.Text = st_etaze;
            label62.Text = st_nadstropja;
            label68.Text = okna;
            label57.Text = tloris.ToString("N2")+" m2";
            label58.Text = upor_povrsina.ToString("N2") + " m2";
            label66.Text = inštalacije;
            string nen_id_s = st_nen_id(dst_sid);
            Poisci_lastnike_delov(nen_id_s);
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

        private void Nalozi_lastnika_dela_stavbe(int vhod)
        {
            string delez = "";
            string q = "select * from tbl_ren_lastniki where id = @idx"; //+ sort;
            try
            {
                cmd9 = new SqlCommand(q, con9);
                cmd9.Parameters.AddWithValue("@idx", vhod);
                con9.Open();
                rdr9 = cmd9.ExecuteReader();
                while (rdr9.Read())
                {
                    ime_last = (string)rdr9["ime"];
                    naslov_last = (string)rdr9["naslov"];
                    leto_last = (string)rdr9["leto"];
                    delez_str_last = (string)rdr9["delez_str"];
                    delez_proc_last = string.Format("{0:F2}", (double)rdr9["delez_proc"]);
                    delez_proc_last = delez_proc_last + " %";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka rdr: " + ex.Message);
            }
            finally
            {
                rdr9.Close();
                con9.Close();
            }
            delez = delez_str_last + "     (" + delez_proc_last + ")";
            label74.Text = ime_last;
            label56.Text = naslov_last;
            label71.Text = leto_last;
            label53.Text = delez;
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
