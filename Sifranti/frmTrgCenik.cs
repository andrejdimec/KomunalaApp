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
using System.Globalization;


namespace Komunala
{
    public partial class frmTrgCenik : Form
    {
        SqlConnection con = frmMain.c;
        SqlConnection con2 = frmMain.c2;
        SqlConnection con3 = frmMain.c3;
        SqlCommand cmd;
        SqlDataReader rdr = null;

        SqlCommand cmd2;
        SqlDataReader rdr2 = null;

        SqlCommand cmd3;

        string index;
        int zac;
        int id_enota;
        double tcenao, tcenat;
        int tid;
        int dodaj = 0;
        //string sort; // po čem naj sortira pri display
        string q, q2, q3; // query string
        int prvic; // za sort
                   //        float ttrg = 0;
                   //        float tobcina = 0;
        int tskupina, storitev_em, storitev_int;
        string tstoritev, ststoritev, stem, stskupina, storitev_string;
        int rezultat_int;
        string vse_skupine_storitev = "Vse skupine storitev";
        string temp_skupina;
        bool drugi_display = true;
        int id_storitev, id_skupina;
        //int idx_storitev;
        bool dgvprvic;
        //string skupina_zavpis;
        int index_spremeni, idx_display;
        bool shranjevanje, dodajanje, prikazi_vse;
        bool spreminjanje = false;
        int stara_skupina; // po spreminjanju napolni staro skupino
        string zacasna_skupina, skupina_za_prikaz;
        int vsestoritve_idx, skupina_za_prikaz_idx; // za prikaz je vse storitve
        string stara_skupina_str, vsestoritve_str, skupina_za_prikaz_str;
        string rezultat_str;

        string storitev_em_str, strid, cenao_string, cenat_string;
        int aktivni_indeks, id_skupine, vse_skupine, aktivni_indeks_storitve, aktivni_indeks_em;
        int ne_shrani;
        int tmp_em;
        string enota_str;

