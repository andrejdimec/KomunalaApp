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

        string fname_vk1 = frmMain.pot_podatki + "zk\\" + "ob_vk1.dat";  // baza z osebami
        int n_vk1;
        int stevec;
        string vrstica;

        public frmBaze_ZK()
        {
            InitializeComponent();
        }

        private void Izprazni()
        {
            label9.Text = "";
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

        private void Izprazni_vk1() // izprazni variable za tabelo tbl_na
        {
        //    pt_id = ""; pt_uime = ""; pt_mid = "";
        }

        private void Obdelaj_vk1()
        {
            if (n_vk1 == 0)
            {
                stevec = 0;
                IzprazniBazo_vk1();
                // preberi HS - CSV
                try
                {
                    System.IO.StreamReader objReader;
                    objReader = new System.IO.StreamReader(fname_vk1, ASCIIEncoding.UTF8);
                    // število vrstic v CSV
                    do
                    {
                        vrstica = "";
                        Izprazni_vk1();
                        vrstica = objReader.ReadLine() + "\r\n";
                        //MessageBox.Show(Convert.ToString(vrstica.Length));
                        //MessageBox.Show("+" + vrstica + "+");
                        //string test = vrstica.Substring(35, 61);
                        //MessageBox.Show("+" + vrstica + "+   -"+test+"-");
                        string emso = vrstica.Substring(1, 13);
                        //MessageBox.Show(emso);
                        string sif_obcine = vrstica.Substring(14, 3);
                        string sif_naselja = vrstica.Substring(17, 3);
                        string sif_ulice = vrstica.Substring(20, 3);
                        string hs = vrstica.Substring(24, 3);
                        string hd = vrstica.Substring(27, 1);
                        //MessageBox.Show(Convert.ToString(vrstica.Length));

                        string st_poste = vrstica.Substring(31, 4);
                        //MessageBox.Show(st_poste);
                        string priimek_ime = vrstica.Substring(35, 60);
                        //MessageBox.Show(Convert.ToString(vrstica.Length));
                        string status_osebe = vrstica.Substring(95, 1);
                        string mid_naslova = vrstica.Substring(96, 8);
                        string mid_hs = vrstica.Substring(104, 8);
                        //MessageBox.Show(emso);

                        // napiši prebrano v tabelo vk1
                        try
                        {
                            if (stevec > 0)
                            {

                                string query = "insert into tbl_vk1_zk_osebe (emso, sif_obcine,sif_naselja,sif_ulice,hs,hsd,st_poste,priimek_ime,status_osebe,mid_naslova,mid_hs) " +
                                    "values(@emso,@sif_obcine,@sif_naselja,@sif_ulice,@hs,@hd,@st_poste,@priimek_ime,@status_osebe,@mid_naslova,@mid_hs)";
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
                    } while (objReader.Peek() != -1);
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
                    //DisplayData_hs();
                }
            }
            else
            {
                MessageBox.Show("Napaka! Datoteka ne obstaja: " + fname_vk1);
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
                label51.Text = "Zapisov: "+lineCount.ToString();
                label52.Text = "";
                n_vk1 = 0;
            }
            catch (Exception ex)
            {
                label52.Text = "Datoteka " + fname_vk1 + " ne obstaja!";
                label51.Text = "Zapisov: " + "0";
                n_vk1 = 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Obdelaj_vk1();

        }
    }
}
