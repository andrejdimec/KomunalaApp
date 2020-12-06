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
        int tid;
        bool dodajanje, osnovno, spreminjanje;


        private void Osebe_v_cb()
        {
            Dictionary<int, string> OsebeDict = new Dictionary<int, string>();

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
                    OsebeDict.Add(tIndeks, tPriimek+" "+tIme);

                    //cbOseba.Items.Add(stor_zac);
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
            Dictionary<int, string> ObjektiDict = new Dictionary<int, string>();

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

                    //cbOseba.Items.Add(stor_zac);
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

        private void frmTelBaza_Load(object sender, EventArgs e)
        {
            Objekti_v_cb(); 
            Osebe_v_cb();
            Skupine_v_cb();
            Design();
            izprazni_tb();
            onemogoci_tb();
            
            Grid();
            Display();
            Gumbi_1();

            //Zacetek();
            dgv1.Focus();
        }

        public frmTelBaza()
        {
            InitializeComponent();
        }

        private void Design()
        {
            this.BackColor = frmMain.barva_form_back;

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

            //tbIme.BackColor = frmMain.bela;
            //tbPriimek.BackColor = frmMain.bela;
            //tbIme2.BackColor = frmMain.bela;
            //tbPriimek2.BackColor = frmMain.bela;
            //tbDelovnoMesto.BackColor = frmMain.bela;
            //tbSm.BackColor = frmMain.bela;
            //tbPosta.BackColor = frmMain.bela;
            //tbNazivPoste.BackColor = frmMain.bela;
            //tbHs.BackColor = frmMain.bela;
            //tbUlica.BackColor = frmMain.bela;
            //tbPrivatMail.BackColor = frmMain.bela;
            //tbSluzbeniMail.BackColor = frmMain.bela;
            //tbSluzbeniMob.BackColor = frmMain.bela;
            //tbSluzbeniStac.BackColor = frmMain.bela;
            //tbPrivatMob.BackColor = frmMain.bela;
            //tbMpo.BackColor = frmMain.bela;
            //tbIzobrazba.BackColor = frmMain.bela;
            //tbEmso.BackColor = frmMain.bela;
            //tbDs.BackColor = frmMain.bela;
            //tbTrr.BackColor = frmMain.bela;
            //tbBanka.BackColor = frmMain.bela;
            //tbOddelek.BackColor = frmMain.bela;

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
            tbStevilka.Enabled = false;
            tbOpis.Enabled = false;
            tbOpombe.Enabled = false;
            tbMpo.Enabled = false;
            cbObjekt.Enabled = false;
            cbOseba.Enabled = true;
            cbOseba.Enabled = false;
            chbAktivna.Enabled = false;
            chbImenik.Enabled = false;
            p1.Enabled = false;
            p2.Enabled = false;
            tbIskanje.Enabled = true;
            cbSkupina.Enabled = true;
            dgv1.Enabled = false;
        }

        private void Preklici()
        {
            spreminjanje = false; // ni cb1 on change
            dodajanje = false; // ni cb1 on change
            izprazni_tb();
            onemogoci_tb();
            Gumbi_1();
            Display();
        }
            private void btnNazaj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Shrani()
        {
            int taktivna = 0;
            int timenik = 0;
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

                int toseba = ((KeyValuePair<int, string>)cbOseba.SelectedItem).Key;
                int tobjekt = ((KeyValuePair<int, string>)cbObjekt.SelectedItem).Key;
                string topomba = tbOpombe.Text;
                if (chbImenik.Checked)
                    timenik = 1;


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
            Display();

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
            Nalozi(tid);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Dodaj();
        }

        private void omogoci_tb()
        {
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
            cbObjekt.Text = "";
            cbOseba.Text = "";
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
        }

        private void Grid()
        {
            dgv1.ColumnHeadersVisible = false;
            dgv1.RowHeadersVisible = false;
            dgv1.ColumnCount = 4;
            dgv1.Columns[0].Width = 1;
            dgv1.Columns[1].Width = 120;
            dgv1.Columns[2].Width = 120;
            dgv1.Columns[3].Width = 190;

            dgv1.Columns[0].Name = "Id";
            dgv1.Columns[1].Name = "Priimek";
            dgv1.Columns[2].Name = "Ime";
            dgv1.Columns[3].Name = "Delovno mesto";
            dgv1.Columns["Id"].Visible = false;
            this.dgv1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgv1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgv1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv1.Focus();
        }

        private void Display()
        {
            Izprazni_dgv();
            string q = "select * from tbl_Telefonske order by stevilka";
            try
            {
                cmd = new SqlCommand(q, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tid = (int)rdr["Id"];
                    string tstevilka = (string)rdr["stevilka"]; // Opis
                    //tpriimek = (string)rdr["priimek"];  // določi id v katerega boš pisal
                    //tdelovnomesto = (string)rdr["del_mesto"];

                    string strid = Convert.ToString(tid);
                    string[] row1 = new string[] { strid, tstevilka };
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
                    int trb_mobilna = (int)rdr2["rb_mobilna"];
                    if (trb_mobilna == 1)
                        rbMobilna.Checked = true;
                    else if (trb_mobilna == 2)
                        rbStacionarna.Checked = true;
                    string tmpo = (string)rdr2["stevilka"]; tbMpo.Text = tmpo;
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
            cbObjekt.Enabled = false;
            chbImenik.Checked = true;
            tbStevilka.Focus();
        }
    }
}
