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
using System.Web.Compilation;
using Microsoft.SqlServer.Server;
using System;
using System.Globalization;
using System.IO;
using System.Configuration;


namespace Komunala
{
    public partial class frmMain : Form
    {

        string verzija = "9.2.2021";
        public static string nazivPrograma = "Komunala Radgona";

        SqlCommand cmd;
        SqlDataReader rdr = null;

        public static string disk = "g:\\";
        public static string lokalni_disk = "c:\\";
        public static string app_path = disk+"\\KomunalaApp\\";
        public static string app_path_data = app_path + "data\\";
        public static string pot_podatki=lokalni_disk+ "\\Podatki\\";

        public static string cs = ConfigurationManager.ConnectionStrings["ConStr"].ToString();

        public static string direktor, imenik, datum_o_1, datum_o_2, tekst_o_1, tekst_o_2, datum_t_1, datum_t_2, tekst_t_1, tekst_t_2;
        public static string fname;
        public static int id_parcele, id_ko;
        public static string ime_ko;

        public static string sit_pripravil = "Franc Kovačič"; // privzeti podpisniki za situacije
        public static string sit_odobril = "Andrej Subašič";

        public static string dne_pripravil = "Franc Kovačič";// privzeti podpisniki za gradbeni dnevnik
        public static string dne_odobril = "Andrej Subašič";

        public static SqlConnection c = new SqlConnection(cs);
        public static SqlConnection c2 = new SqlConnection(cs);
        public static SqlConnection c3 = new SqlConnection(cs);
        public static SqlConnection c9 = new SqlConnection(cs);
        public static SqlConnection c6 = new SqlConnection(cs);

        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(cs);

        DateTime datum;
        string leto = "2020"; // začasno - dobi ga iz combobox
        string baza;

        // gumbi menija
        public static Color barva_gumb_neakt = Color.FromArgb(0, 32, 77);
        public static Color barva_gumb_akt = Color.FromArgb(0, 72, 117);
        public static Color barva_gumb_pis_akt = Color.FromArgb(203, 151, 52); // pisava aktivnega gumba
        public static Color barva_gumb_pneakt = Color.FromArgb(255, 255, 255); // pisava neaktivnega gumba
        
        // gumbi za formo
        //public static Color barva_gumb2_neakt = Color.FromArgb(119, 119, 119);
        public static Color barva_gumb2_neakt = Color.FromArgb(207, 198, 193);
        //public static Color barva_gumb2_neakt = Color.FromArgb(119, 119, 119);
        public static Color barva_gumb2_akt = Color.FromArgb(0, 72, 117);
        public static Color barva_gumb2_pis_akt = Color.FromArgb(0, 0, 0); // pisava aktivnega gumba
        public static Color barva_gumb2_pis_neakt = Color.FromArgb(255, 255, 255); // pisava neaktivnega gumba
        public static Color barva_gumb2_disabled = Color.FromArgb(239, 233, 230);
        public static Color barva_tb_onemogoceno = Color.FromArgb(248, 248, 248);
        public static Color barva_tb_omogoceno = Color.FromArgb(255, 255, 255);

        public static int gumb2_sirina = 120;
        public static int gumb2_visina = 36;
        public static Color bela = Color.White;

        public static Color barva_crta = Color.FromArgb(140, 140, 140);
        public static Color barva_form_back = Color.FromArgb(242, 242, 242);

        bool akt_delovni, akt_telefonija, akt_dnevnik, akt_storitve, akt_nalog, akt_ponudba, akt_ijsvo, akt_nastavitve, akt_sifranti;  // kateri zavihek je aktiven

        SqlConnection con = frmMain.c;

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string database = builder.InitialCatalog;
            string server = builder.DataSource;
            string path = Directory.GetCurrentDirectory();
            //app_path = path;
            //app_path_data = app_path + "data";

            string[] baza = cs.Split(';');
            lbaza.Text = "Podatki: " +server+ database;
            lverzija.Text = "Verzija: " + verzija;
            Nastavitve();
            akt_dnevnik = true;
            Razbarvaj_gumbe();
            bm_dnevnik.BackColor = barva_gumb_akt;

            // črta iz label
            crta_dnevnik.AutoSize = false;
            crta_dnevnik.Height = 1;
            crta_dnevnik.BorderStyle = BorderStyle.Fixed3D;

