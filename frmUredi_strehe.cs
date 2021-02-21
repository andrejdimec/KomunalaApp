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
    public partial class frmUredi_strehe : Form
    {

        SqlConnection con = frmMain.c;
        SqlConnection con2 = frmMain.c2;
        SqlConnection con3 = frmMain.c3;
        SqlConnection con9 = frmMain.c9;
        SqlConnection con6 = frmMain.c6;
        SqlConnection con7 = frmMain.c6;

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
        SqlCommand cmd7;

        static DataTable dt, dt2, dt3, dt4, dt7;
        string q, q2, q3, q6, q9;
        int id_akt;
        bool akt_neodobrene, sprememba;

        // za izvoz
        int stevec;
        string sp = " ";
        string str_stevec, napisi;
        List<string> izvoz_vrsta = new List<string>();
        //public static string pot = frmMain_kat.a_naselje + " - podatki o naselju.csv";
        //private const char tab = '\t';
        private const char tab = ';';


        private void button1_Click(object sender, EventArgs e)
        {
            frmStrehe sec = new frmStrehe();
            sec.ShowDialog();
            Osvezi();
        }

        private void Nalozi_dst(string id_dela)
        {
            sprememba = false;
            string st_stanovanja = "";
            string st_prostorov = "";
            string st_nadstropja = "";
            double procent = 0;
            double streha_skupaj = 0;
            double streha_delez = 0;
            double n_tloris = 0;
            double n_tloris_skupaj = 0;
            string okna = "";
            string dst_sid = "";
            string sta_sid = "";
            string hsmid_del = "";
            string hsmid_gl = "";
            string raba_id = "";
            string raba_ime = "";
            int vecstanovanjska = 0;
            int odobreno = 0;
            string lastnik = "";
            string lastnik_nas = "";
            string lastnik_pt = "";
            string  cadis= "";
            string  cadis_nas= "";
            string  cadis_pt= "";
            string  placnik= "";
            string  placnik_nas= "";
            string  placnik_pt= "";
            string  dst_nas= "";
            string  dst_pt= "";


            string q = "select * from strehe_za_obracun where id = @idx"; //+ sort;
            try
            {
                //MessageBox.Show(vhod.ToString());
                cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@idx", id_dela);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    sta_sid = (string)rdr["sta_sid"];
                    dst_sid = (string)rdr["dst_sid"];
                    hsmid_del = (string)rdr["hs_mid_del"];
                    hsmid_gl = (string)rdr["hs_mid_gl"];
                    st_stanovanja = (string)rdr["st_stanovanja"];
                    st_prostorov = Convert.ToString((int)rdr["st_prostorov"]);
                    vecstanovanjska = rdr["vecstanovanjska"] as int? ?? default(int);
                    raba_id = (string)rdr["raba_id"];
                    raba_ime = (string)rdr["raba_ime"];
                    n_tloris = (double)rdr["n_tloris"];
                    n_tloris_skupaj = (double)rdr["n_tloris_skupaj"];
                    procent = (double)rdr["procent"];
                    streha_skupaj = (double)rdr["streha_skupaj"];
                    streha_delez = (double)rdr["streha_delez"];
                    vecstanovanjska = (int)rdr["vecstanovanjska"];
                    odobreno = (int)rdr["odobreno"];
                    lastnik = (string)rdr["lastnik"];
                    lastnik_nas = (string)rdr["lastnik_nas"];
                    lastnik_pt = (string)rdr["lastnik_pt"];
                    cadis = rdr["cadis"] as string;
                    cadis_nas = rdr["naslov_cad"] as string;
                    cadis_pt = rdr["posta_cad"] as string;
                    placnik = rdr["placnik"] as string;
                    placnik_nas = rdr["naslov_pl"] as string;
                    placnik_pt = rdr["posta_pl"] as string;
                    dst_nas = (string)rdr["naslov_dst"];
                    dst_pt = (string)rdr["posta_dst"];

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
            label29.Text = dst_sid;
            label16.Text = sta_sid;
            label30.Text = hsmid_del;
            label28.Text = hsmid_gl;
            if (vecstanovanjska == 1)
                label32.Text = "Da";
            else
                label32.Text = "Ne";
            label33.Text = raba_id + " - " + raba_ime;
            label31.Text = st_prostorov;
            label38.Text = st_stanovanja;
            label52.Text = n_tloris.ToString("N2") + " m2"; ;
            label46.Text = n_tloris_skupaj.ToString("N2") + " m2"; ;
            label45.Text = procent.ToString("N2") + " %";
            label47.Text = streha_skupaj.ToString("N2") + " m2"; ;
            label44.Text = streha_delez.ToString("N2") + " m2"; ;
            label31.Text = st_prostorov;
            if (odobreno==1)
            {
                label39.Text = "Da";
                label39.ForeColor = Color.Green;
                cb.Text = "Odobren";
                cb.ForeColor = Color.Green;
                cb.Checked = true;
            }
            else
            {
                label39.Text = "Ne";
                label39.ForeColor = Color.Red;
                cb.Text = "Neodobren";
                cb.ForeColor = Color.Red;
                cb.Checked = false;
            }
            li.Text = lastnik;
            ln.Text = lastnik_nas;
            lp.Text = lastnik_pt;
            pi.Text = placnik;
            pn.Text = placnik_nas;
            pp.Text = placnik_pt;
            nn.Text = dst_nas;
            np.Text = dst_pt;
            ci.Text = cadis;
            cn.Text = cadis_nas;
            cp.Text = cadis_pt;

            


        }

        private void dgvs_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string idx_dst = dgvs.Rows[e.RowIndex].Cells[5].Value.ToString();
            id_akt = Convert.ToInt32(dgvs.Rows[e.RowIndex].Cells[5].Value.ToString());
            Nalozi_dst(idx_dst); ;
        }

        private void dgvs_Enter(object sender, EventArgs e)
        {
            akt_neodobrene = true;
            label4.ForeColor = Color.Green;
            label4.Font = new Font("Calibri", 12, FontStyle.Bold);
            dgvs.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(200, 255, 200);
            dgvs.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 255, 200);

            dgvso.ColumnHeadersDefaultCellStyle.BackColor = Color.Gainsboro;
            dgvso.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Gainsboro;

            label5.ForeColor = Color.Black;
            label5.Font = new Font("Calibri", 12,FontStyle.Bold);
            //dgvso.ClearSelection();
            //dgvs.BackgroundColor = Color.FromArgb(240,255,240) ;
        }

        private void dgvso_Enter(object sender, EventArgs e)
        {
            akt_neodobrene = false;
            label5.ForeColor = Color.Green;
            label5.Font = new Font("Calibri", 12, FontStyle.Bold);
            dgvso.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(200, 255, 200);
            dgvso.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 255, 200);

            dgvs.ColumnHeadersDefaultCellStyle.BackColor = Color.Gainsboro;
            dgvs.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Gainsboro;

            label4.ForeColor = Color.Black;
            label4.Font = new Font("Calibri", 12, FontStyle.Bold);
            //dgvs.ClearSelection();
            //dgvso.show

        }
        private void Osvezi()
        {
            Strehe();
            Vpisi_dgv_stavbe();
            Vpisi_dgv_stavbe_odob();
            Odobrene();
        }

        private void dgvso_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string idx_dst = dgvso.Rows[e.RowIndex].Cells[5].Value.ToString();
            id_akt = Convert.ToInt32(dgvso.Rows[e.RowIndex].Cells[5].Value.ToString());
            Nalozi_dst(idx_dst); ;
        }
        private void Izprazni_placnik()
        {
            pi.Text = "";
            pn.Text = "";
            pp.Text = "";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Izprazni_placnik();
            pi.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Izprazni_placnik();
            pi.Text = li.Text;
            pn.Text = ln.Text;
            pp.Text = lp.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Izprazni_placnik();
            pi.Text = ci.Text;
            pn.Text = cn.Text;
            pp.Text = cp.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
//            Izprazni_placnik();
  //          pi.Text = li.Text;
            pn.Text = nn.Text;
            pp.Text = np.Text;
        }

        private void Shrani(int vhod)
        {
            // MessageBox.Show(vhod.ToString());
            int odobreno = 0;
            if (cb.Checked)
                odobreno = 1;
            else
                odobreno = 0;
            q = "update strehe_za_obracun set placnik=@placnik,naslov_pl=@naslov_pl, posta_pl=@posta_pl, odobreno=@odobreno where id=@idx";

            try
            {
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@idx", vhod);
                cmd.Parameters.AddWithValue("@placnik", pi.Text);
                cmd.Parameters.AddWithValue("@naslov_pl", pn.Text);
                cmd.Parameters.AddWithValue("@posta_pl", pp.Text);
                cmd.Parameters.AddWithValue("@odobreno", odobreno);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka rdr update plačnik: " + ex.Message);
            }
            finally
            {
                con.Close();
                sprememba = false;
            }
            Osvezi();
        }

        private void pi_TextChanged(object sender, EventArgs e)
        {
            if (pi.Text.TrimEnd().Equals(""))
                sprememba = false;
            else
                sprememba = true;
        }

        private void pn_TextChanged(object sender, EventArgs e)
        {
            if (pn.Text.TrimEnd().Equals(""))
                sprememba = false;
            else
                sprememba = true;
        }

        private void pp_TextChanged(object sender, EventArgs e)
        {
            if (pp.Text.TrimEnd().Equals(""))
                sprememba = false;
            else
                sprememba = true;
        }

        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            sprememba = true;
            if (cb.Checked)
            {
                cb.Text = "Odobren";
                cb.ForeColor = Color.Green;
            }
            else
            {
                cb.Text = "Neodobren";
                cb.ForeColor = Color.Red;
            }
        }

        private void dgvs_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //if (sprememba==true)
            //{
            //    DialogResult result = MessageBox.Show("Shranim spremembe?", " Potrdi. ", MessageBoxButtons.YesNo);
            //    if (result == DialogResult.Yes)
            //    {
            //        Shrani(id_akt);
            //    }

            //}
        }
        private void Izvoz()
        {
            string Filename = "Seznam za obračun odvajanja padavinske vode s streh.csv";
            StreamWriter w = new StreamWriter(new FileStream(Filename, FileMode.Create, FileAccess.Write));
            stevec = 0;
            w.WriteLine(sp);
            w.WriteLine("Seznam za obračun odvajanja padavinske vode s streh");
            w.WriteLine(sp);
            izvoz_vrsta.Clear();
            Seznam_izvoz();
//            izvoz_vrsta.Sort();
            stevec = 1;
            w.WriteLine("Zap." + tab + "Plačnik" + tab + "Naslov" + tab + "Pošta" + tab + "Površina");
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

        private void Seznam_izvoz()
        {
            string q2 = "select placnik,naslov_pl,posta_pl,streha_delez,odobreno from strehe_za_obracun where odobreno=1 order by naslov_pl";
            try
            {
                cmd2 = new SqlCommand(q2, con2);
                con2.Open();
                rdr2 = cmd2.ExecuteReader();
                while (rdr2.Read())
                {
                    string pl_ime = (string)rdr2["placnik"];
                    string naslov_pl = (string)rdr2["naslov_pl"];
                    string posta_pl = (string)rdr2["posta_pl"];
                    double delez = (double)rdr2["streha_delez"];
                    string delst = delez.ToString("N2");
                    string vrsta = pl_ime + tab +naslov_pl+tab+posta_pl+tab+delst;
                    izvoz_vrsta.Add(vrsta);
                    stevec++;
                }  // while read
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader2: " + ex.Message);
            }
            finally
            {
                rdr2.Close();
                con2.Close();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Izvoz();
            MessageBox.Show("Končano.");
        }

        private void bo_Click(object sender, EventArgs e)
        {
            // prenesi v odobrene
            Shrani(id_akt);
            dgvs.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBaze_ZK sec = new frmBaze_ZK();
            sec.ShowDialog();
            Osvezi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public frmUredi_strehe()
        {
            InitializeComponent();
        }

        private void frmUredi_strehe_Load(object sender, EventArgs e)
        {
            this.Text = frmMain.nazivPrograma;
            sprememba = false;
            //ls.Text = "";
            //ll.Text = "";
        
            Strehe();
            Vpisi_dgv_stavbe();
            Vpisi_dgv_stavbe_odob();
            Odobrene();


        }
        private void Odobrene() // informacije o celi bazi streh
        {
            // neodobrene
            q2 = "select count(*) from strehe_za_obracun where odobreno=0";
            cmd2 = new SqlCommand(q2, con2);
            con2.Open();
            int st_neodobrenih = (Int32)cmd2.ExecuteScalar();
            con2.Close();

            string q6 = "SELECT SUM (streha_delez) FROM strehe_za_obracun where odobreno=0";
            cmd6 = new SqlCommand(q6, con6);
            con6.Open();
            double pov_neodobrenih = (double)cmd6.ExecuteScalar();
            lstavb.Text= "Zapisov: "+st_neodobrenih.ToString()+"    Površina: "+pov_neodobrenih.ToString("N2")+" m2";
            con6.Close();
            
            // odobrene
            q2 = "select count(*) from strehe_za_obracun where odobreno=1";
            cmd2 = new SqlCommand(q2, con2);
            con2.Open();
            int st_odobrenih = (Int32)cmd2.ExecuteScalar();
            con2.Close();

            //q6 = "SELECT SUM (streha_delez) FROM strehe_za_obracun where odobreno=1";
            //cmd6 = new SqlCommand(q6, con6);
            //con6.Open();
            //double pov_odobrenih = (double)cmd6.ExecuteScalar();
            //lstavbo.Text = st_odobrenih.ToString() + ", " + pov_odobrenih.ToString("N2") + " m2";
            //con6.Close();
        }
        private void Strehe() // informacije o celi bazi streh
        {
            
            q2 = "select count(*) from ren_strehe";
            cmd2 = new SqlCommand(q2, con2);
            con2.Open();
            int vseh_zapisov = (Int32)cmd2.ExecuteScalar();
            label16.Text = vseh_zapisov.ToString();
            con2.Close();

            q2 = "select count(*) from strehe_za_obracun";
            cmd2 = new SqlCommand(q2, con2);
            con2.Open();
            int vseh_streh = (Int32)cmd2.ExecuteScalar();
            label3.Text = vseh_streh.ToString();
            con2.Close();

            q2 = "select count(*) from strehe_za_obracun where odobreno=0";
            cmd2 = new SqlCommand(q2, con2);
            con2.Open();
            int vseh_streh_n = (Int32)cmd2.ExecuteScalar();
            label54.Text = vseh_streh_n.ToString();
            con2.Close();

            q2 = "select count(*) from strehe_za_obracun where odobreno=1";
            cmd2 = new SqlCommand(q2, con2);
            con2.Open();
            int vseh_streh_o = (Int32)cmd2.ExecuteScalar();
            label60.Text = vseh_streh_o.ToString();
            con2.Close();

            string q6 = "SELECT SUM (povrsina) FROM ren_strehe";
            cmd6 = new SqlCommand(q6, con6);
            con6.Open();
            double povrsina_vseh_streh = (double)cmd6.ExecuteScalar();
            label7.Text = povrsina_vseh_streh.ToString("N2") + " m2";
            con6.Close();

            q6 = "SELECT SUM (streha_delez) FROM strehe_za_obracun where odobreno=0";
            cmd6 = new SqlCommand(q6, con6);
            con6.Open();
            double povrsina_neodobrenih_streh;
            var tmp_double = cmd6.ExecuteScalar();
            if (tmp_double != null && tmp_double != DBNull.Value && double.TryParse(tmp_double.ToString(), out povrsina_neodobrenih_streh))
            {
                label56.Text = povrsina_neodobrenih_streh.ToString("N2") + " m2";
            }
            else
                label56.Text = "Null";
            //double povrsina_neodobrenih_streh = cmd6.ExecuteScalar() as double;
            //label56.Text = povrsina_neodobrenih_streh.ToString("N2") + " m2";
            con6.Close();

            q6 = "SELECT SUM (streha_delez) FROM strehe_za_obracun where odobreno=1";
            cmd6 = new SqlCommand(q6, con6);
            con6.Open();

            double povrsina_odobrenih_streh;
            var tmp_doubleo = cmd6.ExecuteScalar();
            if (tmp_doubleo != null && tmp_doubleo != DBNull.Value && double.TryParse(tmp_doubleo.ToString(), out povrsina_odobrenih_streh))
            {
                label58.Text = povrsina_odobrenih_streh.ToString("N2") + " m2";
            }
            else
                label58.Text = "Null";


            //double povrsina_odobrenih_streh = (double)cmd6.ExecuteScalar();
            //label58.Text = povrsina_odobrenih_streh.ToString("N2") + " m2";
            //lstavbo.Text = "Zapisov: " + vseh_streh_o.ToString() + "    Površina: " + povrsina_odobrenih_streh.ToString("N2") + " m2";

            con6.Close();

            q2 = "select count(*) from strehe_za_obracun where odobreno=0";
            cmd2 = new SqlCommand(q2, con2);
            con2.Open();
            int st_neodobrenih = (Int32)cmd2.ExecuteScalar();
            con2.Close();

            q6 = "SELECT SUM (streha_delez) FROM strehe_za_obracun where odobreno=0";
            cmd6 = new SqlCommand(q6, con6);
            con6.Open();
            double pov_neodobrenih = (double)cmd6.ExecuteScalar();
            lstavb.Text = "Delov: " + st_neodobrenih.ToString() + "    Površina: " + pov_neodobrenih.ToString("N2") + " m2";
            con6.Close();

            // odobrene
            //q2 = "select count(*) from strehe_za_obracun where odobreno=1";
            //cmd2 = new SqlCommand(q2, con2);
            //con2.Open();
            //int st_odobrenih = (Int32)cmd2.ExecuteScalar();
            //con2.Close();


        }

        private void Vpisi_dgv_stavbe()
        {
            dgvs.RowHeadersVisible = false;
            q = @"select raba_id, naslov_dst,lastnik,n_tloris,odobreno,id from strehe_za_obracun  where (odobreno=N'0') order by naslov_dst,labela_dst";
            var da = new SqlDataAdapter(q, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dgvs.DataSource = dt;
            dgvs.ReadOnly = true;
            dgvs.Columns[0].Width = 60;
            dgvs.Columns[1].Width = 190;
            dgvs.Columns[2].Width = 248;
            dgvs.Columns[3].Width = 60;
            dgvs.Columns[0].HeaderText = " Raba";
            dgvs.Columns[1].HeaderText = "Naslov";
            dgvs.Columns[2].HeaderText = "Lastnik";
            dgvs.Columns[3].HeaderText = "Tloris";
            dgvs.Columns[3].Visible = false;
            dgvs.Columns[4].Visible = false;
            dgvs.Columns[5].Visible = false;

            this.dgvs.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //this.dgvs.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //this.dgvs.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //this.dgvs.Columns[3].DefaultCellStyle.Format = "0.0";
            lstavb.Text = "(" + dgvs.Rows.Count.ToString() + ")";
        }

        private void Vpisi_dgv_stavbe_odob()
        {
            dgvso.RowHeadersVisible = false;
            q = @"select raba_id, naslov_dst,placnik,n_tloris,odobreno,id from strehe_za_obracun  where (odobreno=N'1') order by naslov_dst,labela_dst";
            var da = new SqlDataAdapter(q, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dgvso.DataSource = dt;
            dgvso.ReadOnly = true;
            dgvso.Columns[0].Width = 60;
            dgvso.Columns[1].Width = 190;
            dgvso.Columns[2].Width = 248;
            dgvso.Columns[3].Width = 60;
            dgvso.Columns[0].HeaderText = " Raba";
            dgvso.Columns[1].HeaderText = "Naslov";
            dgvso.Columns[2].HeaderText = "Plačnik";
            dgvso.Columns[3].HeaderText = "Tloris";
            dgvso.Columns[3].Visible = false;
            dgvso.Columns[4].Visible = false;
            dgvso.Columns[5].Visible = false;
            this.dgvso.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //this.dgvso.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvso.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvso.Columns[3].DefaultCellStyle.Format = "0.0";
            //lstavbo.Text = "(" + dgvso.Rows.Count.ToString() + ")";
        }


    }

}
