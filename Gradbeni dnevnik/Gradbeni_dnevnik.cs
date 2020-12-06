using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Komunala
{
    public partial class Gradbeni_dnevnik : Form
    {
        SqlConnection con = frmMain.c;
        SqlConnection con2 = frmMain.c2;
        SqlConnection con3 = frmMain.c3;

        SqlCommand cmd;
        SqlDataReader rdr = null;

        SqlCommand cmd2;
        SqlDataReader rdr2 = null;


        // spremenljivke
        public static int index_izpis, indeks_za_izpis;
        public static int index_nazaj;
        public static bool odpri;
        public static bool iz_gradbeni;
        public static string prejsnji_objekt;


        bool prvic = true;
        string q, q2; // query
        int zadnji_gd,index_odpri;
        string zadnji_gd_str;
        SortedList objekti = new SortedList();
        SortedList storitve = new SortedList();
        List<int> zap_dnevnika = new List<int>();
        int nova_zaporedna;
        bool dodajanje, spreminjanje, shrani_ok,stevilo_ok,vpisi0;
        int tb1i, tb2i, tb3i, tb4i, tb5i, tb6i, tb7i, tb8i, tb9i, tb10i, tb11i, tb12i, tb13i, tb14i, tb15i, tb16i, tb17i, tb18i; // polja za delavce
        string tb1s, tb2s, tb3s, tb4s, tb5s, tb6s, tb7s, tb8s, tb9s, tb10s, tb11s, tb12s, tb13s, tb14s, tb15s, tb16s, tb17s, tb18s; // polja za delavce
        string opis_temp;
        int max_id, novi_id; // maksimalni id v tabeli dnevniki
        string vhod; // naziv storitve v cb2
        int idx_storitev, idx_em, idx_cenik;
        string ime_storitev, ime_em, ime_cenik;
        bool shranjeno; // ali lahko konča brez shranjevanja
        float tcena, cena_float;
        double cena_double, cena_ok;
        string tmp_102;
        bool preklicano;
        string tsestavil, tnadzornik, tvodja;
        // za shranjevanje storitev
        int tid_dnevnik;
        string topis, tstoritev, tem;
        //float tkos, tznesek, tddv;
        float tznesek, tddv;
        double tkos;
        DateTime tdatum;
        string tobjekt;
        int id_objekta, tid_storitve, tid_skupine;
        string tskupina;
        bool zamenjaj,dodaj,odprt, shranjevanje_ok;
        string idx_zamenjaj;
        string tkos_s,tznesek_s,tddv_s;
        int indexrow,tmp_objekt,tid_ddv;
        bool shrani_situacijo, situacija_obstaja;
        string mesec_dnevnika, leto_dnevnika;
        string idx_situacije;
        double temp_ddv_double;
        // shrani storitve situacije
        int ss_id_situacije;

        int ss_id_storitve, ss_id_skupine, ss_id_em, ss_id_ddv, ss_dan,ss_mesec, ss_leto;
        string ss_storitev;
        double ss_kol;
        DateTime ss_datum;
        int sqlstevec;
        int id_novega_dnevnika, id_dodanega_dnevnika;
        public Gradbeni_dnevnik()
        {
            InitializeComponent();
        }

        private void Gradbeni_dnevnik_Load(object sender, EventArgs e)
        {
            Design();
            Zacetek();
        }

        private void Design()
        {
            crtal.AutoSize = false;
            crtal.Height = 1;
            crtal.BorderStyle = BorderStyle.Fixed3D;
            crta2.AutoSize = false;
            crta2.Height = 1;
            crta2.BorderStyle = BorderStyle.Fixed3D;


            // gumbi
            btnBrisi.BackColor = frmMain.barva_gumb2_neakt; btnBrisi.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnNazaj.BackColor = frmMain.barva_gumb2_neakt; btnNazaj.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnPreklici.BackColor = frmMain.barva_gumb2_neakt; btnPreklici.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnShrani.BackColor = frmMain.barva_gumb2_neakt; btnShrani.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnSpremeni.BackColor = frmMain.barva_gumb2_neakt; btnSpremeni.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnPreklici_stor.BackColor = frmMain.barva_gumb2_neakt; btnPreklici_stor.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnDodaj_stor.BackColor = frmMain.barva_gumb2_neakt; btnDodaj_stor.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnBrisi.BackColor = frmMain.barva_gumb2_neakt; btnBrisi.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnNovo.BackColor = frmMain.barva_gumb2_neakt; btnNovo.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnIzpis.BackColor = frmMain.barva_gumb2_neakt; btnIzpis.ForeColor = frmMain.barva_gumb2_pis_akt;
            button1.BackColor = frmMain.barva_gumb2_neakt; button1.ForeColor = frmMain.barva_gumb2_pis_akt;
            button2.BackColor = frmMain.barva_gumb2_neakt; button2.ForeColor = frmMain.barva_gumb2_pis_akt;



            cb2.BackColor = frmMain.bela;
            cb3.BackColor = frmMain.bela;

            this.BackColor = frmMain.barva_form_back; // Form ozadje
            this.Text = frmMain.nazivPrograma; // Form tekst
        }


        public static bool Je_stevilo(string vhod)
        {

            double retNum;

            bool isNum = Double.TryParse(Convert.ToString(vhod), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        private void Gumbi_dodaj()
        {
            //gb1.Enabled = true;
            //pb1.Enabled = true;
            //pb3.Enabled = true;
            //pb2.Enabled = true;

            button1.Enabled = false;
            button1.BackColor = frmMain.barva_gumb2_disabled;
            button2.Enabled = false;
            button2.BackColor = frmMain.barva_gumb2_disabled;
            btnShrani.Enabled = true;
            btnShrani.BackColor = frmMain.barva_gumb2_neakt;
            btnSpremeni.Enabled = false;
            btnSpremeni.BackColor = frmMain.barva_gumb2_disabled;
            btnPreklici.Enabled = true;
            btnPreklici.BackColor = frmMain.barva_gumb2_neakt;
            btnBrisi.Enabled = false;
            btnBrisi.BackColor = frmMain.barva_gumb2_disabled;
            btnNazaj.Enabled = false;
            btnNazaj.BackColor = frmMain.barva_gumb2_disabled;
            btnIzpis.Enabled = false;
            btnIzpis.BackColor = frmMain.barva_gumb2_disabled;
            btnNovo.Enabled = false;
            btnNovo.BackColor = frmMain.barva_gumb2_disabled;
        }
        //private void Gumbi_nov_dnevnik()
        //{
        //    //gb1.Enabled = true;
        //    //pb1.Enabled = true;
        //    //pb3.Enabled = true;
        //    //pb2.Enabled = true;

        //    button1.Enabled = false;
        //    button2.Enabled = false;
        //    btnShrani.Enabled = true;
        //    btnSpremeni.Enabled = false;
        //    btnPreklici.Enabled = true;
        //    btnBrisi.Enabled = false;
        //    btnNazaj.Enabled = false; ;
        //    btnIzpis.Enabled = false;
        //    btnNovo.Enabled = true;
        //}


        private void Gumbi_zacetek33()
        {
            btnPreklici_stor.Enabled = true;
            btnDodaj_stor.Enabled = true;
            btnBrisi.Enabled = true;
        }

        private void Gumbi_storitve_off()
        {
            btnPreklici_stor.Enabled = false;
            btnPreklici_stor.BackColor = frmMain.barva_gumb2_disabled;
            btnDodaj_stor.Enabled = false;
            btnDodaj_stor.BackColor = frmMain.barva_gumb2_disabled;
            btnBrisi.Enabled = false;
            btnBrisi.BackColor = frmMain.barva_gumb2_disabled;
        }

        private void Gumbi_storitve_on()
        {
            btnPreklici_stor.Enabled = true;
            btnPreklici_stor.BackColor = frmMain.barva_gumb2_neakt;
            btnDodaj_stor.Enabled = true;
            btnDodaj_stor.BackColor = frmMain.barva_gumb2_neakt;
            btnBrisi.Enabled = true;
            btnBrisi.BackColor = frmMain.barva_gumb2_neakt;
        }

        private void Gumbi_zacetek2()
        {
            btnShrani.BackColor = frmMain.barva_gumb2_disabled;
            btnShrani.Enabled = false;
            
            btnSpremeni.Enabled = false;
            btnSpremeni.BackColor = frmMain.barva_gumb2_disabled;
            btnPreklici.Enabled = false;
            btnPreklici.BackColor = frmMain.barva_gumb2_disabled;
            btnBrisi.Enabled = false;
            btnBrisi.BackColor = frmMain.barva_gumb2_disabled;
            btnNazaj.Enabled = true;
            btnNazaj.BackColor = frmMain.barva_gumb2_neakt;
            btnIzpis.Enabled = false;
            btnIzpis.BackColor = frmMain.barva_gumb2_disabled;
            button1.Enabled = true;
            button1.BackColor = frmMain.barva_gumb2_neakt;
            button2.Enabled = true;
            button2.BackColor = frmMain.barva_gumb2_neakt;
            btnNovo.Enabled = true;
            btnNovo.BackColor = frmMain.barva_gumb2_neakt;
        }
        private void Gumbi_spremeni()
        {
            btnDodaj_stor.Text = "F2 - Zamenjaj";
            btnBrisi.Enabled = false;
            btnBrisi.BackColor = frmMain.barva_gumb2_disabled;
            btnPreklici_stor.Enabled = true;
            btnPreklici_stor.BackColor = frmMain.barva_gumb2_neakt;
            btnDodaj_stor.Enabled = true;
            btnDodaj_stor.BackColor = frmMain.barva_gumb2_neakt;
        }

        private void Gumbi_po_dodaj()
        {
            Gumbi_storitve_on();
        }

        private void Izprazni_dgv()
        {
            dgv1.Rows.Clear();
            dgv1.Refresh();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cb1_SelectedValueChanged(object sender, EventArgs e)
        {
            shranjeno = false;
        }

        private void cb1_Enter(object sender, EventArgs e)
        {
        }

        private void Preklici_storitev()
        {
            cb2.Text = "";
            //cb2.Items.Clear();
            tb100.Text = "";
            tb101.Text = "";
            tb102.Text = "";
            tb103.Text = "";
            tb100.Focus();
            preklicano = false;
            zamenjaj = false;
            dodaj = true;
            Gumbi_storitve_on();
            btnDodaj_stor.Text = "F2 - Dodaj";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Preklici_storitev();
        }
        private void Izracunaj_stor()
        {
            double tkolicina = Convert.ToDouble(tb102.Text);
            double tcena = cena_ok; // Convert.ToDouble(tb103.Text);
            double tznesek = tkolicina * tcena;
            tb103.Text = tznesek.ToString("F2");
            tb102.Text = tkolicina.ToString("F2");

        }
        private void tb102_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDodaj_stor.Focus();           
            }
        }

        private void tb102_Leave(object sender, EventArgs e)
        {
            // preveri če je količina številka

            tmp_102 = tb102.Text;
           if (tmp_102 == "" || tmp_102 == "0")
                {
                    tmp_102 = "0";
                }
            tmp_102 = tmp_102.Replace(".", ",");
            tb102.Text = tmp_102;
            if (Je_stevilo(tmp_102) == true)
                {
                    Izracunaj_stor();
                    btnDodaj_stor.Focus();

            }
                else
                {
                    MessageBox.Show("Količina mora biti število!");
                    tb102.Focus();
                }
        }

        private void cb2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                cb2.DroppedDown = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                tb102.Focus();
            }
        }

        private void cb2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void cb2_DropDownClosed(object sender, EventArgs e)
        {
            tb102.Focus();
            if (preklicano == false)
            {
                // poišči indeks storitve iz cb2 v tbl_storitve
                vhod = cb2.Text;
                if (cb2.Text == "")
                {
                    tb101.Text = "";
                    tb103.Text = "";
                }

                idx_storitev = -99; // ne najdem storitve

                // poišči indeks em v storitvi
                q2 = "select * from tblStoritve where storitev = @indeks";
                try
                {
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@indeks", vhod);
                    rdr2 = cmd2.ExecuteReader();
                    while (rdr2.Read())
                    {
                        idx_storitev = (int)rdr2["Id"];
                        idx_em = (int)rdr2["em"];
                    }
                    con2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: najdi idx storitve.: " + ex.Message);
                }

                // poišči EM v tbl_enote
                q2 = "select em from tbl_enote where id = @indeks";
                try
                {
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@indeks", idx_em);
                    cmd2.ExecuteNonQuery();
                    ime_em = (string)cmd2.ExecuteScalar();
                    con2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: naziv_em : " + ex.Message);
                }
                tb101.Text = ime_em;

                // poišči ceno v tblCenik
                double cena_temp = 0; ;
                cena_temp = najdi_ceno(idx_storitev);
                if (cena_temp == 0)
                {
                }
                tb103.Text = cena_temp.ToString("F2");
                cena_ok = cena_temp;
            } // preklicano

        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb2_Enter(object sender, EventArgs e)
        {
            //cb2.DroppedDown = true;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void tb1_Leave_1(object sender, EventArgs e)
        {
            tb1s = tb1.Text;
            if (tb1s == "")
            {
                tb1s = "0";
            }
            if (Je_stevilo(tb1s))
            {
                sestej_i();
                shrani_ok = true;
            }
            else
            {
                MessageBox.Show("Vnesi število delavcev!");
                tb1.Focus();
                shrani_ok = false;
            }
        }

        private void tb2_Leave_1(object sender, EventArgs e)
        {
            tb2s = tb2.Text;
            if (tb2s == "")
            {
                tb2s = "0";
            }
            if (Je_stevilo(tb2s))
            {
                sestej_i();
                shrani_ok = true;
            }
            else
            {
                MessageBox.Show("Vnesi število delavcev!");
                tb2.Focus();
                shrani_ok = false;
            }
        }

        private void tb3_Leave(object sender, EventArgs e)
        {
            tb3s = tb3.Text;
            if (tb3s == "")
            {
                tb3s = "0";
            }
            if (Je_stevilo(tb3s))
            {
                sestej_i();
                shrani_ok = true;
            }
            else
            {
                MessageBox.Show("Vnesi število delavcev!");
                tb3.Focus();
                shrani_ok = false;
            }
        }

        private void tb4_Leave_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSituacije secondForm = new frmSituacije();
            secondForm.ShowDialog();
            Zacetek();
        }

        public double najdi_ceno(int vhod) // poišči ceno za storitev
        {
            double rezultat;
            cena_double = 0;
            q2 = "select cena_obcina from tbl_cenik where storitev = @indeks";
            try
            {
                cmd2 = new SqlCommand(q2, con2);
                con2.Open();
                cmd2.Parameters.AddWithValue("@indeks", vhod);
                rdr = cmd2.ExecuteReader();
                while (rdr.Read())
                {
                    cena_double = (Double)rdr["cena_obcina"];
                }
                con2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: najdi ceno storitve: " + ex.Message);
            }
            rezultat = cena_double;
            return rezultat;
        }

        private void btnStoritve_Click(object sender, EventArgs e)
        {
            frmStoritve secondForm = new frmStoritve();
            secondForm.ShowDialog();

            // naloži nove storitve
            cb2.Items.Clear();
            cb2.ResetText();
            q2 = "select * from tblstoritve order by storitev";
            try
            {
                cmd2 = new SqlCommand(q2, con2);
                con2.Open();
                rdr2 = cmd2.ExecuteReader();
                while (rdr2.Read())
                {
                    string storitev = (string)rdr2["storitev"];
                    int id_storitve = (int)rdr2["id"];
                    cb2.Items.Add(storitev);
                    //storitve.Add(storitev, id_storitve);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: Dodaj objekte v cb2  " + ex.Message);
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

        private void btnSpremeni_Click_1(object sender, EventArgs e)
        {
            // spreminjanje
            spreminjanje = true;
            dodajanje = false;
            Gumbi_dodaj();
            btnNovo.Enabled = false;
            omogoci_tb();
            cb1.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novi_dnevnik();
        }

        private void btnSpremeni_Click(object sender, EventArgs e)
        {
            zamenjaj = true;
            dodaj = false;
            Spremeni();
        }

        private void dgv1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            zamenjaj = true;
            dodaj = false;
            Zamenjaj();
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            Brisi();
        }
        public static string getStr(SqlDataReader r, string polje)
        {
            return string.Empty;
        }

        private void Nalozi_dnevnik()
        {
            shranjeno = true;
            izprazni_tb();
            Izprazni_storitev();
            Izprazni_dgv();

            // naloži dnevnik
            q2 = "select * from tbl_dnevnik where id=@idx_dnevnik";
            try
            {
                cmd2 = new SqlCommand(q2, con2);
                con2.Open();
                cmd2.Parameters.AddWithValue("@idx_dnevnik", index_odpri);
                rdr2 = cmd2.ExecuteReader();
                while (rdr2.Read())
                {
                    string tstevilka = Convert.ToString((int)rdr2["stevilka"]);
                    tmp_objekt = (int)rdr2["objekt_id"];
                    tb50.Text = tstevilka;
                    tb51.Text = (string)rdr2["ura_od"];
                    tb52.Text = (string)rdr2["ura_do"];
                    cb1.Text = frmPrejsnji_dnevniki.prejsnji_objekt;
                    dt1.Value= (DateTime)rdr2["datum"];

                    tb1.Text = Convert.ToString((int)rdr2["delavci_iz_vo"]);
                    tb2.Text = Convert.ToString((int)rdr2["delavci_iz_gr"]);
                    tb3.Text = Convert.ToString((int)rdr2["delavci_iz_ob"]);
                    tb4.Text = Convert.ToString((int)rdr2["delavci_iz_in"]);
                    tb5.Text = Convert.ToString((int)rdr2["delavci_iz_dr"]);

                    tb7.Text = Convert.ToString((int)rdr2["delavci_na_vo"]);
                    tb8.Text = Convert.ToString((int)rdr2["delavci_na_gr"]);
                    tb9.Text = Convert.ToString((int)rdr2["delavci_na_ob"]);
                    tb10.Text = Convert.ToString((int)rdr2["delavci_na_in"]);
                    tb11.Text = Convert.ToString((int)rdr2["delavci_na_dr"]);

                    tb13.Text = Convert.ToString((int)rdr2["delavci_po_vo"]);
                    tb14.Text = Convert.ToString((int)rdr2["delavci_po_gr"]);
                    tb15.Text = Convert.ToString((int)rdr2["delavci_po_ob"]);
                    tb16.Text = Convert.ToString((int)rdr2["delavci_po_in"]);
                    tb17.Text = Convert.ToString((int)rdr2["delavci_po_dr"]);

                    sestej_i();
                    sestej_n();
                    sestej_p();

                    tb19.Text= (string)rdr2["stroji_iz_1"];
                    tb20.Text = (string)rdr2["stroji_iz_2"];
                    tb21.Text = (string)rdr2["stroji_iz_3"];
                    tb22.Text = (string)rdr2["stroji_iz_4"];
                    tb23.Text = (string)rdr2["stroji_iz_5"];
                    tb24.Text = (string)rdr2["stroji_iz_6"];
                    tb25.Text = (string)rdr2["stroji_na_1"];
                    tb26.Text = (string)rdr2["stroji_na_2"];
                    tb27.Text = (string)rdr2["stroji_na_3"];
                    tb28.Text = (string)rdr2["stroji_na_4"];
                    tb29.Text = (string)rdr2["stroji_na_5"];
                    tb30.Text = (string)rdr2["stroji_na_6"];
                    cb3.Text= (string)rdr2["sestavil"];
                    cb4.Text = (string)rdr2["nadzornik"];
                    cb5.Text = (string)rdr2["vodja"];

                    // vreme

                    if (rdr2["temp_6"] != DBNull.Value)
                    {
                        tbv1.Text = (string)rdr2["temp_6"];
                    }
                    else tbv1.Text = "";

                    if (rdr2["temp_12"] != DBNull.Value)
                    {
                        tbv2.Text = (string)rdr2["temp_12"];
                    }
                    else tbv2.Text = "";

                    if (rdr2["temp_18"] != DBNull.Value)
                    {
                        tbv3.Text = (string)rdr2["temp_18"];
                    }
                    else tbv3.Text = "";

                    if (rdr2["temp_24"] != DBNull.Value)
                    {
                        tbv4.Text = (string)rdr2["temp_24"];
                    }
                    else tbv4.Text = "";

                    if (rdr2["vreme_6"] != DBNull.Value)
                    {
                        tbv5.Text = (string)rdr2["vreme_6"];
                    }
                    else tbv5.Text = "";

                    if (rdr2["vreme_12"] != DBNull.Value)
                    {
                        tbv6.Text = (string)rdr2["vreme_12"];
                    }
                    else tbv6.Text = "";

                    if (rdr2["vreme_18"] != DBNull.Value)
                    {
                        tbv7.Text = (string)rdr2["vreme_18"];
                    }
                    else tbv7.Text = "";

                    if (rdr2["vreme_24"] != DBNull.Value)
                    {
                        tbv8.Text = (string)rdr2["vreme_24"];
                    }
                    else tbv8.Text = "";

                    //tbv2.Text = Convert.ToString((Double)rdr2["temp_12"]);
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

            // naloži storitve
            q2 = "select * from tbl_Storitve_dnevnik where Id_dnevnik = @indeks";
            try
            {
                cmd2 = new SqlCommand(q2, con2);
                con2.Open();
                cmd2.Parameters.AddWithValue("@indeks", index_odpri);
                rdr2 = cmd2.ExecuteReader();
                while (rdr2.Read())
                {
                    string topis_dela= (string)rdr2["opis"];
                    string tmp_storitev = (string)rdr2["storitev"];
                    string tmp_em = (string)rdr2["em"];
                    float tmp_kolicina = Convert.ToSingle(rdr2["kos"].ToString());
                    float tmp_znesek = Convert.ToSingle(rdr2["znesek"].ToString());

                    DataGridViewTextBoxCell id_dnevnika = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell zap = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell opis_dela = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell storitev = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell em = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell kol = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell znesek = new DataGridViewTextBoxCell();
                    

                    DataGridViewColumn kolid_dnevnika = dgv1.Columns[0];
                    kolid_dnevnika.Width = 60;
                    DataGridViewColumn kolzap = dgv1.Columns[1];
                    kolzap.Width = 100;
                    DataGridViewColumn kolopis_dela = dgv1.Columns[2];
                    kolopis_dela.Width = 427;
                    DataGridViewColumn kolstoritev = dgv1.Columns[3];
                    kolstoritev.Width = 317;
                    DataGridViewColumn kolem = dgv1.Columns[4];
                    kolem.Width = 46;
                    DataGridViewColumn kolkol = dgv1.Columns[5];
                    kolkol.Width = 59;
                    DataGridViewColumn kolznesek = dgv1.Columns[6];
                    kolznesek.Width = 83;

                    kolznesek.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    DataGridViewRow row = new DataGridViewRow();

                    id_dnevnika.Value = index_odpri;  // pri spreminjanju je drugače
                    zap.Value = 99; // začasno, verjetno ne rabiš
                    opis_dela.Value = topis_dela;
                    storitev.Value = tmp_storitev;
                    em.Value = tmp_em;
                    kol.Value = tmp_kolicina;
                    znesek.Value = tmp_znesek;

                    row.Cells.Add(id_dnevnika);
                    row.Cells.Add(zap);
                    row.Cells.Add(opis_dela);
                    row.Cells.Add(storitev);
                    row.Cells.Add(em);
                    row.Cells.Add(kol);
                    row.Cells.Add(znesek);

                    dgv1.Rows.Add(row);  // dodaj vrstico

                }
                con2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: najdi idx storitve.: " + ex.Message);
            }

            //dgv1.Enabled = true;

            shranjeno = true;
        }
        private void button2_Click(object sender, EventArgs e) // prejšnji dnevniki
        {
            //izprazni_tb();
            //Izprazni_storitev();
            //Izprazni_dgv();

            frmPrejsnji_dnevniki secondForm = new frmPrejsnji_dnevniki();
            secondForm.ShowDialog();
            if (frmPrejsnji_dnevniki.odpri==true)
            {
                index_odpri = frmPrejsnji_dnevniki.index_nazaj;
                indeks_za_izpis = index_odpri;
                odprt = true; 
                Nalozi_dnevnik();
                btnIzpis.Enabled = true;
                btnIzpis.BackColor = frmMain.barva_gumb2_neakt;
                btnSpremeni.Enabled = true;
                btnSpremeni.BackColor = frmMain.barva_gumb2_neakt;
            }
            else
            {
                Zacetek();
            }
        }

        private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            indexrow = e.RowIndex;
            zamenjaj = true;
            dodaj = false;
            Spremeni();
        }

        private void dgv1_Enter(object sender, EventArgs e)
        {
        }

        private void cb3_MouseClick(object sender, MouseEventArgs e)
        {
            cb3.DroppedDown = true;
        }

        private void cb5_MouseClick(object sender, MouseEventArgs e)
        {
            cb5.DroppedDown = true;
        }

        private void cb3_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                cb3.DroppedDown = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                cb4.Focus();
            }
        }

        private void cb4_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                cb4.DroppedDown = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                cb5.Focus();
            }
        }

        private void cb5_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                cb5.DroppedDown = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnShrani.Focus();
            }
        }

        private void tb100_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cb2.Focus();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Datarow in dgv1.Rows)
            {
                if (Datarow.Cells[0].Value != null && Datarow.Cells[1].Value != null)
                {
                    string contentValue1 = Datarow.Cells[2].Value.ToString();
                    string contentValue2 = Datarow.Cells[3].Value.ToString();
                    //MessageBox.Show(contentValue1);
                    //MessageBox.Show(contentValue2);
                }
            }
        }

        private void cb2_Leave(object sender, EventArgs e)
        {
            if (cb2.Text=="")
            {
                           }
            // če storitve ni v ceniku
        }

        private void cb2_MouseClick(object sender, MouseEventArgs e)
        {
            cb2.Focus();
            cb2.DroppedDown = true;
        }

        private void cb4_MouseClick_1(object sender, MouseEventArgs e)
        {
            cb4.DroppedDown = true;

        }

        private void cb2_SelectedValueChanged(object sender, EventArgs e)
        {
            // IF ESCAPE == FALSE
            if (preklicano == false)
            {
                // poišči indeks storitve iz cb2 v tbl_storitve
                vhod = cb2.Text;
                if (cb2.Text == "")
                {
                    tb101.Text = "";
                    tb103.Text = "";
                }

                idx_storitev = -99; // ne najdem storitve

                // poišči indeks em v storitvi
                q2 = "select * from tblStoritve where storitev = @indeks";
                try
                {
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@indeks", vhod);
                    rdr2 = cmd2.ExecuteReader();
                    while (rdr2.Read())
                    {
                        idx_storitev = (int)rdr2["Id"];
                        idx_em = (int)rdr2["em"];
                    }
                    con2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: najdi idx storitve.: " + ex.Message);
                }

                // poišči EM v tbl_enote
                q2 = "select em from tbl_enote where id = @indeks";
                try
                {
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@indeks", idx_em);
                    cmd2.ExecuteNonQuery();
                    ime_em = (string)cmd2.ExecuteScalar();
                    con2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: naziv_em : " + ex.Message);
                }
                tb101.Text = ime_em;
                tb102.Text = "1,00";

                // poišči ceno v tblCenik
                double cena_temp = 0; ;
                cena_temp = najdi_ceno(idx_storitev);
                if (cena_temp == 0)
                {
                }
                tb103.Text = cena_temp.ToString("F2");
                cena_ok = cena_temp;
            } // preklicano
        }

        private void Zacetek()
        {
            

            prvic = true;
            dodaj = true;
            odprt = false;
            Gumbi_zacetek2();  // novo
            onemogoci_tb();
            Grid();
            izprazni_tb();
            
            // postavi datum na danes;
            dt1.Value = DateTime.Now;

            // Napolni cb1
            cb1.Items.Clear();
            cb1.ResetText();
            q2 = "select * from tbl_delovisca order by naziv";
                try
                {
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    rdr2 = cmd2.ExecuteReader();
                    while (rdr2.Read())
                    {
                        string objekt = (string)rdr2["naziv"];
                        int id_objekta = (int)rdr2["id_delovisca"];
                        cb1.Items.Add(objekt);
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

            // Napolni cb2
            cb2.Items.Clear();
            cb2.ResetText();
            q2 = "select * from tblstoritve order by storitev";
            try
            {
                cmd2 = new SqlCommand(q2, con2);
                con2.Open();
                rdr2 = cmd2.ExecuteReader();
                while (rdr2.Read())
                {
                    string storitev = (string)rdr2["storitev"];
                    int id_storitve = (int)rdr2["id"];
                    cb2.Items.Add(storitev);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: Dodaj objekte v cb2  " + ex.Message);
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

            shranjeno = true;

            // Napolni cb3, cb4, cb5
            q2 = "select * from tbl_osebe order by oseba";
            try
            {
                cmd2 = new SqlCommand(q2, con2);
                con2.Open();
                rdr2 = cmd2.ExecuteReader();
                cb3.Items.Clear();
                cb4.Items.Clear();
                cb5.Items.Clear();
                while (rdr2.Read())
                {
                    string oseba = (string)rdr2["oseba"];
                    cb3.Items.Add(oseba);
                    cb4.Items.Add(oseba);
                    cb5.Items.Add(oseba);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: Dodaj objekte v cb2  " + ex.Message);
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
            btnNovo.Focus();
        }


        private void Novi_dnevnik()
        {
            Gumbi_dodaj();
            omogoci_tb();
            // preštej stevilo zapisov v bazi dnevniki
            q2 = "SELECT COUNT(*) FROM tbl_dnevnik";
            cmd2 = new SqlCommand(q2, con2);
            con2.Open();
            cmd2.ExecuteNonQuery();
            sqlstevec = (int)cmd2.ExecuteScalar();
            con2.Close();

            if (sqlstevec > 0)
            {
                q2 = "select max(id) from tbl_dnevnik";  // če sta indexa iz ulic enaka
                cmd2 = new SqlCommand(q2, con2);
                con2.Open();
                cmd2.ExecuteNonQuery();
                max_id = (int)cmd2.ExecuteScalar();
                con2.Close();
            }
            else
            {
                max_id = sqlstevec;
            }
            novi_id = max_id+1;
            vpisi0 = false;
            izprazni_tb();
            //omogoci_tb();
            dodajanje = true;

            // polje za datum
            dt1.Format = DateTimePickerFormat.Custom;
            dt1.CustomFormat = "dd. MM. yyyy";
            dt1.Value = DateTime.Now;

            // vpiši zadnjo številko dnevnika v tb50
            q2 = "select stevilka from tbl_dnevnik";
            try
            {
                cmd2 = new SqlCommand(q2, con2);
                con2.Open();
                rdr2 = cmd2.ExecuteReader();
                while (rdr2.Read())
                {
                    int tstevilka = (int)rdr2["stevilka"];
                    zap_dnevnika.Add(tstevilka);
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

            // najdi največjo vrednost
            int maks = 0;
            foreach (int stevilka in zap_dnevnika)
            {
                if (stevilka > maks)
                {
                    maks = stevilka;
                }
            }
            nova_zaporedna = maks + 1;
            
            if (sqlstevec==0) // če je baza z dnevniki prazna
            {
                nova_zaporedna = 1;
            }
            // napolni polja
            tb50.Text = Convert.ToString(nova_zaporedna);
            tb51.Text = "7";
            tb52.Text = "15";

            // novo 23.10.2020

            cb3.Text = frmMain.dne_pripravil;
            cb4.Text = frmMain.dne_odobril;
            cb5.Text = frmMain.dne_pripravil;
            cb1.Focus();
        }

        private void Dodaj()
        {
            // dodaj storitev v mrežo dgv1
            if (dodaj == true)
            {
                Gumbi_po_dodaj();
                DataGridViewTextBoxCell id_dnevnika = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell zap = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell opis_dela = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell storitev = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell em = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell kol = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell znesek = new DataGridViewTextBoxCell();

                id_dnevnika.Value = novi_id;  // pri spreminjanju je drugače
                zap.Value = 99; // začasno, verjetno ne rabiš
                opis_dela.Value = tb100.Text;
                storitev.Value = cb2.Text;
                em.Value = tb101.Text;
                kol.Value = tb102.Text;
                znesek.Value = tb103.Text;

                DataGridViewColumn kolid_dnevnika = dgv1.Columns[0];
                kolid_dnevnika.Width = 60;
                DataGridViewColumn kolzap = dgv1.Columns[1];
                kolzap.Width = 50;
                DataGridViewColumn kolopis_dela = dgv1.Columns[2];
                kolopis_dela.Width = 427;
                DataGridViewColumn kolstoritev = dgv1.Columns[3];
                kolstoritev.Width = 317;
                DataGridViewColumn kolem = dgv1.Columns[4];
                kolem.Width = 46;
                DataGridViewColumn kolkol = dgv1.Columns[5];
                kolkol.Width = 59;
                DataGridViewColumn kolznesek = dgv1.Columns[6];
                kolznesek.Width = 83;

                DataGridViewRow row = new DataGridViewRow();

                row.Cells.Add(id_dnevnika);
                row.Cells.Add(zap);
                row.Cells.Add(opis_dela);
                row.Cells.Add(storitev);
                row.Cells.Add(em);
                row.Cells.Add(kol);
                row.Cells.Add(znesek);

                dgv1.Rows.Add(row);  // dodaj vrstico
                dgv1.Enabled = true;
            }
            Izprazni_storitev();
            zamenjaj = false;
            dodaj = true;
        }
        private void Zamenjaj()  // zamenjaj v grid
        {

            DataGridViewRow newDataRow = dgv1.Rows[indexrow];
            
            newDataRow.Cells[0].Value = idx_zamenjaj;
            newDataRow.Cells[2].Value = tb100.Text;
            newDataRow.Cells[3].Value = cb2.Text;
            newDataRow.Cells[4].Value = tb101.Text;
            newDataRow.Cells[5].Value = tb102.Text;
            newDataRow.Cells[6].Value = tb103.Text;
            btnDodaj_stor.Text = "F2 - Dodaj";
            Izprazni_storitev();
            zamenjaj = false;
            dodaj = true;
            Gumbi_storitve_on();
        }

        private void Izprazni_storitev()
        {
            dodaj = true;
            opis_temp = tb100.Text; 
            tb100.Text = "";
            tb100.Text = opis_temp;
            tb101.Text = "";
            tb102.Text = "";
            tb103.Text = "";
            cb2.Text = "";
            //cb2.Items.Clear();
            tb100.Focus();
        }
        private void Spremeni()  // naloži v zgornjo vrstico
        {
            int row_count = dgv1.RowCount;
            if (row_count > 0)
            {
                Gumbi_spremeni();
                zamenjaj = true;
                dodaj = false;
                
                idx_zamenjaj= dgv1.SelectedCells[0].Value.ToString();
                btnDodaj_stor.Text = "F2 - Zamenjaj";
                tb100.Text = dgv1.SelectedCells[2].Value.ToString();
                cb2.Text = dgv1.SelectedCells[3].Value.ToString();
                tb101.Text = dgv1.SelectedCells[4].Value.ToString();
                tb102.Text = dgv1.SelectedCells[5].Value.ToString();
                tb103.Text = dgv1.SelectedCells[6].Value.ToString();
                tb100.Focus();
            }
        }
        private void Brisi()
        {
            DialogResult result = MessageBox.Show("Ali želiš izbrisati storitev?", " Potrdi brisanje storitve. ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgv1.SelectedRows)
                {
                    dgv1.Rows.RemoveAt(row.Index);
                }
            }
            tb100.Focus();
        }

        private void Shrani()
        {
            // preveri polja z delavci
            // Preveri_polja();
            shrani_ok = true;
            shranjevanje_ok = false;
            shrani_situacijo = false;
            if (cb1.Text == "")
            { 
                MessageBox.Show("Vnesi objekt!");
                shrani_ok = false;
                cb1.Focus();
            }
            if (tb50.Text == "")
            {
                MessageBox.Show("Vnesi številko dnevnika!");
                shrani_ok = false;
                tb50.Focus();
            }
            if (shrani_ok == true)
            {
                DialogResult result = MessageBox.Show("Ali želiš shraniti gradbeni dnevnik?", " Potrdi shranjevanje. ", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if(spreminjanje==true)
                    {
                        // novo 30-8-2020
                        // zaradi spreminjanja
                        // poglej če že obstaja dnevnik
                        // izbriši dnevnik
                        // izbriši storitve dnevnika
                        // izbriši storitve situacije
                        // ko naložiš situacijo za izpis poglej če je prazna in javi, da je prazna

                        // briši dnevnik
                        try
                        {
                            string q = "delete from tbl_Dnevnik where id = @tid";
                            cmd = new SqlCommand(q, con);
                            con.Open();
                            cmd.Parameters.AddWithValue("@tid", indeks_za_izpis);
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Napaka pri brisanju dnevnika: " + ex.Message);
                        }
                        finally
                        {
                            if (con != null)
                            {
                                con.Close();
                            }
                        }

                        // briši storitve dnevnika
                        try
                        {
                            string q = "delete from tbl_Storitve_dnevnik where id_dnevnik = @tid";
                            cmd = new SqlCommand(q, con);
                            con.Open();
                            cmd.Parameters.AddWithValue("@tid", indeks_za_izpis);
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Napaka pri brisanju storitev dnevnika: " + ex.Message);
                        }
                        finally
                        {
                            if (con != null)
                            {
                                con.Close();
                            }
                        }


                        // briši storitve situacije
                        try
                        {
                            string q = "delete from tbl_Situacija_storitve where id_dnevnik = @tid";
                            cmd = new SqlCommand(q, con);
                            con.Open();
                            cmd.Parameters.AddWithValue("@tid", indeks_za_izpis);
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Napaka pri brisanju storitev v situaciji: " + ex.Message);
                        }
                        finally
                        {
                            if (con != null)
                            {
                                con.Close();
                            }
                        }
                        // če je dnevnik edini v situaciji, briši tudi situacijo
                        spreminjanje = false;
                        dodajanje = true;  // shrani kot da dodajaš
                    }

                    if (dodajanje == true)
                    {
                        try
                        {
                            int tobjekt_id = 0;
                            int tstevilka = 0;
                            string tura_od = "";
                            string tura_do = "";
                            int tdelavci_iz_vo = 0;
                            int tdelavci_iz_gr = 0;
                            int tdelavci_iz_ob = 0;
                            int tdelavci_iz_in = 0;
                            int tdelavci_iz_dr = 0;
                            int tdelavci_na_vo = 0;
                            int tdelavci_na_gr = 0;
                            int tdelavci_na_ob = 0;
                            int tdelavci_na_in = 0;
                            int tdelavci_na_dr = 0;
                            int tdelavci_po_vo = 0;
                            int tdelavci_po_gr = 0;
                            int tdelavci_po_ob = 0;
                            int tdelavci_po_in = 0;
                            int tdelavci_po_dr = 0;
                            int tdelavci_iz_sk = 0;
                            int tdelavci_po_sk = 0;
                            int tdelavci_na_sk = 0;

                            string tvreme_1 = "";
                            string tvreme_2 = "";
                            string tvreme_3 = "";
                            string tvreme_4 = "";
                            string ttemp_1 = "";
                            string ttemp_2 = "";
                            string ttemp_3 = "";
                            string ttemp_4 = "";

                            tobjekt = "";
                            string tstroji_iz_1 = "";
                            string tstroji_iz_2 = "";
                            string tstroji_iz_3 = "";
                            string tstroji_iz_4 = "";
                            string tstroji_iz_5 = "";
                            string tstroji_iz_6 = "";
                            string tstroji_na_1 = "";
                            string tstroji_na_2 = "";
                            string tstroji_na_3 = "";
                            string tstroji_na_4 = "";
                            string tstroji_na_5 = "";
                            string tstroji_na_6 = "";

                            // napolni iz polj
                            tobjekt_id = 99;
                            tobjekt = cb1.Text;
                            tstevilka = Convert.ToInt32(tb50.Text);
                            tura_od = tb51.Text;
                            tura_do = tb52.Text;
                            tdatum = dt1.Value;
                            tsestavil = cb3.Text;
                            tnadzornik = cb4.Text;
                            tvodja = cb5.Text;

                            tb1s = tb1.Text;
                            if (tb1s == "")
                            {
                                tb1s = "0";
                            }
                            tdelavci_iz_vo = Convert.ToInt32(tb1s);

                            tb2s = tb2.Text;
                            if (tb2s == "")
                            {
                                tb2s = "0";
                            }
                            tdelavci_iz_gr = Convert.ToInt32(tb2s);

                            tb3s = tb3.Text;
                            if (tb3s == "")
                            {
                                tb3s = "0";
                            }
                            tdelavci_iz_ob = Convert.ToInt32(tb3s);

                            tb4s = tb4.Text;
                            if (tb4s == "")
                            {
                                tb4s = "0";
                            }
                            tdelavci_iz_in = Convert.ToInt32(tb4s);

                            tb5s = tb5.Text;
                            if (tb5s == "")
                            {
                                tb5s = "0";
                            }
                            tdelavci_iz_dr = Convert.ToInt32(tb5s);

                            tb7s = tb7.Text;
                            if (tb7s == "")
                            {
                                tb7s = "0";
                            }
                            tdelavci_na_vo = Convert.ToInt32(tb7s);

                            tb8s = tb8.Text;
                            if (tb8s == "")
                            {
                                tb8s = "0";
                            }
                            tdelavci_na_gr = Convert.ToInt32(tb8s);

                            tb9s = tb9.Text;
                            if (tb9s == "")
                            {
                                tb9s = "0";
                            }
                            tdelavci_na_ob = Convert.ToInt32(tb9s);

                            tb10s = tb10.Text;
                            if (tb10s == "")
                            {
                                tb10s = "0";
                            }
                            tdelavci_na_in = Convert.ToInt32(tb10s);

                            tb11s = tb11.Text;
                            if (tb11s == "")
                            {
                                tb11s = "0";
                            }
                            tdelavci_na_dr = Convert.ToInt32(tb11s);

                            tb13s = tb13.Text;
                            if (tb13s == "")
                            {
                                tb13s = "0";
                            }
                            tdelavci_po_vo = Convert.ToInt32(tb13s);

                            tb14s = tb14.Text;
                            if (tb14s == "")
                            {
                                tb14s = "0";
                            }
                            tdelavci_po_gr = Convert.ToInt32(tb14s);

                            tb15s = tb15.Text;
                            if (tb15s == "")
                            {
                                tb15s = "0";
                            }
                            tdelavci_po_ob = Convert.ToInt32(tb15s);

                            tb16s = tb16.Text;
                            if (tb16s == "")
                            {
                                tb16s = "0";
                            }
                            tdelavci_po_in = Convert.ToInt32(tb16s);

                            tb17s = tb17.Text;
                            if (tb17s == "")
                            {
                                tb17s = "0";
                            }
                            tdelavci_po_dr = Convert.ToInt32(tb17s);


                            tb6s = tb6.Text;
                            if (tb6s == "")
                            {
                                tb6s = "0";
                            }
                            tdelavci_iz_sk = Convert.ToInt32(tb6s);

                            tb12s = tb12.Text;
                            if (tb12s == "")
                            {
                                tb12s = "0";
                            }
                            tdelavci_na_sk = Convert.ToInt32(tb12s);

                            tb18s = tb18.Text;
                            if (tb18s == "")
                            {
                                tb18s = "0";
                            }
                            tdelavci_po_sk = Convert.ToInt32(tb18s);

                            tstroji_iz_1 = tb19.Text;
                            tstroji_iz_2 = tb20.Text;
                            tstroji_iz_3 = tb21.Text;
                            tstroji_iz_4 = tb22.Text;
                            tstroji_iz_5 = tb23.Text;
                            tstroji_iz_6 = tb24.Text;
                            tstroji_na_1 = tb25.Text;
                            tstroji_na_2 = tb26.Text;
                            tstroji_na_3 = tb27.Text;
                            tstroji_na_4 = tb28.Text;
                            tstroji_na_5 = tb29.Text;
                            tstroji_na_6 = tb30.Text;
                            
                            tvreme_1 = tbv5.Text;
                            tvreme_2 = tbv6.Text;
                            tvreme_3 = tbv7.Text;
                            tvreme_4 = tbv8.Text;
                            ttemp_1 = tbv1.Text;
                            ttemp_2 = tbv2.Text;
                            ttemp_3 = tbv3.Text;
                            ttemp_4 = tbv4.Text;



                            // poišči id objekta - delovišča
                            q2 = "select id_delovisca from tbl_delovisca where naziv = @naziv";
                            try
                            {
                                cmd2 = new SqlCommand(q2, con2);
                                con2.Open();
                                cmd2.Parameters.AddWithValue("@naziv", tobjekt);

                                rdr2 = cmd2.ExecuteReader();
                                while (rdr2.Read())
                                {
                                    id_objekta = (int)rdr2["id_delovisca"];
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Napaka: poišči id objekta - delovišča  " + ex.Message);
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
                            tobjekt_id = id_objekta;
                            q = "insert into tbl_Dnevnik (objekt,objekt_id,dnevnik_id,stevilka,datum,ura_od,ura_do,delavci_iz_vo,delavci_iz_gr,delavci_iz_ob,delavci_iz_in,delavci_iz_dr" +
                            ",delavci_na_vo,delavci_na_gr,delavci_na_ob,delavci_na_in,delavci_na_dr,delavci_po_vo,delavci_po_gr,delavci_po_ob,delavci_po_in,delavci_po_dr,delavci_iz_sk,delavci_po_sk,delavci_na_sk," +
                            "stroji_iz_1,stroji_iz_2,stroji_iz_3,stroji_iz_4,stroji_iz_5,stroji_iz_6,stroji_na_1,stroji_na_2,stroji_na_3,stroji_na_4,stroji_na_5,stroji_na_6,vreme_6, vreme_12,vreme_18,vreme_24,temp_6,temp_12,temp_18,temp_24,sestavil,nadzornik,vodja)" +
                            "values (@objekt,@objekt_id,@dnevnik_id,@stevilka,@datum,@ura_od,@ura_do, @delavci_iz_vo,@delavci_iz_gr,@delavci_iz_ob,@delavci_iz_in,@delavci_iz_dr,@delavci_na_vo," +
                            "@delavci_na_gr,@delavci_na_ob,@delavci_na_in,@delavci_na_dr,@delavci_po_vo,@delavci_po_gr,@delavci_po_ob,@delavci_po_in,@delavci_po_dr,@delavci_iz_sk,@delavci_po_sk,@delavci_na_sk," +
                            "@stroji_iz_1,@stroji_iz_2,@stroji_iz_3,@stroji_iz_4,@stroji_iz_5,@stroji_iz_6,@stroji_na_1,@stroji_na_2,@stroji_na_3,@stroji_na_4,@stroji_na_5,@stroji_na_6,@tvreme_1, @tvreme_2, @tvreme_3, @tvreme_4, @ttemp_1, @ttemp_2, @ttemp_3, @ttemp_4, @sestavil,@nadzornik,@vodja);SELECT SCOPE_IDENTITY();";

                            cmd = new SqlCommand(q, con);
                            con.Open();
                            cmd.Parameters.AddWithValue("@objekt_id", tobjekt_id);
                            cmd.Parameters.AddWithValue("@dnevnik_id", novi_id);
                            cmd.Parameters.AddWithValue("@stevilka", tstevilka);
                            cmd.Parameters.AddWithValue("@objekt", tobjekt);
                            cmd.Parameters.AddWithValue("@datum", tdatum);
                            cmd.Parameters.AddWithValue("@ura_od", tura_od);
                            cmd.Parameters.AddWithValue("@ura_do", tura_do);
                            cmd.Parameters.AddWithValue("@delavci_iz_vo", tdelavci_iz_vo);
                            cmd.Parameters.AddWithValue("@delavci_iz_gr", tdelavci_iz_gr);
                            cmd.Parameters.AddWithValue("@delavci_iz_ob", tdelavci_iz_ob);
                            cmd.Parameters.AddWithValue("@delavci_iz_in", tdelavci_iz_in);
                            cmd.Parameters.AddWithValue("@delavci_iz_dr", tdelavci_iz_dr);
                            cmd.Parameters.AddWithValue("@delavci_na_vo", tdelavci_na_vo);
                            cmd.Parameters.AddWithValue("@delavci_na_gr", tdelavci_na_gr);
                            cmd.Parameters.AddWithValue("@delavci_na_ob", tdelavci_na_ob);
                            cmd.Parameters.AddWithValue("@delavci_na_in", tdelavci_na_in);
                            cmd.Parameters.AddWithValue("@delavci_na_dr", tdelavci_na_dr);
                            cmd.Parameters.AddWithValue("@delavci_po_vo", tdelavci_po_vo);
                            cmd.Parameters.AddWithValue("@delavci_po_gr", tdelavci_po_gr);
                            cmd.Parameters.AddWithValue("@delavci_po_ob", tdelavci_po_ob);
                            cmd.Parameters.AddWithValue("@delavci_po_in", tdelavci_po_in);
                            cmd.Parameters.AddWithValue("@delavci_po_dr", tdelavci_po_dr);
                            cmd.Parameters.AddWithValue("@delavci_iz_sk", tdelavci_iz_sk);
                            cmd.Parameters.AddWithValue("@delavci_po_sk", tdelavci_po_sk);
                            cmd.Parameters.AddWithValue("@delavci_na_sk", tdelavci_na_sk);
                            cmd.Parameters.AddWithValue("@stroji_iz_1", tstroji_iz_1);
                            cmd.Parameters.AddWithValue("@stroji_iz_2", tstroji_iz_2);
                            cmd.Parameters.AddWithValue("@stroji_iz_3", tstroji_iz_3);
                            cmd.Parameters.AddWithValue("@stroji_iz_4", tstroji_iz_4);
                            cmd.Parameters.AddWithValue("@stroji_iz_5", tstroji_iz_5);
                            cmd.Parameters.AddWithValue("@stroji_iz_6", tstroji_iz_6);
                            cmd.Parameters.AddWithValue("@stroji_na_1", tstroji_na_1);
                            cmd.Parameters.AddWithValue("@stroji_na_2", tstroji_na_2);
                            cmd.Parameters.AddWithValue("@stroji_na_3", tstroji_na_3);
                            cmd.Parameters.AddWithValue("@stroji_na_4", tstroji_na_4);
                            cmd.Parameters.AddWithValue("@stroji_na_5", tstroji_na_5);
                            cmd.Parameters.AddWithValue("@stroji_na_6", tstroji_na_6);
                            cmd.Parameters.AddWithValue("@tvreme_1", tvreme_1);
                            cmd.Parameters.AddWithValue("@tvreme_2", tvreme_2);
                            cmd.Parameters.AddWithValue("@tvreme_3", tvreme_3);
                            cmd.Parameters.AddWithValue("@tvreme_4", tvreme_4);
                            cmd.Parameters.AddWithValue("@ttemp_1", ttemp_1);
                            cmd.Parameters.AddWithValue("@ttemp_2", ttemp_2);
                            cmd.Parameters.AddWithValue("@ttemp_3", ttemp_3);
                            cmd.Parameters.AddWithValue("@ttemp_4", ttemp_4);
                            cmd.Parameters.AddWithValue("@sestavil", tsestavil);
                            cmd.Parameters.AddWithValue("@nadzornik", tnadzornik);
                            cmd.Parameters.AddWithValue("@vodja", tvodja);
                            id_dodanega_dnevnika = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Napaka pri shranjevanju: " + ex.Message);
                        }
                        finally
                        {
                            if (con != null)
                            {
                                con.Close();
                                shranjeno = true;
                                shranjevanje_ok = true;
                                shrani_situacijo = true;
                                
                            }
                        }

                        indeks_za_izpis = id_dodanega_dnevnika;  // za print
                        // shrani storitve
                        foreach (DataGridViewRow Datarow in dgv1.Rows)
                        {
                            if (Datarow.Cells[0].Value != null && Datarow.Cells[1].Value != null)
                            {
                                tskupina = "";
                                tid_skupine = 0;
                                tid_storitve = 0;

                                tid_dnevnik = id_dodanega_dnevnika;
                                topis = Datarow.Cells[2].Value.ToString();
                                tstoritev = Datarow.Cells[3].Value.ToString();
                                tem = Datarow.Cells[4].Value.ToString();
                                tkos_s = Datarow.Cells[5].Value.ToString();
                                tznesek_s = Datarow.Cells[6].Value.ToString();
                                tddv = 22; // začasno
                                tddv_s = "22";
                                if (tznesek_s == "")
                                {
                                    tznesek = 0;
                                }
                                else
                                {
                                    tznesek = float.Parse(tznesek_s.ToString());
                                }
                                if (tkos_s == "")
                                {
                                    tkos = 0;
                                }
                                else
                                {
                                    tkos = float.Parse(tkos_s.ToString());
                                }
                                if (tddv_s == "")
                                {
                                    tddv = 0;
                                }
                                else
                                {
                                    tddv = float.Parse(tddv_s.ToString());
                                }


                                // Poišči id storitve in id skupine
                                q2 = "select * from tblstoritve where storitev=@storitev";
                                try
                                {
                                    cmd2 = new SqlCommand(q2, con2);
                                    con2.Open();
                                    cmd2.Parameters.AddWithValue("@storitev", tstoritev);
                                    rdr2 = cmd2.ExecuteReader();
                                    while (rdr2.Read())
                                    {
                                        tid_storitve = (int)rdr2["id"];
                                        tid_skupine = (int)rdr2["skupina"];
                                        tid_ddv = (int)rdr2["ddv"];
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Napaka: Poišči id storitve in id skupine  " + ex.Message);
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

                                // Poišči stopnjo ddv
                                q2 = "select stopnja from tbl_ddv where id = @tempddv";  // če sta indexa iz ulic enaka
                                cmd2 = new SqlCommand(q2, con2);
                                con2.Open();
                                cmd2.Parameters.AddWithValue("@tempddv", tid_ddv);
                                cmd2.ExecuteNonQuery();
                                temp_ddv_double = Convert.ToDouble(cmd2.ExecuteScalar());
                                con2.Close();

                                // Poišči naziv skupine
                                q2 = "select * from tblskupinestoritev where id=@id";
                                try
                                {
                                    cmd2 = new SqlCommand(q2, con2);
                                    con2.Open();
                                    cmd2.Parameters.AddWithValue("@id", tid_skupine);
                                    rdr2 = cmd2.ExecuteReader();
                                    while (rdr2.Read())
                                    {
                                        tskupina = (string)rdr2["skupina"];
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Napaka: Poišči naziv skupine  " + ex.Message);
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
                                    q = "insert into tbl_Storitve_Dnevnik (id_dnevnik,opis,id_skupina,skupina,id_storitev,storitev,em,kos,znesek,datum,ddv,objekt,id_objekta) " +
                                        "values (@id_dnevnik,@opis,@id_skupina,@skupina,@id_storitev,@storitev,@em,@kos,@znesek,@datum,@ddv,@objekt,@id_objekta)";
                                    cmd = new SqlCommand(q, con);
                                    con.Open();
                                    cmd.Parameters.AddWithValue("@id_dnevnik", id_dodanega_dnevnika);
                                    cmd.Parameters.AddWithValue("@opis", topis);
                                    cmd.Parameters.AddWithValue("@id_skupina", tid_skupine);
                                    cmd.Parameters.AddWithValue("@skupina", tskupina);
                                    cmd.Parameters.AddWithValue("@id_storitev", tid_storitve);
                                    cmd.Parameters.AddWithValue("@storitev", tstoritev);
                                    cmd.Parameters.AddWithValue("@em", tem);
                                    cmd.Parameters.AddWithValue("@kos", tkos);
                                    cmd.Parameters.AddWithValue("@znesek", tznesek);
                                    cmd.Parameters.AddWithValue("@datum", tdatum);
                                    cmd.Parameters.AddWithValue("@ddv", temp_ddv_double);
                                    cmd.Parameters.AddWithValue("@objekt", tobjekt);
                                    cmd.Parameters.AddWithValue("@id_objekta", id_objekta);
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Napaka pri shranjevanju storitev: " + ex.Message);
                                }
                                finally
                                {
                                    if (con != null)
                                    {
                                        con.Close();
                                        shranjeno = true;
                                        shranjevanje_ok = true;
                                    }
                                } // try
                            }  // if
                        }  // foreach


                        Brisi_stari_dnevnik();
                        Shrani_situacijo();
                        }
                        shranjevanje_ok = false;
                        odprt = false;
                        dodajanje = false;
                    //Novi_dnevnik();

                    Gumbi_zacetek2();
                    Gumbi_storitve_off();
                    onemogoci_tb();
                    btnIzpis.Enabled = true;
                    btnIzpis.BackColor = frmMain.barva_gumb2_neakt;
                    btnSpremeni.Enabled = true;
                    btnSpremeni.BackColor = frmMain.barva_gumb2_neakt;
                    //Zacetek(); // novo 30-8
                } // if (dodajanje=true)
                } // yesno
                else
                {
                    cb1.Focus();
                }
            }
        
        private void Shrani_situacijo()
        {
            if (shrani_situacijo == true)
            // shrani situacijo
            {
                situacija_obstaja = false;
                string tmp_id_objekta = Convert.ToString(id_objekta);
                string tmp_mesec = tdatum.ToString("MMMM");
                string tmp_mesec_ss = tdatum.ToString("MM");
                string tmp_leto = tdatum.ToString("yyyy");
                string tmp_dan = tdatum.ToString("dd");
                ss_dan = Convert.ToInt32(tmp_dan);
                ss_mesec = Convert.ToInt32(tmp_mesec_ss);
                ss_leto = Convert.ToInt32(tmp_leto);
                ss_datum = tdatum;

                idx_situacije = tmp_leto + tmp_mesec + tmp_id_objekta;

                // preveri če situacija že obstaja
                try
                {
                    q = "SELECT * FROM tblSituacije WHERE id_situacije=@idx";
                    cmd = new SqlCommand(q, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@idx", idx_situacije);
                    rdr = cmd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        // situacija še ne obstaja, shrani
                        situacija_obstaja = true;
                    }
                    else
                    {
                        // situacija še ne obstaja, shrani
                        situacija_obstaja = false;
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
                if (situacija_obstaja == false)
                {
                    // Še ne obstaja - Shrani situacijo
                    try
                    {
                        q = "insert into tblSituacije(id_objekta,objekt,mesec,leto,datum,id_situacije)" +
                        " values(@id_objekta,@objekt,@mesec,@leto,@datum,@id_situacije)";
                        cmd = new SqlCommand(q, con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id_objekta", id_objekta);
                        cmd.Parameters.AddWithValue("@objekt", tobjekt);
                        cmd.Parameters.AddWithValue("@mesec", tmp_mesec);
                        cmd.Parameters.AddWithValue("@leto", tmp_leto);
                        cmd.Parameters.AddWithValue("@datum", tdatum);
                        cmd.Parameters.AddWithValue("@id_situacije", idx_situacije);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka: dodaj situacijo " + ex.Message);
                    }
                    finally
                    {
                        if (con != null)
                        {
                            con.Close();
                        }
                        // shrani vse storitve v novo situacijo  // pozneje samo dodajaj količine
                        // najdi id situacije
                        q2 = "select id from tblSituacije where id_situacije=@idx";
                        try
                        {
                            cmd2 = new SqlCommand(q2, con2);
                            con2.Open();
                            cmd2.Parameters.AddWithValue("@idx", idx_situacije);
                            cmd2.ExecuteNonQuery();
                            ss_id_situacije = (int)cmd2.ExecuteScalar();  // glavni id situacije
                            con2.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Napaka: ne najdem situacije za vpis storitev situacije: " + ex.Message);
                        }

                        Shrani_storitve_situacije();
                    }
                } // if situacija obstaja = false
                else
                {
                    // situacija že obstaja, samo dodaj količine storitev po dnevih
                    // najdi id situacije
                    q2 = "select id from tblSituacije where id_situacije=@idx";
                    try
                    {
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@idx", idx_situacije);
                        cmd2.ExecuteNonQuery();
                        ss_id_situacije = (int)cmd2.ExecuteScalar();  // glavni id situacije
                        con2.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka: ne najdem situacije za vpis storitev situacije: " + ex.Message);
                    }
                    Shrani_storitve_situacije();
                }

            }  // shrani situacijo 


        }
        
        private void Shrani_storitve_situacije()
        {
            // če si spreminjal dnevnik - najprej brisanje storitev v situaciji, nato dodajanje
            // če si brisal dnevnik, samo brisanje storitev v situaciji
            if (odprt==true)
            {
                try
                {
                    q = "delete from tbl_situacija_storitve where id_dnevnik = @tid";
                    cmd = new SqlCommand(q, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@tid", index_odpri);
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


            }

            foreach (DataGridViewRow Datarow in dgv1.Rows)
            {
                if (Datarow.Cells[0].Value != null && Datarow.Cells[1].Value != null)
                {
                    ss_storitev = "";
                    int ss_id_dnevnika = id_dodanega_dnevnika;
                    tstoritev = Datarow.Cells[3].Value.ToString();
                    tkos_s = Datarow.Cells[5].Value.ToString();

                    if (tkos_s == "")
                    {
                        tkos = 0;
                    }
                    else
                    {
                        tkos = Convert.ToDouble(tkos_s);
                        tkos = float.Parse(tkos_s.ToString());
                    }
                    ss_kol = tkos;
                    Math.Round(ss_kol, 2);
                    // Poišči id storitve in id skupine
                    q2 = "select * from tblstoritve where storitev=@storitev";
                    try
                    {
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@storitev", tstoritev);
                        rdr2 = cmd2.ExecuteReader();
                        while (rdr2.Read())
                        {
                            ss_id_storitve = (int)rdr2["Id"];
                            ss_id_skupine = (int)rdr2["skupina"];
                            ss_storitev = (string)rdr2["storitev"];
                            ss_id_em = (int)rdr2["em"];
                            ss_id_ddv = (int)rdr2["ddv"];
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka: Poišči id storitve in id skupine  " + ex.Message);
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

                    // najdi em
                    q2 = "select em from tbl_enote where id = @tid";  // če sta indexa iz ulic enaka
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@tid", ss_id_em);
                    cmd2.ExecuteNonQuery();
                    string ss_em = (string)cmd2.ExecuteScalar();
                    con2.Close();

                    // najdi ddv
                    q2 = "select stopnja from tbl_ddv where id = @tempddv";  // če sta indexa iz ulic enaka
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@tempddv", ss_id_ddv);
                    cmd2.ExecuteNonQuery();
                    double ss_ddv = Convert.ToDouble(cmd2.ExecuteScalar());
                    con2.Close();

                    // najdi skupina storitev
                    q2 = "select skupina from tblskupinestoritev where id = @tid";  // če sta indexa iz ulic enaka
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@tid", ss_id_skupine);
                    cmd2.ExecuteNonQuery();
                    string ss_skupina = (string)cmd2.ExecuteScalar();
                    con2.Close();

                    // najdi ceno za občino v ceniku
                    q2 = "select cena_obcina from tbl_cenik where storitev = @idx";  // če sta indexa iz ulic enaka
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@idx", ss_id_storitve);
                    cmd2.ExecuteNonQuery();
                    double ss_cena = Convert.ToDouble(cmd2.ExecuteScalar());
                    con2.Close();

                    // shrani storitev - situacija
                    try
                    {
                        string str_kol=ss_kol.ToString("F2");
                        ss_kol = Convert.ToDouble(str_kol);
                        q2 = "insert into tbl_situacija_storitve (id_situacije,id_storitve,storitev,em,ddv,cena,kol_1, id_skupina,skupina,dan,mesec,leto,datum,id_dnevnik) " +
                        "values(@id_situacije,@id_storitve,@storitev,@em,@ddv,@cena,@kol_1,@id_skupina,@skupina,@dan,@mesec,@leto,@datum,@id_dnevnik)";
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@id_situacije", ss_id_situacije);
                        cmd2.Parameters.AddWithValue("@id_storitve", ss_id_storitve);
                        cmd2.Parameters.AddWithValue("@storitev", ss_storitev);
                        cmd2.Parameters.AddWithValue("@em", ss_em);
                        cmd2.Parameters.AddWithValue("@ddv", ss_ddv);
                        cmd2.Parameters.AddWithValue("@cena", 0);
                        cmd2.Parameters.AddWithValue("@kol_1", ss_kol);
                        cmd2.Parameters.AddWithValue("@id_skupina", ss_id_skupine);
                        cmd2.Parameters.AddWithValue("@skupina", ss_skupina);
                        cmd2.Parameters.AddWithValue("@dan", ss_dan);
                        cmd2.Parameters.AddWithValue("@mesec", ss_mesec);
                        cmd2.Parameters.AddWithValue("@leto", ss_leto);
                        cmd2.Parameters.AddWithValue("@datum", ss_datum);
                        cmd2.Parameters.AddWithValue("@id_dnevnik", ss_id_dnevnika);
                        cmd2.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka dodaj posamezno storitev za situacijo: " + ex.Message);
                    }
                    finally
                    {
                        if (con2 != null)
                        {
                            con2.Close();
                        }
                    }
                }  // if
            }  // foreach
        }

        private void Update_storitve()
        {

        } // private void
        private void Brisi_stari_dnevnik()
        {
            // briši stari dnevnik, če si uspešno shranil novega
            if (shranjevanje_ok == true && odprt == true)
            {
                try
                {
                    q = "delete from tbl_dnevnik where id = @tid";  // ??? začasno
                    cmd = new SqlCommand(q, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@tid", index_odpri);
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
                    cmd.Parameters.AddWithValue("@tid", index_odpri);
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
            } // if shranjevanje_ok
        }


        private void Preklici()
        {
            DialogResult result = MessageBox.Show("Želiš preklicati vnašanje gradbenega dnevnika?", "Prekliči", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (dodajanje)
                {
                    Zacetek();
                }
                else
                {
                    Gumbi_zacetek2();
                    Gumbi_storitve_off();
                    onemogoci_tb();
                    btnIzpis.Enabled = true;
                    btnIzpis.BackColor = frmMain.barva_gumb2_neakt;
                    btnSpremeni.Enabled = true;
                    btnSpremeni.BackColor = frmMain.barva_gumb2_neakt;
                }
            }
            else
            {
                cb1.Focus();
            }

        }
        private void Grid()
        {
            dgv1.ColumnCount = 7;
        }
        private void onemogoci_tb()
        {
            tb3.Enabled = false;
            tb2.Enabled = false;
            tb1.Enabled = false;
            tb4.Enabled = false;
            tb5.Enabled = false;
            tb6.Enabled = false;
            tb7.Enabled = false;
            tb8.Enabled = false;
            tb9.Enabled = false;
            tb10.Enabled = false;
            tb11.Enabled = false;
            tb12.Enabled = false;
            tb13.Enabled = false;
            tb14.Enabled = false;
            tb15.Enabled = false;
            tb16.Enabled = false;
            tb17.Enabled = false;
            tb18.Enabled = false;
            tb19.Enabled = false;
            tb20.Enabled = false;
            tb21.Enabled = false;
            tb22.Enabled = false;
            tb23.Enabled = false;
            tb24.Enabled = false;
            tb25.Enabled = false;
            tb26.Enabled = false;
            tb27.Enabled = false;
            tb28.Enabled = false;
            tb29.Enabled = false;
            tb30.Enabled = false;
            tb50.Enabled = false;
            tb51.Enabled = false;
            tb52.Enabled = false;
            dt1.Enabled = false;
            dgv1.Enabled = false;

            tbv3.Enabled = false;
            tbv2.Enabled = false;
            tbv1.Enabled = false;
            tbv4.Enabled = false;
            tbv5.Enabled = false;
            tbv6.Enabled = false;
            tbv7.Enabled = false;
            tbv8.Enabled = false;
            tb100.Enabled = false;
            tb101.Enabled = false;
            tb102.Enabled = false;
            tb103.Enabled = false;


            tb1.BackColor = frmMain.barva_tb_onemogoceno;
            tb2.BackColor = frmMain.barva_tb_onemogoceno;
            tb3.BackColor = frmMain.barva_tb_onemogoceno;
            tb4.BackColor = frmMain.barva_tb_onemogoceno;
            tb5.BackColor = frmMain.barva_tb_onemogoceno;
            tb6.BackColor = frmMain.barva_tb_onemogoceno;
            tb7.BackColor = frmMain.barva_tb_onemogoceno;
            tb8.BackColor = frmMain.barva_tb_onemogoceno;
            tb9.BackColor = frmMain.barva_tb_onemogoceno;
            tb10.BackColor = frmMain.barva_tb_onemogoceno;
            tb11.BackColor = frmMain.barva_tb_onemogoceno;
            tb12.BackColor = frmMain.barva_tb_onemogoceno;
            tb13.BackColor = frmMain.barva_tb_onemogoceno;
            tb14.BackColor = frmMain.barva_tb_onemogoceno;
            tb15.BackColor = frmMain.barva_tb_onemogoceno;
            tb16.BackColor = frmMain.barva_tb_onemogoceno;
            tb17.BackColor = frmMain.barva_tb_onemogoceno;
            tb18.BackColor = frmMain.barva_tb_onemogoceno;

            tb19.BackColor = frmMain.barva_tb_onemogoceno;
            tb20.BackColor = frmMain.barva_tb_onemogoceno;
            tb21.BackColor = frmMain.barva_tb_onemogoceno;
            tb22.BackColor = frmMain.barva_tb_onemogoceno;
            tb23.BackColor = frmMain.barva_tb_onemogoceno;
            tb24.BackColor = frmMain.barva_tb_onemogoceno;
            tb25.BackColor = frmMain.barva_tb_onemogoceno;
            tb26.BackColor = frmMain.barva_tb_onemogoceno;
            tb27.BackColor = frmMain.barva_tb_onemogoceno;
            tb28.BackColor = frmMain.barva_tb_onemogoceno;
            tb29.BackColor = frmMain.barva_tb_onemogoceno;
            tb30.BackColor = frmMain.barva_tb_onemogoceno;

            tbv1.BackColor = frmMain.barva_tb_onemogoceno;
            tbv2.BackColor = frmMain.barva_tb_onemogoceno;
            tbv3.BackColor = frmMain.barva_tb_onemogoceno;
            tbv4.BackColor = frmMain.barva_tb_onemogoceno;
            tbv5.BackColor = frmMain.barva_tb_onemogoceno;
            tbv6.BackColor = frmMain.barva_tb_onemogoceno;
            tbv7.BackColor = frmMain.barva_tb_onemogoceno;
            tbv8.BackColor = frmMain.barva_tb_onemogoceno;

            tb50.BackColor = frmMain.barva_tb_onemogoceno;
            tb51.BackColor = frmMain.barva_tb_onemogoceno;
            tb52.BackColor = frmMain.barva_tb_onemogoceno;

            
            cb1.DropDownStyle = ComboBoxStyle.DropDownList;
            cb1.BackColor = frmMain.barva_tb_onemogoceno;
            cb2.BackColor = frmMain.barva_tb_onemogoceno;
            cb2.DropDownStyle = ComboBoxStyle.DropDownList;
            cb3.BackColor = frmMain.barva_tb_onemogoceno;
            cb3.DropDownStyle = ComboBoxStyle.DropDownList;
            cb4.BackColor = frmMain.barva_tb_onemogoceno;
            cb4.DropDownStyle = ComboBoxStyle.DropDownList;
            cb5.BackColor = frmMain.barva_tb_onemogoceno;
            cb5.DropDownStyle = ComboBoxStyle.DropDownList;
            
            cb1.Enabled = false;
            cb2.Enabled = false;
            cb3.Enabled = false;
            cb4.Enabled = false;
            cb5.Enabled = false;

            //MessageBox.Show("čakam");
            tb101.BackColor = DefaultBackColor;
            tb103.BackColor = DefaultBackColor;

            tb100.BackColor = frmMain.barva_tb_onemogoceno;
            tb101.BackColor = frmMain.barva_tb_onemogoceno;
            tb102.BackColor = frmMain.barva_tb_onemogoceno;
            tb103.BackColor = frmMain.barva_tb_onemogoceno;

            Gumbi_storitve_off();
        }

        private void omogoci_tb()
        {
            dgv1.Enabled = true;
            tb8.Enabled = true;
            tb9.Enabled = true;
            cb1.Enabled = true;
            cb2.Enabled = true;
            cb3.Enabled = true;
            cb4.Enabled = true;
            cb5.Enabled = true;
            tb2.Enabled = true;
            tb1.Enabled = true;
            tb3.Enabled = true;
            tb4.Enabled = true;
            tb5.Enabled = true;
            tb6.ReadOnly = true;
            tb12.ReadOnly = true;
            tb18.ReadOnly = true;
            tb18.ForeColor = Color.Black;
            tb7.Enabled = true;
            tb10.Enabled = true;
            tb11.Enabled = true;
            tb13.Enabled = true;
            tb14.Enabled = true;
            tb15.Enabled = true;
            tb16.Enabled = true;
            tb17.Enabled = true;
            tb19.Enabled = true;
            tb20.Enabled = true;
            tb21.Enabled = true;
            tb22.Enabled = true;
            tb23.Enabled = true;
            tb24.Enabled = true;
            tb25.Enabled = true;
            tb26.Enabled = true;
            tb27.Enabled = true;
            tb28.Enabled = true;
            tb29.Enabled = true;
            tb30.Enabled = true;
            tb50.Enabled = true;
            tb51.Enabled = true;
            tb52.Enabled = true;
            dt1.Enabled = true;
            //tb101.ReadOnly = true;
            //tb103.ReadOnly = true;
            //tb101.BackColor = Color.White;

            tbv3.Enabled = true;
            tbv2.Enabled = true;
            tbv1.Enabled = true;
            tbv4.Enabled = true;
            tbv5.Enabled = true;
            tbv6.Enabled = true;
            tbv7.Enabled = true;
            tbv8.Enabled = true;
            tb100.Enabled = true;
            tb101.Enabled = true;
            tb102.Enabled = true;
            tb103.Enabled = true;

            tb1.BackColor = frmMain.barva_tb_omogoceno;
            tb2.BackColor = frmMain.barva_tb_omogoceno;
            tb3.BackColor = frmMain.barva_tb_omogoceno;
            tb4.BackColor = frmMain.barva_tb_omogoceno;
            tb5.BackColor = frmMain.barva_tb_omogoceno;
            tb6.BackColor = frmMain.barva_tb_omogoceno;
            tb7.BackColor = frmMain.barva_tb_omogoceno;
            tb8.BackColor = frmMain.barva_tb_omogoceno;
            tb9.BackColor = frmMain.barva_tb_omogoceno;
            tb10.BackColor = frmMain.barva_tb_omogoceno;
            tb11.BackColor = frmMain.barva_tb_omogoceno;
            tb12.BackColor = frmMain.barva_tb_omogoceno;
            tb13.BackColor = frmMain.barva_tb_omogoceno;
            tb14.BackColor = frmMain.barva_tb_omogoceno;
            tb15.BackColor = frmMain.barva_tb_omogoceno;
            tb16.BackColor = frmMain.barva_tb_omogoceno;
            tb17.BackColor = frmMain.barva_tb_omogoceno;
            tb18.BackColor = frmMain.barva_tb_omogoceno;

            tb19.BackColor = frmMain.barva_tb_omogoceno;
            tb20.BackColor = frmMain.barva_tb_omogoceno;
            tb21.BackColor = frmMain.barva_tb_omogoceno;
            tb22.BackColor = frmMain.barva_tb_omogoceno;
            tb23.BackColor = frmMain.barva_tb_omogoceno;
            tb24.BackColor = frmMain.barva_tb_omogoceno;
            tb25.BackColor = frmMain.barva_tb_omogoceno;
            tb26.BackColor = frmMain.barva_tb_omogoceno;
            tb27.BackColor = frmMain.barva_tb_omogoceno;
            tb28.BackColor = frmMain.barva_tb_omogoceno;
            tb29.BackColor = frmMain.barva_tb_omogoceno;
            tb30.BackColor = frmMain.barva_tb_omogoceno;

            tbv1.BackColor = frmMain.barva_tb_omogoceno;
            tbv2.BackColor = frmMain.barva_tb_omogoceno;
            tbv3.BackColor = frmMain.barva_tb_omogoceno;
            tbv4.BackColor = frmMain.barva_tb_omogoceno;
            tbv5.BackColor = frmMain.barva_tb_omogoceno;
            tbv6.BackColor = frmMain.barva_tb_omogoceno;
            tbv7.BackColor = frmMain.barva_tb_omogoceno;
            tbv8.BackColor = frmMain.barva_tb_omogoceno;

            tb50.BackColor = frmMain.barva_tb_omogoceno;
            tb51.BackColor = frmMain.barva_tb_omogoceno;
            tb52.BackColor = frmMain.barva_tb_omogoceno;

            cb1.BackColor = frmMain.barva_tb_omogoceno;
            cb1.DropDownStyle = ComboBoxStyle.DropDownList;
            cb2.BackColor = frmMain.barva_tb_omogoceno;
            cb2.DropDownStyle = ComboBoxStyle.DropDownList;
            cb3.BackColor = frmMain.barva_tb_omogoceno;
            cb3.DropDownStyle = ComboBoxStyle.DropDownList;
            cb4.BackColor = frmMain.barva_tb_omogoceno;
            cb4.DropDownStyle = ComboBoxStyle.DropDownList;
            cb5.BackColor = frmMain.barva_tb_omogoceno;
            cb5.DropDownStyle = ComboBoxStyle.DropDownList;

            tb101.BackColor = DefaultBackColor;
            tb103.BackColor = DefaultBackColor;

            tb100.BackColor = frmMain.barva_tb_omogoceno;
            tb101.BackColor = frmMain.barva_tb_omogoceno;
            tb102.BackColor = frmMain.barva_tb_omogoceno;
            tb103.BackColor = frmMain.barva_tb_omogoceno;

            Gumbi_storitve_on();
        }

        private void izprazni_tb()
        {
            tb3.Text = "";
            tb2.Text = "";
            tb1.Text = "";
            tb4.Text = "";
            tb5.Text = "";
            tb6.Text = "";
            tb7.Text = "";
            tb8.Text = "";
            tb9.Text = "";
            tb10.Text = "";
            tb11.Text = "";
            tb12.Text = "";
            tb13.Text = "";
            tb14.Text = "";
            tb15.Text = "";
            tb16.Text = "";
            tb17.Text = "";
            tb18.Text = "";
            tb19.Text = "";
            tb20.Text = "";
            tb21.Text = "";
            tb22.Text = "";
            tb23.Text = "";
            tb24.Text = "";
            tb25.Text = "";
            tb26.Text = "";
            tb27.Text = "";
            tb28.Text = "";
            tb29.Text = "";
            tb30.Text = "";
            tb100.Text = "";
            tb101.Text = "";
            tb102.Text = "";
            tb103.Text = "";
            cb2.Text = "";
            //cb2.Items.Clear();
            cb1.Text = "";
            cb3.Text = "";
            cb4.Text = "";
            cb5.Text = "";
            tb50.Text = "";
            tb51.Text = "";
            tb52.Text = "";
            // vreme - novo
            tbv1.Text = "";
            tbv2.Text = "";
            tbv3.Text = "";
            tbv4.Text = "";
            tbv5.Text = "";
            tbv6.Text = "";
            tbv7.Text = "";
            tbv8.Text = "";

            Izprazni_dgv();
        }

        private void btnNazaj_Click(object sender, EventArgs e)
        {
            if (shranjeno == true)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                DialogResult result = MessageBox.Show("Spremembe niso shranjene. Želiš končati?", "Potrdi konec", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
                else
                {
                    cb1.Focus();
                }
            }
    
        }

        private void btnIzpis_Click(object sender, EventArgs e)
        {
            
            odpri = false;
            // prenesi dnevnik v izpis
            frmPrejsnji_dnevniki.iz_prejsnji = false;
            iz_gradbeni = true;
            frmDnevnik_Izpis secondForm = new frmDnevnik_Izpis();
            secondForm.ShowDialog();
        }

        private void cb1_MouseClick(object sender, MouseEventArgs e)
        {
            cb1.DroppedDown = true;
        }
        private void sestej_i()
        {

            tb1s = tb1.Text;
            if (tb1s == "")
            {
                tb1s = "0";
            }

            tb2s = tb2.Text;
            if (tb2s == "")
            {
                tb2s = "0";
            }

            tb3s = tb3.Text;
            if (tb3s == "")
            {
                tb3s = "0";
            }

            tb4s = tb4.Text;
            if (tb4s == "")
            {
                tb4s = "0";
            }

            tb5s = tb5.Text;
            if (tb5s == "")
            {
                tb5s = "0";
            }
            tb1i = Convert.ToInt32(tb1s);
            tb2i = Convert.ToInt32(tb2s);
            tb3i = Convert.ToInt32(tb3s);
            tb4i = Convert.ToInt32(tb4s);
            tb5i = Convert.ToInt32(tb5s);

            int vsota = tb1i + tb2i + tb3i + tb4i + tb5i;
            tb6.Text = Convert.ToString(vsota);
        }
        private void sestej_n()
        {
            tb7s = tb7.Text;
            if (tb7s == "")
            {
                tb7s = "0";
            }

            tb8s = tb8.Text;
            if (tb8s == "")
            {
                tb8s = "0";
            }

            tb9s = tb9.Text;
            if (tb9s == "")
            {
                tb9s = "0";
            }

            tb10s = tb10.Text;
            if (tb10s == "")
            {
                tb10s = "0";
            }

            tb11s = tb11.Text;
            if (tb11s == "")
            {
                tb11s = "0";
            }

            tb7i = Convert.ToInt32(tb7s);
            tb8i = Convert.ToInt32(tb8s);
            tb9i = Convert.ToInt32(tb9s);
            tb10i = Convert.ToInt32(tb10s);
            tb11i = Convert.ToInt32(tb11s);

            int vsota = tb7i + tb8i + tb9i + tb10i + tb11i;
            tb12.Text = Convert.ToString(vsota);
        }
        private void sestej_p()
        {
            tb13s = tb13.Text;
            if (tb13s == "")
            {
                tb13s = "0";
            }

            tb14s = tb14.Text;
            if (tb14s == "")
            {
                tb14s = "0";
            }

            tb15s = tb15.Text;
            if (tb15s == "")
            {
                tb15s = "0";
            }

            tb16s = tb16.Text;
            if (tb16s == "")
            {
                tb16s = "0";
            }

            tb17s = tb17.Text;
            if (tb17s == "")
            {
                tb17s = "0";
            }

            tb13i = Convert.ToInt32(tb13s);
            tb14i = Convert.ToInt32(tb14s);
            tb15i = Convert.ToInt32(tb15s);
            tb16i = Convert.ToInt32(tb16s);
            tb17i = Convert.ToInt32(tb17s);

            int vsota = tb13i + tb14i + tb15i + tb16i + tb17i;
            tb18.Text = Convert.ToString(vsota);
        }

        private void tb1_Leave(object sender, EventArgs e)
        {
    
        }

        private void tb2_Leave(object sender, EventArgs e)
        {
         
        }

        private void tb3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tb4_Leave(object sender, EventArgs e)
        {
            tb4s = tb4.Text;
            if (tb4s == "")
            {
                tb4s = "0";
            }
            if (Je_stevilo(tb4s))
            {
                sestej_i();
                shrani_ok = true;
            }
            else
            {
                MessageBox.Show("Vnesi število delavcev!");
                tb4.Focus();
                shrani_ok = false;
            }
        }

        private void tb5_Leave(object sender, EventArgs e)
        {
            tb5s = tb5.Text;
            if (tb5s == "")
            {
                tb5s = "0";
            }
            if (Je_stevilo(tb5s))
            {
                sestej_i();
                shrani_ok = true;
            }
            else
            {
                MessageBox.Show("Vnesi število delavcev!");
                tb5.Focus();
                shrani_ok = false;
            }
        }

        private void tb7_Leave(object sender, EventArgs e)
        {
            tb7s = tb7.Text;
            if (tb7s == "")
            {
                tb7s = "0";
            }
            if (Je_stevilo(tb7s))
            {
                sestej_n();
                shrani_ok = true;
            }
            else
            {
                MessageBox.Show("Vnesi število delavcev!");
                tb7.Focus();
                shrani_ok = false;
            }
        }

        private void tb8_Leave(object sender, EventArgs e)
        {
            tb8s = tb8.Text;
            if (tb8s == "")
            {
                tb8s = "0";
            }
            if (Je_stevilo(tb8s))
            {
                sestej_n();
                shrani_ok = true;
            }
            else
            {
                MessageBox.Show("Vnesi število delavcev!");
                tb8.Focus();
                shrani_ok = false;
            }
        }

        private void tb9_Leave(object sender, EventArgs e)
        {
            tb9s = tb9.Text;
            if (tb9s == "")
            {
                tb9s = "0";
            }
            if (Je_stevilo(tb9s))
            {
                sestej_n();
                shrani_ok = true;
            }
            else
            {
                MessageBox.Show("Vnesi število delavcev!");
                tb9.Focus();
                shrani_ok = false;
            }
        }

        private void tb10_Leave(object sender, EventArgs e)
        {
            tb10s = tb10.Text;
            if (tb10s == "")
            {
                tb10s = "0";
            }
            if (Je_stevilo(tb10s))
            {
                sestej_n();
                shrani_ok = true;
            }
            else
            {
                MessageBox.Show("Vnesi število delavcev!");
                tb10.Focus();
                shrani_ok = false;
            }
        }

        private void tb11_Leave(object sender, EventArgs e)
        {
            tb11s = tb11.Text;
            if (tb11s == "")
            {
                tb11s = "0";
            }
            if (Je_stevilo(tb11s))
            {
                sestej_n();
                shrani_ok = true;
            }
            else
            {
                MessageBox.Show("Vnesi število delavcev!");
                tb11.Focus();
                shrani_ok = false;
            }
        }

        private void tb13_Leave(object sender, EventArgs e)
        {
            tb13s = tb13.Text;
            if (tb13s == "")
            {
                tb13s = "0";
            }
            if (Je_stevilo(tb13s))
            {
                sestej_p();
                shrani_ok = true;
            }
            else
            {
                MessageBox.Show("Vnesi število delavcev!");
                tb13.Focus();
                shrani_ok = false;
            }

        }

        private void tb14_Leave(object sender, EventArgs e)
        {
            tb14s = tb14.Text;
            if (tb14s == "")
            {
                tb14s = "0";
            }
            if (Je_stevilo(tb14s))
            {
                sestej_p();
                shrani_ok = true;
            }
            else
            {
                MessageBox.Show("Vnesi število delavcev!");
                tb14.Focus();
                shrani_ok = false;
            }

        }

        private void tb15_Leave(object sender, EventArgs e)
        {
            tb15s = tb15.Text;
            if (tb15s == "")
            {
                tb15s = "0";
            }
            if (Je_stevilo(tb15s))
            {
                sestej_p();
                shrani_ok = true;
            }
            else
            {
                MessageBox.Show("Vnesi število delavcev!");
                tb15.Focus();
                shrani_ok = false;
            }

        }

        private void tb16_Leave(object sender, EventArgs e)
        {
            tb16s = tb16.Text;
            if (tb16s == "")
            {
                tb16s = "0";
            }
            if (Je_stevilo(tb16s))
            {
                sestej_p();
                shrani_ok = true;
            }
            else
            {
                MessageBox.Show("Vnesi število delavcev!");
                tb16.Focus();
                shrani_ok = false;
            }

        }

        private void tb17_Leave(object sender, EventArgs e)
        {
            tb17s = tb17.Text;
            if (tb17s == "")
            {
                tb17s = "0";
            }
            if (Je_stevilo(tb17s))
            {
                sestej_p();
                shrani_ok = true;
            }
            else
            {
                MessageBox.Show("Vnesi število delavcev!");
                tb17.Focus();
                shrani_ok = false;
            }

        }
        private void Gradbeni_dnevnik_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                if (btnDodaj_stor.Enabled == true)
                {
                    dodaj = true;
                    zamenjaj = false;
                    Dodaj();
                    tb103.Text = "";
                    tb102.Text = "";
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                if (btnPreklici_stor.Enabled == true)
                {
                    preklicano = true;
                    Preklici_storitev();
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
        private void cb3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {

                cb3.DroppedDown = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                cb4.Focus();
            }

        }

        private void cb4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {

                cb4.DroppedDown = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                cb5.Focus();
            }

        }

        private void cb5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {

                cb5.DroppedDown = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnShrani.Focus();
            }

        }


        private void btnShrani_Click(object sender, EventArgs e)
        {
            Shrani();
            
        }

        private void btnPreklici_Click(object sender, EventArgs e)
        {
            Preklici();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (dodaj==true)
            {
                if (cb2.Text == "")
                {
                    MessageBox.Show("Izberi storitev.");
                    cb2.Focus();
                }
                else
                    Dodaj();
            }
            if (zamenjaj == true)
            {
                Zamenjaj();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
