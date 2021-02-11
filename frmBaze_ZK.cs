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
        int stevec;
        string vrstica;
        string naslov_tujina,kraj,posta;

        public frmBaze_ZK()
        {
            InitializeComponent();
        }

        private void Izprazni()
        {
            label9.Text = "";
            label2.Text = "";
            label6.Text = "";

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
        private void IzprazniBazo_vk6()  // izprazni tabelo tbl_pt
        {
            string query = "delete from tbl_vk6_zk_parcele";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
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
                       if (mid_hs!="00000000" || mid_naslova != "00000000") // domači naslov
                        {
                            string ostanek2 = ostanek.Substring(ostanek.IndexOf(",")+2);
                            kraj= ostanek2.Substring(0,ostanek2.IndexOf(";"));  // pred podpicjem
                            posta=ostanek2.Substring(ostanek2.IndexOf(";") + 2); // za podpicjem
                            posta = posta.TrimEnd();
                        }
                        if (mid_hs != "00000000" && mid_naslova != "00000000")
                        // tuji naslov
                        {
                            //string ostanek3 = ostanek.Substring(ostanek.IndexOf("+") + 2);
                            if (ostanek.Contains('+'))
                            {
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
                                MessageBox.Show("--" + ostanek + "--");
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Obdelaj_vk1();

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
