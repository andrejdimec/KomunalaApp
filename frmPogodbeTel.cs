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
using System.IO;
using System.Configuration;


namespace Komunala
{
    public partial class frmPogodbeTel : Form
    {

        public static string datoteka,pdf_datoteka;
        
        int tid;
        string tstevilka;
        DateTime tdatum;
        string ttip;
        string topis, tlink;

        SqlConnection con = frmMain.c;
        SqlConnection con2 = frmMain.c2;
        SqlConnection con3 = frmMain.c3;
        SqlCommand cmd, cmd2, cmd3;
        SqlDataReader rdr, rdr2, rdr3 = null;

        string q, q2, q3;
        string izbrana_datoteka;
        string index;
        int izbrana_skupina, trenutni, prvi_id;
        bool dodajanje, osnovno, spreminjanje, prvic, poslano;
        Dictionary<int, string> TipPogodbeDict = new Dictionary<int, string>();
        string imenik, pot, pot_dok;
        bool je_datoteka_izbrana;
        int najvecja;  // največja številka dokumenta

        private void btnNazaj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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
            Brisi();
        }
        private void Brisi()
        {

            DialogResult result = MessageBox.Show("Izbrišem zapis " + tbOpis.Text + "?", "Potrdi brisanje", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string q = "delete from tbl_Pogodbe_tel where id = @tid";
                    cmd = new SqlCommand(q, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@tid", tid);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka pri brisanju dokumenta: " + ex.Message);
                }
                finally
                {
                    if (con != null)
                    {
                        con.Close();
                        Displayf(0);
                    }
                }

                //Zacetek();
            }
            else if (result == DialogResult.No)
            {
                //Zacetek();
            }

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

        private void btnPreklici_Click(object sender, EventArgs e)
        {
            Preklici();
        }

