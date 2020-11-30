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
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.EPFPageObjectFactory;
using CrystalDecisions.CrystalReports.EMFServerMessageFactory;
using System.Globalization;

namespace Komunala
{
    public partial class frmSituacija_izpis : Form
    {
        SqlConnection con = frmMain.c;
        SqlConnection con2 = frmMain.c2;
        SqlConnection con3 = frmMain.c3;

        SqlCommand cmd;
        SqlDataReader rdr = null;
        SqlDataReader rdr2 = null;
        SqlDataAdapter adapt, adapt2;
        ReportDocument cryrpt = new ReportDocument();

        SqlCommand cmd2;


        string q, q1,q2,tm,tl;
        string tsestavil, todobril, tdatum, tmesec;
        int skupinaok, ttm;
        int idx_skupina;
        string sidx_skupina;
        int d1,d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13, d14, d15, d16, d17, d18, d19, d20, d21, d22, d23, d24, d25, d26, d27, d28, d29, d30, d31;
        //int idx_mesec = 1;
        int idx_situacija;
        double koncni_znesek, delni_znesek;
        crSituacija crpt = new crSituacija();

        Color barva_praznik = Color.Gainsboro;        // barva poudarka
        Color b1 = Color.Transparent;        // prva kolona (za alternative)
        Color b2 = Color.Transparent;        // druga kolona (za alternative)
        Color bc = Color.Black;        // barva črte za kolone
        Color bch = Color.Black;  // barva horizontalnih črt

        // variable prazniki
        int dp1, dp2, dp3, dp4, dp5, dp6, dp7, dp8, dp9, dp10, dp11, dp12, dp13, dp14, dp15, dp16, dp17, dp18, dp19, dp20, dp21, dp22, dp23, dp24, dp25, dp26, dp27, dp28, dp29, dp30, dp31;
        //bool d1, d2;
        DateTime datum;
        string leto; // začasno - dobi ga iz combobox
        int int_leto, int_mesec;
        int mesec;
        DateTime v_noc;
        string tmp_mesec, tmp_dan, tmp_leto, tmp_skupaj;
        DateTime tmp_datum;
        DateTime datum_situacije;
        int ii, xx; // števci
        bool tmp_jepraznik;
        int st_dni;
        double proc_ddv,z_ddv1,z_ddv2,samo_ddv1,samo_ddv2;
        double ddv1 = 22;
        double ddv2 = 9.5;

        private void Prazniki()
        {
            v_noc = Velika_noc(2020);
            Doloci_praznike();
        }

        public bool Praznik(DateTime datum)  // ali je sobota
        {
            bool jepraznik;
            DayOfWeek day = datum.DayOfWeek;
            if ((day == DayOfWeek.Saturday) || (day == DayOfWeek.Sunday))
            {
                tmp_jepraznik = true;
            }
            else
            {
                tmp_jepraznik = false;
            }
            jepraznik = tmp_jepraznik;
            return jepraznik;
        }
        public static DateTime Velika_noc(int year)
        {
            int day = 0;
            int month = 0;

            int g = year % 19;
            int c = year / 100;
            int h = (c - (int)(c / 4) - (int)((8 * c + 13) / 25) + 19 * g + 15) % 30;
            int i = h - (int)(h / 28) * (1 - (int)(h / 28) * (int)(29 / (h + 1)) * (int)((21 - g) / 11));

            day = i - ((year + (int)(year / 4) + i + 2 - c + (int)(c / 4)) % 7) + 28;
            month = 3;

            if (day > 31)
            {
                month++;
                day -= 31;
            }

            return new DateTime(year, month, day);
        }

