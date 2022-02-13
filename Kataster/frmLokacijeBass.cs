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
using MySql.Data.MySqlClient;
using MySql.Data.Types;


namespace Komunala.Kataster
{
    public partial class frmLokacijeBass : Form
    {
        public static string strc = @"Server=192.168.100.18;Database=radgona;Uid=dimec;Pwd='6iXrN6J8@J';Connect Timeout=30;"; // do bass strežnika
        MySqlConnection conb = new MySqlConnection(strc);
        MySqlCommand cmdb;
        MySqlConnection conb2 = new MySqlConnection(strc);
        MySqlCommand cmdb2;
        MySqlDataReader rdrb = null;
        MySqlDataReader rdrb2 = null;


        SqlConnection con = frmMain.c;
        SqlConnection con2 = frmMain.c2;
        SqlConnection con3 = frmMain.c3;

        SqlCommand cmd, cmd2, cmd3;
        SqlDataReader rdr, rdr2, rdr3 = null;
        static DataTable dt;

        int sirina_mreze;
        int s1 = 280; int s2 = 200; int s3 = 150; int s4 = 280; int s5 = 200; int s6 = 200;
        string sort;
        bool prvic;

        string idx;
        string om_naziv, om_hsmid,om_ulica,om_hs,om_hd,om_kraj;
        string stor_naziv, stor_em;
        string pl_naziv = "";
        string pl_naslov = "";
        string pl_ptt = "";
        string pl_kraj = "";
        string pl_drzava = "";
        string pl_zr = "";
        string pl_pravna = "";
        string pl_ddv = "";
        string pl_davcna = "";

        private void Grid()
        {
            dgv1.Width = sirina_mreze + 20;
            //dgv1.ColumnHeadersVisible = false;
            dgv1.RowHeadersVisible = false;
            dgv1.ColumnCount = 12;
            dgv1.Columns[0].Width = s1;
            dgv1.Columns[1].Width = s2;
            dgv1.Columns[2].Width = s3;
            dgv1.Columns[3].Width = s4;
            dgv1.Columns[4].Width = s5;
            dgv1.Columns[5].Width = s6;

            dgv1.Columns[0].Name = "OM";
            dgv1.Columns[1].Name = "Ulica";
            dgv1.Columns[2].Name = "Kraj";
            dgv1.Columns[3].Name = "Plačnik";
            dgv1.Columns[4].Name = "Naslov";
            dgv1.Columns[5].Name = "Pošta";
            dgv1.Columns[6].Name = "sort1";
            dgv1.Columns[7].Name = "hs";
            dgv1.Columns[8].Name = "hsd";
            dgv1.Columns[9].Name = "id";
            dgv1.Columns[10].Name = "placnik_id";
            dgv1.Columns[11].Name = "om";

            dgv1.Columns[6].Visible = false;
            dgv1.Columns[7].Visible = false;
            dgv1.Columns[8].Visible = false;
            dgv1.Columns[9].Visible = false;
            dgv1.Columns[10].Visible = false;
            dgv1.Columns[11].Visible = false;
            Padding newPadding = new Padding(6, 0, 0, 0);
            this.dgv1.Columns[0].DefaultCellStyle.Padding = newPadding;
            this.dgv1.Columns[1].DefaultCellStyle.Padding = newPadding;
            this.dgv1.Columns[2].DefaultCellStyle.Padding = newPadding;
            this.dgv1.Columns[3].DefaultCellStyle.Padding = newPadding;
            this.dgv1.Columns[4].DefaultCellStyle.Padding = newPadding;
            this.dgv1.Columns[5].DefaultCellStyle.Padding = newPadding;

            dgv1.Focus();
        }

