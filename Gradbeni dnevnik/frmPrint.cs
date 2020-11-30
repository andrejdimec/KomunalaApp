using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Data.SqlClient;



namespace Komunala
{
    public partial class frmCrystalReport : Form
    {

        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\KomunalaApp\\Komunala\\data\\komunala_db.mdf; Integrated Security = True; Connect Timeout = 30");
        SqlCommand cmd;
        SqlDataReader rdr = null;

        SqlConnection con2 = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\KomunalaApp\\Komunala\\data\\komunala_db.mdf; Integrated Security = True; Connect Timeout = 30");
        SqlCommand cmd2;
        SqlDataReader rdr2 = null;

        int tceniko, tcenikt, tskupina, tem, id_enota, id_storitev, id_skupina, id_ddv;
        string stskupina, tstoritev, stem, stceniko, stcenikt, stddv;
        int prvic; // za sort
        string topis = "";

        private void btnNazaj_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        string index;
        string tvozilo;
        int tid = 0;
        int dodaj = 0;
        double tddv;
        string sort; // po čem naj sortira pri display
        string q, q2; // query string
        bool shrani_ok;

        public frmCrystalReport()
        {
            InitializeComponent();
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {

            Display();
            //cr1 rpt = new cr1();
            //crv.ReportSource = rpt;
        }


        private void Izprazni_dgv()
        {
            dgv1.Rows.Clear();
            dgv1.Refresh();
        }

        private void Display()
        {
            bool boolt, boolo;
            dgv1.ColumnHeadersVisible = true;
            Izprazni_dgv();
            sort = "storitev asc";
            if (prvic == 1)
            {
                q = "select * from tblStoritve order by " + sort;
                prvic = 0;
            }
            else
            {
                q = "select * from tblStoritve order by " + sort;
            }
            try
            {
                cmd = new SqlCommand(q, con);
                con.Open();
                //cmd.Parameters.AddWithValue("@sort", sort);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tid = (int)rdr["Id"];
                    string tstoritev = (string)rdr["storitev"]; // Opis
                    int tenota = (int)rdr["em"];
                    int tskupina = (int)rdr["skupina"];
                    int tceniko = (int)rdr["ceniko"];
                    int tcenikt = (int)rdr["cenikt"];
                    int tempddv = (int)rdr["ddv"];
                    string strid = Convert.ToString(tid);

                    // poišči enoto mere
                    q2 = "select em from tbl_enote where id = @tid";  // če sta indexa iz ulic enaka
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@tid", tenota);
                    cmd2.ExecuteNonQuery();
                    string stem = (string)cmd2.ExecuteScalar();
                    con2.Close();

                    // poišči skupino
                    q2 = "select skupina from tblskupinestoritev where id = @tid";  // če sta indexa iz ulic enaka
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@tid", tskupina);
                    cmd2.ExecuteNonQuery();
                    string stskupina = (string)cmd2.ExecuteScalar();
                    con2.Close();

                    // poišči ddv
                    q2 = "select stopnja from tbl_ddv where id = @tempddv";  // če sta indexa iz ulic enaka
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@tempddv", tempddv);
                    cmd2.ExecuteNonQuery();
                    double temp_ddv_double = Convert.ToDouble(cmd2.ExecuteScalar());
                    //                    float temp_ddv_float = (float)cmd2.ExecuteScalar();  // napaka
                    con2.Close();

                    if (tceniko == 1)
                    {
                        boolo = true;
                    }
                    else
                    {
                        boolo = false;
                    }

                    if (tcenikt == 1)
                    {
                        boolt = true;
                    }
                    else
                    {
                        boolt = false;
                    }
                    DataGridViewTextBoxCell Id = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell Storitev = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell Em = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell ddv = new DataGridViewTextBoxCell();
                    DataGridViewCheckBoxCell obcina = new DataGridViewCheckBoxCell();
                    DataGridViewCheckBoxCell trg = new DataGridViewCheckBoxCell();
                    DataGridViewTextBoxCell skupina = new DataGridViewTextBoxCell();

                    Id.Value = tid;
                    Storitev.Value = tstoritev;
                    Em.Value = stem;
                    obcina.Value = boolo;
                    trg.Value = boolt;
                    skupina.Value = stskupina;
                    ddv.Value = temp_ddv_double;

                    DataGridViewColumn kolid = dgv1.Columns[0];
                    kolid.Width = 1;
                    DataGridViewColumn kolstoritev = dgv1.Columns[1];
                    kolstoritev.Width = 407;
                    DataGridViewColumn kolem = dgv1.Columns[2];
                    kolem.Width = 50;
                    DataGridViewColumn kolddv = dgv1.Columns[3];
                    kolddv.Width = 50;
                    DataGridViewColumn kolobcina = dgv1.Columns[4];
                    kolobcina.Width = 70;
                    DataGridViewColumn koltrg = dgv1.Columns[5];
                    koltrg.Width = 70;
                    DataGridViewColumn kolskupina = dgv1.Columns[6];
                    kolskupina.Width = 195;

                    kolstoritev.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    kolem.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolobcina.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    koltrg.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolddv.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolskupina.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    DataGridViewRow row = new DataGridViewRow();

                    row.Cells.Add(Id);
                    row.Cells.Add(Storitev);
                    row.Cells.Add(Em);
                    row.Cells.Add(ddv);
                    row.Cells.Add(obcina);
                    row.Cells.Add(trg);
                    row.Cells.Add(skupina);

                    dgv1.Rows.Add(row);  // dodaj vrstico
                }
            }
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
        }

    }
}
