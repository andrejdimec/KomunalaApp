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
    public partial class frmEnote : Form
    {
        SqlConnection con = frmMain.c;
        SqlCommand cmd;
        SqlDataReader rdr = null;

        string topis = "";
        string index;
        string tem;
        int tid;
        int dodaj = 0;

        public frmEnote()
        {
            InitializeComponent();
        }

        private void frmEnote_Load(object sender, EventArgs e)
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
            tb2.BackColor = frmMain.bela;

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
            dgv1.Columns[1].Width = 100;
            dgv1.Columns[2].Width = 247;
            dgv1.Columns[0].Name = "Id";
            dgv1.Columns[1].Name = "Enota";
            dgv1.Columns[2].Name = "Opis";
            dgv1.Columns["Id"].Visible = false;
            this.dgv1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv1.Columns[1].DefaultCellStyle.Padding = new Padding(25, 0, 0, 0);
            dgv1.Columns[2].DefaultCellStyle.Padding = new Padding(15, 0, 0, 0);

            dgv1.Focus();
        }

        private void Display()
        {
            Izprazni_dgv();
            string q = "select * from tbl_Enote order by em";
            try
            {
                cmd = new SqlCommand(q, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tid = (int)rdr["Id"];
                    tem = (string)rdr["em"]; // Opis
                    topis = (string)rdr["opis"];  // določi id v katerega boš pisal
                    string strid = Convert.ToString(tid);
                    string[] row1 = new string[] { strid, tem, topis };
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
                    string q = "delete from tbl_Enote where id = @tid";
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
                if (tb1.Text != "" && tb2.Text != "")
                {
                    tem = tb1.Text;
                    topis = tb2.Text;
                    try
                    {
                        if (dodaj == 1)
                        {
                            // dodaj
                            q = "insert into tbl_Enote(em,opis) values(@tem,@topis)";
                            cmd = new SqlCommand(q, con);
                            con.Open();
                            cmd.Parameters.AddWithValue("@tem", tem);
                            cmd.Parameters.AddWithValue("@topis", topis);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            // spremeni
                            q = "update tbl_Enote set em = @tem, opis= @topis where id=@tid";
                            cmd = new SqlCommand(q, con);
                            con.Open();
                            cmd.Parameters.AddWithValue("@tid", tid);
                            cmd.Parameters.AddWithValue("@tem", tem);
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
    } // partial
}  // namespace
