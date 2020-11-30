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
    public partial class frmIzpis : Form
    {
        SqlConnection con = frmMain.c;
        SqlConnection con2 = frmMain.c2;
        SqlConnection con3 = frmMain.c3;

        SqlCommand cmd;
        SqlDataReader rdr = null;
        // SqlDataAdapter adapt, adapt2;
        ReportDocument cryrpt = new ReportDocument();

        string q,q2;
        int idx_dnevnik;

        public frmIzpis()
        {
            InitializeComponent();
        }

        private void frmIzpis_Load(object sender, EventArgs e)
        {
            idx_dnevnik = 188;

            try
            {
                //   MessageBox.Show("index za izpis " + Convert.ToString(idx_dnevnik));
                q = "select * from tbl_dnevnik where id=@idx_dnevnik";
                SqlDataAdapter da = new SqlDataAdapter(q, con);
                DataSet dataReport = new DataSet();
                da.Fill(dataReport, "tbl_dnevnik");
                cmd.Parameters.AddWithValue("@idx_dnevnik", idx_dnevnik);

                //cmd = new SqlCommand(q, con);
                //con.Open();
                //cmd.ExecuteNonQuery();
                //adapt = new SqlDataAdapter(cmd);
                //DataSet dst = new DataSet();
                //adapt.Fill(dst, "tbl_dnevnik");

                
                
                // novo za drugo tabelo
                ////                string q2 = "select * from tbl_storitve_dnevnik where id_dnevnik=@idx_dnevnik";
                //q2 = "select * from tbl_storitve_dnevnik";
                //cmd = new SqlCommand(q2, con);
                ////con.Open();
                ////cmd.Parameters.AddWithValue("@idx_dnevnik", idx_dnevnik);
                ////cmd.ExecuteNonQuery();
                //adapt2 = new SqlDataAdapter(q2, con);
                //// DataSet dst = new DataSet();
                //adapt2.Fill(dst, "tbl_storitve_dnevnik");



                cr2 crpt = new cr2();
                
                crpt.SetDataSource(dataReport);
                crv2.ReportSource = crpt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka pri odpiranju dnevnika: " + ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                    crv2.Refresh();
                }

            }
        }
    }
}
