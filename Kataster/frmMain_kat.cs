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
using Microsoft.SqlServer.Server;
using System;
using System.Globalization;
using System.IO;
using System.Configuration;


namespace Komunala
{
    public partial class frmMain_kat : Form
    {
        public static string app_path = ConfigurationManager.AppSettings["app_path"];
        public static string app_path_data = ConfigurationManager.AppSettings["app_path_data"];
        //public static string app_path_data=app_path+"data\";
        // public static string pot = "C:\\KomunalaApp\\Komunala\\data\\";

        public static string cs = ConfigurationManager.ConnectionStrings["ConStr"].ToString();

        public static SqlConnection c = new SqlConnection(cs);
        public static SqlConnection c2 = new SqlConnection(cs);
        public static SqlConnection c3 = new SqlConnection(cs);
        public static SqlConnection c9 = new SqlConnection(cs);

        public static bool iz_naselja, iz_search, iz_stavbe, iz_osebe;
        public static string izbrani_hsmid, izbrana_oseba;
        public static string aplikacija = "Kataster";



        // določi connection
        SqlConnection con = c;
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataReader rdr = null;

        SqlConnection con2 = c2;
        SqlCommand cmd2;
        SqlDataReader rdr2 = null;

        // prenesi v formo frmNaselje
        public static int a_prebivalcev, a_zacasnih, a_stalnih, a_stavb;
        public static double a_povrsina;
        public static string a_naselje;
        public static int a_v_stavb, a_k_stavb, a_s_stavb, a_g_stavb = 0, a_v_ljudi, a_k_ljudi, a_s_ljudi, a_g_ljudi;
        public static double a_v_procstavb, a_k_procstavb, a_s_procstavb, a_g_procstavb, a_v_procljudi, a_k_procljudi, a_s_procljudi, a_g_procljudi;

        private void dgv3_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //string mapa = "C:\\KatApp\\Kataster\\data\\";

        private void button2_Click(object sender, EventArgs e)
        {
            frmIjsvo secondForm = new frmIjsvo();
            secondForm.ShowDialog();
            // Environment.Exit(0);
            //dgv.
            Preberi_naselja();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmIsci_n secondForm = new frmIsci_n();
            secondForm.ShowDialog();
            dgv3.Refresh();
            dgv1.Refresh();

        }

        //quantity=TextBox1.text; \\Value which you want to pass


        private void button6_Click(object sender, EventArgs e)
        {
            frmIsci_o secondForm = new frmIsci_o();
            secondForm.ShowDialog();
            //Environment.Exit(0);
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                frmIsci_o secondForm = new frmIsci_o();
                secondForm.ShowDialog();

            }
            if (e.KeyCode == Keys.F2)
            {
                frmIsci_n secondForm = new frmIsci_n();
                secondForm.ShowDialog();

            }
        }

        string m1 = "data\\";
        string fname_nas;  // datoteka z naselji
                           // string q = "";
                           // int a_prebivalcev, a_zacasnih, a_stalnih, a_stavb;
                           // double a_povrsina;
                           // string a_naselje;

        public frmMain_kat()
        {
            InitializeComponent();
        }
        private void Izprazni_dgv()
        {
            dgv3.Rows.Clear();
            dgv3.Refresh();
        }