            //frmSodelavci secondForm = new frmSodelavci();
            //secondForm.ShowDialog();
            //Gradbeni_dnevnik secondForm = new Gradbeni_dnevnik();
            //secondForm.ShowDialog();

            ////frmTrgCenik secondForm = new frmTrgCenik();
            ////secondForm.ShowDialog();
            ////frmCeniko_Izpis secondForm = new frmCeniko_Izpis();
            ////secondForm.ShowDialog();
            ////Environment.Exit(0);
            ////frmStoritve secondForm = new frmStoritve();
            ////secondForm.ShowDialog();
            //frmTelBaza sec = new frmTelBaza();
            //sec.ShowDialog();
            //frmPogodbeTel sec = new frmPogodbeTel();
            //sec.ShowDialog();
            //frmBaze sec = new frmBaze();
            //sec.ShowDialog();

            frmZK_REN sec = new frmZK_REN();
            sec.ShowDialog();

            //frmBaze_ZK sec = new frmBaze_ZK();
            //sec.ShowDialog();

            Environment.Exit(0);
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
                    direktor = (string)rdr["direktor"];
                    datum_o_1 = (string)rdr["datum_o_1"];
                    datum_o_2 = (string)rdr["datum_o_2"];
                    tekst_o_1 = (string)rdr["tekst_o_1"];
                    tekst_o_2 = (string)rdr["tekst_o_2"];
                    datum_t_1 = (string)rdr["datum_t_1"];
                    datum_t_2 = (string)rdr["datum_t_2"];
                    tekst_t_1 = (string)rdr["tekst_t_1"];
                    tekst_t_2 = (string)rdr["tekst_t_2"];
                }
                imenik = Path.GetDirectoryName(Application.ExecutablePath);  // začasno??
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

        private void button14_Click(object sender, EventArgs e)
        {
            frmMain_kat secondForm = new frmMain_kat();
            secondForm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            // konec
            Environment.Exit(0);
        }

        private void Razbarvaj_gumbe() // razbarvaj vse gumbe
        {
            bm_dnevnik.BackColor = barva_gumb_neakt;
            bm_ijsvo.BackColor = barva_gumb_neakt;
            bm_nalogi.BackColor = barva_gumb_neakt;
            bm_telefonija.BackColor = barva_gumb_neakt;
            bm_ponudbe.BackColor = barva_gumb_neakt;
            bm_storitve.BackColor = barva_gumb_neakt;
            bm_šifranti.BackColor = barva_gumb_neakt;
            bm_delovni_nalog.BackColor = barva_gumb_neakt;
            bm_izhod.BackColor = barva_gumb_neakt;
        }

        private void Vsi_neaktivni()  // naredi vse zavihke neaktivne
        {
            akt_dnevnik = false;
            akt_nalog = false;
            akt_nastavitve = false;
            akt_ponudba = false;
            akt_ijsvo = false;
            akt_sifranti = false;
            akt_storitve = false;
            akt_delovni = false;
            akt_telefonija = false;
        }


        private void bm_ponudbe_Click(object sender, EventArgs e)
        {
            Vsi_neaktivni();
            akt_ponudba = true;
            Razbarvaj_gumbe();
            bm_ponudbe.BackColor = barva_gumb_akt;
            this.tc.SelectedTab = this.tp_ponudbe;
            cr_ponudbe.AutoSize = false;
            cr_ponudbe.Height = 1;
            cr_ponudbe.BorderStyle = BorderStyle.Fixed3D;

        }

        private void bm_dnevnik_Click(object sender, EventArgs e)
        {
            Vsi_neaktivni();
            akt_dnevnik = true;
            Razbarvaj_gumbe();
            this.tc.SelectedTab = this.tp_dnevnik;
            bm_dnevnik.BackColor = barva_gumb_akt;
            crta_dnevnik.AutoSize = false;
            crta_dnevnik.Height = 1;
            crta_dnevnik.BorderStyle = BorderStyle.Fixed3D;
        }

        private void bm_nalogi_Click(object sender, EventArgs e)
        {
            Vsi_neaktivni();
            akt_nalog = true;
            Razbarvaj_gumbe();
            this.tc.SelectedTab = this.tp_nalogi;
            bm_nalogi.BackColor = barva_gumb_akt;
            cr_nalogi.AutoSize = false;
            cr_nalogi.Height = 1;
            cr_nalogi.BorderStyle = BorderStyle.Fixed3D;
        }

