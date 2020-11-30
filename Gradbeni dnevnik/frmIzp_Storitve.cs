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
using CrystalDecisions.CrystalReports.Engine;


namespace Komunala
{
    public partial class frmIzp_Storitve : Form
    {
        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\KomunalaApp\\Komunala\\data\\komunala_db.mdf; Integrated Security = True; Connect Timeout = 30");
        SqlCommand cmd;
        SqlDataReader rdr = null;
        SqlDataAdapter adapt = new SqlDataAdapter();

        string q;


        public frmIzp_Storitve()
        {
            InitializeComponent();
        }

        private void frmIzp_Storitve_Load(object sender, EventArgs e)
        {

            //q = "select * from tblStoritve";
            q = "SELECT tblstoritve.storitev,tblstoritve.em,tbl_enote.id,tbl_enote.em FROM tblStoritve inner JOIN tbl_enote ON tbl_enote.id = tblstoritve.em";
            try
            {
                cmd = new SqlCommand(q, con);
                con.Open();

                //con.Open();

                adapt = new SqlDataAdapter(q, con);
                DataSet emp = new DataSet();
                adapt.Fill(emp, "tblStoritve");
                //  DataTable table = new DataTable();
                //  adapt.Fill(table);
                CrystalReport1 cr1 = new CrystalReport1();
                cr1.SetDataSource(emp);
                //cr1.SetDataSource(table);
                crv1.ReportSource = cr1;
                crv1.Refresh();

            } // try
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

        } // public void

        private void crv1_Load(object sender, EventArgs e)
        {

        }
    }
}