        private void Preberi_naselja()
        {
            Izprazni_dgv();
            // float povrsina = 0;

            string povrsinastr = "";
            string naselje = "";
            string namid_ok = ""; // to naselje trnutno bere
                                  // string prebivalcevstr = "";
            string stalnihstr = "", zacasnihstr = "", prebivalcevstr = "", stavbstr = "";
            string ob_stalnihstr = "", ob_zacasnihstr = "", ob_stavbstr = "", ob_prebivalcevstr = "", ob_povrsinastr = "";
            int ob_prebivalcev = 0, ob_stalnih = 0, ob_zacasnih = 0, ob_stavb = 0;
            double ob_povrsina = 0;
            int prebivalcev = 0, prebivalcevtemp = 0;
            int zacasnih = 0, zacasnihtemp = 0;
            int stalnih = 0, stalnihtemp = 0;
            int stavb = 0, stavbtemp = 0;

            int voda = 0, kanalizacija = 0, smeti = 0, greznica = 0;
            string vodas = "", kanalizacijas = "", smetis = "", greznicas = "";
            int ob_voda = 0, ob_kanalizacija = 0, ob_smeti = 0, ob_greznica = 0;
            string ob_vodas = "", ob_kanalizacijas = "", ob_smetis = "", ob_greznicas = "";

            string vodastr = "", ob_vodastr = "", voda_procstr = "", ob_voda_procstr = "";
            string kanalizacijastr = "", ob_kanalizacijastr = "", kanalizacija_procstr = "", ob_kanalizacija_procstr = "";
            string smetistr = "", ob_smetistr = "", smeti_procstr = "", ob_smeti_procstr = "";
            string greznicastr = "", ob_greznicastr = "", greznica_procstr = "", ob_greznica_procstr = "";

            double voda_proc = 0;
            double kanalizacija_proc = 0;
            double greznica_proc = 0;
            double smeti_proc = 0;

            // storitve po ljudeh
            int ljudi = 0, k_ljudi = 0, v_ljudi = 0, g_ljudi = 0, s_ljudi = 0, stpr_ljudi = 0, zcpr_ljudi = 0, obv_ljudi = 0, obk_ljudi = 0, obg_ljudi = 0, obs_ljudi = 0;
            string strk_ljudi = "", strv_ljudi = "", strs_ljudi = "", strg_ljudi = "", strobv_ljudi = "", strobk_ljudi = "", strobg_ljudi = "", strobs_ljudi = "";
            string strobvodaprocl = "", strobkanprocl = "", strobsmeprocl = "", strobgreprocl = "";

            // prikaži v grid

            dgv1.AllowUserToAddRows = false;
            dgv3.AllowUserToAddRows = false;
            dgv2.AllowUserToAddRows = false;

            dgv2.ColumnHeadersVisible = false;
            dgv1.ColumnHeadersVisible = false;
            //dgv3.ColumnHeadersVisible = false;
            dgv1.RowHeadersVisible = false;
            dgv2.RowHeadersVisible = false;
            dgv3.RowHeadersVisible = false;

            dgv1.ColumnCount = 22;
            dgv3.ColumnCount = 22;

            dgv2.ColumnCount = 6;
            dgv2.Columns[0].Name = "NASELJE";
            dgv2.Columns[1].Name = "PREBIVALCI";
            dgv2.Columns[2].Name = "VODOVOD";
            dgv2.Columns[3].Name = "KANALIZACIJA";
            dgv2.Columns[4].Name = "SMETI";
            dgv2.Columns[5].Name = "GREZNICE";

            dgv2.Rows.Add("NASELJE", "PREBIVALCI", "VODA", "KANALIZACIJA", "SMETI", "GREZNICE");
            dgv2.Columns[0].Width = 343;
            dgv2.Columns[1].Width = 180;
            dgv2.Columns[2].Width = 200;
            dgv2.Columns[3].Width = 200;
            dgv2.Columns[4].Width = 200;
            dgv2.Columns[5].Width = 200;
            this.dgv2.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv2.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv2.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv2.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv2.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv2.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv3.Columns[0].Name = "Naziv";
            dgv3.Columns[1].Name = "   Ha";
            dgv3.Columns[2].Name = "Stavbe";
            dgv3.Columns[3].Name = "Vseh";
            dgv3.Columns[4].Name = "Stalno";
            dgv3.Columns[5].Name = "Začasno";
            dgv3.Columns[6].Name = "Stavb";
            dgv3.Columns[7].Name = "   %";
            dgv3.Columns[8].Name = "Ljudi";
            dgv3.Columns[9].Name = "   %";
            dgv3.Columns[10].Name = "Stavb";
            dgv3.Columns[11].Name = "   %";
            dgv3.Columns[12].Name = "Ljudi";
            dgv3.Columns[13].Name = "   %";
            dgv3.Columns[14].Name = "Stavb";
            dgv3.Columns[15].Name = "   %";
            dgv3.Columns[16].Name = "Ljudi";
            dgv3.Columns[17].Name = "   %";
            dgv3.Columns[18].Name = "Stavb";
            dgv3.Columns[19].Name = "   %";
            dgv3.Columns[20].Name = "Ljudi";
            dgv3.Columns[21].Name = "   %";

            // širine kolon
            dgv3.Columns[0].Width = 223;
            dgv3.Columns[1].Width = 60;
            dgv3.Columns[2].Width = 60;
            dgv3.Columns[3].Width = 60;
            dgv3.Columns[4].Width = 60;
            dgv3.Columns[5].Width = 60;
            dgv3.Columns[6].Width = 50;
            dgv3.Columns[7].Width = 50;
            dgv3.Columns[8].Width = 50;
            dgv3.Columns[9].Width = 50;
            dgv3.Columns[10].Width = 50;
            dgv3.Columns[11].Width = 50;
            dgv3.Columns[12].Width = 50;
            dgv3.Columns[13].Width = 50;
            dgv3.Columns[14].Width = 50;
            dgv3.Columns[15].Width = 50;
            dgv3.Columns[16].Width = 50;
            dgv3.Columns[17].Width = 50;
            dgv3.Columns[18].Width = 50;
            dgv3.Columns[19].Width = 50;
            dgv3.Columns[20].Width = 50;
            dgv3.Columns[21].Width = 50;

            dgv1.Columns[0].Width = 223;
            dgv1.Columns[1].Width = 60;
            dgv1.Columns[2].Width = 60;
            dgv1.Columns[3].Width = 60;
            dgv1.Columns[4].Width = 60;
            dgv1.Columns[5].Width = 60;
            dgv1.Columns[6].Width = 50;
            dgv1.Columns[7].Width = 50;
            dgv1.Columns[8].Width = 50;
            dgv1.Columns[9].Width = 50;
            dgv1.Columns[10].Width = 50;
            dgv1.Columns[11].Width = 50;
            dgv1.Columns[12].Width = 50;
            dgv1.Columns[13].Width = 50;
            dgv1.Columns[14].Width = 50;
            dgv1.Columns[15].Width = 50;
            dgv1.Columns[16].Width = 50;
            dgv1.Columns[17].Width = 50;
            dgv1.Columns[18].Width = 50;
            dgv1.Columns[19].Width = 50;
            dgv1.Columns[20].Width = 50;
            dgv1.Columns[21].Width = 50;

            // centriranje
            this.dgv3.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgv3.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[16].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[17].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[18].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[19].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[20].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[21].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgv3.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgv3.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[19].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[20].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv3.Columns[21].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgv1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgv1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.Columns[17].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.Columns[18].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.Columns[19].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.Columns[20].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.Columns[21].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            string q = "select na_mid, na_uime,povrsina from tbl_na"; // preberi vse zapise iz tbl_na
            cmd = new SqlCommand(q, con);
            con.Open();
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                naselje = (string)rdr["na_uime"];// število vrstic v CSV
                double povrsina = (double)rdr["povrsina"];
                povrsina = povrsina / 1000000;
                povrsinastr = povrsina.ToString("F2");
                // a_povrsina = povrsina;
                namid_ok = (string)rdr["na_mid"];// število vrstic v CSV

                SqlDataReader rdr2 = null;
                try
                {
                    // število prebivalcev

                    zacasnih = 0;
                    stalnih = 0;
                    prebivalcev = 0;
                    string q2 = "select na_s, zacasno, stalno from tbl_crp where na_s = @na_midtmp"; // preberi vse zapise iz tbl_na
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@na_midtmp", namid_ok); // preberi naselje
                    rdr2 = cmd2.ExecuteReader();
                    while (rdr2.Read())
                    {
                        // MessageBox.Show((string)rdr["na_s"]);
                        //                      prebivalcev++;
                        zacasnihtemp = (Int32)rdr2["zacasno"];// število vrstic v CSV
                        stalnihtemp = (Int32)rdr2["stalno"];// število vrstic v CSV
                        //stalnihstr = (string)rdr2["na_s"];// število vrstic v CSV

                        //stalnihstr = (string)rdr["stalno"];// število vrstic v CSV
                        if (zacasnihtemp == 1)
                        {
                            zacasnih++;
                            prebivalcev++;
                        }
                        if (stalnihtemp == 1)
                        {
                            stalnih++;
                            prebivalcev++;
                        }
                    }
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("Napaka reader2: " + ex2.Message);
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
                ob_zacasnih = ob_zacasnih + zacasnih;
                ob_stalnih = ob_stalnih + stalnih;
                ob_prebivalcev = ob_prebivalcev + prebivalcev;
                zacasnihstr = Convert.ToString(zacasnih);
                stalnihstr = Convert.ToString(stalnih);
                prebivalcevstr = Convert.ToString(prebivalcev);
                a_prebivalcev = prebivalcev;
                a_zacasnih = zacasnih;
                a_stalnih = stalnih;

                if (zacasnihstr == "0")  // novo 24-8-2020
                {
                    zacasnihstr = "";
                }
                //if (voda_procstr == "0")
                //{
                //    voda_procstr = "";
                //}


                // število stavb
                string namid_temp = "";
                //stavb = 0;  // začasno - verjetno briši
                int vodatmp = 0, kanalizacijatmp = 0, smetitmp = 0, greznicatmp = 0;
                ljudi = 0; v_ljudi = 0; k_ljudi = 0; s_ljudi = 0; g_ljudi = 0;

                try
                {
                    // int voda = 0;
                    string q2 = "select namid, voda, kanalizacija, greznica, smeti,stalno,zacasno from tbl_hise where namid = @na_midtmp"; // preberi vse zapise iz tbl_na
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@na_midtmp", namid_ok); // preberi naselje
                    rdr2 = cmd2.ExecuteReader();
                    while (rdr2.Read())
                    {

                        //                        ljudi = 0;v_ljudi = 0;k_ljudi = 0;s_ljudi = 0;g_ljudi = 0;

                        namid_temp = (String)rdr2["namid"];  // ali obstaja zapis v tbl_hise
                        stpr_ljudi = (Int32)rdr2["stalno"];
                        zcpr_ljudi = (Int32)rdr2["zacasno"];
                        ljudi = stpr_ljudi + zcpr_ljudi; // koliko ljudi je v bajti

                        if (namid_temp != "")
                        {
                            stavb++;
                            if (voda == 1)
                            {
                                vodatmp++;
                                v_ljudi = v_ljudi + ljudi;
                            }
                            if (kanalizacija == 1)
                            {
                                kanalizacijatmp++;
                                k_ljudi = k_ljudi + ljudi;
                            }
                            if (greznica == 1)
                            {
                                greznicatmp++;
                                g_ljudi = g_ljudi + ljudi;
                            }
                            if (smeti == 1)
                            {
                                smetitmp++;
                                s_ljudi = s_ljudi + ljudi;
                            }
                        }
                        if (rdr2["voda"] != DBNull.Value)
                        {
                            voda = (Int32)rdr2["voda"];
                        }
                        if (rdr2["kanalizacija"] != DBNull.Value)
                        {
                            kanalizacija = (Int32)rdr2["kanalizacija"];
                        }
                        if (rdr2["smeti"] != DBNull.Value)
                        {
                            smeti = (Int32)rdr2["smeti"];
                        }
                        if (rdr2["greznica"] != DBNull.Value)
                        {
                            greznica = (Int32)rdr2["greznica"];
                        }

                    } // while reader
                    ob_stavb = ob_stavb + stavb;
                    ob_voda = ob_voda + vodatmp;
                    obv_ljudi = obv_ljudi + v_ljudi;
                    obk_ljudi = obk_ljudi + k_ljudi;
                    obg_ljudi = obg_ljudi + g_ljudi;
                    obs_ljudi = obs_ljudi + s_ljudi;
                    ob_kanalizacija = ob_kanalizacija + kanalizacijatmp;
                    ob_greznica = ob_greznica + greznicatmp;
                    ob_smeti = ob_smeti + smetitmp;

                }
                catch (Exception ex2)
                {
                    MessageBox.Show("Napaka reader2: " + ex2.Message);
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
                stavbstr = Convert.ToString(stavb);
                ob_stavbstr = Convert.ToString(ob_stavb);
                ob_povrsina = ob_povrsina + povrsina;
                ob_zacasnihstr = Convert.ToString(ob_zacasnih);
                ob_stalnihstr = Convert.ToString(ob_stalnih);
                ob_prebivalcevstr = Convert.ToString(ob_prebivalcev);


                //                vodastr = Convert.ToString(vodatmp);
                //                ob_vodastr = Convert.ToString(ob_voda);

                //int ljudi = 0, k_ljudi = 0, v_ljudi = 0, g_ljudi = 0, s_ljudi = 0, stpr_ljudi = 0, zcpr_ljudi = 0, obv_ljudi = 0, obk_ljudi = 0, obg_ljudi = 0, obs_ljudi = 0;
                //string strk_ljudi = "", strv_ljudi = "", strs_ljudi = "", strg_ljudi = "", strobv_ljudi = "", strobk_ljudi = "", strobg_ljudi = "", strobs_ljudi = "";

                vodastr = Convert.ToString(vodatmp);
                ob_vodastr = Convert.ToString(ob_voda);
                strobv_ljudi = Convert.ToString(obv_ljudi);
                voda_proc = ((vodatmp * 100) / stavb);
                voda_procstr = voda_proc.ToString("F0");
                double ob_voda_proc = ((ob_voda * 100) / ob_stavb);
                ob_voda_procstr = ob_voda_proc.ToString("F0");
                strv_ljudi = Convert.ToString(v_ljudi);
                //procent ljudi na vodi
                double voda_procl = ((v_ljudi * 100) / prebivalcev);
                string strvodaprocl = voda_procl.ToString("F0");
                double obvoda_procl = ((obv_ljudi * 100) / ob_prebivalcev);
                strobvodaprocl = obvoda_procl.ToString("F0");
                // double ob_voda_procl = ((obv_ljudi * 100) / ob_ljudi);
                //ob_voda_procstr = ob_voda_proc.ToString("F0");

                if (vodastr == "0")
                {
                    vodastr = "";
                }
                if (voda_procstr == "0")
                {
                    voda_procstr = "";
                }
                if (strvodaprocl == "0")
                {
                    strvodaprocl = "";
                }
                if (strv_ljudi == "0")
                {
                    strv_ljudi = "";
                }

                kanalizacijastr = Convert.ToString(kanalizacijatmp);
                ob_kanalizacijastr = Convert.ToString(ob_kanalizacija);
                kanalizacija_proc = ((kanalizacijatmp * 100) / stavb);
                kanalizacija_procstr = kanalizacija_proc.ToString("F0");
                double ob_kanalizacija_proc = ((ob_kanalizacija * 100) / ob_stavb);
                ob_kanalizacija_procstr = ob_kanalizacija_proc.ToString("F0");
                strk_ljudi = Convert.ToString(k_ljudi);
                double kan_procl = ((k_ljudi * 100) / prebivalcev);
                string strkanaprocl = kan_procl.ToString("F0");
                double obkan_procl = ((obk_ljudi * 100) / ob_prebivalcev);
                strobkanprocl = obkan_procl.ToString("F0");

                strobk_ljudi = Convert.ToString(obk_ljudi);

                if (kanalizacijastr == "0")
                {
                    kanalizacijastr = "";
                }
                if (kanalizacija_procstr == "0")
                {
                    kanalizacija_procstr = "";
                }
                if (strk_ljudi == "0")
                {
                    strk_ljudi = "";
                }
                if (strkanaprocl == "0")
                {
                    strkanaprocl = "";
                }

                greznicastr = Convert.ToString(greznicatmp);
                ob_greznicastr = Convert.ToString(ob_greznica);
                greznica_proc = ((greznicatmp * 100) / stavb);
                greznica_procstr = greznica_proc.ToString("F0");
                double ob_greznica_proc = ((ob_greznica * 100) / ob_stavb);
                ob_greznica_procstr = ob_greznica_proc.ToString("F0");
                strg_ljudi = Convert.ToString(g_ljudi);
                double gre_procl = ((g_ljudi * 100) / prebivalcev);
                string strgreprocl = gre_procl.ToString("F0");
                double obgre_procl = ((obg_ljudi * 100) / ob_prebivalcev);
                strobgreprocl = obgre_procl.ToString("F0");
                strobg_ljudi = Convert.ToString(obg_ljudi);
                if (greznicastr == "0")
                {
                    greznicastr = "";
                }
                if (greznica_procstr == "0")
                {
                    greznica_procstr = "";
                }
                if (strg_ljudi == "0")
                {
                    strg_ljudi = "";
                }
                if (strgreprocl == "0")
                {
                    strgreprocl = "";
                }

                smetistr = Convert.ToString(smetitmp);
                ob_smetistr = Convert.ToString(ob_smeti);
                smeti_proc = ((smetitmp * 100) / stavb);
                smeti_procstr = smeti_proc.ToString("F0");
                double ob_smeti_proc = ((ob_smeti * 100) / ob_stavb);
                ob_smeti_procstr = ob_smeti_proc.ToString("F0");
                strs_ljudi = Convert.ToString(s_ljudi);
                double sme_procl = ((s_ljudi * 100) / prebivalcev);
                string strsmeprocl = sme_procl.ToString("F0");
                double obsme_procl = ((obs_ljudi * 100) / ob_prebivalcev);
                strobsmeprocl = obsme_procl.ToString("F0");


                strobs_ljudi = Convert.ToString(obs_ljudi);
                if (smetistr == "0")
                {
                    smetistr = "";
                }
                if (smeti_procstr == "0")
                {
                    smeti_procstr = "";
                }
                if (strs_ljudi == "0")
                {
                    strs_ljudi = "";
                }
                if (strsmeprocl == "0")
                {
                    strsmeprocl = "";
                }

                stavb = 0;
                string[] row = new string[] { naselje, povrsinastr, stavbstr,prebivalcevstr,stalnihstr,zacasnihstr,
                    vodastr,voda_procstr,strv_ljudi,strvodaprocl,kanalizacijastr,kanalizacija_procstr,strk_ljudi,strkanaprocl,
                    smetistr,smeti_procstr,strs_ljudi,strsmeprocl,greznicastr,greznica_procstr,strg_ljudi,strgreprocl };
                dgv3.Rows.Add(row);


                voda = 0; kanalizacija = 0; greznica = 0; smeti = 0; // verjetno briši - novo 24-8-2020

            }  // while read
            rdr.Close();
            con.Close();

            // cela občina
            ob_povrsinastr = ob_povrsina.ToString("F2");
            dgv1.Rows.Add("Cela občina", ob_povrsinastr, ob_stavbstr, ob_prebivalcevstr, ob_stalnihstr, ob_zacasnihstr,
                ob_vodastr, ob_voda_procstr, strobv_ljudi, strobvodaprocl, ob_kanalizacijastr, ob_kanalizacija_procstr, strobk_ljudi, strobkanprocl,
                ob_smetistr, ob_smeti_procstr, strobs_ljudi, strobsmeprocl, ob_greznicastr, ob_greznica_procstr, strobg_ljudi, strobgreprocl);
            dgv3.Refresh();
            dgv1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(app_path);
            // PREBERI NASELJA
            //Odpri_naselje("Ivanjševci ob Ščavnici");
            //FrmNaselje secondForm = new FrmNaselje();
            //secondForm.ShowDialog();
            //Environment.Exit(0);

            //frmBaze_last secondForm = new frmBaze_last();
            //secondForm.ShowDialog();

            //frmIsci_n secondForm = new frmIsci_n();
            //secondForm.ShowDialog();

            //Environment.Exit(0);


            Preberi_naselja();

            //Okno_baze();
        }

        // poveži conn string

        private void Okno_baze()
        {
            frmBaze secondForm = new frmBaze();
            secondForm.ShowDialog();
            // Environment.Exit(0);
            //dgv.
            Preberi_naselja();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; 
            //Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Okno_baze();
        }

        private void tblhsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // osveži
            Preberi_naselja();
        }

