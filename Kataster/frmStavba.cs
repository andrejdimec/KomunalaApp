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
    public partial class frmStavba : Form
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

        string tmpulica, tmplabela,tmpnaselje,tmpnaslov,tmpposta,tmppt_stev,tmpx,tmpy,time1,time2,tpriimek1,tpriimek2;
        bool opomba_obstaja;
        int voda, smeti, kanalizacija, greznica, cadis, zacasno, stalno, prebivalcev, tid, tzacasno,tkan_ne,tvod_ne;

        private void dgv4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //frmMain.izbrana_oseba = dgv4.SelectedCells[1].Value.ToString();
                //MessageBox.Show(frmMain.izbrana_oseba);
                //e.SuppressKeyPress = true;
                //int row = dgv4.CurrentRow.Index;
                //int col = dgv4.CurrentCell.ColumnIndex;
                //frmOseba form2 = new frmOseba();
                //form2.ShowDialog();
                //Vpisi_dgv();
            }

        }

        private void dgv4_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // odpri osebo
            frmMain_kat.izbrana_oseba = dgv4.Rows[e.RowIndex].Cells[1].Value.ToString();
            frmOseba form2 = new frmOseba();
            form2.ShowDialog();

        }

        private void frmStavba_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }

        private void cbKan_CheckedChanged(object sender, EventArgs e)
        {
            btnShrani.Enabled = true;
        }

        private void tb4_TextChanged(object sender, EventArgs e)
        {
            btnShrani.Enabled = true;
        }

        double x, y;
        string zac_hsmid, q,dodatni_opis;


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            btnShrani.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            btnShrani.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnShrani.Enabled = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            btnShrani.Enabled = true;
        }

        private void checkBox1_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label36.Text = tb4.Text;
            tvod_ne = 0; tkan_ne = 0;
            if (cbKan.Checked == true)
                tkan_ne = 1;
            if (cbVod.Checked == true)
                tvod_ne = 1;

            // preveri če opombe za stavbo že obstajajo
            try
            {
                q = "SELECT * FROM tbl_hise_dod WHERE hsmid=@idx";
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@idx", zac_hsmid);
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    // opomba še ne obstaja, shrani novo
                    opomba_obstaja = true;

                }
                else
                {
                    // situacija še ne obstaja, shrani
                    opomba_obstaja = false;
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

            if (opomba_obstaja == true)
            {
                // Že obstaja - Shrani spremenjeno opombo
                try
                {
                    q = "update tbl_hise_dod set kan_ne=@kan_ne, vod_ne=@vod_ne, vod_op=@vod_op, kan_op=@kan_op, opomba=@opomba, dodatni_opis=@dodatni_opis";
                    cmd = new SqlCommand(q, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@hsmid", zac_hsmid);
                    cmd.Parameters.AddWithValue("@kan_ne", tkan_ne);
                    cmd.Parameters.AddWithValue("@vod_ne", tvod_ne);
                    cmd.Parameters.AddWithValue("@kan_op", tb1.Text);
                    cmd.Parameters.AddWithValue("@vod_op", tb2.Text);
                    cmd.Parameters.AddWithValue("@opomba", tb3.Text);
                    cmd.Parameters.AddWithValue("@dodatni_opis", tb4.Text);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: update opombe " + ex.Message);
                }
                finally
                {
                    if (con != null)
                    {
                        con.Close();
                    }
                }
            }


            if (opomba_obstaja == false)
            {
                // Še ne obstaja - Shrani novo opombo
                try
                {
                    q = "insert into tbl_hise_dod(hsmid,kan_ne,vod_ne,vod_op,kan_op,opomba,dodatni_opis)" +
                    " values(@hsmid,@kan_ne,@vod_ne,@vod_op,@kan_op,@opomba,@dodatni_opis)";
                    cmd = new SqlCommand(q, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@hsmid", zac_hsmid);
                    cmd.Parameters.AddWithValue("@kan_ne", tkan_ne);
                    cmd.Parameters.AddWithValue("@vod_ne", tvod_ne);
                    cmd.Parameters.AddWithValue("@kan_op", tb1.Text);
                    cmd.Parameters.AddWithValue("@vod_op", tb2.Text);
                    cmd.Parameters.AddWithValue("@opomba", tb3.Text);
                    cmd.Parameters.AddWithValue("@dodatni_opis", tb4.Text);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: dodaj situacijo " + ex.Message);
                }
                finally
                {
                    if (con != null)
                    {
                        con.Close();


                    }
                }
            }
            btnShrani.Enabled = false;
            dgv4.Focus();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public frmStavba()
        {
            InitializeComponent();
        }

        private void frmStavba_Load(object sender, EventArgs e)
        {

           // if (frmMain.iz_naselja==true)
            zac_hsmid = frmMain_kat.izbrani_hsmid;
            frmMain_kat.iz_naselja = false;
            frmMain_kat.iz_search = false;
            frmMain_kat.iz_stavbe = false;
            frmMain_kat.iz_osebe = false;


            try
            {
                // zac_hsmid = "19137481";  // začasno
                q = "select * from tbl_hise where hsmid=@tmphsmid"; // preberi vse zapise iz tbl_hise
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@tmphsmid", zac_hsmid);
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
                    zacasno = (int)rdr["zacasno"];
                    stalno = (int)rdr["stalno"];
                    x = (double)rdr["x"];
                    y = (double)rdr["y"];
                    tmpx = Convert.ToString(x);
                    tmpy = Convert.ToString(y);
                    prebivalcev = stalno + zacasno;
                   
                    //if (tmpulica != "")
                    //{
                    //    tmpnaselje = tmpulica;
                    //}
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
            try 
            {
                cbKan.Checked = false;
                cbVod.Checked = false;
                q = "select * from tbl_hise_dod where hsmid=@tmphsmid"; // preberi opombe za hišo
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@tmphsmid", zac_hsmid);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tb1.Text = (string)rdr["kan_op"];
                    tb2.Text = (string)rdr["vod_op"];
                    tb3.Text = (string)rdr["opomba"];
                    tkan_ne = (int)rdr["kan_ne"];
                    tvod_ne = (int)rdr["vod_ne"];
                    dodatni_opis= (string)rdr["dodatni_opis"];

                    if (tkan_ne == 1)
                        cbKan.Checked = true;
                    if (tvod_ne == 1)
                        cbVod.Checked = true;
                    tb4.Text = dodatni_opis;
                    //{
                    //    tmpnaselje = tmpulica;
                    //}
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

            Vpisi_podatke();
        }

        private void Vpisi_podatke()
        {
            label1.Text = tmpnaslov + " " + tmplabela;
            label5.Text = tmpnaselje;
            label11.Text = tmppt_stev+" "+tmpposta;
            //label12.Text = tmpposta;
            if (voda == 1)
                label27.Text = "da";
            else
                label27.Text = "";
            if (kanalizacija == 1)
                label26.Text = "da";
            else
                label26.Text = "";
            if (smeti == 1)
                label28.Text = "da";
            else
                label28.Text = "";
            if (greznica == 1)
                label29.Text = "da";
            else
                label29.Text = "";

            label30.Text = "";
            label3.Text = ""; // aglomeracija
            label21.Text = zac_hsmid;
            label22.Text = "";
            label23.Text = "";
            label24.Text = tmpx;
            label25.Text = tmpy;

            label32.Text = Convert.ToString(stalno);
            label33.Text = Convert.ToString(zacasno);
            label34.Text = Convert.ToString(prebivalcev);
            label36.Text = dodatni_opis;
            Vpisi_ljudi();
            btnShrani.Enabled = false;

        }

        private void Vpisi_ljudi()  // vpiši stalno prijavljene ljudi
        {
            dgv4.ColumnHeadersVisible = false;
            dgv4.RowHeadersVisible = false;
            dgv4.ColumnCount = 2;
            dgv4.Columns[0].Width = 205;
            dgv4.Columns[1].Width = 1;


            dgv4.Columns[0].Name = "Oseba";
            dgv4.Columns[1].Name = "Indeks";
            //dgv4.Columns[1].Name = "Id";

            dgv4.Columns["Oseba"].Visible = true;
            dgv4.Columns["Indeks"].Visible = true;

                // preberi ljudi na tem naslovu
                string q2 = "select * from tbl_crp where hsmid=@tmphsmid order by priimek1 asc"; // preberi vse osebe iz naselja
                try
                {
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@tmphsmid", zac_hsmid);
                    rdr2 = cmd2.ExecuteReader();
                    while (rdr2.Read())
                    {
                        tpriimek1 = (string)rdr2["priimek1"];
                        tpriimek2 = (string)rdr2["priimek2"];
                        time1 = (string)rdr2["ime1"];
                        time2 = (string)rdr2["ime2"];
                        tid = (int)rdr2["id"];
                        tzacasno = (int)rdr2["zacasno"];
                        string tidx = (string)rdr2["indeks_osebe"];
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
                        string oseba =tpriimek1 + tpriimek2 + time1 + time2;
                    if (tzacasno == 1)
                        oseba = oseba + " (z)";
                        //string[] row2 = new string[] { oseba, tidstr };
                        string[] row2 = new string[] { oseba,tidx};
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

    }
}
