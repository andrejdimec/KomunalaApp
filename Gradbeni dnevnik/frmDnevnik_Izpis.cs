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
    public partial class frmDnevnik_Izpis : Form
    {
        SqlConnection con = frmMain.c;
        SqlConnection con2 = frmMain.c2;
        SqlConnection con3 = frmMain.c3;

        SqlCommand cmd;
        SqlDataReader rdr = null;
        SqlDataAdapter adapt, adapt2;
        ReportDocument cryrpt = new ReportDocument();

        string q, q1;
        int idx_dnevnik;

        private void crv1_Load(object sender, EventArgs e)
        {

        }

        public frmDnevnik_Izpis()
        {
            InitializeComponent();
        }


        private void frmDnevnik_Izpis_Load(object sender, EventArgs e)
        {
            if (frmPrejsnji_dnevniki.iz_prejsnji==true)
            {
                idx_dnevnik = frmPrejsnji_dnevniki.index_nazaj;
            }
            if (Gradbeni_dnevnik.iz_gradbeni==true)
            {
                idx_dnevnik = Gradbeni_dnevnik.indeks_za_izpis;
               // MessageBox.Show("Iz gradbeni dnevnik, Odpri = true, index:" + Convert.ToString(Gradbeni_dnevnik.indeks_za_izpis));
            }
            
            //idx_dnevnik = 188; // začasno
            
            try
            {
                q = "select * from tbl_dnevnik where id=@idx_dnevnik";
                cmd = new SqlCommand(q, con);

                SqlDataAdapter da = new SqlDataAdapter(q, con);
                da.SelectCommand.Parameters.Add("@idx_dnevnik", idx_dnevnik);

                DataSet dataReport = new DataSet();
                da.Fill(dataReport, "tbl_dnevnik");


                q1 = "select * from tbl_storitve_dnevnik where id_dnevnik=@id_dnevnik";
                cmd = new SqlCommand(q1, con);
                SqlDataAdapter da1 = new SqlDataAdapter(q1, con);
                da1.SelectCommand.Parameters.Add("@id_dnevnik", idx_dnevnik);
                da1.Fill(dataReport, "tbl_storitve_dnevnik");

                cr1 crpt = new cr1();
                crpt.SetDataSource(dataReport);
                crv1.ReportSource = crpt;

                // crpt.PrintToPrinter(1, false, 0, 0); // direktno na printer

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
                    crv1.Refresh();
                }
            }
        }
    }
}
