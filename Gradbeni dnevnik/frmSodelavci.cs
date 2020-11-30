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
//using System.Drawing;

namespace Komunala
{
    public partial class frmSodelavci : Form
    {
        SqlConnection con = frmMain.c;
        SqlConnection con2 = frmMain.c2;
        SqlConnection con3 = frmMain.c3;

        SqlCommand cmd;
        SqlDataReader rdr = null;

        int dodaj;
        string tskupina = "";
        string index;
        string stindeks;
        int tid, tindeks;

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
            onemogoci_tb();
            Grid();
            Display();
            Zacetek();
        }

        private void Design()
        {
           //  frmSodelavci.DefaultBackColor = Color_ozadje;
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
            dgv1.Columns[1].Width = 240;
            dgv1.Columns[2].Width = 60;
            dgv1.Columns[0].Name = "Id";
            dgv1.Columns[1].Name = "Skupina";
            dgv1.Columns[2].Name = "Indeks";
            dgv1.Columns["Id"].Visible = false;
            this.dgv1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgv1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv1.Focus();

        }

        private void Display()
        {
            Izprazni_dgv();
            string q = "select * from tblSkupinestoritev order by indeks";
            try
            {
                cmd = new SqlCommand(q, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tid = (int)rdr["Id"];
                    tskupina = (string)rdr["skupina"]; // Opis
                    tindeks = (int)rdr["indeks"];  // določi id v katerega boš pisal
                    stindeks = Convert.ToString(tindeks);

                    string strid = Convert.ToString(tid);
                    string[] row1 = new string[] { strid, tskupina, stindeks };
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
            if (tb1.Text != "" && tb2.Text != "")
            {
                tskupina = tb2.Text;
                stindeks = tb1.Text;
                tindeks = Convert.ToInt32(stindeks);
                try
                {
                    if (dodaj == 1)
                    {
                        // dodaj
                        q = "insert into tblSkupinestoritev (skupina,indeks) values(@tskupina,@tindeks)";
                        cmd = new SqlCommand(q, con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@tskupina", tskupina);
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
                        cmd.Parameters.AddWithValue("@tskupina", tskupina);
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
    }
}
