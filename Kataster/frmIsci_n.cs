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
    public partial class frmIsci_n : Form
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

        public frmIsci_n()
        {
            InitializeComponent();
        }

        private void Vpisi_dgv()
        {
            tb1.Text = "";
            dgv5.ColumnHeadersVisible = false;
            dgv5.RowHeadersVisible = false;

            string q = "select hsmid,naslov,labela,hs,hd from tbl_hise order by naslov,hs,hd"; // preberi vse zapise iz tbl_hise



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

        private void frmIsci_n_Load(object sender, EventArgs e)
        {
            Vpisi_dgv();
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "naslov LIKE '" + tb1.Text + "%'";
            dgv5.DataSource = dv;

        }

        private void tb1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                dgv5.Focus();
        }

        private void dgv5_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMain_kat.izbrani_hsmid = dgv5.Rows[e.RowIndex].Cells[0].Value.ToString();
            frmStavba form2 = new frmStavba();
            form2.ShowDialog();
            Vpisi_dgv();

        }

        private void dgv5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmMain_kat.izbrani_hsmid = dgv5.SelectedCells[0].Value.ToString();
                e.SuppressKeyPress = true;
                int row = dgv5.CurrentRow.Index;
                int col = dgv5.CurrentCell.ColumnIndex;
                frmStavba form2 = new frmStavba();
                form2.ShowDialog();
                Vpisi_dgv();
            }

        }

        private void frmIsci_n_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
