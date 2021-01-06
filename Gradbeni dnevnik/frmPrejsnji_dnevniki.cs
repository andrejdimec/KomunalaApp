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
using System.Net;

namespace Komunala
{
    public partial class frmPrejsnji_dnevniki : Form
    {
        SqlConnection con = frmMain.c;
        SqlConnection con2 = frmMain.c2;
        SqlConnection con3 = frmMain.c3;

        SqlCommand cmd;
        SqlDataReader rdr = null;

        SqlCommand cmd2;
        SqlDataReader rdr2 = null;

        // spremenljivke
        public static int index_izpis;
        public static int index_nazaj;
        public static bool odpri;
        public static bool iz_prejsnji;
        public static string prejsnji_objekt;

        string q, q2,prvi_objekt,str_index_nazaj; // query
        int tstevilka, idx_dnevnik,idx_objekt;
        DateTime tdatum;
        bool prvi;

        public frmPrejsnji_dnevniki()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPrejsnji_dnevniki_Load(object sender, EventArgs e)
        {
            Design();
            Zacetek();
            Display();
            // Novi_dnevnik();
        }

        private void Design()
        {
            crtal.AutoSize = false;
            crtal.Height = 1;
            crtal.BorderStyle = BorderStyle.Fixed3D;


            // gumbi
            btnBrisi.BackColor = frmMain.barva_gumb2_neakt; btnBrisi.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnNazaj.BackColor = frmMain.barva_gumb2_neakt; btnNazaj.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnOdpri.BackColor = frmMain.barva_gumb2_neakt; btnOdpri.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnIzpis.BackColor = frmMain.barva_gumb2_neakt; btnIzpis.ForeColor = frmMain.barva_gumb2_pis_akt;

            this.BackColor = frmMain.barva_form_back; // Form ozadje
            this.Text = frmMain.nazivPrograma; // Form tekst
        }

            private void btnIzpis_Click(object sender, EventArgs e)
        {
            Izpis();
        }

        private void btnNazaj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cb1_MouseClick(object sender, MouseEventArgs e)
        {
            cb1.DroppedDown = true;
        }

        private void Odpri()
        {
            
            odpri = true;
            // prenesi dnevnik nazaj v urejanje
            str_index_nazaj = dgv1.SelectedCells[0].Value.ToString();
            prejsnji_objekt = dgv1.SelectedCells[3].Value.ToString();
            index_nazaj = Convert.ToInt32(str_index_nazaj);
            // MessageBox.Show("index nazaj "+str_index_nazaj);
            this.DialogResult = DialogResult.Cancel;

        }

        private void Izpis()
        {
            iz_prejsnji = true;
            Gradbeni_dnevnik.iz_gradbeni = false;
            odpri = false;
            // prenesi dnevnik v izpis
            str_index_nazaj = dgv1.SelectedCells[0].Value.ToString();
            prejsnji_objekt = dgv1.SelectedCells[3].Value.ToString();
            index_nazaj = Convert.ToInt32(str_index_nazaj);
            //MessageBox.Show("index za izpis " + str_index_nazaj);
            frmDnevnik_Izpis secondForm = new frmDnevnik_Izpis();
            secondForm.ShowDialog();
            iz_prejsnji = false;

            // this.DialogResult = DialogResult.Cancel;

        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            // brisanje dnevnika
            string stev_brisi = dgv1.SelectedCells[1].Value.ToString();
            DialogResult result = MessageBox.Show("Ali želiš izbrisati gradbeni dnevnik št. "+stev_brisi+"?", " Potrdi brisanje dnevnika. ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // MessageBox.Show("Brišem stari dnevnik");
                str_index_nazaj = dgv1.SelectedCells[0].Value.ToString();
                index_nazaj = Convert.ToInt32(str_index_nazaj);
                try
                {
                    q = "delete from tbl_dnevnik where id = @tid";
                    cmd = new SqlCommand(q, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@tid", index_nazaj);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka pri brisanju dnevnika : " + ex.Message);
                }
                finally
                {
                    if (con != null)
                    {
                        con.Close();
                    }
                }
                // izbriši storitve
                try
                {
                    q = "delete from tbl_storitve_dnevnik where id_dnevnik = @tid";
                    cmd = new SqlCommand(q, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@tid", index_nazaj);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka pri brisanju storitev: " + ex.Message);
                }
                finally
                {
                    if (con != null)
                    {
                        con.Close();
                    }
                }

                // izbriši storitve situacije
                try
                {
                    q = "delete from tbl_situacija_storitve where id_dnevnik = @tid";
                    cmd = new SqlCommand(q, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@tid", index_nazaj);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka pri brisanju storitev siruacije: " + ex.Message);
                }
                finally
                {
                    if (con != null)
                    {
                        con.Close();
                    }
                }

                Display();
            }
        }

