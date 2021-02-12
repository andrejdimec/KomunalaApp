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
                cmd2 = new SqlCommand(q, con2);
                con2.Open();
                cmd2.Parameters.AddWithValue("@idx", vhod);
                rdr2 = cmd2.ExecuteReader();
                while (rdr2.Read())
                {
                    izbr_ko_id = (string)rdr2["ko_id"];
                    izbr_ko = (string)rdr2["ko_ime"];
                }  // while read
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka reader: " + ex.Message);
            }
            finally
            {
                rdr2.Close();
                con2.Close();
            }
        }

        private void Vpisi_dgv()
        {
            dgv5.RowHeadersVisible = false;
            string q = "select id,sif_ko,parcela,povrsina from tbl_vk6_zk_parcele where sif_ko=@idx order by parcela asc, povrsina desc"; 
            var da = new SqlDataAdapter(q, con3);
            da.SelectCommand.Parameters.Add("@idx", izbr_ko_id);
            dt = new DataTable();
            da.Fill(dt);
            dgv5.DataSource = dt;
            dgv5.ReadOnly = true;
            dgv5.Columns["id"].Visible = false;
            dgv5.Columns["sif_ko"].Visible = false;
            dgv5.Columns["parcela"].Width = 200;
            dgv5.Columns["povrsina"].Width = 80;
            //this.dgv5.Columns["labela"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
            frmMain.id_parcele = -99;
            frmMain.id_ko = -99;
            Pocisti();
        }

        private void frmIsci_parc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }

        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "parcela LIKE '" + tb2.Text + "%'";
            dgv5.DataSource = dv;
        }

        private void tb2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                dgv5.Focus();
        }

        private void dgv5_DoubleClick(object sender, EventArgs e)
        {
            frmMain.id_parcele = Convert.ToInt32(dgv5.SelectedCells[0].Value.ToString());
            frmMain.id_ko = Convert.ToInt32(dgv5.SelectedCells[1].Value.ToString());
            frmMain.ime_ko = izbr_ko;
            this.DialogResult = DialogResult.Cancel;
        }

        private void dgv5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmMain.id_parcele = Convert.ToInt32(dgv5.SelectedCells[0].Value.ToString());
                frmMain.id_ko = Convert.ToInt32(dgv5.SelectedCells[1].Value.ToString());
                frmMain.ime_ko = izbr_ko;
                //e.SuppressKeyPress = true;
                this.DialogResult = DialogResult.Cancel;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tb1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Tab)
            {
                string ko_temp;
                ko_temp = tb1.Text;
                Preveri_KO(ko_temp);
                if (izbr_ko_id == "-99")
                {
                    l1.Text = "KO s to številko ne obstaja!";
                    //tb1.Text = "";
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
    }
}
