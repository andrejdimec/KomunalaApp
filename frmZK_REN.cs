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
    public partial class frmZK_REN : Form
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

        string izbr_ko_id, izbr_ko;

        public frmZK_REN()
        {
            InitializeComponent();
        }

        private void Preveri_KO (string vhod)
        {
            //izbr_ko_id = "-99";
            //try
            //{
            //    string q = "select * from tbl_ko where ko_id=@idx";
            //    cmd = new SqlCommand(q, con);
            //    con.Open();
            //    cmd.Parameters.AddWithValue("@idx", vhod);
            //    rdr = cmd.ExecuteReader();
            //    while (rdr.Read())
            //    {
            //        izbr_ko_id = (string)rdr["ko_id"];
            //        izbr_ko = (string)rdr["ko_ime"];
            //    }  // while read
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Napaka reader: " + ex.Message);
            //}
            //finally
            //{
            //    rdr.Close();
            //    con.Close();
            //    if (izbr_ko_id == "-99")
            //    {
            //        l1.Text = "KO s številko "+izbr_ko_id+" ne obstaja!";
            //        tb1.Text = "";
            //        tb1.Focus();
            //    }
            //    else
            //    {
            //        l1.Text = "KO " + izbr_ko_id + " - " + izbr_ko;
            //        tb2.Focus();
            //    }
            //}

        }


        private void Pocisti()
        {
            l1.Text = ""; l2.Text = "";
        }

        private void frmZK_REN_Load(object sender, EventArgs e)
        {
            Pocisti();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmIsci_parc sec = new frmIsci_parc ();
            sec.ShowDialog();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //string ko_temp;
                //ko_temp = tb1.Text;
                //if (ko_temp.Length < 4)
                //    ko_temp = "0" + ko_temp;
                //Preveri_KO(ko_temp);
            }
        }
    }
}
