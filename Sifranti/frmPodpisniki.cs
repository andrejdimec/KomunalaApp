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
    public partial class frmPodpisniki : Form
    {
        SqlConnection con = frmMain.c;
        SqlConnection con2 = frmMain.c2;
        SqlConnection con3 = frmMain.c3;

        SqlCommand cmd;
        SqlDataReader rdr = null;

        string toseba = "";
        string index;
        string tfunkcija;
        int tid;
        int dodaj = 0;


        public frmPodpisniki()
        {
            InitializeComponent();
        }

        private void frmPodpisniki_Load(object sender, EventArgs e)
        {
            onemogoci_tb();
            Grid();
            Display();
            Zacetek();
        }
        private void Izprazni_dgv()
        {
            dgv1.Rows.Clear();
            dgv1.Refresh();
        }

        private void onemogoci_tb()
        {
            tb1.Enabled = false;
            tb2.Enabled = false;
        }

        private void omogoci_tb()
        {
            tb1.Enabled = true;
            tb2.Enabled = true;
        }

        private void izprazni_tb()
        {
            tb1.Text = "";
            tb2.Text = "";
        }

        private void Grid()
        {
            dgv1.ColumnHeadersVisible = false;
            dgv1.RowHeadersVisible = false;
            dgv1.ColumnCount = 3;
            dgv1.Columns[1].Width = 250;
            dgv1.Columns[2].Width = 176;
            dgv1.Columns[0].Name = "Id";
            dgv1.Columns[1].Name = "Ime in priimek";
            dgv1.Columns[2].Name = "Funkcija";
            dgv1.Columns["Id"].Visible = false;
            //this.dgv1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv1.Focus();
        }

        private void Display()
        {
            Izprazni_dgv();
            string q = "select * from tbl_osebe";
            try
            {
                cmd = new SqlCommand(q, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tid = (int)rdr["Id"];
                    toseba = (string)rdr["oseba"]; // Opis
                    tfunkcija = (string)rdr["funkcija"];  // določi id v katerega boš pisal
                    string strid = Convert.ToString(tid);
                    string[] row1 = new string[] { strid, toseba, tfunkcija };
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

        private void Brisi()
        {
            DialogResult result = MessageBox.Show("Izbrišem zapis?", "Potrdi brisanje", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string q = "delete from tbl_osebe where id = @tid";
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
                toseba = tb1.Text;
                tfunkcija = tb2.Text;
                try
                {
                    if (dodaj == 1)
                    {
                        // dodaj
                        q = "insert into tbl_osebe(oseba,funkcija) values(@toseba,@tfunkcija)";
                        cmd = new SqlCommand(q, con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@toseba", toseba);
                        cmd.Parameters.AddWithValue("@tfunkcija", tfunkcija);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        // spremeni
                        q = "update tbl_osebe set oseba = @toseba, funkcija= @tfunkcija where id=@tid";
                        cmd = new SqlCommand(q, con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@tid", tid);
                        cmd.Parameters.AddWithValue("@toseba", toseba);
                        cmd.Parameters.AddWithValue("@tfunkcija", tfunkcija);
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
            btnShrani.Enabled = true;
            btnPreklici.Enabled = true;
            btnDodaj.Enabled = false;
            btnBrisi.Enabled = false;
            btnSpremeni.Enabled = false;
            btnNazaj.Enabled = false;
            tb1.Focus();
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
            tb1.Focus();
        }
        private void Preklici()
        {
            izprazni_tb();
            Zacetek();
        }

        private void btnPreklici_Click(object sender, EventArgs e)
        {
            Preklici();
        }

        private void btnShrani_Click(object sender, EventArgs e)
        {
            Shrani();
        }

        private void btnNazaj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSpremeni_Click(object sender, EventArgs e)
        {
            tb1.Text = dgv1.SelectedCells[1].Value.ToString();
            tb2.Text = dgv1.SelectedCells[2].Value.ToString();
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
            tb2.Text = dgv1.Rows[e.RowIndex].Cells[2].Value.ToString();
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

        private void tb2_KeyDown(object sender, KeyEventArgs e)
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
                tb2.Text = dgv1.SelectedCells[2].Value.ToString();
                tid = Convert.ToInt32(index);
                Spremeni();
            }
        }
    }
}