        private void Shrani()
        {
            int tmpvrsta = -99;
            string q;
            bool vse_v_redu = false;

            if (tbOpis.Text != "")
                vse_v_redu = true;
            else
            {
                vse_v_redu = false;
                MessageBox.Show("Manjka opis.");
            }
            if (vse_v_redu)
            {
                if (tbStevilka.Text != "")
                    vse_v_redu = true;
                else
                {
                    vse_v_redu = false;
                    MessageBox.Show("Manjka številka dokumenta.");
                }
            }
            if (vse_v_redu)
            {
                if (cbVrsta.Text != "")
                    vse_v_redu = true;
                else
                {
                    vse_v_redu = false;
                    MessageBox.Show("Izberi vrsto dokumenta.");
                }
            }

            if (vse_v_redu)
            {
                // določi vrednosti
                
                DateTime tmpdatum = dtDatum.Value.Date;
                int tmpzaporedna = Convert.ToInt32(tbStevilka.Text);
                if (cbVrsta.Text != "")
                {
                    tmpvrsta = ((KeyValuePair<int, string>)cbVrsta.SelectedItem).Key;
                }
                string tmpopis = tbOpis.Text;
                izbrana_datoteka = "Ime datoteke";
                string tmpfname = izbrana_datoteka;


                try
                {
                    if (dodajanje)
                    {
                        // dodaj
                        q = "insert into tbl_Pogodbe_tel (Zaporedna,Datum,TipDokumenta,Opis,Fname) " +
                            "values(@Zaporedna,@Datum,@TipDokumenta,@Opis,@Fname)";
                        
                        cmd = new SqlCommand(q, con);
                        con.Open();
                        
                        cmd.Parameters.AddWithValue("@Zaporedna", tmpzaporedna);
                        cmd.Parameters.AddWithValue("@Datum", tmpdatum);
                        cmd.Parameters.AddWithValue("@TipDokumenta", tmpvrsta);
                        cmd.Parameters.AddWithValue("@Opis", tmpopis);
                        cmd.Parameters.AddWithValue("@Fname", tmpfname);

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
                        //cmd.Parameters.AddWithValue("@skupina", tskupina);
                        //cmd.Parameters.AddWithValue("@rb_mobilna", trb_mobilna);
                        //cmd.Parameters.AddWithValue("@stevilka", tstevilka);
                        //cmd.Parameters.AddWithValue("@mpo", tmpo);
                        //cmd.Parameters.AddWithValue("@aktivna", taktivna);
                        //cmd.Parameters.AddWithValue("@opis", topis);
                        //cmd.Parameters.AddWithValue("@rb_oseba", trb_oseba);
                        //cmd.Parameters.AddWithValue("@oseba", toseba);
                        //cmd.Parameters.AddWithValue("@objekt", tobjekt);
                        //cmd.Parameters.AddWithValue("@opomba", topomba);
                        //cmd.Parameters.AddWithValue("@imenik", timenik);
                        //cmd.Parameters.AddWithValue("@sm", tmpsm_id);
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
                //Nalozi(prvi_id);

                //Zacetek();
            }
            else
            {
                tbStevilka.Focus();
            }
        }


        private void btnShrani_Click(object sender, EventArgs e)
        {
            Shrani();
        }

        private void dgv1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgv1.Rows[e.RowIndex].Height = 30;
        }

        private void Dodaj()
        {
            je_datoteka_izbrana = false;
            dodajanje = true;
            spreminjanje = false;
            omogoci_tb();
            izprazni_tb();
            Gumbi_2();
            cbVrsta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVrsta.Enabled = true;
            dgv1.Enabled = false;
            tbOpis.Text = "";
            tbStevilka.Text = Convert.ToString(najvecja+1);
            tbStevilka.Focus();
        }

        private void Spremeni()
        {
            dodajanje = false;
            spreminjanje = true;
            omogoci_tb();
            Gumbi_2();
            dgv1.Enabled = false;
            cbVrsta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVrsta.Enabled = true;
            tbStevilka.Focus();

        }


        private void Nastavitve()
        {
            try
            {
                q = "select * from tblNastavitve"; //+ sort;
                cmd = new SqlCommand(q, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    imenik = (string)rdr["imenik"];
                    pot = (string)rdr["mapa_pogodbe_tel"];
                }
                //MessageBox.Show(imenik);
                pot_dok = imenik + pot;
                //MessageBox.Show(pot_dok);
                //imenik = Path.GetDirectoryName(Application.ExecutablePath);  // začasno??
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka rdr nastavitve: " + ex.Message);
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

        private void OdpriDatoteko(string ime)
        {
            if (File.Exists(@ime))
            {
                //MessageBox.Show(ime);
                FileInfo fi = new FileInfo(ime);
                string ext = fi.Extension;
                //MessageBox.Show(ext);
                switch (ext)
                {
                    case ".pdf":
                        {
                            //MessageBox.Show("PDF datoteka.");
                            pdf_datoteka = ime;
                            frmViewPDF sec = new frmViewPDF();
                            sec.Show();
                            break;
                        }
                    case "jpg":
                        {
                            break;
                        }
                    case "png":
                        {
                            break;
                        }
                }

                //axAcroPDF1.LoadFile(ime);
                //MessageBox.Show(ime + "Obstaja.");
            }
            else
                MessageBox.Show("Datoteka ne obstaja.");
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string tmplink = dgv1.Rows[e.RowIndex].Cells[5].Value.ToString();
            tmplink = pot_dok + tmplink;
            OdpriDatoteko(tmplink);
        }

        public frmPogodbeTel()
        {
            InitializeComponent();
        }

        private void Vrste_dokumentov_v_cb()
        {

            q2 = "select * from tbl_TipPogodbe order by TipPogodbe";
            try
            {
                cmd2 = new SqlCommand(q2, con2);
                con2.Open();
                rdr2 = cmd2.ExecuteReader();
                cbVrsta.Items.Clear();
                while (rdr2.Read())
                {
                    int tIndeks = (int)rdr2["Id"]; 
                    string tTipPogodbe = (string)rdr2["TipPogodbe"];
                    TipPogodbeDict.Add(tIndeks, tTipPogodbe);
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
                cbVrsta.DataSource = TipPogodbeDict.ToArray();
                cbVrsta.DisplayMember = "Value";
                cbVrsta.ValueMember = "Key";
            }
        }

        private void frmPogodbeTel_Load(object sender, EventArgs e)
        {
            Nastavitve();
            Vrste_dokumentov_v_cb();
            //Prestej();
            Design();
            //Grid();
            Displayf(0);
            Gumbi_1();
            izprazni_tb();
            onemogoci_tb();
            //Nalozi(prvi_id);
            dgv1.Focus();
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

        private void onemogoci_tb()
        {
            cbVrsta.BackColor = frmMain.bela;
            cbVrsta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVrsta.Enabled = false;
            tbStevilka.Enabled = false;
            tbOpis.Enabled = false;
            dtDatum.Enabled = false;
        }
        private void omogoci_tb()
        {
            cbVrsta.DropDownStyle = ComboBoxStyle.DropDown;
            tbStevilka.Enabled = true;
            tbOpis.Enabled = true;
            dtDatum.Enabled = true;
            cbVrsta.Enabled = true;
            dgv1.Enabled = true;
        }

        private void izprazni_tb()
        {
            tbStevilka.Text = "";
            tbOpis.Text = "";
            dtDatum.Text = "";
            this.cbVrsta.SelectedValue = 0;
        }
        private void Izprazni_dgv()
        {
            dgv1.Rows.Clear();
            dgv1.Refresh();
        }
        private void Displayf(int filter)
        {
            string filter_1;
            najvecja = 0;
            filter_1 = "";
            prvic = true;
            Izprazni_dgv();
            string q = "SELECT tbl_Pogodbe_tel.Id, tbl_Pogodbe_tel.TipDokumenta, Tbl_TipPogodbe.TipPogodbe AS eTip, tbl_Pogodbe_tel.Zaporedna AS eZap, " +
                "tbl_Pogodbe_tel.Datum AS eDat, tbl_Pogodbe_tel.Opis AS eOpi, tbl_Pogodbe_tel.Fname AS eFna " +
                "FROM tbl_Pogodbe_tel INNER JOIN  Tbl_TipPogodbe ON tbl_Pogodbe_tel.TipDokumenta = Tbl_TipPogodbe.Id";

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
                    int intstevilka = (Int32)rdr["eZap"];
                    if (intstevilka > najvecja)
                        najvecja = intstevilka;
                    tstevilka = intstevilka.ToString().PadLeft(4, '0'); // Opis
                    DateTime tmpdat = (DateTime)rdr["eDat"];
                    string tdatum = tmpdat.ToString("dd.MM.yyyy");
                    ttip = (string)rdr["eTip"];
                    topis = (string)rdr["eOpi"];
                    tlink = (string)rdr["eFna"];

                    DataGridViewTextBoxCell Id = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell Stevilka = new DataGridViewTextBoxCell();
                    
                    DataGridViewTextBoxCell Datum = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell Tip = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell Opis = new DataGridViewTextBoxCell();
                    DataGridViewButtonCell Link = new DataGridViewButtonCell();

                    Id.Value = tid;
                    Stevilka.Value = tstevilka;
                    Datum.Value = tdatum;
                    Tip.Value = ttip;
                    Opis.Value = topis;
                    Link.Value = tlink;

                    dgv1.RowTemplate.MinimumHeight = 35;

                    DataGridViewRow row = new DataGridViewRow();

                    row.Cells.Add(Id);
                    row.Cells.Add(Stevilka);
                    row.Cells.Add(Datum);
                    row.Cells.Add(Tip);
                    row.Cells.Add(Opis);
                    row.Cells.Add(Link);

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

            tbOpis.BackColor = frmMain.bela;
            tbStevilka.BackColor = frmMain.bela;
            //tdatum.BackColor = frmMain.bela;
        }
    }
}
