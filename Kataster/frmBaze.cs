using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.CodeDom;

namespace Komunala
{
    public partial class frmBaze : Form
    {
        // določi connection

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

        int stevec_zacasno = 0;
        int stevec_stalno = 0;
        int temp_zacasno, temp_stalno;

        int nivcadis, cadis;
        string vrstica;
        int stevec;
        int countcrp, counths, countul, countna, countpt, countcad;
        // string mapa = "C:\\KatApp\\Kataster\\data\\";
        string mapa = frmMain.app_path_data;
        string m1 = "data\\";
        string fnamecrp;
        string fnamecad;
        string fnamecad2;
        string fnamecrp2;
        string fnamehs;
        string fnamehs2;
        string fnameul;
        string fnameul2;
        string fnamena;
        string fnamena2;
        string fnamept;
        string fnamept2, fnameag, fnameag2;
        string csv = ";";
        string str_zapisi;
        string ag_id, ag_ime;  // aglomeracije
        int nag,ncrp, nhs, nul, nna, npt, ncad; // napake pri preverjanju baze
        string tnaslov, tindeks_osebe;
        // variable cadis
        string chsmid = "", cnaziv = "", ckraj = "", culica = "", chs = "", cposta = "", cime_poste = "", cdim = "", ctip_om = "";
        int csmeti = 0, cvodovod = 0, ckanalizacija = 0, cgreznica = 0;

        // variable tbl_crp
        string emso = "", spol = "", priimek1 = "", priimek2 = "", ime1 = "", ime2 = "", drzava = "", obcina_roj = "", naselje_roj = "";
        string drzava_roj = "", naselje_stpr = "", ulica_stpr = "", hs_stpr = "", hsd_stpr = "", posta_stpr = "", naziv_poste_stpr = "";
        string pt_id = "", pt_uime = "";

        // za izvoz v CSV
        string c_hsmid, c_ulica, c_labela, c_naslov, c_stalno, c_zacasno, c_voda, c_kanalizacija, c_smeti, c_greznica, c_x, c_y,c_cadis;



        private void tbl_crpBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_crpBindingSource.EndEdit();
            // this.tableAdapterManager.UpdateAll(this.ds_Kataster);

        }

        string ulica_zcpr = "", hs_zcpr = "", hsd_zcpr = "", posta_zcpr = "", naziv_poste_zcpr = "", status_preb = "", stan = "";

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        string idxtemp, natemp, ultemp, idxtempz;

        private void button16_Click_1(object sender, EventArgs e)
        {
            //frmBaze_last secondForm = new frmBaze_last();
            //secondForm.ShowDialog();
        }

        private void btnHs_Click(object sender, EventArgs e)
        {

        }

