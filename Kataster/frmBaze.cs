using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Collections;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Data.OleDb;
using GemBox.Spreadsheet;
// using Microsoft.Office.Interop.Excel;


using System.CodeDom;

//using Excel = Microsoft.Interop.Excel;

namespace Komunala
{
    public partial class frmBaze : Form
    {
        // določi connection
        
        // začasno
        System.Data.DataTable dtable = new System.Data.DataTable();
        DataTable dt_bass = new DataTable();

        public static string lokalni_disk = "c:\\";
        //public static string app_path = disk + "\\KomunalaApp\\";
        //public static string app_path_data = app_path + "data\\";
        public static string pot_podatki = lokalni_disk + "Podatki\\";


        public static string strc = @"Server=192.168.100.18;Database=radgona;Uid=dimec;Pwd='6iXrN6J8@J';Connect Timeout=30;"; // do bass strežnika
        MySqlConnection conb = new MySqlConnection (strc);
        MySqlCommand cmdb;
        MySqlConnection conb2 = new MySqlConnection(strc);
        MySqlCommand cmdb2;
        MySqlDataReader rdrb = null;
        MySqlDataReader rdrb2 = null;

        SqlConnection con = frmMain.c;
        SqlConnection con2 = frmMain.c2;
        SqlConnection con3 = frmMain.c3;
        OleDbConnection cona = frmMain.ca;
        
        SqlDataAdapter adapt;

        SqlCommand cmd;
        SqlDataReader rdr = null;

        OleDbCommand cmda;
        OleDbDataReader rdra = null;

        SqlCommand cmd2;
        SqlDataReader rdr2 = null;

        SqlCommand cmd3;
        SqlDataReader rdr3 = null;

        int stevec_zacasno = 0;
        int stevec_stalno = 0;
        int temp_zacasno, temp_stalno;

        int nivcadis, cadis;
        string vrstica;
        int stevec;
        int countcrp, counths, countul, countna, countpt, countcad;
        // string mapa = "C:\\KatApp\\Kataster\\data\\";
        string mapa = frmMain.app_path_data;
        string m1 = "data\\";
        
       // MessageBox.Show(mapa);
            
        string fnamecrp;
        string fnamecad;
        string fnamecad2;
        string fnamecrp2;
        string fnamehs;
        string fnamehs2;
        string fnameul;
        string fnameul2;
        string fnamena;
        string fnamena2;
        string fnamept;
        string fnamept2, fnameag, fnameag2;
        char csv;
        
        string str_zapisi;
        string ag_id, ag_ime;  // aglomeracije
        int nag,ncrp, nhs, nul, nna, npt, ncad; // napake pri preverjanju baze
        string tnaslov, tindeks_osebe;
        // variable cadis
        string chsmid = "", cnaziv = "", ckraj = "", culica = "", chs = "", cposta = "", cime_poste = "", cdim = "", ctip_om = "",c_tip="",c_oblika="",c_id_vs="",c_upravljanje="" ;
        int csmeti = 0, cvodovod = 0, ckanalizacija = 0, cgreznica = 0;

        // variable tbl_crp
        string emso = "", spol = "", priimek1 = "", priimek2 = "", ime1 = "", ime2 = "", drzava = "", obcina_roj = "", naselje_roj = "";
        string drzava_roj = "", naselje_stpr = "", ulica_stpr = "", hs_stpr = "", hsd_stpr = "", posta_stpr = "", naziv_poste_stpr = "";
        string pt_id = "", pt_uime = "";

        // za izvoz v CSV
        string c_hsmid, c_ulica, c_labela, c_naslov, c_stalno, c_zacasno, c_voda, c_kanalizacija, c_smeti, c_greznica, c_x, c_y,c_cadis;
        string toblika_ijs, ttip_prikljucka, tid_vs, tupravljanje_prikljucka, ttip_om, time_cadis, cpedej, cpepos, ckmet, ckmgmid, cpredvidena, cdatpred, cagloid, copombe;

        // t4 kanalizacija
        string ime_aglo = "";
        string id_aglo = "";
        string delez_v_javno = "";
        string st_preb = "";
        string obrem_gospodinjstva = "";
        string obrem_dejavnost = "";
        string obrem_industrija = "";
        string delez_priljucenosti = "";
        string metoda = "";
        string delez_nepriljucenosti = "";
        string delez_opremljenosti = "";
        string preb_na_kanal = "";
        string delez_idivid = "";
        string delez_brez_ciscenja = "";
        string delez_ne_v_javno = "";
        string komentar = "";

        double poraba = 0;
        double stara_poraba = 0;

        // bass
        string sifra_om, naziv_om, naslov, posta, sifra_okolisa, naziv, hsmid, tip_okol, st_stan, st_clan, sif_uporab, uporabnik, sif_last, lastnik, sk_obj, naziv_sk_obj, upravljanje, sklad, sk_obj2, aktiven, naziv2, datum_od, datum_do, tip_storitev, sifra_uvoza,stevec_str;
        string lab, namid, obmid, ptmid, ptid, ptime, ulid, ulime, naid, naime,gidx;

