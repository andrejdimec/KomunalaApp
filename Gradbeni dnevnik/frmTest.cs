using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komunala
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'komunala_ds.tbl_DDV' table. You can move, or remove it, as needed.
            this.tbl_DDVTableAdapter.Fill(this.komunala_ds.tbl_DDV);
            // TODO: This line of code loads data into the 'komunala_ds.tbl_Enote' table. You can move, or remove it, as needed.
            this.tbl_EnoteTableAdapter.Fill(this.komunala_ds.tbl_Enote);
            // TODO: This line of code loads data into the 'komunala_ds.tbl_Delovnamesta' table. You can move, or remove it, as needed.
            this.tbl_DelovnamestaTableAdapter.Fill(this.komunala_ds.tbl_Delovnamesta);
            // TODO: This line of code loads data into the 'komunala_ds.tbl_Delovnamesta' table. You can move, or remove it, as needed.
            Grid();
        }

        private void Grid()
        {
            dgv1.RowHeadersVisible = false;
            dgv1.Columns[1].Width = 250;
            dgv1.Columns[2].Width = 200;
            dgv1.Columns[3].Width = 100;
            dgv1.Columns[4].Width = 100;
            dgv1.Columns[5].Width = 100;
            this.dgv1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv1.Focus();
        }

        private void tbl_DelovnamestaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_DelovnamestaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.komunala_ds);

        }

        private void tbl_DelovnamestaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbl_DelovnamestaBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