        private void cb2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tb1.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Preklici();
            }
            if (e.KeyCode == Keys.Down)
            {
                cb2.DroppedDown = true;
            }
        }

        private void tb1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tb1.Text == "")
                    tb1.Text = "0,00";
                double tmp_cena = Convert.ToDouble(tb1.Text);
                tb2.Text = Convert.ToString(Izračunaj_ddv22(tmp_cena));
                tb3.Text = Convert.ToString(Izračunaj_ddv95(tmp_cena));
                //tb4.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Preklici();
            }
        }

        private void cb2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (spreminjanje == true)
            {
                tb7.Text = storitev_em_str;
            }
            if (dodajanje == true)
            {
                q2 = "select em from tblstoritve where storitev = @tstoritev";  // če sta indexa iz ulic enaka
                cmd3 = new SqlCommand(q2, con3);
                con3.Open();
                cmd3.Parameters.AddWithValue("@tstoritev", cb2.Text);
                cmd3.ExecuteNonQuery();
                tmp_em = (int)cmd3.ExecuteScalar();
                con3.Close();
                tb7.Text = naziv_em(tmp_em);

                //   Poišči id skupine
                q2 = "select skupina from tblstoritve where storitev = @tstoritev";  // če sta indexa iz ulic enaka
                cmd3 = new SqlCommand(q2, con3);
                con3.Open();
                cmd3.Parameters.AddWithValue("@tstoritev", cb2.Text);
                cmd3.ExecuteNonQuery();
                int tmp_sku = (int)cmd3.ExecuteScalar();
                con3.Close();
                vpisi_skupino(tmp_sku);
            }


        }

        private void tb1_Leave(object sender, EventArgs e)
        {
            if (tb1.Text == "")
            {
                tb1.Text = "0,00";
            }
            // zamenjaj decimalno piko z vejico
            string tmp_1 = tb1.Text;
            tmp_1 = tmp_1.Replace(".", ",");
            tb1.Text = tmp_1;
            if (IsNumeric(tb1.Text) == false)
            {
            }
            else
            {
                double tmp_cena = Convert.ToDouble(tb1.Text);
                tb2.Text = Convert.ToString(Izračunaj_ddv22(tmp_cena));
                tb3.Text = Convert.ToString(Izračunaj_ddv95(tmp_cena));
                //tb4.Focus();
            }

        }

        private void dgv1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Spremeni();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Preklici();
            }
        }

        private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Spremeni();
        }

        private void cb1_MouseClick(object sender, MouseEventArgs e)
        {
            cb1.DroppedDown = true;
        }

        private void cb2_Leave(object sender, EventArgs e)
        {
            tb1.Focus();
        }

        private void cb2_DropDownClosed(object sender, EventArgs e)
        {
            tb1.Focus();
        }

        private void frmTrgCenik_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                //MessageBox.Show("F2");
                if (btnDodaj.Enabled == true)
                {
                    Dodaj();
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                if (btnPreklici.Enabled == true)
                {
                    Preklici();
                }
            }
            if (e.KeyCode == Keys.F3)
            {
                if (btnSpremeni.Enabled == true)
                {
                    Spremeni();
                }
            }
            if (e.KeyCode == Keys.Delete)
            {
                if (btnBrisi.Enabled == true)
                {
                    Brisi();
                }
            }
            if (e.KeyCode == Keys.F5)
            {
                if (btnShrani.Enabled == true)
                {
                    Shrani();
                }
            }

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            temp_skupina = cb1.Text;
            Dodaj();
        }

        private void cb1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (spreminjanje == false && dodajanje == false)
            {
                if (cb1.Text == vse_skupine_storitev)
                {
                    prikazi_vse = true;
                    skupina_za_prikaz_str = vse_skupine_storitev;
                }
                else
                {
                    prikazi_vse = false;
                    skupina_za_prikaz_str = cb1.Text;
                    id_skupine = idx_skupine(skupina_za_prikaz_str);
                    skupina_za_prikaz_idx = id_skupine;
                    stara_skupina = id_skupine;
                }
                if (drugi_display == true)
                {
                    Izprazni_dgv();
                    Display();
                    //drugi_display = false;
                }
            }

        }

        private void dgv1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Spremeni();
        }

        private void tb2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Shrani();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Preklici();
            }

        }

        private void btnNazaj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnShrani_Click(object sender, EventArgs e)
        {
            Shrani();
        }

        private void cb2_MouseClick(object sender, MouseEventArgs e)
        {
            cb2.DroppedDown = true;
        }

        private void btnSpremeni_Click(object sender, EventArgs e)
        {
            Spremeni();
        }

        private void btnIzpis_Click(object sender, EventArgs e)
        {
            frmCenikt_Izpis secondForm = new frmCenikt_Izpis();
            secondForm.ShowDialog();
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            index = dgv1.SelectedCells[0].Value.ToString();
            tid = Convert.ToInt32(index);
            Brisi();
        }

        private void btnPreklici_Click(object sender, EventArgs e)
        {
            Preklici();
        }

        // variable za shrani
        string tstr_storitev, tstr_em, tstr_cenat, tstr_cenao, tstr_skupina;



        private void frmTrgCenik_Load(object sender, EventArgs e)
        {
            // prenesi tabelo
            //q = "select * from tbl_cenik";
            //cmd = new SqlCommand(q, con);
            ////cmd.Parameters.AddWithValue("@tmpskupina", skupina_za_prikaz_idx);
            //con.Open();
            //rdr = cmd.ExecuteReader();
            //while (rdr.Read())
            //{
            //    storitev_em = (int)rdr["em"];
            //    storitev_int = (int)rdr["storitev"];
            //    tskupina = (int)rdr["skupina"];
            //    tcenao = (Double)rdr["cena_obcina"];
            //    tcenat = 0;

            //    q2 = "insert into tbl_Cenik_trg(storitev,em,cena_obcina,skupina) values(@tstoritev,@tem,@tcenao,@tskupina)";
            //    cmd2 = new SqlCommand(q2, con2);
            //    con2.Open();
            //    cmd2.Parameters.AddWithValue("@tstoritev", storitev_int);
            //    cmd2.Parameters.AddWithValue("@tem", storitev_em);
            //    cmd.Parameters.AddWithValue("@tcenat", tcenat);
            //    cmd2.Parameters.AddWithValue("@tcenao", tcenao);
            //    cmd2.Parameters.AddWithValue("@tskupina", tskupina);
            //    cmd2.ExecuteNonQuery();
            //    con2.Close();
            //}
            //con.Close();
            //Environment.Exit(0);

                dgvprvic = true;
            prvic = 1;
            prikazi_vse = true;
            spreminjanje = false;
            onemogoci_tb();
            Zacetek();
            Display();
        }

        public frmTrgCenik()
        {
            InitializeComponent();
        }

        private void Izprazni_dgv()
        {
            dgv1.Rows.Clear();
            dgv1.Refresh();
        }

        private void onemogoci_tb()
        {
            //tb3.BackColor = Color.Black;
            tb3.BackColor = DefaultBackColor;
            tb2.BackColor = DefaultBackColor;
            tb7.BackColor = DefaultBackColor;
            //tb4.BackColor = DefaultBackColor;
            //tb5.BackColor = DefaultBackColor;
            //tb6.BackColor = DefaultBackColor;
            tb3.Enabled = false;
            tb2.Enabled = false;
            tb1.Enabled = false;
            tb7.Enabled = false;
            //tb5.Enabled = false;
            //tb6.Enabled = false;
            dgv1.Enabled = true;
            dgv2.Enabled = false;
            cb2.Enabled = false;
            cb1.Enabled = true;
        }

        private void omogoci_tb()
        {
            tb3.BackColor = Color.White;
            //  tb4.BackColor = Color.White;
            tb7.BackColor = Color.White;
            tb2.BackColor = Color.White;
            //tb5.BackColor = Color.White;
            //tb6.BackColor = Color.White;
            //tb6.ForeColor = Color.Black;
            //tb5.ForeColor = Color.Black;
            tb2.ForeColor = Color.Black;
            tb3.ForeColor = Color.Black;
            //tb4.ForeColor = Color.Black;
            //tb7.ForeColor = Color.Black;
            dgv1.Enabled = false;
            dgv2.Enabled = false;
            tb1.Enabled = true;
            tb2.Enabled = true;
            tb3.Enabled = true;
            tb7.Enabled = true;
            cb1.Enabled = false;
            cb2.Enabled = true;
        }

        private void izprazni_tb()
        {
            tb3.Text = "";
            tb2.Text = "";
            tb1.Text = "";
            //tb4.Text = "";
            //tb5.Text = "";
            //tb6.Text = "";
            tb7.Text = "";
            cb1.Text = "";
            cb2.Text = "";
        }

        public string naziv_storitve(int vhod) // poišči naziv storitve
        {
            string rezultat;
            q3 = "select storitev from tblstoritve where id = @indeks";
            try
            {
                cmd3 = new SqlCommand(q3, con3);
                con3.Open();
                cmd3.Parameters.AddWithValue("@indeks", vhod);
                cmd3.ExecuteNonQuery();
                rezultat_str = (string)cmd3.ExecuteScalar();
                con3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: naziv_storitve : " + ex.Message);
            }
            rezultat = rezultat_str;
            return rezultat;
        }

        public string naziv_skupine(int vhod) // poišči naziv skupine
        {
            string rezultat;
            q3 = "select skupina from tblskupinestoritev where id = @indeks";
            try
            {
                cmd3 = new SqlCommand(q3, con3);
                con3.Open();
                cmd3.Parameters.AddWithValue("@indeks", vhod);
                cmd3.ExecuteNonQuery();
                rezultat_str = (string)cmd3.ExecuteScalar();
                con3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: naziv_skupine : " + ex.Message);
            }
            rezultat = rezultat_str;
            return rezultat;
        }
        public string naziv_em(int vhod) // poišči naziv em
        {
            string rezultat;
            q3 = "select em from tbl_enote where id = @indeks";
            try
            {
                cmd3 = new SqlCommand(q3, con3);
                con3.Open();
                cmd3.Parameters.AddWithValue("@indeks", vhod);
                cmd3.ExecuteNonQuery();
                rezultat_str = (string)cmd3.ExecuteScalar();
                con3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: naziv_em : " + ex.Message);
            }
            rezultat = rezultat_str;
            return rezultat;
        }

        public int idx_skupine(string vhod) // poišči indeks skupine
        {
            int rezultat;

            // poišči naziv skupine
            q3 = "select id from tblSkupinestoritev where skupina = @indeks";
            try
            {
                cmd3 = new SqlCommand(q3, con3);
                con3.Open();
                cmd3.Parameters.AddWithValue("@indeks", vhod);
                cmd3.ExecuteNonQuery();
                // kaj če je null?
                rezultat_int = (int)cmd3.ExecuteScalar();
                con3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: idx_skupine : " + ex.Message);
            }
            rezultat = rezultat_int;
            return rezultat;
        }
        public int idx_storitve(string vhod) // poišči indeks storitve
        {
            int rezultat;
            q3 = "select id from tblStoritve where storitev = @indeks";
            try
            {
                cmd3 = new SqlCommand(q3, con3);
                con3.Open();
                cmd3.Parameters.AddWithValue("@indeks", vhod);
                cmd3.ExecuteNonQuery();
                rezultat_int = (int)cmd3.ExecuteScalar();
                con3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: idx_skupine : " + ex.Message);
            }
            rezultat = rezultat_int;
            return rezultat;
        }
        public int idx_em(string vhod) // poišči indeks em
        {
            int rezultat;
            q3 = "select id from tbl_enote where em = @indeks";
            try
            {
                cmd3 = new SqlCommand(q3, con3);
                con3.Open();
                cmd3.Parameters.AddWithValue("@indeks", vhod);
                cmd3.ExecuteNonQuery();
                rezultat_int = (int)cmd3.ExecuteScalar();
                con3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: idx_skupine : " + ex.Message);
            }
            rezultat = rezultat_int;
            return rezultat;
        }

        public void vpisi_skupino(int vhod) // vpiši skupino v cb1
        {
            cb1.Text = naziv_skupine(vhod);
        }

        private void Display()  // prikaži mrežo
        {

            dgv1.ColumnHeadersVisible = true;
            if (spreminjanje == true)
            {
                prikazi_vse = false;
            }

            if (dodajanje == true)
            {
                prikazi_vse = false;
            }

            if (prikazi_vse == true)
            {
                cb1.Text = skupina_za_prikaz_str;
                q = "select * from tbl_Cenik_trg order by skupina, storitev"; //vse skupina + sort;
            }
            else
            {
                cb1.Text = skupina_za_prikaz_str;

                q = "select * from tbl_Cenik_trg where skupina = @tmpskupina order by skupina, storitev"; //ena skupina + sort;
            }
            Izprazni_dgv();
            try
            {
                cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@tmpskupina", skupina_za_prikaz_idx);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    idx_display = (int)rdr["Id"];
                    storitev_em = (int)rdr["em"];
                    storitev_int = (int)rdr["storitev"];
                    tskupina = (int)rdr["skupina"];
                    tcenao = (Double)rdr["cena_obcina"];
                    //tcenat = (Double)rdr["cena_trg"];
                    strid = Convert.ToString(idx_display);
                    cenao_string = Convert.ToString(tcenao);
                    //cenat_string = Convert.ToString(tcenat);

                    stskupina = naziv_skupine(tskupina);
                    ststoritev = naziv_storitve(storitev_int);
                    storitev_em_str = naziv_em(storitev_em);

                    int sirina_znesek = 90; // širina kolone z zneski

                    dgv2.AllowUserToAddRows = false;
                    dgv2.RowHeadersVisible = false;

                    dgv2.ColumnCount = 2;
                    dgv2.Columns[0].Name = "";
                    dgv2.Columns[1].Name = "Cene za Občino";
                    //dgv2.Columns[2].Name = "Cene za trg";

                    dgv2.Rows.Add("", "", "Cene za Občino");
                    dgv2.Columns[0].Width = 359;
                    dgv2.Columns[1].Width = sirina_znesek * 3 + 17;
                    //dgv2.Columns[2].Width = sirina_znesek * 3;

                    this.dgv2.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    this.dgv2.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //this.dgv2.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    //this.dgv2.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    this.dgv2.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //this.dgv2.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


                    DataGridViewTextBoxCell Id = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell Storitev = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell Em = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell obcina = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell obcinaz22 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell obcinaz95 = new DataGridViewTextBoxCell();
                    //DataGridViewTextBoxCell trg = new DataGridViewTextBoxCell();
                    //DataGridViewTextBoxCell trgz22 = new DataGridViewTextBoxCell();
                    //DataGridViewTextBoxCell trgz95 = new DataGridViewTextBoxCell();
                    Id.Value = idx_display;
                    Storitev.Value = ststoritev;
                    Em.Value = storitev_em_str;
                    obcina.Value = tcenao;
                    obcinaz22.Value = tcenao * 1.22;
                    obcinaz95.Value = tcenao * 1.095;
                    //trg.Value = tcenat;
                    //trgz22.Value = tcenat * 1.22;
                    //trgz95.Value = tcenat * 1.095;

                    DataGridViewColumn kolid = dgv1.Columns[0];
                    kolid.Width = 1;
                    DataGridViewColumn kolstoritev = dgv1.Columns[1];
                    kolstoritev.Width = 309;
                    DataGridViewColumn kolem = dgv1.Columns[2];
                    kolem.Width = 50;
                    DataGridViewColumn kolobcina = dgv1.Columns[3];
                    kolobcina.Width = sirina_znesek;
                    DataGridViewColumn kolobcina22 = dgv1.Columns[4];
                    kolobcina22.Width = sirina_znesek;
                    DataGridViewColumn kolobcina95 = dgv1.Columns[5];
                    kolobcina95.Width = sirina_znesek;
                    //DataGridViewColumn koltrg = dgv1.Columns[6];
                    //koltrg.Width = sirina_znesek;
                    //DataGridViewColumn koltrg22 = dgv1.Columns[7];
                    //koltrg22.Width = sirina_znesek;
                    //DataGridViewColumn koltrg95 = dgv1.Columns[8];
                    //koltrg95.Width = sirina_znesek;

                    kolstoritev.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    kolem.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolobcina.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //                    koltrg.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //                  kolobcina.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    ////                  koltrg.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //                  kolem.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //                  kolobcina22.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    //                  kolobcina95.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //koltrg22.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //koltrg95.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    DataGridViewRow row = new DataGridViewRow();
                    //MessageBox.Show("display:"+Storitev);
                    row.Cells.Add(Id);
                    row.Cells.Add(Storitev);
                    row.Cells.Add(Em);
                    row.Cells.Add(obcina);
                    row.Cells.Add(obcinaz22);
                    row.Cells.Add(obcinaz95);
                    //row.Cells.Add(trg);
                    //row.Cells.Add(trgz22);
                    //row.Cells.Add(trgz95);

                    dgv1.Rows.Add(row);  // dodaj vrstico
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
            prvic = 0;
            drugi_display = true;
        }

        private void Zacetek()
        {
            drugi_display = false;
            dodaj = 0;
            izprazni_tb();
            onemogoci_tb();
            // če je prvič dodaj vse skupine v cb1
            if (prvic == 1)
            {
                q2 = "select * from tblskupinestoritev order by skupina";
                try
                {
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    rdr2 = cmd2.ExecuteReader();
                    cb1.Items.Clear();
                    while (rdr2.Read())
                    {
                        string zacasna_skupina = (string)rdr2["Skupina"];
                        int tindeks = (int)rdr2["Indeks"];
                        int tid_indeks = (int)rdr2["Id"];
                        cb1.Items.Add(zacasna_skupina);
                    }
                    cb1.Items.Add(vse_skupine_storitev);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: dodaj vse skupine v cb1  " + ex.Message);
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

                // če je prvič dodaj vse storitve v cb2
                q2 = "select * from tblstoritve order by storitev";
                try
                {
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    rdr2 = cmd2.ExecuteReader();
                    cb2.Items.Clear();
                    while (rdr2.Read())
                    {
                        string stor_zac = (string)rdr2["Storitev"];
                        //int tindeks = (int)rdr2["Indeks"];
                        int tid_indeks = (int)rdr2["Id"];
                        cb2.Items.Add(stor_zac);
                        {
                            aktivni_indeks_storitve = tid_indeks;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka skupina: " + ex.Message);
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
                // če je prvič dodaj vse em v cb3 ???? potrebno???
                q2 = "select * from tbl_enote order by em";
                try
                {
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    rdr2 = cmd2.ExecuteReader();
                    while (rdr2.Read())
                    {
                        string stor_zac = (string)rdr2["em"];
                        int tid_indeks = (int)rdr2["Id"];
                        {
                            aktivni_indeks_em = tid_indeks;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka! vpiši em v cb3:  " + ex.Message);
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
                temp_skupina = vse_skupine_storitev;
                cb1.Text = vse_skupine_storitev;

            }  // konec if prvic== 1
            prvic = 0;

            stara_skupina_str = cb1.Text;

            btnShrani.Enabled = false;
            btnPreklici.Enabled = false;
            btnDodaj.Enabled = true;
            btnBrisi.Enabled = true;
            btnSpremeni.Enabled = true;
            btnNazaj.Enabled = true;
        }

        private void Brisi()
        {
            temp_skupina = cb1.Text;
            DialogResult result = MessageBox.Show("Izbrišem zapis?", "Potrdi brisanje", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    q = "delete from tbl_cenik_trg where id = @tid";
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
        public static bool IsNumeric(object Expression)
        {
            double retNum;

            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }
        private void Shrani()
        {

            ne_shrani = 0;
            if (cb2.Text == "" || ne_shrani == 1)
            {
                cb2.Focus();
                MessageBox.Show("Storitev mora biti izbrana!");
                ne_shrani = 1;
            }
            if (IsNumeric(tb1.Text) == false)
            {
                MessageBox.Show("Cena za Občino mora biti število!");
                tb1.Focus();
                ne_shrani = 1;
            }
            //if (IsNumeric(tb4.Text) == false)
            //{
            //    MessageBox.Show("Cena za trg mora biti število!");
            //    tb4.Focus();
            //    ne_shrani = 1;
            //}

            if (ne_shrani == 0)
            {
                // string q;
                tstr_storitev = cb2.Text;
                tstr_em = tb7.Text;
                tstr_cenao = tb1.Text;
                //tstr_cenat = tb4.Text;
                tstr_skupina = cb1.Text;

                // poišči index od enote
                id_enota = idx_em(tstr_em);
                // poišči index od storitev
                id_storitev = idx_storitve(tstr_storitev);
                // poišči index od skupine
                id_skupina = idx_skupine(tstr_skupina);
                // pretvori cene v double
                tcenao = Convert.ToDouble(tstr_cenao);
                //tcenat = Convert.ToDouble(tstr_cenat);
                try
                {
                    // if (dodaj == 1)
                    if (dodajanje == true)
                    {
                        //MessageBox.Show("Shranjujem dodajanje!");
                        // dodaj
                        q = "insert into tbl_Cenik_trg(storitev,em,cena_obcina,skupina) values(@tstoritev,@tem,@tcenao,@tskupina)";
                        cmd = new SqlCommand(q, con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@tstoritev", id_storitev);
                        cmd.Parameters.AddWithValue("@tem", id_enota);
                        //cmd.Parameters.AddWithValue("@tcenat", tcenat);
                        cmd.Parameters.AddWithValue("@tcenao", tcenao);
                        cmd.Parameters.AddWithValue("@tskupina", id_skupina);
                        cmd.ExecuteNonQuery();
                    }
                    if (spreminjanje == true)

                    //  else
                    {
                        // spremeni
                        // MessageBox.Show("Shranjujem spreminjanje!");
                        q = "update tbl_Cenik_trg set storitev=@tstoritev, em = @tem, cena_obcina=@tcenao, skupina=@tskupina where id=@tid";
                        cmd = new SqlCommand(q, con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@tstoritev", id_storitev);
                        cmd.Parameters.AddWithValue("@tem", id_enota);
                        cmd.Parameters.AddWithValue("@tcenao", tcenao);
                        //cmd.Parameters.AddWithValue("@tcenat", tcenat);
                        cmd.Parameters.AddWithValue("@tskupina", id_skupina);
                        cmd.Parameters.AddWithValue("@tid", index_spremeni);
                        cmd.ExecuteNonQuery();
                        //con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka shrani: " + ex.Message);
                }
                finally
                {
                    if (con != null)
                    {
                        con.Close();
                    }
                }
                spreminjanje = false; // ni cb1 on change
                dodajanje = false; // ni cb1 on change
                izprazni_tb();
                onemogoci_tb();
                btnShrani.Enabled = false;
                btnPreklici.Enabled = false;
                btnDodaj.Enabled = true;
                btnBrisi.Enabled = true;
                btnSpremeni.Enabled = true;
                btnIzpis.Enabled = true;
                btnNazaj.Enabled = true;
                Display();    //?????
            }
        }


        private void Dodaj()
        {
            temp_skupina = cb1.Text;
            dodajanje = true;
            zac = 0;
            //dodaj = 1;
            omogoci_tb();
            izprazni_tb();
            btnShrani.Enabled = true;
            btnPreklici.Enabled = true;
            btnDodaj.Enabled = false;
            btnBrisi.Enabled = false;
            btnSpremeni.Enabled = false;
            btnNazaj.Enabled = false;
            btnIzpis.Enabled = false;
            cb2.Focus();
        }

        private void Spremeni()
        {
            // preveri če dgv1 ni prazna
            int row_count = dgv1.RowCount;
            if (row_count > 0)
            {

                
                zacasna_skupina = cb1.Text;
                omogoci_tb();
                spreminjanje = true;
                index = dgv1.SelectedCells[0].Value.ToString();
                index_spremeni = Convert.ToInt32(index);
                /// novo 

                q = "select * from tbl_Cenik_trg where id = @tmpid"; //+ sort;

                try
                {
                    cmd = new SqlCommand(q, con);
                    cmd.Parameters.AddWithValue("@tmpid", index_spremeni);
                    con.Open();
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        storitev_em = (int)rdr["em"];
                        storitev_int = (int)rdr["storitev"];
                        tskupina = (int)rdr["skupina"];
                        tcenao = (Double)rdr["cena_obcina"];
                        // tcenat = (Double)rdr["cena_trg"];
                        cenao_string = Convert.ToString(tcenao);
                        cenat_string = Convert.ToString(tcenat);
                        stskupina = naziv_skupine(tskupina);
                        ststoritev = naziv_storitve(storitev_int);
                        storitev_em_str = naziv_em(storitev_em);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka rdr: " + ex.Message);
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
                cb1.Text = stskupina;
                cb2.Text = ststoritev;
                tb1.Text = cenao_string;
                //tb4.Text = cenat_string;
                tb2.Text = Convert.ToString(Izračunaj_ddv22(tcenao));
                tb3.Text = Convert.ToString(Izračunaj_ddv95(tcenao));
                //tb5.Text = Convert.ToString(Izračunaj_ddv22(tcenat));
                //tb6.Text = Convert.ToString(Izračunaj_ddv95(tcenat));
                tb7.Text = storitev_em_str;
                btnShrani.Enabled = true;
                btnPreklici.Enabled = true;
                btnDodaj.Enabled = false;
                btnBrisi.Enabled = false;
                btnSpremeni.Enabled = false;
                btnNazaj.Enabled = false;
                btnIzpis.Enabled = false;
                tb3.Focus();
            }
        }

        private void Preklici()
        {
            spreminjanje = false; // ni cb1 on change
            dodajanje = false; // ni cb1 on change
            izprazni_tb();
            onemogoci_tb();
            btnShrani.Enabled = false;
            btnPreklici.Enabled = false;
            btnDodaj.Enabled = true;
            btnBrisi.Enabled = true;
            btnSpremeni.Enabled = true;
            btnNazaj.Enabled = true;
            btnIzpis.Enabled = true;
            drugi_display = false;
            Display();
        }

        public double Izračunaj_ddv22(double vhod)
        {
            double rezultat;

            rezultat = vhod * 1.22;

            return rezultat;
        }

        public double Izračunaj_ddv95(double vhod)
        {
            double rezultat;

            rezultat = vhod * 1.095;

            return rezultat;
        }


    }
}