        private void bm_storitve_Click(object sender, EventArgs e)
        {
            Vsi_neaktivni();
            akt_storitve = true;
            Razbarvaj_gumbe();
            this.tc.SelectedTab = this.tp_storitve;
            bm_storitve.BackColor = barva_gumb_akt;
            cr_storitve.AutoSize = false;
            cr_storitve.Height = 1;
            cr_storitve.BorderStyle = BorderStyle.Fixed3D;
        }

        private void bm_ijsvo_Click(object sender, EventArgs e)
        {
            Vsi_neaktivni();
            akt_ijsvo = true;
            Razbarvaj_gumbe();
            bm_ijsvo.BackColor = barva_gumb_akt;
            this.tc.SelectedTab = this.tp_ijsvo;
            cr_ijsvo.AutoSize = false;
            cr_ijsvo.Height = 1;
            cr_ijsvo.BorderStyle = BorderStyle.Fixed3D;
        }

        private void bm_šifranti_Click(object sender, EventArgs e)
        {
            Vsi_neaktivni();
            akt_sifranti = true;
            Razbarvaj_gumbe();
            bm_šifranti.BackColor = barva_gumb_akt;
            this.tc.SelectedTab = this.tp_sifranti;
            cr_sifranti.AutoSize = false;
            cr_sifranti.Height = 1;
            cr_sifranti.BorderStyle = BorderStyle.Fixed3D;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmSituacije secondForm = new frmSituacije();
            secondForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPrejsnji_dnevniki secondForm = new frmPrejsnji_dnevniki();
            secondForm.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bm_dnevnik_MouseEnter(object sender, EventArgs e)
        {
            bm_dnevnik.BackColor = barva_gumb_akt;
        }

        private void bm_ponudbe_MouseEnter(object sender, EventArgs e)
        {
            bm_ponudbe.BackColor = barva_gumb_akt;
        }

        private void bm_nalogi_MouseEnter(object sender, EventArgs e)
        {
            bm_nalogi.BackColor = barva_gumb_akt;
        }

        private void bm_ijsvo_MouseEnter(object sender, EventArgs e)
        {
            bm_ijsvo.BackColor = barva_gumb_akt;
        }

        private void bm_šifranti_MouseEnter(object sender, EventArgs e)
        {
            bm_šifranti.BackColor = barva_gumb_akt;
        }

        private void bm_nastavitve_MouseEnter(object sender, EventArgs e)
        {
            bm_telefonija.BackColor = barva_gumb_akt;
        }

        private void bm_dnevnik_MouseLeave(object sender, EventArgs e)
        {
            if (akt_dnevnik != true)
                bm_dnevnik.BackColor = barva_gumb_neakt;
        }

        private void bm_ponudbe_MouseLeave(object sender, EventArgs e)
        {
            if (akt_ponudba != true)
                bm_ponudbe.BackColor = barva_gumb_neakt;
        }

        private void bm_nalogi_MouseLeave(object sender, EventArgs e)
        {
            if (akt_nalog != true)
                bm_nalogi.BackColor = barva_gumb_neakt;
        }

        private void bm_ijsvo_MouseLeave(object sender, EventArgs e)
        {
            if (akt_ijsvo != true)
                bm_ijsvo.BackColor = barva_gumb_neakt;
        }

        private void bm_šifranti_MouseLeave(object sender, EventArgs e)
        {
            if (akt_sifranti != true)
                bm_šifranti.BackColor = barva_gumb_neakt;
        }

        private void bm_nastavitve_MouseLeave(object sender, EventArgs e)
        {
            if (akt_nastavitve != true)
                bm_telefonija.BackColor = barva_gumb_neakt;
        }

        private void bm_izhod_MouseLeave(object sender, EventArgs e)
        {
                bm_izhod.BackColor = barva_gumb_neakt;
        }

        private void bm_izhod_MouseEnter(object sender, EventArgs e)
        {
            bm_izhod.BackColor = barva_gumb_akt;
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            // šifrant vozil in strojev
            frmStoritve secondForm = new frmStoritve();
            secondForm.ShowDialog();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            // šifrant skupin storitev
            frmSkupineStoritev secondForm = new frmSkupineStoritev();
            secondForm.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            // Cenik občina
            frmObcinaCenik secondForm = new frmObcinaCenik();
            secondForm.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            // šifrant enot
            frmEnote secondForm = new frmEnote();
            secondForm.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // šifrant DDV
            DDV secondForm = new DDV();
            secondForm.ShowDialog();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            // šifrant delovnih mest
            frmPodpisniki secondForm = new frmPodpisniki();
            secondForm.ShowDialog();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmMain_kat secondForm = new frmMain_kat();
            secondForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmBaze secondForm = new frmBaze();
            secondForm.ShowDialog();

        }

        private void bm_storitve_MouseEnter(object sender, EventArgs e)
        {
            bm_storitve.BackColor = barva_gumb_akt;
        }

        private void bm_storitve_Leave(object sender, EventArgs e)
        {
            
        }

        private void bm_storitve_MouseLeave(object sender, EventArgs e)
        {
            if (akt_storitve!=true)
                bm_storitve.BackColor = barva_gumb_neakt;
        }

        string q;
        int int_leto;
        int mesec = 3;
        DateTime v_noc;
        string tmp_mesec, tmp_dan, tmp_leto, tmp_skupaj;
        DateTime tmp_datum;

        private void bm_delovni_nalog_Click(object sender, EventArgs e)
        {
            Vsi_neaktivni();
            akt_delovni = true;
            Razbarvaj_gumbe();
            this.tc.SelectedTab = this.tp_delovni;
            bm_delovni_nalog.BackColor = barva_gumb_akt;
            cr_delovni.AutoSize = false;
            cr_delovni.Height = 1;
            cr_delovni.BorderStyle = BorderStyle.Fixed3D;
        }

        private void bm_delovni_nalog_MouseLeave(object sender, EventArgs e)
        {
            if (akt_delovni != true)
                bm_delovni_nalog.BackColor = barva_gumb_neakt;
        }

        private void bm_delovni_nalog_MouseEnter(object sender, EventArgs e)
        {
            bm_delovni_nalog.BackColor = barva_gumb_akt;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            frmTelBaza sec = new frmTelBaza();
            sec.ShowDialog();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            frmPogodbeTel sec = new frmPogodbeTel();
            sec.ShowDialog();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            frmBaze_ZK sec = new frmBaze_ZK();
            sec.ShowDialog();
        }

        private void bm_telefonija_Click(object sender, EventArgs e)
        {
            Vsi_neaktivni();
            akt_telefonija = true;
            Razbarvaj_gumbe();
            bm_telefonija.BackColor = barva_gumb_akt;
            this.tc.SelectedTab = this.tp_telefonija;
            cr_telefonija.AutoSize = false;
            cr_telefonija.Height = 1;
            cr_telefonija.BorderStyle = BorderStyle.Fixed3D;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            frmNastavitve secondForm = new frmNastavitve();
            secondForm.ShowDialog();
            Nastavitve();  // še enkrat preberi
        }

        int ii, xx; // števci
        bool tmp_jepraznik;

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmSodelavci sec = new frmSodelavci();
            sec.ShowDialog();
        }