        private void Pisi_v_bazo()
        {
            q = "update tblPrazniki set d1=@d1, d2 = @d2,d3 = @d3,d4 = @d4,d5 = @d5,d6 = @d6,d7 = @d7,d8 = @d8,d9 = @d9,d10 = @d10," +
                "d11 = @d11,d12 = @d12,d13 = @d13,d14 = @d14,d15 = @d15,d16 = @d16,d17 = @d17,d18 = @d18,d19 = @d19," +
                "d20 = @d20,d21 = @d21,d22 = @d22,d23 = @d23,d24 = @d24,d25 = @d25,d26 = @d26,d27 = @d27,d28 = @d28,d29 = @d29," +
                "d30 = @d30,d31 = @d31 where mesec=@tmesec";
            try
            {
                cmd = new SqlCommand(q, con);
                con.Open();
                cmd.Parameters.AddWithValue("@d1", dp1);
                cmd.Parameters.AddWithValue("@d2", dp2);
                cmd.Parameters.AddWithValue("@d3", dp3);
                cmd.Parameters.AddWithValue("@d4", dp4);
                cmd.Parameters.AddWithValue("@d5", dp5);
                cmd.Parameters.AddWithValue("@d6", dp6);
                cmd.Parameters.AddWithValue("@d7", dp7);
                cmd.Parameters.AddWithValue("@d8", dp8);
                cmd.Parameters.AddWithValue("@d9", dp9);
                cmd.Parameters.AddWithValue("@d10", dp10);
                cmd.Parameters.AddWithValue("@d11", dp11);
                cmd.Parameters.AddWithValue("@d12", dp12);
                cmd.Parameters.AddWithValue("@d13", dp13);
                cmd.Parameters.AddWithValue("@d14", dp14);
                cmd.Parameters.AddWithValue("@d15", dp15);
                cmd.Parameters.AddWithValue("@d16", dp16);
                cmd.Parameters.AddWithValue("@d17", dp17);
                cmd.Parameters.AddWithValue("@d18", dp18);
                cmd.Parameters.AddWithValue("@d19", dp19);
                cmd.Parameters.AddWithValue("@d20", dp20);
                cmd.Parameters.AddWithValue("@d21", dp21);
                cmd.Parameters.AddWithValue("@d22", dp22);
                cmd.Parameters.AddWithValue("@d23", dp23);
                cmd.Parameters.AddWithValue("@d24", dp24);
                cmd.Parameters.AddWithValue("@d25", dp25);
                cmd.Parameters.AddWithValue("@d26", dp26);
                cmd.Parameters.AddWithValue("@d27", dp27);
                cmd.Parameters.AddWithValue("@d28", dp28);
                cmd.Parameters.AddWithValue("@d29", dp29);
                cmd.Parameters.AddWithValue("@d30", dp30);
                cmd.Parameters.AddWithValue("@d31", dp31);
                cmd.Parameters.AddWithValue("@tmesec", mesec);
                cmd.ExecuteNonQuery();
                //con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka shrani praznike: " + ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void Na_nulo()
        {
            dp1 = 0; dp2 = 0; dp3 = 0; dp4 = 0; dp5 = 0; dp6 = 0; dp7 = 0; dp8 = 0; dp9 = 0; dp10 = 0; dp11 = 0; dp12 = 0; dp13 = 0; dp14 = 0; dp15 = 0; dp16 = 0; dp17 = 0; dp18 = 0;
            dp19 = 0; dp20 = 0; dp21 = 0; dp22 = 0; dp23 = 0; dp24 = 0; dp25 = 0; dp26 = 0; dp27 = 0; dp28 = 0; dp29 = 0; dp30 = 0; dp31 = 0;
        }
        private void Doloci_praznike()
        // zapiši praznike v bazo
        {
            for (ii = 1; ii < 13; ii++)
            {
                Na_nulo();
                switch (ii)
                {
                    case 1:
                        // januar
                        Na_nulo();
                        mesec = ii;
                        // poišči sobote in nedelje
                        Sobota_ali_nedelja();

                        dp1 = 1; dp2 = 1;
                        Pisi_v_bazo();
                        break;
                    case 2:
                        Na_nulo();
                        mesec = ii;
                        Sobota_ali_nedelja();
                        dp7 = 1;
                        Pisi_v_bazo(); Na_nulo();
                        break;
                    case 3:
                        Na_nulo();
                        mesec = ii;
                        Sobota_ali_nedelja();
                        Pisi_v_bazo(); Na_nulo();
                        break;
                    case 4:
                        Na_nulo();
                        mesec = ii;
                        Sobota_ali_nedelja();
                        dp27 = 1;
                        Pisi_v_bazo(); Na_nulo();
                        break;
                    case 5:
                        mesec = ii;
                        dp1 = 1;
                        dp2 = 1;
                        Sobota_ali_nedelja();
                        Pisi_v_bazo(); Na_nulo();
                        break;
                    case 6:
                        mesec = ii;
                        Sobota_ali_nedelja();
                        //d2 = 1;
                        dp25 = 1;
                        Pisi_v_bazo(); Na_nulo();
                        break;
                    case 7:
                        mesec = ii;
                        Sobota_ali_nedelja();
                        Pisi_v_bazo(); Na_nulo();
                        break;
                    case 8:
                        mesec = ii;
                        Sobota_ali_nedelja();
                        dp15 = 1;
                        Pisi_v_bazo(); Na_nulo();
                        break;
                    case 9:
                        mesec = ii;
                        Sobota_ali_nedelja();
                        Pisi_v_bazo(); Na_nulo();
                        break;
                    case 10:
                        mesec = ii;
                        Sobota_ali_nedelja();
                        dp31 = 1;
                        Pisi_v_bazo(); Na_nulo();
                        break;
                    case 11:
                        mesec = ii;
                        Sobota_ali_nedelja();
                        dp1 = 1;
                        Pisi_v_bazo(); Na_nulo();
                        break;
                    case 12:
                        mesec = ii;
                        Sobota_ali_nedelja();
                        dp25 = 1;
                        dp26 = 1;
                        Pisi_v_bazo(); Na_nulo();
                        break;
                }

            }
            //            Pisi_v_bazo();

        }

        private void Sobota_ali_nedelja()
        {
            // preveri koliko dni ima mesec ii;
            st_dni = DateTime.DaysInMonth(int_leto, ii);
            //MessageBox.Show(Convert.ToString(st_dni));

            for (xx = 1; xx < st_dni+1; xx++)
            {
                tmp_mesec = Convert.ToString(ii);
                tmp_dan = Convert.ToString(xx);
                tmp_leto = leto;
                string tmp_skupaj = tmp_dan + " " + tmp_mesec + " " + tmp_leto;
                // MessageBox.Show(tmp_skupaj);
                var cultureInfo = new CultureInfo("de-DE");
                var dateTime = DateTime.Parse(tmp_skupaj, cultureInfo);
                tmp_datum = dateTime;
                //                MessageBox.Show(Convert.ToString(dateTime));
                switch (xx)
                {
                    case 1:
                        if (Praznik(tmp_datum) == true)
                            dp1 = 1;
                        break;
                    case 2:
                        if (Praznik(tmp_datum) == true)
                            dp2 = 1;
                        break;
                    case 3:
                        if (Praznik(tmp_datum) == true)
                            dp3 = 1;
                        break;
                    case 4:
                        if (Praznik(tmp_datum) == true)
                            dp4 = 1;
                        break;
                    case 5:
                        if (Praznik(tmp_datum) == true)
                            dp5 = 1;
                        break;
                    case 6:
                        if (Praznik(tmp_datum) == true)
                            dp6 = 1;
                        break;
                    case 7:
                        if (Praznik(tmp_datum) == true)
                            dp7 = 1;
                        break;
                    case 8:
                        if (Praznik(tmp_datum) == true)
                            dp8 = 1;
                        break;
                    case 9:
                        if (Praznik(tmp_datum) == true)
                            dp9 = 1;
                        break;
                    case 10:
                        if (Praznik(tmp_datum) == true)
                            dp10 = 1;
                        break;
                    case 11:
                        if (Praznik(tmp_datum) == true)
                            dp11 = 1;
                        break;
                    case 12:
                        if (Praznik(tmp_datum) == true)
                            dp12 = 1;
                        break;
                    case 13:
                        if (Praznik(tmp_datum) == true)
                            dp13 = 1;
                        break;
                    case 14:
                        if (Praznik(tmp_datum) == true)
                            dp14 = 1;
                        break;
                    case 15:
                        if (Praznik(tmp_datum) == true)
                            dp15 = 1;
                        break;
                    case 16:
                        if (Praznik(tmp_datum) == true)
                            dp16 = 1;
                        break;
                    case 17:
                        if (Praznik(tmp_datum) == true)
                            dp17 = 1;
                        break;
                    case 18:
                        if (Praznik(tmp_datum) == true)
                            dp18 = 1;
                        break;
                    case 19:
                        if (Praznik(tmp_datum) == true)
                            dp19 = 1;
                        break;
                    case 20:
                        if (Praznik(tmp_datum) == true)
                            dp20 = 1;
                        break;
                    case 21:
                        if (Praznik(tmp_datum) == true)
                            dp21 = 1;
                        break;
                    case 22:
                        if (Praznik(tmp_datum) == true)
                            dp22 = 1;
                        break;
                    case 23:
                        if (Praznik(tmp_datum) == true)
                            dp23 = 1;
                        break;
                    case 24:
                        if (Praznik(tmp_datum) == true)
                            dp24 = 1;
                        break;
                    case 25:
                        if (Praznik(tmp_datum) == true)
                            dp25 = 1;
                        break;
                    case 26:
                        if (Praznik(tmp_datum) == true)
                            dp26 = 1;
                        break;
                    case 27:
                        if (Praznik(tmp_datum) == true)
                            dp27 = 1;
                        break;
                    case 28:
                        if (Praznik(tmp_datum) == true)
                            dp28 = 1;
                        break;
                    case 29:
                        if (Praznik(tmp_datum) == true)
                            dp29 = 1;
                        break;
                    case 30:
                        if (Praznik(tmp_datum) == true)
                            dp30 = 1;
                        break;
                    case 31:
                        if (Praznik(tmp_datum) == true)
                            dp31 = 1;
                        break;

                }

            }

        }

        private void Datum()  // določi številčne vrednosti iz prenesenega datuma iz baze
        {
            string m_str = datum_situacije.ToString("MM");
            string l_str = datum_situacije.ToString("yyyy");
            string d_str = datum_situacije.ToString("dd");

            int_leto = Convert.ToInt32(l_str);
            int_mesec = Convert.ToInt32(m_str);
        }

        private void frmSituacija_izpis_Load(object sender, EventArgs e)
        {
            tsestavil = frmSituacije.sestavil;
            todobril = frmSituacije.odobril;
            tdatum = frmSituacije.datum;
            //tdatum = "26. avgust 2020";
            //tsestavil = "Franc Kovačič";
            //todobril = "Andrej Subašič";
            //tsestavil = "Franc Kovačič";
            //todobril = "Andrej Subašič";
            idx_situacija = frmSituacije.index_print;
            //MessageBox.Show("Situacija: " + Convert.ToString(idx_situacija));
            //idx_situacija = 20; // začasno - briši
            int i = 0;


            try
            {
                q = "select * from tblsituacije where id=@idx_situacija";
                cmd = new SqlCommand(q, con);
                SqlDataAdapter da = new SqlDataAdapter(q, con);
                da.SelectCommand.Parameters.Add("@idx_situacija", idx_situacija);
                DataSet dataReport = new DataSet();
                da.Fill(dataReport, "tblsituacije");

                // q1 = "select * from tblskupinestoritev ";

                q1 = "select * from tblSkupinestoritev WHERE EXISTS (select * from tblsituacija_temp where tblskupinestoritev.id = tblSituacija_temp.skupina_id)";
                cmd = new SqlCommand(q1, con);
                SqlDataAdapter da1 = new SqlDataAdapter(q1, con);
                DataSet ds = new DataSet();
                da1.Fill(dataReport, "tblskupinestoritev");
                da1.Fill(ds, "tblskupinestoritev");

                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    sidx_skupina = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    idx_skupina = Convert.ToInt32(sidx_skupina);
                    // q2 = "select * from tblSituacija_temp where skupina_id = @skupina_id";
                    q2 = "select * from tblSituacija_temp where skupina_id = @skupina_id AND k_skupaj<>'0' OR skupina_id='0'";  // novo 26-10-2020 - samo polne storitve in glave
                    cmd = new SqlCommand(q2, con);
                    SqlDataAdapter da2 = new SqlDataAdapter(q2, con);
                    da2.SelectCommand.Parameters.Add("@skupina_id", idx_skupina);
                    da2.Fill(dataReport, "tblsituacija_temp");

                }


                // Preberi podatke o situaciji za header
                q2 = "select * from tblsituacije where id=@idx_situacija";
                try
                {
                    cmd2 = new SqlCommand(q2, con2);
                    cmd2.Parameters.AddWithValue("@idx_situacija", idx_situacija);
                    con2.Open();
                    rdr2 = cmd2.ExecuteReader();
                    while (rdr2.Read())
                    {
                        tm = (string)rdr2["mesec"];
                        tl = (string)rdr2["leto"];
                        datum_situacije= (DateTime)rdr2["datum"];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: Situacija Reader  " + ex.Message);
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
                }

                // Najdi vsoto, izračunaj DDV - ddv dodan 30. 10. 2020
                q2 = "select znesek,ddv from tblsituacija_temp";
                try
                {
                    z_ddv1 = 0; z_ddv2 = 0; samo_ddv1 = 0; samo_ddv2 = 0;
                    koncni_znesek = 0; delni_znesek = 0;
                    cmd2 = new SqlCommand(q2, con2);
                    //cmd2.Parameters.AddWithValue("@idx_situacija", idx_situacija);
                    con2.Open();
                    rdr2 = cmd2.ExecuteReader();
                    while (rdr2.Read())
                    {
                        delni_znesek = (Double)rdr2["znesek"];
                        proc_ddv = (Double)rdr2["ddv"];
                        
                        if (proc_ddv==ddv1) // 22 % ddv
                        {
                            samo_ddv1 = samo_ddv1 + delni_znesek * (proc_ddv * 0.01);
                            z_ddv1 = z_ddv1 + delni_znesek + samo_ddv1;
                        }
                        if (proc_ddv == ddv2) // 9,5 % ddv
                        {
                            samo_ddv2=samo_ddv2 + delni_znesek * (proc_ddv * 0.01);
                            z_ddv2 = z_ddv2 + delni_znesek + samo_ddv2;
                        }
                        koncni_znesek = koncni_znesek + delni_znesek;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: Izračun vsote in DDV  " + ex.Message);
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
                }


                //crSituacija crpt = new crSituacija();
                crpt.SetDataSource(dataReport);
                crvSituacije.ReportSource = crpt;

                // za report footer
                tmesec = tm + " " + tl;
                TextObject textmesec = (TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["Text11"];
                textmesec.Text = tmesec;
                TextObject tt1 = (TextObject)crpt.ReportDefinition.Sections["Section4"].ReportObjects["tbSestavil"];
                tt1.Text = tsestavil;
                TextObject tt2 = (TextObject)crpt.ReportDefinition.Sections["Section4"].ReportObjects["tbOdobril"];
                tt2.Text = todobril;
                TextObject tt3 = (TextObject)crpt.ReportDefinition.Sections["Section4"].ReportObjects["tbDatum"];
                tt3.Text = tdatum;
                TextObject tt4 = (TextObject)crpt.ReportDefinition.Sections["Section4"].ReportObjects["tbSkupaj"];
                string tmp_skupaj = koncni_znesek.ToString("N2");
                tt4.Text = tmp_skupaj+" €";

                TextObject tt5 = (TextObject)crpt.ReportDefinition.Sections["Section4"].ReportObjects["t_ddv1"];
                string tmp_ddv1 = samo_ddv1.ToString("N2");
                tt5.Text = tmp_ddv1 + " €";

                TextObject tt6 = (TextObject)crpt.ReportDefinition.Sections["Section4"].ReportObjects["t_ddv2"];
                string tmp_ddv2 = samo_ddv2.ToString("N2");
                tt6.Text = tmp_ddv2 + " €";

                TextObject tt7 = (TextObject)crpt.ReportDefinition.Sections["Section4"].ReportObjects["t_zddv"];
                string tmp_zddv = (koncni_znesek+samo_ddv1+samo_ddv2).ToString("N2");
                tt7.Text = tmp_zddv + " €";




                // za zimsko službo - 29. 10. 2020

                TextObject tekstobjekt = (TextObject)crpt.ReportDefinition.Sections["Section2"].ReportObjects["t_objekt"];

                if (frmSituacije.zs==true)
                    tekstobjekt.Text = frmSituacije.str_zs;
                else
                    tekstobjekt.Text = frmSituacije.str_objekt;

                Datum();
                Prazniki();

                // sobote in prazniki

                q2 = "select * from tblPrazniki where mesec=@idx_mesec";
                try
                {
                    cmd2 = new SqlCommand(q2, con2);
                    cmd2.Parameters.AddWithValue("@idx_mesec", int_mesec);
                    con2.Open();
                    rdr2 = cmd2.ExecuteReader();
                    while (rdr2.Read())
                    {
                        d1 = (int)rdr2["d1"];
                        d2 = (int)rdr2["d2"];
                        d3 = (int)rdr2["d3"];
                        d4 = (int)rdr2["d4"];
                        d5 = (int)rdr2["d5"];
                        d6 = (int)rdr2["d6"];
                        d7 = (int)rdr2["d7"];
                        d8 = (int)rdr2["d8"];
                        d9 = (int)rdr2["d9"];
                        d10 = (int)rdr2["d10"];
                        d11 = (int)rdr2["d11"];
                        d12 = (int)rdr2["d12"];
                        d13 = (int)rdr2["d13"];
                        d14 = (int)rdr2["d14"];
                        d15 = (int)rdr2["d15"];
                        d16 = (int)rdr2["d16"];
                        d17 = (int)rdr2["d17"];
                        d18 = (int)rdr2["d18"];
                        d19 = (int)rdr2["d19"];
                        d20 = (int)rdr2["d20"];
                        d21 = (int)rdr2["d21"];
                        d22 = (int)rdr2["d22"];
                        d23 = (int)rdr2["d23"];
                        d24 = (int)rdr2["d24"];
                        d25 = (int)rdr2["d25"];
                        d26 = (int)rdr2["d26"];
                        d27 = (int)rdr2["d27"];
                        d28 = (int)rdr2["d28"];
                        d29 = (int)rdr2["d29"];
                        d30 = (int)rdr2["d30"];
                        d31 = (int)rdr2["d31"];
                        ttm = (int)rdr2["mesec"];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: Situacija Reader  " + ex.Message);
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
                }
                
                Brez_barve();
                Crte();

                //MessageBox.Show("mesec "+Convert.ToString(ttm));
                if (d1==1)
                {
                    BoxObject pr = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b1"];
                    pr.FillColor = barva_praznik; pr.LineColor = barva_praznik;
                    pr.ObjectFormat.EnableSuppress = false;
                }
                if (d2 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b2"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }
                if (d3 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b3"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }
                if (d4 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b4"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }
                if (d5 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b5"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }
                if (d6 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b6"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;

                }
                if (d7 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b7"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }
                if (d8 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b8"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }
                if (d9 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b9"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }
                if (d10 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b10"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }
                if (d11 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b11"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }
                if (d12 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b12"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }
                if (d13 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b13"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }
                if (d14 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b14"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }
                if (d15 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b15"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }
                if (d16 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b16"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }
                if (d17 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b17"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }
                if (d18 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b18"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }
                if (d19 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b19"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }
                if (d20 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b20"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }
                if (d21 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b21"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }
                if (d22 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b22"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }
                if (d23 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b23"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }
                if (d24 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b24"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }
                if (d25 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b25"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }
                if (d26 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b26"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }
                if (d27 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b27"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }
                if (d28 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b28"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }
                if (d29 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b29"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }
                if (d30 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b30"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }
                if (d31 == 1)
                {
                    BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b31"];
                    pr2.FillColor = barva_praznik; pr2.LineColor = barva_praznik;
                    pr2.ObjectFormat.EnableSuppress = false;
                }

                // crpt.PrintToPrinter(1, false, 0, 0); // direktno na printer
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka pri odpiranju situacije: " + ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                    crvSituacije.Refresh();
                }
            }

        }

        public void Brez_barve()
        {
            BoxObject pr = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b1"];
            pr.FillColor = Color.Transparent;
            
            pr.LineColor = b2;
            pr.ObjectFormat.EnableSuppress = true; pr.Bottom = 1;
            BoxObject pr2 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b2"];
            pr2.FillColor = b1; pr2.LineColor = b1;
            pr2.ObjectFormat.EnableSuppress = true; pr.Bottom = 1;
            BoxObject pr3 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b3"];
            pr3.FillColor = b2; pr3.LineColor = b2;
            pr3.ObjectFormat.EnableSuppress = true;
            BoxObject pr4 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b4"];
            pr4.FillColor = b1; pr4.LineColor = b1;
            pr4.ObjectFormat.EnableSuppress = true;
            BoxObject pr5 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b5"];
            pr5.FillColor = b2; pr5.LineColor = b2;
            pr5.ObjectFormat.EnableSuppress = true;
            BoxObject pr6 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b6"];
            pr6.FillColor = b1; pr6.LineColor = b1;
            pr6.ObjectFormat.EnableSuppress = true;
            BoxObject pr7 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b7"];
            pr7.FillColor = b2; pr7.LineColor = b2;
            pr7.ObjectFormat.EnableSuppress = true;
            BoxObject pr8 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b8"];
            pr8.FillColor = b1; pr8.LineColor = b1;
            pr8.ObjectFormat.EnableSuppress = true;
            BoxObject pr9 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b9"];
            pr9.FillColor = b2; pr9.LineColor = b2;
            pr9.ObjectFormat.EnableSuppress = true;
            BoxObject pr10 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b10"];
            pr10.FillColor = b1; pr10.LineColor = b1;
            pr10.ObjectFormat.EnableSuppress = true;
            BoxObject pr11 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b11"];
            pr11.FillColor = b2; pr11.LineColor = b2;
            pr11.ObjectFormat.EnableSuppress = true;
            BoxObject pr12 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b12"];
            pr12.FillColor = b1; pr12.LineColor = b1;
            pr12.ObjectFormat.EnableSuppress = true;
            BoxObject pr13 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b13"];
            pr13.FillColor = b2; pr13.LineColor = b2;
            pr13.ObjectFormat.EnableSuppress = true;
            BoxObject pr14 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b14"];
            pr14.FillColor = b1; pr14.LineColor = b1;
            pr14.ObjectFormat.EnableSuppress = true;
            BoxObject pr15 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b15"];
            pr15.FillColor = b2; pr15.LineColor = b2;
            pr15.ObjectFormat.EnableSuppress = true;
            BoxObject pr16 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b16"];
            pr16.FillColor = b1; pr16.LineColor = b1;
            pr16.ObjectFormat.EnableSuppress = true;
            BoxObject pr17 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b17"];
            pr17.FillColor = b2; pr17.LineColor = b2;
            pr17.ObjectFormat.EnableSuppress = true;
            BoxObject pr18 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b18"];
            pr18.FillColor = b1; pr18.LineColor = b1;
            pr18.ObjectFormat.EnableSuppress = true;
            BoxObject pr19 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b19"];
            pr19.FillColor = b2; pr19.LineColor = b2;
            pr19.ObjectFormat.EnableSuppress = true;
            BoxObject pr20 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b20"];
            pr20.FillColor = b1; pr20.LineColor = b1;
            pr20.ObjectFormat.EnableSuppress = true;
            BoxObject pr21 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b21"];
            pr21.FillColor = b2; pr21.LineColor = b2;
            pr21.ObjectFormat.EnableSuppress = true;
            BoxObject pr22 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b22"];
            pr22.FillColor = b1; pr22.LineColor = b1;
            pr22.ObjectFormat.EnableSuppress = true;
            BoxObject pr23 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b23"];
            pr23.FillColor = b2; pr23.LineColor = b2;
            pr23.ObjectFormat.EnableSuppress = true;
            BoxObject pr24 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b24"];
            pr24.FillColor = b1; pr24.LineColor = b1;
            pr24.ObjectFormat.EnableSuppress = true;
            BoxObject pr25 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b25"];
            pr25.FillColor = b2; pr25.LineColor = b2;
            pr25.ObjectFormat.EnableSuppress = true;
            BoxObject pr26 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b26"];
            pr26.FillColor = b1; pr26.LineColor = b1;
            pr26.ObjectFormat.EnableSuppress = true;
            BoxObject pr27 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b27"];
            pr27.FillColor = b2; pr27.LineColor = b2;
            pr27.ObjectFormat.EnableSuppress = true;
            BoxObject pr28 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b28"];
            pr28.FillColor = b1; pr28.LineColor = b1;
            pr28.ObjectFormat.EnableSuppress = true;
            BoxObject pr29 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b29"];
            pr29.FillColor = b2; pr29.LineColor = b2;
            pr29.ObjectFormat.EnableSuppress = true;
            BoxObject pr30 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b30"];
            pr30.FillColor = b1; pr30.LineColor = b1;
            pr30.ObjectFormat.EnableSuppress = true;
            BoxObject pr31 = (BoxObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["b31"];
            pr31.FillColor = b2; pr31.LineColor = b2;
            pr31.ObjectFormat.EnableSuppress = true;
        }

        private void Crte()
        {
            // črte
            LineObject pr = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l1"];
            pr.LineColor = bc;
            LineObject pr2 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l2"];
            pr2.LineColor = bc;
            LineObject pr3 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l3"];
            pr3.LineColor = bc;
            LineObject pr4 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l4"];
            pr4.LineColor = bc;
            LineObject pr5 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l5"];
            pr5.LineColor = bc;
            LineObject pr6 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l6"];
            pr6.LineColor = bc;
            LineObject pr7 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l7"];
            pr7.LineColor = bc;
            LineObject pr8 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l8"];
            pr8.LineColor = bc;
            LineObject pr9 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l9"];
            pr9.LineColor = bc;
            LineObject pr10 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l10"];
            pr10.LineColor = bc;
            LineObject pr11 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l11"];
            pr11.LineColor = bc;
            LineObject pr12 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l12"];
            pr12.LineColor = bc;
            LineObject pr13 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l13"];
            pr13.LineColor = bc;
            LineObject pr14 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l14"];
            pr14.LineColor = bc;
            LineObject pr15 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l15"];
            pr15.LineColor = bc;
            LineObject pr16 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l16"];
            pr16.LineColor = bc;
            LineObject pr17 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l17"];
            pr17.LineColor = bc;
            LineObject pr18 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l18"];
            pr18.LineColor = bc;
            LineObject pr19 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l19"];
            pr19.LineColor = bc;
            LineObject pr20 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l20"];
            pr20.LineColor = bc;
            LineObject pr21 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l21"];
            pr21.LineColor = bc;
            LineObject pr22 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l22"];
            pr22.LineColor = bc;
            LineObject pr23 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l23"];
            pr23.LineColor = bc;
            LineObject pr24 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l24"];
            pr24.LineColor = bc;
            LineObject pr25 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l25"];
            pr25.LineColor = bc;
            LineObject pr26 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l26"];
            pr26.LineColor = bc;
            LineObject pr27 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l27"];
            pr27.LineColor = bc;
            LineObject pr28 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l28"];
            pr28.LineColor = bc;
            LineObject pr29 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l29"];
            pr29.LineColor = bc;
            LineObject pr30 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["l30"];
            pr30.LineColor = bc;

            // horizontalne črte
            LineObject pr31 = (LineObject)crpt.Subreports[0].ReportDefinition.Sections["storSection1"].ReportObjects["lh1"];
            pr31.LineColor = bch;

        }

        public frmSituacija_izpis()
        {
            InitializeComponent();
        }
    }
}
