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
    public partial class frmUredi_strehe : Form
    {

        SqlConnection con = frmMain.c;
        SqlConnection con2 = frmMain.c2;
        SqlConnection con3 = frmMain.c3;
        SqlConnection con9 = frmMain.c9;
        SqlConnection con6 = frmMain.c6;
        SqlConnection con7 = frmMain.c6;

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
        SqlCommand cmd7;

        static DataTable dt, dt2, dt3, dt4, dt7;
        string q, q2, q3, q6, q9;

        private void button1_Click(object sender, EventArgs e)
        {
            frmStrehe sec = new frmStrehe();
            sec.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBaze_ZK sec = new frmBaze_ZK();
            sec.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public frmUredi_strehe()
        {
            InitializeComponent();
        }

        private void frmUredi_strehe_Load(object sender, EventArgs e)
        {
            this.Text = frmMain.nazivPrograma;
            //ls.Text = "";
            //ll.Text = "";
            Strehe();
            Vpisi_dgv_stavbe();
            Vpisi_dgv_stavbe_odob();
            Odobrene();


        }
        private void Odobrene() // informacije o celi bazi streh
        {
            // neodobrene
            q2 = "select count(*) from strehe_za_obracun where odobreno=0";
            cmd2 = new SqlCommand(q2, con2);
            con2.Open();
            int st_neodobrenih = (Int32)cmd2.ExecuteScalar();
            con2.Close();

            string q6 = "SELECT SUM (streha_delez) FROM strehe_za_obracun where odobreno=0";
            cmd6 = new SqlCommand(q6, con6);
            con6.Open();
            double pov_neodobrenih = (double)cmd6.ExecuteScalar();
            lstavb.Text= "Delov: "+st_neodobrenih.ToString()+"    Površina: "+pov_neodobrenih.ToString("N2")+" m2";
            con6.Close();
            
            // odobrene
            q2 = "select count(*) from strehe_za_obracun where odobreno=1";
            cmd2 = new SqlCommand(q2, con2);
            con2.Open();
            int st_odobrenih = (Int32)cmd2.ExecuteScalar();
            con2.Close();

            //q6 = "SELECT SUM (streha_delez) FROM strehe_za_obracun where odobreno=1";
            //cmd6 = new SqlCommand(q6, con6);
            //con6.Open();
            //double pov_odobrenih = (double)cmd6.ExecuteScalar();
            //lstavbo.Text = st_odobrenih.ToString() + ", " + pov_odobrenih.ToString("N2") + " m2";
            //con6.Close();
        }
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
            double povrsina_vseh_streh = (double)cmd6.ExecuteScalar();
            label3.Text = povrsina_vseh_streh.ToString("N2");
            con6.Close();
        }

        private void Vpisi_dgv_stavbe()
        {
            dgvs.RowHeadersVisible = false;
            q = @"select raba_id, naslov_dst,labela_dst,n_tloris,odobreno from strehe_za_obracun  where (odobreno=N'0') order by naslov_dst,labela_dst";
            var da = new SqlDataAdapter(q, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dgvs.DataSource = dt;
            dgvs.ReadOnly = true;
            dgvs.Columns[0].Width = 60;
            dgvs.Columns[1].Width = 153;
            dgvs.Columns[2].Width = 40;
            dgvs.Columns[3].Width = 60;
            dgvs.Columns[0].HeaderText = "Raba";
            dgvs.Columns[1].HeaderText = "Naslov";
            dgvs.Columns[2].HeaderText = "Št";
            dgvs.Columns[3].HeaderText = "Tloris";
            dgvs.Columns[4].Visible = false;
            this.dgvs.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvs.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvs.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvs.Columns[3].DefaultCellStyle.Format = "0.0";
            lstavb.Text = "(" + dgvs.Rows.Count.ToString() + ")";
        }

        private void Vpisi_dgv_stavbe_odob()
        {
            dgvso.RowHeadersVisible = false;
            q = @"select raba_id, naslov_dst,labela_dst,n_tloris,odobreno from strehe_za_obracun  where (odobreno=N'1') order by naslov_dst,labela_dst";
            var da = new SqlDataAdapter(q, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dgvso.DataSource = dt;
            dgvso.ReadOnly = true;
            dgvso.Columns[0].Width = 60;
            dgvso.Columns[1].Width = 153;
            dgvso.Columns[2].Width = 40;
            dgvso.Columns[3].Width = 60;
            dgvso.Columns[0].HeaderText = "Raba";
            dgvso.Columns[1].HeaderText = "Naslov";
            dgvso.Columns[2].HeaderText = "Št";
            dgvso.Columns[3].HeaderText = "Tloris";
            dgvso.Columns[4].Visible = false;
            this.dgvso.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvso.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvso.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvso.Columns[3].DefaultCellStyle.Format = "0.0";
            lstavbo.Text = "(" + dgvso.Rows.Count.ToString() + ")";
        }


    }

}
