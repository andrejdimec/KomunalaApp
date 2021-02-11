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
    public partial class frmIsci_parc : Form
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

        static DataTable dt;

        string izbr_ko_id, izbr_ko;

        public frmIsci_parc()
        {
            InitializeComponent();
        }


        private void Preveri_KO(string vhod)
        {
            izbr_ko_id = "-99";
            try
            {
                string q = "select * from tbl_ko where ko_id=@idx";
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@idx", vhod);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    izbr_ko_id = (string)rdr["ko_id"];
                    izbr_ko = (string)rdr["ko_ime"];
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
                if (izbr_ko_id == "-99")
                {
                    l1.Text = "KO s številko " + izbr_ko_id + " ne obstaja!";
                    tb1.Text = "";
                    tb1.Focus();
                }
                else
                {
                    l1.Text = "KO " + izbr_ko_id + " - " + izbr_ko;
                    Omogoci();
                    tb2.Focus();
                }
            }

        }

        private void Vpisi_dgv()
        {
            tb1.Text = "";
            dgv5.ColumnHeadersVisible = false;
            dgv5.RowHeadersVisible = false;

            string q = "select sif_ko,parcela from tbl_vk6_zk_parcele order by parcela"; 

            var da = new SqlDataAdapter(q, con);

            dt = new DataTable();
            da.Fill(dt);
            dgv5.DataSource = dt;

            dgv5.ReadOnly = true;
            //dgv5.Columns[0].Visible = false;
            //dgv5.Columns[1].Visible = false;
            //dgv5.Columns["priimek1"].Width = 170;
            //dgv5.Columns["priimek2"].Width = 100;
            //dgv5.Columns["priimek2"].Visible = false;
            //dgv5.Columns["ime1"].Width = 100;
            //dgv5.Columns["ime2"].Width = 100;
            //dgv5.Columns["ime2"].Visible = false;
            dgv5.Columns["hsmid"].Visible = false;
            dgv5.Columns["hs"].Visible = false;
            dgv5.Columns["hd"].Visible = false;
            dgv5.Columns["naslov"].Width = 150;
            dgv5.Columns["labela"].Width = 60;

            this.dgv5.Columns["labela"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            tb1.Focus();
        }

        private void Pocisti()
        {
            l1.Text = "";
            tb2.Enabled = false;
            dgv5.Enabled = false;
        }
        private void Omogoci()
        {
            tb2.Enabled = true;
            dgv5.Enabled = true;
            Vpisi_dgv();
        }

        private void frmIsci_parc_Load(object sender, EventArgs e)
        {
            Pocisti();
        }

        private void tb1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string ko_temp;
                ko_temp = tb1.Text;
                if (ko_temp.Length < 4)
                    ko_temp = "0" + ko_temp;
                Preveri_KO(ko_temp);
            }

        }
    }
}