        private void Griddt()
        {
            dgv1.Width = sirina_mreze+20;
            //dgv1.ColumnHeadersVisible = false;
            dgv1.RowHeadersVisible = false;
            //dgv1.ColumnCount = 12;
            dgv1.Columns[0].Width = s1;
            dgv1.Columns[1].Width = s2;
            dgv1.Columns[2].Width = s3;
            dgv1.Columns[3].Width = s4;
            dgv1.Columns[4].Width = s5;
            dgv1.Columns[5].Width = s6;

            dgv1.Columns[0].HeaderText= "Odjemno mesto";
            dgv1.Columns[1].Name = "Ulica";
            dgv1.Columns[2].Name = "Kraj";
            dgv1.Columns[3].Name = "Plačnik";
            dgv1.Columns[4].Name = "Naslov";
            dgv1.Columns[5].Name = "Pošta";
            dgv1.Columns[6].Name = "sort1";
            dgv1.Columns[7].Name = "hs";
            dgv1.Columns[8].Name = "hsd";
            dgv1.Columns[9].Name = "id";
            dgv1.Columns[10].Name = "placnik_id";
            dgv1.Columns[11].Name = "om";

            dgv1.Columns[6].Visible = false;
            dgv1.Columns[7].Visible = false;
            dgv1.Columns[8].Visible = false;
            dgv1.Columns[9].Visible = false;
            dgv1.Columns[10].Visible = false;
            dgv1.Columns[11].Visible = false;
            Padding newPadding = new Padding(6, 0, 0, 0);
            this.dgv1.Columns[0].DefaultCellStyle.Padding = newPadding;
            this.dgv1.Columns[1].DefaultCellStyle.Padding = newPadding;
            this.dgv1.Columns[2].DefaultCellStyle.Padding = newPadding;
            this.dgv1.Columns[3].DefaultCellStyle.Padding = newPadding;
            this.dgv1.Columns[4].DefaultCellStyle.Padding = newPadding;
            this.dgv1.Columns[5].DefaultCellStyle.Padding = newPadding;

            dgv1.Focus();
        }
        private void GridS()
        {
            //dgvs.Width = sirina_mreze + 20;
            //dgv1.ColumnHeadersVisible = false;
            dgvs.RowHeadersVisible = false;
            dgvs.ColumnCount = 2;
            dgvs.Columns[0].Width = 290;
            dgvs.Columns[1].Width = 74;

            dgvs.Columns[0].Name = "Storitev";
            dgvs.Columns[1].Name = "EM";
            Padding newPadding = new Padding(6, 0, 0, 0);
            this.dgvs.Columns[0].DefaultCellStyle.Padding = newPadding;
            this.dgvs.Columns[1].DefaultCellStyle.Padding = newPadding;
        }

        private void Sort()
        {
            if (rb1.Checked)
                dgv1.Sort(dgv1.Columns[0], ListSortDirection.Ascending);
            if (rb2.Checked)
            {
                dgv1.Sort(dgv1.Columns[6], ListSortDirection.Ascending);
            }

            if (rb3.Checked)
                dgv1.Sort(dgv1.Columns[3], ListSortDirection.Ascending);
            dgv1.Focus();
        }

