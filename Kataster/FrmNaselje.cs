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
using System.Collections;
using System.IO;


namespace Komunala
{
    public partial class FrmNaselje : Form
    {

        SqlConnection con = frmMain.c;
        SqlConnection con2 = frmMain.c2;
        SqlConnection con3 = frmMain.c3;
        SqlDataAdapter adapt;

        SqlCommand cmd;
        SqlDataReader rdr = null;

        SqlCommand cmd2;
        SqlDataReader rdr2 = null;

        SqlCommand cmd3;
        SqlDataReader rdr3 = null;

//        public static string izbrani_hsmid, izbrana_oseba;
        public static string pot = frmMain_kat.a_naselje + " - podatki o naselju.csv";
        private const char tab = '\t';
        //FileStream stream = new FileStream(path, FileMode.Create);

        // string a_naselje = frmMain.a_naselje; // aktivno naselje - naziv
        string tmplabela , tmpnaselje, tmpnaselje2,tmpulica,tmphsmid, tmpnamid,tmpulmid,tpriimek1,tpriimek2,time1,time2,tmpindeks_osebe;
        int tmpid, tid, tmpcadis,tmpstalno,tmpzacasno,tmpskupaj;
        string strtmpstalno, strtmpzacasno, strtmpskupaj;
        double f_povrsina = 0;
        string f_naselje = "", f_namid="";
        int f_prebivalcev = 0, f_zacasnih = 0, f_stalnih = 0, f_stavb = 0;
        int f_v_stavb, f_k_stavb, f_s_stavb, f_g_stavb = 0, f_v_ljudi, f_k_ljudi, f_s_ljudi, f_g_ljudi;
        // string tab = ";";

        // za izvoz v datoteko
        int stevec;
        string sp = " ";
        string str_stevec,napisi;
        List<string> zacasni = new List<string>();
        List<string> stalni = new List<string>();
        List<string> osebe = new List<string>();
        List<string> stavbe = new List<string>();
        List<string> na_vodi = new List<string>();
        List<string> brez_vode = new List<string>();
        List<string> na_kanalizaciji = new List<string>();
        List<string> brez_kanalizacije = new List<string>();
        List<string> na_smeteh = new List<string>();
        List<string> brez_smeti = new List<string>();
        List<string> brez_greznice_in_kanalizacije = new List<string>();
        List<string> brez_cadis = new List<string>();
        List<string> na_greznici = new List<string>();

        bool kazi_osebe, kazi_stavbe;
        //string[] zacasni = new string[4];




        private void button12_Click(object sender, EventArgs e)
        {
            kazi_osebe = false;
            kazi_stavbe = true;
            // Stavbe z odvozom odpadkov
            dgv4.Rows.Clear();
            dgv4.Refresh();
            dgv3.Rows.Clear();
            dgv3.Refresh();
            gb4.Text = "  Stavbe v sistemu odvoza odpadkov  ";
            gb6.Text = "  Stavbe brez odvoza odpadkov  ";
            Vpisi_zodpadki();
            Vpisi_brezodpadkov();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            kazi_osebe = false;
            kazi_stavbe = true;
            // pokaži stavbe na vodovodu
            dgv4.Rows.Clear();
            dgv4.Refresh();
            dgv3.Rows.Clear();
            dgv3.Refresh();
            gb4.Text = "  Stavbe na javnem vodovodu  ";
            gb6.Text = "  Stavbe brez vodovoda  ";
            Vpisi_zvodo();
            Vpisi_brezvode();
        }

        double f_v_procstavb, f_k_procstavb, f_s_procstavb, f_g_procstavb, f_v_procljudi, f_k_procljudi, f_s_procljudi, f_g_procljudi;

        private void button27_Click(object sender, EventArgs e)
        {
            kazi_osebe = false;
            kazi_stavbe = true;
            // stavbe, ki manakajo v Cadis
            // stalno in začasno prijavljeni prebivalvi
            dgv4.Rows.Clear();
            dgv4.Refresh();
            dgv3.Rows.Clear();
            dgv3.Refresh();
            gb4.Text = "  Hišne številke, ki jih ni v obračunu  ";
            gb6.Text = "    ";
            Vpisi_cadis();

        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.dgv2.Sort(this.dgv2.Columns["Naslov"], ListSortDirection.Ascending);
        }

        public void Izvoz_v_datoteko()
        {
            string pot = f_naselje + " - podatki o naselju.txt";
            //string pot = "tmp.csv";
            StreamWriter w = new StreamWriter(new FileStream(pot, FileMode.Create, FileAccess.Write));
            w.WriteLine(sp);
            w.WriteLine (f_naselje);
            w.WriteLine(sp);
            w.WriteLine("Površina (Ha): " + tab + label22.Text);
            w.WriteLine("Število prebivalcev:" + tab + label24.Text);
            w.WriteLine("Stalno prijavljenih:" + tab + label27.Text);
            w.WriteLine("Začasno prijavljenih:" + tab + label28.Text);
            w.WriteLine("Število stavb v naselju:" + tab + label29.Text);
            w.WriteLine(sp);
            w.WriteLine("Vodovod");
            w.WriteLine(sp);
            w.WriteLine("Število stavb na vodovodu:"+tab+label43.Text);
            w.WriteLine("Število stavb brez vodovoda:"+tab+label42.Text);
            w.WriteLine("Število prebivalcev na vodovodu:" + tab + label41.Text);
            w.WriteLine("Število prebivalcev brez vodovoda:" + tab + label40.Text);
            w.WriteLine(sp);
            w.WriteLine("Kanalizacija");
            w.WriteLine(sp);
            w.WriteLine("Število stavb na kanalizaciji:" + tab + label39.Text);
            w.WriteLine("Število stavb brez kanalizacije:" + tab + label46.Text);
            w.WriteLine("Število stavb brez kanalizacije in brez greznice:" + tab + label38.Text);
            w.WriteLine("Število prebivalcev na kanalizaciji:" + tab + label37.Text);
            w.WriteLine("Število prebivalcev brez kanalizacije in brez greznice:" + tab + label36.Text);
            w.WriteLine(sp);
            w.WriteLine("Odvoz odpadkov");
            w.WriteLine(sp);
            w.WriteLine("Število stavb z odvozom odpadkov:" + tab + label35.Text);
            w.WriteLine("Število stavb brez odvoza odpadkov:" + tab + label30.Text);
            w.WriteLine("Število prebivalcev z odvozom odpadkov:" + tab + label31.Text);
            w.WriteLine("Število prebivalcev brez odvoza odpadkov:" + tab + label32.Text);
            w.WriteLine(sp);
            w.WriteLine("Greznice");
            w.WriteLine(sp);
            w.WriteLine("Število stavb z greznico:" + tab + label33.Text);
            w.WriteLine("Število prebivalcev z greznico:" + tab + label34.Text);
            w.WriteLine(sp);
            w.WriteLine("Število stavb, ki niso zajete v obračunu (Cadis):" + tab + label44.Text);
            w.WriteLine(sp);
            w.WriteLine(sp);
            w.WriteLine("Seznam hišnih številk v naselju");
            w.WriteLine(sp);

            stavbe.Clear();
            osebe.Clear();
            Seznam_stavbe();
            stavbe.Sort();
            stevec = 1;
            w.WriteLine("ZAP." + tab + "NASLOV" + tab + "HŠ" + tab + "HSMID"+tab+"PREB."+tab+"STALNO"+tab+"ZAČ.");
            foreach (string zactmp in stavbe)
            {
                str_stevec = Convert.ToString(stevec);
                napisi = str_stevec+ tab+ zactmp;
                w.WriteLine(napisi);
                stevec++;
            }

            w.WriteLine(sp);
            w.WriteLine(sp);
            w.WriteLine("Seznam vseh prebivalcev v naselju");
            w.WriteLine(sp);

            //Seznam_stavbe();
            osebe.Sort();
            stevec = 1;
            w.WriteLine("ZAP." + tab + "PRIIMEK IN IME" + tab + "NASLOV");
            foreach (string zactmp in osebe)
            {
                str_stevec = Convert.ToString(stevec);
                napisi = str_stevec + tab + zactmp;
                w.WriteLine(napisi);
                stevec++;
            }


            w.WriteLine(sp);
            w.WriteLine(sp);
            w.WriteLine("Seznam stalno prijavljenih prebivalcev v naselju");
            w.WriteLine(sp);

            stalni.Clear();
            Seznam_stalni();
            stalni.Sort();
            stevec = 1;
            w.WriteLine("ZAP." + tab + "PRIIMEK IN IME" + tab + "NASLOV");
            foreach (string zactmp in stalni)
            {
                str_stevec = Convert.ToString(stevec);
                napisi = str_stevec + tab + zactmp;
                w.WriteLine(napisi);
                stevec++;
            }

            w.WriteLine(sp);
            w.WriteLine(sp);
            w.WriteLine("Seznam začasno prijavljenih prebivalcev v naselju");
            w.WriteLine(sp);

            zacasni.Clear();
            Seznam_zacasni();
            zacasni.Sort();
            stevec = 1;
            w.WriteLine("ZAP." + tab + "PRIIMEK IN IME" + tab + "NASLOV");
            foreach (string zactmp in zacasni)
            {
                str_stevec = Convert.ToString(stevec);
                napisi = str_stevec + tab + zactmp;
                w.WriteLine(napisi);
                stevec++;
            }

            w.WriteLine(sp);
            w.WriteLine(sp);
            w.WriteLine("Seznam stavb, ki plačujejo vodarino.");
            w.WriteLine(sp);

            na_vodi.Clear();
            Seznam_na_vodi();
            na_vodi.Sort();
            stevec = 1;
            w.WriteLine("ZAP." + tab + "NASLOV" + tab + "HŠ" + tab + "PREB." + tab + "STALNO" + tab + "ZAČ." + tab + "OPOMBA");
            foreach (string zactmp in na_vodi)
            {
                str_stevec = Convert.ToString(stevec);
                napisi = str_stevec + tab + zactmp;
                w.WriteLine(napisi);
                stevec++;
            }

            w.WriteLine(sp);
            w.WriteLine(sp);
            w.WriteLine("Seznam stavb, ki ne plačujejo vodarine.");
            w.WriteLine(sp);

            brez_vode.Clear();
            Seznam_brez_vode();
            brez_vode.Sort();
            stevec = 1;
            w.WriteLine("ZAP." + tab + "NASLOV" + tab + "HŠ" + tab + "PREB." + tab + "STALNO" + tab + "ZAČ." + tab + "OPOMBA");
            foreach (string zactmp in brez_vode)
            {
                str_stevec = Convert.ToString(stevec);
                napisi = str_stevec + tab + zactmp;
                w.WriteLine(napisi);
                stevec++;
            }

            w.WriteLine(sp);
            w.WriteLine(sp);
            w.WriteLine("Seznam stavb, ki plačujejo kanalščino.");
            w.WriteLine(sp);

            na_kanalizaciji.Clear();
            Seznam_na_kanalizaciji();
            na_kanalizaciji.Sort();
            stevec = 1;
            w.WriteLine("ZAP." + tab + "NASLOV" + tab + "HŠ" + tab  + "PREB." + tab + "STALNO" + tab + "ZAČ." + tab + "OPOMBA");
            foreach (string zactmp in na_kanalizaciji)
            {
                str_stevec = Convert.ToString(stevec);
                napisi = str_stevec + tab + zactmp;
                w.WriteLine(napisi);
                stevec++;
            }

            w.WriteLine(sp);
            w.WriteLine(sp);
            w.WriteLine("Seznam stavb, ki ne plačujejo kanalščine");
            w.WriteLine(sp);

            brez_kanalizacije.Clear();
            Seznam_brez_kanalizacije();
            brez_kanalizacije.Sort();
            stevec = 1;
            w.WriteLine("ZAP." + tab + "NASLOV" + tab + "HŠ" + tab + "PREB." + tab + "STALNO" + tab + "ZAČ." + tab + "OPOMBA");
            foreach (string zactmp in brez_kanalizacije)
            {
                str_stevec = Convert.ToString(stevec);
                napisi = str_stevec + tab + zactmp;
                w.WriteLine(napisi);
                stevec++;
            }

            w.WriteLine(sp);
            w.WriteLine(sp);
            w.WriteLine("Seznam stavb, ki plačujejo odvoz grezničnih gošč.");
            w.WriteLine(sp);

            na_greznici.Clear();
            Seznam_na_greznici();
            na_greznici.Sort();
            stevec = 1;
            w.WriteLine("ZAP." + tab + "NASLOV" + tab + "HŠ" + tab + "PREB." + tab + "STALNO" + tab + "ZAČ." + tab + "OPOMBA");
            foreach (string zactmp in na_greznici)
            {
                str_stevec = Convert.ToString(stevec);
                napisi = str_stevec + tab + zactmp;
                w.WriteLine(napisi);
                stevec++;
            }
            
            w.WriteLine(sp);
            w.WriteLine(sp);
            w.WriteLine("Seznam stavb, ki nimajo rešenega odvajanja. (Ne plačujejo niti kanalščine, niti odvoza grezničnih gošč.)");
            w.WriteLine(sp);
            brez_greznice_in_kanalizacije.Clear();
            Seznam_brez_greznice_in_kanalizacije();
            brez_greznice_in_kanalizacije.Sort();
            stevec = 1;
            w.WriteLine("ZAP." + tab + "NASLOV" + tab + "HŠ" + tab + "PREB." + tab + "STALNO" + tab + "ZAČ." + tab + "OPOMBA");
            foreach (string zactmp in brez_greznice_in_kanalizacije)
            {
                str_stevec = Convert.ToString(stevec);
                napisi = str_stevec + tab + zactmp;
                w.WriteLine(napisi);
                stevec++;
            }

            // imajo smeti
            w.WriteLine(sp);
            w.WriteLine(sp);
            w.WriteLine("Seznam stavb, ki so vključene v sistem odvoza odpadkov");
            w.WriteLine(sp);
            na_smeteh.Clear();
            Seznam_smeti();
            na_smeteh.Sort();
            stevec = 1;
            w.WriteLine("ZAP." + tab + "NASLOV" + tab + "HŠ" + tab + "PREB." + tab + "STALNO" + tab + "ZAČ." + tab + "OPOMBA");
            foreach (string zactmp in na_smeteh)
            {
                str_stevec = Convert.ToString(stevec);
                napisi = str_stevec + tab + zactmp;
                w.WriteLine(napisi);
                stevec++;
            }

            // nimajo smeti
            w.WriteLine(sp);
            w.WriteLine(sp);
            w.WriteLine("Seznam stavb, ki niso vključene v sistem odvoza odpadkov");
            w.WriteLine(sp);
            brez_smeti.Clear();
            Seznam_brez_smeti();
            brez_smeti.Sort();
            stevec = 1;
            w.WriteLine("ZAP." + tab + "NASLOV" + tab + "HŠ" + tab + "PREB." + tab + "STALNO" + tab + "ZAČ." + tab + "OPOMBA");
            foreach (string zactmp in brez_smeti)
            {
                str_stevec = Convert.ToString(stevec);
                napisi = str_stevec + tab + zactmp;
                w.WriteLine(napisi);
                stevec++;
            }

            // niso v Cadis
            w.WriteLine(sp);
            w.WriteLine(sp);
            w.WriteLine("Seznam stavb, ki niso zajete v programu za obračun komunalnih storitev.");
            w.WriteLine(sp);
            brez_cadis.Clear();
            Seznam_brez_cadis();
            brez_cadis.Sort();
            stevec = 1;
            w.WriteLine("ZAP." + tab + "NASLOV" + tab + "HŠ" + tab + "HSMID" + tab + "PREB." + tab + "STALNO" + tab + "ZAČ.");
            foreach (string zactmp in brez_cadis)
            {
                str_stevec = Convert.ToString(stevec);
                napisi = str_stevec + tab + zactmp;
                w.WriteLine(napisi);
                stevec++;
            }

            w.Close();
        }

