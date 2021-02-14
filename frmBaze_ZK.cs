using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Komunala
{
    public partial class frmBaze_ZK : Form
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

        string fname_vk1 = frmMain.pot_podatki + "zk\\" + "ob_vk1_n.dat";  // baza z osebami in naslovi
        int n_vk1;
        string fname_vk5 = frmMain.pot_podatki + "zk\\" + "ob_vk5.dat";  // baza z osebami
        int n_vk5;
        string fname_vk6 = frmMain.pot_podatki + "zk\\" + "ob_vk6.dat";  // baza z osebami
        int n_vk6;
        string fname_ren_lastniki = frmMain.pot_podatki + "ren\\" + "ren_lastniki.csv";  // baza z osebami
        string fname_ren_sestavine = frmMain.pot_podatki + "ren\\" + "ren_sestavine.csv";  // baza z osebami
        string fname_ren_parcele = frmMain.pot_podatki + "ren\\" + "ren_parcele.csv";  // baza z osebami
        string fname_ren_sta_par = frmMain.pot_podatki + "ren\\" + "ren_sta_par.csv";  // baza z osebami
        string fname_ren_stavbe = frmMain.pot_podatki + "ren\\" + "ren_stavbe.csv";  // baza z osebami
        string fname_ren_stavba_naslovi = frmMain.pot_podatki + "ren\\" + "ren_stavba_naslovi.csv";  // baza z osebami
        string fname_ren_deli_stavb = frmMain.pot_podatki + "ren\\" + "ren_delistavb.csv";  // baza z osebami
        int n_renl, n_rens,n_renp,n_rends,n_renns,n_rensn,n_rensp,n_renst;
        
        string nen_id, emso_ms, ime, naslov, leto, status;
        int delez_stev_izr, delez_imen_izr;
        double delez_proc;

        int stevec;
        string vrstica;
        string naslov_tujina,kraj,posta, delez_str;
        string dst_sid, nep_id, pc_mid,sta_sid;
        string ob_mid, ko_sifko, parcela, boniteta,hs_mid;
        double povrsina, x, y;

        public frmBaze_ZK()
        {
            InitializeComponent();
        }

        private void Izprazni()
        {
            label9.Text = "";
            label2.Text = "";
            label6.Text = "";
            label13.Text = "";
            label17.Text = "";
            label21.Text = "";
            label25.Text = "";
            label29.Text = "";
            label33.Text = "";
            label37.Text = "";
        }

        private void Baze_ZK_Load(object sender, EventArgs e)
        {
            Izprazni();
            Preveri_baze();
        }
        private void IzprazniBazo_vk1()  // izprazni tabelo tbl_pt
        {
            string query = "delete from tbl_vk1_zk_osebe";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void IzprazniBazo_vk5()  // izprazni tabelo tbl_pt
        {
            string query = "delete from tbl_VK5_ZK_posest";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Obdelaj_ren_sta_par();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Obdelaj_ren_stavbe();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Obdelaj_ren_stavba_naslovi();
        }

        private void IzprazniBazo_vk6()  // izprazni tabelo tbl_pt
        {
            string query = "delete from tbl_vk6_zk_parcele";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Obdelaj_ren_deli_stavb();
        }

        private void IzprazniBazo_ren_lastniki()  // izprazni tabelo tbl_pt
        {
            string query = "delete from tbl_ren_lastniki";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void IzprazniBazo_ren_sestavine()  // izprazni tabelo tbl_pt
        {
            string query = "delete from tbl_ren_sestavine";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void IzprazniBazo_ren_parcele()  // izprazni tabelo tbl_pt
        {
            string query = "delete from tbl_ren_parcele";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void IzprazniBazo_ren_sta_par()  // izprazni tabelo tbl_pt
        {
            string query = "delete from tbl_ren_sta_par";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void IzprazniBazo_ren_stavba_naslovi()  // izprazni tabelo tbl_pt
        {
            string query = "delete from tbl_ren_stavba_naslovi";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void IzprazniBazo_ren_stavbe()  // izprazni tabelo tbl_pt
        {
            string query = "delete from tbl_ren_stavbe";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void IzprazniBazo_ren_deli_stavb()  // izprazni tabelo tbl_pt
        {
            string query = "delete from tbl_ren_deli_stavb";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Obdelaj_ren_parcele()
        {
            if (n_renp == 0)
            {
                IzprazniBazo_ren_parcele();
                try
                {
                    System.IO.StreamReader objReader;
                    objReader = new System.IO.StreamReader(fname_ren_parcele);
                    stevec = 0;
                    do
                    {
                        vrstica = "";
                        vrstica = vrstica + objReader.ReadLine() ;

                        // razdeli vrstico ločeno s ;
                        string[] polje = vrstica.Split(';');
                        pc_mid = polje[0];
                        ob_mid = polje[1];
                        ko_sifko = polje[2];
                        parcela = polje[3];
                        povrsina = Convert.ToDouble(polje[4]);
                        x = Convert.ToDouble(polje[5]);
                        y = Convert.ToDouble(polje[6]);
                        //MessageBox.Show(boniteta);


                        try
                        {
                            if (stevec > 0)
                            {
                                string query = "Insert into tbl_ren_parcele (pc_mid,ob_mid,ko_sifko,parcela,povrsina,x,y,boniteta) values (@pc_mid,@ob_mid,@ko_sifko,@parcela,@povrsina,@x,@y,@boniteta)";
                                cmd = new SqlCommand(query, con);
                                con.Open();
                                cmd.Parameters.AddWithValue("@pc_mid",pc_mid);
                                cmd.Parameters.AddWithValue("@ob_mid",ob_mid);
                                cmd.Parameters.AddWithValue("@ko_sifko",ko_sifko);
                                cmd.Parameters.AddWithValue("@parcela",parcela);
                                cmd.Parameters.AddWithValue("@povrsina",povrsina);
                                cmd.Parameters.AddWithValue("@x",x);
                                cmd.Parameters.AddWithValue("@y",y);
                                cmd.Parameters.AddWithValue("@boniteta","000");
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
                        label21.Text = stevec.ToString();
                        label21.Refresh();
                    } while (objReader.Peek() != -1); //while (stevec < 100);//
                    objReader.Close();
                    stevec--;
                    label21.Text = stevec.ToString();
                    label21.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: " + ex.Message);
                }
                finally
                {
                    // DisplayData_ul();
                }
            }
            else
            {
                MessageBox.Show("Napaka! Datoteka ne obstaja: " + fname_ren_parcele);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Obdelaj_ren_parcele();
        }

        private void Obdelaj_vk1()
        {
            if (n_vk1 == 0)
            {
                stevec = 0;
                IzprazniBazo_vk1();
                
                try
                {
                    System.IO.StreamReader objReader;
                    objReader = new System.IO.StreamReader(fname_vk1);
                    do
                    {
                        
                        vrstica = "";
                        naslov_tujina = ""; kraj = ""; posta = "";
                        vrstica = objReader.ReadLine() + "\r\n";
                        string emso = vrstica.Substring(1, 13);
                        string sif_obcine = vrstica.Substring(14, 3);
                        string sif_naselja = vrstica.Substring(17, 3);
                        string sif_ulice = vrstica.Substring(20, 3);
                        string hs = vrstica.Substring(24, 3);
                        string hd = vrstica.Substring(27, 1);
                        string st_poste = vrstica.Substring(31, 4);
                        string priimek_ime = vrstica.Substring(35, 60);
                        priimek_ime = priimek_ime.TrimEnd();
                        string status_osebe = vrstica.Substring(95, 1);
                        string mid_naslova = vrstica.Substring(96, 8);
                        string mid_hs = vrstica.Substring(104, 8);
                        string ostanek = vrstica.Substring(112);
                        hs = hs.TrimStart('0');

                        if (mid_hs == "00000000" && mid_naslova == "00000000")
                        // tuji naslov
                        {
                            if (ostanek.Contains('+'))
                            {
                                ostanek = ostanek.TrimEnd();
                                kraj = ostanek.Substring(0, ostanek.IndexOf("+"));  // pred podpicjem
                                posta = ostanek.Substring(ostanek.IndexOf("+") + 2); // za podpicjem
                                posta = posta.TrimEnd();
                                naslov_tujina = kraj + " " + posta;
                            }
                            else
                            {
                                ostanek = ostanek.TrimEnd();
                                kraj = ostanek;
                                posta = "";
                                naslov_tujina = ostanek;
                            }
                        }
                        else // domači naslov
                        {
                            if (ostanek.Contains(';'))
                            {
                                ostanek = ostanek.TrimEnd();
                                string ostanek2 = ostanek.Substring(ostanek.IndexOf(",") + 2);
                                kraj = ostanek2.Substring(0, ostanek2.IndexOf(";"));  // pred podpicjem
                                posta = ostanek2.Substring(ostanek2.IndexOf(";") + 2); // za podpicjem
                                posta = posta.TrimEnd();
                            }
                            else
                            {
                                ostanek = ostanek.TrimEnd();
                                kraj = ostanek;
                                posta = "";
                            }
                        }
                        try
                        {
                            if (stevec > 0)
                            {
                                string query = "insert into tbl_vk1_zk_osebe (emso, sif_obcine,sif_naselja,sif_ulice,hs,hsd,st_poste,priimek_ime,status_osebe,mid_naslova,mid_hs,kraj,posta,naslov_tujina) " +
                                    "values(@emso,@sif_obcine,@sif_naselja,@sif_ulice,@hs,@hd,@st_poste,@priimek_ime,@status_osebe,@mid_naslova,@mid_hs,@kraj,@posta,@naslov_tujina)";
                                cmd = new SqlCommand(query, con);
                                con.Open();
                                cmd.Parameters.AddWithValue("@emso", emso);
                                cmd.Parameters.AddWithValue("@sif_obcine", sif_obcine);
                                cmd.Parameters.AddWithValue("@sif_naselja", sif_naselja);
                                cmd.Parameters.AddWithValue("@sif_ulice", sif_ulice);
                                cmd.Parameters.AddWithValue("@hs", hs);
                                cmd.Parameters.AddWithValue("@hd", hd);
                                cmd.Parameters.AddWithValue("@st_poste", st_poste);
                                cmd.Parameters.AddWithValue("@priimek_ime", priimek_ime);
                                cmd.Parameters.AddWithValue("@status_osebe", status_osebe);
                                cmd.Parameters.AddWithValue("@mid_naslova", mid_naslova);
                                cmd.Parameters.AddWithValue("@mid_hs", mid_hs);
                                cmd.Parameters.AddWithValue("@kraj", kraj);
                                cmd.Parameters.AddWithValue("@posta", posta);
                                cmd.Parameters.AddWithValue("@naslov_tujina",naslov_tujina);
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
                        label9.Text = stevec.ToString();
                        label9.Refresh();
                    } while (objReader.Peek() != -1); //(stevec != 104);  //
                    objReader.Close();
                    stevec--;
                    label9.Text = stevec.ToString();
                    label9.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: " + ex.Message);
                }
                finally
                {
                }
            }
            else
            {
                MessageBox.Show("Napaka! Datoteka ne obstaja: " + fname_vk1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Obdelaj_ren_sestavine();
        }

        private void Obdelaj_vk5()  // posestni listi
        {
            if (n_vk5 == 0)
            {
                stevec = 0;
                IzprazniBazo_vk5();
                
                try
                {
                    System.IO.StreamReader objReader;
                    objReader = new System.IO.StreamReader(fname_vk5);
                    do
                    {
                        vrstica = "";
                        vrstica = objReader.ReadLine() + "\r\n";
                        string sif_ko = vrstica.Substring(1, 4);
                        sif_ko = sif_ko.TrimStart('0');
                        string pos_list = vrstica.Substring(5, 5);
                        string lastnistvo = vrstica.Substring(10, 1);
                        string let_sprememb = vrstica.Substring(11, 4);
                        string st_sprememb = vrstica.Substring(15, 3);
                        string emso = vrstica.Substring(18, 13);
                        string delez_ste = vrstica.Substring(31, 6);
                        string delez_ime = vrstica.Substring(37, 7);
                        string id_postopka = vrstica.Substring(47, 8);
                        try
                        {
                            if (stevec > 0)
                            {
                                string query = "insert into tbl_vk5_zk_posest (sif_ko,pos_list,lastnistvo,let_sprememb,st_sprememb,emso,delez_ste,delez_ime,id_postopka) " +
                                    "values(@sif_ko,@pos_list,@lastnistvo,@let_sprememb,@st_sprememb,@emso,@delez_ste,@delez_ime,@id_postopka)";
                                cmd = new SqlCommand(query, con);
                                con.Open();
                                cmd.Parameters.AddWithValue("@sif_ko",sif_ko);
                                cmd.Parameters.AddWithValue("@pos_list",pos_list);
                                cmd.Parameters.AddWithValue("@lastnistvo",lastnistvo);
                                cmd.Parameters.AddWithValue("@let_sprememb",let_sprememb);
                                cmd.Parameters.AddWithValue("@st_sprememb",st_sprememb);
                                cmd.Parameters.AddWithValue("@emso",emso);
                                cmd.Parameters.AddWithValue("@delez_ste",delez_ste);
                                cmd.Parameters.AddWithValue("@delez_ime",delez_ime);
                                cmd.Parameters.AddWithValue("@id_postopka",id_postopka);
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
                        label2.Text = stevec.ToString();
                        label2.Refresh();
                    } while (objReader.Peek() != -1);
                    objReader.Close();
                    stevec--;
                    label2.Text = stevec.ToString();
                    label2.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: " + ex.Message);
                }
                finally
                {
                }
            }
            else
            {
                MessageBox.Show("Napaka! Datoteka ne obstaja: " + fname_vk5);
            }
        }

        private void Obdelaj_vk6()  // parcele
        {
            if (n_vk6 == 0)
            {
                stevec = 0;
                IzprazniBazo_vk6();

                try
                {
                    System.IO.StreamReader objReader;
                    objReader = new System.IO.StreamReader(fname_vk6);
                    do
                    {
                        vrstica = "";
                        vrstica = objReader.ReadLine() + "\r\n";
                        string parcela;
                        string sif_ko = vrstica.Substring(1, 4);
                        sif_ko = sif_ko.TrimStart('0');
                        string oznaka_parc = vrstica.Substring(5, 1);
                        string stev_parc = vrstica.Substring(6, 4);
                        string imen_parc = vrstica.Substring(10, 4);
                        stev_parc = stev_parc.TrimStart('0');
                        imen_parc = imen_parc.TrimStart('0');

                        if (imen_parc != "")
                            parcela = stev_parc + "/" + imen_parc;
                        else
                            parcela = stev_parc;

                        string pos_list = vrstica.Substring(14, 5);
                        string letnica = vrstica.Substring(26, 4);
                        string stevilka = vrstica.Substring(30, 3);
                        string ozn_nac = vrstica.Substring(33, 1);
                        string povrsina = vrstica.Substring(34, 8);
                        string boniteta = vrstica.Substring(42, 3);
                        string raba_zemljisca = vrstica.Substring(45, 3);
                        string ob_id = vrstica.Substring(49, 4);
                        string id_postopka = vrstica.Substring(53, 8);
                        string urejenost = vrstica.Substring(61, 1);
                        string stev_stavbe = vrstica.Substring(62, 5);
                        string y = vrstica.Substring(67, 9);
                        string x = vrstica.Substring(76, 9);
                        string ob_mid = vrstica.Substring(85, 8);
                        try
                        {
                            if (stevec > 0)
                            {
                                string query = "insert into tbl_vk6_zk_parcele (sif_ko,oznaka_parc,stev_parc,imen_parc,parcela,pos_list,letnica,stevilka,ozn_nac,povrsina,boniteta,raba_zemljisca,ob_id," +
                                    "id_postopka,urejenost,stev_stavbe,y,x,ob_mid) " +
                                    "values(@sif_ko,@oznaka_parc,@stev_parc,@imen_parc,@parcela,@pos_list,@letnica,@stevilka,@ozn_nac,@povrsina,@boniteta,@raba_zemljisca,@ob_id,@id_postopka,@urejenost,@stev_stavbe,@y,@x,@ob_mid)";
                                cmd = new SqlCommand(query, con);
                                con.Open();
                                cmd.Parameters.AddWithValue("@sif_ko", sif_ko);
                                cmd.Parameters.AddWithValue("@oznaka_parc", oznaka_parc);
                                cmd.Parameters.AddWithValue("@stev_parc", stev_parc);
                                cmd.Parameters.AddWithValue("@imen_parc", imen_parc);
                                cmd.Parameters.AddWithValue("@parcela", parcela);
                                cmd.Parameters.AddWithValue("@pos_list", pos_list);
                                cmd.Parameters.AddWithValue("@letnica", letnica);
                                cmd.Parameters.AddWithValue("@stevilka", stevilka);
                                cmd.Parameters.AddWithValue("@ozn_nac", ozn_nac);
                                cmd.Parameters.AddWithValue("@povrsina", povrsina);
                                cmd.Parameters.AddWithValue("@boniteta", boniteta);
                                cmd.Parameters.AddWithValue("@raba_zemljisca", raba_zemljisca);
                                cmd.Parameters.AddWithValue("@ob_id", ob_id);
                                cmd.Parameters.AddWithValue("@id_postopka", id_postopka);
                                cmd.Parameters.AddWithValue("@urejenost", urejenost);
                                cmd.Parameters.AddWithValue("@stev_stavbe", stev_stavbe);
                                cmd.Parameters.AddWithValue("@y", y);
                                cmd.Parameters.AddWithValue("@x", x);
                                cmd.Parameters.AddWithValue("@ob_mid", ob_mid);
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
                        label6.Text = stevec.ToString();
                        label6.Refresh();
                    } while (objReader.Peek() != -1); //(stevec != 100); 
                    objReader.Close();
                    stevec--;
                    label6.Text = stevec.ToString();
                    label6.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: " + ex.Message);
                }
                finally
                {
                }
            }
            else
            {
                MessageBox.Show("Napaka! Datoteka ne obstaja: " + fname_vk6);
            }
        }


        private void Obdelaj_ren_lastniki()
        {
            if (n_renl == 0)
            {
                // začni prenos
                
                IzprazniBazo_ren_lastniki();
                // preberi ul - CSV
                try
                {
                    System.IO.StreamReader objReader;
                    objReader = new System.IO.StreamReader(fname_ren_lastniki);
                    // število vrstic v CSV
                    //++stevec; // preskoči prvo vrstico
                    stevec = 0;
                    do
                    {
                            vrstica = "";
                            vrstica = vrstica + objReader.ReadLine() ;

                            // razdeli vrstico ločeno s ;
                            string[] polje = vrstica.Split(';');
                            nen_id = polje[0];
                            emso_ms = polje[1];
                            ime = polje[2];
                            naslov = polje[3];
                            leto = polje[4];
                        //MessageBox.Show(polje[5]);
                        string ts = polje[5];
                        string ti = polje[6];
                        delez_str = ts + "/" + ti;
                        if (ts.Equals(""))
                        {
                            delez_imen_izr = 0;
                            delez_stev_izr = 0;
                            delez_proc = 0;
                        }
                        else
                        {
                            delez_stev_izr = Convert.ToInt32(polje[5]);
                            delez_imen_izr = Convert.ToInt32(polje[6]);
                            double s = Convert.ToDouble(polje[5]);
                            double i = Convert.ToDouble(polje[6]);
                            delez_proc = (s / i) * 100;
                        }
                        //MessageBox.Show(Convert.ToString(delez_proc));
                        if (emso_ms.Length < 10)
                                status = "Pod";
                            else
                                status = "Fiz";

                            try
                            {
                                    string query = "Insert into tbl_ren_lastniki (nen_id,emso_ms,ime,naslov,leto,delez_stev_izr,delez_imen_izr,delez_str,delez_proc,status) values (@nen_id,@emso_ms,@ime,@naslov,@leto,@delez_stev_izr,@delez_imen_izr,@delez_str,@delez_proc,@status)";
                                    cmd = new SqlCommand(query, con);
                                    con.Open();
                                    cmd.Parameters.AddWithValue("@nen_id", nen_id);
                                    cmd.Parameters.AddWithValue("@emso_ms", emso_ms);
                                    cmd.Parameters.AddWithValue("@ime", ime);
                                    cmd.Parameters.AddWithValue("@naslov", naslov);
                                    cmd.Parameters.AddWithValue("@leto", leto);
                                    cmd.Parameters.AddWithValue("@delez_stev_izr", delez_stev_izr);
                                    cmd.Parameters.AddWithValue("@delez_imen_izr", delez_imen_izr);
                                    cmd.Parameters.AddWithValue("@delez_str", delez_str);
                                    cmd.Parameters.AddWithValue("@delez_proc", delez_proc);
                                    cmd.Parameters.AddWithValue("@status", status);
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Napaka: " + ex.Message);
                            }
                        stevec = ++stevec;
                        vrstica = "";
                        label13.Text = stevec.ToString();
                        label13.Refresh();
                    }  while (objReader.Peek() != -1); //while (stevec < 100);//
                    objReader.Close();
                    stevec--;
                    label13.Text = stevec.ToString();
                    label13.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: " + ex.Message);
                }
                finally
                {
                   // DisplayData_ul();
                }
            }
            else
            {
                MessageBox.Show("Napaka! Datoteka ne obstaja: " + fname_ren_lastniki);
            }

        }

        private void Obdelaj_ren_sestavine()
        {
            if (n_rens == 0)
            {
                // začni prenos

                IzprazniBazo_ren_sestavine();
                // preberi ul - CSV
                try
                {
                    System.IO.StreamReader objReader;
                    objReader = new System.IO.StreamReader(fname_ren_sestavine);
                    // število vrstic v CSV
                    //++stevec; // preskoči prvo vrstico
                    stevec = 0;
                    do
                    {
                        vrstica = "";
                        vrstica = vrstica + objReader.ReadLine();

                        // razdeli vrstico ločeno s ;
                        string[] polje = vrstica.Split(';');
                        nep_id = polje[0];
                        nen_id = polje[1];
                        dst_sid = polje[2];
                        pc_mid = polje[3];

                        try
                        {
                                string query = "Insert into tbl_ren_sestavine (nep_id,nen_id,dst_sid,pc_mid) values (@nep_id,@nen_id,@dst_sid,@pc_mid)";
                                cmd = new SqlCommand(query, con);
                                con.Open();
                                cmd.Parameters.AddWithValue("@nep_id", nep_id);
                                cmd.Parameters.AddWithValue("@nen_id", nen_id);
                                cmd.Parameters.AddWithValue("@dst_sid", dst_sid);
                                cmd.Parameters.AddWithValue("@pc_mid", pc_mid);
                                cmd.ExecuteNonQuery();
                                con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Napaka: " + ex.Message);
                        }
                        stevec = ++stevec;
                        vrstica = "";
                        label17.Text = stevec.ToString();
                        label17.Refresh();
                    } while (objReader.Peek() != -1); //while (stevec < 100);//
                    objReader.Close();
                    stevec--;
                    label17.Text = stevec.ToString();
                    label17.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: " + ex.Message);
                }
                finally
                {
                    // DisplayData_ul();
                }
            }
            else
            {
                MessageBox.Show("Napaka! Datoteka ne obstaja: " + fname_ren_sestavine);
            }

        }
        private void Obdelaj_ren_sta_par()
        {
            if (n_rensp == 0)
            {
                // začni prenos

                IzprazniBazo_ren_sta_par();
                // preberi ul - CSV
                try
                {
                    System.IO.StreamReader objReader;
                    objReader = new System.IO.StreamReader(fname_ren_sta_par);
                    stevec = 0;
                    do
                    {
                        vrstica = "";
                        vrstica = vrstica + objReader.ReadLine() ;

                        // razdeli vrstico ločeno s ;
                        string[] polje = vrstica.Split(';');
                        sta_sid = polje[0];
                        pc_mid = polje[1];
                        if (polje[2] == "")
                            povrsina = 0;
                        else
                            povrsina = Convert.ToDouble(polje[2]);

                        try
                        {
                                string query = "Insert into tbl_ren_sta_par (sta_sid,pc_mid,povrsina) values (@sta_sid,@pc_mid,@povrsina)";
                                cmd = new SqlCommand(query, con);
                                con.Open();
                                cmd.Parameters.AddWithValue("@sta_sid", sta_sid);
                                cmd.Parameters.AddWithValue("@pc_mid", pc_mid);
                                cmd.Parameters.AddWithValue("@povrsina", povrsina);
                                cmd.ExecuteNonQuery();
                                con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Napaka: " + ex.Message);
                        }
                        stevec = ++stevec;
                        vrstica = "";
                        label25.Text = stevec.ToString();
                        label25.Refresh();
                    } while (objReader.Peek() != -1); //while (stevec < 100);//
                    objReader.Close();
                    stevec--;
                    label25.Text = stevec.ToString();
                    label25.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: " + ex.Message);
                }
                finally
                {
                    // DisplayData_ul();
                }
            }
            else
            {
                MessageBox.Show("Napaka! Datoteka ne obstaja: " + fname_ren_sta_par);
            }
        }
        private void Obdelaj_ren_stavba_naslovi()
        {
            if (n_rensn == 0)
            {
                // začni prenos

                IzprazniBazo_ren_stavba_naslovi();
                // preberi ul - CSV
                try
                {
                    System.IO.StreamReader objReader;
                    objReader = new System.IO.StreamReader(fname_ren_stavba_naslovi);
                    stevec = 0;
                    do
                    {
                        vrstica = "";
                        vrstica = vrstica + objReader.ReadLine() ;

                        // razdeli vrstico ločeno s ;
                        string[] polje = vrstica.Split(';');
                        sta_sid = polje[0];

                        //                        hs_mid = polje[1];
                        if (polje[1] == "")
                            hs_mid = "";
                        else
                        {
                            hs_mid = polje[1];
                            hs_mid = hs_mid.Substring(0, 8);
                        }
                        try
                        {
                                string query = "Insert into tbl_ren_stavba_naslovi (sta_sid,hs_mid) values (@sta_sid,@hs_mid)";
                                cmd = new SqlCommand(query, con);
                                con.Open();
                                cmd.Parameters.AddWithValue("@sta_sid", sta_sid);
                                cmd.Parameters.AddWithValue("@hs_mid", hs_mid);
                                cmd.ExecuteNonQuery();
                                con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Napaka: " + ex.Message);
                        }
                        stevec = ++stevec;
                        vrstica = "";
                        label33.Text = stevec.ToString();
                        label33.Refresh();
                    } while (objReader.Peek() != -1); //while (stevec < 100);//
                    objReader.Close();
                    stevec--;
                    label33.Text = stevec.ToString();
                    label33.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: " + ex.Message);
                }
                finally
                {
                    // DisplayData_ul();
                }
            }
            else
            {
                MessageBox.Show("Napaka! Datoteka ne obstaja: " + fname_ren_stavba_naslovi);
            }
        }

        private void Obdelaj_ren_stavbe()
        {
            if (n_renst == 0)
            {
                // začni prenos

                IzprazniBazo_ren_stavbe();
                // preberi ul - CSV
                try
                {
                    System.IO.StreamReader objReader;
                    objReader = new System.IO.StreamReader(fname_ren_stavbe);
                    stevec = 0;
                    do
                    {
                        vrstica = "";
                        vrstica = vrstica + objReader.ReadLine() ;

                        // razdeli vrstico ločeno s ;
                        string[] polje = vrstica.Split(';');
                        sta_sid = polje[0];
                        ko_sifko = polje[1];
                        string stev = polje[2];
                        string ob_mid = polje[3];
                        string katas_vpis = polje[4];
                        
                        int st_etaz;
                        if (polje[5] == "")
                            st_etaz = -99;
                        else
                            st_etaz = Convert.ToInt32(polje[5]);

                        int st_prit_etaze;
                        if (polje[6] == "")
                            st_prit_etaze = -99;
                        else
                            st_prit_etaze = Convert.ToInt32(polje[6]);

                        int st_stanovanj;
                        if (polje[7] == "")
                            st_stanovanj = -99;
                        else
                            st_stanovanj = Convert.ToInt32(polje[7]);

                        int st_poslovnih_prostorov;
                        if (polje[8] == "")
                            st_poslovnih_prostorov = -99;
                        else
                            st_poslovnih_prostorov = Convert.ToInt32(polje[8]);

                        //int st_etaz =Convert.ToInt32(polje[5]);
                        //int st_prit_etaze = Convert.ToInt32(polje[6]);
                        //int st_stanovanj = Convert.ToInt32(polje[7]);
                        //int st_poslovnih_prostorov = Convert.ToInt32(polje[8]);
                        string id_tip_stavbe = polje[9];
                        string leto_izg_sta = polje[10];
                        double x = Convert.ToDouble(polje[11]);
                        double y = Convert.ToDouble(polje[12]);
                        string leto_obn_strehe = polje[13];
                        string leto_obn_fasade = polje[14];
                        string id_konstrukcije = polje[15];
                        string id_vodovod = polje[16];
                        string id_elektrika = polje[17];
                        string id_kanalizacija = polje[18];
                        string id_plin;

                        if (polje[19] == "\r\n")
                            id_plin = "";
                        else
                            id_plin = polje[19];

                        try
                        {
                                string query = "Insert into tbl_ren_stavbe (sta_sid,ko_sifko,stev,ob_mid,katas_vpis,st_etaz,st_prit_etaze,st_stanovanj,st_poslovnih_prostorov," +
                                "id_tip_stavbe,leto_izg_sta,x,y,leto_obn_strehe,leto_obn_fasade,id_konstrukcije,id_vodovod,id_elektrika,id_kanalizacija,id_plin) " +
                                "values (@sta_sid,@ko_sifko,@stev,@ob_mid,@katas_vpis,@st_etaz,@st_prit_etaze,@st_stanovanj,@st_poslovnih_prostorov," +
                                "@id_tip_stavbe, @leto_izg_sta, @x, @y, @leto_obn_strehe, @leto_obn_fasade, @id_konstrukcije, @id_vodovod, @id_elektrika, @id_kanalizacija, @id_plin)";
                                cmd = new SqlCommand(query, con);
                                con.Open();

                                cmd.Parameters.AddWithValue("@sta_sid",sta_sid);
                                cmd.Parameters.AddWithValue("@ko_sifko",ko_sifko);
                                cmd.Parameters.AddWithValue("@stev",stev);
                                cmd.Parameters.AddWithValue("@ob_mid",ob_mid);
                                cmd.Parameters.AddWithValue("@katas_vpis",katas_vpis);
                                cmd.Parameters.AddWithValue("@st_etaz",st_etaz);
                                cmd.Parameters.AddWithValue("@st_prit_etaze",st_prit_etaze);
                                cmd.Parameters.AddWithValue("@st_stanovanj",st_stanovanj);
                                cmd.Parameters.AddWithValue("@st_poslovnih_prostorov",st_poslovnih_prostorov);
                                cmd.Parameters.AddWithValue("@id_tip_stavbe",id_tip_stavbe);
                                cmd.Parameters.AddWithValue("@leto_izg_sta",leto_izg_sta);
                                cmd.Parameters.AddWithValue("@x",x);
                                cmd.Parameters.AddWithValue("@y",y);
                                cmd.Parameters.AddWithValue("@leto_obn_strehe",leto_obn_strehe);
                                cmd.Parameters.AddWithValue("@leto_obn_fasade",leto_obn_fasade);
                                cmd.Parameters.AddWithValue("@id_konstrukcije",id_konstrukcije);
                                cmd.Parameters.AddWithValue("@id_vodovod",id_vodovod);
                                cmd.Parameters.AddWithValue("@id_elektrika",id_elektrika);
                                cmd.Parameters.AddWithValue("@id_kanalizacija",id_kanalizacija);
                                cmd.Parameters.AddWithValue("@id_plin",id_plin);
                                cmd.ExecuteNonQuery();
                                con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Napaka: " + ex.Message);
                        }
                        stevec = ++stevec;
                        vrstica = "";
                        label29.Text = stevec.ToString();
                        label29.Refresh();
                    } while (objReader.Peek() != -1); //while (stevec < 100);//
                    objReader.Close();
                    stevec--;
                    label29.Text = stevec.ToString();
                    label29.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: " + ex.Message);
                }
                finally
                {
                    // DisplayData_ul();
                }
            }
            else
            {
                MessageBox.Show("Napaka! Datoteka ne obstaja: " + fname_ren_stavbe);
            }
        }

        private void Obdelaj_ren_deli_stavb()
        {
            if (n_rends == 0)
            {
                // začni prenos

                IzprazniBazo_ren_deli_stavb();
                // preberi ul - CSV
                try
                {
                    System.IO.StreamReader objReader;
                    objReader = new System.IO.StreamReader(fname_ren_deli_stavb);
                    stevec = 0;
                    do
                    {
                        vrstica = "";
                        vrstica = vrstica + objReader.ReadLine() ;

                        // razdeli vrstico ločeno s ;
                        string[] polje = vrstica.Split(';');
                        
                        dst_sid = polje[0];
                        sta_sid = polje[1];
//                        ko_sifko = polje[2];
                        string stevdst = polje[2];
                        string stevstan = polje[3];
                        string st_etaze = polje[4];
                        string st_nadstropja = polje[5];
                        string hs_mid = polje[6];
                        string katas_vpis = polje[7];
                        string dejanska_raba = polje[8];
                        //double upor_pov_stan = Convert.ToDouble(polje[10]);

                        double upor_pov_stan;
                        if (polje[9] == "")
                            upor_pov_stan = -99;
                        else
                            upor_pov_stan = Convert.ToDouble(polje[9]);

                        //int st_etaz;
                        //if (polje[5] == "")
                        //    st_etaz = -99;
                        //else
                        //    st_etaz = Convert.ToInt32(polje[5]);

                        double neto_tloris_pov_dst;
                        if (polje[10] == "")
                            neto_tloris_pov_dst = -99;
                        else
                            neto_tloris_pov_dst = Convert.ToDouble(polje[10]);

                        string leto_obn_oken = polje[11];

                        string leto_obn_inst = polje[12];
                        string ms_upravnika = polje[13];
                        string id_lega = polje[14];
                        
                        //double svetla_visina_etaze = Convert.ToDouble(polje[16]);
                        double svetla_visina_etaze;
                        if (polje[15] == "")
                            svetla_visina_etaze = -99;
                        else
                            svetla_visina_etaze = Convert.ToDouble(polje[15]);


                        //double prostornina = Convert.ToDouble(polje[17]);
                        double prostornina;
                        string tmp = polje[16];
                        if (polje[16] == "" || polje[16] == "\r\n")
                            prostornina = -99;
                        else
                            prostornina = Convert.ToDouble(polje[17]);



                        string id_dvigalo;
                        string tmp2 = polje[17];
                        if (polje[17] == "\r\n")
                            id_dvigalo = "";
                        else
                            id_dvigalo = polje[17];

                        try
                        {
                                string query = "Insert into tbl_ren_deli_stavb (dst_sid,sta_sid,stevdst,stevstan,st_etaze,st_nadstropja,hs_mid,katas_vpis," +
                                "dejanska_raba,upor_pov_stan,neto_tloris_pov_dst,leto_obn_oken,leto_obn_inst,ms_upravnika,id_lega,svetla_visina_etaze,prostornina,id_dvigalo) " +
                                "values (@dst_sid,@sta_sid,@stevdst,@stevstan,@st_etaze,@st_nadstropja,@hs_mid,@katas_vpis," +
                                "@dejanska_raba,@upor_pov_stan,@neto_tloris_pov_dst,@leto_obn_oken,@leto_obn_inst,@ms_upravnika,@id_lega,@svetla_visina_etaze,@prostornina,@id_dvigalo)";
                                cmd = new SqlCommand(query, con);
                                con.Open();

                                cmd.Parameters.AddWithValue("@dst_sid",dst_sid);
                                cmd.Parameters.AddWithValue("@sta_sid",sta_sid);
                                cmd.Parameters.AddWithValue("@stevdst",stevdst);
                                cmd.Parameters.AddWithValue("@stevstan",stevstan);
                                cmd.Parameters.AddWithValue("@st_etaze",st_etaze);
                                cmd.Parameters.AddWithValue("@st_nadstropja",st_nadstropja);
                                cmd.Parameters.AddWithValue("@hs_mid",hs_mid);
                                cmd.Parameters.AddWithValue("@katas_vpis",katas_vpis);
                                cmd.Parameters.AddWithValue("@dejanska_raba",dejanska_raba);
                                cmd.Parameters.AddWithValue("@upor_pov_stan",upor_pov_stan);
                                cmd.Parameters.AddWithValue("@neto_tloris_pov_dst",neto_tloris_pov_dst);
                                cmd.Parameters.AddWithValue("@leto_obn_oken",leto_obn_oken);
                                cmd.Parameters.AddWithValue("@leto_obn_inst",leto_obn_inst);
                                cmd.Parameters.AddWithValue("@ms_upravnika",ms_upravnika);
                                cmd.Parameters.AddWithValue("@id_lega",id_lega);
                                cmd.Parameters.AddWithValue("@svetla_visina_etaze",svetla_visina_etaze);
                                cmd.Parameters.AddWithValue("@prostornina",prostornina);
                                cmd.Parameters.AddWithValue("@id_dvigalo",id_dvigalo);
                                cmd.ExecuteNonQuery();
                                con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Napaka: " + ex.Message);
                        }
                        stevec = ++stevec;
                        vrstica = "";
                        label37.Text = stevec.ToString();
                        label37.Refresh();
                    } while (objReader.Peek() != -1); //while (stevec < 100);//
                    objReader.Close();
                    stevec--;
                    label37.Text = stevec.ToString();
                    label37.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: " + ex.Message);
                }
                finally
                {
                    // DisplayData_ul();
                }
            }
            else
            {
                MessageBox.Show("Napaka! Datoteka ne obstaja: " + fname_ren_deli_stavb);
            }
        }


        private void Preveri_baze()
        {
            // VK1 - osebe
            try
            {
                var lineCount = File.ReadAllLines(fname_vk1).Length;
                lineCount--;
                //label2.Text = fnamecrp2;
                label51.Text = "Zap: "+lineCount.ToString();
                label52.Text = "";
                n_vk1 = 0;
            }
            catch (Exception ex)
            {
                label52.Text = "Datoteka " + fname_vk1 + " ne obstaja!";
                label51.Text = "Zap: " + "0";
                n_vk1 = 1;
            }

            // VK5 - posestni listi
            try
            {
                var lineCount = File.ReadAllLines(fname_vk5).Length;
                lineCount--;
                //label2.Text = fnamecrp2;
                label4.Text = "Zap: " + lineCount.ToString();
                label3.Text = "";
                n_vk5 = 0;
            }
            catch (Exception ex)
            {
                label3.Text = "Datoteka " + fname_vk5 + " ne obstaja!";
                label4.Text = "Zap: " + "0";
                n_vk5 = 1;
            }

            // VK6 - parcele
            try
            {
                var lineCount = File.ReadAllLines(fname_vk6).Length;
                lineCount--;
                //label2.Text = fnamecrp2;
                label8.Text = "Zap: " + lineCount.ToString();
                label7.Text = "";
                n_vk6 = 0;
            }
            catch (Exception ex)
            {
                label7.Text = "Datoteka " + fname_vk6 + " ne obstaja!";
                label8.Text = "Zap: " + "0";
                n_vk6 = 1;
            }

            // ren lastniki
            try
            {
                var lineCount = File.ReadAllLines(fname_ren_lastniki).Length;
                lineCount--;
                //label2.Text = fnamecrp2;
                label15.Text = "Zap: " + lineCount.ToString();
                label14.Text = "";
                n_renl = 0;
            }
            catch (Exception ex)
            {
                label14.Text = "Datoteka " + fname_ren_lastniki + " ne obstaja!";
                label15.Text = "Zap: " + "0";
                n_renl = 1;
            }
            // ren sestavine
            try
            {
                var lineCount = File.ReadAllLines(fname_ren_sestavine).Length;
                lineCount--;
                //label2.Text = fnamecrp2;
                label19.Text = "Zap: " + lineCount.ToString();
                label18.Text = "";
                n_rens = 0;
            }
            catch (Exception ex)
            {
                label18.Text = "Datoteka " + fname_ren_sestavine + " ne obstaja!";
                label19.Text = "Zap: " + "0";
                n_rens = 1;
            }
            // ren parcele
            try
            {
                var lineCount = File.ReadAllLines(fname_ren_parcele).Length;
                lineCount--;
                //label2.Text = fnamecrp2;
                label23.Text = "Zap: " + lineCount.ToString();
                label22.Text = "";
                n_rens = 0;
            }
            catch (Exception ex)
            {
                label22.Text = "Datoteka " + fname_ren_parcele + " ne obstaja!";
                label23.Text = "Zap: " + "0";
                n_renp = 1;
            }
            // ren sta_par
            try
            {
                var lineCount = File.ReadAllLines(fname_ren_sta_par).Length;
                lineCount--;
                //label2.Text = fnamecrp2;
                label27.Text = "Zap: " + lineCount.ToString();
                label26.Text = "";
                n_rensp = 0;
            }
            catch (Exception ex)
            {
                label26.Text = "Datoteka " + fname_ren_sta_par + " ne obstaja!";
                label27.Text = "Zap: " + "0";
                n_rensp = 1;
            }
            // ren stavbe
            try
            {
                var lineCount = File.ReadAllLines(fname_ren_stavbe).Length;
                lineCount--;
                //label2.Text = fnamecrp2;
                label31.Text = "Zap: " + lineCount.ToString();
                label30.Text = "";
                n_renst = 0;
            }
            catch (Exception ex)
            {
                label30.Text = "Datoteka " + fname_ren_stavbe + " ne obstaja!";
                label31.Text = "Zap: " + "0";
                n_renst = 1;
            }
            // ren stavba-naslovi
            try
            {
                var lineCount = File.ReadAllLines(fname_ren_stavba_naslovi).Length;
                lineCount--;
                //label2.Text = fnamecrp2;
                label35.Text = "Zap: " + lineCount.ToString();
                label34.Text = "";
                n_rensn = 0;
            }
            catch (Exception ex)
            {
                label34.Text = "Datoteka " + fname_ren_stavba_naslovi + " ne obstaja!";
                label35.Text = "Zap: " + "0";
                n_rensn = 1;
            }
            // ren deli stavb
            try
            {
                var lineCount = File.ReadAllLines(fname_ren_deli_stavb).Length;
                lineCount--;
                //label2.Text = fnamecrp2;
                label39.Text = "Zap: " + lineCount.ToString();
                label38.Text = "";
                n_rends = 0;
            }
            catch (Exception ex)
            {
                label38.Text = "Datoteka " + fname_ren_deli_stavb + " ne obstaja!";
                label39.Text = "Zap: " + "0";
                n_rends = 1;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Obdelaj_vk1();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Obdelaj_ren_lastniki();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Obdelaj_vk5();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Obdelaj_vk6();
        }
    }
}