        private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Odpri();

        }

        private void btnOdpri_Click(object sender, EventArgs e)
        {
            Odpri();

            //odpri = true;
            //// prenesi dnevnik nazaj v urejanje
            //str_index_nazaj = dgv1.SelectedCells[0].Value.ToString();
            //prejsnji_objekt = dgv1.SelectedCells[3].Value.ToString();
            //index_nazaj = Convert.ToInt32(str_index_nazaj);
            //this.DialogResult = DialogResult.Cancel;
            ////MessageBox.Show(dgv1.SelectedCells[1].Value.ToString());
        }

        private void cb1_SelectedValueChanged(object sender, EventArgs e)
        {
            Display();
        }

        private void Izprazni_dgv()
        {
            dgv1.Rows.Clear();
            dgv1.Refresh();
        }

        private void Display()  // napolni grid
        {

            // Poišči objekt
            Izprazni_dgv();
            string tmp_objekt = cb1.Text;
            if (tmp_objekt !="")
            {

                //q2 = "select id from tbl_delovisca where naziv = @tmp_objekt";
                //try
                //{
                //    con2.Open();
                //    cmd2.Parameters.AddWithValue("@tmp_objekt", tmp_objekt);
                //    cmd2.ExecuteNonQuery();
                //    idx_objekt = (int)cmd2.ExecuteScalar();
                //    con2.Close();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Napaka: Poišči idx objekta : " + ex.Message);
                //}

                // Napolni mrežo


                if (cb1.Text != "")
                {
                    q2 = "select * from tbl_dnevnik where objekt=@tmp_objekt order by leto desc, stevilka desc";
                    try
                    {
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@tmp_objekt", tmp_objekt);
                        rdr2 = cmd2.ExecuteReader();
                        //cb1.Items.Clear();
                        while (rdr2.Read())
                        {
                            tstevilka = (int)rdr2["stevilka"];
                            idx_dnevnik = (int)rdr2["id"];
                            tdatum = (DateTime)rdr2["datum"];

                            DataGridViewTextBoxCell Id = new DataGridViewTextBoxCell();
                            DataGridViewTextBoxCell St = new DataGridViewTextBoxCell();
                            DataGridViewTextBoxCell Datum = new DataGridViewTextBoxCell();
                            DataGridViewTextBoxCell Objekt = new DataGridViewTextBoxCell();

                            DataGridViewColumn kolid = dgv1.Columns[0];
                            kolid.Width = 10;
                            DataGridViewColumn kolst = dgv1.Columns[1];
                            kolst.Width = 80;
                            DataGridViewColumn koldatum = dgv1.Columns[2];
                            koldatum.Width = 130;
                            DataGridViewColumn kolobjekt = dgv1.Columns[3];
                            kolobjekt.Width = 230;

                            kolid.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                            kolst.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            koldatum.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            kolobjekt.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                            St.Value = tstevilka;
                            Datum.Value = tdatum;
                            Id.Value = idx_dnevnik;
                            Objekt.Value = tmp_objekt;


                            DataGridViewRow row = new DataGridViewRow();

                            row.Cells.Add(Id);
                            row.Cells.Add(St);
                            row.Cells.Add(Datum);
                            row.Cells.Add(Objekt);

                            dgv1.Rows.Add(row);  // dodaj vrstico

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka: Poišči dnevnike  " + ex.Message);
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
                else
                {
                        MessageBox.Show("Objekt ne more biti prazen");
                }

            } // if != ""
           
        }
       
        private void Zacetek()
        {
            //Display();
            odpri = false;
            prvi = true;
            // Napolni cb1
            q2 = "select * from tbl_delovisca order by naziv";
            try
            {
                cmd2 = new SqlCommand(q2, con2);
                con2.Open();
                rdr2 = cmd2.ExecuteReader();
                cb1.Items.Clear();
                while (rdr2.Read())
                {
                    string objekt = (string)rdr2["naziv"];
                    //int id_objekta = (int)rdr2["id_delovisca"];
                    cb1.Items.Add(objekt);
                    if (prvi==true)
                    {
                        prvi_objekt = objekt;
                        prvi = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: Dodaj objekte cb1  " + ex.Message);
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
            cb1.Text = prvi_objekt;
        }
    } // partial

}
