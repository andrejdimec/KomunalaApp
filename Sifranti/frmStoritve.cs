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
//- using Komunala.komunala_dsTableAdapters;
using System.Configuration;


namespace Komunala
{
    public partial class frmStoritve : Form
    {
        SqlConnection con = frmMain.c;
        SqlConnection con2 = frmMain.c2;
        SqlConnection con3 = frmMain.c3;

        SqlCommand cmd;
        SqlDataReader rdr = null;

        SqlCommand cmd2;
        SqlDataReader rdr2 = null;

        int tceniko, tcenikt, tskupina, tem, id_enota, id_storitev, id_skupina,id_ddv;
        string stskupina, tstoritev, stem, stceniko, stcenikt,stddv;
        int prvic; // za sort
        string topis = "";
        string index;
        string tvozilo;
        int tid = 0;
        int dodaj = 0;
        double tddv;
        string sort; // po čem naj sortira pri display
        string q, q2; // query string
        bool shrani_ok;

        public frmStoritve()
        {
            InitializeComponent();
        }

        private void frmVozila_Load(object sender, EventArgs e)
        {
            prvic = 1;
            onemogoci_tb();
            Design();
            Display();

            //Zacetek();
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
            cbed1.BackColor = frmMain.bela;
            cbed1.ForeColor = Color.Black;

            //cb1e.BackColor = frmMain.bela;
            cb2.BackColor = frmMain.bela;
            cb3.BackColor = frmMain.bela;
            //tb2.BackColor = frmMain.bela;

            this.BackColor = frmMain.barva_form_back; // Form ozadje
            this.Text = frmMain.nazivPrograma; // Form tekst

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

        private void Izprazni_dgv()
        {
            dgv1.Rows.Clear();
            dgv1.Refresh();
        }

        private void onemogoci_tb()
        {
            tb1.Enabled = false;
            cbed1.DropDownStyle = ComboBoxStyle.DropDownList;
            cb3.DropDownStyle = ComboBoxStyle.DropDownList;
            cb2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbed1.Enabled = false;
            cb2.Enabled = false;
            cb3.Enabled = false;
        }

        private void omogoci_tb()
        {
            tb1.Enabled = true;
            cbed1.Enabled = true;
            cbed1.DropDownStyle = ComboBoxStyle.DropDown;
            cb2.DropDownStyle = ComboBoxStyle.DropDown;
            cb3.DropDownStyle = ComboBoxStyle.DropDown;
            cb2.Enabled = true;
            cb3.Enabled = true;
        }

        private void izprazni_tb()
        {
            tb1.Text = "";
            cbed1.Text = "";
            cb2.Text = "";
            cb3.Text = "";
        }

        private void Display()
        {
            bool boolt, boolo;
            dgv1.ColumnHeadersVisible = true;
            Izprazni_dgv();
            sort = "storitev asc";
            if (prvic == 1)
            {
                q=  "SELECT TblStoritve.Id,TblStoritve.Storitev, tbl_DDV.Stopnja, tbl_Enote.em AS Expr3, tblSkupinestoritev.Skupina AS Expr5 "+
                    "FROM TblStoritve INNER JOIN tblSkupinestoritev ON TblStoritve.Skupina = tblSkupinestoritev.Id INNER JOIN "+
                    "tbl_DDV ON TblStoritve.Ddv = tbl_DDV.Id INNER JOIN tbl_Enote ON TblStoritve.Em = tbl_Enote.Id order by " + sort;
                prvic = 0;
            }
            else
            {
                q = "SELECT TblStoritve.Id,TblStoritve.Storitev, tbl_DDV.Stopnja, tbl_Enote.em AS Expr3, tblSkupinestoritev.Skupina AS Expr5 " +
                    "FROM TblStoritve INNER JOIN tblSkupinestoritev ON TblStoritve.Skupina = tblSkupinestoritev.Id INNER JOIN " +
                    "tbl_DDV ON TblStoritve.Ddv = tbl_DDV.Id INNER JOIN tbl_Enote ON TblStoritve.Em = tbl_Enote.Id order by " + sort;
            }
            try
            {
                cmd = new SqlCommand(q, con);
                con.Open();
                //cmd.Parameters.AddWithValue("@sort", sort);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tid = (int)rdr["Id"];
                    string tstoritev = (string)rdr["storitev"]; // Opis
                    string strid = Convert.ToString(tid);

                    string stem = (string)rdr["Expr3"];
                    string stskupina = (string)rdr["Expr5"];
                    double temp_ddv_double = (Double)rdr["Stopnja"];

                    if (tceniko == 1)
                    {
                        boolo = true;
                    }
                    else
                    {
                        boolo = false;
                    }

                    if (tcenikt == 1)
                    {
                        boolt = true;
                    }
                    else
                    {
                        boolt = false;
                    }
                    DataGridViewTextBoxCell Id = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell Storitev = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell Em = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell ddv = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell skupina = new DataGridViewTextBoxCell();

                    Id.Value = tid;
                    Storitev.Value = tstoritev;
                    Em.Value = stem;
                    skupina.Value = stskupina;
                    ddv.Value = temp_ddv_double;

                    DataGridViewColumn kolid = dgv1.Columns[0];
                    kolid.Width = 1;
                    DataGridViewColumn kolstoritev = dgv1.Columns[1];
                    kolstoritev.Width = 507;
                    DataGridViewColumn kolem = dgv1.Columns[2];
                    kolem.Width = 70;
                    DataGridViewColumn kolddv = dgv1.Columns[3];
                    kolddv.Width = 70;
                    DataGridViewColumn kolskupina = dgv1.Columns[4];
                    kolskupina.Width = 276;

                    kolstoritev.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    kolem.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolddv.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolskupina.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    DataGridViewRow row = new DataGridViewRow();

                    row.Cells.Add(Id);
                    row.Cells.Add(Storitev);
                    row.Cells.Add(Em);
                    row.Cells.Add(ddv);
                    row.Cells.Add(skupina);

                    dgv1.Rows.Add(row);  // dodaj vrstico
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka display: " + ex.Message);
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
            Zacetek();
        }

        private void Zacetek()
        {
            dodaj = 0;
            izprazni_tb();
            onemogoci_tb();

            // napolni cb1 - skupine
            q2 = "select * from tblskupinestoritev";
            try
            {
                cmd2 = new SqlCommand(q2, con2);
                con2.Open();
                rdr2 = cmd2.ExecuteReader();
                cbed1.Items.Clear();
                while (rdr2.Read())
                {
                    cbed1.Items.Add(rdr2[1].ToString());
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
            // napolni cb2 - enote
            q2 = "select * from tbl_enote";
            try
            {
                cmd2 = new SqlCommand(q2, con2);
                con2.Open();
                rdr2 = cmd2.ExecuteReader();
                cb2.Items.Clear();
                while (rdr2.Read())
                {
                    cb2.Items.Add(rdr2[1].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka napolni enote - reader: " + ex.Message);
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

            // napolni cb3 - ddv
            q2 = "select * from tbl_ddv";
            try
            {
                cmd2 = new SqlCommand(q2, con2);
                con2.Open();
                rdr2 = cmd2.ExecuteReader();
                cb3.Items.Clear();
                while (rdr2.Read())
                {
                    cb3.Items.Add(rdr2[2].ToString());
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
                    q = "delete from tblStoritve where id = @tid";
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
            shrani_ok = true;
            if (cbed1.Text=="" || tb1.Text=="" || cb2.Text=="" || cb3.Text=="")
            {
                shrani_ok = false;
            }
            string q;
            if (shrani_ok != false)
            {
                tceniko = 1;
                tcenikt = 1;
                stskupina = cbed1.Text;
                tstoritev = tb1.Text;
                stem = cb2.Text;
                stddv = cb3.Text;
                tddv = Convert.ToDouble(stddv);
                // poišči index od enote
                q2 = "select Id from tbl_enote where @tenota=em";
                try
                {
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@tenota", stem);
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
                // poišči index od skupine
                q2 = "select Id from tblSkupinestoritev where @tstor=skupina";
                try
                {
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@tstor", stskupina);
                    cmd2.ExecuteNonQuery();
                    id_skupina = Convert.ToInt32(cmd2.ExecuteScalar());
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
                q2 = "select Id from tbl_ddv where stopnja=@tddv";
                try
                {
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@tddv", tddv);
                    cmd2.ExecuteNonQuery();
                    id_ddv = Convert.ToInt32(cmd2.ExecuteScalar());
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

                // dejansko shrani
                try
                {
                    if (dodaj == 1)
                    {
                        // dodaj
                        q = "insert into tblStoritve(storitev,skupina,em,ddv,ceniko,cenikt) values(@tstoritev,@tskupina,@tem,@tddv,@tceniko,@tcenikt)";
                        cmd = new SqlCommand(q, con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@tstoritev", tstoritev);
                        cmd.Parameters.AddWithValue("@tskupina", id_skupina);
                        cmd.Parameters.AddWithValue("@tem", id_enota);
                        cmd.Parameters.AddWithValue("@tddv", id_ddv);
                        cmd.Parameters.AddWithValue("@tceniko", 1);
                        cmd.Parameters.AddWithValue("@tcenikt", 1);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        // spremeni
                        q = "update tblStoritve set storitev = @tstoritev, skupina = @tskupina, em = @tem, ddv = @tddv,ceniko = @tceniko, cenikt = @tcenikt where id=@tid";
                        cmd = new SqlCommand(q, con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@tid", tid);
                        cmd.Parameters.AddWithValue("@tstoritev", tstoritev);
                        cmd.Parameters.AddWithValue("@tskupina", id_skupina);
                        cmd.Parameters.AddWithValue("@tem", id_enota);
                        cmd.Parameters.AddWithValue("@tddv", id_ddv);
                        cmd.Parameters.AddWithValue("@tceniko", 1);
                        cmd.Parameters.AddWithValue("@tcenikt", 1);
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
                Display();
            }
            else
            {
                MessageBox.Show("Napaka: Nobeno polje ne sme biti prazno.");
                tb1.Focus();
            }
//            Display();
        }

        private void Dodaj()
        {
            dodaj = 1;
            omogoci_tb();
            izprazni_tb();
            Gumbi_2();
            cbed1.Focus();
        }

        private void Spremeni()
        {
            dodaj = 0;
            omogoci_tb();
            index = dgv1.SelectedCells[0].Value.ToString();
            tid = Convert.ToInt32(index);

            cbed1.Text = dgv1.SelectedCells[4].Value.ToString();
            tb1.Text = dgv1.SelectedCells[1].Value.ToString();
            cb2.Text = dgv1.SelectedCells[2].Value.ToString();
            cb3.Text = dgv1.SelectedCells[3].Value.ToString();
            Gumbi_2();
            cbed1.Focus();
        }
        private void Preklici()
        {
            izprazni_tb();
            Zacetek();
        }

        private void btnShrani_Click_1(object sender, EventArgs e)
        {
            Shrani();
        }

        private void cb3_MouseClick_1(object sender, MouseEventArgs e)
        {
            cb3.DroppedDown = true;
        }

        private void cb3_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Preklici();
            }
        }

        private void cb1e_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tb1.Focus();
            if (e.KeyCode == Keys.Escape)
            {
                Preklici();
            }
        }

        private void cb1e_MouseClick(object sender, MouseEventArgs e)
        {
            cbed1.DroppedDown = true;
        }

        private void cbed1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbed1_MouseClick(object sender, MouseEventArgs e)
        {
            cbed1.DroppedDown = true;
        }

        private void cbed1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tb1.Focus();
            // prekliči
            if (e.KeyCode == Keys.Escape)
            {
                Preklici();
            }
        }

        private void cb1_MouseClick_1(object sender, MouseEventArgs e)
        {
            cbed1.DroppedDown = true;
        }

        private void cb1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tb1.Focus();
            //{
            //    Shrani();
            //}
            // prekliči
            if (e.KeyCode == Keys.Escape)
            {
                Preklici();
            }
        }

        private void cb2_KeyDown_1(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                    cb3.Focus();
                //{
                //    Shrani();
                //}
                // prekliči
                if (e.KeyCode == Keys.Escape)
                {
                    Preklici();
                }
        }

        private void cb2_MouseClick_1(object sender, MouseEventArgs e)
        {
            cb2.DroppedDown = true;
        }

        private void dgv1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            index = dgv1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tid = Convert.ToInt32(index);
            tb1.Text = dgv1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //tb2.Text = dgv1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Spremeni();
        }

        private void tb1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cb2.Focus();
            }
            // prekliči
            if (e.KeyCode == Keys.Escape)
            {
                Preklici();
            }
        }

        private void dgv1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tb1.Text = dgv1.SelectedCells[1].Value.ToString();
                tid = Convert.ToInt32(index);
                Spremeni();
            }
        }

        private void btnDodaj_Click_1(object sender, EventArgs e)
        {
            Dodaj();
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

        private void btnNazaj_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSpremeni_Click_1(object sender, EventArgs e)
        {
            Spremeni();
        }

        private void frmVozila_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                if (btnDodaj.Enabled == true)
                {

                    Dodaj();
                }
            }

            if (e.KeyCode == Keys.F3)
            {
                if (btnDodaj.Enabled == true)
                {
                    tb1.Text = dgv1.SelectedCells[1].Value.ToString();
                    tid = Convert.ToInt32(index);
                    Spremeni();
                }
            }
            if (e.KeyCode == Keys.F5)
            {
                if (btnShrani.Enabled == true)
                {
                    Shrani();
                }
            }

            if (e.KeyCode == Keys.Delete)
            {
                if (btnBrisi.Enabled == true)
                {
                    index = dgv1.SelectedCells[0].Value.ToString();
                    tid = Convert.ToInt32(index);
                    Brisi();
                }
            }

        }
    }
}