        private void Seznam_brez_greznice_in_kanalizacije()
        {
            try
            {
                string q = "select * from tbl_hise where namid=@tmpnamid and kanalizacija=0 and greznica=0 order by ulica, hs,hd desc"; // preberi vse zapise iz tbl_hise
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@tmpnamid", f_namid);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpid = (int)rdr["id"];
                    tmphsmid = (string)rdr["hsmid"];
                    tmpnamid = (string)rdr["namid"];
                    tmpulmid = (string)rdr["ulmid"];
                    tmpnaselje = (string)rdr["naselje"];
                    tmplabela = (string)rdr["labela"];
                    tmpulica = (string)rdr["ulica"];
                    tmpstalno = (int)rdr["stalno"];
                    tmpzacasno = (int)rdr["zacasno"];
                    tmpskupaj = tmpstalno + tmpzacasno;
                    strtmpstalno = Convert.ToString(tmpstalno);
                    strtmpzacasno = Convert.ToString(tmpzacasno);
                    strtmpskupaj = Convert.ToString(tmpskupaj);

                    if (tmpulica != "")
                    {
                        tmpnaselje = tmpulica;
                    }
                    brez_greznice_in_kanalizacije.Add(tmpnaselje + tab + tmplabela + tab + strtmpskupaj + tab + strtmpstalno + tab + strtmpzacasno);
                }  // while read
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }

        }

