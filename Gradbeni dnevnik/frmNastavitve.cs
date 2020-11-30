using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Komunala
{
    public partial class frmNastavitve : Form
    {
        SqlConnection con = frmMain.c;
        SqlConnection con2 = frmMain.c2;
        SqlConnection con3 = frmMain.c3;
        SqlCommand cmd;
        SqlDataReader rdr = null;

        string q;

        public frmNastavitve()
        {
            InitializeComponent();
        }

        private void frmNastavitve_Load(object sender, EventArgs e)
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
           // MessageBox.Show(appPath);

            tb1.Text = frmMain.imenik;
            tb2.Text = frmMain.direktor;
            tb3.Text = frmMain.datum_o_1;
            tb4.Text = frmMain.datum_o_2;
            tb5.Text = frmMain.tekst_o_1;
            tb6.Text = frmMain.tekst_o_2;
            tb7.Text = frmMain.datum_t_1;
            tb8.Text = frmMain.datum_t_2;
            tb9.Text = frmMain.tekst_t_1;
            tb10.Text = frmMain.tekst_t_2;

            tb1.Focus();
        }

        private void btnZapri_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnShrani_Click(object sender, EventArgs e)
        {

            try
            {
                    q = "insert into tblNastavitve(imenik,direktor,datum_o_1,datum_o_2,tekst_o_1,tekst_o_2,datum_t_1,datum_t_2,tekst_t_1,tekst_t_2)" +
                    " values(@timenik,@tdirektor,@tdatum_o_1,@tdatum_o_2,@ttekst_o_1,@ttekst_o_2,@tdatum_t_1,@tdatum_t_2,@ttekst_t_1,@ttekst_t_2)";
                    cmd = new SqlCommand(q, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@timenik", tb1.Text);
                    cmd.Parameters.AddWithValue("@tdirektor", tb2.Text);
                    cmd.Parameters.AddWithValue("@tdatum_o_1", tb3.Text);
                cmd.Parameters.AddWithValue("@tdatum_o_2", tb4.Text);
                cmd.Parameters.AddWithValue("@ttekst_o_1", tb5.Text);
                cmd.Parameters.AddWithValue("@ttekst_o_2", tb6.Text);
                cmd.Parameters.AddWithValue("@tdatum_t_1", tb7.Text);
                cmd.Parameters.AddWithValue("@tdatum_t_2", tb8.Text);
                cmd.Parameters.AddWithValue("@ttekst_t_1", tb9.Text);
                cmd.Parameters.AddWithValue("@ttekst_t_2", tb10.Text);
                    cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka shrani nastavitve: " + ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                    this.DialogResult = DialogResult.Cancel;

                }
            }

        }
    }
}
