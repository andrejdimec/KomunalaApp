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
    public partial class frmIsci_o : Form
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
        
        public frmIsci_o()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmIsci_o_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }

        private void Vpisi_dgv()
        {
            tb1.Text = "";
            dgv5.ColumnHeadersVisible = false;
            dgv5.RowHeadersVisible = false;

            string q = "select tbl_crp.indeks_osebe, tbl_crp.hsmid, tbl_crp.priimek1, tbl_crp.priimek2, tbl_crp.ime1, tbl_crp.ime2, tbl_hise.naslov,tbl_hise.labela" +
                " from tbl_crp inner join tbl_hise on tbl_crp.hsmid = tbl_hise.hsmid order by tbl_crp.priimek1,tbl_hise.naslov,tbl_hise.labela"; // preberi vse zapise iz tbl_hise



            var da = new SqlDataAdapter(q, con);

            dt = new DataTable();
            da.Fill(dt);
            dgv5.DataSource = dt;

            dgv5.ReadOnly = true;
            dgv5.Columns[0].Visible = false;
            dgv5.Columns[1].Visible = false;
            dgv5.Columns["priimek1"].Width = 170;
            dgv5.Columns["priimek2"].Width = 100;
            dgv5.Columns["priimek2"].Visible = false;
            dgv5.Columns["ime1"].Width = 100;
            dgv5.Columns["ime2"].Width = 100;
            dgv5.Columns["ime2"].Visible = false;
            dgv5.Columns["naslov"].Width = 170;
            dgv5.Columns["labela"].Width = 70;
            this.dgv5.Columns["labela"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            tb1.Focus();
        }
        private void frmIsci_o_Load(object sender, EventArgs e)
        {
            Vpisi_dgv();
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "priimek1 LIKE '" + tb1.Text + "%'";
            dgv5.DataSource = dv;

           // bs.Filter = "[ColumnName1] like '%" + textBox1.Text + "%' " +
           //"OR [ColumnName2] like '%" + textBox1.Text + "%'" +
           //"OR [ColumnName3] like '%" + textBox1.Text + "%'" +
           //"OR [ColumnName4] like '%" + textBox1.Text + "%'";
        }

        private void tb1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                dgv5.Focus();
        }

        private void dgv5_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMain_kat.izbrana_oseba = dgv5.Rows[e.RowIndex].Cells[0].Value.ToString();
            frmOseba form2 = new frmOseba();
            form2.ShowDialog();
            Vpisi_dgv();
        }

        private void dgv5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                frmMain_kat.izbrana_oseba = dgv5.SelectedCells[0].Value.ToString();
                e.SuppressKeyPress = true;
                int row = dgv5.CurrentRow.Index;
                int col = dgv5.CurrentCell.ColumnIndex;
                frmOseba form2 = new frmOseba();
                form2.ShowDialog();
                Vpisi_dgv();
            }
        }
    }
}