        private void button13_Click(object sender, EventArgs e)
        {
            frmBaze secondForm = new frmBaze();
            secondForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Cenik občina
            frmTrgCenik secondForm = new frmTrgCenik();
            secondForm.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            frmNastavitve secondForm = new frmNastavitve();
            secondForm.ShowDialog();
            Nastavitve();  // še enkrat preberi
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // šifrant DDV
            DDV secondForm = new DDV();
            secondForm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // šifrant delovnih mest
            frmPodpisniki secondForm = new frmPodpisniki();
            secondForm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // šifrant enot
            frmEnote secondForm = new frmEnote();
            secondForm.ShowDialog();
        }

        private void tbl_DelovnamestaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.tbl_DelovnamestaBindingSource.EndEdit();
            //- this.tableAdapterManager.UpdateAll(this.komunala_ds);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            // šifrant vozil in strojev
            frmStoritve secondForm = new frmStoritve();
            secondForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // šifrant skupin storitev
            frmSkupineStoritev secondForm = new frmSkupineStoritev();
            secondForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Cenik občina
            frmObcinaCenik secondForm = new frmObcinaCenik();
            secondForm.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            // Gradbeni dnevnik
            Gradbeni_dnevnik secondForm = new Gradbeni_dnevnik();
            secondForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmSkupine secondForm = new frmSkupine();
            secondForm.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            frmSituacije secondForm = new frmSituacije();
            secondForm.ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            frmPrejsnji_dnevniki secondForm = new frmPrejsnji_dnevniki();
            secondForm.ShowDialog();

        }
    }
}
