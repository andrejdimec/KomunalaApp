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
    public partial class frmPogodbeTel : Form
    {

        int tid;
        string tstevilka;
        DateTime tdatum;
        string ttip;
        string topis, tlink;
        SqlConnection con = frmMain.c;
        SqlConnection con2 = frmMain.c2;
        SqlConnection con3 = frmMain.c3;
        SqlCommand cmd, cmd2, cmd3;
        SqlDataReader rdr, rdr2, rdr3 = null;

        string q, q2, q3;
        string index;
        int izbrana_skupina, trenutni, prvi_id;
        bool dodajanje, osnovno, spreminjanje, prvic, poslano;
        Dictionary<int, string> TipPogodbeDict = new Dictionary<int, string>();

        public frmPogodbeTel()
        {
            InitializeComponent();
        }

        private void Vrste_dokumentov_v_cb()
        {

            q2 = "select * from tbl_TipPogodbe order by TipPogodbe";
            try
            {
                cmd2 = new SqlCommand(q2, con2);
                con2.Open();
                rdr2 = cmd2.ExecuteReader();
                cbVrsta.Items.Clear();
                while (rdr2.Read())
                {
                    int tIndeks = (int)rdr2["Id"]; 
                    string tTipPogodbe = (string)rdr2["TipPogodbe"];
                    TipPogodbeDict.Add(tIndeks, tTipPogodbe);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka osebe_v_cb: " + ex.Message);
            }
            finally
            {
                if (rdr2 != null)
                {
                    rdr2.Close();
                }
                if (con2 != null)
                {
                    con2.Close();
                }
                cbVrsta.DataSource = TipPogodbeDict.ToArray();
                cbVrsta.DisplayMember = "Value";
                cbVrsta.ValueMember = "Key";
            }
        }

        private void frmPogodbeTel_Load(object sender, EventArgs e)
        {
            Vrste_dokumentov_v_cb();
            //Prestej();
            Design();
            //Grid();
            Displayf(0);
            Gumbi_1();
            izprazni_tb();
            onemogoci_tb();
            //Nalozi(prvi_id);
            dgv1.Focus();
        }
        private void Gumbi_2() // dodajanje, urejanje
        {
            btnShrani.Enabled = true; btnShrani.BackColor = frmMain.barva_gumb2_neakt;
            btnPreklici.Enabled = true; btnPreklici.BackColor = frmMain.barva_gumb2_neakt;
            btnDodaj.Enabled = false; btnDodaj.BackColor = frmMain.barva_gumb2_disabled;
            btnBrisi.Enabled = false; btnBrisi.BackColor = frmMain.barva_gumb2_disabled;
            btnSpremeni.Enabled = false; btnSpremeni.BackColor = frmMain.barva_gumb2_disabled;
            btnNazaj.Enabled = false; btnNazaj.BackColor = frmMain.barva_gumb2_disabled;
        }

        private void Gumbi_1()  // začetek
        {
            btnShrani.Enabled = false; btnShrani.BackColor = frmMain.barva_gumb2_disabled;
            btnPreklici.Enabled = false; btnPreklici.BackColor = frmMain.barva_gumb2_disabled;
            btnDodaj.Enabled = true; btnDodaj.BackColor = frmMain.barva_gumb2_neakt;
            btnBrisi.Enabled = true; btnBrisi.BackColor = frmMain.barva_gumb2_neakt;
            btnSpremeni.Enabled = true; btnSpremeni.BackColor = frmMain.barva_gumb2_neakt;
            btnNazaj.Enabled = true; btnNazaj.BackColor = frmMain.barva_gumb2_neakt;
        }

        private void onemogoci_tb()
        {
            cbVrsta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVrsta.Enabled = false;
            tbStevilka.Enabled = false;
            tbOpis.Enabled = false;
            dtDatum.Enabled = false;
        }
        private void omogoci_tb()
        {
            cbVrsta.DropDownStyle = ComboBoxStyle.DropDown;
            tbStevilka.Enabled = true;
            tbOpis.Enabled = true;
            dtDatum.Enabled = true;
            cbVrsta.Enabled = true;
            dgv1.Enabled = true;
        }

        private void izprazni_tb()
        {
            tbStevilka.Text = "";
            tbOpis.Text = "";
            dtDatum.Text = "";
            this.cbVrsta.SelectedValue = 0;
        }
        private void Izprazni_dgv()
        {
            dgv1.Rows.Clear();
            dgv1.Refresh();
        }
        private void Displayf(int filter)
        {
            string filter_1;
            filter_1 = "";
            prvic = true;
            Izprazni_dgv();
            string q = "SELECT tbl_Pogodbe.Id, tbl_Pogodbe.TipDokumenta, Tbl_TipPogodbe.TipPogodbe AS eTip, tbl_Pogodbe.Zaporedna AS eZap, " +
                "tbl_Pogodbe.Datum AS eDat, tbl_Pogodbe.Opis AS eOpi, tbl_Pogodbe.Fname AS eFna, tbl_Pogodbe.VrstaDatoteke " +
                "FROM tbl_Pogodbe INNER JOIN  Tbl_TipPogodbe ON tbl_Pogodbe.TipDokumenta = Tbl_TipPogodbe.Id";

            try
            {
                cmd = new SqlCommand(q, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tid = (int)rdr["Id"];
                    if (prvic)
                        prvi_id = tid;
                    prvic = false;
                    int intstevilka = (Int32)rdr["eZap"];
                    tstevilka = intstevilka.ToString().PadLeft(4, '0'); // Opis
                    DateTime tDatum = (DateTime)rdr["eDat"];
                    ttip = (string)rdr["eTip"];
                    topis = (string)rdr["eOpi"];
                    
                    DataGridViewTextBoxCell Id = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell Stevilka = new DataGridViewTextBoxCell();
                    
                    DataGridViewTextBoxCell Datum = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell Tip = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell Opis = new DataGridViewTextBoxCell();
                    DataGridViewLinkCell Link = new DataGridViewLinkCell();

                    //DataGridViewCheckBoxCell Imenik = new DataGridViewCheckBoxCell();
                    //Id.Visible = false;
                    Id.Value = tid;
                    Stevilka.Value = tstevilka;
                    Datum.Value = tdatum;
                    Tip.Value = ttip;
                    Opis.Value = topis;
                    Link.Value = tlink;
            

                    // to naredi v grid edit columns
                    //DataGridViewColumn kolid = dgv1.Columns[0];
                    ////kolid.Width = 1;
                    //kolid.Visible = false;
                    //DataGridViewColumn kolstevilka = dgv1.Columns[1];
                    //kolstevilka.Width = 70;
                    //kolstevilka.Visible = true;
                    //kolstevilka.HeaderText = "Številka";
                    //DataGridViewColumn koldatum = dgv1.Columns[2];
                    //koldatum.Width = 90;
                    //DataGridViewColumn koltip = dgv1.Columns[3];
                    //koltip.Width = 280;
                    //DataGridViewColumn kolopis = dgv1.Columns[4];
                    //kolopis.Width = 396;
                    //DataGridViewColumn kollink = dgv1.Columns[5];
                    //kollink.Width = 100;


                    DataGridViewRow row = new DataGridViewRow();

                    row.Cells.Add(Id);
                    row.Cells.Add(Stevilka);
                    row.Cells.Add(Datum);
                    row.Cells.Add(Tip);
                    row.Cells.Add(Opis);
                    row.Cells.Add(Link);

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

        private void Design()
        {
            crtal.AutoSize = false;
            crtal.Height = 1;
            crtal.BorderStyle = BorderStyle.Fixed3D;

            // gumbi
            btnBrisi.BackColor = frmMain.barva_gumb2_neakt; btnBrisi.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnDodaj.BackColor = frmMain.barva_gumb2_neakt; btnDodaj.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnNazaj.BackColor = frmMain.barva_gumb2_neakt; btnNazaj.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnPreklici.BackColor = frmMain.barva_gumb2_neakt; btnPreklici.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnShrani.BackColor = frmMain.barva_gumb2_neakt; btnShrani.ForeColor = frmMain.barva_gumb2_pis_akt;
            btnSpremeni.BackColor = frmMain.barva_gumb2_neakt; btnSpremeni.ForeColor = frmMain.barva_gumb2_pis_akt;
            //btnBrisi.Width = frmMain.gumb2_sirina; btnBrisi.Height = frmMain.gumb2_visina;
            //btnDodaj.Width = frmMain.gumb2_sirina; btnDodaj.Height = frmMain.gumb2_visina;
            //btnNazaj.Width = frmMain.gumb2_sirina; btnNazaj.Height = frmMain.gumb2_visina;
            //btnPreklici.Width = frmMain.gumb2_sirina; btnPreklici.Height = frmMain.gumb2_visina;
            //btnShrani.Width = frmMain.gumb2_sirina; btnShrani.Height = frmMain.gumb2_visina;
            //btnSpremeni.Width = frmMain.gumb2_sirina; btnSpremeni.Height = frmMain.gumb2_visina;

            //tbIme.BackColor = frmMain.bela;
            //tbPriimek.BackColor = frmMain.bela;
            //tbIme2.BackColor = frmMain.bela;
            //tbPriimek2.BackColor = frmMain.bela;
            //tbDelovnoMesto.BackColor = frmMain.bela;
            //tbSm.BackColor = frmMain.bela;
            //tbPosta.BackColor = frmMain.bela;
            //tbNazivPoste.BackColor = frmMain.bela;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create object of Open file dialog class  
            {
                OpenFileDialog dlg = new OpenFileDialog();
                // set file filter of dialog   
                dlg.Filter = "pdf files (*.pdf) |*.pdf;";
                dlg.ShowDialog();
                if (dlg.FileName != null)
                {
                    // use the LoadFile(ByVal fileName As String) function for open the pdf in control  
                    axAcroPDF1.LoadFile(dlg.FileName);
                }
            }
        }

        private void crtal_Click(object sender, EventArgs e)
        {

        }

    }
}
