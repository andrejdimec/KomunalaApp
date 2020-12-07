﻿using System;
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
        int tid,prvi_id;
        bool dodajanje, osnovno, spreminjanje,prvic;
        Dictionary<int, string> OsebeDict = new Dictionary<int, string>();
        Dictionary<int, string> ObjektiDict = new Dictionary<int, string>();


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
            Dictionary<int, string> SkupineDict = new Dictionary<int, string>();
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
        }

        private void Nalozi_prvega()
        {
            int idx = OsebeDict.Keys.First();
            Nalozi(idx);
        }
        private void frmTelBaza_Load(object sender, EventArgs e)
        {
            Objekti_v_cb(); 
            Osebe_v_cb();
            Skupine_v_cb();
            
            Design();
            Grid();
            Display();
            Gumbi_1();
            izprazni_tb();
            onemogoci_tb();
            Nalozi_prvega();
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
            btnBrisi.Width = frmMain.gumb2_sirina; btnBrisi.Height = frmMain.gumb2_visina;
            btnDodaj.Width = frmMain.gumb2_sirina; btnDodaj.Height = frmMain.gumb2_visina;
            btnNazaj.Width = frmMain.gumb2_sirina; btnNazaj.Height = frmMain.gumb2_visina;
            btnPreklici.Width = frmMain.gumb2_sirina; btnPreklici.Height = frmMain.gumb2_visina;
            btnShrani.Width = frmMain.gumb2_sirina; btnShrani.Height = frmMain.gumb2_visina;
            btnSpremeni.Width = frmMain.gumb2_sirina; btnSpremeni.Height = frmMain.gumb2_visina;
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
                        q = "insert into tbl_Telefonske (skupina,rb_mobilna,stevilka,mpo,aktivna,opis,rb_oseba,oseba,objekt,opomba,imenik) " +
                            "values(@skupina,@rb_mobilna,@stevilka,@mpo,@aktivna,@opis,@rb_oseba,@oseba,@objekt,@opomba,@imenik)";
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
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {

                        // spremeni
                        q = "update tbl_Sodelavci set emso=@emso, ime=@ime, priimek=@priimek ,ulica=@ulica,hs=@hs,posta=@posta,posta_ime=@posta_ime,ds=@ds,tel_privat=@tel_privat,tel_sluzba_1=@tel_sluzba_1,tel_sluzba_2=tel_sluzba_2," +
                            "email_privat=@email_privat,email_sluzba=@email_sluzba,trr=@trr,banka=@banka,izobrazba=@izobrazba,del_mesto=@del_mesto,oddelek=@oddelek,sm=@sm,mpo=@mpo " +
                            "where id=@tid";
                        cmd = new SqlCommand(q, con);
                        con.Open();
                        //cmd.Parameters.AddWithValue("@tid", tid);
                        //cmd.Parameters.AddWithValue("@emso", tbEmso.Text);
                        //cmd.Parameters.AddWithValue("@ime", tbIme.Text);
                        //cmd.Parameters.AddWithValue("@priimek", tbPriimek.Text);
                        //cmd.Parameters.AddWithValue("@ulica", tbUlica.Text);
                        //cmd.Parameters.AddWithValue("@hs", tbHs.Text);
                        //cmd.Parameters.AddWithValue("@posta", tbPosta.Text);
                        //cmd.Parameters.AddWithValue("@posta_ime", tbNazivPoste.Text);
                        //cmd.Parameters.AddWithValue("@ds", tbDs.Text);
                        //cmd.Parameters.AddWithValue("@tel_privat", tbPrivatMob.Text);
                        //cmd.Parameters.AddWithValue("@tel_sluzba_1", tbSluzbeniMob.Text);
                        //cmd.Parameters.AddWithValue("@tel_sluzba_2", tbSluzbeniStac.Text);
                        //cmd.Parameters.AddWithValue("@email_privat", tbPrivatMail.Text);
                        //cmd.Parameters.AddWithValue("@email_sluzba", tbSluzbeniMail.Text);
                        //cmd.Parameters.AddWithValue("@trr", tbTrr.Text);
                        //cmd.Parameters.AddWithValue("@banka", tbBanka.Text);
                        //cmd.Parameters.AddWithValue("@izobrazba", tbIzobrazba.Text);
                        //cmd.Parameters.AddWithValue("@del_mesto", tbDelovnoMesto.Text);
                        //cmd.Parameters.AddWithValue("@oddelek", tbOddelek.Text);
                        //cmd.Parameters.AddWithValue("@sm", tmpsm_id);
                        //cmd.Parameters.AddWithValue("@mpo", tbMpo.Text);
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
            if (rbInternet.Checked == true)
            {
                cbOseba.DropDownStyle = ComboBoxStyle.DropDown;
                cbOseba.Enabled = true;
                cbObjekt.DropDownStyle = ComboBoxStyle.DropDown;
                cbObjekt.Enabled = true;
            }
        }

        private void rbDrugo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDrugo.Checked == true)
            {
                cbOseba.DropDownStyle = ComboBoxStyle.DropDown;
                cbOseba.Enabled = true;
                cbObjekt.DropDownStyle = ComboBoxStyle.DropDown;
                cbObjekt.Enabled = true;
            }
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
            cbSkupina.Text = "";
            this.cbOseba.SelectedValue = 0;
            this.cbObjekt.SelectedValue = 0;
        }

        private void Grid()
        {
            dgv1.RowHeadersVisible = false;
            dgv1.ColumnCount = 5;
            dgv1.Columns[0].Width = 20;
            dgv1.Columns[1].Width = 120;
            dgv1.Columns[2].Width = 308;
            dgv1.Columns[3].Width = 140;
            dgv1.Columns[0].Name = "Id";
            dgv1.Columns[1].Name = "Številka";
            dgv1.Columns[2].Name = "Opis";
            dgv1.Columns[3].Name = "Oseba";
            dgv1.Columns[4].Name = "Objekt";
            dgv1.Columns["Id"].Visible = false;
            dgv1.Columns["Objekt"].Visible = false;
            this.dgv1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgv1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgv1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv1.Focus();
        }

        private void Display()
        {
            string tepriimek, teime, teobjekt;
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
                "LEFT OUTER JOIN Tbl_sodelavci ON Tbl_Telefonske.Oseba = Tbl_sodelavci.Id";

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
                    string toseba = tepriimek+" " + teime;

                    if (rdr["eobjekt"] != DBNull.Value)
                    {
                        teobjekt = (string)rdr["eobjekt"];
                    }
                    string tobjekt = teobjekt;
                    
                    string topis = (string)rdr["expr17"];
                    string strid = Convert.ToString(tid);
                    string[] row1 = new string[] {strid, tstevilka,topis,toseba,tobjekt };
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
            dgv1.Focus();
        }

        private void Dodaj()
        {
            dodajanje = true;
            omogoci_tb();
            izprazni_tb();
            Gumbi_2();
            chbAktivna.Checked = true;
            rbOseba.Checked = true;
            rbMobilna.Checked = true;
            cbObjekt.DropDownStyle = ComboBoxStyle.DropDownList;
            cbObjekt.Enabled = false;
            chbImenik.Checked = true;
            tbStevilka.Focus();
        }
    }
}