        private void button27_Click(object sender, EventArgs e)
        {
            // razdeli šifro in naziv v OM za Bass
            ls.Text = "";
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = frmMain.pot_podatki;

            open.FileName = "";

            open.Filter = "Ločeno s podpičjem | *.csv";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Razdeli_om(open.FileName);
                ls.Text = "Ok";
            }
        }
        private void Shrani_vrsto(string vrstica, string imedatoteke)
        {
                try
                {
                    using (StreamWriter writetext = new StreamWriter(imedatoteke))
                    {
                        writetext.WriteLine(vrstica, Encoding.UTF8);
                    }
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("Napaka pri shranjevanju: " + ex2.Message);
                }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            // razdeli šifro in naziv v OM za Bass
            ls.Text = "";
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = frmMain.pot_podatki;

            open.FileName = "";

            open.Filter = "Ločeno s podpičjem | *.csv";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Razdeli_om2(open.FileName);
                ls.Text = "Ok";
            }

        }

        private void Razdeli_om2(string vhod)
        {
            csv = ';';
            string dod1, dod2, dod3, dod4, dod5, dod6;
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "Objekti in OM - ločeno Andrej.csv";
            save.Filter = "Ločeno s podpičjem | *.csv";

            if (save.ShowDialog() == DialogResult.OK)

            {
                using (StreamWriter writetext = new StreamWriter(save.FileName))
                {
                    // glava
                    str_zapisi = "SIFRA_OBJ" + csv + "SIFRAOM" + csv + "OM_NAZIV" + csv + "OM_NASLOV" + csv + "KOLICINA" + csv + "VREDNOST" + csv + "VREDNOSTZDDV" + csv + "VREDNOST_DDV";
                    writetext.WriteLine(str_zapisi, Encoding.ASCII);


                    string tip_stor = "";
                    string skup_stor = "";
                    string stor = "";
                    // Bass - razdeli šifre OM
                    stevec = 0;
                    try
                    {
                        System.IO.StreamReader objReader;
                        objReader = new System.IO.StreamReader(vhod, ASCIIEncoding.UTF8);
                        do
                        {
                            dod1 = ""; dod2 = ""; dod3 = ""; dod4 = ""; dod5 = ""; dod6 = "";
                            vrstica = "";
                            //Izprazni_cad_om();
                            //vrstica = vrstica + objReader.ReadLine() + "\r\n";
                            vrstica = objReader.ReadLine();
                            string[] polje = vrstica.Split(';');

                            tip_stor = polje[1];
                            //skup_stor = polje[7];
                            //stor = polje[8];
                            // razdeli prvi stolpec
                            if (tip_stor.Contains(' '))
                            {
                                string[] sifra = tip_stor.Split(' ');
                                dod1 = sifra[0];
                                dod2 = sifra[1];
                                if (dod2.Length > 0)
                                {
                                    dod2 = tip_stor.Remove(0, dod1.Length + 1);
                                }
                                else
                                {
                                    dod2 = dod1;
                                }
                            }
                            else
                            {
                                dod1 = ""; dod2 = "";
                            }


                            string vrstica_pisi = vrstica + csv + dod1 + csv + dod2;
                            writetext.WriteLine(vrstica_pisi, Encoding.UTF8);
                            stevec = ++stevec;
                            vrstica = "";
                            ls.Text = stevec.ToString();
                            ls.Refresh();
                        } while (objReader.Peek() != -1);
                        objReader.Close();
                        stevec--;
                        ls.Text = stevec.ToString();
                        ls.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka: " + ex.Message);
                    }
                    finally
                    {
                        MessageBox.Show("Zapis v CSV končan!");
                    }
                }
            } // if savedialog ok
        }


        private void Razdeli_om(string vhod)
        {
            csv = ';';
            string dod1, dod2, dod3, dod4, dod5, dod6;
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "om s storitvami - ločeno.csv";
            save.Filter = "Ločeno s podpičjem | *.csv";

            if (save.ShowDialog() == DialogResult.OK)

            {
                using (StreamWriter writetext = new StreamWriter(save.FileName))
                {
                    // glava
                    str_zapisi = "STRANKA_SIFRA" + csv + "OM_SIFRA" + csv + "STOR_DELEZ" + csv + "STOR_KOLICNIK1" + csv + "STOR_KOLICNIK2" + csv + "STOR_KOLICNIK3" + csv + "STOR_TIP_STORITVE" + csv + "STOR_SKUPINA_STORITEV" + csv +
                        "STOR_STOR_STORITEV" + csv + "STOR_VEZAVA" + csv + "STOR_CENA" + csv + "STOR_ENOTA_MERE" + csv + "STOR_STOR_DAVST" + csv + "STOR_STOR_NACOBR" + csv + "STOR_STOR_DELITEV_STROSKOV" 
                        + csv + "TIP_STORITVE_SIF" + csv + "TIP_STORITVE_TEKST" + csv + "SKUPINA_STORITVE_SIF" + csv + "SKUPINA_STORITVE_TEKST" + csv + "STORITEV_SIF" + csv + "STORITEV_TEKST";
                    writetext.WriteLine(str_zapisi,Encoding.ASCII);
                

                string tip_stor = ""; 
                string skup_stor = "";
                string stor = "";
                // Bass - razdeli šifre OM
                stevec = 0;
                try
                {
                    System.IO.StreamReader objReader;
                    objReader = new System.IO.StreamReader(vhod, ASCIIEncoding.UTF8);
                    do
                    {
                            dod1 = ""; dod2 = ""; dod3 = ""; dod4 = ""; dod5 = ""; dod6 = "";
                            vrstica = "";
                            //Izprazni_cad_om();
                            //vrstica = vrstica + objReader.ReadLine() + "\r\n";
                            vrstica = objReader.ReadLine();
                            string[] polje = vrstica.Split(';');

                            tip_stor = polje[6];
                            skup_stor = polje[7];
                            stor = polje[8];
                            // razdeli prvi stolpec
                            if (tip_stor.Contains(' '))
                            {
                                string[] sifra = tip_stor.Split(' ');
                                dod1 = sifra[0];
                                dod2 = sifra[1];
                                if (dod2.Length > 0)
                                {
                                    dod2 = tip_stor.Remove(0, dod1.Length + 1);
                                }
                                else
                                {
                                    dod2 = dod1;
                                }
                            }
                            else
                            {
                                dod1 = ""; dod2 = "";
                            }

                            // razdeli drugi stolpec
                            if (skup_stor.Contains(' '))
                            {
                                string[] sifra = skup_stor.Split(' ');
                                dod3 = sifra[0];
                                dod4 = sifra[1];
                                if (dod4.Length > 0)
                                {
                                    dod4 = skup_stor.Remove(0, dod3.Length + 1);
                                }
                                else
                                {
                                    dod4 = dod2;
                                }
                            }
                            else
                            {
                                dod3 = ""; dod4 = "";
                            }

                            // razdeli tretji stolpec
                            if (stor.Contains(' '))
                            {
                                string[] sifra = stor.Split(' ');
                                dod5 = sifra[0];
                                dod6 = sifra[1];
                                if (dod6.Length > 0)
                                {
                                    dod6 = stor.Remove(0, dod5.Length + 1);
                                }
                                else
                                {
                                    dod6 = dod5;
                                }
                            }
                            else
                            {
                                dod5 = ""; dod6 = "";
                            }

                            string vrstica_pisi = vrstica + csv + dod1 + csv + dod2 + csv + dod3 + csv + dod4 + csv + dod5 + csv + dod6;
                            writetext.WriteLine(vrstica_pisi, Encoding.UTF8);
                            stevec = ++stevec;
                            vrstica = "";
                            ls.Text = stevec.ToString();
                            ls.Refresh();
                    } while (objReader.Peek() != -1);
                    objReader.Close();
                    stevec--;
                    ls.Text = stevec.ToString();
                    ls.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: " + ex.Message);
                }
                finally
                {
                    MessageBox.Show("Zapis v CSV končan!");
                }
            }
            } // if savedialog ok
        }


        private void button26_Click(object sender, EventArgs e)
        {
            // Zapiši aglomeracije za Bass

            ls1.Text = counths.ToString();
            ls1.Refresh();
            ls.Text = "";
            OpenFileDialog open = new OpenFileDialog();
            open.FileName = "";

            open.Filter = "Ločeno s podpičjem | *.csv";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Obdelaj_aglo_bass(open.FileName);
                ls.Text = "Ok";
                ls.Refresh();
            }

        }

        private void button29_Click(object sender, EventArgs e)
        {
            // prenesi CRP iz ACESS baze z uvoženo tabelo iz EXCEL-a - jan 2022
            stevec = 0;
            IzprazniBazo_crp();
            try
            {
                rdra = null;
                string q9 = "select * from crp";
                cmda = new OleDbCommand(q9, cona);
                cona.Open();
                rdra = cmda.ExecuteReader();
                while (rdra.Read())
                {
                    //namid_ok = (String)rdr["na_mid"];  // določi namid stalnega
                    //naselje_ok = (String)rdr["na_uime"];  // določi naselje stalnega
                    vrstica = "";
                    string idxulica = "";
                    string idxulica_s = "";
                    string idxulica_z = "";
                    izprazni_crp();
                    vrstica = "";
                    // razdeli vrstico ločeno s ;
                    string[] polje = vrstica.Split(';');
                    emso = "N/A";
                    if (rdra["spol"] != DBNull.Value) spol = (string)rdra["spol"];
                    if (rdra["Datum rojstva"] != DBNull.Value) dat_roj = Convert.ToString((DateTime)rdra["Datum rojstva"]);
                    if (rdra["Priimek1"] != DBNull.Value) priimek1 = (string)rdra["Priimek1"];
                    if (rdra["Priimek2"] != DBNull.Value) priimek2 = (string)rdra["Priimek2"];
                    if (rdra["Ime1"] != DBNull.Value) ime1 = (string)rdra["Ime1"];
                    if (rdra["Ime2"] != DBNull.Value) ime2 = (string)rdra["Ime2"];

                    if (rdra["Ime državljanstva1"] != DBNull.Value) drzava = (string)rdra["Ime državljanstva1"];
                    if (rdra["Naziv občine roj"] != DBNull.Value) obcina_roj = (string)rdra["Naziv občine roj"];
                    if (rdra["Naziv naselja roj"] != DBNull.Value) naselje_roj = (string)rdra["Naziv naselja roj"];
                    if (rdra["Naziv države roj"] != DBNull.Value) drzava_roj = (string)rdra["Naziv države roj"];
                    if (rdra["Naziv naselja STPR"] != DBNull.Value) naselje_stpr = (string)rdra["Naziv naselja STPR"];
                    if (rdra["Naziv ulice STPR"] != DBNull.Value) ulica_stpr = (string)rdra["Naziv ulice STPR"];
                    if (rdra["Hišna št STPR"] != DBNull.Value) hs_stpr = Convert.ToString((double)rdra["Hišna št STPR"]);
                    if (rdra["Hišna št STPR dodatek"] != DBNull.Value) hsd_stpr = (string)rdra["Hišna št STPR dodatek"];
                    if (rdra["Pošta STPR"] != DBNull.Value) posta_stpr = Convert.ToString((double)rdra["Pošta STPR"]);
                    if (rdra["Pošte STPR naziv"] != DBNull.Value) naziv_poste_stpr = (string)rdra["Pošte STPR naziv"];
                    if (rdra["Naziv ulice ZCPR"] != DBNull.Value) ulica_zcpr = (string)rdra["Naziv ulice ZCPR"];
                    if (rdra["Hišna št ZCPR"] != DBNull.Value) hs_zcpr = Convert.ToString((double)rdra["Hišna št ZCPR"]);
                    if (rdra["Hišna št ZCPR dodatek"] != DBNull.Value) hsd_zcpr = (string)rdra["Hišna št ZCPR dodatek"];
                    if (rdra["Pošta ZCPR"] != DBNull.Value) posta_zcpr = (string)rdra["Pošta ZCPR"];
                    if (rdra["Pošte ZCPR naziv"] != DBNull.Value) naziv_poste_zcpr = (string)rdra["Pošte ZCPR naziv"];
                    if (rdra["Datum od ZCPR"] != DBNull.Value) datum_od_zcpr = Convert.ToString((DateTime)rdra["Datum od ZCPR"]);
                    if (rdra["Status prebivališča"] != DBNull.Value) status_preb = Convert.ToString((double)rdra["Status prebivališča"]);
                    if (rdra["Zakonski stan naziv"] != DBNull.Value) stan = (string)rdra["Zakonski stan naziv"];

                    // napiši prebrano v tabelo crp
                    try
                    {
                        if (stevec > 0)  // preskoči prvo vrstico
                        {
                            // naredi indekse

                            // indeks crp - vsi ga morajo imeti iz radgonske občine
                            string stalno = "1"; //"Ima samo stalno prebivališče";
                            string zacasno = "2"; //"Ima samo začasno prebivališče";
                            string oboje = "3"; //"Ima stalno in začasno prebivališče";
                            string izbira = status_preb;
                            string namid_ok = ""; // na_mid, ki se bo zapisal v bazo crp
                            string naselje_ok = ""; // ime naselja, ki se bo zapisalo v bazo
                            string idxtemp = "";
                            string idxt = "";
                            string lcaseidxtemp = "";
                            string lcaseidxtempz = "";
                            int tzacasno = 0;
                            int tstalno = 0;

                            if (izbira == stalno)
                            {
                                // če ima samo stalno je sigurno v radgoni
                                idxtemp = ulica_stpr + hs_stpr + hsd_stpr;
                                idxtemp = string.Join("", idxtemp.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries)); // odstrani presledke
                                lcaseidxtemp = idxtemp.ToLower(); // v male črke
                                idxt = lcaseidxtemp;
                                idxulica_s = ulica_stpr;
                                idxulica = ulica_stpr;
                                idxulica_z = "99";
                                lcaseidxtempz = "99";
                                tzacasno = 0;
                                tstalno = 1;
                            }

                            if (izbira == zacasno)
                            {
                                // če ima samo začasno je sigurno v radgoni
                                idxtemp = ulica_zcpr + hs_zcpr + hsd_zcpr;
                                idxtemp = string.Join("", idxtemp.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries)); // odstrani presledke
                                lcaseidxtemp = idxtemp.ToLower(); // v male črke
                                idxt = lcaseidxtemp;
                                idxulica = ulica_zcpr;
                                idxulica_s = ulica_zcpr;
                                idxulica_z = ulica_zcpr;
                                lcaseidxtempz = lcaseidxtemp;
                                tzacasno = 1;
                                tstalno = 0;
                            }
                            if (izbira == oboje)
                            {
                                // stalno
                                idxtemp = ulica_stpr + hs_stpr + hsd_stpr;
                                idxtemp = string.Join("", idxtemp.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries)); // odstrani presledke
                                lcaseidxtemp = idxtemp.ToLower(); // v male črke

                                // zacasno
                                idxtempz = ulica_zcpr + hs_zcpr + hsd_zcpr;
                                idxtempz = string.Join("", idxtempz.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries)); // odstrani presledke
                                lcaseidxtempz = idxtempz.ToLower(); // v male črke
                                                                    //MessageBox.Show(lcaseidxtemp + " " + lcaseidxtempz);

                                // če je idxtemp v indeksu HS je to pravi
                                // preveri če je idxtemp v radgonski občini
                                // če je -> idx = idxtemp, index_crp = idxtemp, index_crpz = idxtempz
                                // če je stalno v radgonski občini daj idxtemp kot index_crp in idxtempz kot index_crpz
                                natemp = "";
                                int stpr_v_gr = 0;
                                string q = "select na_mid from tbl_hs where index_hs = @indeks";

                                cmd = new SqlCommand(q, con);
                                con.Open();
                                cmd.Parameters.AddWithValue("@indeks", lcaseidxtemp); // preberi naselje
                                cmd.ExecuteNonQuery();
                                natemp = (string)cmd.ExecuteScalar();
                                con.Close();
                                tstalno = 1;
                                if (natemp == null)
                                {
                                    // nič ni našel, začasno je v radgoni
                                    // MessageBox.Show("nič ni našel " + natemp);
                                    stpr_v_gr = 0;
                                    idxt = lcaseidxtempz;
                                    idxulica = ulica_zcpr;
                                    tzacasno = 1;
                                    tstalno = 0;
                                    //tzacasno = 0;
                                    //tstalno = 1;
                                }

                                if (natemp != null)
                                {
                                    // našel je zapis - stalno je v radgoni ampak 
                                    stpr_v_gr = 1;
                                    idxt = lcaseidxtemp;
                                    idxulica = ulica_stpr;
                                    tzacasno = 0;
                                    tstalno = 1;
                                    //tzacasno = 1;
                                    //tstalno = 0;
                                }
                            }
                            // konec indeksov
                            naselje_ok = idxulica;

                            naselje_ok = "Gornja Radgona";
                            namid_ok = "10092752"; // MID od radgone

                            // poglej če je idxulica med naselji, če ni je gornja radgona
                            SqlDataReader rdr = null;
                            try
                            {
                                string q = "select na_mid, na_uime from tbl_na where na_uime = @tnauime";
                                cmd = new SqlCommand(q, con);
                                con.Open();
                                cmd.Parameters.AddWithValue("@tnauime", idxulica); // preberi naselje
                                rdr = cmd.ExecuteReader();
                                while (rdr.Read())
                                {
                                    namid_ok = (String)rdr["na_mid"];  // določi namid stalnega
                                    naselje_ok = (String)rdr["na_uime"];  // določi naselje stalnega
                                }
                            }
                            catch (Exception ex2)
                            {
                                MessageBox.Show("Napaka reader: " + ex2.Message);
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

                            tindeks_osebe = dat_roj + priimek1 + ime1 + lcaseidxtemp + lcaseidxtempz;
                            string query = "insert into tbl_crp(indeks_osebe,emso,spol,dat_roj,priimek1,priimek2,ime1,ime2,drzava," +
                            "               obcina_roj,naselje_roj,drzava_roj,naselje_stpr,ulica_stpr,hs_stpr,hsd_stpr,posta_stpr,naziv_poste_stpr,ulica_zcpr,hs_zcpr,hsd_zcpr," +
                            "               posta_zcpr,naziv_poste_zcpr,datom_od_zcpr,status_preb,stan,index_crp,index_crpz,idx,zacasno,stalno,na_s,na_z) values(@indeks_osebe,@emso,@spol,@dat_roj,@priimek1,@priimek2," +
                            "               @ime1,@ime2,@drzava,@obcina_roj,@naselje_roj,@drzava_roj,@naselje_stpr,@ulica_stpr,@hs_stpr, @hsd_stpr, @posta_stpr, @naziv_poste_stpr," +
                            "               @ulica_zcpr, @hs_zcpr, @hsd_zcpr, @posta_zcpr, @naziv_poste_zcpr, @datom_od_zcpr, @status_preb, @stan,@index_crp,@index_crpz,@idx,@zacasno,@stalno,@na_s,@na_z)";
                            cmd = new SqlCommand(query, con);
                            con.Open();
                            cmd.Parameters.AddWithValue("@emso", emso);
                            cmd.Parameters.AddWithValue("@indeks_osebe", tindeks_osebe);
                            cmd.Parameters.AddWithValue("@spol", spol);
                            cmd.Parameters.AddWithValue("@dat_roj", dat_roj);
                            cmd.Parameters.AddWithValue("@priimek1", priimek1);
                            cmd.Parameters.AddWithValue("@priimek2", priimek2);
                            cmd.Parameters.AddWithValue("@ime1", ime1);
                            cmd.Parameters.AddWithValue("@ime2", ime2);
                            cmd.Parameters.AddWithValue("@drzava", drzava);
                            cmd.Parameters.AddWithValue("@obcina_roj", obcina_roj);
                            cmd.Parameters.AddWithValue("@naselje_roj", naselje_roj);
                            cmd.Parameters.AddWithValue("@drzava_roj", drzava_roj);
                            cmd.Parameters.AddWithValue("@naselje_stpr", naselje_stpr);
                            cmd.Parameters.AddWithValue("@ulica_stpr", ulica_stpr);
                            cmd.Parameters.AddWithValue("@hs_stpr", hs_stpr);
                            cmd.Parameters.AddWithValue("@hsd_stpr", hsd_stpr);
                            cmd.Parameters.AddWithValue("@posta_stpr", posta_stpr);
                            cmd.Parameters.AddWithValue("@naziv_poste_stpr", naziv_poste_stpr);
                            cmd.Parameters.AddWithValue("@ulica_zcpr", ulica_zcpr);
                            cmd.Parameters.AddWithValue("@hs_zcpr", hs_zcpr);
                            cmd.Parameters.AddWithValue("@hsd_zcpr", hsd_zcpr);
                            cmd.Parameters.AddWithValue("@posta_zcpr", posta_zcpr);
                            cmd.Parameters.AddWithValue("@naziv_poste_zcpr", naziv_poste_zcpr);
                            cmd.Parameters.AddWithValue("@datom_od_zcpr", datum_od_zcpr);
                            cmd.Parameters.AddWithValue("@status_preb", status_preb);
                            cmd.Parameters.AddWithValue("@stan", stan);
                            cmd.Parameters.AddWithValue("@index_crp", lcaseidxtemp);
                            cmd.Parameters.AddWithValue("@index_crpz", lcaseidxtempz); //lcaseidxtempz
                            cmd.Parameters.AddWithValue("@idx", idxt); //lcaseidxtempz
                            cmd.Parameters.AddWithValue("@zacasno", tzacasno); // 1 ali 0
                            cmd.Parameters.AddWithValue("@stalno", tstalno); //lcaseidxtempz
                            cmd.Parameters.AddWithValue("@na_s", namid_ok);
                            cmd.Parameters.AddWithValue("@na_z", naselje_ok);
                            // cmd.Parameters.AddWithValue("@idx", idxt); //lcaseidxtempz

                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka: " + ex.Message);
                    }
                    // MessageBox.Show("emso " + emso + " spol " + spol + " priimek1 " + priimek1);
                    vrstica = "";
                    stevec = ++stevec;
                    ls.Text = stevec.ToString();
                    ls.Refresh();
                } 
                stevec--;
                ls.Text = stevec.ToString();
                ls.Refresh();
    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka branje: " + ex.Message + priimek1+ime1+dat_roj);
            }
            finally
            {
                rdra.Close();
                cona.Close();// close
            }


        }

        string ulmid_tmp, ulime_tmp, namid_tmp, naime_tmp;
        bool ima_hsmid, v_mestu;

        private void button25_Click(object sender, EventArgs e)
        {
            ls1.Text = countcad.ToString();
            ls1.Refresh();
            ls.Text = "";
            Zdruzi_OM_HS();
            ls.Text = "OK";
            ls.Refresh();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            // Prenos hs za bass
            ls.Text = "";
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = frmMain.pot_podatki;

            open.FileName = "";

            open.Filter = "Ločeno s podpičjem | *.csv";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Prenesi_hs_bass(open.FileName);
                ls.Text = "Ok";
            }
        }

        private void tbl_crpBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_crpBindingSource.EndEdit();
            // this.tableAdapterManager.UpdateAll(this.ds_Kataster);

        }

        string ulica_zcpr = "", hs_zcpr = "", hsd_zcpr = "", posta_zcpr = "", naziv_poste_zcpr = "", status_preb = "", stan = "";

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button14_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            // ijsvo T4 kanalizacija


            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "t4-kanalizacija.csv";

            save.Filter = "Ločeno s podpičjem | *.csv";

            if (save.ShowDialog() == DialogResult.OK)

            {
                try
                {


                    string q = "select * from tbl_aglo where tip_aglo='KAN'"; // preberi vse zapise iz tbl_hise

                    cmd = new SqlCommand(q, con);
                    con.Open();
                    rdr = cmd.ExecuteReader();
                    using (StreamWriter writetext = new StreamWriter(save.FileName))
                    {
                        // glava
                        str_zapisi = "(0) IME AGLO" + csv + "(1) ID AGLO" + csv + "(2) DELEŽ % JAVNO" + csv + "(3) ŠT. PREB-" + csv + "(4) OBREM. GOSPODINJSTVA" + csv + "(5) OBREM. DEJAVNOST" + csv + "(6) OBREM. INDUST." + csv + "(7) DELEŽ OBREMEN." + csv + 
                            "(8) METODA" + csv+ "(9) DELEŽ BREZ ČIŠČ." + csv + "(10) METODA" + csv + "(11) DELEŽ OPREMLJ." + csv + "(12) ŠT. PREB. NA KANAL." + csv + "(13) DELEŽ INDIVID." + csv + "(14) METODA" + csv + "(15) DELEŽ NE V JAVNO" + csv +
                            "(16) METODA" + csv + "(17) KOMENTAR";


                        writetext.WriteLine(str_zapisi, Encoding.UTF8);

                        while (rdr.Read())
                        {
                            // t4 kanalizacija
                            id_aglo = "";
                            ime_aglo = "";
                            delez_v_javno = "";
                            st_preb = "";
                            obrem_gospodinjstva = "";
                            obrem_dejavnost = "";
                            obrem_industrija = "";
                            string delez_obremen_s="";
                            double delez_obremen = 0;
                            delez_priljucenosti = "";
                            metoda = "";
                            delez_nepriljucenosti = "";
                            delez_opremljenosti = "";
                            preb_na_kanal = "";
                            delez_idivid = "";
                            delez_ne_v_javno = "";
                            komentar = "";
                            int preb_temp = 0; 
                            int pisi_preb = 0;
                            double dejav_temp = 0;
                            double skupaj_dejav = 0;
                            double pe_dejav = 0;
                            double ind_temp = 0;
                            double skupaj_ind = 0;
                            double pe_ind = 0;
                            double pe_skupaj = 0;
                            double pe_vkanal = 0;
                            int pe_gospodinjstvo = 0;
                            int pe_gospodinjstvo_kan = 0;
                            double pe_dejav_kan = 0;
                            string delez_povrsine = ""; // 11

                            int stavb = 0;
                            int stavb_kan = 0;
                            int ima_kan = 0;
                            //int stavb = 0;

                            id_aglo = (string)rdr["id_aglo"];
                            ime_aglo = (string)rdr["ime_aglo"];
                            delez_v_javno = "Kataster";

                            // preberi vse stavbe v aglomeraciji

                            try
                            {


                                string q2 = "select * from tbl_hise where idaglo_kan=@idaglo"; // preberi vse zapise iz tbl_hise

                                cmd2 = new SqlCommand(q2, con2);
                                con2.Open();
                                cmd2.Parameters.AddWithValue("@idaglo", id_aglo);
                                rdr2 = cmd2.ExecuteReader();
                                while (rdr2.Read())
                                {
                                    stavb++;
                                    dejav_temp= (double)rdr2["pe_dejav"];
                                    ind_temp = (double)rdr2["pe_posst"];
                                    pe_gospodinjstvo = (int)rdr2["stalno"];
                                    preb_temp = (int)rdr2["stalno"];
                                    ima_kan = (int)rdr2["kanalizacija"];

                                    pisi_preb = pisi_preb + preb_temp;
                                    pe_dejav = pe_dejav + dejav_temp;
                                    pe_ind = pe_ind + ind_temp;

                                    pe_skupaj = pe_skupaj + pe_gospodinjstvo + dejav_temp + ind_temp;

                                    if (ima_kan==1)
                                    {
                                        pe_vkanal = pe_vkanal + pe_gospodinjstvo + dejav_temp + ind_temp;
                                        pe_gospodinjstvo_kan = pe_gospodinjstvo_kan + pe_gospodinjstvo;
                                        pe_dejav_kan = pe_dejav_kan + dejav_temp;
                                        
                                        stavb_kan++;
                                    }
                                } // while reader
                            }
                            catch (Exception ex2)
                            {
                                MessageBox.Show("Napaka reader hiše: " + ex2.Message);
                            }
                            finally
                            {
                                    rdr2.Close();
                                    con2.Close();

                            }
                            
                            if (id_aglo=="3168")
                            {
                                // negova
                                delez_v_javno = "98";
                                delez_povrsine = "98";
                                delez_brez_ciscenja = "0";
                            }
                            if (id_aglo == "50158")
                            {
                                // ščavnica
                                delez_v_javno = "0";
                                delez_povrsine = "0";
                                delez_brez_ciscenja = "0";
                            }
                            if (id_aglo == "3351")
                            {
                                // lomanoše
                                delez_v_javno = "0";
                                delez_povrsine = "0";
                                delez_brez_ciscenja = "0";
                            }
                            if (id_aglo == "3064")
                            {
                                // radgona
                                delez_v_javno = "100";
                                delez_povrsine = "100";
                                delez_brez_ciscenja = "0,5";
                            }

                            st_preb = pisi_preb.ToString();
                            obrem_gospodinjstva = st_preb;

                            obrem_dejavnost = pe_dejav.ToString("F2");
                            obrem_industrija = pe_ind.ToString("F2");

                            delez_obremen = (pe_vkanal * 100) / pe_skupaj;
                            delez_obremen_s = delez_obremen.ToString("F2");
                            double individualno = 100 - delez_obremen;
                            string individualno_s = individualno.ToString("F2");

                            str_zapisi = ime_aglo+csv+id_aglo + csv + delez_v_javno + csv + st_preb + csv + pe_gospodinjstvo_kan + csv + obrem_dejavnost + csv + obrem_industrija + csv + delez_obremen_s + csv + "1" + csv 
                                + delez_brez_ciscenja+csv+"1"+csv+delez_povrsine+csv+pe_gospodinjstvo_kan + csv + individualno_s+csv+ "1" + csv + "0" + csv + "1" + csv + komentar;

                            writetext.WriteLine(str_zapisi, Encoding.UTF8);
                        }
                    }
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("Napaka reader: " + ex2.Message);
                }

                finally
                {
                    // MessageBox.Show("finnaly");
                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                    if (con != null)
                    {
                        con.Close();
                    }
                    MessageBox.Show("Zapis v CSV končan!");
                    //Display_hise();
                }

            }


        }

        private void button16_Click_2(object sender, EventArgs e)
        {

        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            // dodaj MB vodovod
            ls1.Text = counths.ToString();
            ls1.Refresh();
            ls.Text = "";
            OpenFileDialog open = new OpenFileDialog();
            open.FileName = "";

            open.Filter = "Ločeno s podpičjem | *.csv";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Obdelaj_mb_vodovod(open.FileName);
                ls.Text = "Ok";
                ls.Refresh();
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            // prenos aglomeracije kanalizacija
            ls.Text = "";
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = frmMain.pot_podatki;

            open.FileName = "";

            open.Filter = "Ločeno s podpičjem | *.csv";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Obdelaj_aglo_kan(open.FileName);
                ls.Text = "Ok";
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            // prenos porabe vode v bazo
            ls.Text = "";
            OpenFileDialog open = new OpenFileDialog();
            open.FileName = "";

            open.Filter = "Ločeno s podpičjem | *.csv";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Obdelaj_cadis_voda(open.FileName);
                ls.Text = "Ok";
                ls.Refresh();
            }


        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            // prenos porabe nanalščine v bazo
            ls.Text = "";
            OpenFileDialog open = new OpenFileDialog();
            open.FileName = "";

            open.Filter = "Ločeno s podpičjem | *.csv";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Obdelaj_cadis_kan(open.FileName);
                ls.Text = "Ok";
                ls.Refresh();
            }

        }

        string idxtemp, natemp, ultemp, idxtempz;

        private void IzprazniBazo_cad_om()  
        {
            string query = "delete from om";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Izprazni_cad_om() 
        {
            sifra_om = ""; naziv_om = ""; naslov = ""; posta = ""; sifra_okolisa = ""; naziv = ""; hsmid = ""; tip_okol = ""; st_stan = ""; st_clan = "";
            sif_uporab = ""; uporabnik = ""; sif_last = ""; lastnik = ""; sk_obj = ""; naziv_sk_obj = ""; upravljanje = ""; sklad = ""; sk_obj2 = ""; aktiven = "";
            naziv2 = ""; datum_od = ""; datum_do = ""; tip_storitev = ""; sifra_uvoza = ""; stevec_str = "";
        }

        private void Prenesi_cadis_om(string vhod) // prenesi cadis.crp
        {
            // prenos CADIS OM
            {
                // začni prenos
                stevec = 0;
                //string cvodovodstr = "", ckanalizacijastr = "", cgreznicastr = "", csmetistr = "";
                IzprazniBazo_cad_om();
                // preberi ul - CSV
                try
                {
                    System.IO.StreamReader objReader;
                    objReader = new System.IO.StreamReader(vhod, ASCIIEncoding.UTF8);
                    // število vrstic v CSV
                    // ++stevec; // preskoči prvo vrstico
                    do
                    {
                        vrstica = "";
                        Izprazni_cad_om();
                        vrstica = vrstica + objReader.ReadLine() + "\r\n";
                        string[] polje = vrstica.Split(';');

                        sifra_om = polje[0];
                        naziv_om = polje[1];
                        naslov = polje[2];
                        posta = polje[3];
                        sifra_okolisa = polje[4];
                        naziv = polje[5];
                        hsmid = polje[6];
                        tip_okol = polje[7];
                        st_stan = polje[8];
                        st_clan = polje[9];
                        sif_uporab = polje[10];
                        uporabnik = polje[11];
                        sif_last = polje[12];
                        lastnik = polje[13];
                        sk_obj = polje[14];
                        naziv_sk_obj = polje[15];
                        upravljanje = polje[16];
                        sklad = polje[17];
                        sk_obj2 = polje[18];
                        aktiven = polje[19];
                        naziv2 = polje[20];
                        datum_od = polje[21];
                        datum_do = polje[22];
                        tip_storitev = polje[23];
                        sifra_uvoza = polje[24];
                        stevec_str = polje[25];
                        string idx_temp = naslov.ToLower();
                        idx_temp = idx_temp.Replace(" ", "");
                        idx_temp = idx_temp.Replace("č", "cc");
                        idx_temp = idx_temp.Replace("š", "ss");
                        idx_temp = idx_temp.Replace("ž", "zz");

                        try
                        {
                            string query = "Insert into om (sifra_om, naziv_om, naslov, posta, sifra_okolisa, naziv, hsmid, tip_okol, st_stan, st_clan, sif_uporab, uporabnik, sif_last, lastnik, sk_obj, naziv_sk_obj, upravljanje, sklad, sk_obj2, aktiven, naziv2, datum_od, datum_do, tip_storitev, sifra_uvoza,stevec,idx) values " +
                                "(@sifra_om, @naziv_om, @naslov, @posta, @sifra_okolisa, @naziv, @hsmid, @tip_okol, @st_stan, @st_clan, @sif_uporab, @uporabnik, @sif_last, @lastnik, @sk_obj, @naziv_sk_obj, @upravljanje, @sklad, @sk_obj2, @aktiven, @naziv2, @datum_od, @datum_do, @tip_storitev, @sifra_uvoza,@stevec,@idx)";
                            cmd = new SqlCommand(query, con);
                            con.Open();

                            cmd.Parameters.AddWithValue("@sifra_om",sifra_om);
                            cmd.Parameters.AddWithValue("@naziv_om",naziv_om);
                            cmd.Parameters.AddWithValue("@naslov",naslov);
                            cmd.Parameters.AddWithValue("@posta",posta);
                            cmd.Parameters.AddWithValue("@sifra_okolisa",sifra_okolisa);
                            cmd.Parameters.AddWithValue("@naziv",naziv);
                            cmd.Parameters.AddWithValue("@hsmid",hsmid);
                            cmd.Parameters.AddWithValue("@tip_okol",tip_okol);
                            cmd.Parameters.AddWithValue("@st_stan",st_stan);
                            cmd.Parameters.AddWithValue("@st_clan",st_clan);
                            cmd.Parameters.AddWithValue("@sif_uporab",sif_uporab);
                            cmd.Parameters.AddWithValue("@uporabnik",uporabnik);
                            cmd.Parameters.AddWithValue("@sif_last",sif_last);
                            cmd.Parameters.AddWithValue("@lastnik",lastnik);
                            cmd.Parameters.AddWithValue("@sk_obj",sk_obj);
                            cmd.Parameters.AddWithValue("@naziv_sk_obj",naziv_sk_obj);
                            cmd.Parameters.AddWithValue("@upravljanje",upravljanje);
                            cmd.Parameters.AddWithValue("@sklad",sklad);
                            cmd.Parameters.AddWithValue("@sk_obj2",sk_obj2);
                            cmd.Parameters.AddWithValue("@aktiven",aktiven);
                            cmd.Parameters.AddWithValue("@naziv2",naziv2);
                            cmd.Parameters.AddWithValue("@datum_od",datum_od);
                            cmd.Parameters.AddWithValue("@datum_do",datum_do);
                            cmd.Parameters.AddWithValue("@tip_storitev",tip_storitev);
                            cmd.Parameters.AddWithValue("@sifra_uvoza",sifra_uvoza);
                            cmd.Parameters.AddWithValue("@stevec",stevec_str);
                            cmd.Parameters.AddWithValue("@idx", idx_temp);

                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Napaka: " + ex.Message);
                        }
                        stevec = ++stevec;
                        vrstica = "";
                        ls.Text = stevec.ToString();
                        ls.Refresh();
                    } while (objReader.Peek() != -1);
                    objReader.Close();
                    stevec--;
                    ls.Text = stevec.ToString();
                    ls.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: " + ex.Message);
                }
                finally
                {
                    //Displaydata_cad();
                }
            }
        } // private void


        private void IzprazniBazo_hs_bass()
        {
            string query = "delete from hs_bass";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Izprazni_hs_bass()
        {
            hsmid = ""; hs = ""; hd = ""; lab = ""; ulmid = ""; namid = ""; obmid = ""; ptmid = ""; x = ""; y = ""; ptid = ""; ptime = ""; ulid = ""; ulime = ""; naid = ""; naime = ""; gidx = "";
        }

        private void Prenesi_hs_bass(string vhod) // prenesi cadis.crp
        {
            string idx_temp = "";

                stevec = 0;
                IzprazniBazo_hs_bass();
                try
                {
                    System.IO.StreamReader objReader;
                    objReader = new System.IO.StreamReader(vhod, ASCIIEncoding.UTF8);
                    do
                    {
                        vrstica = "";
                        Izprazni_hs_bass();
                        vrstica = vrstica + objReader.ReadLine() + "\r\n";
                        string[] polje = vrstica.Split(';');

                        hsmid = polje[0];
                        hs = polje[1];
                        hd = polje[2];
                        lab = polje[3];
                        ulmid = polje[4];
                        namid = polje[5];
                        obmid = polje[6];
                        ptmid = polje[7];
                        x = polje[8];
                        y = polje[9];
                        ptid = polje[10];
                        ptime = polje[11];
                        ulid = polje[12];
                        ulime = polje[13];
                        naid = polje[14];
                        naime = polje[15];

                        if (ulid=="")
                        {
                            idx_temp = naime;
                        }
                        else
                        {
                            idx_temp = ulime;
                        }
                        idx_temp = idx_temp.Replace(" ", "");
                        idx_temp = idx_temp + lab;
                        idx_temp = idx_temp.ToLower();
                    idx_temp = idx_temp.Replace("č", "cc");
                    idx_temp = idx_temp.Replace("š", "ss");
                    idx_temp = idx_temp.Replace("ž", "zz");
                    
                    StringBuilder sb = new StringBuilder();
                    foreach (char c in idx_temp)
                    {
                        if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                        {
                            sb.Append(c);
                        }
                    }
                    gidx = sb.ToString();

                    //gidx = idx_temp;


                    //gidx = "";

                    try
                    {
                            string query = "Insert into hs_bass (hsmid,hs,hd,lab, ulmid,namid, obmid, ptmid, x,y,ptid, ptime, ulid, ulime, naid, naime,gidx) values " +
                                "(@hsmid,@hs,@hd,@lab, @ulmid,@namid, @obmid, @ptmid, @x,@y,@ptid, @ptime, @ulid, @ulime, @naid, @naime,@gidx)";
                            cmd = new SqlCommand(query, con);
                            con.Open();

                            cmd.Parameters.AddWithValue("@hsmid",hsmid);
                            cmd.Parameters.AddWithValue("@hs",hs);
                            cmd.Parameters.AddWithValue("@hd",hd);
                            cmd.Parameters.AddWithValue("@lab",lab);
                            cmd.Parameters.AddWithValue("@ulmid",ulmid);
                            cmd.Parameters.AddWithValue("@namid",namid);
                            cmd.Parameters.AddWithValue("@obmid",obmid);
                            cmd.Parameters.AddWithValue("@ptmid",ptmid);
                            cmd.Parameters.AddWithValue("@x",x);
                            cmd.Parameters.AddWithValue("@y",y);
                            cmd.Parameters.AddWithValue("@ptid",ptid);
                            cmd.Parameters.AddWithValue("@ptime",ptime);
                            cmd.Parameters.AddWithValue("@ulid",ulid);
                            cmd.Parameters.AddWithValue("@ulime",ulime);
                            cmd.Parameters.AddWithValue("@naid",naid);
                            cmd.Parameters.AddWithValue("@naime",naime);
                            cmd.Parameters.AddWithValue("@gidx",gidx);

                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Napaka: " + ex.Message);
                        }
                        stevec = ++stevec;
                        vrstica = "";
                        ls.Text = stevec.ToString();
                        ls.Refresh();
                    } while (objReader.Peek() != -1);
                    objReader.Close();
                    stevec--;
                    ls.Text = stevec.ToString();
                    ls.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: " + ex.Message);
                }
                finally
                {
                    //Displaydata_cad();
                }
        } // private void


        private void button23_Click(object sender, EventArgs e)
        {
            // prenesi OM iz cadis v SQL bazo om
            ls.Text = "";
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = frmMain.pot_podatki;

            open.FileName = "";

            open.Filter = "Ločeno s podpičjem | *.csv";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Prenesi_cadis_om(open.FileName);
                ls.Text = "Ok";
            }

        }

        private void button22_Click(object sender, EventArgs e)
        {
            // drugi podatki voda

            id_aglo = "";
            ime_aglo = "";
            string id_vs = "1633";
            string pokrit = "";
            int mmgosp = 0;
            int mminst = 0;
            int mmdejav = 0;
            int mmind = 0;
            int mmkmet = 0;
            string prodgosps = "";
            string prodinsts = "";
            string proddejavs = "";
            string prodinds = "";
            string prodanas = "";
            string prodkmets = "";
            double prodgosp = 0;
            double prodinst = 0;
            double proddejav = 0;
            double prodind = 0;
            double prodkmet = 0;
            double prodana = 0;
            double tmp_prod = 0;
            string komentar = "";

            int stavb = 0;
            int stavb_vod = 0;
            int ima_vod = 0;
            int preb = 0;
            int preb_voda = 0;
            int tmp_preb = 0;
            int tmp_preb_voda = 0;
            string tip_prikljucka = "";
            int mmest = 0;
            double pokritd = 0;

            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "IJSVO - drugi podatki voda.csv";

            save.Filter = "Ločeno s podpičjem | *.csv";

            if (save.ShowDialog() == DialogResult.OK)

            {

                using (StreamWriter writetext = new StreamWriter(save.FileName))
                {
                    str_zapisi = "(0) ŠT. OSKRBOVANIH" + csv + "(1) ŠT. PRIKLJUČKOV" + csv + "(2) PRODANA" + csv + "(3) PRODANA GOSP." + csv + "(4) PRODANA INŠT." + csv + "(5) PRODANA KMET." + csv + "(6) PRODANA PODJETJA." + csv + "(7) PREBIVALCEV V HSMID"+csv+"IND";


                    writetext.WriteLine(str_zapisi, Encoding.UTF8);


                    try
                    {


                        string q2 = "select * from tbl_hise"; // preberi vse zapise iz tbl_hise

                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        // cmd2.Parameters.AddWithValue("@idaglo", id_aglo);
                        rdr2 = cmd2.ExecuteReader();
                        while (rdr2.Read())
                        {
                            stavb++;
                            tmp_preb = (int)rdr2["stalno"];
                            ima_vod = (int)rdr2["voda"];
                            tip_prikljucka = (string)rdr2["tip_prikljucka"];
                            tmp_prod = (double)rdr2["poraba_vod"];

                            preb = preb + tmp_preb;


                            if (ima_vod == 1)
                            {
                                if (tip_prikljucka == "1")
                                {
                                    mmgosp++;
                                    prodgosp = prodgosp + tmp_prod;
                                }
                                if (tip_prikljucka == "2")
                                {
                                    mminst++;
                                    prodinst = prodinst + tmp_prod;
                                }
                                if (tip_prikljucka == "3")
                                {
                                    mmdejav++;
                                    proddejav = proddejav + tmp_prod;
                                }
                                if (tip_prikljucka == "4")
                                {
                                    mmind++;
                                    prodind = prodind + tmp_prod;
                                }
                                if (tip_prikljucka == "5")
                                {
                                    mmkmet++;
                                    prodkmet = prodkmet + tmp_prod;
                                }
                                tmp_prod = 0;
                                preb_voda = preb_voda + tmp_preb;
                                mmest++;
                            }
                        } // while reader
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show("Napaka reader hiše: " + ex2.Message);
                    }
                    finally
                    {
                        rdr2.Close();
                        con2.Close();

                    }

                    prodgosps = prodgosp.ToString("F2");
                    prodinds = prodind.ToString("F2");
                    proddejavs = proddejav.ToString("F2");
                    prodinsts = prodinst.ToString("F2");
                    string preb_vodas = preb_voda.ToString();
                    string mmests = mmest.ToString();
                    string prebs = preb.ToString();
                    prodkmets = prodkmet.ToString("F2");

                    str_zapisi = preb_vodas + csv + mmests + csv + prodanas + csv + prodgosps + csv + prodinsts + csv + prodkmets + csv + proddejavs + csv + prebs+csv+prodinds;

                    writetext.WriteLine(str_zapisi, Encoding.UTF8);

                }
                MessageBox.Show("Zapis v CSV končan!");
            }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            // T4 voda - aglomeracije


            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "t4-voda.csv";

            save.Filter = "Ločeno s podpičjem | *.csv";

            if (save.ShowDialog() == DialogResult.OK)

            {
                try
                {


                    string q = "select * from tbl_aglo where tip_aglo='VOD'"; // preberi vse zapise iz tbl_hise

                    cmd = new SqlCommand(q, con);
                    con.Open();
                    rdr = cmd.ExecuteReader();
                    using (StreamWriter writetext = new StreamWriter(save.FileName))
                    {
                        // glava
                        str_zapisi = "(0) IME AGLO" + csv + "(1) ID AGLO" + csv + "(2) ID VS" + csv + "(3) % POKRIT." + csv + "(4) MM GOSP." + csv + "(5) MM INŠT." + csv + "(6) MM DEJAV." + csv + "(7) MM IND." + csv +
                            "(8) PROD. GOSP." + csv + "(9) PROD. INŠT." + csv + "(10) PROD. DEJAV." + csv + "(11) PROD. IND." + csv + "(12) KOMENTAR"+csv+"preb"+csv+"preb voda"+csv+"stavb"+csv+"stavb voda";


                        writetext.WriteLine(str_zapisi, Encoding.UTF8);

                        while (rdr.Read())
                        {
                            // t4 kanalizacija
                            id_aglo = "";
                            ime_aglo = "";
                            string id_vs = "1633";
                            string pokrit = "";
                            int mmgosp = 0;
                            int mminst = 0;
                            int mmdejav = 0;
                            int mmind = 0;
                            string prodgosps = "";
                            string prodinsts = "";
                            string proddejavs = "";
                            string prodinds = "";
                            double prodgosp = 0;
                            double prodinst = 0;
                            double proddejav = 0;
                            double prodind = 0;
                            double tmp_prod = 0;
                            string komentar = "";

                            int stavb = 0;
                            int stavb_vod = 0;
                            int ima_vod = 0;
                            int preb = 0;
                            int preb_voda = 0;
                            int tmp_preb = 0;
                            int tmp_preb_voda = 0;
                            string tip_prikljucka = "";
                            int mmest = 0;
                            double pokritd = 0;

                            id_aglo = (string)rdr["id_aglo2"];
                            ime_aglo = (string)rdr["ime_aglo2"];

                            try
                            {


                                string q2 = "select * from tbl_hise where idaglo_vod=@idaglo"; // preberi vse zapise iz tbl_hise

                                cmd2 = new SqlCommand(q2, con2);
                                con2.Open();
                                cmd2.Parameters.AddWithValue("@idaglo", id_aglo);
                                rdr2 = cmd2.ExecuteReader();
                                while (rdr2.Read())
                                {
                                    stavb++;
                                    tmp_preb = (int)rdr2["stalno"];
                                    ima_vod = (int)rdr2["voda"];
                                    tip_prikljucka = (string)rdr2["tip_prikljucka"];
                                    tmp_prod = (double)rdr2["poraba_vod"];

                                    preb = preb + tmp_preb;


                                    if (ima_vod == 1)
                                    {
                                        if (tip_prikljucka == "1")
                                        {
                                            mmgosp++;
                                            prodgosp = prodgosp + tmp_prod;
                                        }
                                        if (tip_prikljucka == "2")
                                        {
                                            mminst++;
                                            prodinst = prodinst + tmp_prod;
                                        }
                                        if (tip_prikljucka == "3")
                                        {
                                            mmdejav++;
                                            proddejav = proddejav + tmp_prod;
                                        }
                                        if (tip_prikljucka == "4")
                                        {
                                            mmind++;
                                            prodind = prodind + tmp_prod;
                                        }
                                        tmp_prod = 0;
                                        preb_voda = preb_voda + tmp_preb;
                                        mmest++;
                                    }
                                } // while reader
                            }
                            catch (Exception ex2)
                            {
                                MessageBox.Show("Napaka reader hiše: " + ex2.Message);
                            }
                            finally
                            {
                                rdr2.Close();
                                con2.Close();

                            }

                            if (id_aglo == "3168")
                            {
                                // negova
                                komentar = "Upravlja MB vodovod";
                            }

                            //if (id_aglo == "50158")
                            //{
                            //    // ščavnica
                            //    delez_v_javno = "0";
                            //    delez_povrsine = "0";
                            //    delez_brez_ciscenja = "0";
                            //}
                            //if (id_aglo == "3351")
                            //{
                            //    // lomanoše
                            //    delez_v_javno = "0";
                            //    delez_povrsine = "0";
                            //    delez_brez_ciscenja = "0";
                            //}
                            //if (id_aglo == "3064")
                            //{
                            //    // radgona
                            //    delez_v_javno = "100";
                            //    delez_povrsine = "100";
                            //    delez_brez_ciscenja = "0,5";
                            //}

                            pokritd = (preb_voda * 100) / preb;
                            pokrit = pokritd.ToString("F2");

                            prodgosps = prodgosp.ToString("F2");
                            prodinds = prodind.ToString("F2");
                            proddejavs = proddejav.ToString("F2");
                            prodinsts = prodinst.ToString("F2");

                            str_zapisi = ime_aglo + csv + id_aglo + csv + id_vs + csv + pokrit + csv + mmgosp + csv + mminst + csv + mmdejav + csv + mmind + csv + prodgosps + csv
                                + prodinsts + csv + proddejavs + csv + prodinds + csv + komentar+csv+preb+csv+preb_voda+csv+stavb+csv+mmest;

                            writetext.WriteLine(str_zapisi, Encoding.UTF8);
                        }
                    }
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("Napaka reader: " + ex2.Message);
                }

                finally
                {
                    // MessageBox.Show("finnaly");
                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                    if (con != null)
                    {
                        con.Close();
                    }
                    MessageBox.Show("Zapis v CSV končan!");
                    //Display_hise();
                }

            }

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            // ijsvo T2 kanalizacija
            // izvozi datoteko stavbe v CSV

            string cid="",c_nas="",c_lab="",c_naslov="",c_kanal = "", c_grez = "", c_aglo = "", c_at1 = "", c_at2 = "", c_at3 = "", c_at4 = "",cpedej = "", cpepos = "", ckmgmid = "", ckmet = "", cpredvidena = "", cdatpred = "", cagloid = "", copombe = "", c_imecad = "" ,c_omcad = "";

            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "t2-kanalizacija.csv";

            save.Filter = "Ločeno s podpičjem | *.csv";

            if (save.ShowDialog() == DialogResult.OK)

            {
                try
                {


                    string q = "select * from tbl_hise"; // preberi vse zapise iz tbl_hise

                    cmd = new SqlCommand(q, con);
                    con.Open();
                    rdr = cmd.ExecuteReader();
                    using (StreamWriter writetext = new StreamWriter(save.FileName))
                    {
                        // glava
                        str_zapisi = "ID"+csv+"IME CADIS" +csv+ "NASLOV"+csv+"OM CADIS"+csv+ "HSMID" + csv + "X" + csv + "Y" + csv + "OBLIKA IJS" + csv + "ATR1"+ csv + "ATR2" + csv + "ATR3" + csv + "ATR4" +csv + "PE Dejavnost" + csv+ "PE Posst" + csv+ "Upor kmet" + csv+ "KMGMID" + csv+ "IJS predvidena" + csv+ "Datum predv." + csv+ "AGLO ID" + csv+ "Opombe" + csv + "PE gosp";
                        writetext.WriteLine(str_zapisi, Encoding.UTF8);

                        while (rdr.Read())
                        {
                            cid = ""; c_kanal = ""; c_grez = ""; c_aglo = ""; c_at1 = ""; c_at2 = ""; c_at3 = ""; c_at4 = ""; cpedej = ""; cpepos = ""; ckmgmid = ""; ckmet = ""; cpredvidena = ""; cdatpred = ""; cagloid = ""; copombe = ""; c_imecad = ""; c_omcad = "";
                            c_at1 = "";
                            c_at2 = "";
                            c_aglo = "";
                            str_zapisi = "";
                            cid= Convert.ToString((int)rdr["id"]);
                            c_hsmid = (string)rdr["hsmid"];
                            c_x = Convert.ToString((double)rdr["x"]);
                            c_y = Convert.ToString((double)rdr["y"]);
                            c_oblika = (string)rdr["oblika_ijs"];
                            c_grez = Convert.ToString((int)rdr["greznica"]);
                            c_kanal = Convert.ToString((int)rdr["kanalizacija"]);
                            //c_tip = (string)rdr["tip_prikljucka"];
                            //c_id_vs = (string)rdr["id_vs"];
                            c_imecad = (string)rdr["ime_cadis"];
                            c_omcad = (string)rdr["tipom_cadis"];
                            c_upravljanje = (string)rdr["upravljanje_prikljucka"];
                            c_nas = (string)rdr["naslov"];
                            c_lab = (string)rdr["labela"];
                            c_naslov = c_nas + " " + c_lab;
                            double pepos = (double)rdr["pe_posst"];
                            double pedej = (double)rdr["pe_dejav"];

                            cpepos = pepos.ToString("F2");
                            cpedej = pedej.ToString("F2");
                            string cstalno = Convert.ToString((int)rdr["stalno"]);
                            
                            if (rdr["idaglo_kan"] != DBNull.Value)
                                c_aglo = (string)rdr["idaglo_kan"]; 
                            else
                                c_aglo = "-1";

                            c_at4 = "";
                            c_oblika = "NEZNAN";
                            c_at3 = "";                            
                            if (c_kanal.Equals("1"))
                            {
                                c_oblika = "KANAL";
                                
                                // radgona
                                c_at3 = "10905";
                                c_at4 = "3488";
                                if (c_aglo.Equals("3168"))
                                // negova
                                {
                                    c_at3 = "10906";
                                    c_at4 = "2530";
                                }
                            }
                            if (c_grez.Equals("1"))
                            {
                                c_oblika = "GREZ_P";
                                c_at4 = "3488";
                                if (c_aglo.Equals("3168"))
                                // negova
                                {
                                    c_at4 = "2530";
                                }
                            }
                            if (c_imecad.Length >20)
                            {
                                c_imecad = c_imecad.Substring(0, 19)
;                            }

                            if (c_omcad.Contains("KMETIJSTVO"))
                                {
                                    ckmet = "DA";
                                }
                            if (c_aglo.Length>1)
                            {
                                if (!c_oblika.Equals("KANAL"))
                                {
                                    cpredvidena = "KANAL";
                                    cdatpred = "31.12.2023";
                                }
                            }
                            if (c_oblika.Equals("NEZNAN"))
                                copombe = "NIMAMO PODATKOV";
                            // string za zapis
                            str_zapisi = cid+csv+c_imecad+csv+c_naslov+ csv+c_omcad+csv+c_hsmid + csv + c_x + csv + c_y + csv + c_oblika + csv + c_at1 + csv + c_at2 + csv + c_at3 + csv + c_at4 + csv+ cpedej + csv + cpepos+csv+ckmet+csv+ckmgmid+csv+cpredvidena+csv+cdatpred+csv+c_aglo+csv+ copombe + csv + cstalno;
                            writetext.WriteLine(str_zapisi, Encoding.UTF8);
                            // writetext.WriteLine(str_zapisi);
                        }
                    }
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("Napaka reader: " + ex2.Message);
                }

                finally
                {
                    // MessageBox.Show("finnaly");
                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                    if (con != null)
                    {
                        con.Close();
                    }
                    MessageBox.Show("Zapis v CSV končan!");
                    //Display_hise();
                }

            }

        }


        public void WriteSample()
        {
            //Excel.Application excelApp = new Excel.Application();
            //if (excelApp != null)
            //{
            //    Excel.Workbook excelWorkbook = excelApp.Workbooks.Add();
            //    Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelWorkbook.Sheets.Add();

            //    excelWorksheet.Cells[1, 1] = "Value1";
            //    excelWorksheet.Cells[2, 1] = "Value2";
            //    excelWorksheet.Cells[3, 1] = "Value3";
            //    excelWorksheet.Cells[4, 1] = "Value4";

            //    excelApp.ActiveWorkbook.SaveAs(@"C:\abc.xls", Excel.XlFileFormat.xlWorkbookNormal);

            //    excelWorkbook.Close();
            //    excelApp.Quit();

            //    System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excelWorksheet);
            //    System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excelWorkbook);
            //    System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excelApp);
            //    GC.Collect();
            //    GC.WaitForPendingFinalizers();
            //}
        }

        private void button16_Click_3(object sender, EventArgs e)
        {
            // prenesi aglomeracije voda
            ls.Text = "";
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = frmMain.pot_podatki;

            open.FileName = "";

            open.Filter = "Ločeno s podpičjem | *.csv";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Obdelaj_aglo_vod(open.FileName);
                ls.Text = "Ok";
            }
        }

        private void button14_Click_2(object sender, EventArgs e)
        {
            // prenos aglomeracije kanalizacija
            IzprazniBazo_ag();
            ls.Text = "";
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = frmMain.pot_podatki;

            open.FileName = "";

            open.Filter = "Ločeno s podpičjem | *.csv";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Obdelaj_aglo_kan(open.FileName);
                ls.Text = "Ok";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // prenesi aglomeracije voda
            ls.Text = "";
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = frmMain.pot_podatki;

            open.FileName = "";

            open.Filter = "Ločeno s podpičjem | *.csv";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Obdelaj_aglo_vod(open.FileName);
                ls.Text = "Ok";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ls1.Text = counths.ToString();
            ls1.Refresh();
            ls.Text = "";
            OpenFileDialog open = new OpenFileDialog();
            open.FileName = "";

            open.Filter = "Ločeno s podpičjem | *.csv";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Obdelaj_aglo(open.FileName);
                ls.Text = "Ok";
                ls.Refresh();
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            string cid = "", c_nas = "", c_lab = "", c_naslov = "", c_kanal = "", c_grez = "", c_aglo = "", c_at1 = "", c_at2 = "", c_at3 = "", c_at4 = "", cpedej = "", cpepos = "", ckmgmid = "", ckmet = "", cpredvidena = "", cdatpred = "", cagloid = "", copombe = "", c_imecad = "", c_omcad = "";
            // ijsvo T2 voda
            // izvozi datoteko stavbe v CSV

            //string path = "c:\\Kataster\\hise.csv";

            //File.Create(path).Close();

            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "t2-voda.csv";

            save.Filter = "Ločeno s podpičjem | *.csv";

            if (save.ShowDialog() == DialogResult.OK)

            {
                try
                {


                    string q = "select * from tbl_hise"; // preberi vse zapise iz tbl_hise

                    cmd = new SqlCommand(q, con);
                    con.Open();
                    rdr = cmd.ExecuteReader();
                    using (StreamWriter writetext = new StreamWriter(save.FileName))
                    {
                        // glava
                        str_zapisi = "ID" + csv + "IME CADIS" + csv + "NASLOV" + csv + "OM CADIS" + csv + "HSMID" + csv + "X" + csv + "Y" + csv + "OBLIKA IJS" + csv + "TIP PRIKLJUČKA" + csv + "ID VS" + csv + "UPRAVLJANJE";
                        writetext.WriteLine(str_zapisi, Encoding.UTF8);

                        while (rdr.Read())
                        {
                            cid = ""; c_kanal = ""; c_grez = ""; c_aglo = ""; c_at1 = ""; c_at2 = ""; c_at3 = ""; c_at4 = ""; cpedej = ""; cpepos = ""; ckmgmid = ""; ckmet = ""; cpredvidena = ""; cdatpred = ""; cagloid = ""; copombe = ""; c_imecad = ""; c_omcad = "";
                            str_zapisi = "";
                            c_hsmid = (string)rdr["hsmid"];
                            c_x = Convert.ToString((double)rdr["x"]);
                            c_y = Convert.ToString((double)rdr["y"]);
                            c_oblika = (string)rdr["oblika_ijs"];
                            c_tip =  (string)rdr["tip_prikljucka"];
                            c_id_vs = (string)rdr["id_vs"]; 
                            c_upravljanje = (string)rdr["upravljanje_prikljucka"];
                            c_imecad = (string)rdr["ime_cadis"];
                            c_omcad = (string)rdr["tipom_cadis"];
                            cid = Convert.ToString((int)rdr["id"]);
                            c_nas = (string)rdr["naslov"];
                            c_lab = (string)rdr["labela"];
                            c_naslov = c_nas + " " + c_lab;

                            //if (c_nas.Contains("Negova"))
                            //{
                            //    c_oblika="Negoa"
                            //}



                            // string za zapis
                            str_zapisi = cid + csv + c_imecad + csv + c_naslov + csv + c_omcad + csv + c_hsmid + csv + c_x + csv + c_y + csv + c_oblika + csv + c_tip + csv + c_id_vs + csv + c_upravljanje;
                            writetext.WriteLine(str_zapisi, Encoding.UTF8);
                        }
                    }
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("Napaka reader: " + ex2.Message);
                }

                finally
                {
                    // MessageBox.Show("finnaly");
                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                    if (con != null)
                    {
                        con.Close();
                    }
                    MessageBox.Show("Zapis v CSV končan!");
                    //Display_hise();
                }

            }
        }

    

    private void button16_Click_1(object sender, EventArgs e)
        {
            //frmBaze_last secondForm = new frmBaze_last();
            //secondForm.ShowDialog();
        }

        private void btnHs_Click(object sender, EventArgs e)
        {

        }

        private void Obdelaj_aglo(string fnameag)
        {

            string pisi_idaglo_vod = "";
            string pisi_imeaglo_vod = "";
            string pisi_idaglo_kan = "";
            string pisi_imeaglo_kan = "";

            
            string q = "UPDATE tbl_hise SET idaglo_vod = -1, idaglo_kan=-1,imeaglo_vod='',imeaglo_kan=''";
            cmd2 = new SqlCommand(q, con2);
            con2.Open();
            cmd2.ExecuteNonQuery();
            con2.Close();


            // začni prenos
            stevec = 0;
            //IzprazniBazo_ag();
            try
            {
                System.IO.StreamReader objReader;
                objReader = new System.IO.StreamReader(fnameag, ASCIIEncoding.UTF8);
                do
                {
                    vrstica = "";
                    //Izprazni_ag();
                    vrstica = vrstica + objReader.ReadLine() + "\r\n";

                    // razdeli vrstico ločeno s ;
                    string[] polje = vrstica.Split(';');
                    string idaglo_kan = polje[16];
                    string imeaglo_kan = polje[17];
                    string idaglo_vod = polje[18];
                    string imeaglo_vod = polje[19];
                    string hsmid_aglo = polje[2];
                    if (idaglo_kan == null)
                        idaglo_kan = "0";
                    //pt_mid = polje[2];
                    try
                    {
                        if (stevec > 0)
                        {

                            // napiši aglomeracije v tabelo hise
                            try
                            {

                                // ali obstaja hs_mid v tabeli hise?
                                string q2 = "select hsmid from tbl_hise where hsmid = @idx"; 
                                cmd2 = new SqlCommand(q2, con2);
                                con2.Open();
                                cmd2.Parameters.AddWithValue("@idx", hsmid_aglo);
                                cmd2.ExecuteNonQuery();
                                string ok_hsmid = (string)cmd2.ExecuteScalar(); 
                                if (ok_hsmid == null)
                                {
                                    pisi_idaglo_vod = "-99";
                                    pisi_imeaglo_vod = "";
                                    pisi_idaglo_kan = "-99";
                                    pisi_imeaglo_kan = "";
                                }
                                else
                                {
                                    pisi_idaglo_vod = idaglo_vod;
                                    pisi_imeaglo_vod = imeaglo_vod;
                                    pisi_idaglo_kan = idaglo_kan;
                                    pisi_imeaglo_kan = imeaglo_kan;
                                }
                                con2.Close();

                                q2 = "update tbl_hise set idaglo_vod = @idaglo_vod, imeaglo_vod = @imeaglo_vod,idaglo_kan = @idaglo_kan, imeaglo_kan = @imeaglo_kan where hsmid=@idx";
                                // MessageBox.Show("Ta hsmid bo zapisal v tbl_hs " + ok_hsmid);
                                cmd2 = new SqlCommand(q2, con2);
                                con2.Open();
                                cmd2.Parameters.AddWithValue("@idaglo_kan", pisi_idaglo_kan);
                                cmd2.Parameters.AddWithValue("@imeaglo_kan", pisi_imeaglo_kan);
                                cmd2.Parameters.AddWithValue("@idaglo_vod", pisi_idaglo_vod);
                                cmd2.Parameters.AddWithValue("@imeaglo_vod", pisi_imeaglo_vod);
                                cmd2.Parameters.AddWithValue("@idx", hsmid_aglo);
                                cmd2.ExecuteNonQuery();
                                con2.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Napakaupdate aglomeracija: " + ex.Message);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka: " + ex.Message);
                    }
                    stevec = ++stevec;
                    vrstica = "";
                    ls.Text = stevec.ToString();
                    ls.Refresh();
                } while (objReader.Peek() != -1);
                objReader.Close();
                stevec--;
                //label52.Text = stevec.ToString();
                //label52.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka - aglomeracije: " + ex.Message);
            }
            finally
            {
               // DisplayData_pt();
            }

        }


        private void Obdelaj_aglo_bass(string fnameag)
        {

            string pisi_idaglo_vod = "";
            string pisi_imeaglo_vod = "";
            string pisi_idaglo_kan = "";
            string pisi_imeaglo_kan = "";


            string q = "UPDATE om SET gaglo_vod = '', gaglo_kan=''";
            cmd2 = new SqlCommand(q, con2);
            con2.Open();
            cmd2.ExecuteNonQuery();
            con2.Close();


            // začni prenos
            stevec = 0;
            //IzprazniBazo_ag();
            try
            {
                System.IO.StreamReader objReader;
                objReader = new System.IO.StreamReader(fnameag, ASCIIEncoding.UTF8);
                do
                {
                    vrstica = "";
                    //Izprazni_ag();
                    vrstica = vrstica + objReader.ReadLine() + "\r\n";

                    // razdeli vrstico ločeno s ;
                    string[] polje = vrstica.Split(';');
                    string idaglo_kan = polje[16];
                    string imeaglo_kan = polje[17];
                    string idaglo_vod = polje[18];
                    string imeaglo_vod = polje[19];
                    string hsmid_aglo = polje[2];
                    if (idaglo_kan == null)
                        idaglo_kan = "";
                    if (idaglo_kan == "0")
                        idaglo_kan = "";
                    if (idaglo_vod == "0")
                        idaglo_vod = "";
                    //pt_mid = polje[2];
                    try
                    {
                            try
                            {
                                string q2 = "select ghsmid from om where ghsmid = @idx";
                                cmd2 = new SqlCommand(q2, con2);
                                con2.Open();
                                cmd2.Parameters.AddWithValue("@idx", hsmid_aglo);
                                cmd2.ExecuteNonQuery();
                                string ok_hsmid = (string)cmd2.ExecuteScalar();
                                if (ok_hsmid == null)
                                {
                                    pisi_idaglo_vod = "-99";
                                    pisi_idaglo_kan = "-99";
                                }
                                else
                                {
                                    pisi_idaglo_vod = idaglo_vod;
                                    pisi_idaglo_kan = idaglo_kan;
                                }
                                con2.Close();

                                q2 = "update om set gaglo_vod = @idaglo_vod, gaglo_kan = @idaglo_kan where ghsmid=@idx";
                                // MessageBox.Show("Ta hsmid bo zapisal v tbl_hs " + ok_hsmid);
                                cmd2 = new SqlCommand(q2, con2);
                                con2.Open();
                                cmd2.Parameters.AddWithValue("@idaglo_kan", pisi_idaglo_kan);
                                cmd2.Parameters.AddWithValue("@idaglo_vod", pisi_idaglo_vod);
                                cmd2.Parameters.AddWithValue("@idx", hsmid_aglo);
                                cmd2.ExecuteNonQuery();
                                con2.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Napakaupdate aglomeracija: " + ex.Message);
                            }
                        }
                    
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka: " + ex.Message);
                    }
                    stevec = ++stevec;
                    vrstica = "";
                    ls.Text = stevec.ToString();
                    ls.Refresh();
                } while (objReader.Peek() != -1);
                objReader.Close();
                stevec--;
                //label52.Text = stevec.ToString();
                //label52.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka - aglomeracije: " + ex.Message);
            }
            finally
            {
            }

        }

        private void Obdelaj_cadis_voda(string fnameag)
        {

            
            string q2 = "";

            // daj porabo na nulo
            q2 = "UPDATE tbl_hise SET poraba_vod = 0";
            cmd2 = new SqlCommand(q2, con2);
            con2.Open();
            cmd2.ExecuteNonQuery();
            con2.Close();


            stevec = 0;
            try
            {
                System.IO.StreamReader objReader;
                objReader = new System.IO.StreamReader(fnameag, ASCIIEncoding.UTF8);
                do
                {
                    poraba = 0; stara_poraba = 0;
                    vrstica = "";
                    vrstica = vrstica + objReader.ReadLine() + "\r\n";

                    // razdeli vrstico ločeno s ;
                    string[] polje = vrstica.Split(';');
                    string hsmid_cad = polje[0];
                    double poraba_cad = Convert.ToDouble(polje[3]);

                    try
                    {
                            // ali obstaja hs_mid v tabeli hise?
                            q2 = "select hsmid from tbl_hise where hsmid = @idx";
                            cmd2 = new SqlCommand(q2, con2);
                            con2.Open();
                            cmd2.Parameters.AddWithValue("@idx", hsmid_cad);
                            cmd2.ExecuteNonQuery();
                            string ok_hsmid = (string)cmd2.ExecuteScalar();
                            con2.Close();

                            if (ok_hsmid != null)
                            {
                                // samo če hsmid obstaja vpiši porabo    

                                // preberi staro porabo
                                q2 = "select poraba_vod from tbl_hise where hsmid = @idx";
                                cmd2 = new SqlCommand(q2, con2);
                                con2.Open();
                                cmd2.Parameters.AddWithValue("@idx", hsmid_cad);
                                cmd2.ExecuteNonQuery();
                                
                            
                                object porabaobj = cmd2.ExecuteScalar();
                            if (!porabaobj.Equals(DBNull.Value))
                                stara_poraba = Convert.ToDouble(porabaobj);
                            else
                                stara_poraba = 0;
                                
                            con2.Close();

                                // prištej porabo k obstoječi
                                poraba = stara_poraba + poraba_cad;
                            if (poraba < 0)
                                poraba = 0;
                                // zapiši porabo
                                q2 = "update tbl_hise set poraba_vod = @poraba_vod where hsmid=@idx";
                                cmd2 = new SqlCommand(q2, con2);
                                con2.Open();
                                cmd2.Parameters.AddWithValue("@poraba_vod", poraba);
                                cmd2.Parameters.AddWithValue("@idx", hsmid_cad);
                                cmd2.ExecuteNonQuery();
                                con2.Close();
                            }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka: " + ex.Message);
                    }
                    stevec = ++stevec;
                    vrstica = "";
                    ls.Text = stevec.ToString();
                    ls.Refresh();
                } while (objReader.Peek() != -1);
                objReader.Close();
                stevec--;
                //label52.Text = stevec.ToString();
                //label52.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: " + ex.Message);
            }
            finally
            {
                // DisplayData_pt();
            }

        }

        private void Obdelaj_cadis_kan(string fnameag)
        {

            string q2 = "";

            // daj porabo in pe na nulo
            q2 = "UPDATE tbl_hise SET poraba_kan = 0,pe_posst=0,pe_dejav=0";
            cmd2 = new SqlCommand(q2, con2);
            con2.Open();
            cmd2.ExecuteNonQuery();
            con2.Close();

            stevec = 0;
            try
            {
                System.IO.StreamReader objReader;
                objReader = new System.IO.StreamReader(fnameag, ASCIIEncoding.UTF8);
                do
                {
                    poraba = 0; stara_poraba = 0;
                    vrstica = "";
                    vrstica = vrstica + objReader.ReadLine() + "\r\n";

                    // razdeli vrstico ločeno s ;
                    string[] polje = vrstica.Split(';');
                    string hsmid_cad = polje[0];
                    double poraba_cad = Convert.ToDouble(polje[3]);

                    try
                    {
                        // ali obstaja hs_mid v tabeli hise?
                        q2 = "select hsmid from tbl_hise where hsmid = @idx";
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@idx", hsmid_cad);
                        cmd2.ExecuteNonQuery();
                        string ok_hsmid = (string)cmd2.ExecuteScalar();
                        con2.Close();

                        if (ok_hsmid != null)
                        {
                            // samo če hsmid obstaja vpiši porabo    

                            // preberi staro porabo
                            q2 = "select poraba_kan from tbl_hise where hsmid = @idx";
                            cmd2 = new SqlCommand(q2, con2);
                            con2.Open();
                            cmd2.Parameters.AddWithValue("@idx", hsmid_cad);
                            cmd2.ExecuteNonQuery();


                            object porabaobj = cmd2.ExecuteScalar();
                            if (!porabaobj.Equals(DBNull.Value))
                                stara_poraba = Convert.ToDouble(porabaobj);
                            else
                                stara_poraba = 0;

                            // določi PE


                            con2.Close();

                            // prištej porabo k obstoječi
                            poraba = stara_poraba + poraba_cad;
                            if (poraba < 0)
                                poraba = 0;

                            // zapiši porabo
                            q2 = "update tbl_hise set poraba_kan = @poraba_kan where hsmid=@idx";
                            cmd2 = new SqlCommand(q2, con2);
                            con2.Open();
                            cmd2.Parameters.AddWithValue("@poraba_kan", poraba);
                            cmd2.Parameters.AddWithValue("@idx", hsmid_cad);
                            cmd2.ExecuteNonQuery();
                            con2.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka: " + ex.Message);
                    }
                    stevec = ++stevec;
                    vrstica = "";
                    ls.Text = stevec.ToString();
                    ls.Refresh();
                } while (objReader.Peek() != -1);
                objReader.Close();
                stevec--;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: " + ex.Message);
            }
            // izračunaj PE
            try
            {
                string q = "select id,tip_prikljucka, poraba_kan, poraba_vod from tbl_hise";
                cmd = new SqlCommand(q, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string tip_prikljucka = (String)rdr["tip_prikljucka"]; 
                    int id = (int)rdr["id"];
                    double poraba_k = (double)rdr["poraba_kan"];
                    double poraba_v = (double)rdr["poraba_vod"];

                    if (poraba_k > poraba_v)
                        poraba = poraba_k;
                    else
                        poraba = poraba_v;
                    
                    // izračunaj PE
                    double pe_dejav = 0; 
                    double pe_posst=0;

                    if (tip_prikljucka == "1")
                    {
                        pe_dejav = 0;
                        pe_posst = 0;
                    }

                    if (tip_prikljucka == "2" | tip_prikljucka == "3")
                    {
                        pe_dejav = poraba * 1000;
                        pe_dejav = pe_dejav / 54750;
                        pe_posst = 0;
                    }

                    if (tip_prikljucka == "4")
                    {
                        pe_dejav = 0;
                        pe_posst = poraba * 1000;
                        pe_posst = pe_posst / 54750;
                    }



                    // zapiši pe
                    q2 = "update tbl_hise set pe_dejav = @pe_dejav, pe_posst = @pe_posst where id=@idx";
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@pe_dejav", pe_dejav);
                    cmd2.Parameters.AddWithValue("@pe_posst",pe_posst);
                    cmd2.Parameters.AddWithValue("@idx", id);
                    cmd2.ExecuteNonQuery();
                    con2.Close();

                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Napaka reader določi PE: " + ex2.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }

        }

        private void Obdelaj_mb_vodovod(string fnameag)
        {

            int mb_vodovod=3;
            string c_opomba="";
            int vodovod = 0;

            // začni prenos
            stevec = 0;
            //IzprazniBazo_ag();
            try
            {
                System.IO.StreamReader objReader;
                objReader = new System.IO.StreamReader(fnameag, ASCIIEncoding.UTF8);
                do
                {
                    mb_vodovod = 3;
                    vrstica = "";
                    //Izprazni_ag();
                    vrstica = vrstica + objReader.ReadLine() + "\r\n";

                    // razdeli vrstico ločeno s ;
                    string[] polje = vrstica.Split(';');
                    string hsmid_mb = polje[1];

                    string q2 = "select hsmid from tbl_hise where hsmid = @idx";
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@idx", hsmid_mb);
                    cmd2.ExecuteNonQuery();
                    string ok_hsmid = (string)cmd2.ExecuteScalar();
                    con2.Close();

                    if (ok_hsmid != null)
                    {
                        // napiši MB v tabelo hise
                        try
                        {
                            q2 = "select voda,oblika_ijs,id_vs, opomba from tbl_hise where hsmid = @idx";
                            cmd2 = new SqlCommand(q2, con2);
                            con2.Open();
                            cmd2.Parameters.AddWithValue("@idx", hsmid_mb);
                            rdr2 = cmd2.ExecuteReader();

                            while (rdr2.Read())
                            {
                                c_opomba = "MB vodovod";
                                vodovod = (int)rdr2["voda"];
                                c_oblika = (string)rdr2["oblika_ijs"];
                                c_id_vs = (string)rdr2["id_vs"];
                                //string ok_hsmid = (string)cmd2.ExecuteScalar();
                            }
                            if (vodovod == 1)
                            {
                                mb_vodovod = vodovod;
                            }
                            else
                            {
                                // mb vodovod = true
                                mb_vodovod = 3;
                                c_oblika = "JAV";
                                c_id_vs = "1171";

                            }
                                con2.Close();

                                q2 = "update tbl_hise set voda = @vodovod, oblika_ijs = @oblika, id_vs = @vs, opomba=@opomba where hsmid=@idx";
                                // MessageBox.Show("Ta hsmid bo zapisal v tbl_hs " + ok_hsmid);
                                cmd2 = new SqlCommand(q2, con2);
                                con2.Open();
                                cmd2.Parameters.AddWithValue("@vodovod", mb_vodovod);
                            cmd2.Parameters.AddWithValue("@oblika", c_oblika);
                            cmd2.Parameters.AddWithValue("@vs", c_id_vs);
                            cmd2.Parameters.AddWithValue("@opomba", c_opomba);
                            cmd2.Parameters.AddWithValue("@idx", hsmid_mb);
                                cmd2.ExecuteNonQuery();
                                con2.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Napaka update MB vodovod: " + stevec.ToString() + " " + ex.Message);
                            }

                        
                    }
                    stevec = ++stevec;
                    vrstica = "";
                    ls.Text = stevec.ToString();
                    ls.Refresh();
                } while (objReader.Peek() != -1);
                objReader.Close();
                stevec--;
                //label52.Text = stevec.ToString();
                //label52.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka - aglomeracije: " + ex.Message);
            }
            finally
            {
                // DisplayData_pt();
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            //// zapiši Aglomeracije v tbl_hise
            //fd.Title = "Izberi datoteko s podatki o aglomeracijah";
            //fd.InitialDirectory = frmMain.app_path_data;  // "C:\\KatApp\\Kataster\\data";
            //fd.FileName = "aglo.csv";

            //// preberi ime datoteke iz dialoga
            //if (fd.ShowDialog() == DialogResult.OK)
            //{
            //    // preberi CRP - CSV
            //    try
            //    {
            //        fnamecrp = fd.FileName;
            //        var lineCount = File.ReadAllLines(@fnamecrp).Length;
            //        // label2.Text = fnamecrp;
            //        // label24.Text = lineCount.ToString();
            //        //Obdelaj_aglo();
            //        ncrp = 0;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Napaka: " + ex.Message);
            //        ncrp = 1;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Datoteka ne obstaja: " + fnamecrp);

            //}

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        string dat_roj = "", datum_od_zcpr = "";

        // variable tbl_hs
        string index_hs = "", enota = "", hs_mid = "", hs = "", hd = "", labela = "", ulmid = "", na_mid = "", ob_mid = "", pt_mid = "", po_mid = "", y = "", x = "";

        
        private void exportToExcel(System.Data.DataTable dt)  // data table v excel
        {
            /*Set up work book, work sheets, and excel application*/
            Microsoft.Office.Interop.Excel.Application oexcel = new Microsoft.Office.Interop.Excel.Application();
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory;
                object misValue = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Excel.Workbook obook = oexcel.Workbooks.Add(misValue);
                Microsoft.Office.Interop.Excel.Worksheet osheet = new Microsoft.Office.Interop.Excel.Worksheet();


                //  obook.Worksheets.Add(misValue);

                osheet = (Microsoft.Office.Interop.Excel.Worksheet)obook.Sheets["Sheet1"];
                int colIndex = 0;
                int rowIndex = 1;

                foreach (DataColumn dc in dt.Columns)
                {
                    colIndex++;
                    osheet.Cells[1, colIndex] = dc.ColumnName;
                }
                foreach (DataRow dr in dt.Rows)
                {
                    rowIndex++;
                    colIndex = 0;

                    foreach (DataColumn dc in dt.Columns)
                    {
                        colIndex++;
                        osheet.Cells[rowIndex, colIndex] = dr[dc.ColumnName];
                    }
                }

                osheet.Columns.AutoFit();
                string filepath = "C:\\Temp\\Book1";

                //Release and terminate excel

                obook.SaveAs(filepath);
                obook.Close();
                oexcel.Quit();

                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Name);
                oexcel.Quit();
            }
            finally
            {

            }
        }
        
        private void btnIzvoz_Click(object sender, EventArgs e)
        {
            // dodano shranjevanje v excel - 01 2022
            var pot = "c:\\kataster\\Geodata D96\\Kora\\hise.xlsx";

                using (var da = new SqlDataAdapter("select * from tbl_hise", con))
                {
                    da.Fill(dtable);
                }

                var workbook = new ExcelFile();
                var worksheet = workbook.Worksheets.Add("Stavbe");

                worksheet.InsertDataTable(dtable,
                    new InsertDataTableOptions()
                    {
                        ColumnHeaders = true,
                        StartRow = 0
                    });

                try
                {
                    workbook.Save(pot);
                    MessageBox.Show("Zapisana datoteka: " + pot);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka pri pisanju v Excel", ex.Message);
                }
        }

        private void Manjkavcadis()
        {
            
            
            // Stavbe ki manjkajo v Cadis
            con.Open();
            System.Data.DataTable dt = new System.Data.DataTable();
            adapt = new SqlDataAdapter("select * from tbl_hise where cadis = 0", con);
            int tmpcadis = 0;
            adapt.Fill(dt);
            dgv1.DataSource = dt;
            con.Close();
            ls.Text = dgv1.Rows.Count.ToString();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            ls1.Text = "";
            ls.Text = "";

            Manjkavcadis();
        }

        private void Obdelaj_sql()
        {
            // obdelaj vse sql baze
            if (countcrp > 0 && counths > 0 && countul > 0 && countna > 0 && countcad > 0)
            {
                Hsmid_crp();
                Beri_hs();
                Cadis_v_stavbe();
                Manjkavcadis();
            }
            else
                MessageBox.Show("Napaka v eno od SQL datotek!");

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Obdelaj_sql();
        }

        private void Cadis_v_stavbe()  // staro do 01-2022 pred Bass
        {
            int st = 0;
            string q2;
            string q3;
            string thsmid, tindex_crp, ok_hsmid,tvodovodstr;
            Int32 tkanalizacija = 0, tgreznica = 0, tsmeti = 0;
            Int32 tvodovod = 0;
            int tid;

            try
            {
                string q = "select id,hsmid,voda,kanalizacija,smeti from tbl_hise"; // preberi vse zapise iz tbl_hise

                cmd = new SqlCommand(q, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                string hsmid_hs;
                nivcadis = 0;
                while (rdr.Read())
                {
                    toblika_ijs = "NEZ";ttip_prikljucka = "-99";tid_vs = "-99";tupravljanje_prikljucka = "-99";
                    hsmid_hs = (string)rdr["hsmid"]; // hsmid po katerem boš iskal v cadis
                    tid = (Int32)rdr["id"];  // določi id v katerega boš pisal
                    try
                    {
                        cadis = 1;
                        string tmp_hsmid;
                        // preveri katere stavbe so sploh v cadisu
                        q2 = "select hsmid from tbl_cad where hsmid = @thsmid";  // če sta indexa iz ulic enaka
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@thsmid", hsmid_hs);
                        cmd2.ExecuteNonQuery();
                        tmp_hsmid = (string)cmd2.ExecuteScalar();
                        con2.Close();
                        if (tmp_hsmid==null)
                        {
                            tmp_hsmid = "99";
                            cadis = 0;
                            nivcadis++;
                        }

                        // poišči hsmid iz tbl_hise v tbl_cad
                        tkanalizacija = 0; tvodovod = 0; tgreznica = 0; tsmeti = 0; ttip_om="" ;
                        q2 = "select vodovod from tbl_cad where hsmid = @thsmid";  // če sta indexa iz ulic enaka
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@thsmid", hsmid_hs);
                        cmd2.ExecuteNonQuery();
                        tvodovod = Convert.ToInt32(cmd2.ExecuteScalar());
                        con2.Close();

                        // ijsvo
                        if (tvodovod == 1)
                        {
                            toblika_ijs = "JAV";
                            tid_vs = "1633";
                            tupravljanje_prikljucka = "1";
                        }
                        else
                        {
                            toblika_ijs = "DRUG";
                            tid_vs = "99";
                            tupravljanje_prikljucka = "0";
                        }




                        q2 = "select kanalizacija from tbl_cad where hsmid = @thsmid";  // če sta indexa iz ulic enaka
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@thsmid", hsmid_hs);
                        cmd2.ExecuteNonQuery();
                        tkanalizacija = Convert.ToInt32(cmd2.ExecuteScalar());
                        con2.Close();

                        q2 = "select greznica from tbl_cad where hsmid = @thsmid";  // če sta indexa iz ulic enaka
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@thsmid", hsmid_hs);
                        cmd2.ExecuteNonQuery();
                        tgreznica = Convert.ToInt32(cmd2.ExecuteScalar());
                        con2.Close();

                        q2 = "select smeti from tbl_cad where hsmid = @thsmid";  // če sta indexa iz ulic enaka
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@thsmid", hsmid_hs);
                        cmd2.ExecuteNonQuery();
                        tsmeti = Convert.ToInt32(cmd2.ExecuteScalar());
                        con2.Close();

                        q2 = "select tip_om from tbl_cad where hsmid = @thsmid";  // če sta indexa iz ulic enaka
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@thsmid", hsmid_hs);
                        cmd2.ExecuteNonQuery();
                        ttip_om = Convert.ToString(cmd2.ExecuteScalar());
                        con2.Close();

                        q2 = "select naziv from tbl_cad where hsmid = @thsmid";  // če sta indexa iz ulic enaka
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@thsmid", hsmid_hs);
                        cmd2.ExecuteNonQuery();
                        time_cadis = Convert.ToString(cmd2.ExecuteScalar());
                        con2.Close();

                        time_cadis = time_cadis.Replace("\u0022", "");
                        ttip_om = ttip_om.Replace("\u0022", "");

                        // ZA IJSVO
                        ttip_prikljucka = "";
                        if (ttip_om.Contains("GOSPODINJSTVO"))
                            ttip_prikljucka = "1";
                        if (ttip_om.Contains("GOSPODARSTVO"))
                            ttip_prikljucka = "3";
                        if (ttip_om.Contains("NEGOSPODARSTVO"))
                            ttip_prikljucka = "2";
                        if (ttip_om.Contains("POSEBNE"))
                            ttip_prikljucka = "4";
                        if (ttip_om.Contains("KMETIJSTVO"))
                            ttip_prikljucka = "2";
                        if (ttip_om.Equals(""))
                            toblika_ijs = "NEZ";
                        
                        //MessageBox.Show("tu");

                        // zapiši najdene vrednosti v datoteko tbl_hise - update

                        q3 = "update tbl_hise set cadis = @tcadis, voda = @tvodovod, kanalizacija = @tkanalizacija, greznica = @tgreznica, smeti = @tsmeti, oblika_ijs = @toblika_ijs" +
                            ", tip_prikljucka=@ttip_prikljucka,id_vs=@tid_vs,upravljanje_prikljucka=@upravljanje,tipom_cadis=@tipom_cadis,ime_cadis=@ime_cadis  where id=@tid";
                        cmd3 = new SqlCommand(q3, con3);
                        con3.Open();
                        cmd3.Parameters.AddWithValue("@tcadis", cadis);
                        cmd3.Parameters.AddWithValue("@tvodovod", tvodovod);
                        cmd3.Parameters.AddWithValue("@tkanalizacija", tkanalizacija);
                        cmd3.Parameters.AddWithValue("@tgreznica", tgreznica);
                        cmd3.Parameters.AddWithValue("@tsmeti", tsmeti);
                        cmd3.Parameters.AddWithValue("@toblika_ijs", toblika_ijs);
                        cmd3.Parameters.AddWithValue("@ttip_prikljucka", ttip_prikljucka);
                        cmd3.Parameters.AddWithValue("@tid_vs", tid_vs);
                        cmd3.Parameters.AddWithValue("@upravljanje", tupravljanje_prikljucka);
                        cmd3.Parameters.AddWithValue("@tid", tid);
                        cmd3.Parameters.AddWithValue("@tipom_cadis", ttip_om);
                        cmd3.Parameters.AddWithValue("@ime_cadis", time_cadis);
                        cmd3.ExecuteNonQuery();
                        con3.Close();

                        //q3 = "update tbl_hise set voda = @tvodovod where id=@tid";
                        //cmd3 = new SqlCommand(q3, con3);
                        //con3.Open();
                        //cmd3.Parameters.AddWithValue("@tvodovod", tvodovod);
                        //cmd3.Parameters.AddWithValue("@tid", tid);
                        //cmd3.ExecuteNonQuery();
                        //con3.Close();

                        //q3 = "update tbl_hise set kanalizacija = @tkanalizacija where id=@tid";
                        //cmd3 = new SqlCommand(q3, con3);
                        //con3.Open();
                        //cmd3.Parameters.AddWithValue("@tkanalizacija", tkanalizacija);
                        //cmd3.Parameters.AddWithValue("@tid", tid);
                        //cmd3.ExecuteNonQuery();
                        //con3.Close();

                        //q3 = "update tbl_hise set greznica = @tgreznica where id=@tid";
                        //cmd3 = new SqlCommand(q3, con3);
                        //con3.Open();
                        //cmd3.Parameters.AddWithValue("@tgreznica", tgreznica);
                        //cmd3.Parameters.AddWithValue("@tid", tid);
                        //cmd3.ExecuteNonQuery();
                        //con3.Close();

                        //q3 = "update tbl_hise set smeti = @tsmeti where id=@tid";
                        //cmd3 = new SqlCommand(q3, con3);
                        //con3.Open();
                        //cmd3.Parameters.AddWithValue("@tsmeti", tsmeti);
                        //cmd3.Parameters.AddWithValue("@tid", tid);
                        //cmd3.ExecuteNonQuery();
                        //con3.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka: " + ex.Message);
                    }
                    st = ++st;
                    ls.Text = st.ToString();
                    ls.Refresh();
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Napaka reader: " + ex2.Message);
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
                Display_hise();
            }
        }  // void

        private void Bass_v_stavbe()  // novo od 01-2022 prehod na Bass
        {
            int st = 0;
            string q2;
            string q3;
            string thsmid, tindex_crp, ok_hsmid, tvodovodstr;
            Int32 tkanalizacija = 0, tgreznica = 0, tsmeti = 0;
            Int32 tvodovod = 0;
            int tid;

            try
            {
                string q = "select id,hsmid,voda,kanalizacija,smeti from tbl_hise"; // preberi vse zapise iz tbl_hise

                cmd = new SqlCommand(q, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                string hsmid_hs;
                nivcadis = 0;
                while (rdr.Read())
                {
                    toblika_ijs = "NEZ"; ttip_prikljucka = "-99"; tid_vs = "-99"; tupravljanje_prikljucka = "-99";
                    hsmid_hs = (string)rdr["hsmid"]; // hsmid po katerem boš iskal v bass
                    tid = (Int32)rdr["id"];  // določi id v katerega boš pisal
                    try
                    {
                        cadis = 1;
                        string tmp_hsmid;
                        // preveri katere stavbe so sploh v cadisu
                        q2 = "select hsmid from tbl_bass where hsmid = @thsmid";  // če sta indexa iz ulic enaka
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@thsmid", hsmid_hs);
                        cmd2.ExecuteNonQuery();
                        tmp_hsmid = (string)cmd2.ExecuteScalar();
                        con2.Close();
                        if (tmp_hsmid == null)
                        {
                            tmp_hsmid = "99";
                            cadis = 0;
                            nivcadis++;
                        }

                        // poišči hsmid iz tbl_hise v tbl_cad
                        tkanalizacija = 0; tvodovod = 0; tgreznica = 0; tsmeti = 0; ttip_om = "";
                        q2 = "select vodovod from tbl_bass where hsmid = @thsmid";  // če sta indexa iz ulic enaka
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@thsmid", hsmid_hs);
                        cmd2.ExecuteNonQuery();
                        tvodovod = Convert.ToInt32(cmd2.ExecuteScalar());
                        con2.Close();

                        // ijsvo
                        if (tvodovod == 1)
                        {
                            toblika_ijs = "JAV";
                            tid_vs = "1633";
                            tupravljanje_prikljucka = "1";
                        }
                        else
                        {
                            toblika_ijs = "DRUG";
                            tid_vs = "99";
                            tupravljanje_prikljucka = "0";
                        }




                        q2 = "select kanalizacija from tbl_bass where hsmid = @thsmid";  // če sta indexa iz ulic enaka
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@thsmid", hsmid_hs);
                        cmd2.ExecuteNonQuery();
                        tkanalizacija = Convert.ToInt32(cmd2.ExecuteScalar());
                        con2.Close();

                        q2 = "select greznica from tbl_bass where hsmid = @thsmid";  // če sta indexa iz ulic enaka
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@thsmid", hsmid_hs);
                        cmd2.ExecuteNonQuery();
                        tgreznica = Convert.ToInt32(cmd2.ExecuteScalar());
                        con2.Close();

                        q2 = "select smeti from tbl_bass where hsmid = @thsmid";  // če sta indexa iz ulic enaka
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@thsmid", hsmid_hs);
                        cmd2.ExecuteNonQuery();
                        tsmeti = Convert.ToInt32(cmd2.ExecuteScalar());
                        con2.Close();

                        q2 = "select tip_om from tbl_bass where hsmid = @thsmid";  // če sta indexa iz ulic enaka
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@thsmid", hsmid_hs);
                        cmd2.ExecuteNonQuery();
                        ttip_om = Convert.ToString(cmd2.ExecuteScalar());
                        con2.Close();

                        q2 = "select naziv from tbl_bass where hsmid = @thsmid";  // če sta indexa iz ulic enaka
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@thsmid", hsmid_hs);
                        cmd2.ExecuteNonQuery();
                        time_cadis = Convert.ToString(cmd2.ExecuteScalar());
                        con2.Close();

                        time_cadis = time_cadis.Replace("\u0022", "");
                        ttip_om = ttip_om.Replace("\u0022", "");

                        // ZA IJSVO
                        ttip_prikljucka = "";
                        if (ttip_om.Contains("GOSPODINJSTVO"))
                            ttip_prikljucka = "1";
                        if (ttip_om.Contains("GOSPODARSTVO"))
                            ttip_prikljucka = "3";
                        if (ttip_om.Contains("NEGOSPODARSTVO"))
                            ttip_prikljucka = "2";
                        if (ttip_om.Contains("POSEBNE"))
                            ttip_prikljucka = "4";
                        if (ttip_om.Contains("KMETIJSTVO"))
                            ttip_prikljucka = "2";
                        if (ttip_om.Equals(""))
                            toblika_ijs = "NEZ";

                        //MessageBox.Show("tu");

                        // zapiši najdene vrednosti v datoteko tbl_hise - update

                        q3 = "update tbl_hise set cadis = @tcadis, voda = @tvodovod, kanalizacija = @tkanalizacija, greznica = @tgreznica, smeti = @tsmeti, oblika_ijs = @toblika_ijs" +
                            ", tip_prikljucka=@ttip_prikljucka,id_vs=@tid_vs,upravljanje_prikljucka=@upravljanje,tipom_cadis=@tipom_cadis,ime_cadis=@ime_cadis  where id=@tid";
                        cmd3 = new SqlCommand(q3, con3);
                        con3.Open();
                        cmd3.Parameters.AddWithValue("@tcadis", cadis);
                        cmd3.Parameters.AddWithValue("@tvodovod", tvodovod);
                        cmd3.Parameters.AddWithValue("@tkanalizacija", tkanalizacija);
                        cmd3.Parameters.AddWithValue("@tgreznica", tgreznica);
                        cmd3.Parameters.AddWithValue("@tsmeti", tsmeti);
                        cmd3.Parameters.AddWithValue("@toblika_ijs", toblika_ijs);
                        cmd3.Parameters.AddWithValue("@ttip_prikljucka", ttip_prikljucka);
                        cmd3.Parameters.AddWithValue("@tid_vs", tid_vs);
                        cmd3.Parameters.AddWithValue("@upravljanje", tupravljanje_prikljucka);
                        cmd3.Parameters.AddWithValue("@tid", tid);
                        cmd3.Parameters.AddWithValue("@tipom_cadis", ttip_om);
                        cmd3.Parameters.AddWithValue("@ime_cadis", time_cadis);
                        cmd3.ExecuteNonQuery();
                        con3.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka: " + ex.Message);
                    }
                    st = ++st;
                    ls.Text = st.ToString();
                    ls.Refresh();
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Napaka reader: " + ex2.Message);
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
                Display_hise();
            }
        }  // void


        private void button13_Click(object sender, EventArgs e)
        {
            ls1.Text = countcad.ToString();
            ls1.Refresh();
            ls.Text = "";
            Bass_v_stavbe();
            ls.Text = "OK";
            ls.Refresh();
        }

        private void Zdruzi_OM_HS()
            // Bass
        {
            int st = 0;
            string q2;
            string q3;
            int tid;
            string namid_t, ptmid_t, ptime_t, ulime_t, naime_t, ulid_t, naid_t, ulmid_t;

            try
            {
                string q = "select * from om"; // preberi vse zapise iz tbl_hise

                cmd = new SqlCommand(q, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                string idx_tmp, naslov_tmp;
                while (rdr.Read())
                {
                    idx_tmp = (string)rdr["idx"]; // hsmid po katerem boš iskal v HS
                    tid = (Int32)rdr["id"];  // določi id v katerega boš pisal
                    naslov_tmp = (string)rdr["naslov"];

                    try
                    {

                        //string tmp_hsmid;
                        ima_hsmid = false;
                        hsmid = ""; hs = ""; hd = ""; lab = ""; ulmid = ""; namid = ""; obmid = ""; ptmid = ""; x = ""; y = ""; ptid = ""; ptime = ""; ulid = ""; ulime = ""; naid = ""; naime = ""; gidx = "";
                        q2 = "select * from hs_bass where gidx = @gindex";  // če sta indexa iz ulic enaka
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@gindex", idx_tmp);
                        rdr2 = cmd2.ExecuteReader();
                        // string idx_tmp;
                        while (rdr2.Read())
                        {
                            ima_hsmid = true;
                            hsmid = (string)rdr2["hsmid"];
                            hs = (string)rdr2["hs"];
                            hd = (string)rdr2["hd"];
                            lab = (string)rdr2["lab"];
                            ulmid = (string)rdr2["ulmid"];
                            namid = (string)rdr2["namid"];
                            obmid = (string)rdr2["obmid"];
                            ptmid = (string)rdr2["ptmid"];
                            x = (string)rdr2["x"];
                            y = (string)rdr2["y"];
                            ptid = (string)rdr2["ptid"];
                            ptime = (string)rdr2["ptime"];
                            ulid = (string)rdr2["ulid"];
                            ulime = (string)rdr2["ulime"];
                            naid = (string)rdr2["naid"];
                            naime = (string)rdr2["naime"];
                            string idx_bass = (string)rdr2["gidx"];

                            q3 = "update om set gidx = @gixd,ghsmid = @ghsmid, ghs = @ghs, ghd = @ghd, glab = @glab, gulmid = @gulmid, gnamid = @gnamid, gobmid = @gobmid, gptmid = @gptmid, gy = @gy, gx = @gx, gptid = @gptid, gptime = @gptime, gulid = @gulid, gulime = @gulime, gnaid = @gnaid, gnaime = @gnaime " +
                            "where id=@tid";
                            cmd3 = new SqlCommand(q3, con3);
                            con3.Open();
                            cmd3.Parameters.AddWithValue("@tid", tid);
                            cmd3.Parameters.AddWithValue("@gixd", idx_bass);
                            cmd3.Parameters.AddWithValue("@ghsmid", hsmid);
                            cmd3.Parameters.AddWithValue("@ghs", hs);
                            cmd3.Parameters.AddWithValue("@ghd", hd);
                            cmd3.Parameters.AddWithValue("@glab", lab);
                            cmd3.Parameters.AddWithValue("@gulmid", ulmid);
                            cmd3.Parameters.AddWithValue("@gnamid", namid);
                            cmd3.Parameters.AddWithValue("@gobmid", obmid);
                            cmd3.Parameters.AddWithValue("@gptmid", ptmid);
                            cmd3.Parameters.AddWithValue("@gy", y);
                            cmd3.Parameters.AddWithValue("@gx", x);
                            cmd3.Parameters.AddWithValue("@gptid", ptid);
                            cmd3.Parameters.AddWithValue("@gptime", ptime);
                            cmd3.Parameters.AddWithValue("@gulid", ulid);
                            cmd3.Parameters.AddWithValue("@gulime", ulime);
                            cmd3.Parameters.AddWithValue("@gnaid", naid);
                            cmd3.Parameters.AddWithValue("@gnaime", naime);
                            cmd3.ExecuteNonQuery();
                            con3.Close();
                        }
                        con2.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka: " + ex.Message);
                    }

                    if (ima_hsmid==false)
                    {
                        
                        naslov_tmp = naslov_tmp.ToLower();
                        // če nima hsmid najdi vsaj ulico in kraj

                        // najprej preveri ulice, če je v mestu
                        q2 = "select * from tbl_ul";
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        rdr2 = cmd2.ExecuteReader();
                        v_mestu = false;
                        while (rdr2.Read())
                        {
                            ulmid_tmp = (string)rdr2["ul_mid"];
                            ulime_tmp = (string)rdr2["ul_uime"];
                            //ulime_tmp = ulime_tmp.ToLower();
                            string tul = ulime_tmp.ToLower();
                            if (naslov_tmp.Contains(tul))
                            {
                                v_mestu = true;
                                ulmid = ulmid_tmp;
                                ulime = ulime_tmp;

                                // najdi ostale lokacijske podatke
                                q3 = "select * from hs_bass where ulmid=@ulmid";
                                cmd3 = new SqlCommand(q3, con3);
                                con3.Open();
                                cmd3.Parameters.AddWithValue("@ulmid", ulmid);
                                rdr3 = cmd3.ExecuteReader();
                                while (rdr3.Read())
                                {
                                    namid = (string)rdr3["ulmid"];
                                    ptmid = (string)rdr3["ptmid"];
                                    naime = (string)rdr3["naime"];
                                    ptime = (string)rdr3["ptime"];
                                    obmid = (string)rdr3["obmid"];
                                    ptid = (string)rdr3["ptid"];
                                    ulid = (string)rdr3["ulid"];
                                    naid = (string)rdr3["naid"];
                                }
                                con3.Close();
                            }
                        }
                        con2.Close();

                        if (v_mestu==false)
                        {
                            // poišči naselje
                            q2 = "select * from tbl_na";
                            cmd2 = new SqlCommand(q2, con2);
                            con2.Open();
                            rdr2 = cmd2.ExecuteReader();
                            while (rdr2.Read())
                            {
                                namid_tmp = (string)rdr2["na_mid"];
                                naime_tmp = (string)rdr2["na_uime"];
                                //ulime_tmp = ulime_tmp.ToLower();
                                string tna = naime_tmp.ToLower();
                                if (naslov_tmp.Contains(tna))
                                {
                                    //v_mestu = true;
                                    namid = namid_tmp;
                                    naime = naime_tmp;

                                    // najdi ostale lokacijske podatke
                                    q3 = "select * from hs_bass where namid=@namid";
                                    cmd3 = new SqlCommand(q3, con3);
                                    con3.Open();
                                    cmd3.Parameters.AddWithValue("@namid", namid);
                                    rdr3 = cmd3.ExecuteReader();
                                    while (rdr3.Read())
                                    {
                                        namid = (string)rdr3["ulmid"];
                                        ptmid = (string)rdr3["ptmid"];
                                        naime = (string)rdr3["naime"];
                                        ptime = (string)rdr3["ptime"];
                                        obmid = (string)rdr3["obmid"];
                                        ptid = (string)rdr3["ptid"];
                                        ulid = (string)rdr3["ulid"];
                                        naid = (string)rdr3["naid"];
                                        ulmid = (string)rdr3["ulmid"];
                                    }
                                    con3.Close();
                                }
                            }
                            con2.Close();


                            //ulmid = "Nima";
                            //ulime = "Nima imena";
                        }


                        q3 = "update om set gidx = @gixd,ghsmid = @ghsmid, ghs = @ghs, ghd = @ghd, glab = @glab, gulmid = @gulmid, gnamid = @gnamid, gobmid = @gobmid, gptmid = @gptmid, gy = @gy, gx = @gx, gptid = @gptid, gptime = @gptime, gulid = @gulid, gulime = @gulime, gnaid = @gnaid, gnaime = @gnaime " +
                        "where id=@tid";
                        cmd3 = new SqlCommand(q3, con3);
                        con3.Open();
                        cmd3.Parameters.AddWithValue("@tid", tid);
                        cmd3.Parameters.AddWithValue("@gixd", "Nima HS_MID");
                        cmd3.Parameters.AddWithValue("@ghsmid", "99");
                        cmd3.Parameters.AddWithValue("@ghs", "");
                        cmd3.Parameters.AddWithValue("@ghd", "");
                        cmd3.Parameters.AddWithValue("@glab", "");
                        cmd3.Parameters.AddWithValue("@gulmid", ulmid);
                        cmd3.Parameters.AddWithValue("@gnamid", namid);
                        cmd3.Parameters.AddWithValue("@gobmid", obmid);
                        cmd3.Parameters.AddWithValue("@gptmid", ptmid);
                        cmd3.Parameters.AddWithValue("@gy", "");
                        cmd3.Parameters.AddWithValue("@gx","");
                        cmd3.Parameters.AddWithValue("@gptid", ptid);
                        cmd3.Parameters.AddWithValue("@gptime", ptime);
                        cmd3.Parameters.AddWithValue("@gulid", ulid);
                        cmd3.Parameters.AddWithValue("@gulime", ulime);
                        cmd3.Parameters.AddWithValue("@gnaid", naid);
                        cmd3.Parameters.AddWithValue("@gnaime", naime);
                        cmd3.ExecuteNonQuery();
                        con3.Close();

                    }
                    ima_hsmid = false;
                    st = ++st;
                    ls.Text = st.ToString();
                    ls.Refresh();
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Napaka reader: " + ex2.Message);
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
                Display_hise();
            }
        }  // void



        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Hsmid_crp()  // zapiši HSMID vsaki osebi v CRP
        {
            // HSMID -> CRP
            int st = 0, brezstavbe = 0;
            //string ls = "";
            string q2;
           // SqlConnection con2 = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\KatApp\\Kataster\\data\\kataster.mdf;Integrated Security = True; Connect Timeout = 30");
          //  SqlCommand cmd2;

            //SqlDataAdapter adapt;
            //SqlDataReader rdr2 = null;
            string thsmid, tindex_crp, ok_hsmid,ok_namid;
            int tid;
            try
            {
                string q = "select id, index_crp,idx, hsmid from tbl_crp"; // preberi vse zapise iz tbl_crp

                cmd = new SqlCommand(q, con);
                con.Open();
                rdr2 = cmd.ExecuteReader();

                while (rdr2.Read())
                {
                    tid = (Int32)rdr2["id"];  // določi id v katerega boš pisal
                    string tidx_crp = "";
                    ok_hsmid = ""; ok_namid = "";
                    if (String.IsNullOrEmpty((string)rdr2["idx"]))
                    {
                        MessageBox.Show("String = null " + st.ToString());
                    }
                    else
                    {
                        tidx_crp = (string)rdr2["idx"];
                        //  MessageBox.Show("prebrani index iz CRP "+tidx_crp);
                    }
                    try
                    {
                        
                        // poišči index_crp v datoteki tbl_hs - index_hs
                        q2 = "select hs_mid, index_hs from tbl_hs where index_hs = @idx";  // če sta indexa iz ulic enaka
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@idx", tidx_crp);
                        cmd2.ExecuteNonQuery();
                        ok_hsmid = (string)cmd2.ExecuteScalar();  // ta hsmid zapiši v datoteko crp
                        // MessageBox.Show("Ta hsmid je našel v tbl_hs " + ok_hsmid);
                        if (ok_hsmid == null)
                        {
                            //MessageBox.Show("hsmid ne obstaja");
                            ok_hsmid = "99";
                            brezstavbe++;
                        }
                        else
                        {
                            //   MessageBox.Show("hsmid je ok");
                        }
                        con2.Close();

                        // poišči na_mid v datoteki tbl_hs
                        q2 = "select na_mid, index_hs from tbl_hs where index_hs = @idx";  // če sta indexa iz ulic enaka
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@idx", tidx_crp);
                        cmd2.ExecuteNonQuery();
                        ok_namid = (string)cmd2.ExecuteScalar();  // ta hsmid zapiši v datoteko crp
                       // MessageBox.Show("Ta na_mid je našel v tbl_hs " + ok_namid);
                        if (ok_namid == null)
                        {
                            //MessageBox.Show("hsmid ne obstaja");
                            ok_namid = "99";
                        }
                        con2.Close();
                        q2 = "update tbl_crp set hsmid = @thsmid, hs_na = @ths_na where id=@tid";
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@thsmid", ok_hsmid);
                        cmd2.Parameters.AddWithValue("@ths_na", ok_namid);
                        cmd2.Parameters.AddWithValue("@tid", tid);
                        cmd2.ExecuteNonQuery();
                        con2.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka22: " + ex.Message);
                    }
                    st = ++st;
                    ls.Text = st.ToString();
                    ls.Refresh();
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Napaka reader: " + ex2.Message);
            }

            finally
            {
                // MessageBox.Show("finnaly");
                if (rdr2 != null)
                {
                    rdr2.Close();
                }
                if (con != null)
                {
                    con.Close();
                }
                
                // MessageBox.Show("pred displaydata");
                DisplayData_crp2();
                //MessageBox.Show("Prebivalcev brez določene stavbe: " + Convert.ToString(brezstavbe));
            }
            ls.Text = "OK";
        }  // void

        private void IzprazniBazo_cad()  // izprazni tabelo tbl_cad
        {
            string query = "delete from tbl_cad";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void IzprazniBazo_bass()  // izprazni tabelo tbl_cad
        {
            string query = "delete from tbl_bass";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Izprazni_cad() // izprazni variable za tabelo tbl_ul
        {
            csmeti = 0; chsmid = ""; cnaziv = "";ckraj = "";culica = "";chs = "";cposta = "";cime_poste = "";cvodovod = 0;ckanalizacija = 0;cgreznica = 0;cdim = "";ctip_om = ""; 
        }

        private void Prenesi_cadis(string vhod) // prenesi cadis.crp
        {
            // prenos CADIS

            {
                    // začni prenos
                    stevec = 0;
                    string cvodovodstr = "", ckanalizacijastr="", cgreznicastr="",csmetistr= "";
                    IzprazniBazo_cad();
                    // preberi ul - CSV
                    try
                    {
                        System.IO.StreamReader objReader;
                        objReader = new System.IO.StreamReader(vhod, ASCIIEncoding.UTF8);
                        // število vrstic v CSV
                        // ++stevec; // preskoči prvo vrstico
                        do
                        {
                            vrstica = "";
                            Izprazni_cad();
                            vrstica = vrstica + objReader.ReadLine() + "\r\n";
                            //vrstica = "";
                            // razdeli vrstico ločeno s ;
                            string[] polje = vrstica.Split(';');
                            chsmid = polje[0];
                            cnaziv = polje[1];
                            ckraj = polje[2];
                            culica = polje[3];
                            chs = polje[4];
                            cposta = polje[5];
                            cime_poste = polje[6];
                            cvodovodstr = polje[7];
                            ckanalizacijastr = polje[8];
                            cgreznicastr = polje[9];
                            csmetistr = polje[10];
                            //cvodovod = 1;ckanalizacija = 1;cgreznica = 1;csmeti = 1;
                            cdim = polje[11];
                            ctip_om = polje[12];
                            //source = source.Substring(0, length);
                            int dolzina = 999; // največja dolžina naziva
                            if (cnaziv.Length > dolzina)
                            {
                                cnaziv = cnaziv.Substring(0, 9);
                            }
                            try
                            {
                                if (stevec > 0)
                                {
                                    cvodovod = Int32.Parse(cvodovodstr);
                                    ckanalizacija = Int32.Parse(ckanalizacijastr);
                                    csmeti = Int32.Parse(csmetistr);
                                    cgreznica = Int32.Parse(cgreznicastr);
                                    // napiši prebrano v tabelo tbl_cad
                                    string query = "Insert into tbl_cad (hsmid,naziv,kraj,ulica,hs,posta,ime_poste,vodovod,kanalizacija,greznica,smeti,dimenzija,tip_om) values " +
                                        "(@chsmid,@cnaziv,@ckraj,@culica,@chs,@cposta,@cime_poste,@cvodovod,@ckanalizacija,@cgreznica,@csmeti,@cdimenzija,@ctip_om)";
                                    cmd = new SqlCommand(query, con);
                                    con.Open();
                                    cmd.Parameters.AddWithValue("@chsmid", chsmid);
                                    cmd.Parameters.AddWithValue("@cnaziv", cnaziv);
                                    cmd.Parameters.AddWithValue("@ckraj", ckraj);
                                    cmd.Parameters.AddWithValue("@culica",culica );
                                    cmd.Parameters.AddWithValue("@chs",chs );
                                    cmd.Parameters.AddWithValue("@cposta",cposta );
                                    cmd.Parameters.AddWithValue("@cime_poste",cime_poste );
                                    cmd.Parameters.AddWithValue("@cvodovod", cvodovod);
                                    cmd.Parameters.AddWithValue("@ckanalizacija", ckanalizacija);
                                    cmd.Parameters.AddWithValue("@cgreznica", cgreznica);
                                    cmd.Parameters.AddWithValue("@csmeti", csmeti);
                                    cmd.Parameters.AddWithValue("@cdimenzija",cdim );
                                    cmd.Parameters.AddWithValue("@ctip_om",ctip_om );
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Napaka: " + ex.Message);
                            }
                            stevec = ++stevec;
                            vrstica = "";
                            ls.Text = stevec.ToString();
                            ls.Refresh();
                        } while (objReader.Peek() != -1);
                        objReader.Close();
                        stevec--;
                        ls.Text = stevec.ToString();
                        ls.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka1: " + ex.Message);
                    }
                    finally
                    {
                        Displaydata_cad();
                    }
            }
        } // private void

        private void Prenesi_Bass_dt() // prenos bass z data table
        {

        }

        private void Prenesi_Bass()
        {


            // prenos Bass
            int tna_mid = 0; 
            string tulmid = "";
            string ths = "";
            string thsd = "";
            string idxom = "";

            {
                // začni prenos
                stevec = 0;
                string cvodovodstr = "", ckanalizacijastr = "", cgreznicastr = "", csmetistr = "";
                IzprazniBazo_bass();
                // preberi ul - CSV
                try
                {
                    // beri vsa odjemna mesta
                    // najprej prenesi samo odjemna mesta, potem dodaj še HSMID, če ga ni vzelo iz bass-a

                    string q = "select om,om_naziv,om_hsmid,kraj_sk_sifra,ulica_sifra,om_hs,om_hsd from inkasso_2021_om_radgona where om_aktiven='T'";
                    cmdb = new MySqlCommand(q, conb);
                    conb.Open();
                    
                    rdrb = cmdb.ExecuteReader();
                    while (rdrb.Read())
                    {
                        //if (stevec < 101) // začasno
                        //{
                            Izprazni_cad();

                            idxom = (string)rdrb["om"];
                            int tmphsmid = (Int32)rdrb["om_hsmid"];
                            if (tmphsmid < 10000000)
                                tmphsmid = 99;
                            chsmid = Convert.ToString(tmphsmid);

                            if (rdrb["om_naziv"] != DBNull.Value)
                                cnaziv = (string)rdrb["om_naziv"];
                            else
                                cnaziv = "-1";


                            // kraj
                            // preberi ime naselja

                            if (rdrb["kraj_sk_sifra"] != DBNull.Value)
                                tna_mid = (Int32)rdrb["kraj_sk_sifra"];
                            else
                                tna_mid = -1;

                            string naime = "";
                            string q2 = "select na_uime from tbl_na where na_mid = @tna_mid";
                            cmd2 = new SqlCommand(q2, con2);
                            con2.Open();
                            cmd2.Parameters.AddWithValue("@tna_mid", tna_mid.ToString()); // preberi ulico
                            cmd2.ExecuteNonQuery();
                            ckraj = (string)cmd2.ExecuteScalar();
                            if (ckraj == null)
                            {
                                ckraj = "N/A";
                            }
                            con2.Close();

                            // preberi ime ulice

                            if (rdrb["ulica_sifra"] != DBNull.Value)
                                tna_mid = (Int32)rdrb["ulica_sifra"];
                            else
                                tna_mid = -1;

                            string ime = "", ulime = "";
                            q2 = "select ul_uime from tbl_ul where ul_mid = @tulmid";
                            cmd2 = new SqlCommand(q2, con2);
                            con2.Open();
                            cmd2.Parameters.AddWithValue("@tulmid", tna_mid.ToString()); // preberi ulico
                            cmd2.ExecuteNonQuery();
                            ulime = (string)cmd2.ExecuteScalar();
                            if (ulime == null)
                            {
                                ulime = ckraj;
                            }
                            con2.Close();
                            culica = ulime;

                            // hišna številka
                            if (rdrb["om_hs"] != DBNull.Value)
                                ths = (string)rdrb["om_hs"];
                            else
                                ths = "";

                            if (rdrb["om_hsd"] != DBNull.Value)
                                thsd = (string)rdrb["om_hsd"];
                            else
                                thsd = "";
                            chs = ths + thsd;

                            // poišči storitve po šifrantu iz bass
                            string imavodo1 = "01";
                            string imavodo2 = "02";
                            string imaodvajanje = "ODV";
                            string imaciscenje = "CIS";
                            string imagreznico = "GREOS";
                            string imasmeti1 = "SM0001";
                            string imasmeti2 = "SM0002";
                            string imasmeti3 = "SM0003";
                            string imasmeti4 = "SM0004";
                            string imasmeti5 = "SM0005";
                            string imasmeti6 = "SMD001";
                            string imasmeti7 = "SMD002";
                            string imasmeti8 = "SMD003";
                            string imasmeti9 = "SMD004";

                            try
                            {
                                string q3 = "select om,omstoritve_storitev from inkasso_2021_omstoritve_radgona where om=@idxom";
                                cmdb2 = new MySqlCommand(q3, conb2);
                                conb2.Open();
                                cmdb2.Parameters.AddWithValue("@idxom", idxom); // preberi ulico
                                rdrb2 = cmdb2.ExecuteReader();
                                while (rdrb2.Read())
                                {
                                    string tmpstoritev = (string)rdrb2["omstoritve_storitev"];
                                    if (tmpstoritev == imavodo1 || tmpstoritev == imavodo2)
                                        cvodovod = 1;
                                    if (tmpstoritev == imaodvajanje)
                                        ckanalizacija = 1;
                                    if (tmpstoritev == imagreznico)
                                        cgreznica = 1;
                                    if (tmpstoritev == imasmeti1 || tmpstoritev == imasmeti2 || tmpstoritev == imasmeti3 || tmpstoritev == imasmeti4 || tmpstoritev == imasmeti5 || tmpstoritev == imasmeti6 || tmpstoritev == imasmeti7 || tmpstoritev == imasmeti8 || tmpstoritev == imasmeti9)
                                        csmeti = 1;



                                } // while reader
                            }
                            catch (Exception ex3)
                            {
                                MessageBox.Show("Napaka MySQL reader storitve: " + ex3.Message);
                            }
                            finally
                            {
                                rdrb2.Close();
                                conb2.Close();
                            }

                            try
                            {
                                if (stevec > 0)
                                {
                                    // napiši prebrano v tabelo tbl_bass
                                    string query = "Insert into tbl_bass (hsmid,naziv,kraj,ulica,hs,posta,ime_poste,vodovod,kanalizacija,greznica,smeti,dimenzija,tip_om) values " +
                                        "(@chsmid,@cnaziv,@ckraj,@culica,@chs,@cposta,@cime_poste,@cvodovod,@ckanalizacija,@cgreznica,@csmeti,@cdimenzija,@ctip_om)";
                                    cmd = new SqlCommand(query, con);
                                    con.Open();
                                    cmd.Parameters.AddWithValue("@chsmid", chsmid);
                                    cmd.Parameters.AddWithValue("@cnaziv", cnaziv);
                                    cmd.Parameters.AddWithValue("@ckraj", ckraj);
                                    cmd.Parameters.AddWithValue("@culica", culica);
                                    cmd.Parameters.AddWithValue("@chs", chs);
                                    cmd.Parameters.AddWithValue("@cposta", cposta);
                                    cmd.Parameters.AddWithValue("@cime_poste", cime_poste);
                                    cmd.Parameters.AddWithValue("@cvodovod", cvodovod);
                                    cmd.Parameters.AddWithValue("@ckanalizacija", ckanalizacija);
                                    cmd.Parameters.AddWithValue("@cgreznica", cgreznica);
                                    cmd.Parameters.AddWithValue("@csmeti", csmeti);
                                    cmd.Parameters.AddWithValue("@cdimenzija", cdim);
                                    cmd.Parameters.AddWithValue("@ctip_om", ctip_om);
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Napaka insert: " + ex.Message);
                            }
//                        } // začasno if števec<101
                        stevec = ++stevec;
                        vrstica = "";
                        ls.Text = stevec.ToString();
                        ls.Refresh();
                        
                    } // while reader
                    
                    stevec--;
                    ls.Text = stevec.ToString();
                    ls.Refresh();
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("Napaka MySQL reader: " + ex2.Message);
                }
                finally
                {
                    if (rdrb != null)
                    {
                        rdrb.Close();
                    }
                    if (conb != null)
                    {
                        conb.Close();
                    }
                }
            }


        }

        private void button10_Click(object sender, EventArgs e)  // prenesi iz Bassove baze
        {
            ls.Text = "";
            Prenesi_Bass();
            ls.Text = "Ok";

        }

        //private void button10_Click(object sender, EventArgs e)  // prenesi cadis.crp
        //{
        //    ls.Text = "";
        //    OpenFileDialog open = new OpenFileDialog();
        //    open.InitialDirectory = frmMain.pot_podatki;

        //    open.FileName = "";

        //    open.Filter = "Ločeno s podpičjem | *.csv";

        //    if (open.ShowDialog() == DialogResult.OK)
        //    {
        //        Prenesi_cadis(open.FileName);
        //        ls.Text = "Ok";
        //    }

        //    //Prenesi_cadis();
        //}

        private void button9_Click(object sender, EventArgs e)
        {
//            St_zapisov();
            ls1.Text = countcrp.ToString();
            ls1.Refresh();
            ls.Text = "";
            // HSMID -> CRP
            if (countcrp>0 && counths>0 && countul>0 && countna>0 && countcad>0)
            {
                ls1.Text = countcrp.ToString();
                Hsmid_crp();
            }
            else
            {
                MessageBox.Show("Napaka! Nekatere datoteke s podatki iz CSV so prazne");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ls.Text = "";
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = frmMain.pot_podatki;
            
            open.FileName = "";

            open.Filter = "Ločeno s podpičjem | *.csv";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Obdelaj_pt(open.FileName);
                ls.Text = "Ok";
            }
        }

        private void IzprazniBazo_hise()  // izprazni tabelo tbl_crp
        {
            string query = "delete from tbl_hise";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Beri_hs()  // zapiši datoteko hiše
        {
            int st = 0;
            IzprazniBazo_hise();

            string tulmid, thsmid, ths, thd, tlabela, tna_mid, tpt_mid, tpo_mid, tposta, tpt_stev,tsx,tsy,tindex_hs;
            float tx,ty;
            try
            {
                string q = "select hs_mid, ulmid, hs, hd,labela,ulmid,na_mid,pt_mid,po_mid,x,y,index_hs from tbl_hs";
                cmd = new SqlCommand(q, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tnaslov = "";
                    thsmid = (string)rdr["hs_mid"];
                    ths= (string)rdr["hs"];
                    thd = (string)rdr["hd"];
                    tlabela = (string)rdr["labela"];
                    tulmid = (string)rdr["ulmid"];
                    tna_mid = (string)rdr["na_mid"];
                    tpt_mid = (string)rdr["pt_mid"];
                    tpo_mid = (string)rdr["po_mid"];
                    tsx = (string)rdr["x"];
                    tsy = (string)rdr["y"];
                    tx = float.Parse(tsx);
                    ty = float.Parse(tsy);
                    tindex_hs = (string)rdr["index_hs"];

                    // preberi ime ulice
                    string ime = "",  ulime = "", q2;
                    q2 = "select ul_uime from tbl_ul where ul_mid = @tulmid";
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@tulmid", tulmid); // preberi ulico
                    cmd2.ExecuteNonQuery();
                    ulime = (string)cmd2.ExecuteScalar();
                    if (ulime==null)
                    {
                        ulime = "";
                    }
                    con2.Close();

                    // preberi ime naselja
                    string naime = "";
                    q2 = "select na_uime from tbl_na where na_mid = @tna_mid";
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@tna_mid", tna_mid); // preberi ulico
                    cmd2.ExecuteNonQuery();
                    naime = (string)cmd2.ExecuteScalar();
                    if (naime == null)
                    {
                        naime = "";
                    }
                    con2.Close();

                    // preberi pošto
                    string ptime = "";
                    q2 = "select pt_uime from tbl_pt where pt_mid = @tpt_mid";
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@tpt_mid", tpt_mid); // preberi ulico
                    cmd2.ExecuteNonQuery();
                    tposta = (string)cmd2.ExecuteScalar();
                    if (tposta == null)
                    {
                        tposta = "";
                    }
                    q2 = "select pt_id from tbl_pt where pt_mid = @tpt_mid";
                    cmd2 = new SqlCommand(q2, con2);
                    cmd2.Parameters.AddWithValue("@tpt_mid", tpt_mid); // preberi ulico
                    cmd2.ExecuteNonQuery();
                    tpt_stev = (string)cmd2.ExecuteScalar();
                    if (tpt_stev == null)
                    {
                        tpt_stev = "";
                    }
                    con2.Close();

                    ArrayList seznam_stpr = new ArrayList();
                    ArrayList seznam_zcpr = new ArrayList();
                    int x = 0;
                    q2 = "select * from tbl_crp where hsmid = @thsmid";
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@thsmid", thsmid);
                    rdr2 = cmd2.ExecuteReader();
                    stevec_zacasno = 0; stevec_stalno = 0;
                    while (rdr2.Read())
                    {
                        temp_zacasno = 0; temp_stalno = 0;
                        temp_zacasno = Convert.ToInt32(rdr2[34]); // sprememnjeno zaradi dodatnega polja
                        temp_stalno = Convert.ToInt32(rdr2[35]);
                        stevec_zacasno = stevec_zacasno + temp_zacasno;
                        stevec_stalno = stevec_stalno + temp_stalno;
                        x++;
                    }
                    con2.Close();
                    int stevec = 0, stalnih=0, zacasnih=0, nasel=0;
                    stalnih = stevec_stalno;
                    zacasnih = stevec_zacasno;
                    tnaslov = ulime;
                    if (ulime == "")
                        tnaslov = naime;

                    try
                    {
                        string q3 = "insert into tbl_hise(hsmid,ulmid,ulica,hs,hd,naslov,labela,namid,naselje,pt_stev,posta,obcina,x,y,stalno,zacasno) values(@hsmid,@ulmid,@ulica,@hs,@hd,@naslov,@labela,@namid,@naselje,@pt_stev,@posta,@obcina,@x,@y,@stalno,@zacasno)";
                        cmd3 = new SqlCommand(q3, con3);
                        con3.Open();
                        cmd3.Parameters.AddWithValue("@hsmid", thsmid);
                        cmd3.Parameters.AddWithValue("@ulmid", tulmid);
                        cmd3.Parameters.AddWithValue("@ulica", ulime);
                        cmd3.Parameters.AddWithValue("@hs", ths);
                        cmd3.Parameters.AddWithValue("@hd", thd);
                        cmd3.Parameters.AddWithValue("@naslov", tnaslov);
                        cmd3.Parameters.AddWithValue("@labela", tlabela);
                        cmd3.Parameters.AddWithValue("@namid", tna_mid);
                        cmd3.Parameters.AddWithValue("@naselje", naime);
                        cmd3.Parameters.AddWithValue("@pt_stev", tpt_stev);
                        cmd3.Parameters.AddWithValue("@posta", tposta);
                        cmd3.Parameters.AddWithValue("@obcina", "Gornja Radgona");
                        cmd3.Parameters.AddWithValue("@x", tx);
                        cmd3.Parameters.AddWithValue("@y", ty);
                        cmd3.Parameters.AddWithValue("@stalno", stalnih);
                        cmd3.Parameters.AddWithValue("@zacasno", zacasnih);
                        cmd3.ExecuteNonQuery();
                        con3.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka: " + ex.Message);
                    }
                    st = ++st;
                    ls.Text = st.ToString();
                    ls.Refresh();
                }
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
                Display_hise();
                ls.Text = "OK";
                ls.Refresh();
            }
        }

        private void btnhise_Click(object sender, EventArgs e)
        {
            ls1.Text = counths.ToString();
            ls1.Refresh();
            ls.Text = "";

            if (countcrp > 0 && counths > 0 && countul > 0 && countna > 0 && countcad > 0)
            {
                Beri_hs();
            }
            else
            {
                MessageBox.Show("Napaka! Nekatere datoteke s podatki iz CSV so prazne");
            }
        }

        private void button5_Click(object sender, EventArgs e)  // obdelaj vse baze naenkrat
        {
            //if (ncrp == 0 && nhs == 0 && nul == 0 && nna == 0 && npt==0 && ncad==0)
            //{
            //    Obdelaj_pt();
            //    Obdelaj_na();
            //    Obdelaj_ul();
            //    Obdelaj_hs();
            //    Obdelaj_crp();
            //    Prenesi_cadis();
            //    //Obdelaj_aglo();

            //    Obdelaj_sql();
            //    MessageBox.Show("Končano! Podatki so pripravljeni.");
            //}
            //else
            //{
            //    MessageBox.Show("Vse potrebne datoteke niso na voljo!");
            //}
        }

        // variable tbl_ul
        string ul_mid = "", ob_uime = "", na_uime = "", ul_uime = "";

        // variable tbl_na
        string ob2_uime = "", na2_uime = "", na2_mid = "";
        float povrsina = 0;

        private void frmBaze_Load(object sender, EventArgs e)
        {
            csv = ';';
            csv = '\t';

            //MessageBox.Show(mapa);
            // TODO: This line of code loads data into the 'dskat2.tbl_ul' table. You can move, or remove it, as needed.

            ls.Text = ""; label24.Text = ""; label23.Text = ""; label22.Text = ""; label21.Text = "";label4.Text = "";label17.Text = "";
            label5.Text = "";label18.Text="" ;
            //Prikazi_bazo();
            // Preberi_bazo();
            Preveri_baze();
            St_zapisov();
            Display_hise();
        }

        // napiši število zapisov

        private void St_zapisov()
        {
            Int32 count = 0;
            string query;
            // crp
            query = "select count(*) from tbl_crp";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            count = (Int32)cmd.ExecuteScalar();
            con.Close();
            countcrp = count;
            count = 0;

            // crp
            query = "select count(*) from tbl_ul";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            count = (Int32)cmd.ExecuteScalar();
            con.Close();
            countul = count;
            count = 0;

            query = "select count(*) from tbl_hs";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            count = (Int32)cmd.ExecuteScalar();
            con.Close();
            counths = count;
            count = 0;

            query = "select count(*) from tbl_na";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            count = (Int32)cmd.ExecuteScalar();
            con.Close();
            countna = count;
            count = 0;

            query = "select count(*) from tbl_pt";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            count = (Int32)cmd.ExecuteScalar();
            con.Close();
            countpt = count;
            count = 0;

            query = "select count(*) from tbl_bass";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            count = (Int32)cmd.ExecuteScalar();
            con.Close();
            countcad = count;
            count = 0;

        }

        public frmBaze()
        {
            InitializeComponent();
        }

        void Displaydata_cad()
        {
            con.Open();
            System.Data.DataTable dt = new System.Data.DataTable();
            adapt = new SqlDataAdapter("select * from tbl_cad", con);
            adapt.Fill(dt);
            dgv1.DataSource = dt;
            con.Close();
        }

        void Display_hise()
        {
            con.Open();
            System.Data.DataTable dt = new System.Data.DataTable();
            adapt = new SqlDataAdapter("select * from tbl_hise", con);
            adapt.Fill(dt);
            dgv1.DataSource = dt;
            con.Close();
        }
        void DisplayData_pt()
        {
            con.Open();
            System.Data.DataTable dt = new System.Data.DataTable();
            adapt = new SqlDataAdapter("select * from tbl_pt", con);
            adapt.Fill(dt);
            dgv1.DataSource = dt;
            con.Close();
        }
        void DisplayData_ul()
        {
            con.Open();
            System.Data.DataTable dt = new System.Data.DataTable();
            adapt = new SqlDataAdapter("select * from tbl_ul", con);
            adapt.Fill(dt);
            dgv1.DataSource = dt;
            con.Close();
        }
        void DisplayData_hs()
        {
            con.Open();
            System.Data.DataTable dt = new System.Data.DataTable();
            adapt = new SqlDataAdapter("select * from tbl_hs", con);
            adapt.Fill(dt);
            dgv1.DataSource = dt;
            con.Close();
        }
        void DisplayData_crp()
        {
            // MessageBox.Show("displaydata_crp");
            con.Open();
            System.Data.DataTable dt = new System.Data.DataTable();
            adapt = new SqlDataAdapter("select * from tbl_crp", con);
            adapt.Fill(dt);
            dgv1.DataSource = dt;
            con.Close();
        }
        void DisplayData_crp2()
        {
            // MessageBox.Show("displaydata_crp2");
            con.Open();
            System.Data.DataTable dt = new System.Data.DataTable();
            adapt = new SqlDataAdapter("select * from tbl_crp", con);
            adapt.Fill(dt);
            dgv1.DataSource = dt;
            con.Close();
        }
        void DisplayData_na()
        {
            con.Open();
            System.Data.DataTable dt = new System.Data.DataTable();
            adapt = new SqlDataAdapter("select * from tbl_na", con);
            adapt.Fill(dt);
            dgv1.DataSource = dt;
            con.Close();
        }

        // prenos CRP
        private void IzprazniBazo_crp()  // izprazni tabelo tbl_crp
        {
            string query = "delete from tbl_crp";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void izprazni_crp() // izprazni variable za bazo
        {
            emso = ""; spol = ""; priimek1 = ""; priimek2 = ""; ime1 = ""; ime2 = ""; drzava = ""; obcina_roj = ""; naselje_roj = "";
            drzava_roj = ""; naselje_stpr = ""; ulica_stpr = ""; hs_stpr = ""; hsd_stpr = ""; posta_stpr = ""; naziv_poste_stpr = "";
            ulica_zcpr = ""; hs_zcpr = ""; hsd_zcpr = ""; posta_zcpr = ""; naziv_poste_zcpr = ""; status_preb = ""; stan = "";
            dat_roj = ""; datum_od_zcpr = "";
        }

        private void Obdelaj_crp(string vhod)  
        {
            // string lcaseidxtemp, lcaseidxtempz;
                stevec = 0;
                IzprazniBazo_crp();
                // preberi CRP - CSV
                try
                {
                    System.IO.StreamReader objReader;
                    objReader = new System.IO.StreamReader(vhod, ASCIIEncoding.UTF8);
                    // število vrstic v CSV
                    do
                    {

                    // novo od 2021
                    vrstica = "";
                    string idxulica = "";
                    string idxulica_s = "";
                    string idxulica_z = "";
                    izprazni_crp();
                    vrstica = vrstica + objReader.ReadLine() + "\r\n";
                    // razdeli vrstico ločeno s ;
                    string[] polje = vrstica.Split(';');
                    emso = polje[0];
                    spol = polje[1];
                    dat_roj = polje[2];
                    priimek1 = polje[5];
                    priimek2 = polje[6];
                    ime1 = polje[8];
                    ime2 = polje[9];
                    drzava = polje[11];
                    obcina_roj = polje[15];
                    naselje_roj = polje[17];
                    drzava_roj = polje[29];
                    naselje_stpr = polje[39];
                    ulica_stpr = polje[41];
                    hs_stpr = polje[42];
                    hsd_stpr = polje[43];
                    posta_stpr = polje[48];
                    naziv_poste_stpr = polje[49];
                    ulica_zcpr = polje[62];
                    hs_zcpr = polje[63];
                    hsd_zcpr = polje[64];
                    posta_zcpr = polje[66];
                    naziv_poste_zcpr = polje[67];
                    datum_od_zcpr = polje[68];
                    status_preb = polje[82];
                    stan = polje[84];


                    // staro do 02-2021    
                    //vrstica = "";
                    //string idxulica = "";
                    //string idxulica_s = "";
                    //string idxulica_z = "";
                    //izprazni_crp();
                    //vrstica = vrstica + objReader.ReadLine() + "\r\n";
                    //// razdeli vrstico ločeno s ;
                    //string[] polje = vrstica.Split(';');
                    //emso = polje[0];
                    //spol = polje[1];
                    //dat_roj = polje[2];
                    //priimek1 = polje[3];
                    //priimek2 = polje[4];
                    //ime1 = polje[5];
                    //ime2 = polje[6];
                    //drzava = polje[7];
                    //obcina_roj = polje[9];
                    //naselje_roj = polje[10];
                    //drzava_roj = polje[11];
                    //naselje_stpr = polje[13];
                    //ulica_stpr = polje[14];
                    //hs_stpr = polje[15];
                    //hsd_stpr = polje[16];
                    //posta_stpr = polje[17];
                    //naziv_poste_stpr = polje[18];
                    //ulica_zcpr = polje[19];
                    //hs_zcpr = polje[20];
                    //hsd_zcpr = polje[21];
                    //posta_zcpr = polje[22];
                    //naziv_poste_zcpr = polje[23];
                    //datom_od_zcpr = polje[24];
                    //status_preb = polje[25];
                    //stan = polje[26];

                    // napiši prebrano v tabelo crp
                    try
                    {
                            if (stevec > 0)  // preskoči prvo vrstico
                            {
                                // naredi indekse

                                // indeks crp - vsi ga morajo imeti iz radgonske občine
                                string stalno = "Ima samo stalno prebivališče";
                                string zacasno = "Ima samo začasno prebivališče";
                                string oboje = "Ima stalno in začasno prebivališče";
                                string izbira = status_preb;
                                string namid_ok = ""; // na_mid, ki se bo zapisal v bazo crp
                                string naselje_ok = ""; // ime naselja, ki se bo zapisalo v bazo
                                string idxtemp = ""; 
                                string idxt = "";
                                string lcaseidxtemp = "";
                                string lcaseidxtempz = "";
                                int tzacasno = 0;  
                                int tstalno=0;

                                if (izbira == stalno)
                                {
                                    // če ima samo stalno je sigurno v radgoni
                                    idxtemp = ulica_stpr + hs_stpr + hsd_stpr;
                                    idxtemp = string.Join("", idxtemp.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries)); // odstrani presledke
                                    lcaseidxtemp = idxtemp.ToLower(); // v male črke
                                    idxt = lcaseidxtemp;
                                    idxulica_s = ulica_stpr;
                                    idxulica = ulica_stpr;
                                    idxulica_z="99";
                                    lcaseidxtempz = "99";
                                    tzacasno = 0;
                                    tstalno = 1;
                                }

                                if (izbira == zacasno)
                                {
                                    // če ima samo začasno je sigurno v radgoni
                                    idxtemp = ulica_zcpr + hs_zcpr + hsd_zcpr;
                                    idxtemp = string.Join("", idxtemp.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries)); // odstrani presledke
                                    lcaseidxtemp = idxtemp.ToLower(); // v male črke
                                    idxt = lcaseidxtemp;
                                    idxulica = ulica_zcpr;
                                    idxulica_s = ulica_zcpr;
                                    idxulica_z = ulica_zcpr;
                                    lcaseidxtempz = lcaseidxtemp;
                                    tzacasno = 1;
                                    tstalno = 0;
                                }
                                if (izbira == oboje)
                                {
                                    // stalno
                                    idxtemp = ulica_stpr + hs_stpr + hsd_stpr;
                                    idxtemp = string.Join("", idxtemp.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries)); // odstrani presledke
                                    lcaseidxtemp = idxtemp.ToLower(); // v male črke

                                    // zacasno
                                    idxtempz = ulica_zcpr + hs_zcpr + hsd_zcpr;
                                    idxtempz = string.Join("", idxtempz.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries)); // odstrani presledke
                                    lcaseidxtempz = idxtempz.ToLower(); // v male črke
                                    //MessageBox.Show(lcaseidxtemp + " " + lcaseidxtempz);

                                    // če je idxtemp v indeksu HS je to pravi
                                    // preveri če je idxtemp v radgonski občini
                                    // če je -> idx = idxtemp, index_crp = idxtemp, index_crpz = idxtempz
                                    // če je stalno v radgonski občini daj idxtemp kot index_crp in idxtempz kot index_crpz
                                    natemp = "";
                                    int stpr_v_gr = 0;
                                    string q = "select na_mid from tbl_hs where index_hs = @indeks";

                                    cmd = new SqlCommand(q, con);
                                    con.Open();
                                    cmd.Parameters.AddWithValue("@indeks", lcaseidxtemp); // preberi naselje
                                    cmd.ExecuteNonQuery();
                                    natemp = (string)cmd.ExecuteScalar();
                                    con.Close();
                                    tstalno = 1;
                                    if (natemp==null)
                                    {
                                        // nič ni našel, začasno je v radgoni
                                       // MessageBox.Show("nič ni našel " + natemp);
                                        stpr_v_gr = 0;
                                        idxt = lcaseidxtempz;
                                        idxulica = ulica_zcpr;
                                        tzacasno = 1;
                                        tstalno = 0;
                                        //tzacasno = 0;
                                        //tstalno = 1;
                                    }

                                    if (natemp !=null)
                                    {
                                        // našel je zapis - stalno je v radgoni ampak 
                                        stpr_v_gr = 1;
                                        idxt = lcaseidxtemp;
                                        idxulica = ulica_stpr;
                                        tzacasno = 0;
                                        tstalno = 1;
                                        //tzacasno = 1;
                                        //tstalno = 0;
                                    }
                                }
                                // konec indeksov
                                naselje_ok = idxulica;

                                naselje_ok = "Gornja Radgona";
                                namid_ok = "10092752"; // MID od radgone

                                // poglej če je idxulica med naselji, če ni je gornja radgona
                                SqlDataReader rdr = null;
                                try
                                {
                                    string q = "select na_mid, na_uime from tbl_na where na_uime = @tnauime";
                                    cmd = new SqlCommand(q, con);
                                    con.Open();
                                    cmd.Parameters.AddWithValue("@tnauime", idxulica); // preberi naselje
                                    rdr = cmd.ExecuteReader();
                                    while (rdr.Read())
                                    {
                                        namid_ok = (String)rdr["na_mid"];  // določi namid stalnega
                                        naselje_ok = (String)rdr["na_uime"];  // določi naselje stalnega
                                    }
                                }
                                catch (Exception ex2)
                                {
                                    MessageBox.Show("Napaka reader: " + ex2.Message);
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

                                tindeks_osebe = dat_roj + priimek1 + ime1 + lcaseidxtemp + lcaseidxtempz;
                                string query = "insert into tbl_crp(indeks_osebe,emso,spol,dat_roj,priimek1,priimek2,ime1,ime2,drzava," +
                                "               obcina_roj,naselje_roj,drzava_roj,naselje_stpr,ulica_stpr,hs_stpr,hsd_stpr,posta_stpr,naziv_poste_stpr,ulica_zcpr,hs_zcpr,hsd_zcpr," +
                                "               posta_zcpr,naziv_poste_zcpr,datom_od_zcpr,status_preb,stan,index_crp,index_crpz,idx,zacasno,stalno,na_s,na_z) values(@indeks_osebe,@emso,@spol,@dat_roj,@priimek1,@priimek2," +
                                "               @ime1,@ime2,@drzava,@obcina_roj,@naselje_roj,@drzava_roj,@naselje_stpr,@ulica_stpr,@hs_stpr, @hsd_stpr, @posta_stpr, @naziv_poste_stpr," +
                                "               @ulica_zcpr, @hs_zcpr, @hsd_zcpr, @posta_zcpr, @naziv_poste_zcpr, @datom_od_zcpr, @status_preb, @stan,@index_crp,@index_crpz,@idx,@zacasno,@stalno,@na_s,@na_z)";
                                cmd = new SqlCommand(query, con);
                                con.Open();
                                cmd.Parameters.AddWithValue("@emso", emso);
                                cmd.Parameters.AddWithValue("@indeks_osebe", tindeks_osebe);
                                cmd.Parameters.AddWithValue("@spol", spol);
                                cmd.Parameters.AddWithValue("@dat_roj", dat_roj);
                                cmd.Parameters.AddWithValue("@priimek1", priimek1);
                                cmd.Parameters.AddWithValue("@priimek2", priimek2);
                                cmd.Parameters.AddWithValue("@ime1", ime1);
                                cmd.Parameters.AddWithValue("@ime2", ime2);
                                cmd.Parameters.AddWithValue("@drzava", drzava);
                                cmd.Parameters.AddWithValue("@obcina_roj", obcina_roj);
                                cmd.Parameters.AddWithValue("@naselje_roj", naselje_roj);
                                cmd.Parameters.AddWithValue("@drzava_roj", drzava_roj);
                                cmd.Parameters.AddWithValue("@naselje_stpr", naselje_stpr);
                                cmd.Parameters.AddWithValue("@ulica_stpr", ulica_stpr);
                                cmd.Parameters.AddWithValue("@hs_stpr", hs_stpr);
                                cmd.Parameters.AddWithValue("@hsd_stpr", hsd_stpr);
                                cmd.Parameters.AddWithValue("@posta_stpr", posta_stpr);
                                cmd.Parameters.AddWithValue("@naziv_poste_stpr", naziv_poste_stpr);
                                cmd.Parameters.AddWithValue("@ulica_zcpr", ulica_zcpr);
                                cmd.Parameters.AddWithValue("@hs_zcpr", hs_zcpr);
                                cmd.Parameters.AddWithValue("@hsd_zcpr", hsd_zcpr);
                                cmd.Parameters.AddWithValue("@posta_zcpr", posta_zcpr);
                                cmd.Parameters.AddWithValue("@naziv_poste_zcpr", naziv_poste_zcpr);
                                cmd.Parameters.AddWithValue("@datom_od_zcpr", datum_od_zcpr);
                                cmd.Parameters.AddWithValue("@status_preb", status_preb);
                                cmd.Parameters.AddWithValue("@stan", stan);
                                cmd.Parameters.AddWithValue("@index_crp", lcaseidxtemp);
                                cmd.Parameters.AddWithValue("@index_crpz", lcaseidxtempz); //lcaseidxtempz
                                cmd.Parameters.AddWithValue("@idx", idxt); //lcaseidxtempz
                                cmd.Parameters.AddWithValue("@zacasno", tzacasno); // 1 ali 0
                                cmd.Parameters.AddWithValue("@stalno", tstalno); //lcaseidxtempz
                                cmd.Parameters.AddWithValue("@na_s", namid_ok);
                                cmd.Parameters.AddWithValue("@na_z", naselje_ok);
                                // cmd.Parameters.AddWithValue("@idx", idxt); //lcaseidxtempz

                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Napaka: " + ex.Message);
                        }
                        // MessageBox.Show("emso " + emso + " spol " + spol + " priimek1 " + priimek1);
                        vrstica = "";
                        stevec = ++stevec;
                        ls.Text = stevec.ToString();
                        ls.Refresh();
                    } while (objReader.Peek() != -1);
                    objReader.Close();
                    stevec--;
                    ls.Text = stevec.ToString();
                    ls.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: " + ex.Message);
                }
                finally
                {
                    DisplayData_crp();
                }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ls.Text = "";
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = frmMain.pot_podatki;

            open.FileName = "";

            open.Filter = "Ločeno s podpičjem | *.csv";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Obdelaj_crp(open.FileName);
                ls.Text = "Ok";
            }
            //Obdelaj_crp();
        }
        // konec prenos CRP

        // prenos HS
        private void IzprazniBazo_hs()  // izprazni tabelo tbl_hs
        {
            string query = "delete from tbl_hs";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Izprazni_hs() // izprazni variable za tabelo tbl_ul
        {
            index_hs = ""; enota = ""; hs_mid = ""; hs = ""; hd = ""; labela = ""; ulmid = ""; na_mid = ""; ob_mid = ""; pt_mid = ""; po_mid = ""; x = ""; y = "";
        }
        private void Obdelaj_hs(string vhod)
        {
                stevec = 0;
                IzprazniBazo_hs();
                // preberi HS - CSV
                try
                {
                    System.IO.StreamReader objReader;
                    objReader = new System.IO.StreamReader(vhod, ASCIIEncoding.UTF8);
                    // število vrstic v CSV
                    do
                    {
                        vrstica = "";
                        Izprazni_hs();
                        vrstica = vrstica + objReader.ReadLine() + "\r\n";
                        // MessageBox.Show(vrstica);

                        // razdeli vrstico ločeno s ;
                        string[] polje = vrstica.Split(';');
                        enota = polje[1];
                        hs_mid = polje[2];
                        hs = polje[3];
                        hd = polje[4];
                        labela = polje[5];
                        ulmid = polje[6];
                        na_mid = polje[7];
                        ob_mid = polje[8];
                        pt_mid = polje[9];
                        po_mid = polje[10];
                        y = polje[14];
                        x = polje[15];
                        // napiši prebrano v tabelo crp
                        try
                        {
                            if (stevec > 0)
                            {
                                // naredi indekse
                                idxtemp = ""; natemp = ""; ultemp = "";
                                string selecttemp = na_mid; // začasni na_mid
                                string q = "select na_uime, na_mid from tbl_na where na_mid = @selecttemp";
                                cmd = new SqlCommand(q, con);
                                con.Open();
                                cmd.Parameters.AddWithValue("@selecttemp", selecttemp); // preberi naselje
                                cmd.ExecuteNonQuery();
                                natemp = (string)cmd.ExecuteScalar();
                                con.Close();
                              //  MessageBox.Show("Naselje "+natemp);

                                selecttemp = ulmid; // začasni na_mid
                                q = "select ul_uime, ul_mid from tbl_ul where ul_mid = @selecttemp";
                                cmd = new SqlCommand(q, con);
                                con.Open();
                                cmd.Parameters.AddWithValue("@selecttemp", selecttemp); // preberi ulico
                                cmd.ExecuteNonQuery();
                                ultemp = (string)cmd.ExecuteScalar();
                                con.Close();
                                // MessageBox.Show("Naselje " + natemp+"  Ulica: +"+ultemp+"+");

                                if (ultemp == null)
                                {
                                    ultemp = natemp; // če ni ulice daj v indeks naselje
                                    // MessageBox.Show("Naselje v if" + natemp);
                                }

                                idxtemp = ultemp + hs + hd;
                                idxtemp = string.Join("", idxtemp.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries)); // odstrani presledke
                                string lcaseidxtemp = idxtemp.ToLower(); // v male črke
                                // konec indeksov

                                string query = "insert into tbl_hs (enota, hs_mid, hs, hd, labela, ulmid, na_mid, ob_mid, pt_mid, po_mid, y, x,index_hs) values(@enota, @hs_mid, @hs, @hd, @labela, @ulmid, @na_mid, @ob_mid, @pt_mid, @po_mid, @y, @x,@index_hs)";
                                cmd = new SqlCommand(query, con);
                                con.Open();
                                cmd.Parameters.AddWithValue("@enota", enota);
                                cmd.Parameters.AddWithValue("@hs_mid", hs_mid);
                                cmd.Parameters.AddWithValue("@hs", hs);
                                cmd.Parameters.AddWithValue("@hd", hd);
                                cmd.Parameters.AddWithValue("@labela", labela);
                                cmd.Parameters.AddWithValue("@ulmid", ulmid);
                                cmd.Parameters.AddWithValue("@na_mid", na_mid);
                                cmd.Parameters.AddWithValue("@ob_mid", ob_mid);
                                cmd.Parameters.AddWithValue("@pt_mid", pt_mid);
                                cmd.Parameters.AddWithValue("@po_mid", po_mid);
                                cmd.Parameters.AddWithValue("@y", y);
                                cmd.Parameters.AddWithValue("@x", x);
                                cmd.Parameters.AddWithValue("@index_hs", lcaseidxtemp);
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Napaka: " + ex.Message);
                        }
                        vrstica = "";
                        stevec = ++stevec;
                        ls.Text = stevec.ToString();
                        ls.Refresh();
                    } while (objReader.Peek() != -1);
                    objReader.Close();
                    stevec--;
                    ls.Text = stevec.ToString();
                    ls.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: " + ex.Message);
                }
                finally
                {
                    DisplayData_hs();
                }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ls.Text = "";
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = frmMain.pot_podatki;

            open.FileName = "";

            open.Filter = "Ločeno s podpičjem | *.csv";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Obdelaj_hs(open.FileName);
                ls.Text = "Ok";
            }

            //Obdelaj_hs();
        }
        // konec prenos HS

        // prenos UL

        private void IzprazniBazo_ul()  // izprazni tabelo tbl_ul
        {
            string query = "delete from tbl_ul";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Izprazni_ul() // izprazni variable za tabelo tbl_ul
        {
            ul_mid = ""; ob_uime = ""; na_uime = ""; ul_uime = "";
        }
        private void Obdelaj_ul(string vhod)
        {
                // začni prenos
                stevec = 0;
                IzprazniBazo_ul();
                // preberi ul - CSV
                try
                {
                    System.IO.StreamReader objReader;
                    objReader = new System.IO.StreamReader(vhod, ASCIIEncoding.UTF8);
                    // število vrstic v CSV
                    // ++stevec; // preskoči prvo vrstico
                    do
                    {
                        vrstica = "";
                        Izprazni_ul();
                        vrstica = vrstica + objReader.ReadLine() + "\r\n";

                        // razdeli vrstico ločeno s ;
                        string[] polje = vrstica.Split(';');
                        ul_mid = polje[2];
                        ob_uime = polje[7];
                        na_uime = polje[6];
                        ul_uime = polje[4];
                        try
                        {
                            if (stevec > 0)
                            {
                                // napiši prebrano v tabelo ul
                                string query = "Insert into tbl_ul (ul_mid, ob_uime, na_uime, ul_uime) values (@ul_mid, @ob_uime, @na_uime, @ul_uime)";
                                cmd = new SqlCommand(query, con);
                                con.Open();
                                cmd.Parameters.AddWithValue("@ul_mid", ul_mid);
                                cmd.Parameters.AddWithValue("@ob_uime", ob_uime);
                                cmd.Parameters.AddWithValue("@na_uime", na_uime);
                                cmd.Parameters.AddWithValue("@ul_uime", ul_uime);
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Napaka: " + ex.Message);
                        }
                        stevec = ++stevec;
                        vrstica = "";
                        ls.Text = stevec.ToString();
                        ls.Refresh();
                    } while (objReader.Peek() != -1);
                    objReader.Close();
                    stevec--;
                    ls.Text = stevec.ToString();
                    ls.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: " + ex.Message);
                }
                finally
                {
                    DisplayData_ul();
                }
        }
        private void button3_Click(object sender, EventArgs e) // prenos z SQL
        {
            ls.Text = "";
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = frmMain.pot_podatki;

            open.FileName = "";

            open.Filter = "Ločeno s podpičjem | *.csv";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Obdelaj_ul(open.FileName);
                ls.Text = "Ok";
            }

            //Obdelaj_ul();
        }
        // konec prenos UL

        // prenos NA

        private void IzprazniBazo_na()  // izprazni tabelo tbl_na
        {
            string query = "delete from tbl_na";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Izprazni_na() // izprazni variable za tabelo tbl_na
        {
            ob2_uime = ""; na2_uime = ""; povrsina = 0; na2_mid = "";
        }

        private void Obdelaj_na(string vhod)
        {
                // začni prenos
                stevec = 0;
                IzprazniBazo_na();
                string povrsinastr = "";

                try
                {
                    System.IO.StreamReader objReader;
                    objReader = new System.IO.StreamReader(vhod, ASCIIEncoding.UTF8);
                    do
                    {
                        vrstica = "";
                        Izprazni_na();
                        vrstica = vrstica + objReader.ReadLine() + "\r\n";

                        // razdeli vrstico ločeno s ;
                        string[] polje = vrstica.Split(';');
                        ob2_uime = polje[6];
                        na2_uime = polje[4];
                        na2_mid = polje[2];
                        povrsinastr = polje[7];
                        try
                        {
                            if (stevec > 0)
                            {
                                // napiši prebrano v tabelo ul
                                povrsina = float.Parse(povrsinastr);
                                string query = "insert into tbl_na (ob_uime, na_uime, povrsina,na_mid) values(@ob_uime, @na_uime, @povrsina,@na_mid)";
                                cmd = new SqlCommand(query, con);
                                con.Open();
                                cmd.Parameters.AddWithValue("@ob_uime", ob2_uime);
                                cmd.Parameters.AddWithValue("@na_uime", na2_uime);
                                cmd.Parameters.AddWithValue("@povrsina", povrsina);
                                cmd.Parameters.AddWithValue("@na_mid", na2_mid);
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Napaka: " + ex.Message);
                        }
                        stevec = ++stevec;
                        vrstica = "";
                        ls.Text = stevec.ToString();
                        ls.Refresh();
                    } while (objReader.Peek() != -1);
                    objReader.Close();
                    stevec--;
                    ls.Text = stevec.ToString();
                    ls.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: " + ex.Message);
                }
                finally
                {
                    DisplayData_na();
                }
        }

        private void Obdelaj_aglo_kan(string vhod)
        {
            // začni prenos
            stevec = 0;
            IzprazniBazo_ag();
            string povrsinastr = "";

            try
            {
                System.IO.StreamReader objReader;
                objReader = new System.IO.StreamReader(vhod, ASCIIEncoding.UTF8);
                do
                {
                    vrstica = "";
                    Izprazni_ag();
                    vrstica = vrstica + objReader.ReadLine() + "\r\n";

                    // razdeli vrstico ločeno s ;
                    string[] polje = vrstica.Split(';');
                    string aglo_id = polje[2];
                    string aglo_ime = polje[3];
                    string aglo_id2 = "";
                    string aglo_ime2 = "";
                    string tip_aglo = "kan";
                    try
                    {
                            // napiši prebrano v tabelo ul
                            string query = "insert into tbl_aglo (id_aglo, ime_aglo,id_aglo2, ime_aglo2, tip_aglo) values(@id_aglo, @ime_aglo,@id_aglo2, @ime_aglo2, @tip_aglo)";
                            cmd = new SqlCommand(query, con);
                            con.Open();
                            cmd.Parameters.AddWithValue("@id_aglo", aglo_id);
                            cmd.Parameters.AddWithValue("@ime_aglo", aglo_ime);
                            cmd.Parameters.AddWithValue("@tip_aglo", tip_aglo);
                        cmd.Parameters.AddWithValue("@id_aglo2", aglo_id2);
                        cmd.Parameters.AddWithValue("@ime_aglo2", aglo_ime2);

                        cmd.ExecuteNonQuery();
                            con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka: " + ex.Message);
                    }
                    stevec = ++stevec;
                    vrstica = "";
                    ls.Text = stevec.ToString();
                    ls.Refresh();
                } while (objReader.Peek() != -1);
                objReader.Close();
                stevec--;
                ls.Text = stevec.ToString();
                ls.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: " + ex.Message);
            }
            finally
            {
                DisplayData_na();
            }
        }

        private void Obdelaj_aglo_vod(string vhod)
        {
            // začni prenos
            stevec = 0;
            //IzprazniBazo_ag();
            string povrsinastr = "";

            try
            {
                System.IO.StreamReader objReader;
                objReader = new System.IO.StreamReader(vhod, ASCIIEncoding.UTF8);
                do
                {
                    vrstica = "";
                    //Izprazni_ag();
                    vrstica = vrstica + objReader.ReadLine() + "\r\n";

                    // razdeli vrstico ločeno s ;
                    string[] polje = vrstica.Split(';');
                    string aglo_id = polje[2];
                    string aglo_ime = polje[3];
                    string aglo_id2 = polje[6];
                    string aglo_ime2 = polje[7];
                    string tip_aglo = "vod";
                    try
                    {
                        // napiši prebrano v tabelo ul
                        string query = "insert into tbl_aglo (id_aglo, ime_aglo,id_aglo2, ime_aglo2, tip_aglo) values(@id_aglo, @ime_aglo,@id_aglo2, @ime_aglo2, @tip_aglo)";
                        cmd = new SqlCommand(query, con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id_aglo", aglo_id);
                        cmd.Parameters.AddWithValue("@ime_aglo", aglo_ime);
                        cmd.Parameters.AddWithValue("@id_aglo2", aglo_id2);
                        cmd.Parameters.AddWithValue("@ime_aglo2", aglo_ime2);
                        cmd.Parameters.AddWithValue("@tip_aglo", tip_aglo);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka: " + ex.Message);
                    }
                    stevec = ++stevec;
                    vrstica = "";
                    ls.Text = stevec.ToString();
                    ls.Refresh();
                } while (objReader.Peek() != -1);
                objReader.Close();
                stevec--;
                ls.Text = stevec.ToString();
                ls.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: " + ex.Message);
            }
            finally
            {
                DisplayData_na();
            }
        }

        private void button7_Click(object sender, EventArgs e)  // prenos NA
        {
            ls.Text = "";
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = frmMain.pot_podatki;

            open.FileName = "";

            open.Filter = "Ločeno s podpičjem | *.csv";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Obdelaj_na(open.FileName);
                ls.Text = "Ok";
            }


            //Obdelaj_na();
        }
        // konec prenos NA

        // prenos PT

        private void IzprazniBazo_pt()  // izprazni tabelo tbl_pt
        {
            string query = "delete from tbl_pt";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void IzprazniBazo_ag()  // izprazni tabelo tbl_pt
        {
            string query = "delete from tbl_aglo";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Izprazni_pt() // izprazni variable za tabelo tbl_na
        {
            pt_id = ""; pt_uime = ""; pt_mid = "";
        }
        private void Izprazni_ag() // izprazni variable za tabelo tbl_na
        {
            ag_id = ""; ag_ime = "";
        }

        private void Obdelaj_pt(string filep)
        {
                // začni prenos
                stevec = 0;
                IzprazniBazo_pt();
                try
                {
                    System.IO.StreamReader objReader;
                    objReader = new System.IO.StreamReader(filep, ASCIIEncoding.UTF8);
                    do
                    {
                        vrstica = "";
                        Izprazni_pt();
                        vrstica = vrstica + objReader.ReadLine() + "\r\n";

                        // razdeli vrstico ločeno s ;
                        string[] polje = vrstica.Split(';');
                        pt_id = polje[3];
                        pt_uime = polje[4];
                        pt_mid = polje[2];
                        try
                        {
                            if (stevec > 0)
                            {
                                // napiši prebrano v tabelo pt
                                string query = "insert into tbl_pt (pt_id,pt_uime,pt_mid) values(@pt_id, @pt_uime,@pt_mid)";
                                cmd = new SqlCommand(query, con);
                                con.Open();
                                cmd.Parameters.AddWithValue("@pt_id", pt_id);
                                cmd.Parameters.AddWithValue("@pt_uime", pt_uime);
                                cmd.Parameters.AddWithValue("@pt_mid", pt_mid);
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Napaka: " + ex.Message);
                        }
                        stevec = ++stevec;
                        vrstica = "";
                        ls.Text = stevec.ToString();
                        ls.Refresh();
                    } while (objReader.Peek() != -1);
                    objReader.Close();
                    stevec--;
                    ls.Text = stevec.ToString();
                    ls.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: " + ex.Message);
                }
                finally
                {
                    DisplayData_pt();
                }
        }

        private void button2_Click(object sender, EventArgs e) // zapri okno
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Preveri_baze()
        {
            // AGLO
            fnameag = mapa + "aglo.csv";
            fnameag2 = m1 + "aglo.csv";
            try
            {
                var lineCount = File.ReadAllLines(@fnameag).Length;
                lineCount--;
                //label2.Text = fnamecrp2;
                ls.Text = lineCount.ToString();
                nag = 0;
            }
            catch (Exception ex)
            {
                ls.Text = "Datoteka " + fnameag + " ne obstaja!";
                ls.Text = "0";
                nag = 1;
            }

            // CRP
            fnamecrp = mapa + "crp.csv";
            fnamecrp2 = m1 + "crp.csv";
            try
            {
                var lineCount = File.ReadAllLines(@fnamecrp).Length;
                lineCount--;
                //label2.Text = fnamecrp2;
                label24.Text = lineCount.ToString();
                ncrp = 0;
            }
            catch (Exception ex)
            {
                // label2.Text = "Datoteka "+fnamecrp+" ne obstaja!";
                label24.Text = "0";
                ncrp = 1;
            }
            // NA
            fnamena = mapa + "na.csv";
            fnamena2 = m1 + "na.csv";

            try
            {
                var lineCount = File.ReadAllLines(@fnamena).Length;
                lineCount--;
                // label15.Text = fnamena2;
                label21.Text = lineCount.ToString();
                nna = 0;
            }
            catch (Exception ex)
            {
                // label15.Text = "Datoteka " + fnamena + " ne obstaja!";
                label21.Text = "0";
                nna = 1;
            }
            // HS
            fnamehs = mapa + "hs.csv";
            fnamehs2 = m1 + "hs.csv";

            try
            {
                var lineCount = File.ReadAllLines(@fnamehs).Length;
                lineCount--;
                // label3.Text = fnamehs2;
                label23.Text = lineCount.ToString();
                nhs = 0;
            }
            catch (Exception ex)
            {
                // label3.Text = "Datoteka " + fnamehs + " ne obstaja!";
                label23.Text = "0";
                nhs = 1;
            }
            // UL
            fnameul = mapa + "ul.csv";
            fnameul2 = m1 + "ul.csv";

            try
            {
                var lineCount = File.ReadAllLines(@fnameul).Length;
                lineCount--;
                // label12.Text = fnameul2;
                label22.Text = lineCount.ToString();
                nul = 0;
            }
            catch (Exception ex)
            {
                // label12.Text = "Datoteka " + fnameul + " ne obstaja!";
                label22.Text = "0";
                nul = 1;
            }
            // pt
            fnamept = mapa + "pt.csv";
            fnamept2 = m1 + "pt.csv";

            try
            {
                var lineCount = File.ReadAllLines(@fnamept).Length;
                lineCount--;
                // label25.Text = fnamept2;
                label6.Text = lineCount.ToString();
                npt = 0;
            }
            catch (Exception ex)
            {
                // label25.Text = "Manjka " + fnameul;
                label6.Text = "0";
                npt = 1;
            }

            // cadis
            fnamecad = mapa + "cadis.csv";
            fnamecad2 = m1 + "cadis.csv";

            try
            {
                var lineCount = File.ReadAllLines(@fnamecad).Length;
                lineCount--;
                //label16.Text = fnamecad2;
                label7.Text = lineCount.ToString();
                ncad = 0;
            }
            catch (Exception ex)
            {
                // label16.Text = "Manjka " + fnamecad2;
                label7.Text = "0";
                ncad = 1;
            }
            label32.Text = "";
        }

        private void btnCrp_Click(object sender, EventArgs e) // odpri datoteko CRP
        {
            fd.Title = "Izberi datoteko s CRP";
            fd.InitialDirectory = frmMain.app_path_data;  // "C:\\KatApp\\Kataster\\data";
            fd.FileName = "crp.csv";

            // preberi ime datoteke iz dialoga
            if (fd.ShowDialog() == DialogResult.OK)
            {
                // preberi CRP - CSV
                try
                {
                    fnamecrp = fd.FileName;
                    var lineCount = File.ReadAllLines(@fnamecrp).Length;
                   // label2.Text = fnamecrp;
                    label24.Text = lineCount.ToString();
                    ncrp = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: " + ex.Message);
                    ncrp = 1;
                }
            }
            else
            {
                MessageBox.Show("Datoteka ne obstaja: " + fnamecrp);

            }

        }
    }
}