        private void Seznam_na_greznici()
        {
            try
            {
                string q = "select * from tbl_hise where namid=@tmpnamid and greznica=1 order by ulica, hs,hd desc"; // preberi vse zapise iz tbl_hise
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@tmpnamid", f_namid);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpid = (int)rdr["id"];
                    tmphsmid = (string)rdr["hsmid"];
                    tmpnamid = (string)rdr["namid"];
                    tmpulmid = (string)rdr["ulmid"];
                    tmpnaselje = (string)rdr["naselje"];
                    tmplabela = (string)rdr["labela"];
                    tmpulica = (string)rdr["ulica"];
                    tmpstalno = (int)rdr["stalno"];
                    tmpzacasno = (int)rdr["zacasno"];
                    tmpskupaj = tmpstalno + tmpzacasno;
                    strtmpstalno = Convert.ToString(tmpstalno);
                    strtmpzacasno = Convert.ToString(tmpzacasno);
                    strtmpskupaj = Convert.ToString(tmpskupaj);

                    if (tmpulica != "")
                    {
                        tmpnaselje = tmpulica;
                    }
                    na_greznici.Add(tmpnaselje + tab + tmplabela + tab + strtmpskupaj + tab + strtmpstalno + tab + strtmpzacasno);
                }  // while read
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }

        }
        private void Seznam_brez_cadis()
        {
            try
            {
                
                string q = "select * from tbl_hise where namid=@tmpnamid and cadis=0 order by ulica, hs,hd desc"; // preberi vse zapise iz tbl_hise
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@tmpnamid", f_namid);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpid = (int)rdr["id"];
                    tmphsmid = (string)rdr["hsmid"];
                    tmpnamid = (string)rdr["namid"];
                    tmpulmid = (string)rdr["ulmid"];
                    tmpnaselje = (string)rdr["naselje"];
                    tmplabela = (string)rdr["labela"];
                    tmpulica = (string)rdr["ulica"];
                    tmpstalno = (int)rdr["stalno"];
                    tmpzacasno = (int)rdr["zacasno"];
                    tmpskupaj = tmpstalno + tmpzacasno;
                    strtmpstalno = Convert.ToString(tmpstalno);
                    strtmpzacasno = Convert.ToString(tmpzacasno);
                    strtmpskupaj = Convert.ToString(tmpskupaj);

                    if (tmpulica != "")
                    {
                        tmpnaselje = tmpulica;
                    }
                    brez_cadis.Add(tmpnaselje + tab + tmplabela+tab+tmphsmid + tab + strtmpskupaj + tab + strtmpstalno + tab + strtmpzacasno);
                }  // while read
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }

        }


        private void Seznam_smeti()
        {
            try
            {
                string q = "select * from tbl_hise where namid=@tmpnamid and smeti=1 order by ulica, hs,hd desc"; // preberi vse zapise iz tbl_hise
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@tmpnamid", f_namid);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpid = (int)rdr["id"];
                    tmphsmid = (string)rdr["hsmid"];
                    tmpnamid = (string)rdr["namid"];
                    tmpulmid = (string)rdr["ulmid"];
                    tmpnaselje = (string)rdr["naselje"];
                    tmplabela = (string)rdr["labela"];
                    tmpulica = (string)rdr["ulica"];
                    tmpstalno = (int)rdr["stalno"];
                    tmpzacasno = (int)rdr["zacasno"];
                    tmpskupaj = tmpstalno + tmpzacasno;
                    strtmpstalno = Convert.ToString(tmpstalno);
                    strtmpzacasno = Convert.ToString(tmpzacasno);
                    strtmpskupaj = Convert.ToString(tmpskupaj);

                    if (tmpulica != "")
                    {
                        tmpnaselje = tmpulica;
                    }
                    na_smeteh.Add(tmpnaselje + tab + tmplabela + tab + strtmpskupaj + tab + strtmpstalno + tab + strtmpzacasno);
                }  // while read
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }

        }

        private void Seznam_brez_smeti()
        {
            try
            {
                string q = "select * from tbl_hise where namid=@tmpnamid and smeti=0 order by ulica, hs,hd desc"; // preberi vse zapise iz tbl_hise
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@tmpnamid", f_namid);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpid = (int)rdr["id"];
                    tmphsmid = (string)rdr["hsmid"];
                    tmpnamid = (string)rdr["namid"];
                    tmpulmid = (string)rdr["ulmid"];
                    tmpnaselje = (string)rdr["naselje"];
                    tmplabela = (string)rdr["labela"];
                    tmpulica = (string)rdr["ulica"];
                    tmpcadis = (int)rdr["cadis"];
                    tmpstalno = (int)rdr["stalno"];
                    tmpzacasno = (int)rdr["zacasno"];
                    tmpskupaj = tmpstalno + tmpzacasno;
                    strtmpstalno = Convert.ToString(tmpstalno);
                    strtmpzacasno = Convert.ToString(tmpzacasno);
                    strtmpskupaj = Convert.ToString(tmpskupaj);


                    if (tmpulica != "")
                    {
                        tmpnaselje = tmpulica;
                    }
                    string tmp = tmpnaselje + tab + tmplabela + tab + strtmpskupaj + tab + strtmpstalno + tab + strtmpzacasno;
                    if (tmpcadis != 1)
                    {
                        tmp = tmp + tab + "Stavbe ni v obračunu (Cadis)";
                    }
                    brez_smeti.Add(tmp);
                }  // while read
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }

        }

        private void Seznam_na_kanalizaciji()
        {
            try
            {
                string q = "select * from tbl_hise where namid=@tmpnamid and kanalizacija=1 order by ulica, hs,hd desc"; // preberi vse zapise iz tbl_hise
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@tmpnamid", f_namid);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpid = (int)rdr["id"];
                    tmphsmid = (string)rdr["hsmid"];
                    tmpnamid = (string)rdr["namid"];
                    tmpulmid = (string)rdr["ulmid"];
                    tmpnaselje = (string)rdr["naselje"];
                    tmplabela = (string)rdr["labela"];
                    tmpulica = (string)rdr["ulica"];
                    tmpstalno = (int)rdr["stalno"];
                    tmpzacasno = (int)rdr["zacasno"];
                    tmpskupaj = tmpstalno + tmpzacasno;
                    strtmpstalno = Convert.ToString(tmpstalno);
                    strtmpzacasno = Convert.ToString(tmpzacasno);
                    strtmpskupaj = Convert.ToString(tmpskupaj);

                    if (tmpulica != "")
                    {
                        tmpnaselje = tmpulica;
                    }
                    na_kanalizaciji.Add(tmpnaselje + tab + tmplabela + tab + strtmpskupaj + tab + strtmpstalno + tab + strtmpzacasno);
                }  // while read
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }

        }

        private void Seznam_brez_kanalizacije()
        {
            try
            {
                string q = "select * from tbl_hise where namid=@tmpnamid and kanalizacija=0 order by ulica, hs,hd desc"; // preberi vse zapise iz tbl_hise
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@tmpnamid", f_namid);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpid = (int)rdr["id"];
                    tmphsmid = (string)rdr["hsmid"];
                    tmpnamid = (string)rdr["namid"];
                    tmpulmid = (string)rdr["ulmid"];
                    tmpnaselje = (string)rdr["naselje"];
                    tmplabela = (string)rdr["labela"];
                    tmpulica = (string)rdr["ulica"];
                    tmpcadis = (int)rdr["cadis"];
                    tmpstalno = (int)rdr["stalno"];
                    tmpzacasno = (int)rdr["zacasno"];
                    tmpskupaj = tmpstalno + tmpzacasno;
                    strtmpstalno = Convert.ToString(tmpstalno);
                    strtmpzacasno = Convert.ToString(tmpzacasno);
                    strtmpskupaj = Convert.ToString(tmpskupaj);


                    if (tmpulica != "")
                    {
                        tmpnaselje = tmpulica;
                    }
                    string tmp = tmpnaselje + tab + tmplabela + tab + strtmpskupaj + tab + strtmpstalno + tab + strtmpzacasno;
                    if (tmpcadis != 1)
                    {
                        tmp = tmp + tab + "Stavbe ni v obračunu (Cadis)";
                    }
                    brez_kanalizacije.Add(tmp);
                }  // while read
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }

        }

        private void Seznam_na_vodi()
        {
            try
            {
                string q = "select * from tbl_hise where namid=@tmpnamid and voda=1 order by ulica, hs,hd desc"; // preberi vse zapise iz tbl_hise
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@tmpnamid", f_namid);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpid = (int)rdr["id"];
                    tmphsmid = (string)rdr["hsmid"];
                    tmpnamid = (string)rdr["namid"];
                    tmpulmid = (string)rdr["ulmid"];
                    tmpnaselje = (string)rdr["naselje"];
                    tmplabela = (string)rdr["labela"];
                    tmpulica = (string)rdr["ulica"];
                    tmpstalno = (int)rdr["stalno"];
                    tmpzacasno = (int)rdr["zacasno"];
                    tmpskupaj = tmpstalno + tmpzacasno;
                    strtmpstalno = Convert.ToString(tmpstalno);
                    strtmpzacasno = Convert.ToString(tmpzacasno);
                    strtmpskupaj = Convert.ToString(tmpskupaj);

                    if (tmpulica != "")
                    {
                        tmpnaselje = tmpulica;
                    }
                    na_vodi.Add(tmpnaselje + tab + tmplabela + tab + strtmpskupaj + tab + strtmpstalno + tab + strtmpzacasno);
                }  // while read
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }

        }

        private void Seznam_brez_vode()
        {
            try
            {
                string q = "select * from tbl_hise where namid=@tmpnamid and voda=0 order by ulica, hs,hd desc"; // preberi vse zapise iz tbl_hise
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@tmpnamid", f_namid);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpid = (int)rdr["id"];
                    tmphsmid = (string)rdr["hsmid"];
                    tmpnamid = (string)rdr["namid"];
                    tmpulmid = (string)rdr["ulmid"];
                    tmpnaselje = (string)rdr["naselje"];
                    tmplabela = (string)rdr["labela"];
                    tmpulica = (string)rdr["ulica"];
                    tmpcadis = (int)rdr["cadis"];
                    tmpstalno = (int)rdr["stalno"];
                    tmpzacasno = (int)rdr["zacasno"];
                    tmpskupaj = tmpstalno + tmpzacasno;
                    strtmpstalno = Convert.ToString(tmpstalno);
                    strtmpzacasno = Convert.ToString(tmpzacasno);
                    strtmpskupaj = Convert.ToString(tmpskupaj);


                    if (tmpulica != "")
                    {
                        tmpnaselje = tmpulica;
                    }
                    string tmp = tmpnaselje + tab + tmplabela + tab + strtmpskupaj + tab + strtmpstalno + tab + strtmpzacasno;
                    if (tmpcadis != 1)
                    {
                        tmp = tmp+tab+ "Stavbe ni v obračunu (Cadis)";
                    }
                    brez_vode.Add(tmp);
                }  // while read
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }

        }
        private void button24_Click(object sender, EventArgs e)
        {
            Izvoz_v_datoteko();
            MessageBox.Show("Končano.");
        }
       
        private void Seznam_stavbe()
        {
            try
            {
                string q = "select * from tbl_hise where namid=@tmpnamid order by ulica, hs,hd desc"; // preberi vse zapise iz tbl_hise
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@tmpnamid", f_namid);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpid = (int)rdr["id"];
                    tmphsmid = (string)rdr["hsmid"];
                    tmpnamid = (string)rdr["namid"];
                    tmpulmid = (string)rdr["ulmid"];
                    tmpnaselje = (string)rdr["naselje"];
                    tmplabela = (string)rdr["labela"];
                    tmpulica = (string)rdr["ulica"];
                    tmpstalno = (int)rdr["stalno"];
                    tmpzacasno = (int)rdr["zacasno"];
                    tmpskupaj = tmpstalno + tmpzacasno;
                    strtmpstalno = Convert.ToString(tmpstalno);
                    strtmpzacasno = Convert.ToString(tmpzacasno);
                    strtmpskupaj = Convert.ToString(tmpskupaj);

                    if (tmpulica != "")
                    {
                        tmpnaselje = tmpulica;
                    }
                    // preberi ljudi na tem naslovu
                    string q2 = "select id, priimek1, priimek2, ime1, ime2, hsmid, hs_na from tbl_crp where hsmid=@tmphsmid order by priimek1 desc"; // preberi vse osebe iz naselja
                    try
                    {
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@tmphsmid", tmphsmid);
                        rdr2 = cmd2.ExecuteReader();
                        while (rdr2.Read())
                        {
                            tpriimek1 = (string)rdr2["priimek1"];
                            tpriimek2 = (string)rdr2["priimek2"];
                            time1 = (string)rdr2["ime1"];
                            time2 = (string)rdr2["ime2"];
                            tid = (int)rdr2["id"];
                            if (tpriimek2 != "")
                            {
                                tpriimek2 = " " + tpriimek2;
                            }
                            time1 = " " + time1;
                            if (time2 != "")
                            {
                                time2 = " " + time2;
                            }
                            string tidstr = Convert.ToString(tid);
                            string oseba = tpriimek1 + tpriimek2 + time1 + time2 + tab + tmpnaselje + " " + tmplabela;
                            osebe.Add(oseba);
                            stevec++;
                        }  // while read
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka reader2: " + ex.Message);
                    }
                    finally
                    {
                        rdr2.Close();
                        con2.Close();
                    }
                    string stavba = tmpnaselje + tab + tmplabela+tab+tmphsmid+tab+strtmpskupaj+tab+strtmpstalno+tab+strtmpzacasno;
                    stavbe.Add(stavba);
                }  // while read
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }

        }
        private void Seznam_stalni()
        {
            stevec = 0;
            try
            {
                string q = "select id, ulica, hsmid, namid,ulmid, hs,hd,labela,naselje from tbl_hise where namid=@tmpnamid order by ulica, hs,hd desc"; // preberi vse zapise iz tbl_hise
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@tmpnamid", f_namid);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpid = (int)rdr["id"];
                    tmphsmid = (string)rdr["hsmid"];
                    tmpnamid = (string)rdr["namid"];
                    tmpulmid = (string)rdr["ulmid"];
                    tmpnaselje = (string)rdr["naselje"];
                    tmplabela = (string)rdr["labela"];
                    tmpulica = (string)rdr["ulica"];
                    if (tmpulica != "")
                    {
                        tmpnaselje = tmpulica;
                    }
                    //tmpnaselje = tmpnaselje + " " + tmplabela;

                    // preberi ljudi na tem naslovu
                    string q2 = "select id, priimek1, priimek2, ime1, ime2, hsmid, hs_na from tbl_crp where hsmid=@tmphsmid and stalno=1 and zacasno=0 order by priimek1 desc"; // preberi vse osebe iz naselja
                    try
                    {
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@tmphsmid", tmphsmid);
                        rdr2 = cmd2.ExecuteReader();
                        while (rdr2.Read())
                        {
                            tpriimek1 = (string)rdr2["priimek1"];
                            tpriimek2 = (string)rdr2["priimek2"];
                            time1 = (string)rdr2["ime1"];
                            time2 = (string)rdr2["ime2"];
                            tid = (int)rdr2["id"];
                            if (tpriimek2 != "")
                            {
                                tpriimek2 = " " + tpriimek2;
                            }
                            time1 = " " + time1;
                            if (time2 != "")
                            {
                                time2 = " " + time2;
                            }
                            string tidstr = Convert.ToString(tid);
                            string oseba = tpriimek1 + tpriimek2 + time1 + time2 + tab + tmpnaselje + " " + tmplabela;
                            //string[] row2 = new string[] { oseba };
                            stalni.Add(oseba);
                            stevec++;

                        }  // while read
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka vpiši stalne: " + ex.Message);
                    }
                    finally
                    {
                        rdr2.Close();
                        con2.Close();
                    }
                    // this.dgv2.Sort(this.dgv2.Columns["Oseba"], ListSortDirection.Ascending);

                    // konec branja ljudi
                    //string tmpidstr = Convert.ToString(tmpid);
                    //string[] row = new string[] { tmpidstr, "      " + tmpnaselje, tmplabela, tmpulica, tmphsmid, tmpulmid, tmpnamid };
                    //dgv1.Rows.Add(row);
                }  // while read
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            //DataView dv;
            
            //dv = new DataView(ds.Tables[0], "type = 'business' ", "type Desc", DataViewRowState.CurrentRows);
            //dgv2.DataSource = dv;
            //(dgv2.DataSource as DataTable).DefaultView.RowFilter = string.Format("LoginID LIKE '{0}%'", textBoxFindUserID.Text);
            //(dgv2.DataSource as DataTable).DefaultView.RowFilter = string.Format("Oseba LIKE '{0}%'", tb1.Text);
            //this.dgv1.Filter = string.Format("Naslov Like '%{0}%'", this.tb1.Text);
        }

        private void Seznam_zacasni()
        {
            stevec = 0;    
            try
                {
                    string q = "select id, ulica, hsmid, namid,ulmid, hs,hd,labela,naselje from tbl_hise where namid=@tmpnamid order by ulica, hs,hd desc"; // preberi vse zapise iz tbl_hise
                    cmd = new SqlCommand(q, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@tmpnamid", f_namid);
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        tmpid = (int)rdr["id"];
                        tmphsmid = (string)rdr["hsmid"];
                        tmpnamid = (string)rdr["namid"];
                        tmpulmid = (string)rdr["ulmid"];
                        tmpnaselje = (string)rdr["naselje"];
                        tmplabela = (string)rdr["labela"];
                        tmpulica = (string)rdr["ulica"];
                        if (tmpulica != "")
                        {
                            tmpnaselje = tmpulica;
                        }
                        //tmpnaselje = tmpnaselje + " " + tmplabela;

                        // preberi ljudi na tem naslovu
                        string q2 = "select id, priimek1, priimek2, ime1, ime2, hsmid, hs_na from tbl_crp where hsmid=@tmphsmid and stalno=0 and zacasno=1 order by priimek1 desc"; // preberi vse osebe iz naselja
                        try
                        {
                            cmd2 = new SqlCommand(q2, con2);
                            con2.Open();
                            cmd2.Parameters.AddWithValue("@tmphsmid", tmphsmid);
                            rdr2 = cmd2.ExecuteReader();
                            while (rdr2.Read())
                            {
                                tpriimek1 = (string)rdr2["priimek1"];
                                tpriimek2 = (string)rdr2["priimek2"];
                                time1 = (string)rdr2["ime1"];
                                time2 = (string)rdr2["ime2"];
                                tid = (int)rdr2["id"];
                                if (tpriimek2 != "")
                                {
                                    tpriimek2 = " " + tpriimek2;
                                }
                                time1 = " " + time1;
                                if (time2 != "")
                                {
                                    time2 = " " + time2;
                                }
                                string tidstr = Convert.ToString(tid);
                                string oseba = tpriimek1 + tpriimek2 + time1 + time2 + tab+ tmpnaselje + " " + tmplabela;
                            //string[] row2 = new string[] { oseba };
                            zacasni.Add(oseba);
                            stevec++;

                            }  // while read
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Napaka vpiši začasne: " + ex.Message);
                        }
                        finally
                        {
                            rdr2.Close();
                            con2.Close();
                        }
                        // this.dgv2.Sort(this.dgv2.Columns["Oseba"], ListSortDirection.Ascending);

                        // konec branja ljudi
                        //string tmpidstr = Convert.ToString(tmpid);
                        //string[] row = new string[] { tmpidstr, "      " + tmpnaselje, tmplabela, tmpulica, tmphsmid, tmpulmid, tmpnamid };
                        //dgv1.Rows.Add(row);
                    }  // while read
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka reader: " + ex.Message);
                }
                finally
                {
                    rdr.Close();
                    con.Close();
                }
        }

        private void Stavba()
        {
            frmStavba form2 = new frmStavba();
            form2.ShowDialog();
        }

        private void dgv3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgv4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgv1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMain_kat.izbrani_hsmid = dgv1.Rows[e.RowIndex].Cells[4].Value.ToString();
            frmMain_kat.iz_naselja = true;
            Stavba();
        }

        private void dgv2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMain_kat.izbrana_oseba = dgv2.Rows[e.RowIndex].Cells[3].Value.ToString();
            frmMain_kat.iz_naselja = true;

            Oseba();

        }

        private void dgv3_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (kazi_stavbe == true)
            {
                frmMain_kat.izbrani_hsmid = dgv3.Rows[e.RowIndex].Cells[4].Value.ToString();
                frmMain_kat.iz_naselja = true;

                Stavba();
            }
            else
            {
                frmMain_kat.izbrana_oseba = dgv3.Rows[e.RowIndex].Cells[3].Value.ToString();
                frmMain_kat.iz_naselja = true;

                Oseba();
            }

        }

        private void dgv4_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (kazi_stavbe == true)
            {
                frmMain_kat.izbrani_hsmid = dgv4.Rows[e.RowIndex].Cells[4].Value.ToString();
                frmMain_kat.iz_naselja = true;

                Stavba();
            }
            else
            {
                frmMain_kat.izbrana_oseba = dgv4.Rows[e.RowIndex].Cells[3].Value.ToString();
                frmMain_kat.iz_naselja = true;

                Oseba();
            }

        }

        private void Oseba()
        {
            frmOseba form2 = new frmOseba();
            form2.ShowDialog();
        }

        private void FrmNaselje_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Escape)
                    this.DialogResult = DialogResult.Cancel;
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //MessageBox.Show(izbrani_naslov);
        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e) // sort po priimku
        {
            this.dgv2.Sort(this.dgv2.Columns["Oseba"], ListSortDirection.Ascending);
            //Vpisi_stalno(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kazi_osebe = true;
            kazi_stavbe = false;

            // stalno in začasno prijavljeni prebivalvi
            dgv4.Rows.Clear();
            dgv4.Refresh();
            dgv3.Rows.Clear();
            dgv3.Refresh();
            gb4.Text = "  Stalno prijavljeni prebivalci  ";
            gb6.Text = "  Začasno prijavljeni prebivalci  ";
            Vpisi_stalno(1);
            Vpisi_zacasno();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            kazi_osebe = false;
            kazi_stavbe = true;
            // pokaži stavbe z geznico
            dgv4.Rows.Clear();
            dgv4.Refresh();
            dgv3.Rows.Clear();
            dgv3.Refresh();
            gb4.Text = "  Stavbe z odvajanjem v greznico  ";
            gb6.Text = "  Stavbe brez kanalizacije in brez greznice  ";
            Vpisi_zgreznico();
            Vpisi_brezkaningrez();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            kazi_osebe = false;
            kazi_stavbe = true;
            // pokaži stavbe z geznico
            dgv4.Rows.Clear();
            dgv4.Refresh();
            dgv3.Rows.Clear();
            dgv3.Refresh();
            gb4.Text = "  Stavbe z odvajanjem v greznico  ";
            gb6.Text = "  Stavbe brez kanalizacije in brez greznice  ";
            Vpisi_zgreznico();
            Vpisi_brezkaningrez();
        }

    

    int kantmp, gretmp,brez_king,preb_brez_king,stalnotmp,zacasnotmp;


        // double a_povrsina = f_povrsina;


        public FrmNaselje()
        {
            InitializeComponent();
        }

        private void Preberi_namid(string arg)
        {
            string q = "select na_mid, na_uime from tbl_na where na_uime = @naselje";
            cmd = new SqlCommand(q, con);
            con.Open();
            cmd.Parameters.AddWithValue("@naselje", f_naselje); // preberi naselje
            cmd.ExecuteNonQuery();
            f_namid = (string)cmd.ExecuteScalar();
            con.Close();
            // MessageBox.Show(f_namid);
        }
        private void Stmanjkavcadis()
        {
            string q2 = "SELECT COUNT(*) FROM tbl_hise where cadis=0 and namid=@tna_mid";
            //q2 = "select vodovod from tbl_cad where hsmid = @thsmid";  // če sta indexa iz ulic enaka
            cmd2 = new SqlCommand(q2, con2);
            con2.Open();
            cmd2.Parameters.AddWithValue("@tna_mid", f_namid);
            cmd2.ExecuteNonQuery();
            Int32 count = (Int32)cmd2.ExecuteScalar();
            con2.Close();
            label44.Text = Convert.ToString(count);
        }
        private void Preberi_tblhise()
        {

            brez_king = 0;
            preb_brez_king = 0;
            string q = "select namid, hsmid,voda,kanalizacija,smeti,greznica,stalno,zacasno from tbl_hise where namid=@namid"; // preberi vse zapise iz tbl_na
            try
            {
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@namid", f_namid); // preberi naselje
                rdr = cmd.ExecuteReader();
                
                // Stavbe in prebivalci brez kanalizacije in greznice

                while (rdr.Read())
                {
                    kantmp = 0; gretmp = 0;stalnotmp = 0;zacasnotmp = 0;
                    kantmp = (Int32)rdr["kanalizacija"];
                    gretmp = (Int32)rdr["greznica"];  
                    stalnotmp = (Int32)rdr["stalno"];  
                    zacasnotmp = (Int32)rdr["zacasno"];  
                    if (kantmp == 0 && gretmp == 0)
                        {
                        preb_brez_king = preb_brez_king + stalnotmp + zacasnotmp;
                        brez_king++;
                        }
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Napaka rdr tblHise : " + ex2.Message);
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


        private void Vpisi_podatke()
        {
            int s_brez_v_proc, s_brez_v, s_brez_k, s_brez_k_proc;
            int p_brez_v_proc, p_brez_v, p_brez_k, p_brez_k_proc;
            int p_brez_s_proc, p_brez_s;
            int s_brez_s_proc, s_brez_s, preb_brez_king_proc, brez_king_proc;

            s_brez_v = f_stavb - f_v_stavb; // št. stavb brez vode
            s_brez_k = f_stavb - f_k_stavb; // št. stavb brez vode
            p_brez_v = f_prebivalcev - f_v_ljudi; // št. prebivalcev brez vode
            s_brez_v_proc = (100 * s_brez_v) / f_stavb;    // % stavb brez vode
            s_brez_k_proc = (100 * s_brez_k) / f_stavb;    // % stavb brez vode
            p_brez_v_proc = (100 * p_brez_v) / f_prebivalcev;    // % stavb brez vode

            s_brez_s = f_stavb - f_s_stavb; // št. stavb brez smeti
            p_brez_s = f_prebivalcev - f_s_ljudi; // št. prebivalcev brez smeti
            s_brez_s_proc = (100 * s_brez_s) / f_stavb;    // % stavb brez smeti
            p_brez_s_proc = (100 * p_brez_s) / f_prebivalcev;    // % stavb brez smeti
            preb_brez_king_proc = (100 * preb_brez_king) / f_prebivalcev;
            brez_king_proc = (100 * brez_king) / f_stavb;

            label22.Text = Convert.ToString(f_povrsina);
            label1.Text = f_naselje;
            label24.Text = Convert.ToString(f_prebivalcev);
            label28.Text = Convert.ToString(f_zacasnih);
            label27.Text = Convert.ToString(f_stalnih);
            label38.Text = Convert.ToString(brez_king) + "   (" + brez_king_proc + "%)";
            label36.Text = Convert.ToString(preb_brez_king) + "   (" + preb_brez_king_proc + "%)";
            label29.Text = Convert.ToString(f_stavb);
            label43.Text = Convert.ToString(f_v_stavb)+"   ("+f_v_procstavb+"%)";
            label39.Text = Convert.ToString(f_k_stavb) + "   (" + f_k_procstavb + "%)"; ;
            label35.Text = Convert.ToString(f_s_stavb) + "   (" + f_s_procstavb + "%)"; 
            label30.Text = Convert.ToString(s_brez_s) + "   (" + s_brez_s_proc + "%)";
            label41.Text = Convert.ToString(f_v_ljudi) + "   (" + f_v_procljudi + "%)";
            label42.Text = Convert.ToString(s_brez_v) + "   (" + s_brez_v_proc + "%)";
            label40.Text = Convert.ToString(p_brez_v) + "   (" + p_brez_v_proc + "%)"; 
            label37.Text = Convert.ToString(f_k_ljudi) + "   (" + f_k_procljudi + "%)"; 
            label31.Text = Convert.ToString(f_s_ljudi) + "   (" + f_s_procljudi + "%)"; 
            label32.Text = Convert.ToString(p_brez_s) + "   (" + p_brez_s_proc + "%)";
            label46.Text = Convert.ToString(s_brez_k) + "   (" + s_brez_k_proc + "%)";

            label33.Text = Convert.ToString(f_g_stavb) + "   (" + f_g_procstavb + "%)";
            label34.Text = Convert.ToString(f_g_ljudi) + "   (" + f_g_procljudi + "%)";
            Stmanjkavcadis();
            // label34.Text = Convert.ToString(f_g_ljudi);

            //f_v_procstavb = frmMain.a_v_procstavb;
            //f_k_procstavb = frmMain.a_k_procstavb;
            //f_s_procstavb = frmMain.a_s_procstavb;
            //f_g_procstavb = frmMain.a_g_procstavb;
            //f_v_procljudi = frmMain.a_v_procljudi;
            //f_k_procljudi = frmMain.a_k_procljudi;
            //f_s_procljudi = frmMain.a_s_procljudi;
            //f_g_procljudi = frmMain.a_g_procljudi;

        }
        private void Variable()
        {
            f_naselje = frmMain_kat.a_naselje;
            Preberi_namid(f_naselje);
            f_povrsina = frmMain_kat.a_povrsina;
            f_prebivalcev = frmMain_kat.a_prebivalcev;
            f_zacasnih = frmMain_kat.a_zacasnih;
            f_stalnih = frmMain_kat.a_stalnih;
            f_stavb = frmMain_kat.a_stavb;
            f_v_stavb = frmMain_kat.a_v_stavb;
            f_k_stavb = frmMain_kat.a_k_stavb;
            f_s_stavb = frmMain_kat.a_s_stavb;
            f_g_stavb = frmMain_kat.a_g_stavb;
            f_v_ljudi = frmMain_kat.a_v_ljudi;
            f_k_ljudi = frmMain_kat.a_k_ljudi;
            f_s_ljudi = frmMain_kat.a_s_ljudi;
            f_g_ljudi = frmMain_kat.a_g_ljudi;
            f_v_procstavb = frmMain_kat.a_v_procstavb;
            f_k_procstavb = frmMain_kat.a_k_procstavb;
            f_s_procstavb = frmMain_kat.a_s_procstavb;
            f_g_procstavb = frmMain_kat.a_g_procstavb;
            f_v_procljudi = frmMain_kat.a_v_procljudi;
            f_k_procljudi = frmMain_kat.a_k_procljudi;
            f_s_procljudi = frmMain_kat.a_s_procljudi;
            f_g_procljudi = frmMain_kat.a_g_procljudi;
        }

        public class MyDetails
        {
            private string age;

            public string Age
            {
                get { return age; }
                set { age = value; }
            }
            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            private int id;

            public int Id
            {
                get { return id; }
                set { id = value; }
            }
        }

        private void Vpisi_naselja2()
        {

            //dgv5.ColumnHeadersVisible = false;
            //dgv5.RowHeadersVisible = false;
            //dgv5.ColumnCount = 6;
            //dgv5.Columns[1].Width = 226;

            //dgv5.Columns[0].Name = "Id";
            //dgv5.Columns[1].Name = "Naselje";
            //dgv5.Columns[2].Name = "labela";
            ////dgv5.Columns[3].Name = "Ulica";
            ////dgv5.Columns[4].Name = "Hs_mid";
            ////dgv5.Columns[5].Name = "Ul_mid";
            ////dgv5.Columns[6].Name = "Na_mid";

            //dgv5.Columns[0].Visible = false;
            //dgv5.Columns[1].Visible = false;
            //dgv5.Columns[2].Visible = false;
            //dgv5.Columns["Hs_mid"].Visible = false;
            //dgv5.Columns["Ul_mid"].Visible = false;
            //dgv5.Columns["Na_mid"].Visible = false;


            //string q = "select id, ulica, hsmid, namid,ulmid, hs,hd,labela,naselje from tbl_hise where namid=@tmpnamid order by ulica, hs,hd desc"; // preberi vse zapise iz tbl_hise

            
            ////con.Open();

            //var da = new SqlDataAdapter(q, con);
            //var commandBuilder = new SqlCommandBuilder(da);
            ////cmd = new SqlCommand(q, con); 
            //var ds = new DataSet();
            //da.SelectCommand.Parameters.Add("@tmpnamid", f_namid);
            //da.Fill(ds);
            //dgv5.ReadOnly = true;
            //dgv5.DataSource = ds.Tables[0];

            //string q = "select id, ulica, hsmid, namid,ulmid, hs,hd,labela,naselje from tbl_hise where namid=@tmpnamid order by ulica, hs,hd desc"; // preberi vse zapise iz tbl_hise
            ////Connection c = new Connection();
            //SqlDataAdapter dataAdapter = new SqlDataAdapter(q, con); //c.con is the connection string
            //SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            //DataTable table = new DataTable();
            //table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            //dataAdapter.Fill(table);
            //BindingSource bs1 = new BindingSource();
            //bs1.DataSource = table;

            //dgv5.ReadOnly = true;
            //dgv5.DataSource = bs1;

//            dgv1.ColumnHeadersVisible = false;
//            dgv1.RowHeadersVisible = false;
//            dgv1.ColumnCount = 7;
//            dgv1.Columns[1].Width = 226;

//            dgv1.Columns[0].Name = "Id";
//            dgv1.Columns[1].Name = "Naselje";
//            dgv1.Columns[2].Name = "labela";
//            dgv1.Columns[3].Name = "Ulica";
//            dgv1.Columns[4].Name = "Hs_mid";
//            dgv1.Columns[5].Name = "Ul_mid";
//            dgv1.Columns[6].Name = "Na_mid";

//            dgv1.Columns["Id"].Visible = false;
//            dgv1.Columns["labela"].Visible = false;
//            dgv1.Columns["Ulica"].Visible = false;
//            dgv1.Columns["Hs_mid"].Visible = false;
//            dgv1.Columns["Ul_mid"].Visible = false;
//            dgv1.Columns["Na_mid"].Visible = false;

//            try
//            {
//                string q = "select id, ulica, hsmid, namid,ulmid, hs,hd,labela,naselje from tbl_hise where namid=@tmpnamid order by ulica, hs,hd desc"; // preberi vse zapise iz tbl_hise
//                cmd = new SqlCommand(q, con);
//                con.Open();
//                cmd.Parameters.AddWithValue("@tmpnamid", f_namid);
//                rdr = cmd.ExecuteReader();
//                while (rdr.Read())
//                {
//                    tmpid = (int)rdr["id"];
//                    tmphsmid = (string)rdr["hsmid"];
//                    tmpnamid = (string)rdr["namid"];
//                    tmpulmid = (string)rdr["ulmid"];
//                    tmpnaselje = (string)rdr["naselje"];
//                    tmplabela = (string)rdr["labela"];
//                    tmpulica = (string)rdr["ulica"];
//                    if (tmpulica != "")
//                    {
//                        tmpnaselje = tmpulica;
//                    }
//                    tmpnaselje2 = tmpnaselje;
//                    tmpnaselje = tmpnaselje + "   " + tmplabela;

//                    // preberi ljudi na tem naslovu
//                    string q2 = "select id, priimek1, priimek2, ime1, ime2, hsmid, hs_na from tbl_crp where hsmid=@tmphsmid order by priimek1 desc"; // preberi vse osebe iz naselja
//                    try
//                    {
//                        cmd2 = new SqlCommand(q2, con2);
//                        con2.Open();
//                        cmd2.Parameters.AddWithValue("@tmphsmid", tmphsmid);
//                        rdr2 = cmd2.ExecuteReader();
//                        while (rdr2.Read())
//                        {
//                            tpriimek1 = (string)rdr2["priimek1"];
//                            tpriimek2 = (string)rdr2["priimek2"];
//                            time1 = (string)rdr2["ime1"];
//                            time2 = (string)rdr2["ime2"];
//                            tid = (int)rdr2["id"];
//                            if (tpriimek2 != "")
//                            {
//                                tpriimek2 = " " + tpriimek2;
//                            }
//                            time1 = " " + time1;
//                            if (time2 != "")
//                            {
//                                time2 = " " + time2;
//                            }
//                            string tidstr = Convert.ToString(tid);
//                            string oseba = "      " + tpriimek1 + tpriimek2 + time1 + time2 + "   -   " + tmplabela + "    " + tmpnaselje;
//                            string[] row2 = new string[] { oseba, tmpnaselje2, tmplabela };
//                            dgv2.Rows.Add(row2);

//                        }  // while read
//                    }
//                    catch (Exception ex)
//                    {
//                        MessageBox.Show("Napaka reader2: " + ex.Message);
//                    }
//                    finally
//                    {
//                        rdr2.Close();
//                        con2.Close();
//                    }
//                    // this.dgv2.Sort(this.dgv2.Columns["Oseba"], ListSortDirection.Ascending);

//                    // konec branja ljudi
//                    string tmpidstr = Convert.ToString(tmpid);
//                    string[] row = new string[] { tmpidstr, "      " + tmpnaselje, tmplabela, tmpulica, tmphsmid, tmpulmid, tmpnamid };
//                    dgv1.Rows.Add(row);
//                }  // while read
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Napaka reader: " + ex.Message);
//            }
//            finally
//            {
//                rdr.Close();

//                con.Close();
////                this.dgv2.Sort(this.dgv2.Columns["Oseba"], ListSortDirection.Ascending);
//            }
        }

        private void Vpisi_naselja()
        {
            dgv1.ColumnHeadersVisible = false;
            dgv1.RowHeadersVisible = false;
            dgv1.ColumnCount = 7;
            dgv1.Columns[1].Width = 226;

            dgv1.Columns[0].Name = "Id";
            dgv1.Columns[1].Name = "Naselje";
            dgv1.Columns[2].Name = "labela";
            dgv1.Columns[3].Name = "Ulica";
            dgv1.Columns[4].Name = "Hs_mid";
            dgv1.Columns[5].Name = "Ul_mid";
            dgv1.Columns[6].Name = "Na_mid";

            dgv1.Columns["Id"].Visible = false;
            dgv1.Columns["labela"].Visible = false;
            dgv1.Columns["Ulica"].Visible = false;
            dgv1.Columns["Hs_mid"].Visible = false;
            dgv1.Columns["Ul_mid"].Visible = false;
            dgv1.Columns["Na_mid"].Visible = false;

            dgv2.ColumnHeadersVisible = false;
            dgv2.RowHeadersVisible = false;
            dgv2.ColumnCount = 4;
            dgv2.Columns[0].Width = 300;


            dgv2.Columns[0].Name = "Oseba";
            dgv2.Columns[1].Name = "Naslov";
            dgv2.Columns[2].Name = "Labela";
            dgv2.Columns[3].Name = "Indeks";
            //dgv2.Columns[1].Name = "Id";

            dgv2.Columns["Oseba"].Visible = true;
            dgv2.Columns["Naslov"].Visible = false;
            dgv2.Columns["Labela"].Visible = false;
            dgv2.Columns["Indeks"].Visible = false;
            //dgv2.Columns["Id"].Visible = true;

            try
            {
                string q = "select id, ulica, hsmid, namid,ulmid, hs,hd,labela,naselje from tbl_hise where namid=@tmpnamid order by ulica, hs,hd desc"; // preberi vse zapise iz tbl_hise
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@tmpnamid", f_namid);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpid = (int)rdr["id"];
                    tmphsmid = (string)rdr["hsmid"];
                    tmpnamid = (string)rdr["namid"];
                    tmpulmid = (string)rdr["ulmid"];
                    tmpnaselje = (string)rdr["naselje"];
                    tmplabela = (string)rdr["labela"];
                    tmpulica = (string)rdr["ulica"];
                    
                    if (tmpulica != "")
                    {
                        tmpnaselje = tmpulica;
                    }
                    tmpnaselje2 = tmpnaselje;
                    tmpnaselje = tmpnaselje + "   " + tmplabela;

                    // preberi ljudi na tem naslovu
                    string q2 = "select id, indeks_osebe,priimek1, priimek2, ime1, ime2, hsmid, hs_na from tbl_crp where hsmid=@tmphsmid order by priimek1 desc"; // preberi vse osebe iz naselja
                    try
                    {
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@tmphsmid", tmphsmid);
                        rdr2 = cmd2.ExecuteReader();
                        while (rdr2.Read())
                        {
                            tpriimek1 = (string)rdr2["priimek1"];
                            tpriimek2 = (string)rdr2["priimek2"];
                            time1 = (string)rdr2["ime1"];
                            time2 = (string)rdr2["ime2"];
                            tid = (int)rdr2["id"];
                            tmpindeks_osebe = (string)rdr2["indeks_osebe"];
                            if (tpriimek2 != "")
                            {
                                tpriimek2 = " " + tpriimek2;
                            }
                            time1 = " " + time1;
                            if (time2 != "")
                            {
                                time2 = " " + time2;
                            }
                            string tidstr = Convert.ToString(tid);
                            string oseba = "      " + tpriimek1 + tpriimek2 + time1 + time2 + "   -   " + tmplabela + "    " + tmpnaselje;
                            string[] row2 = new string[] { oseba,tmpnaselje2,tmplabela,tmpindeks_osebe};
                            dgv2.Rows.Add(row2);

                        }  // while read
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka reader2: " + ex.Message);
                    }
                    finally
                    {
                        rdr2.Close();
                        con2.Close();
                    }
                    // this.dgv2.Sort(this.dgv2.Columns["Oseba"], ListSortDirection.Ascending);
                    
                    // konec branja ljudi
                    string tmpidstr = Convert.ToString(tmpid);
                    string[] row = new string[] { tmpidstr, "      " + tmpnaselje, tmplabela, tmpulica, tmphsmid, tmpulmid, tmpnamid };
                    dgv1.Rows.Add(row);
                }  // while read
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
                this.dgv2.Sort(this.dgv2.Columns["Oseba"], ListSortDirection.Ascending);
            }
        }

        private void Vpisi_stalno(int vhod)  // vpiši stalno prijavljene ljudi
        {
            string q;
            dgv3.ColumnHeadersVisible = false;
            dgv3.RowHeadersVisible = false;
            dgv3.ColumnCount = 4;
            dgv3.Columns[0].Width = 300;


            dgv3.Columns[0].Name = "Oseba";
            dgv3.Columns[1].Name = "Naslov";
            dgv3.Columns[2].Name = "Labela";
            dgv3.Columns[3].Name = "Indeks";

            //dgv3.Columns[1].Name = "Id";

            dgv3.Columns["Oseba"].Visible = true;
            dgv3.Columns["Naslov"].Visible = false;
            dgv3.Columns["Labela"].Visible = false;
            dgv3.Columns["Indeks"].Visible = false;
            //dgv3.Columns["Id"].Visible = true;

            try
            {
                if (vhod==1) // sort po priimku
                    q = "select id, ulica, hsmid, namid,ulmid, hs,hd,labela,naselje from tbl_hise where namid=@tmpnamid order by ulica, hs,hd desc"; // preberi vse zapise iz tbl_hise
                else
                    // sort po naslovu
                    q = "select id, ulica, hsmid, namid,ulmid, hs,hd,labela,naselje from tbl_hise where namid=@tmpnamid order by ulica, hs,hd desc"; // preberi vse zapise iz tbl_hise
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@tmpnamid", f_namid);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpid = (int)rdr["id"];
                    tmphsmid = (string)rdr["hsmid"];
                    tmpnamid = (string)rdr["namid"];
                    tmpulmid = (string)rdr["ulmid"];
                    tmpnaselje = (string)rdr["naselje"];
                    tmplabela = (string)rdr["labela"];
                    tmpulica = (string)rdr["ulica"];
                    if (tmpulica != "")
                    {
                        tmpnaselje = tmpulica;
                    }
                    tmpnaselje =  tmpnaselje + "   " + tmplabela;

                    // preberi ljudi na tem naslovu
                    string q2 = "select id,indeks_osebe, priimek1, priimek2, ime1, ime2, hsmid, hs_na from tbl_crp where hsmid=@tmphsmid and stalno=1 and zacasno=0 order by priimek1 desc"; // preberi vse osebe iz naselja
                    try
                    {
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@tmphsmid", tmphsmid);
                        rdr2 = cmd2.ExecuteReader();
                        while (rdr2.Read())
                        {
                            tpriimek1 = (string)rdr2["priimek1"];
                            tpriimek2 = (string)rdr2["priimek2"];
                            time1 = (string)rdr2["ime1"];
                            time2 = (string)rdr2["ime2"];
                            tid = (int)rdr2["id"];
                            tmpindeks_osebe = (string)rdr2["indeks_osebe"];

                            if (tpriimek2!="")
                            {
                                tpriimek2 = " " + tpriimek2;
                            }
                            time1 = " " + time1;
                            if (time2 != "")
                            {
                                time2 = " " + time2;
                            }
                            string tidstr = Convert.ToString(tid);
                            string oseba = "      "+tpriimek1 + tpriimek2 + time1 + time2 + "   -   "+tmplabela+"    "+tmpnaselje;
                            string[] row2 = new string[] { oseba, tmpnaselje, tmplabela, tmpindeks_osebe};

                            dgv3.Rows.Add(row2);

                        }  // while read
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka reader2 stalno: " + ex.Message);
                    }
                    finally
                    {
                        rdr2.Close();
                        con2.Close();
                    }
                   // this.dgv2.Sort(this.dgv2.Columns["Oseba"], ListSortDirection.Ascending);

                    // konec branja ljudi
                    //string tmpidstr = Convert.ToString(tmpid);
                    //string[] row = new string[] { tmpidstr, "      " + tmpnaselje, tmplabela, tmpulica, tmphsmid, tmpulmid, tmpnamid };
                    //dgv1.Rows.Add(row);
                }  // while read
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }
        }

        private void Vpisi_zacasno()  // vpiši stalno prijavljene ljudi
        {
            dgv4.ColumnHeadersVisible = false;
            dgv4.RowHeadersVisible = false;
            dgv4.ColumnCount = 4;
            dgv4.Columns[0].Width = 300;


            dgv4.Columns[0].Name = "Oseba";
            dgv4.Columns[1].Name = "Naslov";
            dgv4.Columns[2].Name = "Labela";
            dgv4.Columns[3].Name = "Indeks";

            //dgv4.Columns[1].Name = "Id";

            dgv4.Columns["Oseba"].Visible = true;
            dgv4.Columns["Naslov"].Visible = false;
            dgv4.Columns["Labela"].Visible = false;
            dgv4.Columns["Indeks"].Visible = false;

            //dgv4.Columns["Id"].Visible = true;

            try
            {
                string q = "select id, ulica, hsmid, namid,ulmid, hs,hd,labela,naselje from tbl_hise where namid=@tmpnamid order by ulica, hs,hd desc"; // preberi vse zapise iz tbl_hise
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@tmpnamid", f_namid);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpid = (int)rdr["id"];
                    tmphsmid = (string)rdr["hsmid"];
                    tmpnamid = (string)rdr["namid"];
                    tmpulmid = (string)rdr["ulmid"];
                    tmpnaselje = (string)rdr["naselje"];
                    tmplabela = (string)rdr["labela"];
                    tmpulica = (string)rdr["ulica"];
                    if (tmpulica != "")
                    {
                        tmpnaselje = tmpulica;
                    }
                    tmpnaselje = tmpnaselje + "   " + tmplabela;

                    // preberi ljudi na tem naslovu
                    string q2 = "select id,indeks_osebe, priimek1, priimek2, ime1, ime2, hsmid, hs_na from tbl_crp where hsmid=@tmphsmid and stalno=0 and zacasno=1 order by priimek1 desc"; // preberi vse osebe iz naselja
                    try
                    {
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@tmphsmid", tmphsmid);
                        rdr2 = cmd2.ExecuteReader();
                        while (rdr2.Read())
                        {
                            tpriimek1 = (string)rdr2["priimek1"];
                            tpriimek2 = (string)rdr2["priimek2"];
                            time1 = (string)rdr2["ime1"];
                            time2 = (string)rdr2["ime2"];
                            tid = (int)rdr2["id"];
                            tmpindeks_osebe = (string)rdr2["indeks_osebe"];

                            if (tpriimek2 != "")
                            {
                                tpriimek2 = " " + tpriimek2;
                            }
                            time1 = " " + time1;
                            if (time2 != "")
                            {
                                time2 = " " + time2;
                            }
                            string tidstr = Convert.ToString(tid);
                            string oseba = "      " + tpriimek1 + tpriimek2 + time1 + time2 + "   -   " + tmplabela + "    " + tmpnaselje;
                            //string[] row2 = new string[] { oseba, tidstr };
//                            string[] row2 = new string[] { oseba};
                            string[] row2 = new string[] { oseba, tmpnaselje, tmplabela, tmpindeks_osebe };

                            dgv4.Rows.Add(row2);

                        }  // while read
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka reader2 zacasno: " + ex.Message);
                    }
                    finally
                    {
                        rdr2.Close();
                        con2.Close();
                    }
                    // this.dgv2.Sort(this.dgv2.Columns["Oseba"], ListSortDirection.Ascending);

                    // konec branja ljudi
                    //string tmpidstr = Convert.ToString(tmpid);
                    //string[] row = new string[] { tmpidstr, "      " + tmpnaselje, tmplabela, tmpulica, tmphsmid, tmpulmid, tmpnamid };
                    //dgv1.Rows.Add(row);
                }  // while read
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }
        }



        private void Vpisi_ljudi()
        {
            dgv2.ColumnHeadersVisible = true;
            dgv2.RowHeadersVisible = false;
            dgv2.ColumnCount = 7;
            dgv2.Columns[1].Width = 226;


            dgv2.Columns[0].Name = "Id";
            dgv2.Columns[1].Name = "Naselje";
            dgv2.Columns[2].Name = "labela";
            dgv2.Columns[3].Name = "Ulica";
            dgv2.Columns[4].Name = "Hs_mid";
            dgv2.Columns[5].Name = "Ul_mid";
            dgv2.Columns[6].Name = "Na_mid";

            dgv2.Columns["Id"].Visible = false;
            dgv2.Columns["Naselje"].Visible = true;

            dgv2.Columns["labela"].Visible = false;
            dgv2.Columns["Ulica"].Visible = false;
            dgv2.Columns["Hs_mid"].Visible = false;
            dgv2.Columns["Ul_mid"].Visible = false;
            dgv2.Columns["Na_mid"].Visible = false;
            try
            {
                string q = "select id, ulica, hsmid, namid,ulmid, hs,hd,labela,naselje from tbl_hise where namid=@tmpnamid order by hs,hd desc"; // preberi vse zapise iz tbl_hise
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@tmpnamid", f_namid);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpid = (int)rdr["id"];
                    tmphsmid = (string)rdr["hsmid"];
                    tmpnamid = (string)rdr["namid"];
                    tmpulmid = (string)rdr["ulmid"];
                    tmpnaselje = (string)rdr["naselje"];
                    tmplabela = (string)rdr["labela"];
                    tmpulica = (string)rdr["ulica"];
                    if (tmpulica!="")
                       {
                           tmpnaselje = tmpulica;
                        }
                        tmpnaselje = "  "+tmpnaselje + " " + tmplabela;
                    string tmpidstr = Convert.ToString(tmpid);
                    string[] row = new string[] { tmpidstr, tmpnaselje, tmplabela,tmpulica,tmphsmid,tmpulmid,tmpnamid};
                    dgv2.Rows.Add(row);
                }  // while read
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }
        }

        private void FrmNaselje_Load(object sender, EventArgs e)
        {

            kazi_osebe = false;
            kazi_stavbe = true;
            Variable();
            Preberi_tblhise();
            Vpisi_podatke();
            Vpisi_naselja();
            Vpisi_naselja2();
            Vpisi_zvodo();
            Vpisi_brezvode();

            // Vpisi_ljudi();
            //          MessageBox.Show(Convert.ToString(f_naselje));
        }

        private void Vpisi_zvodo()
        {
            gb4.Text = "  Stavbe na javnem vodovodu  ";
            dgv3.ColumnHeadersVisible = false;
            dgv3.RowHeadersVisible = false;
            dgv3.ColumnCount = 7;
            dgv3.Columns[1].Width = 226;

            dgv3.Columns[0].Name = "Id";
            dgv3.Columns[1].Name = "Naselje";
            dgv3.Columns[2].Name = "labela";
            dgv3.Columns[3].Name = "Ulica";
            dgv3.Columns[4].Name = "Hs_mid";
            dgv3.Columns[5].Name = "Ul_mid";
            dgv3.Columns[6].Name = "Na_mid";

            dgv3.Columns["Id"].Visible = false;
            dgv3.Columns["Naselje"].Visible = true;
            dgv3.Columns["labela"].Visible = false;
            dgv3.Columns["Ulica"].Visible = false;
            dgv3.Columns["Hs_mid"].Visible = false;
            dgv3.Columns["Ul_mid"].Visible = false;
            dgv3.Columns["Na_mid"].Visible = false;
            try
            {
                string q = "select id, ulica, hsmid, namid,ulmid, hs,hd,labela,naselje from tbl_hise where namid=@tmpnamid and voda=1 order by ulica, hs,hd desc"; // preberi vse zapise iz tbl_hise
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@tmpnamid", f_namid);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpid = (int)rdr["id"];
                    tmphsmid = (string)rdr["hsmid"];
                    tmpnamid = (string)rdr["namid"];
                    tmpulmid = (string)rdr["ulmid"];
                    tmpnaselje = (string)rdr["naselje"];
                    tmplabela = (string)rdr["labela"];
                    tmpulica = (string)rdr["ulica"];
                    if (tmpulica != "")
                    {
                        tmpnaselje = tmpulica;
                    }
                    tmpnaselje = tmpnaselje + "   " + tmplabela;

                    string tmpidstr = Convert.ToString(tmpid);
                    string[] row = new string[] { tmpidstr, "      " + tmpnaselje, tmplabela, tmpulica, tmphsmid, tmpulmid, tmpnamid };
                    dgv3.Rows.Add(row);
                }  // while read
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }
        }

        private void Vpisi_brezvode()
        {
            gb6.Text = "  Stavbe brez vodovoda  ";
            dgv4.ColumnHeadersVisible = false;
            dgv4.RowHeadersVisible = false;
            dgv4.ColumnCount = 7;
            dgv4.Columns[1].Width = 350;
            // dgv4.ScrollBars = "Both";

            dgv4.Columns[0].Name = "Id";
            dgv4.Columns[1].Name = "Naselje";
            dgv4.Columns[2].Name = "labela";
            dgv4.Columns[3].Name = "Ulica";
            dgv4.Columns[4].Name = "Hs_mid";
            dgv4.Columns[5].Name = "Ul_mid";
            dgv4.Columns[6].Name = "Na_mid";

            dgv4.Columns["Id"].Visible = false;
            dgv4.Columns["labela"].Visible = false;
            dgv4.Columns["Naselje"].Visible = true;

            dgv4.Columns["Ulica"].Visible = false;
            dgv4.Columns["Hs_mid"].Visible = false;
            dgv4.Columns["Ul_mid"].Visible = false;
            dgv4.Columns["Na_mid"].Visible = false;
            try
            {
                string q = "select id, ulica, hsmid, namid,ulmid, hs,hd,labela,naselje,cadis from tbl_hise where namid=@tmpnamid and voda=0 order by ulica, hs,hd desc"; // preberi vse zapise iz tbl_hise
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@tmpnamid", f_namid);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpid = (int)rdr["id"];
                    tmphsmid = (string)rdr["hsmid"];
                    tmpnamid = (string)rdr["namid"];
                    tmpulmid = (string)rdr["ulmid"];
                    tmpnaselje = (string)rdr["naselje"];
                    tmplabela = (string)rdr["labela"];
                    tmpulica = (string)rdr["ulica"];
                    tmpcadis = (int)rdr["cadis"];

                    if (tmpulica != "")
                    {
                        tmpnaselje = tmpulica;
                    }
                    tmpnaselje = tmpnaselje + "   " + tmplabela;
                    if (tmpcadis != 1)
                    {
                        tmpnaselje = tmpnaselje+" (Ni v Cadis)";
                    }
//                    tmpnaselje = tmpnaselje + "   " + tmplabela;


                    string tmpidstr = Convert.ToString(tmpid);
                    string[] row = new string[] { tmpidstr, "      " + tmpnaselje, tmplabela, tmpulica, tmphsmid, tmpulmid, tmpnamid };
                    dgv4.Rows.Add(row);
                }  // while read
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }
        }


        private void Vpisi_cadis()
        {
//            gb6.Text = "  Stavbe brez vodovoda  ";
            dgv3.ColumnHeadersVisible = false;
            dgv3.RowHeadersVisible = false;
            dgv3.ColumnCount = 7;
            dgv3.Columns[1].Width = 350;
            // dgv4.ScrollBars = "Both";

            dgv3.Columns[0].Name = "Id";
            dgv3.Columns[1].Name = "Naselje";
            dgv3.Columns[2].Name = "labela";
            dgv3.Columns[3].Name = "Ulica";
            dgv3.Columns[4].Name = "Hs_mid";
            dgv3.Columns[5].Name = "Ul_mid";
            dgv3.Columns[6].Name = "Na_mid";

            dgv3.Columns["Id"].Visible = false;
            dgv3.Columns["Naselje"].Visible = true;

            dgv3.Columns["labela"].Visible = false;
            dgv3.Columns["Ulica"].Visible = false;
            dgv3.Columns["Hs_mid"].Visible = false;
            dgv3.Columns["Ul_mid"].Visible = false;
            dgv3.Columns["Na_mid"].Visible = false;
            try
            {
                string q = "select id, ulica, hsmid, namid,ulmid, hs,hd,labela,naselje,cadis from tbl_hise where namid=@tmpnamid and cadis=0 order by ulica, hs,hd desc"; // preberi vse zapise iz tbl_hise
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@tmpnamid", f_namid);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpid = (int)rdr["id"];
                    tmphsmid = (string)rdr["hsmid"];
                    tmpnamid = (string)rdr["namid"];
                    tmpulmid = (string)rdr["ulmid"];
                    tmpnaselje = (string)rdr["naselje"];
                    tmplabela = (string)rdr["labela"];
                    tmpulica = (string)rdr["ulica"];
                    tmpcadis = (int)rdr["cadis"];

                    if (tmpulica != "")
                    {
                        tmpnaselje = tmpulica;
                    }
                    tmpnaselje = tmpnaselje + "   " + tmplabela;

                    string tmpidstr = Convert.ToString(tmpid);
                    string[] row = new string[] { tmpidstr, "      " + tmpnaselje, tmplabela, tmpulica, tmphsmid, tmpulmid, tmpnamid };
                    dgv3.Rows.Add(row);
                }  // while read
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }
        }


        private void Vpisi_zodpadki()
        {
            //gb4.Text = "  Stavbe na javnem vodovodu  ";
            dgv3.ColumnHeadersVisible = false;
            dgv3.RowHeadersVisible = false;
            dgv3.ColumnCount = 7;
            dgv3.Columns[1].Width = 226;

            dgv3.Columns[0].Name = "Id";
            dgv3.Columns[1].Name = "Naselje";
            dgv3.Columns[2].Name = "labela";
            dgv3.Columns[3].Name = "Ulica";
            dgv3.Columns[4].Name = "Hs_mid";
            dgv3.Columns[5].Name = "Ul_mid";
            dgv3.Columns[6].Name = "Na_mid";

            dgv3.Columns["Id"].Visible = false;
            dgv3.Columns["labela"].Visible = false;
            dgv3.Columns["Naselje"].Visible = true;

            dgv3.Columns["Ulica"].Visible = false;
            dgv3.Columns["Hs_mid"].Visible = false;
            dgv3.Columns["Ul_mid"].Visible = false;
            dgv3.Columns["Na_mid"].Visible = false;
            try
            {
                string q = "select id, ulica, hsmid, namid,ulmid, hs,hd,labela,naselje from tbl_hise where namid=@tmpnamid and smeti=1 order by ulica, hs,hd desc"; // preberi vse zapise iz tbl_hise
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@tmpnamid", f_namid);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpid = (int)rdr["id"];
                    tmphsmid = (string)rdr["hsmid"];
                    tmpnamid = (string)rdr["namid"];
                    tmpulmid = (string)rdr["ulmid"];
                    tmpnaselje = (string)rdr["naselje"];
                    tmplabela = (string)rdr["labela"];
                    tmpulica = (string)rdr["ulica"];
                    if (tmpulica != "")
                    {
                        tmpnaselje = tmpulica;
                    }
                    tmpnaselje = tmpnaselje + "   " + tmplabela;

                    string tmpidstr = Convert.ToString(tmpid);
                    string[] row = new string[] { tmpidstr, "      " + tmpnaselje, tmplabela, tmpulica, tmphsmid, tmpulmid, tmpnamid };
                    dgv3.Rows.Add(row);
                }  // while read
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }
        }

        private void Vpisi_brezodpadkov()
        {
            //gb6.Text = "  Stavbe brez vodovoda  ";
            dgv4.ColumnHeadersVisible = false;
            dgv4.RowHeadersVisible = false;
            dgv4.ColumnCount = 7;
            dgv4.Columns[1].Width = 350;
            // dgv4.ScrollBars = "Both";

            dgv4.Columns[0].Name = "Id";
            dgv4.Columns[1].Name = "Naselje";
            dgv4.Columns[2].Name = "labela";
            dgv4.Columns[3].Name = "Ulica";
            dgv4.Columns[4].Name = "Hs_mid";
            dgv4.Columns[5].Name = "Ul_mid";
            dgv4.Columns[6].Name = "Na_mid";

            dgv4.Columns["Id"].Visible = false;
            dgv4.Columns["labela"].Visible = false;
            dgv4.Columns["Naselje"].Visible = true;

            dgv4.Columns["Ulica"].Visible = false;
            dgv4.Columns["Hs_mid"].Visible = false;
            dgv4.Columns["Ul_mid"].Visible = false;
            dgv4.Columns["Na_mid"].Visible = false;
            try
            {
                string q = "select id, ulica, hsmid, namid,ulmid, hs,hd,labela,naselje,cadis from tbl_hise where namid=@tmpnamid and smeti=0 order by ulica, hs,hd desc"; // preberi vse zapise iz tbl_hise
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@tmpnamid", f_namid);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpid = (int)rdr["id"];
                    tmphsmid = (string)rdr["hsmid"];
                    tmpnamid = (string)rdr["namid"];
                    tmpulmid = (string)rdr["ulmid"];
                    tmpnaselje = (string)rdr["naselje"];
                    tmplabela = (string)rdr["labela"];
                    tmpulica = (string)rdr["ulica"];
                    tmpcadis = (int)rdr["cadis"];

                    if (tmpulica != "")
                    {
                        tmpnaselje = tmpulica;
                    }
                    tmpnaselje = tmpnaselje + "   " + tmplabela;
                    if (tmpcadis != 1)
                    {
                        tmpnaselje = tmpnaselje + " (Ni v Cadis)";
                    }
                    //                    tmpnaselje = tmpnaselje + "   " + tmplabela;


                    string tmpidstr = Convert.ToString(tmpid);
                    string[] row = new string[] { tmpidstr, "      " + tmpnaselje, tmplabela, tmpulica, tmphsmid, tmpulmid, tmpnamid };
                    dgv4.Rows.Add(row);
                }  // while read
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }
        }

        private void Vpisi_zgreznico()
        {
            dgv3.ColumnHeadersVisible = false;
            dgv3.RowHeadersVisible = false;
            dgv3.ColumnCount = 7;
            dgv3.Columns[1].Width = 226;

            dgv3.Columns[0].Name = "Id";
            dgv3.Columns[1].Name = "Naselje";
            dgv3.Columns[2].Name = "labela";
            dgv3.Columns[3].Name = "Ulica";
            dgv3.Columns[4].Name = "Hs_mid";
            dgv3.Columns[5].Name = "Ul_mid";
            dgv3.Columns[6].Name = "Na_mid";

            dgv3.Columns["Id"].Visible = false;
            dgv3.Columns["labela"].Visible = false;
            dgv3.Columns["Naselje"].Visible = true;

            dgv3.Columns["Ulica"].Visible = false;
            dgv3.Columns["Hs_mid"].Visible = false;
            dgv3.Columns["Ul_mid"].Visible = false;
            dgv3.Columns["Na_mid"].Visible = false;
            try
            {
                string q = "select id, ulica, hsmid, namid,ulmid, hs,hd,labela,naselje from tbl_hise where namid=@tmpnamid and greznica=1 order by ulica, hs,hd desc"; // preberi vse zapise iz tbl_hise
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@tmpnamid", f_namid);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpid = (int)rdr["id"];
                    tmphsmid = (string)rdr["hsmid"];
                    tmpnamid = (string)rdr["namid"];
                    tmpulmid = (string)rdr["ulmid"];
                    tmpnaselje = (string)rdr["naselje"];
                    tmplabela = (string)rdr["labela"];
                    tmpulica = (string)rdr["ulica"];
                    if (tmpulica != "")
                    {
                        tmpnaselje = tmpulica;
                    }
                    tmpnaselje = tmpnaselje + "   " + tmplabela;

                    string tmpidstr = Convert.ToString(tmpid);
                    string[] row = new string[] { tmpidstr, "      " + tmpnaselje, tmplabela, tmpulica, tmphsmid, tmpulmid, tmpnamid };
                    dgv3.Rows.Add(row);
                }  // while read
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }
        }

        private void Vpisi_brezkaningrez()
        {
            dgv4.ColumnHeadersVisible = false;
            dgv4.RowHeadersVisible = false;
            dgv4.ColumnCount = 7;
            dgv4.Columns[1].Width = 350;

            dgv4.Columns[0].Name = "Id";
            dgv4.Columns[1].Name = "Naselje";
            dgv4.Columns[2].Name = "labela";
            dgv4.Columns[3].Name = "Ulica";
            dgv4.Columns[4].Name = "Hs_mid";
            dgv4.Columns[5].Name = "Ul_mid";
            dgv4.Columns[6].Name = "Na_mid";

            dgv4.Columns["Id"].Visible = false;
            dgv4.Columns["labela"].Visible = false;
            dgv4.Columns["Naselje"].Visible = true;

            dgv4.Columns["Ulica"].Visible = false;
            dgv4.Columns["Hs_mid"].Visible = false;
            dgv4.Columns["Ul_mid"].Visible = false;
            dgv4.Columns["Na_mid"].Visible = false;
            try
            {
                string q = "select id, ulica, hsmid, namid,ulmid, hs,hd,labela,naselje,cadis from tbl_hise where namid=@tmpnamid and greznica=0 and kanalizacija=0 order by ulica, hs,hd desc"; // preberi vse zapise iz tbl_hise
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@tmpnamid", f_namid);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpid = (int)rdr["id"];
                    tmphsmid = (string)rdr["hsmid"];
                    tmpnamid = (string)rdr["namid"];
                    tmpulmid = (string)rdr["ulmid"];
                    tmpnaselje = (string)rdr["naselje"];
                    tmplabela = (string)rdr["labela"];
                    tmpulica = (string)rdr["ulica"];
                    tmpcadis = (int)rdr["cadis"];

                    if (tmpulica != "")
                    {
                        tmpnaselje = tmpulica;
                    }
                    tmpnaselje = tmpnaselje + "   " + tmplabela;
                    if (tmpcadis != 1)
                    {
                        tmpnaselje = tmpnaselje + " (Ni v Cadis)";
                    }
                    //                    tmpnaselje = tmpnaselje + "   " + tmplabela;


                    string tmpidstr = Convert.ToString(tmpid);
                    string[] row = new string[] { tmpidstr, "      " + tmpnaselje, tmplabela, tmpulica, tmphsmid, tmpulmid, tmpnamid };
                    dgv4.Rows.Add(row);
                }  // while read
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }
        }


        private void Vpisi_Brezkanalizacije()
        {
            gb6.Text = "  Stavbe brez javne kanalizacije  ";
            dgv4.ColumnHeadersVisible = false;
            dgv4.RowHeadersVisible = false;
            dgv4.ColumnCount = 7;
            dgv4.Columns[1].Width = 350;

            dgv4.Columns[0].Name = "Id";
            dgv4.Columns[1].Name = "Naselje";
            dgv4.Columns[2].Name = "labela";
            dgv4.Columns[3].Name = "Ulica";
            dgv4.Columns[4].Name = "Hs_mid";
            dgv4.Columns[5].Name = "Ul_mid";
            dgv4.Columns[6].Name = "Na_mid";

            dgv4.Columns["Id"].Visible = false;
            dgv4.Columns["labela"].Visible = false;
            dgv4.Columns["Naselje"].Visible = true;

            dgv4.Columns["Ulica"].Visible = false;
            dgv4.Columns["Hs_mid"].Visible = false;
            dgv4.Columns["Ul_mid"].Visible = false;
            dgv4.Columns["Na_mid"].Visible = false;
            try
            {
                string q = "select id, ulica, hsmid, namid,ulmid, hs,hd,labela,naselje,cadis from tbl_hise where namid=@tmpnamid and kanalizacija=0 order by ulica, hs,hd desc"; // preberi vse zapise iz tbl_hise
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@tmpnamid", f_namid);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpid = (int)rdr["id"];
                    tmphsmid = (string)rdr["hsmid"];
                    tmpnamid = (string)rdr["namid"];
                    tmpulmid = (string)rdr["ulmid"];
                    tmpnaselje = (string)rdr["naselje"];
                    tmplabela = (string)rdr["labela"];
                    tmpulica = (string)rdr["ulica"];
                    tmpcadis = (int)rdr["cadis"];

                    if (tmpulica != "")
                    {
                        tmpnaselje = tmpulica;
                    }
                    tmpnaselje = tmpnaselje + "   " + tmplabela;
                    if (tmpcadis != 1)
                    {
                        tmpnaselje = tmpnaselje + " (Ni v Cadis)";
                    }
                    //                    tmpnaselje = tmpnaselje + "   " + tmplabela;


                    string tmpidstr = Convert.ToString(tmpid);
                    string[] row = new string[] { tmpidstr, "      " + tmpnaselje, tmplabela, tmpulica, tmphsmid, tmpulmid, tmpnamid };
                    dgv4.Rows.Add(row);
                }  // while read
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }
        }

        private void Vpisi_Skanalizacijo()
        {
            gb6.Text = "  Stavbe na javni kanalizaciji  ";
            dgv3.ColumnHeadersVisible = false;
            dgv3.RowHeadersVisible = false;
            dgv3.ColumnCount = 7;
            dgv3.Columns[1].Width = 350;

            dgv3.Columns[0].Name = "Id";
            dgv3.Columns[1].Name = "Naselje";
            dgv3.Columns[2].Name = "labela";
            dgv3.Columns[3].Name = "Ulica";
            dgv3.Columns[4].Name = "Hs_mid";
            dgv3.Columns[5].Name = "Ul_mid";
            dgv3.Columns[6].Name = "Na_mid";

            dgv3.Columns["Id"].Visible = false;
            dgv3.Columns["Naselje"].Visible = true;

            dgv3.Columns["labela"].Visible = false;
            dgv3.Columns["Ulica"].Visible = false;
            dgv3.Columns["Hs_mid"].Visible = false;
            dgv3.Columns["Ul_mid"].Visible = false;
            dgv3.Columns["Na_mid"].Visible = false;
            try
            {
                string q = "select id, ulica, hsmid, namid,ulmid, hs,hd,labela,naselje,cadis from tbl_hise where namid=@tmpnamid and kanalizacija=1 order by ulica, hs,hd desc"; // preberi vse zapise iz tbl_hise
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@tmpnamid", f_namid);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpid = (int)rdr["id"];
                    tmphsmid = (string)rdr["hsmid"];
                    tmpnamid = (string)rdr["namid"];
                    tmpulmid = (string)rdr["ulmid"];
                    tmpnaselje = (string)rdr["naselje"];
                    tmplabela = (string)rdr["labela"];
                    tmpulica = (string)rdr["ulica"];
                    tmpcadis = (int)rdr["cadis"];

                    if (tmpulica != "")
                    {
                        tmpnaselje = tmpulica;
                    }
                    tmpnaselje = tmpnaselje + "   " + tmplabela;
                    if (tmpcadis != 1)
                    {
                        tmpnaselje = tmpnaselje + " (Ni v Cadis)";
                    }
                    //                    tmpnaselje = tmpnaselje + "   " + tmplabela;


                    string tmpidstr = Convert.ToString(tmpid);
                    string[] row = new string[] { tmpidstr, "      " + tmpnaselje, tmplabela, tmpulica, tmphsmid, tmpulmid, tmpnamid };
                    dgv3.Rows.Add(row);
                }  // while read
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
            label15.Font = new Font(label11.Font, FontStyle.Bold);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            kazi_osebe = false;
            kazi_stavbe = true;
            // pokaži stavbe s kanalizacijo
            dgv4.Rows.Clear();
            dgv4.Refresh();
            dgv3.Rows.Clear();
            dgv3.Refresh();
            gb4.Text = "  Stavbe na javni kanalizaciji  ";
            gb6.Text = "  Stavbe brez javne kanalizacije  ";
            Vpisi_Skanalizacijo();
            Vpisi_Brezkanalizacije();

        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            label15.Font = new Font(label11.Font, FontStyle.Regular);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            // FrmNaselje.
        }
    }
}
