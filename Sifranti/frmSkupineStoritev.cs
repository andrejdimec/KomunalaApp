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
    public partial class frmSkupineStoritev : Form
    {
        SqlConnection con = frmMain.c;
        SqlConnection con2 = frmMain.c2;
        SqlConnection con3 = frmMain.c3;

        SqlCommand cmd;
        SqlDataReader rdr = null;

        string topis = "";
        string index;
        string tem;
        int tid;
        int dodaj = 0;

        public frmSkupineStoritev()
        {
            InitializeComponent();
        }

        private void frmVrsteStoritev_Load(object sender, EventArgs e)
        {
            onemogoci_tb();
            Design();
            Grid();
            Display();
            Zacetek();
        }

        private void Design()
        {
            crtal.AutoSize = false;
            crtal.Height = 1;
            crtal.BorderStyle = BorderStyle.Fixed3D;


            // gumbi
            btnBrisi.BackColor = frmMain.barva_gumb2_neakt; btnBrisi.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnDodaj.BackColor = frmMain.barva_gumb2_neakt; btnDodaj.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnNazaj.BackColor = frmMain.barva_gumb2_neakt; btnNazaj.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnPreklici.BackColor = frmMain.barva_gumb2_neakt; btnPreklici.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnShrani.BackColor = frmMain.barva_gumb2_neakt; btnShrani.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnSpremeni.BackColor = frmMain.barva_gumb2_neakt; btnSpremeni.ForeColor = frmMain.barva_gumb2_pis_akt;

            tb1.BackColor = frmMain.bela;

            this.BackColor = frmMain.barva_form_back; // Form ozadje
            this.Text = frmMain.nazivPrograma; // Form tekst

        }

        private void Izprazni_dgv()
        {
            dgv1.Rows.Clear();
            dgv1.Refresh();
        }

        private void onemogoci_tb()
        {
            tb1.Enabled = false;
        }

        private void omogoci_tb()
        {
            tb1.Enabled = true;
        }

        private void izprazni_tb()
        {
            tb1.Text = "";
        }

        private void Grid()
        {
            dgv1.ColumnHeadersVisible = false;
            dgv1.RowHeadersVisible = false;
            dgv1.ColumnCount = 2;
            dgv1.Columns[1].Width = 347;
            dgv1.Columns[0].Name = "Id";
            dgv1.Columns[1].Name = "Skupina";
            dgv1.Columns["Id"].Visible = false;
            dgv1.Columns[1].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);

            //this.dgv1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv1.Focus();
        }

        private void Display()
        {
            Izprazni_dgv();
            string q = "select * from tblSkupinestoritev";
            try
            {
                cmd = new SqlCommand(q, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    int tindeks = (int)rdr["Indeks"];
                    if (tindeks != 1)
                    {
                        topis = (string)rdr["skupina"]; // Opis
                        tid = (int)rdr["Id"];
                        string strid = Convert.ToString(tid);
                        string[] row1 = new string[] { strid, topis };
                        dgv1.Rows.Add(row1);
                    }
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
        private void Gumbi_2() // dodajanje, urejanje
        {
            btnShrani.Enabled = true; btnShrani.BackColor = frmMain.barva_gumb2_neakt;
            btnPreklici.Enabled = true; btnPreklici.BackColor = frmMain.barva_gumb2_neakt;
            btnDodaj.Enabled = false; btnDodaj.BackColor = frmMain.barva_gumb2_disabled;
            btnBrisi.Enabled = false; btnBrisi.BackColor = frmMain.barva_gumb2_disabled;
            btnSpremeni.Enabled = false; btnSpremeni.BackColor = frmMain.barva_gumb2_disabled;
            btnNazaj.Enabled = false; btnNazaj.BackColor = frmMain.barva_gumb2_disabled;
        }

        private void Gumbi_1()  // začetek
        {
            btnShrani.Enabled = false; btnShrani.BackColor = frmMain.barva_gumb2_disabled;
            btnPreklici.Enabled = false; btnPreklici.BackColor = frmMain.barva_gumb2_disabled;
            btnDodaj.Enabled = true; btnDodaj.BackColor = frmMain.barva_gumb2_neakt;
            btnBrisi.Enabled = true; btnBrisi.BackColor = frmMain.barva_gumb2_neakt;
            btnSpremeni.Enabled = true; btnSpremeni.BackColor = frmMain.barva_gumb2_neakt;
            btnNazaj.Enabled = true; btnNazaj.BackColor = frmMain.barva_gumb2_neakt;
        }

        private void Zacetek()
        {
            dodaj = 0;
            izprazni_tb();
            onemogoci_tb();
            Gumbi_1();
            dgv1.Focus();
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
            if (tb1.Text != "")
            {
                topis = tb1.Text;
                try
                {
                    if (dodaj == 1)
                    {
                        // dodaj
                        q = "insert into tblSkupinestoritev(skupina,indeks) values(@topis,@indeks)";
                        cmd = new SqlCommand(q, con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@topis", topis);
                        cmd.Parameters.AddWithValue("@indeks", 0);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        // spremeni
                        q = "update tblSkupinestoritev set skupina= @topis where id=@tid";
                        cmd = new SqlCommand(q, con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@tid", tid);
                        cmd.Parameters.AddWithValue("@topis", topis);
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
                tb1.Focus();
            }
            Display();
        }

        private void Dodaj()
        {
            dodaj = 1;
            omogoci_tb();
            izprazni_tb();
            Gumbi_2();
            tb1.Focus();
        }

        private void Spremeni()
        {
            dodaj = 0;
            omogoci_tb();
            Gumbi_2();
            tb1.Focus();
        }
        private void Preklici()
        {
            izprazni_tb();
            Zacetek();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Shrani();
        }

        private void btnPreklici_Click(object sender, EventArgs e)
        {
            Preklici();
        }

        private void btnNazaj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSpremeni_Click(object sender, EventArgs e)
        {
            tb1.Text = dgv1.SelectedCells[1].Value.ToString();
            tid = Convert.ToInt32(index);
            Spremeni();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Dodaj();
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            index = dgv1.SelectedCells[0].Value.ToString();
            tid = Convert.ToInt32(index);
            Brisi();
        }

        private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dgv1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tid = Convert.ToInt32(index);
            tb1.Text = dgv1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Spremeni();
        }

        private void tb1_KeyDown(object sender, KeyEventArgs e)
        {
            // shrani
            if (e.KeyCode == Keys.Enter)
            {
                Shrani();
            }
            // prekliči
            if (e.KeyCode == Keys.Escape)
            {
                Preklici();
            }
        }

        private void dgv1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tb1.Text = dgv1.SelectedCells[1].Value.ToString();
                tid = Convert.ToInt32(index);
                Spremeni();
            }
        }
    }
}
