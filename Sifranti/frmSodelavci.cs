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
using System.Collections.Generic;
using System.Drawing;

namespace Komunala
{
    public partial class frmSodelavci : Form
    {
        SqlConnection con = frmMain.c;
        SqlConnection con2 = frmMain.c2;
        SqlConnection con3 = frmMain.c3;

        SqlCommand cmd,cmd2;
        SqlDataReader rdr,rdr2 = null;

        string q,q2;
        int dodaj;
        string time = "";
        string tpriimek = "";
        string tdelovnomesto = "";
        string temso = "";
        string index;
        string stindeks;
        int tid, tindeks;
        bool osnovno;
        
        private Color ColorOzadje;
        //public Color ColorOzadje
        //{
        //    get { return ColorOozadje; }
        //    set { ColorOOzadje = value; Invalidate(); }
        //}
        ////private Color ColorOzadje;
        //Color ColorOzadje = new Color.FromArgb(0, 62, 107);  // ozadje neaktivnega

        public frmSodelavci()
        {
            InitializeComponent();
        }

        private void frmSodelavci_Load(object sender, EventArgs e)
        {
            
            // črta iz label
            Design();
            this.BackColor = frmMain.barva_form_back;


            onemogoci_tb();
            Grid();
            Display();
            Zacetek();
        }

        private void Design()
        {
            crtal2.AutoSize = false;
            crtal2.Height = 1;
            //crtal.Width = 500;
            crtal2.BorderStyle = BorderStyle.Fixed3D;
            crtal.AutoSize = false;
            crtal.Height = 1;
            //crtal.Width = 500;
            crtal.BorderStyle = BorderStyle.Fixed3D;

            tpOsnovno.BackColor = frmMain.barva_form_back;
            tpDodatno.BackColor = frmMain.barva_form_back;

            // gumbi
            btnBrisi.BackColor = frmMain.barva_gumb2_neakt; btnBrisi.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnDodaj.BackColor = frmMain.barva_gumb2_neakt; btnDodaj.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnNazaj.BackColor = frmMain.barva_gumb2_neakt;btnNazaj.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnPreklici.BackColor = frmMain.barva_gumb2_neakt;btnPreklici.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnShrani.BackColor = frmMain.barva_gumb2_neakt;btnShrani.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnSpremeni.BackColor = frmMain.barva_gumb2_neakt;btnSpremeni.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnDodatno.BackColor = frmMain.barva_gumb2_neakt;btnDodatno.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnBrisi.Width = frmMain.gumb2_sirina; btnBrisi.Height = frmMain.gumb2_visina;
            btnDodaj.Width = frmMain.gumb2_sirina; btnDodaj.Height = frmMain.gumb2_visina;
            btnNazaj.Width = frmMain.gumb2_sirina; btnNazaj.Height = frmMain.gumb2_visina;
            btnPreklici.Width = frmMain.gumb2_sirina; btnPreklici.Height = frmMain.gumb2_visina;
            btnShrani.Width = frmMain.gumb2_sirina; btnShrani.Height = frmMain.gumb2_visina;
            btnSpremeni.Width = frmMain.gumb2_sirina; btnSpremeni.Height = frmMain.gumb2_visina;




        }
        private void Izprazni_dgv()
        {
            dgv1.Rows.Clear();
            dgv1.Refresh();
        }

        private void onemogoci_tb()
        {
            //tb1.Enabled = false;
            //tb2.Enabled = false;
        }

        private void omogoci_tb()
        {
            //tb1.Enabled = true;
            //tb2.Enabled = true;
        }

        private void izprazni_tb()
        {
            tbIme.Text = "";
            tbPriimek.Text = "";
        }

        private void Grid()
        {
            dgv1.ColumnHeadersVisible = false;
            dgv1.RowHeadersVisible = false;
            dgv1.ColumnCount = 4;
            dgv1.Columns[0].Width = 1;
            dgv1.Columns[1].Width = 120;
            dgv1.Columns[2].Width = 120;
            dgv1.Columns[3].Width = 190;

            dgv1.Columns[0].Name = "Id"; 
            dgv1.Columns[1].Name = "Priimek";
            dgv1.Columns[2].Name = "Ime";
            dgv1.Columns[3].Name = "Delovno mesto";
            dgv1.Columns["Id"].Visible = false;
            this.dgv1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgv1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgv1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            // this.dgv1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv1.Focus();

        }

        private void Display()
        {
            Izprazni_dgv();
            string q = "select * from tbl_Sodelavci order by priimek";
            try
            {
                cmd = new SqlCommand(q, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tid = (int)rdr["Id"];
                    time = (string)rdr["ime"]; // Opis
                    tpriimek = (string)rdr["priimek"];  // določi id v katerega boš pisal
                    tdelovnomesto = (string)rdr["del_mesto"];

                    string strid = Convert.ToString(tid);
                    string[] row1 = new string[] { strid,tpriimek, time, tdelovnomesto };
                    dgv1.Rows.Add(row1);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: " + ex.Message);
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
                }
            }
            //Zacetek();
        }

        private void Zacetek()
        {
            dodaj = 0;
            osnovno = true;
            izprazni_tb();
            onemogoci_tb();
            btnShrani.Enabled = false;
            btnPreklici.Enabled = false;
            btnDodaj.Enabled = true;
            btnBrisi.Enabled = true;
            btnSpremeni.Enabled = true;
            btnNazaj.Enabled = true;
            dgv1.Focus();
        }