        private void Obdelaj_aglo()
        {
            
            // začni prenos
            stevec = 0;
            IzprazniBazo_ag();
            try
            {
                System.IO.StreamReader objReader;
                objReader = new System.IO.StreamReader(fnameag, ASCIIEncoding.UTF8);
                do
                {
                    vrstica = "";
                    Izprazni_ag();
                    vrstica = vrstica + objReader.ReadLine() + "\r\n";

                    // razdeli vrstico ločeno s ;
                    string[] polje = vrstica.Split(';');
                    ag_id = polje[1];
                    ag_ime = polje[2];
                    //pt_mid = polje[2];
                    try
                    {
                        if (stevec > 0)
                        {
                            // napiši prebrano v tabelo pt
                            string query = "insert into tbl_aglo (id_aglo,ime_aglo) values(@ag_id, @ag_ime)";
                            cmd = new SqlCommand(query, con);
                            con.Open();
                            cmd.Parameters.AddWithValue("@ag_id", ag_id);
                            cmd.Parameters.AddWithValue("@ag_ime", ag_ime);
                            //cmd.Parameters.AddWithValue("@pt_mid", pt_mid);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka: " + ex.Message);
                    }
                    stevec = ++stevec;
                    vrstica = "";
                    label52.Text = stevec.ToString();
                    label52.Refresh();
                } while (objReader.Peek() != -1);
                objReader.Close();
                stevec--;
                label52.Text = stevec.ToString();
                label52.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka - aglomeracije: " + ex.Message);
            }
            finally
            {
               // DisplayData_pt();
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            // zapiši Aglomeracije v tbl_hise
            fd.Title = "Izberi datoteko s podatki o aglomeracijah";
            fd.InitialDirectory = frmMain.app_path_data;  // "C:\\KatApp\\Kataster\\data";
            fd.FileName = "aglo.csv";

            // preberi ime datoteke iz dialoga
            if (fd.ShowDialog() == DialogResult.OK)
            {
                // preberi CRP - CSV
                try
                {
                    fnamecrp = fd.FileName;
                    var lineCount = File.ReadAllLines(@fnamecrp).Length;
                    // label2.Text = fnamecrp;
                    // label24.Text = lineCount.ToString();
                    Obdelaj_aglo();
                    ncrp = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: " + ex.Message);
                    ncrp = 1;
                }
            }
            else
            {
                MessageBox.Show("Datoteka ne obstaja: " + fnamecrp);

            }

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        string dat_roj = "", datom_od_zcpr = "";

        // variable tbl_hs
        string index_hs = "", enota = "", hs_mid = "", hs = "", hd = "", labela = "", ulmid = "", na_mid = "", ob_mid = "", pt_mid = "", po_mid = "", y = "", x = "";

        private void btnIzvoz_Click(object sender, EventArgs e)
        {
            // izvozi datoteko stavbe v CSV


            try
            {
                string path = "c:\\hise.csv";

                File.Create(path).Close();
                
                string q = "select * from tbl_hise"; // preberi vse zapise iz tbl_hise

                cmd = new SqlCommand(q, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                //string hsmid_hs;
                //nivcadis = 0;
                using (StreamWriter writetext = new StreamWriter(path))
                {
                    // glava
                    str_zapisi = "HSMID" + csv + "ULICA" + csv + "LABELA" + csv + "NASLOV" + csv + "STALNO" + csv + "ZACASNO" + csv + "VODA" + csv + "KAN." + csv + "SMETI" + csv + "GREZNICA" + csv + "CADIS";
                    writetext.WriteLine(str_zapisi, Encoding.UTF8);

                    while (rdr.Read())
                    {
                        str_zapisi = "";
                        c_hsmid = (string)rdr["hsmid"];
                        c_ulica = (string)rdr["naslov"];
                        c_labela = (string)rdr["labela"];
                        c_naslov = c_ulica + " " + c_labela;
                        c_stalno = Convert.ToString((int)rdr["stalno"]);
                        c_zacasno = Convert.ToString((int)rdr["zacasno"]);
                        c_voda = Convert.ToString((int)rdr["zacasno"]);
                        c_kanalizacija = Convert.ToString((int)rdr["zacasno"]);
                        c_smeti = Convert.ToString((int)rdr["zacasno"]);
                        c_greznica = Convert.ToString((int)rdr["zacasno"]);
                        c_cadis = Convert.ToString((int)rdr["zacasno"]);

                        // string za zapis
                        str_zapisi = c_hsmid + csv + c_ulica + csv + c_labela + csv + c_naslov + csv + c_stalno + csv + c_zacasno + csv + c_voda + csv + c_kanalizacija + csv + c_smeti + csv + c_greznica + csv + c_cadis;
                        writetext.WriteLine(str_zapisi,Encoding.ASCII);
                    }
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Napaka reader: " + ex2.Message);
            }

            finally
            {
                // MessageBox.Show("finnaly");
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (con != null)
                {
                    con.Close();
                }
                MessageBox.Show("Zapis v CSV končan!");
                //Display_hise();
            }


        }

        private void Manjkavcadis()
        {
            
            
            // Stavbe ki manjkajo v Cadis
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from tbl_hise where cadis = 0", con);
            int tmpcadis = 0;
            adapt.Fill(dt);
            dgv1.DataSource = dt;
            con.Close();
            label18.Text = dgv1.Rows.Count.ToString();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            Manjkavcadis();
        }

        private void Obdelaj_sql()
        {
            // obdelaj vse sql baze
            if (countcrp > 0 && counths > 0 && countul > 0 && countna > 0 && countcad > 0)
            {
                Hsmid_crp();
                Beri_hs();
                Cadis_v_stavbe();
                Manjkavcadis();
            }
            else
                MessageBox.Show("Napaka v eno od SQL datotek!");

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Obdelaj_sql();
        }

        private void Cadis_v_stavbe()
        {
            // prenesi Cadisova podatke v tbl_hise
            int st = 0;
            string q2;
            //SqlConnection con2 = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\KatApp\\Kataster\\data\\kataster.mdf;Integrated Security = True; Connect Timeout = 30");
            //SqlCommand cmd2;
            string q3;
            //SqlConnection con3 = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\KatApp\\Kataster\\data\\kataster.mdf;Integrated Security = True; Connect Timeout = 30");
            //SqlCommand cmd3;
            //SqlDataAdapter adapt;
            //SqlDataReader rdr = null;

            string thsmid, tindex_crp, ok_hsmid,tvodovodstr;
            Int32 tkanalizacija = 0, tgreznica = 0, tsmeti = 0;
            Int32 tvodovod = 0;
            int tid;



            try
            {
                string q = "select id,hsmid,voda,kanalizacija,smeti from tbl_hise"; // preberi vse zapise iz tbl_hise

                cmd = new SqlCommand(q, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                string hsmid_hs;
                nivcadis = 0;
                while (rdr.Read())
                {
                    hsmid_hs = (string)rdr["hsmid"]; // hsmid po katerem boš iskal v cadis
                    tid = (Int32)rdr["id"];  // določi id v katerega boš pisal
                    // string tidx_crp = "";
                    // ok_hsmid = "";
                    //if (String.IsNullOrEmpty((string)rdr2["idx"]))
                    //{
                    //    MessageBox.Show("String = null " + st.ToString());
                    //}
                    try
                    {
                        cadis = 1;
                        string tmp_hsmid;
                        // preveri katere stavbe so sploh v cadisu
                        q2 = "select hsmid from tbl_cad where hsmid = @thsmid";  // če sta indexa iz ulic enaka
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@thsmid", hsmid_hs);
                        cmd2.ExecuteNonQuery();
                        tmp_hsmid = (string)cmd2.ExecuteScalar();
                        con2.Close();
                        if (tmp_hsmid==null)
                        {
                            tmp_hsmid = "99";
                            cadis = 0;
                            nivcadis++;
                            // MessageBox.Show(tmp_hsmid);
                        }

                        // poišči hsmid iz tbl_hise v tbl_cad
                        tkanalizacija = 0; tvodovod = 0; tgreznica = 0; tsmeti = 0;
                        q2 = "select vodovod from tbl_cad where hsmid = @thsmid";  // če sta indexa iz ulic enaka
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@thsmid", hsmid_hs);
                        cmd2.ExecuteNonQuery();
                        tvodovod = Convert.ToInt32(cmd2.ExecuteScalar());
                        con2.Close();

                        q2 = "select kanalizacija from tbl_cad where hsmid = @thsmid";  // če sta indexa iz ulic enaka
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@thsmid", hsmid_hs);
                        cmd2.ExecuteNonQuery();
                        tkanalizacija = Convert.ToInt32(cmd2.ExecuteScalar());
                        con2.Close();

                        q2 = "select greznica from tbl_cad where hsmid = @thsmid";  // če sta indexa iz ulic enaka
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@thsmid", hsmid_hs);
                        cmd2.ExecuteNonQuery();
                        tgreznica = Convert.ToInt32(cmd2.ExecuteScalar());
                        con2.Close();

                        q2 = "select smeti from tbl_cad where hsmid = @thsmid";  // če sta indexa iz ulic enaka
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@thsmid", hsmid_hs);
                        cmd2.ExecuteNonQuery();
                        tsmeti = Convert.ToInt32(cmd2.ExecuteScalar());
                        // tvodovod = Convert.ToInt32(tvodovodstr);
                        con2.Close();

                        //MessageBox.Show("tu");

                        // zapiši najdene vrednosti v datoteko tbl_hise - update

                        q3 = "update tbl_hise set cadis = @tcadis where id=@tid";
                        cmd3 = new SqlCommand(q3, con3);
                        con3.Open();
                        cmd3.Parameters.AddWithValue("@tcadis", cadis);
                        cmd3.Parameters.AddWithValue("@tid", tid);
                        cmd3.ExecuteNonQuery();
                        con3.Close();

                        q3 = "update tbl_hise set voda = @tvodovod where id=@tid";
                        cmd3 = new SqlCommand(q3, con3);
                        con3.Open();
                        cmd3.Parameters.AddWithValue("@tvodovod", tvodovod);
                        cmd3.Parameters.AddWithValue("@tid", tid);
                        cmd3.ExecuteNonQuery();
                        con3.Close();

                        q3 = "update tbl_hise set kanalizacija = @tkanalizacija where id=@tid";
                        cmd3 = new SqlCommand(q3, con3);
                        con3.Open();
                        cmd3.Parameters.AddWithValue("@tkanalizacija", tkanalizacija);
                        cmd3.Parameters.AddWithValue("@tid", tid);
                        cmd3.ExecuteNonQuery();
                        con3.Close();

                        q3 = "update tbl_hise set greznica = @tgreznica where id=@tid";
                        cmd3 = new SqlCommand(q3, con3);
                        con3.Open();
                        cmd3.Parameters.AddWithValue("@tgreznica", tgreznica);
                        cmd3.Parameters.AddWithValue("@tid", tid);
                        cmd3.ExecuteNonQuery();
                        con3.Close();

                        q3 = "update tbl_hise set smeti = @tsmeti where id=@tid";
                        cmd3 = new SqlCommand(q3, con3);
                        con3.Open();
                        cmd3.Parameters.AddWithValue("@tsmeti", tsmeti);
                        cmd3.Parameters.AddWithValue("@tid", tid);
                        cmd3.ExecuteNonQuery();
                        con3.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka: " + ex.Message);
                    }
                    st = ++st;
                    label17.Text = st.ToString();
                    label17.Refresh();
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Napaka reader: " + ex2.Message);
            }

            finally
            {
                // MessageBox.Show("finnaly");
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (con != null)
                {
                    con.Close();
                }
                // MessageBox.Show("pred displaydata");
                Display_hise();
            }
           // MessageBox.Show(Convert.ToString(nivcadis));
        }  // void

        private void button13_Click(object sender, EventArgs e)
        {
            // prenesi Cadisova podatke v tbl_hise
            Cadis_v_stavbe();

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Hsmid_crp()  // zapiši HSMID vsaki osebi v CRP
        {
            // HSMID -> CRP
            int st = 0, brezstavbe = 0;
            string q2;
           // SqlConnection con2 = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\KatApp\\Kataster\\data\\kataster.mdf;Integrated Security = True; Connect Timeout = 30");
            SqlCommand cmd2;

            SqlDataAdapter adapt;
            SqlDataReader rdr2 = null;
            string thsmid, tindex_crp, ok_hsmid,ok_namid;
            int tid;
            try
            {
                string q = "select id, index_crp,idx, hsmid from tbl_crp"; // preberi vse zapise iz tbl_crp

                cmd = new SqlCommand(q, con);
                con.Open();
                rdr2 = cmd.ExecuteReader();

                while (rdr2.Read())
                {
                    tid = (Int32)rdr2["id"];  // določi id v katerega boš pisal
                    string tidx_crp = "";
                    ok_hsmid = ""; ok_namid = "";
                    if (String.IsNullOrEmpty((string)rdr2["idx"]))
                    {
                        MessageBox.Show("String = null " + st.ToString());
                    }
                    else
                    {
                        tidx_crp = (string)rdr2["idx"];
                        //  MessageBox.Show("prebrani index iz CRP "+tidx_crp);
                    }
                    try
                    {
                        
                        // poišči index_crp v datoteki tbl_hs - index_hs
                        q2 = "select hs_mid, index_hs from tbl_hs where index_hs = @idx";  // če sta indexa iz ulic enaka
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@idx", tidx_crp);
                        cmd2.ExecuteNonQuery();
                        ok_hsmid = (string)cmd2.ExecuteScalar();  // ta hsmid zapiši v datoteko crp
                        // MessageBox.Show("Ta hsmid je našel v tbl_hs " + ok_hsmid);
                        if (ok_hsmid == null)
                        {
                            //MessageBox.Show("hsmid ne obstaja");
                            ok_hsmid = "99";
                            brezstavbe++;
                        }
                        else
                        {
                            //   MessageBox.Show("hsmid je ok");
                        }
                        con2.Close();

                        // poišči na_mid v datoteki tbl_hs
                        q2 = "select na_mid, index_hs from tbl_hs where index_hs = @idx";  // če sta indexa iz ulic enaka
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@idx", tidx_crp);
                        cmd2.ExecuteNonQuery();
                        ok_namid = (string)cmd2.ExecuteScalar();  // ta hsmid zapiši v datoteko crp
                       // MessageBox.Show("Ta na_mid je našel v tbl_hs " + ok_namid);
                        if (ok_namid == null)
                        {
                            //MessageBox.Show("hsmid ne obstaja");
                            ok_namid = "99";
                        }
                        con2.Close();


                        // preberi zapis ki ga boš updatal
                        //q2 = "select id from tbl_crp where id = @tid";
                        //cmd2 = new SqlCommand(q2, con2);
                        //cmd2.Parameters.AddWithValue("@tid", tid);
                        //cmd2.ExecuteNonQuery();
//                        MessageBox.Show("pred Napaka22");

                        // zapiši najdeni hsmid v datoteko crp - update
                        q2 = "update tbl_crp set hsmid = @thsmid, hs_na = @ths_na where id=@tid";
                        // MessageBox.Show("Ta hsmid bo zapisal v tbl_hs " + ok_hsmid);
                        cmd2 = new SqlCommand(q2, con2);
                        con2.Open();
                        cmd2.Parameters.AddWithValue("@thsmid", ok_hsmid);
                        cmd2.Parameters.AddWithValue("@ths_na", ok_namid);
                        cmd2.Parameters.AddWithValue("@tid", tid);
                        cmd2.ExecuteNonQuery();
                        con2.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka22: " + ex.Message);
                    }
                    st = ++st;
                    label4.Text = st.ToString();
                    label4.Refresh();
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Napaka reader: " + ex2.Message);
            }

            finally
            {
                // MessageBox.Show("finnaly");
                if (rdr2 != null)
                {
                    rdr2.Close();
                }
                if (con != null)
                {
                    con.Close();
                }
                // MessageBox.Show("pred displaydata");
                DisplayData_crp2();
                //MessageBox.Show("Prebivalcev brez določene stavbe: " + Convert.ToString(brezstavbe));
            }
        }  // void

        private void IzprazniBazo_cad()  // izprazni tabelo tbl_cad
        {
            string query = "delete from tbl_cad";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Izprazni_cad() // izprazni variable za tabelo tbl_ul
        {
            csmeti = 0; chsmid = ""; cnaziv = "";ckraj = "";culica = "";chs = "";cposta = "";cime_poste = "";cvodovod = 0;ckanalizacija = 0;cgreznica = 0;cdim = "";ctip_om = ""; 
        }

        private void Prenesi_cadis() // prenesi cadis.crp
        {
            // prenos CADIS

            {
                if (ncad == 0)
                {
                    // začni prenos
                    stevec = 0;
                    string cvodovodstr = "", ckanalizacijastr="", cgreznicastr="",csmetistr= "";
                    IzprazniBazo_cad();
                    // preberi ul - CSV
                    try
                    {
                        System.IO.StreamReader objReader;
                        objReader = new System.IO.StreamReader(fnamecad, ASCIIEncoding.UTF8);
                        // število vrstic v CSV
                        // ++stevec; // preskoči prvo vrstico
                        do
                        {
                            vrstica = "";
                            Izprazni_cad();
                            vrstica = vrstica + objReader.ReadLine() + "\r\n";
                            //vrstica = "";
                            // razdeli vrstico ločeno s ;
                            string[] polje = vrstica.Split(';');
                            chsmid = polje[0];
                            cnaziv = polje[1];
                            ckraj = polje[2];
                            culica = polje[3];
                            chs = polje[4];
                            cposta = polje[5];
                            cime_poste = polje[6];
                            cvodovodstr = polje[7];
                            ckanalizacijastr = polje[8];
                            cgreznicastr = polje[9];
                            csmetistr = polje[10];
                            //cvodovod = 1;ckanalizacija = 1;cgreznica = 1;csmeti = 1;
                            cdim = polje[11];
                            ctip_om = polje[12];
                            //source = source.Substring(0, length);
                            int dolzina = 999; // največja dolžina naziva
                            if (cnaziv.Length > dolzina)
                            {
                                cnaziv = cnaziv.Substring(0, 9);
                            }
                            try
                            {
                                if (stevec > 0)
                                {
                                    cvodovod = Int32.Parse(cvodovodstr);
                                    ckanalizacija = Int32.Parse(ckanalizacijastr);
                                    csmeti = Int32.Parse(csmetistr);
                                    cgreznica = Int32.Parse(cgreznicastr);
                                    // napiši prebrano v tabelo tbl_cad
                                    string query = "Insert into tbl_cad (hsmid,naziv,kraj,ulica,hs,posta,ime_poste,vodovod,kanalizacija,greznica,smeti,dimenzija,tip_om) values " +
                                        "(@chsmid,@cnaziv,@ckraj,@culica,@chs,@cposta,@cime_poste,@cvodovod,@ckanalizacija,@cgreznica,@csmeti,@cdimenzija,@ctip_om)";
                                    cmd = new SqlCommand(query, con);
                                    con.Open();
                                    cmd.Parameters.AddWithValue("@chsmid", chsmid);
                                    cmd.Parameters.AddWithValue("@cnaziv", cnaziv);
                                    cmd.Parameters.AddWithValue("@ckraj", ckraj);
                                    cmd.Parameters.AddWithValue("@culica",culica );
                                    cmd.Parameters.AddWithValue("@chs",chs );
                                    cmd.Parameters.AddWithValue("@cposta",cposta );
                                    cmd.Parameters.AddWithValue("@cime_poste",cime_poste );
                                    cmd.Parameters.AddWithValue("@cvodovod", cvodovod);
                                    cmd.Parameters.AddWithValue("@ckanalizacija", ckanalizacija);
                                    cmd.Parameters.AddWithValue("@cgreznica", cgreznica);
                                    cmd.Parameters.AddWithValue("@csmeti", csmeti);
                                    cmd.Parameters.AddWithValue("@cdimenzija",cdim );
                                    cmd.Parameters.AddWithValue("@ctip_om",ctip_om );
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Napaka: " + ex.Message);
                            }
                            stevec = ++stevec;
                            vrstica = "";
                            label11.Text = stevec.ToString();
                            label11.Refresh();
                        } while (objReader.Peek() != -1);
                        objReader.Close();
                        stevec--;
                        label11.Text = stevec.ToString();
                        label11.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka1: " + ex.Message);
                    }
                    finally
                    {
                        Displaydata_cad();
                    }
                }
                else
                {
                    MessageBox.Show("Napaka! Datoteka ne obstaja: " + fnamecad);
                }


            }
        } // private void

            private void button10_Click(object sender, EventArgs e)  // prenesi cadis.crp
        {
            Prenesi_cadis();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // HSMID -> CRP
            if (countcrp>0 && counths>0 && countul>0 && countna>0 && countcad>0)
            {
                Hsmid_crp();
            }
            else
            {
                MessageBox.Show("Napaka! Nekatere datoteke s podatki iz CSV so prazne");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Obdelaj_pt();
        }

        private void IzprazniBazo_hise()  // izprazni tabelo tbl_crp
        {
            string query = "delete from tbl_hise";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Beri_hs()  // zapiši datoteko hiše
        {
            int st = 0;
            IzprazniBazo_hise();
           // SqlConnection con2 = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\KatApp\\Kataster\\data\\kataster.mdf;Integrated Security = True; Connect Timeout = 30");
            SqlCommand cmd2;
            //SqlConnection con3 = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\KatApp\\Kataster\\data\\kataster.mdf;Integrated Security = True; Connect Timeout = 30");
            SqlCommand cmd3;
            SqlDataAdapter adapt;
            // preberi tbl_hs in zapiši v tbl_hise
            SqlDataReader rdr = null;
            SqlDataReader rdr2 = null;

            string tulmid, thsmid, ths, thd, tlabela, tna_mid, tpt_mid, tpo_mid, tposta, tpt_stev,tsx,tsy,tindex_hs;
            float tx,ty;
            try
            {
                string q = "select hs_mid, ulmid, hs, hd,labela,ulmid,na_mid,pt_mid,po_mid,x,y,index_hs from tbl_hs";
                cmd = new SqlCommand(q, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    tnaslov = "";
                    thsmid = (string)rdr["hs_mid"];
                    ths= (string)rdr["hs"];
                    thd = (string)rdr["hd"];
                    tlabela = (string)rdr["labela"];
                    tulmid = (string)rdr["ulmid"];
                    tna_mid = (string)rdr["na_mid"];
                    tpt_mid = (string)rdr["pt_mid"];
                    tpo_mid = (string)rdr["po_mid"];
                    tsx = (string)rdr["x"];
                    tsy = (string)rdr["y"];
                    tx = float.Parse(tsx);
                    ty = float.Parse(tsy);
                    tindex_hs = (string)rdr["index_hs"];

                    // preberi ime ulice
                    string ime = "",  ulime = "", q2;
                    q2 = "select ul_uime from tbl_ul where ul_mid = @tulmid";
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@tulmid", tulmid); // preberi ulico
                    cmd2.ExecuteNonQuery();
                    ulime = (string)cmd2.ExecuteScalar();
                    if (ulime==null)
                    {
                        ulime = "";
                    }
                    con2.Close();

                    // preberi stpr
                    //q2 = "select priimek1, index_crp from tbl_crp where index_crp = @index_hs";
                    //cmd2 = new SqlCommand(q2, con2);
                    //con2.Open();
                    //cmd2.Parameters.AddWithValue("@index_hs", tindex_hs); // preberi ulico
                    //cmd2.ExecuteNonQuery();
                    //ime = (string)cmd2.ExecuteScalar();
                    //MessageBox.Show(ime);
                    //if (ime == null)
                    //{
                    //    ime = "";
                    //}
                    //con2.Close();

                    // preberi ime naselja
                    string naime = "";
                    q2 = "select na_uime from tbl_na where na_mid = @tna_mid";
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@tna_mid", tna_mid); // preberi ulico
                    cmd2.ExecuteNonQuery();
                    naime = (string)cmd2.ExecuteScalar();
                    if (naime == null)
                    {
                        naime = "";
                    }
                    con2.Close();

                    // preberi pošto
                    string ptime = "";
                    q2 = "select pt_uime from tbl_pt where pt_mid = @tpt_mid";
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@tpt_mid", tpt_mid); // preberi ulico
                    cmd2.ExecuteNonQuery();
                    tposta = (string)cmd2.ExecuteScalar();
                    if (tposta == null)
                    {
                        tposta = "";
                    }
                    q2 = "select pt_id from tbl_pt where pt_mid = @tpt_mid";
                    cmd2 = new SqlCommand(q2, con2);
//                    con2.Open();
                    cmd2.Parameters.AddWithValue("@tpt_mid", tpt_mid); // preberi ulico
                    cmd2.ExecuteNonQuery();
                    tpt_stev = (string)cmd2.ExecuteScalar();
                    if (tpt_stev == null)
                    {
                        tpt_stev = "";
                    }
                    con2.Close();

                    // preberi koliko stalnih je na tem naslovu
                    // po thsmid

                    //string q = "select hs_mid, ulmid, hs, hd,labela,ulmid,na_mid,pt_mid,po_mid,x,y,index_hs from tbl_hs";
                    //cmd = new SqlCommand(q, con);
                    //con.Open();
                    //rdr = cmd.ExecuteReader();
                    //while (rdr.Read()) ;

                    ArrayList seznam_stpr = new ArrayList();
                    ArrayList seznam_zcpr = new ArrayList();
                    int x = 0;
                    q2 = "select * from tbl_crp where hsmid = @thsmid";
                    cmd2 = new SqlCommand(q2, con2);
                    con2.Open();
                    cmd2.Parameters.AddWithValue("@thsmid", thsmid);
                    rdr2 = cmd2.ExecuteReader();
                    stevec_zacasno = 0; stevec_stalno = 0;
                    while (rdr2.Read())
                    {
                        temp_zacasno = 0; temp_stalno = 0;
//                        temp_zacasno = (int)rdr["zacasno"];
                        temp_zacasno = Convert.ToInt32(rdr2[34]); // sprememnjeno zaradi dodatnega polja
                        temp_stalno = Convert.ToInt32(rdr2[35]);
  //                      temp_stalno = (int)rdr["stalno"];
                        stevec_zacasno = stevec_zacasno + temp_zacasno;
                        stevec_stalno = stevec_stalno + temp_stalno;

                        //seznam_stpr.Add(rdr2[27].ToString());
                        //seznam_zcpr.Add(rdr2[28].ToString());
                       // MessageBox.Show("stpr " + rdr2[28].ToString());
                        //MessageBox.Show("stpr "+ rdr2[28].ToString() +" zcpr "+ rdr2[29].ToString());

                        x++;
                    }
                    con2.Close();
                    int stevec = 0, stalnih=0, zacasnih=0, nasel=0;
                    //while (stevec<x)
                    //{
                    //    nasel = 0; // ali je našel zadetek
                    //    //MessageBox.Show("seznam stpr -" + seznam_stpr[stevec] + "- seznam zcpr -" + seznam_zcpr[stevec]+"-");

                    //    if (String.Equals(seznam_stpr[stevec],seznam_zcpr[stevec]))
                    //    {
                    //        // ima samo zacasno prebivališče
                    //        zacasnih++;
                    //        // MessageBox.Show("ima začasno");
                    //        nasel = 1;
                    //    }
                    //    else
                    //    {
                    //        stalnih++;
                    //    }
                    //    stevec++;
                    //}
                    //if (stalnih>0 || zacasnih>0)
                    //    {
                    //    MessageBox.Show(thsmid + " stalnih " + Convert.ToString(stalnih) + " zacasnih " + Convert.ToString(zacasnih));
                    //    }

                    stalnih = stevec_stalno;
                    zacasnih = stevec_zacasno;
                    //tulmid = (string)rdr["ulmid"];
                    //tna_mid = (string)rdr["na_mid"];
                    tnaslov = ulime;
                    if (ulime == "")
                        tnaslov = naime;
                    // zapiši v hiše
                    //if (tnaslov=="Trate" && tlabela=="37")
                          // MessageBox.Show(tnaslov + " "+tlabela+" stalno " + Convert.ToString(stevec_stalno) + " začasno " + Convert.ToString(stevec_zacasno));

                    try
                    {
                        string q3 = "insert into tbl_hise(hsmid,ulmid,ulica,hs,hd,naslov,labela,namid,naselje,pt_stev,posta,obcina,x,y,stalno,zacasno) values(@hsmid,@ulmid,@ulica,@hs,@hd,@naslov,@labela,@namid,@naselje,@pt_stev,@posta,@obcina,@x,@y,@stalno,@zacasno)";
                        cmd3 = new SqlCommand(q3, con3);
                        con3.Open();
                        cmd3.Parameters.AddWithValue("@hsmid", thsmid);
                        cmd3.Parameters.AddWithValue("@ulmid", tulmid);
                        cmd3.Parameters.AddWithValue("@ulica", ulime);
                        cmd3.Parameters.AddWithValue("@hs", ths);
                        cmd3.Parameters.AddWithValue("@hd", thd);
                        cmd3.Parameters.AddWithValue("@naslov", tnaslov);
                        cmd3.Parameters.AddWithValue("@labela", tlabela);
                        cmd3.Parameters.AddWithValue("@namid", tna_mid);
                        cmd3.Parameters.AddWithValue("@naselje", naime);
                        cmd3.Parameters.AddWithValue("@pt_stev", tpt_stev);
                        cmd3.Parameters.AddWithValue("@posta", tposta);
                        cmd3.Parameters.AddWithValue("@obcina", "Gornja Radgona");
                        cmd3.Parameters.AddWithValue("@x", tx);
                        cmd3.Parameters.AddWithValue("@y", ty);
                        cmd3.Parameters.AddWithValue("@stalno", stalnih);
                        cmd3.Parameters.AddWithValue("@zacasno", zacasnih);
                        cmd3.ExecuteNonQuery();
                        con3.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka: " + ex.Message);
                    }
                    st = ++st;
                    label5.Text = st.ToString();
                    label5.Refresh();
                }
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
                Display_hise();
            }
        }

        private void btnhise_Click(object sender, EventArgs e)
        {
            if (countcrp > 0 && counths > 0 && countul > 0 && countna > 0 && countcad > 0)
            {
                Beri_hs();
            }
            else
            {
                MessageBox.Show("Napaka! Nekatere datoteke s podatki iz CSV so prazne");
            }

            // zapiši stavbe
        }

        private void button5_Click(object sender, EventArgs e)  // obdelaj vse baze naenkrat
        {
            if (ncrp == 0 && nhs == 0 && nul == 0 && nna == 0 && npt==0 && ncad==0)
            {
                Obdelaj_pt();
                //Obdelaj_na();
                //Obdelaj_ul();
                //Obdelaj_hs();
                //Obdelaj_crp();
                //Prenesi_cadis();
                Obdelaj_aglo();

                //Obdelaj_sql();
                MessageBox.Show("Končano! Podatki so pripravljeni.");
            }
            else
            {
                MessageBox.Show("Vse potrebne datoteke niso na voljo!");
            }
        }

        // variable tbl_ul
        string ul_mid = "", ob_uime = "", na_uime = "", ul_uime = "";

        // variable tbl_na
        string ob2_uime = "", na2_uime = "", na2_mid = "";
        float povrsina = 0;

        private void frmBaze_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dskat2.tbl_ul' table. You can move, or remove it, as needed.
            label8.Text = ""; // zapisov crp
            label51.Text = ""; label52.Text = ""; label24.Text = ""; label23.Text = ""; label22.Text = ""; label21.Text = "";label4.Text = "";label17.Text = "";
            label9.Text = ""; label13.Text = ""; label10.Text = ""; label14.Text = ""; label5.Text = "";label11.Text = "";label18.Text="" ;
            //Prikazi_bazo();
            // Preberi_bazo();
            Preveri_baze();
            St_zapisov();
            Display_hise();
        }

        // napiši število zapisov

        private void St_zapisov()
        {
            Int32 count = 0;
            string query;
            // crp
            query = "select count(*) from tbl_crp";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            count = (Int32)cmd.ExecuteScalar();
            con.Close();
            countcrp = count;
            count = 0;

            // crp
            query = "select count(*) from tbl_ul";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            count = (Int32)cmd.ExecuteScalar();
            con.Close();
            countul = count;
            count = 0;

            query = "select count(*) from tbl_hs";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            count = (Int32)cmd.ExecuteScalar();
            con.Close();
            counths = count;
            count = 0;

            query = "select count(*) from tbl_na";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            count = (Int32)cmd.ExecuteScalar();
            con.Close();
            countna = count;
            count = 0;

            query = "select count(*) from tbl_pt";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            count = (Int32)cmd.ExecuteScalar();
            con.Close();
            countpt = count;
            count = 0;

            query = "select count(*) from tbl_cad";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            count = (Int32)cmd.ExecuteScalar();
            con.Close();
            countcad = count;
            count = 0;

        }

        public frmBaze()
        {
            InitializeComponent();
        }

        void Displaydata_cad()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from tbl_cad", con);
            adapt.Fill(dt);
            dgv1.DataSource = dt;
            con.Close();
        }

        void Display_hise()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from tbl_hise", con);
            adapt.Fill(dt);
            dgv1.DataSource = dt;
            con.Close();
        }
        void DisplayData_pt()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from tbl_pt", con);
            adapt.Fill(dt);
            dgv1.DataSource = dt;
            con.Close();
        }
        void DisplayData_ul()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from tbl_ul", con);
            adapt.Fill(dt);
            dgv1.DataSource = dt;
            con.Close();
        }
        void DisplayData_hs()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from tbl_hs", con);
            adapt.Fill(dt);
            dgv1.DataSource = dt;
            con.Close();
        }
        void DisplayData_crp()
        {
            // MessageBox.Show("displaydata_crp");
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from tbl_crp", con);
            adapt.Fill(dt);
            dgv1.DataSource = dt;
            con.Close();
        }
        void DisplayData_crp2()
        {
            // MessageBox.Show("displaydata_crp2");
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from tbl_crp", con);
            adapt.Fill(dt);
            dgv1.DataSource = dt;
            con.Close();
        }
        void DisplayData_na()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from tbl_na", con);
            adapt.Fill(dt);
            dgv1.DataSource = dt;
            con.Close();
        }

        // prenos CRP
        private void IzprazniBazo_crp()  // izprazni tabelo tbl_crp
        {
            string query = "delete from tbl_crp";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void izprazni_crp() // izprazni variable za bazo
        {
            emso = ""; spol = ""; priimek1 = ""; priimek2 = ""; ime1 = ""; ime2 = ""; drzava = ""; obcina_roj = ""; naselje_roj = "";
            drzava_roj = ""; naselje_stpr = ""; ulica_stpr = ""; hs_stpr = ""; hsd_stpr = ""; posta_stpr = ""; naziv_poste_stpr = "";
            ulica_zcpr = ""; hs_zcpr = ""; hsd_zcpr = ""; posta_zcpr = ""; naziv_poste_zcpr = ""; status_preb = ""; stan = "";
            dat_roj = ""; datom_od_zcpr = "";
        }

        private void Obdelaj_crp()  
        {
            // string lcaseidxtemp, lcaseidxtempz;
            if (ncrp == 0)
            {
                stevec = 0;
                IzprazniBazo_crp();
                // preberi CRP - CSV
                try
                {
                    System.IO.StreamReader objReader;
                    objReader = new System.IO.StreamReader(fnamecrp, ASCIIEncoding.UTF8);
                    // število vrstic v CSV
                    do
                    {
                        vrstica = "";
                        string idxulica = "";
                        string idxulica_s = "";
                        string idxulica_z = "";
                        izprazni_crp();
                        vrstica = vrstica + objReader.ReadLine() + "\r\n";
                        // razdeli vrstico ločeno s ;
                        string[] polje = vrstica.Split(';');
                        emso = polje[0];
                        spol = polje[1];
                        dat_roj = polje[2];
                        priimek1 = polje[3];
                        priimek2 = polje[4];
                        ime1 = polje[5];
                        ime2 = polje[6];
                        drzava = polje[7];
                        obcina_roj = polje[9];
                        naselje_roj = polje[10];
                        drzava_roj = polje[11];
                        naselje_stpr = polje[13];
                        ulica_stpr = polje[14];
                        hs_stpr = polje[15];
                        hsd_stpr = polje[16];
                        posta_stpr = polje[17];
                        naziv_poste_stpr = polje[18];
                        ulica_zcpr = polje[19];
                        hs_zcpr = polje[20];
                        hsd_zcpr = polje[21];
                        posta_zcpr = polje[22];
                        naziv_poste_zcpr = polje[23];
                        datom_od_zcpr = polje[24];
                        status_preb = polje[25];
                        stan = polje[26];

                        // napiši prebrano v tabelo crp
                        try
                        {
                            if (stevec > 0)  // preskoči prvo vrstico
                            {
                                // naredi indekse

                                // indeks crp - vsi ga morajo imeti iz radgonske občine
                                string stalno = "Ima samo stalno prebivališče";
                                string zacasno = "Ima samo začasno prebivališče";
                                string oboje = "Ima stalno in začasno prebivališče";
                                string izbira = status_preb;
                                string namid_ok = ""; // na_mid, ki se bo zapisal v bazo crp
                                string naselje_ok = ""; // ime naselja, ki se bo zapisalo v bazo
                                string idxtemp = ""; 
                                string idxt = "";
                                string lcaseidxtemp = "";
                                string lcaseidxtempz = "";
                                int tzacasno = 0;  
                                int tstalno=0;

                                if (izbira == stalno)
                                {
                                    // če ima samo stalno je sigurno v radgoni
                                    idxtemp = ulica_stpr + hs_stpr + hsd_stpr;
                                    idxtemp = string.Join("", idxtemp.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries)); // odstrani presledke
                                    lcaseidxtemp = idxtemp.ToLower(); // v male črke
                                    idxt = lcaseidxtemp;
                                    idxulica_s = ulica_stpr;
                                    idxulica = ulica_stpr;
                                    idxulica_z="99";
                                    lcaseidxtempz = "99";
                                    tzacasno = 0;
                                    tstalno = 1;
                                }

                                if (izbira == zacasno)
                                {
                                    // če ima samo začasno je sigurno v radgoni
                                    idxtemp = ulica_zcpr + hs_zcpr + hsd_zcpr;
                                    idxtemp = string.Join("", idxtemp.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries)); // odstrani presledke
                                    lcaseidxtemp = idxtemp.ToLower(); // v male črke
                                    idxt = lcaseidxtemp;
                                    idxulica = ulica_zcpr;
                                    idxulica_s = ulica_zcpr;
                                    idxulica_z = ulica_zcpr;
                                    lcaseidxtempz = lcaseidxtemp;
                                    tzacasno = 1;
                                    tstalno = 0;
                                }
                                if (izbira == oboje)
                                {
                                    // stalno
                                    idxtemp = ulica_stpr + hs_stpr + hsd_stpr;
                                    idxtemp = string.Join("", idxtemp.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries)); // odstrani presledke
                                    lcaseidxtemp = idxtemp.ToLower(); // v male črke

                                    // zacasno
                                    idxtempz = ulica_zcpr + hs_zcpr + hsd_zcpr;
                                    idxtempz = string.Join("", idxtempz.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries)); // odstrani presledke
                                    lcaseidxtempz = idxtempz.ToLower(); // v male črke
                                    //MessageBox.Show(lcaseidxtemp + " " + lcaseidxtempz);

                                    // če je idxtemp v indeksu HS je to pravi
                                    // preveri če je idxtemp v radgonski občini
                                    // če je -> idx = idxtemp, index_crp = idxtemp, index_crpz = idxtempz
                                    // če je stalno v radgonski občini daj idxtemp kot index_crp in idxtempz kot index_crpz
                                    natemp = "";
                                    int stpr_v_gr = 0;
                                    string q = "select na_mid from tbl_hs where index_hs = @indeks";

                                    cmd = new SqlCommand(q, con);
                                    con.Open();
                                    cmd.Parameters.AddWithValue("@indeks", lcaseidxtemp); // preberi naselje
                                    cmd.ExecuteNonQuery();
                                    natemp = (string)cmd.ExecuteScalar();
                                    con.Close();
                                    tstalno = 1;
                                    if (natemp==null)
                                    {
                                        // nič ni našel, začasno je v radgoni
                                       // MessageBox.Show("nič ni našel " + natemp);
                                        stpr_v_gr = 0;
                                        idxt = lcaseidxtempz;
                                        idxulica = ulica_zcpr;
                                        tzacasno = 1;
                                        tstalno = 0;
                                        //tzacasno = 0;
                                        //tstalno = 1;
                                    }

                                    if (natemp !=null)
                                    {
                                        // našel je zapis - stalno je v radgoni ampak 
                                        stpr_v_gr = 1;
                                        idxt = lcaseidxtemp;
                                        idxulica = ulica_stpr;
                                        tzacasno = 0;
                                        tstalno = 1;
                                        //tzacasno = 1;
                                        //tstalno = 0;
                                    }
                                }
                                // konec indeksov
                                naselje_ok = idxulica;

                                naselje_ok = "Gornja Radgona";
                                namid_ok = "10092752"; // MID od radgone

                                // poglej če je idxulica med naselji, če ni je gornja radgona
                                SqlDataReader rdr = null;
                                try
                                {
                                    string q = "select na_mid, na_uime from tbl_na where na_uime = @tnauime";
                                    cmd = new SqlCommand(q, con);
                                    con.Open();
                                    cmd.Parameters.AddWithValue("@tnauime", idxulica); // preberi naselje
                                    rdr = cmd.ExecuteReader();
                                    while (rdr.Read())
                                    {
                                        namid_ok = (String)rdr["na_mid"];  // določi namid stalnega
                                        naselje_ok = (String)rdr["na_uime"];  // določi naselje stalnega
                                    }
                                }
                                catch (Exception ex2)
                                {
                                    MessageBox.Show("Napaka reader: " + ex2.Message);
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

                                tindeks_osebe = dat_roj + priimek1 + ime1 + lcaseidxtemp + lcaseidxtempz;
                                string query = "insert into tbl_crp(indeks_osebe,emso,spol,dat_roj,priimek1,priimek2,ime1,ime2,drzava," +
                                "               obcina_roj,naselje_roj,drzava_roj,naselje_stpr,ulica_stpr,hs_stpr,hsd_stpr,posta_stpr,naziv_poste_stpr,ulica_zcpr,hs_zcpr,hsd_zcpr," +
                                "               posta_zcpr,naziv_poste_zcpr,datom_od_zcpr,status_preb,stan,index_crp,index_crpz,idx,zacasno,stalno,na_s,na_z) values(@indeks_osebe,@emso,@spol,@dat_roj,@priimek1,@priimek2," +
                                "               @ime1,@ime2,@drzava,@obcina_roj,@naselje_roj,@drzava_roj,@naselje_stpr,@ulica_stpr,@hs_stpr, @hsd_stpr, @posta_stpr, @naziv_poste_stpr," +
                                "               @ulica_zcpr, @hs_zcpr, @hsd_zcpr, @posta_zcpr, @naziv_poste_zcpr, @datom_od_zcpr, @status_preb, @stan,@index_crp,@index_crpz,@idx,@zacasno,@stalno,@na_s,@na_z)";
                                cmd = new SqlCommand(query, con);
                                con.Open();
                                cmd.Parameters.AddWithValue("@emso", emso);
                                cmd.Parameters.AddWithValue("@indeks_osebe", tindeks_osebe);
                                cmd.Parameters.AddWithValue("@spol", spol);
                                cmd.Parameters.AddWithValue("@dat_roj", dat_roj);
                                cmd.Parameters.AddWithValue("@priimek1", priimek1);
                                cmd.Parameters.AddWithValue("@priimek2", priimek2);
                                cmd.Parameters.AddWithValue("@ime1", ime1);
                                cmd.Parameters.AddWithValue("@ime2", ime2);
                                cmd.Parameters.AddWithValue("@drzava", drzava);
                                cmd.Parameters.AddWithValue("@obcina_roj", obcina_roj);
                                cmd.Parameters.AddWithValue("@naselje_roj", naselje_roj);
                                cmd.Parameters.AddWithValue("@drzava_roj", drzava_roj);
                                cmd.Parameters.AddWithValue("@naselje_stpr", naselje_stpr);
                                cmd.Parameters.AddWithValue("@ulica_stpr", ulica_stpr);
                                cmd.Parameters.AddWithValue("@hs_stpr", hs_stpr);
                                cmd.Parameters.AddWithValue("@hsd_stpr", hsd_stpr);
                                cmd.Parameters.AddWithValue("@posta_stpr", posta_stpr);
                                cmd.Parameters.AddWithValue("@naziv_poste_stpr", naziv_poste_stpr);
                                cmd.Parameters.AddWithValue("@ulica_zcpr", ulica_zcpr);
                                cmd.Parameters.AddWithValue("@hs_zcpr", hs_zcpr);
                                cmd.Parameters.AddWithValue("@hsd_zcpr", hsd_zcpr);
                                cmd.Parameters.AddWithValue("@posta_zcpr", posta_zcpr);
                                cmd.Parameters.AddWithValue("@naziv_poste_zcpr", naziv_poste_zcpr);
                                cmd.Parameters.AddWithValue("@datom_od_zcpr", datom_od_zcpr);
                                cmd.Parameters.AddWithValue("@status_preb", status_preb);
                                cmd.Parameters.AddWithValue("@stan", stan);
                                cmd.Parameters.AddWithValue("@index_crp", lcaseidxtemp);
                                cmd.Parameters.AddWithValue("@index_crpz", lcaseidxtempz); //lcaseidxtempz
                                cmd.Parameters.AddWithValue("@idx", idxt); //lcaseidxtempz
                                cmd.Parameters.AddWithValue("@zacasno", tzacasno); // 1 ali 0
                                cmd.Parameters.AddWithValue("@stalno", tstalno); //lcaseidxtempz
                                cmd.Parameters.AddWithValue("@na_s", namid_ok);
                                cmd.Parameters.AddWithValue("@na_z", naselje_ok);
                                // cmd.Parameters.AddWithValue("@idx", idxt); //lcaseidxtempz

                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Napaka: " + ex.Message);
                        }
                        // MessageBox.Show("emso " + emso + " spol " + spol + " priimek1 " + priimek1);
                        vrstica = "";
                        stevec = ++stevec;
                        label8.Text = stevec.ToString();
                        label8.Refresh();
                    } while (objReader.Peek() != -1);
                    objReader.Close();
                    stevec--;
                    label8.Text = stevec.ToString();
                    label8.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: " + ex.Message);
                }
                finally
                {
                    DisplayData_crp();
                }
            }
            else
            {
                MessageBox.Show("Napaka! Datoteka ne obstaja: " + fnamecrp);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Obdelaj_crp();
        }
        // konec prenos CRP

        // prenos HS
        private void IzprazniBazo_hs()  // izprazni tabelo tbl_hs
        {
            string query = "delete from tbl_hs";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Izprazni_hs() // izprazni variable za tabelo tbl_ul
        {
            index_hs = ""; enota = ""; hs_mid = ""; hs = ""; hd = ""; labela = ""; ulmid = ""; na_mid = ""; ob_mid = ""; pt_mid = ""; po_mid = ""; x = ""; y = "";
        }
        private void Obdelaj_hs()
        {
            if (nhs == 0)
            {
                stevec = 0;
                IzprazniBazo_hs();
                // preberi HS - CSV
                try
                {
                    System.IO.StreamReader objReader;
                    objReader = new System.IO.StreamReader(fnamehs, ASCIIEncoding.UTF8);
                    // število vrstic v CSV
                    do
                    {
                        vrstica = "";
                        Izprazni_hs();
                        vrstica = vrstica + objReader.ReadLine() + "\r\n";
                        // MessageBox.Show(vrstica);

                        // razdeli vrstico ločeno s ;
                        string[] polje = vrstica.Split(';');
                        enota = polje[1];
                        hs_mid = polje[2];
                        hs = polje[3];
                        hd = polje[4];
                        labela = polje[5];
                        ulmid = polje[6];
                        na_mid = polje[7];
                        ob_mid = polje[8];
                        pt_mid = polje[9];
                        po_mid = polje[10];
                        y = polje[14];
                        x = polje[15];
                        // napiši prebrano v tabelo crp
                        try
                        {
                            if (stevec > 0)
                            {
                                // naredi indekse
                                idxtemp = ""; natemp = ""; ultemp = "";
                                string selecttemp = na_mid; // začasni na_mid
                                string q = "select na_uime, na_mid from tbl_na where na_mid = @selecttemp";
                                cmd = new SqlCommand(q, con);
                                con.Open();
                                cmd.Parameters.AddWithValue("@selecttemp", selecttemp); // preberi naselje
                                cmd.ExecuteNonQuery();
                                natemp = (string)cmd.ExecuteScalar();
                                con.Close();
                              //  MessageBox.Show("Naselje "+natemp);

                                selecttemp = ulmid; // začasni na_mid
                                q = "select ul_uime, ul_mid from tbl_ul where ul_mid = @selecttemp";
                                cmd = new SqlCommand(q, con);
                                con.Open();
                                cmd.Parameters.AddWithValue("@selecttemp", selecttemp); // preberi ulico
                                cmd.ExecuteNonQuery();
                                ultemp = (string)cmd.ExecuteScalar();
                                con.Close();
                                // MessageBox.Show("Naselje " + natemp+"  Ulica: +"+ultemp+"+");

                                if (ultemp == null)
                                {
                                    ultemp = natemp; // če ni ulice daj v indeks naselje
                                    // MessageBox.Show("Naselje v if" + natemp);
                                }

                                idxtemp = ultemp + hs + hd;
                                idxtemp = string.Join("", idxtemp.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries)); // odstrani presledke
                                string lcaseidxtemp = idxtemp.ToLower(); // v male črke
                                // konec indeksov

                                string query = "insert into tbl_hs (enota, hs_mid, hs, hd, labela, ulmid, na_mid, ob_mid, pt_mid, po_mid, y, x,index_hs) values(@enota, @hs_mid, @hs, @hd, @labela, @ulmid, @na_mid, @ob_mid, @pt_mid, @po_mid, @y, @x,@index_hs)";
                                cmd = new SqlCommand(query, con);
                                con.Open();
                                cmd.Parameters.AddWithValue("@enota", enota);
                                cmd.Parameters.AddWithValue("@hs_mid", hs_mid);
                                cmd.Parameters.AddWithValue("@hs", hs);
                                cmd.Parameters.AddWithValue("@hd", hd);
                                cmd.Parameters.AddWithValue("@labela", labela);
                                cmd.Parameters.AddWithValue("@ulmid", ulmid);
                                cmd.Parameters.AddWithValue("@na_mid", na_mid);
                                cmd.Parameters.AddWithValue("@ob_mid", ob_mid);
                                cmd.Parameters.AddWithValue("@pt_mid", pt_mid);
                                cmd.Parameters.AddWithValue("@po_mid", po_mid);
                                cmd.Parameters.AddWithValue("@y", y);
                                cmd.Parameters.AddWithValue("@x", x);
                                cmd.Parameters.AddWithValue("@index_hs", lcaseidxtemp);
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Napaka: " + ex.Message);
                        }
                        vrstica = "";
                        stevec = ++stevec;
                        label9.Text = stevec.ToString();
                        label9.Refresh();
                    } while (objReader.Peek() != -1);
                    objReader.Close();
                    stevec--;
                    label9.Text = stevec.ToString();
                    label9.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: " + ex.Message);
                }
                finally
                {
                    DisplayData_hs();
                }
            }
            else
            {
                MessageBox.Show("Napaka! Datoteka ne obstaja: " + fnamehs);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Obdelaj_hs();
        }
        // konec prenos HS

        // prenos UL

        private void IzprazniBazo_ul()  // izprazni tabelo tbl_ul
        {
            string query = "delete from tbl_ul";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Izprazni_ul() // izprazni variable za tabelo tbl_ul
        {
            ul_mid = ""; ob_uime = ""; na_uime = ""; ul_uime = "";
        }
        private void Obdelaj_ul()
        {
            if (nul == 0)
            {
                // začni prenos
                stevec = 0;
                IzprazniBazo_ul();
                // preberi ul - CSV
                try
                {
                    System.IO.StreamReader objReader;
                    objReader = new System.IO.StreamReader(fnameul, ASCIIEncoding.UTF8);
                    // število vrstic v CSV
                    // ++stevec; // preskoči prvo vrstico
                    do
                    {
                        vrstica = "";
                        Izprazni_ul();
                        vrstica = vrstica + objReader.ReadLine() + "\r\n";

                        // razdeli vrstico ločeno s ;
                        string[] polje = vrstica.Split(';');
                        ul_mid = polje[11];
                        ob_uime = polje[4];
                        na_uime = polje[9];
                        ul_uime = polje[14];
                        try
                        {
                            if (stevec > 0)
                            {
                                // napiši prebrano v tabelo ul
                                string query = "Insert into tbl_ul (ul_mid, ob_uime, na_uime, ul_uime) values (@ul_mid, @ob_uime, @na_uime, @ul_uime)";
                                cmd = new SqlCommand(query, con);
                                con.Open();
                                cmd.Parameters.AddWithValue("@ul_mid", ul_mid);
                                cmd.Parameters.AddWithValue("@ob_uime", ob_uime);
                                cmd.Parameters.AddWithValue("@na_uime", na_uime);
                                cmd.Parameters.AddWithValue("@ul_uime", ul_uime);
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Napaka: " + ex.Message);
                        }
                        stevec = ++stevec;
                        vrstica = "";
                        label10.Text = stevec.ToString();
                        label10.Refresh();
                    } while (objReader.Peek() != -1);
                    objReader.Close();
                    stevec--;
                    label10.Text = stevec.ToString();
                    label10.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: " + ex.Message);
                }
                finally
                {
                    DisplayData_ul();
                }
            }
            else
            {
                MessageBox.Show("Napaka! Datoteka ne obstaja: " + fnameul);
            }

        }
        private void button3_Click(object sender, EventArgs e) // prenos z SQL
        {
            Obdelaj_ul();
        }
        // konec prenos UL

        // prenos NA

        private void IzprazniBazo_na()  // izprazni tabelo tbl_na
        {
            string query = "delete from tbl_na";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Izprazni_na() // izprazni variable za tabelo tbl_na
        {
            ob2_uime = ""; na2_uime = ""; povrsina = 0; na2_mid = "";
        }

        private void Obdelaj_na()
        {
            if (nna == 0)
            {
                // začni prenos
                stevec = 0;
                IzprazniBazo_na();
                string povrsinastr = "";

                try
                {
                    System.IO.StreamReader objReader;
                    objReader = new System.IO.StreamReader(fnamena, ASCIIEncoding.UTF8);
                    do
                    {
                        vrstica = "";
                        Izprazni_na();
                        vrstica = vrstica + objReader.ReadLine() + "\r\n";

                        // razdeli vrstico ločeno s ;
                        string[] polje = vrstica.Split(';');
                        ob2_uime = polje[3];
                        na2_uime = polje[8];
                        na2_mid = polje[5];
                        povrsinastr = polje[11];
                        try
                        {
                            if (stevec > 0)
                            {
                                // napiši prebrano v tabelo ul
                                povrsina = float.Parse(povrsinastr);
                                string query = "insert into tbl_na (ob_uime, na_uime, povrsina,na_mid) values(@ob_uime, @na_uime, @povrsina,@na_mid)";
                                cmd = new SqlCommand(query, con);
                                con.Open();
                                cmd.Parameters.AddWithValue("@ob_uime", ob2_uime);
                                cmd.Parameters.AddWithValue("@na_uime", na2_uime);
                                cmd.Parameters.AddWithValue("@povrsina", povrsina);
                                cmd.Parameters.AddWithValue("@na_mid", na2_mid);
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Napaka: " + ex.Message);
                        }
                        stevec = ++stevec;
                        vrstica = "";
                        label13.Text = stevec.ToString();
                        label13.Refresh();
                    } while (objReader.Peek() != -1);
                    objReader.Close();
                    stevec--;
                    label13.Text = stevec.ToString();
                    label13.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: " + ex.Message);
                }
                finally
                {
                    DisplayData_na();
                }

            }
            else
            {
                MessageBox.Show("Napaka! Datoteka ne obstaja: " + fnamena);
            }

        }
        private void button7_Click(object sender, EventArgs e)  // prenos NA
        {
            Obdelaj_na();
        }
        // konec prenos NA

        // prenos PT

        private void IzprazniBazo_pt()  // izprazni tabelo tbl_pt
        {
            string query = "delete from tbl_pt";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void IzprazniBazo_ag()  // izprazni tabelo tbl_pt
        {
            string query = "delete from tbl_aglo";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Izprazni_pt() // izprazni variable za tabelo tbl_na
        {
            pt_id = ""; pt_uime = ""; pt_mid = "";
        }
        private void Izprazni_ag() // izprazni variable za tabelo tbl_na
        {
            ag_id = ""; ag_ime = "";
        }

        private void Obdelaj_pt()
        {
            if (npt == 0)
            {
                // začni prenos
                stevec = 0;
                IzprazniBazo_pt();
                try
                {
                    System.IO.StreamReader objReader;
                    objReader = new System.IO.StreamReader(fnamept, ASCIIEncoding.UTF8);
                    do
                    {
                        vrstica = "";
                        Izprazni_pt();
                        vrstica = vrstica + objReader.ReadLine() + "\r\n";

                        // razdeli vrstico ločeno s ;
                        string[] polje = vrstica.Split(';');
                        pt_id = polje[3];
                        pt_uime = polje[4];
                        pt_mid = polje[2];
                        try
                        {
                            if (stevec > 0)
                            {
                                // napiši prebrano v tabelo pt
                                string query = "insert into tbl_pt (pt_id,pt_uime,pt_mid) values(@pt_id, @pt_uime,@pt_mid)";
                                cmd = new SqlCommand(query, con);
                                con.Open();
                                cmd.Parameters.AddWithValue("@pt_id", pt_id);
                                cmd.Parameters.AddWithValue("@pt_uime", pt_uime);
                                cmd.Parameters.AddWithValue("@pt_mid", pt_mid);
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Napaka: " + ex.Message);
                        }
                        stevec = ++stevec;
                        vrstica = "";
                        label14.Text = stevec.ToString();
                        label14.Refresh();
                    } while (objReader.Peek() != -1);
                    objReader.Close();
                    stevec--;
                    label14.Text = stevec.ToString();
                    label14.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: " + ex.Message);
                }
                finally
                {
                    DisplayData_pt();
                }

            }
            else
            {
                MessageBox.Show("Napaka! Datoteka ne obstaja: " + fnamena);
            }

        }

        private void button2_Click(object sender, EventArgs e) // zapri okno
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Preveri_baze()
        {
            // AGLO
            fnameag = mapa + "aglo.csv";
            fnameag2 = m1 + "aglo.csv";
            try
            {
                var lineCount = File.ReadAllLines(@fnameag).Length;
                lineCount--;
                //label2.Text = fnamecrp2;
                label51.Text = lineCount.ToString();
                nag = 0;
            }
            catch (Exception ex)
            {
                label52.Text = "Datoteka " + fnameag + " ne obstaja!";
                label51.Text = "0";
                nag = 1;
            }

            // CRP
            fnamecrp = mapa + "crp.csv";
            fnamecrp2 = m1 + "crp.csv";
            try
            {
                var lineCount = File.ReadAllLines(@fnamecrp).Length;
                lineCount--;
                label2.Text = fnamecrp2;
                label24.Text = lineCount.ToString();
                ncrp = 0;
            }
            catch (Exception ex)
            {
                label2.Text = "Datoteka "+fnamecrp+" ne obstaja!";
                label24.Text = "0";
                ncrp = 1;
            }
            // NA
            fnamena = mapa + "na.csv";
            fnamena2 = m1 + "na.csv";

            try
            {
                var lineCount = File.ReadAllLines(@fnamena).Length;
                lineCount--;
                label15.Text = fnamena2;
                label21.Text = lineCount.ToString();
                nna = 0;
            }
            catch (Exception ex)
            {
                label15.Text = "Datoteka " + fnamena + " ne obstaja!";
                label21.Text = "0";
                nna = 1;
            }
            // HS
            fnamehs = mapa + "hs.csv";
            fnamehs2 = m1 + "hs.csv";

            try
            {
                var lineCount = File.ReadAllLines(@fnamehs).Length;
                lineCount--;
                label3.Text = fnamehs2;
                label23.Text = lineCount.ToString();
                nhs = 0;
            }
            catch (Exception ex)
            {
                label3.Text = "Datoteka " + fnamehs + " ne obstaja!";
                label23.Text = "0";
                nhs = 1;
            }
            // UL
            fnameul = mapa + "ul.csv";
            fnameul2 = m1 + "ul.csv";

            try
            {
                var lineCount = File.ReadAllLines(@fnameul).Length;
                lineCount--;
                label12.Text = fnameul2;
                label22.Text = lineCount.ToString();
                nul = 0;
            }
            catch (Exception ex)
            {
                label12.Text = "Datoteka " + fnameul + " ne obstaja!";
                label22.Text = "0";
                nul = 1;
            }
            // pt
            fnamept = mapa + "pt.csv";
            fnamept2 = m1 + "pt.csv";

            try
            {
                var lineCount = File.ReadAllLines(@fnamept).Length;
                lineCount--;
                label25.Text = fnamept2;
                label6.Text = lineCount.ToString();
                npt = 0;
            }
            catch (Exception ex)
            {
                label25.Text = "Manjka " + fnameul;
                label6.Text = "0";
                npt = 1;
            }

            // cadis
            fnamecad = mapa + "cadis.csv";
            fnamecad2 = m1 + "cadis.csv";

            try
            {
                var lineCount = File.ReadAllLines(@fnamecad).Length;
                lineCount--;
                label16.Text = fnamecad2;
                label7.Text = lineCount.ToString();
                ncad = 0;
            }
            catch (Exception ex)
            {
                label16.Text = "Manjka " + fnamecad2;
                label7.Text = "0";
                ncad = 1;
            }
        }

        private void btnCrp_Click(object sender, EventArgs e) // odpri datoteko CRP
        {
            fd.Title = "Izberi datoteko s CRP";
            fd.InitialDirectory = frmMain.app_path_data;  // "C:\\KatApp\\Kataster\\data";
            fd.FileName = "crp.csv";

            // preberi ime datoteke iz dialoga
            if (fd.ShowDialog() == DialogResult.OK)
            {
                // preberi CRP - CSV
                try
                {
                    fnamecrp = fd.FileName;
                    var lineCount = File.ReadAllLines(@fnamecrp).Length;
                    label2.Text = fnamecrp;
                    label24.Text = lineCount.ToString();
                    ncrp = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napaka: " + ex.Message);
                    ncrp = 1;
                }
            }
            else
            {
                MessageBox.Show("Datoteka ne obstaja: " + fnamecrp);

            }

        }
    }
}
