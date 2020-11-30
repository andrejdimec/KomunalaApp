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
    public partial class frmDelovnaMesta : Form
    {
        SqlConnection con = frmMain.c;
        SqlConnection con2 = frmMain.c2;
        SqlConnection con3 = frmMain.c3;
        
        SqlCommand cmd;
        SqlDataReader rdr = null;

        SqlCommand cmd2;
        SqlDataReader rdr2 = null;

        string topis = "";
        string index, tnaziv, topomba;
        int tem,tddv;
        int id_enota,id_ddv;
        string strstopnja = "";
        double tstopnja,tura;
//        float tura;
        int tid;
        int dodaj = 0;

        public frmDelovnaMesta()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'komunala_ds.tbl_DDV' table. You can move, or remove it, as needed.
            this.tbl_DDVTableAdapter.Fill(this.komunala_ds.tbl_DDV);
            // TODO: This line of code loads data into the 'komunala_ds.tbl_Delovnamesta' table. You can move, or remove it, as needed.
            this.tbl_DelovnamestaTableAdapter1.Fill(this.komunala_ds.tbl_Delovnamesta);
            // TODO: This line of code loads data into the 'komunala_ds.tbl_Enote' table. You can move, or remove it, as needed.
             this.tbl_EnoteTableAdapter.Fill(this.komunala_ds.tbl_Enote);
            onemogoci_tb();
            Grid();
            Display();
            Zacetek();
        }

        private void Izprazni_dgv()
        {
            dgv2.Rows.Clear();
            dgv2.Refresh();
        }

        private void onemogoci_tb()
        {
            tb1.Enabled = false;
            tb2.Enabled = false;
            tb3.Enabled = false;
            cb3.Enabled = false;
            cb4.Enabled = false;

        }

        private void omogoci_tb()
        {
            tb1.Enabled = true;
            tb2.Enabled = true;
            tb3.Enabled = true;
            cb3.Enabled = true;
            cb4.Enabled = true;
        }

        private void izprazni_tb()
        {
            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            cb3.Text = "";
            cb4.Text = "";
        }

        private void Grid()
        {
            dgv2.ColumnHeadersVisible = true;
            dgv2.RowHeadersVisible = false;
            dgv2.ColumnCount = 6;
            dgv2.Columns[1].Width = 200;
            dgv2.Columns[2].Width = 150;
            dgv2.Columns[3].Width = 90;
            dgv2.Columns[4].Width = 90;
            dgv2.Columns[5].Width = 90;

            dgv2.Columns[0].Name = "Id";
            dgv2.Columns[1].Name = "Delovno mesto";
            dgv2.Columns[2].Name = "Opomba";
            dgv2.Columns[3].Name = "EM";
            dgv2.Columns[4].Name = "Ura/€";
            dgv2.Columns[5].Name = "DDV";
            dgv2.Columns["Id"].Visible = false;
            this.dgv2.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv2.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv2.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv2.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv2.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv2.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv2.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv2.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv2.Columns[1].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);
            dgv2.Columns[2].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0); 
            dgv2.Focus();
        }

        private void Display()
        {
            Izprazni_dgv();
            string q = "select * from tbl_Delovnamesta";
            try
            {
                cmd = new SqlCommand(q, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tid = (int)rdr["Id"];
                    int tenota = (int)rdr["enota"];
                    int tddv = (int)rdr["ddv"];

                    tnaziv = (string)rdr["naziv"]; // Opis
                    topomba = (string)rdr["opomba"]; // Opis
                    
                    //tura = (float)rdr["Ura"];  // določi id v katerega boš pisal
                    tura=2.23;
                    string strid = Convert.ToString(tid);
                    tura = (double)rdr["ura"];
                    string stura = string.Format("{0:N2}", tura);

                    //string stura = Convert.ToString(tura);
                    tem = (Int32)rdr["enota"];

                    // poišči enoto mere
                    string q2 = "select em from tbl_enote where id = @tid";  // če sta indexa iz ulic enaka
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@tid", tenota);
                    cmd2.ExecuteNonQuery();
                    string stem = (string)cmd2.ExecuteScalar();
                    con2.Close();

                    // poišči DDV
                    q2 = "select stopnja from tbl_ddv where id = @tid";  // če sta indexa iz ulic enaka
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@tid", tddv);
                    cmd2.ExecuteNonQuery();
                    double t2ddv = Convert.ToDouble (cmd2.ExecuteScalar());
                    string stddv = string.Format("{0:N1}", t2ddv);
                    con2.Close();

                    // napiši v grid
                    string[] row1 = new string[] { strid, tnaziv, topomba, stem, stura, stddv };
                    dgv2.Rows.Add(row1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka Display: " + ex.Message);
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
            // napolni cb1
            string q2 = "select * from tbl_enote";
            try
            {
                cmd2 = new SqlCommand(q2, con2);
                con2.Open();
                rdr2 = cmd2.ExecuteReader();
                cb3.Items.Clear();
                while (rdr2.Read())
                    {
                       cb3.Items.Add(rdr2[1].ToString());
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka enota: " + ex.Message);
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
            // napolni cb4 - ddv
            q2 = "select * from tbl_ddv";
            try
            {
                cmd2 = new SqlCommand(q2, con2);
                con2.Open();
                rdr2 = cmd2.ExecuteReader();
                cb4.Items.Clear();
                while (rdr2.Read())
                {
                    cb4.Items.Add(rdr2[2].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka ddv reader: " + ex.Message);
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
            btnShrani.Enabled = false;
            btnPreklici.Enabled = false;
            btnDodaj.Enabled = true;
            btnBrisi.Enabled = true;
            btnSpremeni.Enabled = true;
            btnNazaj.Enabled = true;
            //Display();
            dgv2.Focus();
        }

        private void Brisi()
        {
            DialogResult result = MessageBox.Show("Izbrišem zapis?", "Potrdi brisanje", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string q = "delete from tbl_Delovnamesta where id = @tid";
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
            if (!float.TryParse(tb3.Text, out vrednost))
            {
                tb3.Focus();
                MessageBox.Show("Urna postavka mora biti število!");
                return;
            }
            else
            {
                string q;
                if (tb1.Text != "")
                {
                    tnaziv = tb1.Text;
                    topomba = tb2.Text;
                    string strura = tb3.Text;
                    string strtenota = cb3.Text;
                    string strddv = cb4.Text;
                    double double_ddv= Convert.ToDouble(strddv);
                    tura = Convert.ToDouble(strura);

                    // poišči index od enote
                    string q2 = "select Id from tbl_enote where @tenota=em";
                    try
                    {
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@tenota", strtenota);
                        cmd2.ExecuteNonQuery();
                        id_enota = Convert.ToInt32(cmd2.ExecuteScalar());
                        con2.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka enota: " + ex.Message);
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
                    // poišči index od ddv
                    q2 = "select Id from tbl_ddv where @tddv=stopnja";
                    try
                    {
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@tddv", double_ddv);
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("idddv " + Convert.ToString(id_ddv));
                        id_ddv = Convert.ToInt32(cmd2.ExecuteScalar());
                        con2.Close();
                        MessageBox.Show("idddv "+Convert.ToString(id_ddv));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka enota: " + ex.Message);
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

                    try
                    {
                        if (dodaj == 1)
                        {
                            // dodaj
                            q = "insert into tbl_Delovnamesta(naziv,opomba,ura,enota,ddv) values(@tnaziv,@topomba,@tura,@tenota,@tddv)";
                            cmd = new SqlCommand(q, con);
                            con.Open();
                            cmd.Parameters.AddWithValue("@tnaziv", tnaziv);
                            cmd.Parameters.AddWithValue("@topomba", topomba);
                            cmd.Parameters.AddWithValue("@tura", tura);
                            cmd.Parameters.AddWithValue("@tenota", id_enota);
                            cmd.Parameters.AddWithValue("@tddv", id_ddv);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            // spremeni
                            q = "update tbl_Delovnamesta set naziv=@tnaziv, opomba = @topomba, enota= @tenota, ura=@tura, ddv=@tddv where id=@tid";
                            cmd = new SqlCommand(q, con);
                            con.Open();
                            cmd.Parameters.AddWithValue("@tnaziv", tnaziv);
                            cmd.Parameters.AddWithValue("@topomba", topomba);
                            cmd.Parameters.AddWithValue("@tura", tura);
                            cmd.Parameters.AddWithValue("@tenota", id_enota);
                            cmd.Parameters.AddWithValue("@tddv", id_ddv);
                            cmd.Parameters.AddWithValue("@tid", tid);
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
            }
        }

        private void Dodaj()
        {
            dodaj = 1;
            omogoci_tb();
            izprazni_tb();
            cb3.SelectedIndex = 3;
            cb4.SelectedIndex = 0;
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
            index = dgv2.SelectedCells[0].Value.ToString();
            tid = Convert.ToInt32(index);
            tb1.Text = dgv2.SelectedCells[1].Value.ToString();
            tb2.Text = dgv2.SelectedCells[2].Value.ToString();
            tb3.Text = dgv2.SelectedCells[4].Value.ToString();
            cb3.Text = dgv2.SelectedCells[3].Value.ToString();
            cb4.Text = dgv2.SelectedCells[5].Value.ToString();
            //// poišči in vpiši enoto
            //string q2 = "select em from tbl_enote where id=";
            //try
            //{
            //    cmd2 = new SqlCommand(q2, con2);
            //    con2.Open();
            //    rdr2 = cmd2.ExecuteReader();
            //    cb3.Items.Clear();
            //    while (rdr2.Read())
            //    {
            //        cb3.Items.Add(rdr2[1].ToString());
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Napaka enota: " + ex.Message);
            //}
            //finally
            //{
            //    if (rdr2 != null)
            //    {
            //        rdr2.Close();
            //    }
            //    if (con2 != null)
            //    {
            //        con2.Close();
            //    }
            //}
            // napolni cb4 - ddv
            //q2 = "select * from tbl_ddv";
            //try
            //{
            //    cmd2 = new SqlCommand(q2, con2);
            //    con2.Open();
            //    rdr2 = cmd2.ExecuteReader();
            //    cb4.Items.Clear();
            //    while (rdr2.Read())
            //    {
            //        cb4.Items.Add(rdr2[1].ToString());
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Napaka ddv reader: " + ex.Message);
            //}
            //finally
            //{
            //    if (rdr2 != null)
            //    {
            //        rdr2.Close();
            //    }
            //    if (con2 != null)
            //    {
            //        con2.Close();
            //    }
            //}


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

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Dodaj();
        }

        private void btnSpremeni_Click(object sender, EventArgs e)
        {
            Spremeni();
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            index = dgv2.SelectedCells[0].Value.ToString();
            tid = Convert.ToInt32(index);
            Brisi();
        }

        private void dgv1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Spremeni();
        }

        private void btnPreklici_Click(object sender, EventArgs e)
        {
            Preklici();
        }

        private void dgv1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgv1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void dgv2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Spremeni();
            }
        }

        private void dgv2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Spremeni();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNazaj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void dgv1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Spremeni();
            }
        }

        private void btnShrani_Click(object sender, EventArgs e)
        {
            //this.tbl_DelovnamestaBindingSource.EndEdit();
            Shrani();
        }
    } // partial
}  // namespace
