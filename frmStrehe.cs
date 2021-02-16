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
    public partial class frmStrehe : Form
    {

        SqlConnection con = frmMain.c;
        SqlConnection con2 = frmMain.c2;
        SqlConnection con3 = frmMain.c3;
        SqlConnection con9 = frmMain.c9;
        SqlConnection con6 = frmMain.c6;
        SqlDataAdapter adapt;

        SqlCommand cmd;
        SqlDataReader rdr = null;

        SqlCommand cmd2;
        SqlDataReader rdr2 = null;

        SqlCommand cmd3;
        SqlDataReader rdr3 = null;

        SqlDataReader rdr9 = null;
        SqlCommand cmd9;

        SqlDataReader rdr6 = null;
        SqlCommand cmd6;

        static DataTable dt, dt2, dt3, dt4;
        string q,q2,q3,q6,q9;

        string idx_sta, hsmid_gl;
        string sta_sid, st_stanovanj, st_poslovnih_prostorov;

        private void Strehe() // informacije o celi bazi streh
        {
            q2 = "select count(*) from ren_strehe";
            cmd2 = new SqlCommand(q2, con2);
            con2.Open();
            int vseh_zapisov = (Int32)cmd2.ExecuteScalar();
            label16.Text = vseh_zapisov.ToString();
            con2.Close();

            string q6 = "SELECT SUM (povrsina) FROM ren_strehe";
            cmd6 = new SqlCommand(q6, con6);
            con6.Open();
            double vsota_streh = (double)cmd6.ExecuteScalar();
            label3.Text = vsota_streh.ToString("N2");
            con6.Close();
        }

        private void Vpisi_strehe(string vhos)
        {
            dgvs.RowHeadersVisible = false;
            if (cb_vec.Checked)
                q = "SELECT ren_Strehe.Id, ren_Strehe.SID AS sid, ren_Strehe.OM_naslov AS nasl, tbl_ren_stavbe.st_stanovanj AS stan, tbl_ren_stavbe.st_poslovnih_prostorov AS posl, tbl_ren_stavbe.sta_sid,ren_Strehe.ObjectId FROM ren_Strehe " +
                    "LEFT JOIN tbl_ren_stavbe ON ren_Strehe.SID = tbl_ren_stavbe.sta_sid WHERE(tbl_ren_stavbe.st_stanovanj + tbl_ren_stavbe.st_poslovnih_prostorov > 1) AND (ren_Strehe.Glavna_streha = N'1') order by nasl";
            else
                q = "SELECT ren_Strehe.Id, ren_Strehe.SID AS sid, ren_Strehe.OM_naslov AS nasl, tbl_ren_stavbe.st_stanovanj AS stan, tbl_ren_stavbe.st_poslovnih_prostorov AS posl, tbl_ren_stavbe.sta_sid FROM ren_Strehe " +
                    "LEFT JOIN tbl_ren_stavbe ON ren_Strehe.SID = tbl_ren_stavbe.sta_sid WHERE (ren_Strehe.Glavna_streha = N'1') order by nasl";

            var da = new SqlDataAdapter(q, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dgvs.DataSource = dt;
            dgvs.ReadOnly = true;
            dgvs.Columns[0].Visible = false;
            dgvs.Columns[5].Visible = false;
            dgvs.Columns[1].Width = 80;
            dgvs.Columns[2].Width = 185;
            dgvs.Columns[3].Width = 30;
            dgvs.Columns[4].Width = 30;
            dgvs.Columns[1].HeaderText = "ID";
            dgvs.Columns[2].HeaderText = "Naslov";
            dgvs.Columns[3].HeaderText = "St";
            dgvs.Columns[4].HeaderText = "Po";

            //dgvs.Columns[1].Visible = false;
            //dgv1.Columns["povrsina"].Visible = false;
            //dgv1.Columns["ko_sifko"].Width = 60;
            ////dgv1.Columns["povrsina"].Width = 60;
            //dgv1.Columns["ko_sifko"].HeaderText = "KO";
            this.dgvs.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvs.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            lstavb.Text = "(" + dgvs.Rows.Count.ToString() + ")";
        }


        private void Nalozi_strehe_stavbe(int vhod)  // strehe, ki spadajo k naloženi stavbi
        {

            q6 = "SELECT hsmid_gl FROM ren_strehe  where id = @idx"; // poišči glavni hsmid
            cmd6 = new SqlCommand(q6, con6);
            cmd6.Parameters.AddWithValue("@idx", vhod);
            con6.Open();
            hsmid_gl = (string)cmd6.ExecuteScalar();
            //MessageBox.Show(hsmid_gl);
            //label3.Text = vsota_streh.ToString("N2");
            con6.Close();

            q2 = "select count(*) from ren_strehe where hsmid_gl=@idx";  // preštej koliko streh spada h glavni
            cmd2 = new SqlCommand(q2, con2);
            cmd2.Parameters.AddWithValue("@idx", hsmid_gl);
            con2.Open();
            label8.Text = Convert.ToString((Int32)cmd2.ExecuteScalar());
            //label16.Text = vseh_zapisov.ToString();
            con2.Close();

            q6 = "SELECT SUM (povrsina) FROM ren_strehe where hsmid_gl=@idx";  // seštej površino streh, ki spadajo k glavni
            cmd6 = new SqlCommand(q6, con6);
            cmd6.Parameters.AddWithValue("@idx", hsmid_gl);
            con6.Open();
            double vsota_streh = (double)cmd6.ExecuteScalar();
            label20.Text = vsota_streh.ToString("N2");
            con6.Close();


            dgvps.RowHeadersVisible = false;
            string q = "select id,ObjectID,hsmid,glavna_streha,povrsina from ren_strehe where hsmid_gl=@idx order by glavna_streha desc";  // preštej koliko streh spada h glavni
            //q = "select id, ObjectID from ren_strehe";  // preštej koliko streh spada h glavni

            var da = new SqlDataAdapter(q, con);
            da.SelectCommand.Parameters.AddWithValue("@idx",hsmid_gl);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dgvps.DataSource = dt;
            dgvps.ReadOnly = true;
            dgvps.Columns[0].Visible = false;
            //dgvps.Columns[5].Visible = false;
            dgvps.Columns[1].Width = 80;
            dgvps.Columns[2].Width = 90;
            dgvps.Columns[3].Width = 60;
            dgvps.Columns[4].Width = 84;
            //dgvps.Columns[4].Width = 30;
            dgvps.Columns[1].HeaderText = "  ObjectID";
            dgvps.Columns[2].HeaderText = "    HS mid";
            dgvps.Columns[3].HeaderText = " Glavna";
            dgvps.Columns[4].HeaderText = "  Površina";

            //dgvps.Columns[3].HeaderText = "St";
            //dgvps.Columns[4].HeaderText = "Po";

            //dgvs.Columns[1].Visible = false;
            //dgv1.Columns["povrsina"].Visible = false;
            //dgv1.Columns["ko_sifko"].Width = 60;
            ////dgv1.Columns["povrsina"].Width = 60;
            //dgv1.Columns["ko_sifko"].HeaderText = "KO";
            this.dgvps.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvps.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvps.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvps.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvps.Columns[4].DefaultCellStyle.Format = "0.00";
            //lstavb.Text = "(" + dgvs.Rows.Count.ToString() + ")";


            //int stevec = 0;
            //double povrsina_prisp_streh = 0;
            //string q = "select * from ren_strehe where hsmid_gl = @idx"; //+ sort;
            //try
            //{
            //    cmd6 = new SqlCommand(q, con6);
            //    cmd6.Parameters.AddWithValue("@idx", hsmid_gl);
            //    con6.Open();
            //    rdr6 = cmd6.ExecuteReader();
            //    while (rdr6.Read())
            //    {
            //        hsmid_gl= (string)rdr6["hsmid_gl"];
            //        //stevec++;
            //        //double delna_povrsina= (double)rdr6["povrsina"];
            //        //povrsina_prisp_streh = povrsina_prisp_streh + delna_povrsina;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Napaka rdr: " + ex.Message);
            //}
            //finally
            //{
            //    rdr6.Close();
            //    con6.Close();
            //}
            //label13.Text = sta_sid;
            //label20.Text = povrsina_prisp_streh.ToString("N2");
            //label8.Text = Convert.ToString(stevec);
        }

        private void Nalozi_stavbo(string vhod)
        {
            string q = "select * from tbl_ren_stavbe where sta_sid = @idx"; //+ sort;
            try
            {
                cmd6 = new SqlCommand(q, con6);
                cmd6.Parameters.AddWithValue("@idx", vhod);
                con6.Open();
                rdr6 = cmd6.ExecuteReader();
                while (rdr6.Read())
                {
                    sta_sid = (string)rdr6["sta_sid"];
                    st_stanovanj = Convert.ToString((int)rdr6["st_stanovanj"]);
                    st_poslovnih_prostorov = Convert.ToString((int)rdr6["st_poslovnih_prostorov"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka rdr: " + ex.Message);
            }
            finally
            {
                rdr6.Close();
                con6.Close();
            }

            label13.Text = sta_sid;
            label21.Text = st_stanovanj;
            label18.Text = st_poslovnih_prostorov;
        }
        private void Nalozi_del_stavbe(string id_dela, string nam_raba)
        {
            string st_stanovanja = "";
            string st_etaze = "";
            string st_nadstropja = "";
            double upor_povrsina = 0;
            double tloris = 0;
            double visina = 0;
            string okna = "";
            string inštalacije = "";
            string dst_sid = "";

            string q = "select * from tbl_ren_deli_stavb where id = @idx"; //+ sort;
            try
            {
                //MessageBox.Show(vhod.ToString());
                cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@idx", id_dela);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    st_stanovanja = (string)rdr["stevstan"];
                    st_etaze = (string)rdr["st_etaze"];
                    st_nadstropja = (string)rdr["st_nadstropja"];
                    upor_povrsina = (double)rdr["upor_pov_stan"];
                    tloris = (double)rdr["neto_tloris_pov_dst"];
                    visina = (double)rdr["svetla_visina_etaze"];
                    okna = (string)rdr["leto_obn_oken"];
                    inštalacije = (string)rdr["leto_obn_inst"];
                    dst_sid = (string)rdr["dst_sid"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka rdr: " + ex.Message);
            }
            finally
            {
                rdr.Close();
                con.Close();
            }

            // najdi naslov
            //label65.Text = nam_raba;
            //label55.Text = st_stanovanja;
            //label61.Text = st_etaze;
            //label62.Text = st_nadstropja;
            //label68.Text = okna;
            //label57.Text = tloris.ToString("N2") + " m2";
            //label58.Text = upor_povrsina.ToString("N2") + " m2";
            //label66.Text = inštalacije;
            //string nen_id_s = st_nen_id(dst_sid);
            //Poisci_lastnike_delov(nen_id_s);
        }


        private void cb_vec_CheckedChanged(object sender, EventArgs e)
        {
            Vpisi_dgv_stavbe();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void dgvs_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            idx_sta = dgvs.Rows[e.RowIndex].Cells[1].Value.ToString();
            int idx_strehe = Convert.ToInt32(dgvs.Rows[e.RowIndex].Cells[0].Value.ToString());
            Nalozi_stavbo(idx_sta);
            Nalozi_strehe_stavbe(idx_strehe);
        }

        public frmStrehe()
        {
            InitializeComponent();
        }

        private void frmStrehe_Load(object sender, EventArgs e)
        {
            this.Text = frmMain.nazivPrograma;
            Strehe();
            Vpisi_dgv_stavbe();

        }

        private void Vpisi_dgv_stavbe()
        {
            dgvs.RowHeadersVisible = false;
            if (cb_vec.Checked)
                    q = "SELECT ren_Strehe.Id, ren_Strehe.SID AS sid, ren_Strehe.OM_naslov AS nasl, tbl_ren_stavbe.st_stanovanj AS stan, tbl_ren_stavbe.st_poslovnih_prostorov AS posl, tbl_ren_stavbe.sta_sid,ren_Strehe.ObjectId FROM ren_Strehe " +
                        "LEFT JOIN tbl_ren_stavbe ON ren_Strehe.SID = tbl_ren_stavbe.sta_sid WHERE(tbl_ren_stavbe.st_stanovanj + tbl_ren_stavbe.st_poslovnih_prostorov > 1) AND (ren_Strehe.Glavna_streha = N'1') order by nasl";
            else
                q = "SELECT ren_Strehe.Id, ren_Strehe.SID AS sid, ren_Strehe.OM_naslov AS nasl, tbl_ren_stavbe.st_stanovanj AS stan, tbl_ren_stavbe.st_poslovnih_prostorov AS posl, tbl_ren_stavbe.sta_sid FROM ren_Strehe " +
                    "LEFT JOIN tbl_ren_stavbe ON ren_Strehe.SID = tbl_ren_stavbe.sta_sid WHERE (ren_Strehe.Glavna_streha = N'1') order by nasl";

            var da = new SqlDataAdapter(q, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dgvs.DataSource = dt;
            dgvs.ReadOnly = true;
            dgvs.Columns[0].Visible = false;
            dgvs.Columns[5].Visible = false;
            dgvs.Columns[1].Width = 80;
            dgvs.Columns[2].Width = 185;
            dgvs.Columns[3].Width = 30;
            dgvs.Columns[4].Width = 30;
            dgvs.Columns[1].HeaderText = "ID";
            dgvs.Columns[2].HeaderText = "Naslov";
            dgvs.Columns[3].HeaderText = "St";
            dgvs.Columns[4].HeaderText = "Po";

            //dgvs.Columns[1].Visible = false;
            //dgv1.Columns["povrsina"].Visible = false;
            //dgv1.Columns["ko_sifko"].Width = 60;
            ////dgv1.Columns["povrsina"].Width = 60;
            //dgv1.Columns["ko_sifko"].HeaderText = "KO";
            this.dgvs.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvs.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            lstavb.Text = "("+dgvs.Rows.Count.ToString()+")";
        }

    }
}
