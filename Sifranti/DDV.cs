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
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Drawing;

namespace Komunala
{
    public partial class DDV : Form
    {
        SqlConnection con = frmMain.c;
        SqlCommand cmd;
        SqlDataReader rdr = null;

        string topis = "";
        string index;
        string strstopnja = "";
        double tstopnja;
        int tid;
        int dodaj = 0;

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
            btnBrisi.Width = frmMain.gumb2_sirina; btnBrisi.Height = frmMain.gumb2_visina;
            btnDodaj.Width = frmMain.gumb2_sirina; btnDodaj.Height = frmMain.gumb2_visina;
            btnNazaj.Width = frmMain.gumb2_sirina; btnNazaj.Height = frmMain.gumb2_visina;
            btnPreklici.Width = frmMain.gumb2_sirina; btnPreklici.Height = frmMain.gumb2_visina;
            btnShrani.Width = frmMain.gumb2_sirina; btnShrani.Height = frmMain.gumb2_visina;
            btnSpremeni.Width = frmMain.gumb2_sirina; btnSpremeni.Height = frmMain.gumb2_visina;

            tb1.BackColor = frmMain.bela;
            tb2.BackColor = frmMain.bela;

            this.BackColor = frmMain.barva_form_back; // Form ozadje
            this.Text = frmMain.nazivPrograma; // Form tekst

        }
        private void ShraniPozicijo()
        {
            int saveRow = 0;
            if (dgv1.Rows.Count > 0 && dgv1.FirstDisplayedCell != null)
                saveRow = dgv1.FirstDisplayedCell.RowIndex;

            //dgv1.DataSource = dataTable1;

            if (saveRow != 0 && saveRow < dgv1.Rows.Count)
                dgv1.FirstDisplayedScrollingRowIndex = saveRow;
        }
        
        public DDV()
        {
            InitializeComponent();
        }

        private void DDV_Load(object sender, EventArgs e)
        {
            onemogoci_tb();
            Design();
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
            dgv1.Columns[2].Width = 147;
            dgv1.Columns[0].Name = "Id";
            dgv1.Columns[1].Name = "Opis";
            dgv1.Columns[2].Name = "Stopnja";
            dgv1.Columns["Id"].Visible = false;
            this.dgv1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv1.Focus();
        }

        private void Display()
        {
            Izprazni_dgv();
            string q = "select * from tbl_DDV";
            try
            {
                cmd = new SqlCommand(q, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tid = (int)rdr["Id"];
                    topis = (string)rdr["Opis"]; // Opis
                    tstopnja = (Double)rdr["Stopnja"];  // določi id v katerega boš pisal
                    string strid = Convert.ToString(tid);
                    string strstopnja = Convert.ToString(tstopnja);
                    string[] row1 = new string[] { strid, topis, strstopnja };
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
                    string q = "delete from tbl_DDV where id = @tid";
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
            float vrednost;
            if (!float.TryParse(tb2.Text, out vrednost))
            {
                tb2.Focus();
                MessageBox.Show("Stopnja DDV mora biti številka!");
                return;
            }
            else
            {
                string q;
                if (tb1.Text != "" && tb2.Text != "")
                {
                    topis = tb1.Text;
                    strstopnja = tb2.Text;
                    tstopnja = Convert.ToDouble(strstopnja);
                    try
                    {
                        if (dodaj == 1)
                        {
                           // dodaj
                            q = "insert into tbl_DDV(opis,stopnja) values(@topis,@tstopnja)";
                            cmd = new SqlCommand(q, con);
                            con.Open();
                            cmd.Parameters.AddWithValue("@topis", topis);
                            cmd.Parameters.AddWithValue("@tstopnja", tstopnja);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            // spremeni
                            q = "update tbl_DDV set opis = @topis, stopnja= @tstopnja where id=@tid";
                            cmd = new SqlCommand(q, con);
                            con.Open();
                            cmd.Parameters.AddWithValue("@tid", tid);
                            cmd.Parameters.AddWithValue("@topis", topis);
                            cmd.Parameters.AddWithValue("@tstopnja", tstopnja);
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
        }

        private void btnShrani_Click(object sender, EventArgs e)
        {
        }

        private void btnNazaj_Click(object sender, EventArgs e)
        {
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSpremeni_Click(object sender, EventArgs e)
        {
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
        }

        private void dgv1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = dgv1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tid = Convert.ToInt32(index);
            tb1.Text = dgv1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb2.Text = dgv1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Spremeni();
        }

        private void tb1_Enter(object sender, EventArgs e)
        {
//            Shrani();
        }

        private void tb1_KeyPress(object sender, KeyPressEventArgs e)
        {

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

        private void dgv1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
        }

        private void dgv1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btnDodaj_Click_1(object sender, EventArgs e)
        {
            Dodaj();
        }

        private void btnSpremeni_Click_1(object sender, EventArgs e)
        {
            tb1.Text = dgv1.SelectedCells[1].Value.ToString();
            tb2.Text = dgv1.SelectedCells[2].Value.ToString();
            tid = Convert.ToInt32(index);
            Spremeni();
        }

        private void btnBrisi_Click_1(object sender, EventArgs e)
        {
            index = dgv1.SelectedCells[0].Value.ToString();
            tid = Convert.ToInt32(index);
            Brisi();
        }

        private void btnPreklici_Click_1(object sender, EventArgs e)
        {
            Preklici();
        }

        private void btnShrani_Click_1(object sender, EventArgs e)
        {
            Shrani();
        }

        private void btnNazaj_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    } // partial
}  // namespace