        private void dgv3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string msg = String.Format("Row: {0}, Column: {1}",
            dgv3.CurrentCell.RowIndex,
            dgv3.CurrentCell.ColumnIndex);
            //string arg = dgv3.Rows[e.RowIndex].Cells[1].Value.ToString();
            // MessageBox.Show(msg, "Current Cell");

            //GridViewRow row = dgv3.SelectedRow;

            //// Display the first name from the selected row.
            //// In this example, the third column (index 2) contains
            //// the first name.
            //MessageLabel.Text = "You selected " + row.Cells[2].Text + ".";
            //var dataIndexNo = dgv3.Rows[e.RowIndex].Index.ToString();
            //string cellValue = dgv3.Rows[e.RowIndex].Cells[1].Value.ToString();

            //MessageBox.Show("The row index = " + dataIndexNo.ToString() + " and the row data in second column is: "
            //  + cellValue.ToString());
        }
        private void Zacasne_spremenljivke()
        {
            // samo za test

            a_naselje = "Ivanjševci ob Ščavnici";
        }
        private void dgv3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            a_naselje = dgv3.Rows[e.RowIndex].Cells[0].Value.ToString();

            if (dgv3.Rows[e.RowIndex].Cells[1].Value == "")
                a_povrsina = 0;
            else
                a_povrsina = Convert.ToDouble(dgv3.Rows[e.RowIndex].Cells[1].Value.ToString());

            if (dgv3.Rows[e.RowIndex].Cells[2].Value == "")
                a_stavb = 0;
            else
                a_stavb = Convert.ToInt32(dgv3.Rows[e.RowIndex].Cells[2].Value.ToString());

            if (dgv3.Rows[e.RowIndex].Cells[3].Value == "")
                a_prebivalcev = 0;
            else
                a_prebivalcev = Convert.ToInt32(dgv3.Rows[e.RowIndex].Cells[3].Value.ToString());

            if (dgv3.Rows[e.RowIndex].Cells[4].Value == "")
                a_stalnih = 0;
            else
                a_stalnih = Convert.ToInt32(dgv3.Rows[e.RowIndex].Cells[4].Value.ToString());

            if (dgv3.Rows[e.RowIndex].Cells[5].Value == "")
                a_zacasnih = 0;
            else
                a_zacasnih = Convert.ToInt32(dgv3.Rows[e.RowIndex].Cells[5].Value.ToString());

            if (dgv3.Rows[e.RowIndex].Cells[6].Value == "")
                a_v_stavb = 0;
            else
                a_v_stavb = Convert.ToInt32(dgv3.Rows[e.RowIndex].Cells[6].Value.ToString());

            if (dgv3.Rows[e.RowIndex].Cells[7].Value == "")
                a_v_procstavb = 0;
            else
                a_v_procstavb = Convert.ToDouble(dgv3.Rows[e.RowIndex].Cells[7].Value.ToString());

            if (dgv3.Rows[e.RowIndex].Cells[8].Value == "")
                a_v_ljudi = 0;
            else
                a_v_ljudi = Convert.ToInt32(dgv3.Rows[e.RowIndex].Cells[8].Value.ToString());

            if (dgv3.Rows[e.RowIndex].Cells[9].Value == "")
                a_v_procljudi = 0;
            else
                a_v_procljudi = Convert.ToDouble(dgv3.Rows[e.RowIndex].Cells[9].Value.ToString());

            if (dgv3.Rows[e.RowIndex].Cells[10].Value == "")
                a_k_stavb = 0;
            else
                a_k_stavb = Convert.ToInt32(dgv3.Rows[e.RowIndex].Cells[10].Value.ToString());

            if (dgv3.Rows[e.RowIndex].Cells[11].Value == "")
                a_v_procstavb = 0;
            else
                a_v_procstavb = Convert.ToDouble(dgv3.Rows[e.RowIndex].Cells[11].Value.ToString());

            if (dgv3.Rows[e.RowIndex].Cells[12].Value == "")
                a_k_ljudi = 0;
            else
                a_k_ljudi = Convert.ToInt32(dgv3.Rows[e.RowIndex].Cells[10].Value.ToString());

            if (dgv3.Rows[e.RowIndex].Cells[13].Value == "")
                a_k_procljudi = 0;
            else
                a_k_procljudi = Convert.ToDouble(dgv3.Rows[e.RowIndex].Cells[13].Value.ToString());

            if (dgv3.Rows[e.RowIndex].Cells[14].Value == "")
                a_s_stavb = 0;
            else
                a_s_stavb = Convert.ToInt32(dgv3.Rows[e.RowIndex].Cells[14].Value.ToString());

            if (dgv3.Rows[e.RowIndex].Cells[15].Value == "")
                a_s_procstavb = 0;
            else
                a_s_procstavb = Convert.ToDouble(dgv3.Rows[e.RowIndex].Cells[15].Value.ToString());

            if (dgv3.Rows[e.RowIndex].Cells[16].Value == "")
            {
                a_s_ljudi = 0;
            }
            else
            {
                a_s_ljudi = Convert.ToInt32(dgv3.Rows[e.RowIndex].Cells[16].Value.ToString());
            }

            if (dgv3.Rows[e.RowIndex].Cells[17].Value == "")
                a_s_procljudi = 0;
            else
                a_s_procljudi = Convert.ToDouble(dgv3.Rows[e.RowIndex].Cells[17].Value.ToString());

            if (dgv3.Rows[e.RowIndex].Cells[18].Value == "")
            {
                a_g_stavb = 0;
            }
            else
            {
                a_g_stavb = Convert.ToInt32(dgv3.Rows[e.RowIndex].Cells[18].Value.ToString());
            }

            if (dgv3.Rows[e.RowIndex].Cells[19].Value == "")
                a_g_procstavb = 0;
            else
                a_g_procstavb = Convert.ToDouble(dgv3.Rows[e.RowIndex].Cells[19].Value.ToString());

            if (dgv3.Rows[e.RowIndex].Cells[20].Value == "")
            {
                a_g_ljudi = 0;
            }
            else
            {
                a_g_ljudi = Convert.ToInt32(dgv3.Rows[e.RowIndex].Cells[20].Value.ToString());
            }

            if (dgv3.Rows[e.RowIndex].Cells[21].Value == "")
                a_g_procljudi = 0;
            else
                a_g_procljudi = Convert.ToDouble(dgv3.Rows[e.RowIndex].Cells[21].Value.ToString());

            FrmNaselje form2 = new FrmNaselje();
            form2.ShowDialog();
        }


        private void Prave_spremenljivke()
        {

        }

        private void Odpri_naselje(string arg)
        {
            Zacasne_spremenljivke();
            FrmNaselje form2 = new FrmNaselje();
            form2.ShowDialog();
            //Environment.Exit(0);  // začasno
        }

    }
}