        void Nalozi(int idx) // naloži podatke v polja
        {
            q2 = "select * from tbl_Sodelavci where id=@idx";
            try
            {
                cmd2 = new SqlCommand(q2, con2);
                cmd2.Parameters.AddWithValue("@idx", idx); 
                con2.Open();
                rdr2 = cmd2.ExecuteReader();
                while (rdr2.Read())
                {
                    tbIme.Text = (string)rdr2["ime"];
                    tbPriimek.Text = (string)rdr2["priimek"];
                    tbDelovnoMesto.Text = (string)rdr2["del_mesto"];
                    tbSm.Text = Convert.ToString((Int32)rdr2["sm"]); // poišči sm
                    tbPrivatMob.Text = (string)rdr2["tel_privat"];
                    tbPosta.Text = (string)rdr2["posta"];
                    tbNazivPoste.Text = (string)rdr2["posta_ime"];
                    tbHs.Text = (string)rdr2["hs"];
                    tbUlica.Text = (string)rdr2["ulica"];
                    tbPrivatMail.Text = (string)rdr2["email_privat"];
                    tbSluzbeniMail.Text = (string)rdr2["email_sluzba"];
                    tbSluzbeniMob.Text = (string)rdr2["tel_sluzba_1"];
                    tbSluzbeniStac.Text = (string)rdr2["tel_sluzba_2"];
                    //.Text = (string)rdr2[""];

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader (Naloži): " + ex.Message);
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
        private void Brisi()
        {
            DialogResult result = MessageBox.Show("Izbrišem zapis?", "Potrdi brisanje", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string q = "delete from tblSkupinestoritev where id = @tid";
                    cmd = new SqlCommand(q, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@tid", tid);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka pri brisanju: " + ex.Message);
                }
                finally
                {
                    if (con != null)
                    {
                        con.Close();
                    }
                }
                Zacetek();
            }
            else if (result == DialogResult.No)
            {
                Zacetek();
            }
            Display();
        }

        private void Shrani()
        {
            string q;
            if (tbIme.Text != "" && tbPriimek.Text != "")
            {
                //tskupina = tb2.Text;
                //stindeks = tb1.Text;
                //tindeks = Convert.ToInt32(stindeks);
                try
                {
                    if (dodaj == 1)
                    {
                        // dodaj
                        q = "insert into tblSkupinestoritev (skupina,indeks) values(@tskupina,@tindeks)";
                        cmd = new SqlCommand(q, con);
                        con.Open();
                        //cmd.Parameters.AddWithValue("@tskupina", tskupina);
                        cmd.Parameters.AddWithValue("@tindeks", tindeks);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        // spremeni
                        q = "update tblSkupinestoritev set skupina = @tskupina, indeks= @tindeks where id=@tid";
                        cmd = new SqlCommand(q, con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@tid", tid);
                        //cmd.Parameters.AddWithValue("@tskupina", tskupina);
                        cmd.Parameters.AddWithValue("@tindeks", tindeks);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: " + ex.Message);
                }
                finally
                {
                    if (con != null)
                    {
                        con.Close();
                    }
                }
                Zacetek();

            }
            else
            {
                MessageBox.Show("Napaka: Polje ne sme biti prazno.");
                tbIme.Focus();
            }
            Display();
        }

        private void Dodaj()
        {
            dodaj = 1;
            omogoci_tb();
            izprazni_tb();
            btnShrani.Enabled = true;
            btnPreklici.Enabled = true;
            btnDodaj.Enabled = false;
            btnBrisi.Enabled = false;
            btnSpremeni.Enabled = false;
            btnNazaj.Enabled = false;
            tbIme.Focus();
        }

        private void Spremeni()
        {
            dodaj = 0;
            omogoci_tb();
            btnShrani.Enabled = true;
            btnPreklici.Enabled = true;
            btnDodaj.Enabled = false;
            btnBrisi.Enabled = false;
            btnSpremeni.Enabled = false;
            btnNazaj.Enabled = false;
            tbIme.Focus();
        }

        private void btnNazaj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

        }

        private void btnDodatno_Click(object sender, EventArgs e)
        {
            if (osnovno)
            {
                osnovno = false;
                btnDodatno.Text = "Pokaži osnovne podatke";
                label2.Text = "Dodatni podatki";
                this.tc.SelectedTab = this.tpDodatno;
            }
            else
            {
                osnovno = true;
                btnDodatno.Text = "Pokaži dodatne podatke";
                label2.Text = "Osnovni podatki";
                this.tc.SelectedTab = this.tpOsnovno;
            }


        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dgv1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tid = Convert.ToInt32(index);
            Nalozi(tid);
            //tbIme.Text = dgv1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dgv1_SelectionChanged(object sender, EventArgs e)
        {
            //index = dgv1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //tid = Convert.ToInt32(index);
            //Nalozi(tid);
        }

        private void dgv1_LocationChanged(object sender, EventArgs e)
        {
           
        }

        private void dgv1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            index = dgv1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tid = Convert.ToInt32(index);
            Nalozi(tid);
        }

        private void Preklici()
        {
            izprazni_tb();
            Zacetek();
        }
    }
}