        private void Nalozi_zapis(int idx_om, int idx_placnik, int idx_omom)
        {
            dgvs.Rows.Clear();
            //string q = "select sifra, naziv,naslov,ptt,kraj,drzava_naziv,zr,pravna_os,zavezanec,davcna from stranke_radgona_2021 where sifra = @idx"; //+ sort;
            string q = @"
            SELECT
              inkasso_2021_om_radgona.OM AS om,
              inkasso_2021_om_radgona.OM_ID AS omid,
              inkasso_2021_om_radgona.OM_NAZIV AS omnaziv,
              inkasso_2021_om_radgona.ULICA_SIFRA,
              inkasso_2021_om_radgona.OM_HS AS omhs,
              inkasso_2021_om_radgona.OM_HSD AS omhd,
              inkasso_2021_om_radgona.OM_XH AS omx,
              inkasso_2021_om_radgona.OM_YH AS omy,
              inkasso_2021_om_radgona.OM_HSMID AS omhsmid,
              inkasso_2021_om_radgona.OM_AKTIVEN,
              bass_location_street.street_name AS omulica,
              inkasso_2021_om_radgona.KRAJ_SK_SIFRA,
              bass_location_sett.sett_name AS omkraj,
              inkasso_2021_om_radgona.OM_PLACNIK,
              stranke_radgona_2021.NAZIV AS plnaziv,
              stranke_radgona_2021.NASLOV AS plulica,
              stranke_radgona_2021.KRAJ AS plkraj,
              stranke_radgona_2021.PTT AS plptt,
              stranke_radgona_2021.PRAVNA_OS AS plpravna,
              stranke_radgona_2021.ZAVEZANEC AS plzavezanec,
              stranke_radgona_2021_poste.NAZIV AS plpttnaziv
            FROM inkasso_2021_om_radgona
              INNER JOIN bass_location_sett
                ON inkasso_2021_om_radgona.KRAJ_SK_SIFRA = bass_location_sett.sett_code
              INNER JOIN bass_location_street
                ON inkasso_2021_om_radgona.ULICA_SIFRA = bass_location_street.street_code
              INNER JOIN stranke_radgona_2021
                ON inkasso_2021_om_radgona.OM_PLACNIK = stranke_radgona_2021.SIFRA
              INNER JOIN stranke_radgona_2021_poste
                ON stranke_radgona_2021.PTT = stranke_radgona_2021_poste.SIFRA
            WHERE inkasso_2021_om_radgona.OM_ID = @idx
                ";

            try
            {
                cmdb2 = new MySqlCommand(q, conb2);
                cmdb2.Parameters.AddWithValue("@idx", idx_om);
                conb2.Open();
                rdrb2 = cmdb2.ExecuteReader();
                while (rdrb2.Read())
                {
                    if (rdrb2["omnaziv"] != DBNull.Value) om_naziv = (string)rdrb2["omnaziv"];
                    if (rdrb2["omulica"] != DBNull.Value) om_ulica = (string)rdrb2["omulica"];
                    if (rdrb2["omhs"] != DBNull.Value) om_hs = (string)rdrb2["omhs"];
                    if (rdrb2["omhd"] != DBNull.Value) om_hd = (string)rdrb2["omhd"];
                    if (rdrb2["omhsmid"] != DBNull.Value) om_hsmid = Convert.ToString((Int32)rdrb2["omhsmid"]);
                    if (rdrb2["omkraj"] != DBNull.Value) om_kraj = (string)rdrb2["omkraj"];

                    if (rdrb2["plnaziv"] != DBNull.Value) pl_naziv = (string)rdrb2["plnaziv"];
                    if (rdrb2["plulica"] != DBNull.Value) pl_naslov = (string)rdrb2["plulica"];
                    if (rdrb2["plptt"] != DBNull.Value) pl_ptt = (string)rdrb2["plptt"];
                    if (rdrb2["plkraj"] != DBNull.Value) pl_kraj = (string)rdrb2["plkraj"];
                    //if (rdrb2["drzava_naziv"] != DBNull.Value) pl_drzava = (string)rdrb2["drzava_naziv"];
                    //if (rdrb2["zr"] != DBNull.Value) pl_zr = (string)rdrb2["zr"];
                    if (rdrb2["plpravna"] != DBNull.Value) pl_pravna = (string)rdrb2["plpravna"];
                    if (rdrb2["plzavezanec"] != DBNull.Value) pl_ddv = (string)rdrb2["plzavezanec"];
                    //if (rdrb2["davcna"] != DBNull.Value) pl_davcna = (string)rdrb2["davcna"];
                    //if (pl_drzava == "SLOVENIJA")
                    //    pl_drzava = "";
                    //else
                    //    pl_drzava = ", " + pl_drzava;
                    // ltr.Text = pl_zr;
                    if (pl_pravna == "T") lpr.Text = "DA";
                    else lpr.Text = "NE";
                    if (pl_ddv == "T") lza.Text = "DA";
                    else lza.Text = "NE";
                    lds.Text = pl_davcna;

                    lom.Text = om_naziv;
                    lomn.Text = om_ulica + " " + om_hs + om_hd + ", "+om_kraj;
                    lhsmid.Text = om_hsmid;
                    //st_stanovanj = Convert.ToString((int)rdr6["st_stanovanj"]);
                    //st_poslovnih_prostorov = Convert.ToString((int)rdr6["st_poslovnih_prostorov"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka rdr: " + ex.Message);
            }
            finally
            {
                rdrb2.Close();
                conb2.Close();
            }

            lp.Text = pl_naziv;
            ln.Text = pl_naslov + ", " + pl_ptt + " " + pl_kraj + pl_drzava;
            //label21.Text = st_stanovanj;
            //label18.Text = st_poslovnih_prostorov;

            // POIŠČI STORITVE
            q = @"
            SELECT
              inkasso_2021_om_radgona.OM AS OMOM,
              inkasso_2021_omstoritve_radgona.OMSTORITVE_STORITEV,
              inkasso_2021_omstoritve_radgona.OM AS OMSTOR,
              racuni_2021_storitve_radgona.storitev_naziv as stornaziv,
              racuni_2021_storitve_radgona.storitev_em as storem
            FROM inkasso_2021_omstoritve_radgona
              INNER JOIN racuni_2021_storitve_radgona
                ON inkasso_2021_omstoritve_radgona.OMSTORITVE_STORITEV = racuni_2021_storitve_radgona.storitev_sifra
              INNER JOIN inkasso_2021_om_radgona
                ON inkasso_2021_omstoritve_radgona.OM = inkasso_2021_om_radgona.OM
            WHERE inkasso_2021_omstoritve_radgona.OM = @idx
            GROUP BY inkasso_2021_omstoritve_radgona.OMSTORITVE_STORITEV
            ";
            try
            {
                cmdb2 = new MySqlCommand(q, conb2);
                cmdb2.Parameters.AddWithValue("@idx", idx_omom);
                conb2.Open();
                rdrb2 = cmdb2.ExecuteReader();
                while (rdrb2.Read())
                {
                    if (rdrb2["stornaziv"] != DBNull.Value) stor_naziv = (string)rdrb2["stornaziv"];
                    if (rdrb2["storem"] != DBNull.Value) stor_em = (string)rdrb2["storem"];
                    //MessageBox.Show(stor_naziv);
                    string[] row2 = new string[] { stor_naziv, stor_em };
                    dgvs.Rows.Add(row2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka rdr: " + ex.Message);
            }
            finally
            {
                dgvs.Refresh();
                rdrb2.Close();
                conb2.Close();
            }


        }
        private void dgv1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //string tmp = dgv1.Rows[e.RowIndex].Cells[10].Value.ToString();
            //lp.Text = tmp;
            //int idx_om = Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells[9].Value.ToString());
            //int idx_placnik = Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells[10].Value.ToString());
            //int idx_omom = Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells[11].Value.ToString());
            //Nalozi_zapis(idx_om, idx_placnik,idx_omom);

        }

        private void Display()
        {
            int stevid = 0;
            Izprazni_dgv();
            string brezlokacije;
            if (cbl.Checked)
            {
                brezlokacije = " and (inkasso_2021_om_radgona.OM_HSMID = '99' or inkasso_2021_om_radgona.OM_HSMID = '0') ";
                sort = "ORDER BY omnaziv, omulica, omhs, omhsd";
            }
            else
            {
                brezlokacije = "";
                sort = "ORDER BY omnaziv, omulica, omhs, omhsd";
            }
            if (prvic)
                sort = "ORDER BY omnaziv, omulica, omhs, omhsd";
            try
            {
                string q = @"
                            SELECT
                              bass_location_street.street_name AS omulica,
                              inkasso_2021_om_radgona.OM_NAZIV AS omnaziv,
                              inkasso_2021_om_radgona.OM_HSMID AS omhsmid,
                              inkasso_2021_om_radgona.OM_HS AS omhs,
                              inkasso_2021_om_radgona.OM_HSD AS omhsd,
                              inkasso_2021_om_radgona.OM_XH AS omx,
                              inkasso_2021_om_radgona.OM_YH AS omy,
                              bass_location_sett.sett_name AS omkraj,
                              inkasso_2021_om_radgona.OM_PLACNIK AS placnik_id,
                              stranke_radgona_2021.NAZIV AS omplacnik,
                              stranke_radgona_2021.NASLOV AS plnaslov,
                              stranke_radgona_2021.KRAJ AS plkraj,
                              inkasso_2021_om_radgona.OM AS om,
                              inkasso_2021_om_radgona.OM_ID AS omid,
                              stranke_radgona_2021.PTT AS plptt,
                              stranke_radgona_2021.DRZAVA_NAZIV AS pldrzava,
                              stranke_radgona_2021.TELEFON,
                              stranke_radgona_2021_poste.NAZIV AS plposta
                            FROM inkasso_2021_om_radgona
                              INNER JOIN bass_location_street
                                ON inkasso_2021_om_radgona.ULICA_SIFRA = bass_location_street.street_code
                              INNER JOIN stranke_radgona_2021
                                ON inkasso_2021_om_radgona.OM_PLACNIK = stranke_radgona_2021.SIFRA
                              INNER JOIN bass_location_sett
                                ON bass_location_street.sett_code = bass_location_sett.sett_code
                              INNER JOIN stranke_radgona_2021_poste
                                ON stranke_radgona_2021.PTT = stranke_radgona_2021_poste.SIFRA
                            WHERE inkasso_2021_om_radgona.om_aktiven='T'"
                                + brezlokacije +
                                @"
                                GROUP BY inkasso_2021_om_radgona.OM_ID,
                                     stranke_radgona_2021.PTT,
                                     stranke_radgona_2021.DRZAVA_NAZIV,
                                     stranke_radgona_2021.TELEFON,
                                     stranke_radgona_2021_poste.NAZIV 
                        "
                        + sort;
                        ;

                string omulica = ""; 
                string omhs = "";
                string omid = "";
                string om = "";
                string omplacnik = "";
                string plnaslov = "";
                string omhd = "";
                string omlabela = "";
                string omkraj = "";
                string plposta = "";
                // string plkraj = "";
                string pldrzava = "";
                string plpostat = "";
                string placnik_id = "";
                string plptt = "";
                // string 
                cmdb = new MySqlCommand(q, conb);
                conb.Open();
    
                rdrb = cmdb.ExecuteReader();
                while (rdrb.Read())
                {
                    stevid++;
                    string sstev = stevid.ToString();
                    if (rdrb["omid"] != DBNull.Value) omid = Convert.ToString((int)rdrb["omid"]);
                    if (rdrb["om"] != DBNull.Value) om = (string)rdrb["om"];
                    if (rdrb["omnaziv"] != DBNull.Value) om_naziv = (string)rdrb["omnaziv"];
                    if (rdrb["omhsmid"] != DBNull.Value) om_hsmid = Convert.ToString((Int32)rdrb["omhsmid"]);

                    if (rdrb["omulica"] != DBNull.Value) omulica = (string)rdrb["omulica"];
                    if (rdrb["omhs"] != DBNull.Value) omhs = (string)rdrb["omhs"];
                    if (rdrb["omhsd"] != DBNull.Value) omhd = (string)rdrb["omhsd"];
                    //omulica = 
                    if (rdrb["omkraj"] != DBNull.Value) omkraj = (string)rdrb["omkraj"];
                    if (rdrb["omplacnik"] != DBNull.Value) omplacnik = (string)rdrb["omplacnik"];
                    if (rdrb["plnaslov"] != DBNull.Value) plnaslov = (string)rdrb["plnaslov"];
                    if (rdrb["plptt"] != DBNull.Value) plptt = (string)rdrb["plptt"];
                    if (rdrb["plposta"] != DBNull.Value) plpostat = (string)rdrb["plposta"];
                    if (rdrb["placnik_id"] != DBNull.Value) placnik_id = Convert.ToString((int)rdrb["placnik_id"]);
                    plposta = plptt + " " + plpostat;
                    if (rdrb["pldrzava"] != DBNull.Value) pldrzava = (string)rdrb["pldrzava"];
                    string[] row1 = new string[] { om_naziv, omulica + " " + omhs + omhd,omkraj, omplacnik,plnaslov,plposta,omulica+omhs+omhd,omhs,omhd,omid,placnik_id,om };

                    dgv1.Rows.Add(row1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: " + ex.Message);
            }
            finally
            {
                rdrb.Close();
                conb.Close();
            }
            lz.Text = stevid.ToString();
            //Zacetek();
        }

        private void Displaydt()
        {
            int stevid = 0;
            Izprazni_dgv();
            string brezlokacije;
            if (cbl.Checked)
            {
                brezlokacije = " and (inkasso_2021_om_radgona.OM_HSMID = '99' or inkasso_2021_om_radgona.OM_HSMID = '0') ";
                sort = "ORDER BY omnaziv, omulica, omhs, omhsd";
            }
            else
            {
                brezlokacije = "";
                sort = "ORDER BY omnaziv, omulica, omhs, omhsd";
            }
            if (prvic)
                sort = "ORDER BY omnaziv, omulica, omhs, omhsd";
            try
            {
                
                string q = @"
                            SELECT
                              inkasso_2021_om_radgona.OM_NAZIV AS omnaziv,
                              bass_location_street.street_name AS omulica,
                              inkasso_2021_om_radgona.OM_HSMID AS omhsmid,
                              inkasso_2021_om_radgona.OM_HS AS omhs,
                              inkasso_2021_om_radgona.OM_HSD AS omhsd,
                              inkasso_2021_om_radgona.OM_XH AS omx,
                              inkasso_2021_om_radgona.OM_YH AS omy,
                              bass_location_sett.sett_name AS omkraj,
                              inkasso_2021_om_radgona.OM_PLACNIK AS placnik_id,
                              stranke_radgona_2021.NAZIV AS omplacnik,
                              stranke_radgona_2021.NASLOV AS plnaslov,
                              stranke_radgona_2021.KRAJ AS plkraj,
                              inkasso_2021_om_radgona.OM AS om,
                              inkasso_2021_om_radgona.OM_ID AS omid,
                              stranke_radgona_2021.PTT AS plptt,
                              stranke_radgona_2021.DRZAVA_NAZIV AS pldrzava,
                              stranke_radgona_2021.TELEFON,
                              stranke_radgona_2021_poste.NAZIV AS plposta
                            FROM inkasso_2021_om_radgona
                              INNER JOIN bass_location_street
                                ON inkasso_2021_om_radgona.ULICA_SIFRA = bass_location_street.street_code
                              INNER JOIN stranke_radgona_2021
                                ON inkasso_2021_om_radgona.OM_PLACNIK = stranke_radgona_2021.SIFRA
                              INNER JOIN bass_location_sett
                                ON bass_location_street.sett_code = bass_location_sett.sett_code
                              INNER JOIN stranke_radgona_2021_poste
                                ON stranke_radgona_2021.PTT = stranke_radgona_2021_poste.SIFRA
                            WHERE inkasso_2021_om_radgona.om_aktiven='T'"
                                + brezlokacije +
                                @"
                                GROUP BY inkasso_2021_om_radgona.OM_ID,
                                     stranke_radgona_2021.PTT,
                                     stranke_radgona_2021.DRZAVA_NAZIV,
                                     stranke_radgona_2021.TELEFON,
                                     stranke_radgona_2021_poste.NAZIV 
                        "
                        + sort;
                ;

                var da = new MySqlDataAdapter(q, conb);

                dt = new DataTable();
                da.Fill(dt);
                dgv1.DataSource = dt;


                //    string omulica = "";
                //    string omhs = "";
                //    string omid = "";
                //    string om = "";
                //    string omplacnik = "";
                //    string plnaslov = "";
                //    string omhd = "";
                //    string omlabela = "";
                //    string omkraj = "";
                //    string plposta = "";
                //    // string plkraj = "";
                //    string pldrzava = "";
                //    string plpostat = "";
                //    string placnik_id = "";
                //    string plptt = "";
                //    // string 
                //    cmdb = new MySqlCommand(q, conb);
                //    conb.Open();

                //    rdrb = cmdb.ExecuteReader();
                //    while (rdrb.Read())
                //    {
                //        stevid++;
                //        string sstev = stevid.ToString();
                //        if (rdrb["omid"] != DBNull.Value) omid = Convert.ToString((int)rdrb["omid"]);
                //        if (rdrb["om"] != DBNull.Value) om = (string)rdrb["om"];
                //        if (rdrb["omnaziv"] != DBNull.Value) om_naziv = (string)rdrb["omnaziv"];
                //        if (rdrb["omhsmid"] != DBNull.Value) om_hsmid = Convert.ToString((Int32)rdrb["omhsmid"]);

                //        if (rdrb["omulica"] != DBNull.Value) omulica = (string)rdrb["omulica"];
                //        if (rdrb["omhs"] != DBNull.Value) omhs = (string)rdrb["omhs"];
                //        if (rdrb["omhsd"] != DBNull.Value) omhd = (string)rdrb["omhsd"];
                //        //omulica = 
                //        if (rdrb["omkraj"] != DBNull.Value) omkraj = (string)rdrb["omkraj"];
                //        if (rdrb["omplacnik"] != DBNull.Value) omplacnik = (string)rdrb["omplacnik"];
                //        if (rdrb["plnaslov"] != DBNull.Value) plnaslov = (string)rdrb["plnaslov"];
                //        if (rdrb["plptt"] != DBNull.Value) plptt = (string)rdrb["plptt"];
                //        if (rdrb["plposta"] != DBNull.Value) plpostat = (string)rdrb["plposta"];
                //        if (rdrb["placnik_id"] != DBNull.Value) placnik_id = Convert.ToString((int)rdrb["placnik_id"]);
                //        plposta = plptt + " " + plpostat;
                //        if (rdrb["pldrzava"] != DBNull.Value) pldrzava = (string)rdrb["pldrzava"];
                //        string[] row1 = new string[] { om_naziv, omulica + " " + omhs + omhd, omkraj, omplacnik, plnaslov, plposta, omulica + omhs + omhd, omhs, omhd, omid, placnik_id, om };

                //        dgv1.Rows.Add(row1);
                //    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka DataTable: " + ex.Message);
            }
            finally
            {
                conb.Close();
            }
            lz.Text = stevid.ToString();
            //Zacetek();
        }

        private void frmLokacijeBass_Load(object sender, EventArgs e)
        {
            prvic = true;
            Design();
            rb1.Checked = true;
            //onemogoci_tb();
            //Grid();
            GridS();
            Displaydt();
            Griddt();
            Zacetek();
        }

        private void Design()
        {
            //this.BackColor = frmMain.barva_form_back;
            sirina_mreze = s1 + s2 + s3 + s4 + s5 + s6;
            this.Width = sirina_mreze + 500;

            //crtal2.AutoSize = false;
            //crtal2.Height = 1;
            //crtal2.BorderStyle = BorderStyle.Fixed3D;
            //crtal.AutoSize = false;
            //crtal.Height = 1;
            //crtal.BorderStyle = BorderStyle.Fixed3D;

            //tpOsnovno.BackColor = frmMain.barva_form_back;
            //tpDodatno.BackColor = frmMain.barva_form_back;

            //// gumbi
            //btnBrisi.BackColor = frmMain.barva_gumb2_neakt; btnBrisi.ForeColor = frmMain.barva_gumb2_pis_akt;
            //btnDodaj.BackColor = frmMain.barva_gumb2_neakt; btnDodaj.ForeColor = frmMain.barva_gumb2_pis_akt;
         //   btnNazaj.BackColor = frmMain.barva_gumb2_neakt; btnNazaj.ForeColor = frmMain.barva_gumb2_pis_akt;
            //btnPreklici.BackColor = frmMain.barva_gumb2_neakt; btnPreklici.ForeColor = frmMain.barva_gumb2_pis_akt;
            //btnShrani.BackColor = frmMain.barva_gumb2_neakt; btnShrani.ForeColor = frmMain.barva_gumb2_pis_akt;
            //btnSpremeni.BackColor = frmMain.barva_gumb2_neakt; btnSpremeni.ForeColor = frmMain.barva_gumb2_pis_akt;
            //btnDodatno.BackColor = frmMain.barva_gumb2_neakt; btnDodatno.ForeColor = frmMain.barva_gumb2_pis_akt;
            //btnBrisi.Width = frmMain.gumb2_sirina; btnBrisi.Height = frmMain.gumb2_visina;
            //btnDodaj.Width = frmMain.gumb2_sirina; btnDodaj.Height = frmMain.gumb2_visina;
           // btnNazaj.Width = frmMain.gumb2_sirina; btnNazaj.Height = frmMain.gumb2_visina;
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
            //tbHs.BackColor = frmMain.bela;
            //tbUlica.BackColor = frmMain.bela;
            //tbPrivatMail.BackColor = frmMain.bela;
            //tbSluzbeniMail.BackColor = frmMain.bela;
            //tbSluzbeniMob.BackColor = frmMain.bela;
            //tbSluzbeniStac.BackColor = frmMain.bela;
            //tbPrivatMob.BackColor = frmMain.bela;
            //tbMpo.BackColor = frmMain.bela;
            //tbIzobrazba.BackColor = frmMain.bela;
            //tbEmso.BackColor = frmMain.bela;
            //tbDs.BackColor = frmMain.bela;
            //tbTrr.BackColor = frmMain.bela;
            //tbBanka.BackColor = frmMain.bela;
            //tbOddelek.BackColor = frmMain.bela;

        }
        private void Izprazni_dgv()
        {
            dgv1.Rows.Clear();
            dgv1.Refresh();
        }

        private void frmLokacijeBass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                // iskanje po nazivu om
                tbom.Focus();
                //frmIsci_o secondForm = new frmIsci_o();
                //secondForm.ShowDialog();

            }
            if (e.KeyCode == Keys.F2)
            {
                //frmIsci_n secondForm = new frmIsci_n();
                //secondForm.ShowDialog();

            }
        }

        private void tbom_TextChanged(object sender, EventArgs e)
        {
            // Išči po odjemnem mestu
            (dgv1.DataSource as DataTable).DefaultView.RowFilter = string.Format("OM LIKE '%{0}%'", tbom.Text);
            //DataView dv = dt.DefaultView;
            //dv.RowFilter = "OM LIKE '" + tbom.Text + "%'";
            //dgv1.DataSource = dv;
        }

        private void cbl_CheckedChanged(object sender, EventArgs e)
        {
            Display();
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            if (prvic==false) Sort();
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            if (prvic == false) Sort();
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            if (prvic == false) Sort();
        }

        private void btnNazaj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void onemogoci_tb()
        {
            //tbIme.Enabled = false;
            //tbPriimek.Enabled = false;
            //tbIme2.Enabled = false;
            //tbPriimek2.Enabled = false;
            //tbDelovnoMesto.Enabled = false;
            //tbSm.Enabled = false;
            //tbPosta.Enabled = false;
            //tbNazivPoste.Enabled = false;
            //tbHs.Enabled = false;
            //tbUlica.Enabled = false;
            //tbPrivatMail.Enabled = false;
            //tbSluzbeniMail.Enabled = false;
            //tbSluzbeniMob.Enabled = false;
            //tbSluzbeniStac.Enabled = false;
            //tbPrivatMob.Enabled = false;
            //tbMpo.Enabled = false;
            //tbIzobrazba.Enabled = false;
            //tbEmso.Enabled = false;
            //tbDs.Enabled = false;
            //tbTrr.Enabled = false;
            //tbBanka.Enabled = false;
            //tbOddelek.Enabled = false;
        }

        private void omogoci_tb()
        {
            //tbIme.Enabled = true;
            //tbPriimek.Enabled = true;
            //tbDelovnoMesto.Enabled = true;
            //tbSm.Enabled = true;
            //tbPosta.Enabled = true;
            //tbNazivPoste.Enabled = true;
            //tbHs.Enabled = true;
            //tbUlica.Enabled = true;
            //tbPrivatMail.Enabled = true;
            //tbSluzbeniMail.Enabled = true;
            //tbSluzbeniMob.Enabled = true;
            //tbSluzbeniStac.Enabled = true;
            //tbPrivatMob.Enabled = true;
            //tbMpo.Enabled = true;
            //tbIzobrazba.Enabled = true;
            //tbEmso.Enabled = true;
            //tbDs.Enabled = true;
            //tbTrr.Enabled = true;
            //tbBanka.Enabled = true;
            //tbOddelek.Enabled = true;
        }

        private void izprazni_tb()
        {
            //tbIme.Text = "";
            //tbPriimek.Text = "";
            //tbIme2.Text = "";
            //tbPriimek2.Text = "";
            //tbDelovnoMesto.Text = "";
            //tbSm.Text = "";
            //tbPosta.Text = "";
            //tbNazivPoste.Text = "";
            //tbHs.Text = "";
            //tbUlica.Text = "";
            //tbPrivatMail.Text = "";
            //tbSluzbeniMail.Text = "";
            //tbSluzbeniMob.Text = "";
            //tbSluzbeniStac.Text = "";
            //tbPrivatMob.Text = "";
            ////.Text = (string)rdr2[""];
            //tbMpo.Text = "";
            //tbIzobrazba.Text = "";
            //tbEmso.Text = "";
            //tbDs.Text = "";
            //tbTrr.Text = "";
            //tbBanka.Text = "";
            //tbOddelek.Text = "";
        }

        public frmLokacijeBass()
        {
            InitializeComponent();
        }

        private void Zacetek()
        {
            prvic = false;
            //dodajanje = false;
            //osnovno = true;
            //izprazni_tb();
            //onemogoci_tb();
            //btnShrani.Enabled = false;
            //btnShrani.BackColor = frmMain.barva_gumb2_disabled;
            //btnPreklici.Enabled = false;
            //btnPreklici.BackColor = frmMain.barva_gumb2_disabled;
            //btnDodaj.Enabled = true;
            //btnDodaj.BackColor = frmMain.barva_gumb2_neakt;
            //btnBrisi.Enabled = true;
            //btnBrisi.BackColor = frmMain.barva_gumb2_neakt;
            //btnSpremeni.Enabled = true;
            //btnSpremeni.BackColor = frmMain.barva_gumb2_neakt;
            //btnNazaj.Enabled = true;
            //btnNazaj.BackColor = frmMain.barva_gumb2_neakt;
            dgv1.Focus();

        }



    }
}
