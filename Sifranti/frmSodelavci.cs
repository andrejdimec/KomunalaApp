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
        string time = "";
        string tpriimek = "";
        string tdelovnomesto = "";
        string temso = "";
        string index;
        string stindeks;
        int tid, tindeks;
        bool osnovno=true;
        bool dodajanje;
        
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

            tbIme.BackColor = frmMain.bela;
            tbPriimek.BackColor = frmMain.bela;
            tbIme2.BackColor = frmMain.bela;
            tbPriimek2.BackColor = frmMain.bela;
            tbDelovnoMesto.BackColor = frmMain.bela;
            tbSm.BackColor = frmMain.bela;
            tbPosta.BackColor = frmMain.bela;
            tbNazivPoste.BackColor = frmMain.bela;
            tbHs.BackColor = frmMain.bela;
            tbUlica.BackColor = frmMain.bela;
            tbPrivatMail.BackColor = frmMain.bela;
            tbSluzbeniMail.BackColor = frmMain.bela;
            tbSluzbeniMob.BackColor = frmMain.bela;
            tbSluzbeniStac.BackColor = frmMain.bela;
            tbPrivatMob.BackColor = frmMain.bela;
            tbMpo.BackColor = frmMain.bela;
            tbIzobrazba.BackColor = frmMain.bela;
            tbEmso.BackColor = frmMain.bela;
            tbDs.BackColor = frmMain.bela;
            tbTrr.BackColor = frmMain.bela;
            tbBanka.BackColor = frmMain.bela;
            tbOddelek.BackColor = frmMain.bela;

        }
        private void Izprazni_dgv()
        {
            dgv1.Rows.Clear();
            dgv1.Refresh();
        }

        private void onemogoci_tb()
        {
            tbIme.Enabled = false;
            tbPriimek.Enabled = false;
            tbIme2.Enabled = false;
            tbPriimek2.Enabled = false;
            tbDelovnoMesto.Enabled = false;
            tbSm.Enabled = false;
            tbPosta.Enabled = false;
            tbNazivPoste.Enabled = false;
            tbHs.Enabled = false;
            tbUlica.Enabled = false;
            tbPrivatMail.Enabled = false;
            tbSluzbeniMail.Enabled = false;
            tbSluzbeniMob.Enabled = false;
            tbSluzbeniStac.Enabled = false;
            tbPrivatMob.Enabled = false;
            tbMpo.Enabled = false;
            tbIzobrazba.Enabled = false;
            tbEmso.Enabled = false;
            tbDs.Enabled = false;
            tbTrr.Enabled = false;
            tbBanka.Enabled = false;
            tbOddelek.Enabled = false;
        }

        private void omogoci_tb()
        {
            tbIme.Enabled = true;
            tbPriimek.Enabled = true;
            //tbIme2.Enabled = true;
            //tbPriimek2.Enabled = true;
            tbDelovnoMesto.Enabled = true;
            tbSm.Enabled = true;
            tbPosta.Enabled = true;
            tbNazivPoste.Enabled = true;
            tbHs.Enabled = true;
            tbUlica.Enabled = true;
            tbPrivatMail.Enabled = true;
            tbSluzbeniMail.Enabled = true;
            tbSluzbeniMob.Enabled = true;
            tbSluzbeniStac.Enabled = true;
            tbPrivatMob.Enabled = true;
            tbMpo.Enabled = true;
            tbIzobrazba.Enabled = true;
            tbEmso.Enabled = true;
            tbDs.Enabled = true;
            tbTrr.Enabled = true;
            tbBanka.Enabled = true;
            tbOddelek.Enabled = true;
        }

        private void izprazni_tb()
        {
            tbIme.Text = "";
            tbPriimek.Text = "";
            tbIme2.Text = "";
            tbPriimek2.Text = "";
            tbDelovnoMesto.Text = "";
            tbSm.Text = "";
            tbPosta.Text = "";
            tbNazivPoste.Text = "";
            tbHs.Text = "";
            tbUlica.Text = "";
            tbPrivatMail.Text = "";
            tbSluzbeniMail.Text = "";
            tbSluzbeniMob.Text = "";
            tbSluzbeniStac.Text = "";
            tbPrivatMob.Text = "";
            //.Text = (string)rdr2[""];
            tbMpo.Text = "";
            tbIzobrazba.Text = "";
            tbEmso.Text = "";
            tbDs.Text = "";
            tbTrr.Text = "";
            tbBanka.Text = "";
            tbOddelek.Text = "";
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
            dodajanje = false;
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
                    tbIme2.Text = (string)rdr2["ime"];
                    tbPriimek2.Text = (string)rdr2["priimek"];
                    tbDelovnoMesto.Text = (string)rdr2["del_mesto"];
                    tbSm.Text = (string)rdr2["sm"]; // poišči sm
                    tbPosta.Text = (string)rdr2["posta"];
                    tbNazivPoste.Text = (string)rdr2["posta_ime"];
                    tbHs.Text = (string)rdr2["hs"];
                    tbUlica.Text = (string)rdr2["ulica"];
                    tbPrivatMail.Text = (string)rdr2["email_privat"];
                    tbSluzbeniMail.Text = (string)rdr2["email_sluzba"];
                    tbSluzbeniMob.Text = (string)rdr2["tel_sluzba_1"];
                    tbSluzbeniStac.Text = (string)rdr2["tel_sluzba_2"];
                    tbPrivatMob.Text = (string)rdr2["tel_privat"];
                    //.Text = (string)rdr2[""];
                    tbMpo.Text = (string)rdr2["mpo"];
                    tbIzobrazba.Text = (string)rdr2["izobrazba"];
                    tbEmso.Text = (string)rdr2["emso"];
                    tbDs.Text = (string)rdr2["ds"];
                    tbTrr.Text = (string)rdr2["trr"];
                    tbBanka.Text = (string)rdr2["banka"];
                    tbOddelek.Text= (string)rdr2["oddelek"];
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
                    if (dodajanje)
                    {
                        // dodaj
                        q = "insert into tbl_Sodelavci (emso,ime,priimek,ulica,hs,posta,posta_ime,ds,tel_privat,tel_sluzba_1,tel_sluzba_2," +
                            "email_privat,email_sluzba,trr,banka,izobrazba,del_mesto,oddelek,sm,mpo) " +
                            "values(@emso,@ime,@priimek,@hs,@ulica,@posta,@posta_ime,@ds,@tel_privat,@tel_sluzba_1,@tel_sluzba_2," +
                            "@email_privat,@email_sluzba,@trr,@banka,@izobrazba,@del_mesto,@oddelek,@sm,@mpo)";
                        cmd = new SqlCommand(q, con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@emso", tbEmso.Text); 
                        cmd.Parameters.AddWithValue("@ime", tbIme.Text);
                        cmd.Parameters.AddWithValue("@priimek", tbPriimek.Text);
                        cmd.Parameters.AddWithValue("@ulica", tbUlica.Text);
                        cmd.Parameters.AddWithValue("@hs", tbHs.Text);
                        cmd.Parameters.AddWithValue("@posta", tbPosta.Text);
                        cmd.Parameters.AddWithValue("@posta_ime", tbNazivPoste.Text);
                        cmd.Parameters.AddWithValue("@ds", tbDs.Text);
                        cmd.Parameters.AddWithValue("@tel_privat", tbPrivatMob.Text);
                        cmd.Parameters.AddWithValue("@tel_sluzba_1", tbSluzbeniMob.Text);
                        cmd.Parameters.AddWithValue("@tel_sluzba_2", tbSluzbeniStac.Text);
                        cmd.Parameters.AddWithValue("@email_privat", tbPrivatMail.Text);
                        cmd.Parameters.AddWithValue("@email_sluzba", tbSluzbeniMail.Text);
                        cmd.Parameters.AddWithValue("@trr", tbTrr.Text);
                        cmd.Parameters.AddWithValue("@banka", tbBanka.Text);
                        cmd.Parameters.AddWithValue("@izobrazba", tbIzobrazba.Text);
                        cmd.Parameters.AddWithValue("@del_mesto", tbDelovnoMesto.Text);
                        cmd.Parameters.AddWithValue("@oddelek", tbOddelek.Text);
                        cmd.Parameters.AddWithValue("@sm", tbSm.Text);
                        cmd.Parameters.AddWithValue("@mpo", tbMpo.Text);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        // spremeni
                        q = "update tbl_Sodelavci set ime = @time, priimek= @tpriimek where id=@tid";
                        cmd = new SqlCommand(q, con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@tid", tid);
                        cmd.Parameters.AddWithValue("@time", tbIme.Text);
                        cmd.Parameters.AddWithValue("@tpriimek", tbPriimek.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka pri shranjevanju zapisa: " + ex.Message);
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
                MessageBox.Show("Napaka: Ime in priimek ne smeta biti prazna!");
                tbIme.Focus();
            }
            Display();
        }

        private void Dodaj()
        {
            dodajanje = true;
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
            dodajanje = false;
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
                tbIme2.Text = tbIme.Text;
                tbPriimek2.Text = tbPriimek.Text;
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
            //index = dgv1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //tid = Convert.ToInt32(index);
            //Nalozi(tid);
            //tbIme.Text = dgv1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnDodaj_Click_1(object sender, EventArgs e)
        {
            Dodaj();
        }

        private void btnPreklici_Click(object sender, EventArgs e)
        {
            Preklici();
        }

        private void btnSpremeni_Click(object sender, EventArgs e)
        {
            Spremeni();
        }

        private void btnShrani_Click(object sender, EventArgs e)
        {
            Shrani();
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
            if (dodajanje)
            {
                DialogResult result = MessageBox.Show("Želiš preklicati vnašanje novega sodelavca?", "Prekliči", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    izprazni_tb();
                    Zacetek();
                }
                else
                {
                    // cb1.Focus();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Želiš preklicati urejanje sodelavca?", "Prekliči", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    izprazni_tb();
                    Zacetek();
                }
                else
                {
                    // cb1.Focus();
                }
            }
        }
    }
}
