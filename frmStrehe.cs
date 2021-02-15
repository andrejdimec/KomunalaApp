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
        string q;

        private void cb_vec_CheckedChanged(object sender, EventArgs e)
        {
            Vpisi_dgv_stavbe();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public frmStrehe()
        {
            InitializeComponent();
        }

        private void frmStrehe_Load(object sender, EventArgs e)
        {
            this.Text = frmMain.nazivPrograma;
            Vpisi_dgv_stavbe();

        }

        private void Vpisi_dgv_stavbe()
        {
            dgvs.RowHeadersVisible = false;
            if (cb_vec.Checked)
                    q = "SELECT ren_Strehe.Id, ren_Strehe.SID AS sid, ren_Strehe.OM_naslov AS nasl, tbl_ren_stavbe.st_stanovanj AS stan, tbl_ren_stavbe.st_poslovnih_prostorov AS posl, tbl_ren_stavbe.sta_sid FROM ren_Strehe " +
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
            //dgvs.Columns[1].Visible = false;

            //dgv1.Columns["povrsina"].Visible = false;
            dgvs.Columns[2].Width = 150;
           // dgvs.Columns[3].Visible = false;
            dgvs.Columns[4].Width = 68;
            //dgv1.Columns["ko_sifko"].Width = 60;
            ////dgv1.Columns["povrsina"].Width = 60;
            //dgv1.Columns["ko_sifko"].HeaderText = "KO";
            dgvs.Columns[1].HeaderText = "ID";
            dgvs.Columns[2].HeaderText = "Naslov";
            this.dgvs.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            lstavb.Text = "("+dgvs.Rows.Count.ToString()+")";
        }

    }
}
