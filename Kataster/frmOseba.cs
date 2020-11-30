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
    public partial class frmOseba : Form
    {
        SqlConnection con = frmMain.c;
        SqlConnection con2 = frmMain.c2;
        SqlConnection con3 = frmMain.c3;

        SqlCommand cmd;
        SqlDataReader rdr = null;

        SqlCommand cmd2;
        SqlDataReader rdr2 = null;

        string q,q2,time1, time2, tpriimek1, tpriimek2, tindeks_osebe, oseba, tspol, thsmid, tdat_roj, tdrzava_roj, thsd_stpr;

        private void frmOseba_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }

        string tmpulica, tmplabela, tmpnaselje, tmpnaslov, tmpposta, tmppt_stev, tmpx, tmpy;
        int voda, smeti, kanalizacija, greznica, cadis, prebivalcev, tid, tzacasno, tkan_ne, tvod_ne;
        string ths_stpr, ths_zcpr, thsd_zcpr, tnaselje_roj, tnaselje_stpr, tposta_zcpr, tstan, tulica_zcpr, tulica_stpr;
        string naslov, stalno, zacasno, kraj_rojstva, starost;

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public frmOseba()
        {
            InitializeComponent();
        }

        private void Nalozi_podatke()
        {
            label1.Text = oseba;
            if (tspol=="M")
            {
                pic_on.Visible = true;
                pic_ona.Visible = false;
                label19.Text = "Moški";
            }
            if (tspol == "Ž")
            {
                pic_on.Visible = false;
                pic_ona.Visible = true;
                label19.Text = "Ženski";
            }
            label20.Text = ""; // emšo
            stalno = tulica_stpr + " " + ths_stpr + thsd_stpr+",  "+tnaselje_stpr;
            if (String.Concat(stalno.Where(c => !Char.IsWhiteSpace(c))) == ",")  // odstrani space
                stalno = "";

            zacasno = tulica_zcpr + " " + ths_zcpr + thsd_zcpr + ",  " + tposta_zcpr;
            if (String.Concat(zacasno.Where(c => !Char.IsWhiteSpace(c))) == ",")
                zacasno = "";

            label24.Text = stalno;
            label25.Text = zacasno;
            label22.Text = tdat_roj;
            label26.Text = tstan;

            // starost v letih
            DateTime dat_roj = DateTime.Parse(tdat_roj);
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(dat_roj.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;
            starost = Convert.ToString(age);
            label21.Text = starost;


            kraj_rojstva = tnaselje_roj;
            if (tdrzava_roj != "" && kraj_rojstva!="")
                kraj_rojstva = tnaselje_roj + ", " + tdrzava_roj;
            else
                kraj_rojstva = tnaselje_roj + tdrzava_roj;


            label23.Text = kraj_rojstva;
            label6.Text = tmpnaslov + " " + tmplabela;

            if (voda == 1)
                label34.Text = "da";
            else
                label34.Text = "";
            if (kanalizacija == 1)
                label35.Text = "da";
            else
                label35.Text = "";
            if (smeti == 1)
                label31.Text = "da";
            else
                label31.Text = "";
            if (greznica == 1)
                label29.Text = "da";
            else
                label29.Text = "";
            label30.Text = "";
        }

        private void Vpisi_ljudi()  // vpiši stalno prijavljene ljudi
        {
            dgv4.ColumnHeadersVisible = false;
            dgv4.RowHeadersVisible = false;
            dgv4.ColumnCount = 1;
            dgv4.Columns[0].Width = 205;


            dgv4.Columns[0].Name = "Oseba";
            //dgv4.Columns[1].Name = "Id";

            dgv4.Columns["Oseba"].Visible = true;
            //dgv4.Columns["Id"].Visible = true;

            // preberi ljudi na tem naslovu
            string q2 = "select * from tbl_crp where hsmid=@tmphsmid order by priimek1 asc"; // preberi vse osebe iz naselja
            try
            {
                cmd2 = new SqlCommand(q2, con2);
                con2.Open();
                cmd2.Parameters.AddWithValue("@tmphsmid", thsmid);
                rdr2 = cmd2.ExecuteReader();
                while (rdr2.Read())
                {
                    tpriimek1 = (string)rdr2["priimek1"];
                    tpriimek2 = (string)rdr2["priimek2"];
                    time1 = (string)rdr2["ime1"];
                    time2 = (string)rdr2["ime2"];
                    tid = (int)rdr2["id"];
                    tzacasno = (int)rdr2["zacasno"];
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
                    string oseba = tpriimek1 + tpriimek2 + time1 + time2;
                    if (tzacasno == 1)
                        oseba = oseba + " (z)";
                    //string[] row2 = new string[] { oseba, tidstr };
                    string[] row2 = new string[] { oseba };
                    dgv4.Rows.Add(row2);

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
        }

        private void frmOseba_Load(object sender, EventArgs e)
        {


            //tindeks_osebe = FrmNaselje.izbrana_oseba;

            //if (frmMain.iz_naselja == true)
            tindeks_osebe = frmMain_kat.izbrana_oseba;

            frmMain_kat.iz_naselja = false;
            frmMain_kat.iz_search = false;
            frmMain_kat.iz_stavbe = false;
            frmMain_kat.iz_osebe = false;

            //tindeks_osebe = "24.05.1965PiercyJasmineaženskivrh9aženskivrh9";

            // preberi osebo iz CRP
            q2 = "select * from tbl_crp where indeks_osebe=@indeks_osebe"; // preberi vse osebe iz naselja
            try
            {
                cmd2 = new SqlCommand(q2, con2);
                con2.Open();
                cmd2.Parameters.AddWithValue("@indeks_osebe", tindeks_osebe);
                rdr2 = cmd2.ExecuteReader();
                while (rdr2.Read())
                {
                    tpriimek1 = (string)rdr2["priimek1"];
                    tpriimek2 = (string)rdr2["priimek2"];
                    time1 = (string)rdr2["ime1"];
                    time2 = (string)rdr2["ime2"];
                    tspol = (string)rdr2["spol"];
                    thsmid = (string)rdr2["hsmid"];
                    tdat_roj = (string)rdr2["dat_roj"];
                    tnaselje_roj = (string)rdr2["naselje_roj"];
                    tdrzava_roj = (string)rdr2["drzava_roj"];
                    tulica_stpr = (string)rdr2["ulica_stpr"];
                    tnaselje_stpr = (string)rdr2["naselje_stpr"];
                    ths_stpr = (string)rdr2["hs_stpr"];
                    thsd_stpr = (string)rdr2["hsd_stpr"];
                    tulica_zcpr = (string)rdr2["ulica_zcpr"];
                    ths_zcpr = (string)rdr2["hs_zcpr"];
                    thsd_zcpr = (string)rdr2["hsd_zcpr"];
                    tposta_zcpr = (string)rdr2["naziv_poste_zcpr"];
                    tstan = (string)rdr2["stan"];

                    if (time2 != "")
                    {
                        time2 = " " + time2;
                    }

                    if (tpriimek2 != "")
                    {
                        tpriimek2 = " " + tpriimek2;
                    }
                    oseba = time1+time2+" "+ tpriimek1 + tpriimek2;
                }  // while read
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka vpiši podatke: " + ex.Message);
            }
            finally
            {
                rdr2.Close();
                con2.Close();
            }

            // preberi stavbo iz tbl_Hise
            try
            {
                q = "select * from tbl_hise where hsmid=@tmphsmid"; // preberi vse zapise iz tbl_hise
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@tmphsmid", thsmid);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tmpnaselje = (string)rdr["naselje"];
                    tmpnaslov = (string)rdr["naslov"];
                    tmplabela = (string)rdr["labela"];
                    tmpulica = (string)rdr["ulica"];
                    tmppt_stev = (string)rdr["pt_stev"];
                    tmpposta = (string)rdr["posta"];
                    kanalizacija = (int)rdr["kanalizacija"];
                    voda = (int)rdr["voda"];
                    smeti = (int)rdr["smeti"];
                    greznica = (int)rdr["greznica"];
                    cadis = (int)rdr["cadis"];
                    //zacasno = (int)rdr["zacasno"];
                    //stalno = (int)rdr["stalno"];
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


            Nalozi_podatke();
            Vpisi_ljudi();

            //MessageBox.Show(FrmNaselje.izbrana_oseba);
        }
    }
}
