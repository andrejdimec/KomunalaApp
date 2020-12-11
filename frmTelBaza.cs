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
    public partial class frmTelBaza : Form
    {
        SqlConnection con = frmMain.c;
        SqlConnection con2 = frmMain.c2;
        SqlConnection con3 = frmMain.c3;
        SqlCommand cmd, cmd2, cmd3;
        SqlDataReader rdr, rdr2, rdr3 = null;

        string q, q2, q3;
        string index;
        int izbrana_skupina, trenutni, tid, prvi_id;
        bool dodajanje, osnovno, spreminjanje,prvic, poslano;
        Dictionary<int, string> OsebeDict = new Dictionary<int, string>();
        Dictionary<int, string> ObjektiDict = new Dictionary<int, string>();
        Dictionary<int, string> SkupineDict = new Dictionary<int, string>();

        int stevec;
        string fnamept, vrstica, tel_1, tel_2;
        string filter_1, filter_2;
        string sm_koda, sm_opis, tsm, tsm_opis;

        private void Prestej() // koliko je katerih številk
        {
            int vseh,aktivnih, odjavljenih, mobilnih, stacionarnih, telemetrije, drugih, internetnih, zaposlenih;

            //q2 = "select count(*) from tbl_telefonske where aktivna=0";
            //cmd2 = new SqlCommand(q2, con2);
            //con2.Open();
            //odjavljenih = (Int32)cmd.ExecuteScalar();
           // con2.Close();
            q2 = "select count(*) from tbl_telefonske where aktivna=1";
            cmd2 = new SqlCommand(q2, con2);
            con2.Open();
            aktivnih = (Int32)cmd2.ExecuteScalar();
            con2.Close();
            q2 = "select count(*) from tbl_telefonske where rb_oseba=1 and aktivna=1";
            cmd2 = new SqlCommand(q2, con2);
            con2.Open();
            zaposlenih = (Int32)cmd2.ExecuteScalar();
            con2.Close();
            q2 = "select count(*) from tbl_telefonske where rb_oseba=2 and aktivna=1";
            cmd2 = new SqlCommand(q2, con2);
            con2.Open();
            telemetrije = (Int32)cmd2.ExecuteScalar();
            con2.Close();
            q2 = "select count(*) from tbl_telefonske where rb_oseba=3 and aktivna=1";
            cmd2 = new SqlCommand(q2, con2);
            con2.Open();
            internetnih = (Int32)cmd2.ExecuteScalar();
            con2.Close();
            q2 = "select count(*) from tbl_telefonske where rb_oseba=4 and aktivna=1";
            cmd2 = new SqlCommand(q2, con2);
            con2.Open();
            drugih = (Int32)cmd2.ExecuteScalar();
            con2.Close();
            q2 = "select count(*) from tbl_telefonske where rb_mobilna=1 and aktivna=1";
            cmd2 = new SqlCommand(q2, con2);
            con2.Open();
            mobilnih = (Int32)cmd2.ExecuteScalar();
            con2.Close();
            q2 = "select count(*) from tbl_telefonske where rb_mobilna=2 and aktivna=1";
            cmd2 = new SqlCommand(q2, con2);
            con2.Open();
            stacionarnih = (Int32)cmd2.ExecuteScalar();
            con2.Close();

            stevilke.Text = "Aktivnih: " + Convert.ToString(aktivnih) + "     Osebnih: " + Convert.ToString(zaposlenih) + "     Telemetrija: " + Convert.ToString(telemetrije) 
                + "     Mob. internet: " + Convert.ToString(internetnih) + "     Drugo: " + Convert.ToString(drugih) + "     Mobilnih: " + Convert.ToString(mobilnih) + "     Stacionarnih: " + Convert.ToString(stacionarnih);
        }

        private void Osebe_v_cb()
        {

            q2 = "select * from tbl_sodelavci order by priimek";
            try
            {
                cmd2 = new SqlCommand(q2, con2);
                con2.Open();
                rdr2 = cmd2.ExecuteReader();
                cbOseba.Items.Clear();
                while (rdr2.Read())
                {
                    string tPriimek = (string)rdr2["Priimek"];
                    string tIme = (string)rdr2["Ime"];
                    int tIndeks = (int)rdr2["Id"];
                    OsebeDict.Add(tIndeks, tPriimek + " " + tIme);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka osebe_v_cb: " + ex.Message);
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
                cbOseba.DataSource = OsebeDict.ToArray();
                cbOseba.DisplayMember = "Value";
                cbOseba.ValueMember = "Key";
            }
        }

        private void Objekti_v_cb()
        {

            q2 = "select * from tbl_objekti order by naziv";
            try
            {
                cmd2 = new SqlCommand(q2, con2);
                con2.Open();
                rdr2 = cmd2.ExecuteReader();
                cbOseba.Items.Clear();
                while (rdr2.Read())
                {
                    string tNaziv = (string)rdr2["naziv"];
                    int tIndeks = (int)rdr2["Id"];
                    ObjektiDict.Add(tIndeks, tNaziv);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka objekti_v_cb: " + ex.Message);
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
                cbObjekt.DataSource = ObjektiDict.ToArray();
                cbObjekt.DisplayMember = "Value";
                cbObjekt.ValueMember = "Key";
            }
        }

        private void Skupine_v_cb()
        {
            
            SkupineDict.Add(0, "Vse telefonske številke");
            SkupineDict.Add(1, "Zaposleni");
            SkupineDict.Add(2, "Telemetrija na objektih");
            SkupineDict.Add(3, "Neomejeni internet");
            SkupineDict.Add(4, "Druge številke");
            SkupineDict.Add(5, "Mobilne številke");
            SkupineDict.Add(6, "Stacionarne številke");
            SkupineDict.Add(7, "Neaktivne številke");
            cbSkupina.DataSource = SkupineDict.ToArray();
            cbSkupina.DisplayMember = "Value";
            cbSkupina.ValueMember = "Key";
            poslano = true;
        }

        private void Nalozi_prvega()
        {
            int idx = OsebeDict.Keys.First();
            Nalozi(idx);
        }
        private void frmTelBaza_Load(object sender, EventArgs e)
        {
            poslano = false;
            Objekti_v_cb(); 
            Osebe_v_cb();
            Skupine_v_cb();
            Prestej();
            Design();
            Grid();
            Displayf(0);
            Gumbi_1();
            izprazni_tb();
            onemogoci_tb();
            Nalozi(prvi_id);
            dgv1.Focus();
        }

        public frmTelBaza()
        {
            InitializeComponent();
        }

        private void Design()
        {
            this.BackColor = frmMain.barva_form_back;
            this.Text = frmMain.nazivPrograma; // Form tekst

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
            btnIzpis.BackColor = frmMain.barva_gumb2_neakt; btnIzpis.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnRacun.BackColor = frmMain.barva_gumb2_neakt; btnRacun.ForeColor = frmMain.barva_gumb2_pis_akt;
            //btnBrisi.Width = frmMain.gumb2_sirina; btnBrisi.Height = frmMain.gumb2_visina;
            //btnDodaj.Width = frmMain.gumb2_sirina; btnDodaj.Height = frmMain.gumb2_visina;
            //btnNazaj.Width = frmMain.gumb2_sirina; btnNazaj.Height = frmMain.gumb2_visina;
            //btnPreklici.Width = frmMain.gumb2_sirina; btnPreklici.Height = frmMain.gumb2_visina;
            //btnShrani.Width = frmMain.gumb2_sirina; btnShrani.Height = frmMain.gumb2_visina;
            //btnSpremeni.Width = frmMain.gumb2_sirina; btnSpremeni.Height = frmMain.gumb2_visina;
            tbStevilka.BackColor = frmMain.bela;
            tbMpo.BackColor = frmMain.bela;
            tbOpis.BackColor = frmMain.bela;
            tbOpombe.BackColor = frmMain.bela;
            tbIskanje.BackColor = frmMain.bela;
            cbObjekt.BackColor = frmMain.bela;
            cbOseba.BackColor = frmMain.bela;
            cbSkupina.BackColor = frmMain.bela;
        }

        private void Gumbi_2() // dodajanje, urejanje
        {
            btnShrani.Enabled = true; btnShrani.BackColor = frmMain.barva_gumb2_neakt;
            btnPreklici.Enabled = true; btnPreklici.BackColor = frmMain.barva_gumb2_neakt;
            btnDodaj.Enabled = false; btnDodaj.BackColor = frmMain.barva_gumb2_disabled;
            btnBrisi.Enabled = false; btnBrisi.BackColor = frmMain.barva_gumb2_disabled;
            btnIzpis.Enabled = false; btnIzpis.BackColor = frmMain.barva_gumb2_disabled;
            btnRacun.Enabled = false; btnRacun.BackColor = frmMain.barva_gumb2_disabled;
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
            btnIzpis.Enabled = true; btnIzpis.BackColor = frmMain.barva_gumb2_neakt;
            btnRacun.Enabled = true; btnRacun.BackColor = frmMain.barva_gumb2_neakt;
        }

        private void Izprazni_dgv()
        {
            dgv1.Rows.Clear();
            dgv1.Refresh();
        }

        private void onemogoci_tb()
        {

            cbOseba.DropDownStyle = ComboBoxStyle.DropDownList;
            cbObjekt.DropDownStyle = ComboBoxStyle.DropDownList;
            cbObjekt.Enabled = false;
            cbOseba.Enabled = false;
            cbSkupina.DropDownStyle = ComboBoxStyle.DropDown;
            tbStevilka.Enabled = false;
            tbOpis.Enabled = false;
            tbOpombe.Enabled = false;
            tbMpo.Enabled = false;
            chbAktivna.Enabled = false;
            chbImenik.Enabled = false;
            p1.Enabled = false;
            p2.Enabled = false;
            tbIskanje.Enabled = true;
            cbSkupina.Enabled = true;
        }

        public int Sm_id(string sm_koda)  // najdi id in opis stroškovnega mesta
        {
            //sm_koda = "";
            int tsm_id = -99;

            q3 = "select * from tbl_sm where koda_sm=@idx";
            try
            {
                cmd3 = new SqlCommand(q3, con3);
                cmd3.Parameters.AddWithValue("@idx", sm_koda);
                con3.Open();
                rdr3 = cmd3.ExecuteReader();
                while (rdr3.Read())
                {
                    tsm_id = (Int32)rdr3["id"];
                    tsm_opis = (string)rdr3["opis_sm"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader (Najdi SM id): " + ex.Message);
            }
            finally
            {
                if (rdr3 != null)
                {
                    rdr3.Close();
                }
                if (con3 != null)
                {
                    con3.Close();
                }
            }
            return tsm_id;
        }

        public String Najdi_sm(int id) // najdi kodo in opis stroškovnega mesta
        {
            sm_koda = "";
            sm_opis = "Neznano stroškovno mesto.";
            q3 = "select * from tbl_sm where id=@idx";
            try
            {
                cmd3 = new SqlCommand(q3, con3);
                cmd3.Parameters.AddWithValue("@idx", id);
                con3.Open();
                rdr3 = cmd3.ExecuteReader();
                while (rdr3.Read())
                {
                    sm_koda = (string)rdr3["koda_sm"];
                    sm_opis = (string)rdr3["opis_sm"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader (Najdi SM): " + ex.Message);
            }
            finally
            {
                if (rdr3 != null)
                {
                    rdr3.Close();
                }
                if (con3 != null)
                {
                    con3.Close();
                }
            }
            return tsm;
        }

        private void Preklici()
        {
            if (dodajanje)
            {
                izprazni_tb();
            }
            spreminjanje = false;
            dodajanje = false;
            onemogoci_tb();
            Gumbi_1();
            dgv1.Enabled = true;
        }
            
        
        private void btnNazaj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Shrani()
        {
            int taktivna = 0;
            int timenik = 0;
            int toseba = -99;
            int tobjekt = -99;
            string q;
            
            if (tbStevilka.Text != "")
            {
                // določi vrednosti
                
                int tmpsm_id = Sm_id(tbSm.Text);

                int trb_mobilna=0;
                int trb_oseba = 0;

                int tskupina = 0;
                string tstevilka = tbStevilka.Text;
                if (rbMobilna.Checked)
                    trb_mobilna = 1;
                else
                    trb_mobilna = 2;
                string tmpo = tbMpo.Text;
                if (chbAktivna.Checked)
                    taktivna = 1;
                string topis = tbOpis.Text;
                if (rbOseba.Checked)
                    trb_oseba = 1;
                else if (rbTelemetrija.Checked)
                    trb_oseba = 2;
                else if (rbInternet.Checked)
                    trb_oseba = 3;
                else if (rbDrugo.Checked)
                    trb_oseba = 4;

                if (cbOseba.Text != "")
                {
                    toseba = ((KeyValuePair<int, string>)cbOseba.SelectedItem).Key;
                }
                if (cbObjekt.Text != "")
                {
                    tobjekt = ((KeyValuePair<int, string>)cbObjekt.SelectedItem).Key;
                }
                string topomba = tbOpombe.Text;
                
                if (chbImenik.Checked)
                    timenik = 1;
                else
                    timenik = 0;


                try
                {
                    if (dodajanje)
                    {
                        // dodaj
                        q = "insert into tbl_Telefonske (skupina,rb_mobilna,stevilka,mpo,aktivna,opis,rb_oseba,oseba,objekt,opomba,imenik,sm) " +
                            "values(@skupina,@rb_mobilna,@stevilka,@mpo,@aktivna,@opis,@rb_oseba,@oseba,@objekt,@opomba,@imenik,@sm)";
                        cmd = new SqlCommand(q, con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@skupina", tskupina);
                        cmd.Parameters.AddWithValue("@rb_mobilna", trb_mobilna);
                        cmd.Parameters.AddWithValue("@stevilka", tstevilka);
                        cmd.Parameters.AddWithValue("@mpo", tmpo);
                        cmd.Parameters.AddWithValue("@aktivna", taktivna);
                        cmd.Parameters.AddWithValue("@opis", topis);
                        cmd.Parameters.AddWithValue("@rb_oseba", trb_oseba);
                        cmd.Parameters.AddWithValue("@oseba", toseba);
                        cmd.Parameters.AddWithValue("@objekt", tobjekt);
                        cmd.Parameters.AddWithValue("@opomba", topomba);
                        cmd.Parameters.AddWithValue("@imenik", timenik);
                        cmd.Parameters.AddWithValue("@sm", tmpsm_id);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {

                        // spremeni
                        q = "update tbl_Telefonske set skupina=@skupina,rb_mobilna=@rb_mobilna,stevilka = @stevilka,mpo = @mpo,aktivna = @aktivna,opis = @opis," +
                            "rb_oseba = @rb_oseba,oseba = @oseba,objekt = @objekt,opomba = @opomba,imenik = @imenik, sm=@sm where id=@tid";
                        cmd = new SqlCommand(q, con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@tid", tid);
                        cmd.Parameters.AddWithValue("@skupina", tskupina);
                        cmd.Parameters.AddWithValue("@rb_mobilna", trb_mobilna);
                        cmd.Parameters.AddWithValue("@stevilka", tstevilka);
                        cmd.Parameters.AddWithValue("@mpo", tmpo);
                        cmd.Parameters.AddWithValue("@aktivna", taktivna);
                        cmd.Parameters.AddWithValue("@opis", topis);
                        cmd.Parameters.AddWithValue("@rb_oseba", trb_oseba);
                        cmd.Parameters.AddWithValue("@oseba", toseba);
                        cmd.Parameters.AddWithValue("@objekt", tobjekt);
                        cmd.Parameters.AddWithValue("@opomba", topomba);
                        cmd.Parameters.AddWithValue("@imenik", timenik);
                        cmd.Parameters.AddWithValue("@sm", tmpsm_id);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka pri shranjevanju zapisa: " + ex.Message);
                }
                finally
                {
                    if (con != null)
                    {
                        con.Close();
                    }
                }
                int zacasni_tid = tid;
                Displayf(izbrana_skupina);
                dgv1.Enabled = true;
                //tid = zacasni_tid;
                Nalozi(prvi_id);

                Zacetek();
            }
            else
            {
                MessageBox.Show("Napaka: Vnesti moraš vsaj telefonsko številko!");
                tbStevilka.Focus();
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

        private void dgv1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            index = dgv1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tid = Convert.ToInt32(index);
            trenutni = tid;
            izprazni_tb();
            Nalozi(tid);
        }

        private void rbOseba_CheckedChanged(object sender, EventArgs e)
        {
            if (dodajanje || spreminjanje)
            { 
                if (rbOseba.Checked == true)
                {
                    cbOseba.DropDownStyle = ComboBoxStyle.DropDown;
                    cbOseba.Enabled = true;
                    cbObjekt.DropDownStyle = ComboBoxStyle.DropDownList;
                    cbObjekt.Enabled = false;
                    this.cbObjekt.SelectedValue = 0;
                }
                else
                {
                }
            }
        }

        private void rbInternet_CheckedChanged(object sender, EventArgs e)
        {
            if (dodajanje || spreminjanje)
            {
                if (rbInternet.Checked == true)
                {
                    cbOseba.DropDownStyle = ComboBoxStyle.DropDown;
                    cbOseba.Enabled = true;
                    cbObjekt.DropDownStyle = ComboBoxStyle.DropDown;
                    cbObjekt.Enabled = true;
                }
            }
        }

        private void cbOseba_SelectedIndexChanged(object sender, EventArgs e)
        {
            // naredi avtomatski opis
            if (tbOpis.Text == "")
            {
                if (rbMobilna.Checked)
                    tbOpis.Text = cbOseba.Text + ", mobilna številka";
                if (rbStacionarna.Checked)
                    tbOpis.Text = cbOseba.Text + ", stacionarna številka";

            }
        }

        private void cbObjekt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbOpis.Text == "")
                    tbOpis.Text = cbObjekt.Text + ", telemetrija";
        }

        private void btnSpremeni_Click(object sender, EventArgs e)
        {
            Spremeni();
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            // najdi opis in kodo sm 
            tsm_opis = "Neznano stroškovno mesto.";
            int tmpid = Sm_id(tbSm.Text);
            lsm.Text = tsm_opis;
        }

        private void rbDrugo_CheckedChanged(object sender, EventArgs e)
        {
            if (dodajanje || spreminjanje)
            {
                if (rbDrugo.Checked == true)
                {
                    cbOseba.DropDownStyle = ComboBoxStyle.DropDown;
                    cbOseba.Enabled = true;
                    cbObjekt.DropDownStyle = ComboBoxStyle.DropDown;
                    cbObjekt.Enabled = true;
                }
            }
        }

        private void chbImenik_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbTelemetrija_CheckedChanged(object sender, EventArgs e)
        {
            if (dodajanje || spreminjanje)
            {
                if (rbTelemetrija.Checked == true)
                {
                    cbObjekt.DropDownStyle = ComboBoxStyle.DropDown;
                    cbObjekt.Enabled = true;
                    cbOseba.DropDownStyle = ComboBoxStyle.DropDownList;
                    cbOseba.Enabled = false;
                    this.cbOseba.SelectedValue = 0;
                }
                else
                {
                }
            }
        }

        private void Brisi()
        {
            
                DialogResult result = MessageBox.Show("Izbrišem zapis " + tbOpis.Text + "?", "Potrdi brisanje", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string q = "delete from tbl_Telefonske where id = @tid";
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
                            Displayf(izbrana_skupina);
                        }
                    }

                    Zacetek();
                }
                else if (result == DialogResult.No)
                {
                    Zacetek();
                }

            }

            private void btnBrisi_Click(object sender, EventArgs e)
        {
            Brisi();
        }

        private void cbSkupina_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* prefitriraj in prikaži
             0 - vse številke
             1 - osebe
             2 - telemetrija
             3 - neomejeni internet
             4 - druge številke
             5 - mobilne številke
             6 - stacionarne številke
             7 - neaktivne številke
            */
            izbrana_skupina = ((KeyValuePair<int, string>)cbSkupina.SelectedItem).Key;
            Displayf(izbrana_skupina);
            dgv1.Focus();
        }

        private void cbSkupina_MouseClick(object sender, MouseEventArgs e)
        {
            cbSkupina.DroppedDown = true;
        }

        private void cbOseba_MouseClick(object sender, MouseEventArgs e)
        {
            cbOseba.DroppedDown = true;
        }

        private void cbObjekt_MouseClick(object sender, MouseEventArgs e)
        {
            cbObjekt.DroppedDown = true;
        }

        private void Preveri_rb()
        {
            if (rbTelemetrija.Checked == true)
            {
                cbObjekt.DropDownStyle = ComboBoxStyle.DropDown;
                cbObjekt.Enabled = true;
                cbOseba.DropDownStyle = ComboBoxStyle.DropDownList;
                cbOseba.Enabled = false;
                this.cbOseba.SelectedValue = 0;
            }
            if (rbDrugo.Checked == true)
            {
                cbOseba.DropDownStyle = ComboBoxStyle.DropDown;
                cbOseba.Enabled = true;
                cbObjekt.DropDownStyle = ComboBoxStyle.DropDown;
                cbObjekt.Enabled = true;
            }
            if (rbInternet.Checked == true)
            {
                cbOseba.DropDownStyle = ComboBoxStyle.DropDown;
                cbOseba.Enabled = true;
                cbObjekt.DropDownStyle = ComboBoxStyle.DropDown;
                cbObjekt.Enabled = true;
            }
            if (rbOseba.Checked == true)
            {
                cbOseba.DropDownStyle = ComboBoxStyle.DropDown;
                cbOseba.Enabled = true;
                cbObjekt.DropDownStyle = ComboBoxStyle.DropDownList;
                cbObjekt.Enabled = false;
                this.cbObjekt.SelectedValue = 0;
            }
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Dodaj();
        }

        private void omogoci_tb()
        {
            cbSkupina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOseba.DropDownStyle = ComboBoxStyle.DropDown;
            cbObjekt.DropDownStyle = ComboBoxStyle.DropDown;
            tbStevilka.Enabled = true;
            tbOpis.Enabled = true;
            tbOpombe.Enabled = true;
            tbMpo.Enabled = true;
            cbObjekt.Enabled = true;
            cbOseba.Enabled = true;
            chbAktivna.Enabled = true;
            chbImenik.Enabled = true;
            p1.Enabled = true;
            p2.Enabled = true;
            tbIskanje.Enabled = false;
            cbSkupina.Enabled = false;
            dgv1.Enabled = true;
        }

        private void izprazni_tb()
        {
            tbStevilka.Text = "";
            tbOpis.Text = "";
            tbOpombe.Text = "";
            tbMpo.Text = "";
            chbAktivna.Checked = false;
            chbImenik.Checked = false;
            rbDrugo.Checked = false;
            rbInternet.Checked = false;
            rbMobilna.Checked = false;
            rbOseba.Checked = false;
            rbStacionarna.Checked = false;
            rbTelemetrija.Checked = false;
            tbIskanje.Text = "";
            //cbSkupina.Text = "";
            this.cbOseba.SelectedValue = 0;
            this.cbObjekt.SelectedValue = 0;
        }

        private void Grid()
        {
            //dgv1.RowHeadersVisible = false;
            //dgv1.ColumnCount = 4;
            //dgv1.Columns[0].Width = 20;
            //dgv1.Columns[1].Width = 120;
            //dgv1.Columns[2].Width = 308;
            //dgv1.Columns[3].Width = 140;
            //dgv1.Columns[0].Name = "Id";
            //dgv1.Columns[1].Name = "Stevilka";
            //dgv1.Columns[2].Name = "Opis";
            //dgv1.Columns[3].Name = "Imenik";
            //dgv1.Columns["Id"].Visible = false;
            ////dgv1.Columns["Objekt"].Visible = false;
            //this.dgv1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //this.dgv1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //this.dgv1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //dgv1.Focus();
        }

        //private void Display() // prikaži vse številke
        //{
        //    string tepriimek, teime, teobjekt;
        //    prvic = true;
        //    Izprazni_dgv();
        //    string q = "SELECT Tbl_Telefonske.Id, Tbl_Telefonske.rb_mobilna AS Expr13, Tbl_Telefonske.Stevilka AS Expr14, Tbl_Telefonske.Mpo AS Expr15, " +
        //        "Tbl_Telefonske.Aktivna AS Expr16, Tbl_Telefonske.Opis AS Expr17, Tbl_Telefonske.rb_oseba AS Expr18,  Tbl_Telefonske.Oseba " +
        //        "AS Expr19, Tbl_Telefonske.Objekt AS Expr20, Tbl_Telefonske.Opomba AS Expr21, Tbl_Telefonske.Imenik AS Expr22, Tbl_Telefonske.Objekt " +
        //        "AS Expr1, Tbl_Telefonske.rb_mobilna AS Expr2,  Tbl_Telefonske.Stevilka AS Expr3, Tbl_Telefonske.Mpo AS Expr4, Tbl_Telefonske.Aktivna " +
        //        "AS Expr5, Tbl_Telefonske.Opis AS Expr6, Tbl_Telefonske.rb_oseba AS Expr7, Tbl_Telefonske.Oseba AS Expr8,  Tbl_Telefonske.Opomba " +
        //        "AS Expr9, Tbl_Telefonske.Imenik AS Expr10, Tbl_Objekti.Naziv AS eobjekt, Tbl_sodelavci.Ime AS eime, Tbl_sodelavci.Priimek " +
        //        "AS epriimek FROM Tbl_Telefonske " +
        //        "LEFT OUTER JOIN Tbl_Objekti ON Tbl_Telefonske.Objekt = Tbl_Objekti.Id " +
        //        "LEFT OUTER JOIN Tbl_sodelavci ON Tbl_Telefonske.Oseba = Tbl_sodelavci.Id";


        //    try
        //    {
        //        cmd = new SqlCommand(q, con);
        //        con.Open();
        //        rdr = cmd.ExecuteReader();
        //        while (rdr.Read())
        //        {
        //            tid = (int)rdr["Id"];
        //            if (prvic)
        //                prvi_id = tid;
        //            prvic = false;
        //            string tstevilka = (string)rdr["expr14"]; // Opis

        //            tepriimek = "";
        //            teime = "";
        //            teobjekt = "";
                    
        //            if (rdr["epriimek"] != DBNull.Value)
        //            {
        //                tepriimek = (string)rdr["epriimek"];
        //            }
        //            if (rdr["eime"] != DBNull.Value)
        //            {
        //                teime = (string)rdr["eime"];
        //            }
        //            string toseba = tepriimek+" " + teime;

        //            if (rdr["eobjekt"] != DBNull.Value)
        //            {
        //                teobjekt = (string)rdr["eobjekt"];
        //            }
        //            string tobjekt = teobjekt;
                    
        //            string topis = (string)rdr["expr17"];
        //            string strid = Convert.ToString(tid);

        //            int timenik = (Int32)rdr["expr10"];
        //            string strimenik = Convert.ToString(timenik);

        //            DataGridViewTextBoxCell Id = new DataGridViewTextBoxCell();
        //            DataGridViewTextBoxCell Stevilka = new DataGridViewTextBoxCell();
        //            DataGridViewTextBoxCell Opis = new DataGridViewTextBoxCell();
        //            DataGridViewCheckBoxCell Imenik = new DataGridViewCheckBoxCell();

        //            Id.Value = tid;
        //            Stevilka.Value = tstevilka;
        //            Opis.Value = topis;
        //            Imenik.Value = timenik;

        //            DataGridViewColumn kolid = dgv1.Columns[0];
        //            kolid.Width = 1;
        //            DataGridViewColumn kolstevilka = dgv1.Columns[1];
        //            kolstevilka.Width = 120;
        //            DataGridViewColumn kolopis = dgv1.Columns[2];
        //            kolopis.Width = 380;
        //            DataGridViewColumn kolimenik = dgv1.Columns[3];
        //            kolimenik.Width = 140;

        //            //kolstoritev.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
        //            //kolem.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //            //kolddv.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //            //kolskupina.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

        //            DataGridViewRow row = new DataGridViewRow();

        //            row.Cells.Add(Id);
        //            row.Cells.Add(Stevilka);
        //            row.Cells.Add(Opis);
        //            row.Cells.Add(Imenik);

        //            dgv1.Rows.Add(row);  // dodaj vrstico
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Napaka: " + ex.Message);
        //    }
        //    finally
        //    {
        //        if (rdr != null)
        //        {
        //            rdr.Close();
        //        }
        //        if (con != null)
        //        {
        //            con.Close();
        //        }
        //    }
        //}

        private void Displayf(int Filter )  // prikaži filtriran dgv1
        {
            /* prefitriraj in prikaži
             0 - vse številke
             1 - osebe
             2 - telemetrija
             3 - neomejeni internet
             4 - druge številke
             5 - mobilne številke
             6 - stacionarne številke
             7 - neaktivne številke
            */
            string tepriimek, teime, teobjekt;

            if (poslano)  // če si poslal iz combobox-a
            {
                switch (Filter)
                {
                    case 0: // Vse aktivne
                        filter_1 = "WHERE "+ "(Tbl_Telefonske.Aktivna = 1)";
                        filter_2 = "";
                        break;
                    case 1:  // samo osebe
                        filter_1 = "WHERE " + "(Tbl_Telefonske.Aktivna = 1) ";
                        filter_2 = "AND " + "(Tbl_Telefonske.rb_oseba = 1)";
                        break;
                    case 2:  // telemetrija
                        filter_1 = "WHERE " + "(Tbl_Telefonske.Aktivna = 1) ";
                        filter_2 = "AND " + "(Tbl_Telefonske.rb_oseba = 2)";
                        break;
                    case 3:  // neomejeni internet
                        filter_1 = "WHERE " + "(Tbl_Telefonske.Aktivna = 1) ";
                        filter_2 = "AND " + "(Tbl_Telefonske.rb_oseba = 3)";
                        break;
                    case 4:  // druge številke
                        filter_1 = "WHERE " + "(Tbl_Telefonske.Aktivna = 1) ";
                        filter_2 = "AND " + "(Tbl_Telefonske.rb_oseba = 4)";
                        break;
                    case 5:  // mobilne številke
                        filter_1 = "WHERE " + "(Tbl_Telefonske.Aktivna = 1) ";
                        filter_2 = "AND " + "(Tbl_Telefonske.rb_mobilna = 1)";
                        break;
                    case 6:  // stacionarne številke
                        filter_1 = "WHERE " + "(Tbl_Telefonske.Aktivna = 1) ";
                        filter_2 = "AND " + "(Tbl_Telefonske.rb_mobilna = 2)";
                        break;
                    case 7:  // neaktivne
                        filter_1 = "WHERE " + "(Tbl_Telefonske.Aktivna = 0)";
                        filter_2 = "";
                        break;
                }

                //"WHERE (Tbl_Telefonske.rb_oseba = 3) AND "+filter_2+
                prvic = true;
                Izprazni_dgv();
                string q = "SELECT Tbl_Telefonske.Id, Tbl_Telefonske.rb_mobilna AS Expr13, Tbl_Telefonske.Stevilka AS Expr14, Tbl_Telefonske.Mpo AS Expr15, " +
                    "Tbl_Telefonske.Aktivna AS Expr16, Tbl_Telefonske.Opis AS Expr17, Tbl_Telefonske.rb_oseba AS Expr18,  Tbl_Telefonske.Oseba " +
                    "AS Expr19, Tbl_Telefonske.Objekt AS Expr20, Tbl_Telefonske.Opomba AS Expr21, Tbl_Telefonske.Imenik AS Expr22, Tbl_Telefonske.Objekt " +
                    "AS Expr1, Tbl_Telefonske.rb_mobilna AS Expr2,  Tbl_Telefonske.Stevilka AS Expr3, Tbl_Telefonske.Mpo AS Expr4, Tbl_Telefonske.Aktivna " +
                    "AS Expr5, Tbl_Telefonske.Opis AS Expr6, Tbl_Telefonske.rb_oseba AS Expr7, Tbl_Telefonske.Oseba AS Expr8,  Tbl_Telefonske.Opomba " +
                    "AS Expr9, Tbl_Telefonske.Imenik AS Expr10, Tbl_Objekti.Naziv AS eobjekt, Tbl_sodelavci.Ime AS eime, Tbl_sodelavci.Priimek " +
                    "AS epriimek FROM Tbl_Telefonske " +
                    "LEFT OUTER JOIN Tbl_Objekti ON Tbl_Telefonske.Objekt = Tbl_Objekti.Id " +
                    "LEFT OUTER JOIN Tbl_sodelavci ON Tbl_Telefonske.Oseba = Tbl_sodelavci.Id " + filter_1+filter_2+" ORDER BY Expr17";

                try
                {
                    cmd = new SqlCommand(q, con);
                    con.Open();
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        tid = (int)rdr["Id"];
                        if (prvic)
                            prvi_id = tid;
                        prvic = false;
                        string tstevilka = (string)rdr["expr14"]; // Opis

                        tepriimek = "";
                        teime = "";
                        teobjekt = "";

                        if (rdr["epriimek"] != DBNull.Value)
                        {
                            tepriimek = (string)rdr["epriimek"];
                        }
                        if (rdr["eime"] != DBNull.Value)
                        {
                            teime = (string)rdr["eime"];
                        }
                        string toseba = tepriimek + " " + teime;

                        if (rdr["eobjekt"] != DBNull.Value)
                        {
                            teobjekt = (string)rdr["eobjekt"];
                        }
                        string tobjekt = teobjekt;

                        string topis = (string)rdr["expr17"];
                        string strid = Convert.ToString(tid);

                        bool timenik = (bool)rdr["expr10"];
                        string strimenik = Convert.ToString(timenik);

                        DataGridViewTextBoxCell Id = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell Stevilka = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell Opis = new DataGridViewTextBoxCell();
                        DataGridViewCheckBoxCell Imenik = new DataGridViewCheckBoxCell();

                        Id.Value = tid;
                        Stevilka.Value = tstevilka;
                        Opis.Value = topis;
                        Imenik.Value = timenik;

                        DataGridViewColumn kolid = dgv1.Columns[0];
                        kolid.Width = 1;
                        DataGridViewColumn kolstevilka = dgv1.Columns[1];
                        kolstevilka.Width = 120;
                        DataGridViewColumn kolopis = dgv1.Columns[2];
                        kolopis.Width = 355;
                        DataGridViewColumn kolimenik = dgv1.Columns[3];
                        kolimenik.Width = 80;

                        DataGridViewRow row = new DataGridViewRow();

                        row.Cells.Add(Id);
                        row.Cells.Add(Stevilka);
                        row.Cells.Add(Opis);
                        row.Cells.Add(Imenik);

                        dgv1.Rows.Add(row);  // dodaj vrstico

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
            }
        }

        void Nalozi(int idx) // naloži podatke v polja
        {
            q2 = "select * from tbl_Telefonske where id=@idx";
            try
            { 
                cmd2 = new SqlCommand(q2, con2);
                cmd2.Parameters.AddWithValue("@idx", idx);
                con2.Open();
                rdr2 = cmd2.ExecuteReader();
                while (rdr2.Read())
                {
                    string tstevilka = (string)rdr2["stevilka"]; tbStevilka.Text = tstevilka;
                    string topis = (string)rdr2["opis"]; tbOpis.Text = topis;
                    string topomba = (string)rdr2["opomba"]; tbOpombe.Text = topomba;
                    tbSm.Text = Najdi_sm((Int32)rdr2["sm"]); // poišči sm
                    lsm.Text = sm_opis;
                    tbSm.Text = sm_koda;
                    int trb_mobilna = (int)rdr2["rb_mobilna"];
                    if (trb_mobilna == 1)
                        rbMobilna.Checked = true;
                    else if (trb_mobilna == 2)
                        rbStacionarna.Checked = true;
                    string tmpo = (string)rdr2["mpo"]; tbMpo.Text = tmpo;
                    
                    bool taktivna = (bool)rdr2["aktivna"];
                    if (taktivna)
                        chbAktivna.Checked = true;
                    else
                        chbAktivna.Checked = false;
                    bool timenik = (bool)rdr2["imenik"];
                    if (timenik)
                        chbImenik.Checked = true;
                    else
                        chbImenik.Checked = false;

                    int trb_oseba = (int)rdr2["rb_oseba"];
                    if (trb_oseba == 1)
                        rbOseba.Checked = true;
                    else if (trb_oseba == 2)
                        rbTelemetrija.Checked = true;
                    else if (trb_oseba == 3)
                        rbInternet.Checked = true;
                    else if (trb_oseba == 4)
                        rbDrugo.Checked = true;

                    // oseba
                    int cb_index = (int)rdr2["oseba"];
                    if (OsebeDict.Keys.Contains(cb_index))
                        this.cbOseba.SelectedValue = cb_index;
                    else
                        cbOseba.Text = "Neznana oseba";

                    // objekt
                    int cb_index_objekt = (int)rdr2["objekt"];
                    if (ObjektiDict.Keys.Contains(cb_index_objekt))
                        this.cbObjekt.SelectedValue = cb_index_objekt;
                    else
                        cbObjekt.Text = "Neznan objekt";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader (Naloži): " + ex.Message);
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

        private void Zacetek()
        {
            dodajanje = false;
            spreminjanje = false;
            osnovno = true;
            izprazni_tb();
            onemogoci_tb();
            btnShrani.Enabled = false;
            btnShrani.BackColor = frmMain.barva_gumb2_disabled;
            btnPreklici.Enabled = false;
            btnPreklici.BackColor = frmMain.barva_gumb2_disabled;
            btnDodaj.Enabled = true;
            btnDodaj.BackColor = frmMain.barva_gumb2_neakt;
            btnBrisi.Enabled = true;
            btnBrisi.BackColor = frmMain.barva_gumb2_neakt;
            btnSpremeni.Enabled = true;
            btnSpremeni.BackColor = frmMain.barva_gumb2_neakt;
            btnNazaj.Enabled = true;
            btnNazaj.BackColor = frmMain.barva_gumb2_neakt;
            tbOpis.Text = "";
            dgv1.Focus();
        }

        private void Dodaj()
        {
            dodajanje = true;
            spreminjanje = false;
            omogoci_tb();
            izprazni_tb();
            Gumbi_2();
            chbAktivna.Checked = true;
            rbOseba.Checked = true;
            rbMobilna.Checked = true;
            cbObjekt.DropDownStyle = ComboBoxStyle.DropDownList;
            cbObjekt.Enabled = false;
            chbImenik.Checked = true;
            dgv1.Enabled = false;
            tbOpis.Text = "";
            tbStevilka.Focus();
        }

        private void Spremeni()
        {
            dodajanje = false;
            spreminjanje = true;
            omogoci_tb();
            Gumbi_2();
            dgv1.Enabled = false;
            Preveri_rb();
            cbObjekt.DropDownStyle = ComboBoxStyle.DropDownList;
            cbObjekt.Enabled = false;
            tbStevilka.Focus();
            
        }
        
        ////////////////////////////////////////////////////////////////////////
        ///////////    to je samo za prenos iz baze txt    /////////////////////
        ////////////////////////////////////////////////////////////////////////
        
        //private void IzprazniBazo_pt()  // izprazni tabelo tbl_pt
        //{
        //    string query = "delete from tbl_pt";
        //    cmd = new SqlCommand(query, con);
        //    con.Open();
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //}
        //private void Izprazni_pt() // izprazni variable za tabelo tbl_na
        //{
        //    tel_1 = ""; tel_2 = "";
        //}

        //private void Obdelaj_pt()
        //{
        //    //if (npt == 0)
        //    //{
        //    // začni prenos
        //    fnamept = "c:\\tel.txt";
        //    stevec = 0;
        //    IzprazniBazo_pt();
        //    try
        //    {
        //        System.IO.StreamReader objReader;
        //        objReader = new System.IO.StreamReader(fnamept, ASCIIEncoding.UTF8);
        //        do
        //        {
        //            vrstica = "";
        //            Izprazni_pt();
        //            vrstica = vrstica + objReader.ReadLine() + "\r\n";

        //            // razdeli vrstico ločeno s ;
        //            string[] polje = vrstica.Split(';');
        //            tel_1 = polje[0];
        //            tel_2 = polje[1];
        //            try
        //            {
        //                if (stevec > 0)
        //                {
        //                    // napiši prebrano v tabelo pt
        //                    string query = "insert into tbl_telefonske (skupina,rb_mobilna,stevilka,mpo,aktivna,opis,rb_oseba,oseba,objekt,opomba,imenik) values(0,1,@tel_1,'',1,@tel_2,1,0,0,'',0)";
        //                    cmd = new SqlCommand(query, con);
        //                    con.Open();
        //                    cmd.Parameters.AddWithValue("@tel_1", tel_1);
        //                    cmd.Parameters.AddWithValue("@tel_2", tel_2);
        //                    cmd.ExecuteNonQuery();
        //                    con.Close();
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Napaka: " + ex.Message);
        //            }
        //            stevec = ++stevec;
        //            vrstica = "";
        //        } while (objReader.Peek() != -1);
        //        objReader.Close();
        //        stevec--;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Napaka: " + ex.Message);
        //    }
        //    finally
        //    {
        //    }
        //}

    }
}
