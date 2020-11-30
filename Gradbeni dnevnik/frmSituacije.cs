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
using System.Collections;
//using System.Collections.Generic;

namespace Komunala
{
    public class MyFormBase : System.Windows.Forms.Form
    {
    }


    public partial class frmSituacije : Form
    {
        SqlConnection con = frmMain.c;
        SqlConnection con2 = frmMain.c2;
        SqlConnection con3 = frmMain.c3;
        SqlConnection con9 = frmMain.c9;

        SqlCommand cmd;
        SqlDataReader rdr = null;

        SqlCommand cmd2;
        SqlDataReader rdr2 = null;

        SqlCommand cmd3;
        SqlDataReader rdr3 = null;

        SqlCommand cmd9;
        SqlDataReader rdr9 = null;

        // spremenljivke
        public static int index_print;
        public static string sestavil, odobril,datum;


        bool prvic = true;
        string q, q2, q9, q3, oseba; // query
        string objekt, tmp_skupina, storitev, str_em, str_cena;
        int id_objekt, tmp_id_skupina, id_storitev, tzap, id_em, id_ddv,id_izbrane_situacije,dan,tmp_skupina_id;
        double float_ddv, float_cena,tmp_cena_obcina,tmp_kolicina,skupna_kolicina;
        // mreža
        string d_skupina_stor, d_storitev,d_em, msg_pocakaj;
        int d_zap,d_id;
        double d_cena, d_ddv, d_k1, d_k2, d_k3, d_k4, d_k5, d_k6, d_k7, d_k8, d_k9, d_k10, d_k11, d_k12;

        public static string str_objekt;
        // posebnosti za zimsko službo 28. 10. 2020
        public static bool zs = false; // ali je situacija za zimsko službo
        public static bool zs_prvic, zs_drugic;
        public static string str_zs;
        public static double zs_proc;  // procent delitve
        int id_zimska = 5; // id zimske službe v bazi tblDelovisca

        private frmPocakaj _waitForm;

        protected void ShowWaitForm(string message)
        {
            // don't display more than one wait form at a time
            if (_waitForm != null && !_waitForm.IsDisposed)
            {
                return;
            }

            _waitForm = new frmPocakaj();
            _waitForm.SetMessage(message); // "Loading data. Please wait..."
            _waitForm.TopMost = true;
            _waitForm.StartPosition = FormStartPosition.CenterScreen;
            _waitForm.Show();
            _waitForm.Refresh();

            // force the wait window to display for at least 700ms so it doesn't just flash on the screen
            System.Threading.Thread.Sleep(700);
            Application.Idle += OnLoaded;
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            Application.Idle -= OnLoaded;
            _waitForm.Close();
        }


        private void cb20_SelectedIndexChanged(object sender, EventArgs e)
        {
            // vnesi podpisnike v polja
            cb22.Text = frmMain.sit_pripravil;
            cb23.Text = frmMain.sit_odobril;
        }

        private void cb23_MouseClick(object sender, MouseEventArgs e)
        {
            cb23.DroppedDown = true;
        }

        private void cb22_MouseClick(object sender, MouseEventArgs e)
        {
            cb22.DroppedDown = true;
        }


        private void cb21_MouseClick(object sender, MouseEventArgs e)
        {
            cb21.DroppedDown = true;
        }

        private void cb20_MouseClick(object sender, MouseEventArgs e)
        {
            cb20.DroppedDown = true;
        }

        double d_k13, d_k14, d_k15, d_k16, d_k17, d_k18, d_k19, d_k20, d_k21, d_k22, d_k23, d_k24, d_k25, d_k26, d_k27, d_k28, d_k29, d_k30, d_k31;
        string sd_k1, sd_k2, sd_k3, sd_k4, sd_k5, sd_k6, sd_k7, sd_k8, sd_k9, sd_k10, sd_k11, sd_k12;
        string sd_k13, sd_k14, sd_k15, sd_k16, sd_k17, sd_k18, sd_k19, sd_k20, sd_k21, sd_k22, sd_k23, sd_k24;
        string sd_k25, sd_k26, sd_k27, sd_k28, sd_k29, sd_k30, sd_k31,sd_skupaj,sd_znesek;
        string id_situacije, t_mesec, t_leto, t_situacija, t_skupina;
        string str_mesec, str_leto,sd_cena,sd_zap, sd_ddv;
        double skupna_kolicina_za_mesec, skupna_kolicina_za_dan, d_skupaj, d_znesek;
        double k01, k02, k03, k04, k05, k06, k07, k08, k09, k010, k011, k012, k013, k014, k015, k016, k017, k018, k019, k020, k021, k022, k023, k024, k025, k026, k027, k028, k029, k030, k031;

        private void tblSituacija_tempBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }


        public frmSituacije()
        {
            InitializeComponent();
        }

        private void btnNazaj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmSituacije_Load(object sender, EventArgs e)
        {
            cb20.Items.Clear();
            cb20.ResetText();
            cb21.Items.Clear();
            cb21.ResetText();
            cb22.Items.Clear();
            cb22.ResetText();
            cb23.Items.Clear();
            cb23.ResetText();
            Zacetek();
        }

        private void Shrani_vrsto()
        {
                try
                {
                    //tzap++;
                    q9 = "insert into tblsituacija_temp(zap,skupina_id,skupina_stor,storitev,em,cena,ddv,k01,k02,k03,k04,k05,k06,k07,k08,k09,k010" +
                        ",k011,k012,k013,k014,k015,k016,k017,k018,k019,k020,k021,k022,k023,k024,k025,k026,k027,k028,k029,k030,k031,k_skupaj,znesek,mesec,leto,sestavil,odgovorni) " +
                        "values(@zap,@skupina_id,@skupina_stor,@storitev,@em,@cena,@ddv,@k01,@k02,@k03,@k04,@k05,@k06,@k07,@k08,@k09,@k010,@k011,@k012,@k013,@k014,@k015,@k016" +
                        ",@k017,@k018,@k019,@k020,@k021,@k022,@k023,@k024,@k025,@k026,@k027,@k028,@k029,@k030,@k031,@k_skupaj,@znesek,@mesec,@leto,@sestavil,@odgovorni)";
                    cmd9 = new SqlCommand(q9, con9);
                    con9.Open();
                    cmd9.Parameters.AddWithValue("@zap", tzap);
                    cmd9.Parameters.AddWithValue("@skupina_id", tmp_skupina_id);
                    cmd9.Parameters.AddWithValue("@skupina_stor", tmp_skupina);
                    cmd9.Parameters.AddWithValue("@storitev", storitev);
                    cmd9.Parameters.AddWithValue("@em", str_em);
                    cmd9.Parameters.AddWithValue("@cena", float_cena);
                    cmd9.Parameters.AddWithValue("@ddv", float_ddv);
                    cmd9.Parameters.AddWithValue("@k01", k01);
                    cmd9.Parameters.AddWithValue("@k02", k02);
                    cmd9.Parameters.AddWithValue("@k03", k03);
                    cmd9.Parameters.AddWithValue("@k04", k04);
                    cmd9.Parameters.AddWithValue("@k05", k05);
                    cmd9.Parameters.AddWithValue("@k06", k06);
                    cmd9.Parameters.AddWithValue("@k07", k07);
                    cmd9.Parameters.AddWithValue("@k08", k08);
                    cmd9.Parameters.AddWithValue("@k09", k09);
                    cmd9.Parameters.AddWithValue("@k010", k010);
                    cmd9.Parameters.AddWithValue("@k011", k011);
                    cmd9.Parameters.AddWithValue("@k012", k012);
                    cmd9.Parameters.AddWithValue("@k013", k013);
                    cmd9.Parameters.AddWithValue("@k014", k014);
                    cmd9.Parameters.AddWithValue("@k015", k015);
                    cmd9.Parameters.AddWithValue("@k016", k016);
                    cmd9.Parameters.AddWithValue("@k017", k017);
                    cmd9.Parameters.AddWithValue("@k018", k018);
                    cmd9.Parameters.AddWithValue("@k019", k019);
                    cmd9.Parameters.AddWithValue("@k020", k020);
                    cmd9.Parameters.AddWithValue("@k021", k021);
                    cmd9.Parameters.AddWithValue("@k022", k022);
                    cmd9.Parameters.AddWithValue("@k023", k023);
                    cmd9.Parameters.AddWithValue("@k024", k024);
                    cmd9.Parameters.AddWithValue("@k025", k025);
                    cmd9.Parameters.AddWithValue("@k026", k026);
                    cmd9.Parameters.AddWithValue("@k027", k027);
                    cmd9.Parameters.AddWithValue("@k028", k028);
                    cmd9.Parameters.AddWithValue("@k029", k029);
                    cmd9.Parameters.AddWithValue("@k030", k030);
                    cmd9.Parameters.AddWithValue("@k031", k031);
                    cmd9.Parameters.AddWithValue("@k_skupaj", skupna_kolicina_za_mesec);
                    cmd9.Parameters.AddWithValue("@znesek", skupna_kolicina_za_mesec * float_cena);
                    cmd9.Parameters.AddWithValue("@mesec", t_mesec);
                    cmd9.Parameters.AddWithValue("@leto", t_leto);
                    cmd9.Parameters.AddWithValue("@sestavil", "sestavil");
                    cmd9.Parameters.AddWithValue("@odgovorni", "odgovorni");
                    cmd9.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Shrani vrsto: " + ex.Message);
                }
                finally
                {
                    if (con9 != null)
                    {
                        con9.Close();
                    }
                }
        }

        private void Shrani_vrsto_skupino()
        {
            try
            {
                q9 = "insert into tblsituacija_temp(zap,skupina_id,skupina_stor,storitev,em,cena,ddv,k01,k02,k03,k04,k05,k06,k07,k08,k09,k010" +
                    ",k011,k012,k013,k014,k015,k016,k017,k018,k019,k020,k021,k022,k023,k024,k025,k026,k027,k028,k029,k030,k031,k_skupaj,znesek,mesec,leto,sestavil,odgovorni) " +
                    "values(@zap,@skupina_id,@skupina_stor,@storitev,@em,@cena,@ddv,@k01,@k02,@k03,@k04,@k05,@k06,@k07,@k08,@k09,@k010,@k011,@k012,@k013,@k014,@k015,@k016" +
                    ",@k017,@k018,@k019,@k020,@k021,@k022,@k023,@k024,@k025,@k026,@k027,@k028,@k029,@k030,@k031,@k_skupaj,@znesek,@mesec,@leto,@sestavil,@odgovorni)";
                cmd9 = new SqlCommand(q9, con9);
                con9.Open();
                cmd9.Parameters.AddWithValue("@zap", 0);
                cmd9.Parameters.AddWithValue("@skupina_id", tmp_skupina_id);
                cmd9.Parameters.AddWithValue("@skupina_stor", "________________");
                cmd9.Parameters.AddWithValue("@storitev", "");
                cmd9.Parameters.AddWithValue("@em", "");
                cmd9.Parameters.AddWithValue("@cena", 0);
                cmd9.Parameters.AddWithValue("@ddv", 0);
                cmd9.Parameters.AddWithValue("@k01", 0);
                cmd9.Parameters.AddWithValue("@k02", 0);
                cmd9.Parameters.AddWithValue("@k03", 0);
                cmd9.Parameters.AddWithValue("@k04", 0);
                cmd9.Parameters.AddWithValue("@k05", 0);
                cmd9.Parameters.AddWithValue("@k06", 0);
                cmd9.Parameters.AddWithValue("@k07", 0);
                cmd9.Parameters.AddWithValue("@k08", 0);
                cmd9.Parameters.AddWithValue("@k09", 0);
                cmd9.Parameters.AddWithValue("@k010", 0);
                cmd9.Parameters.AddWithValue("@k011", 0);
                cmd9.Parameters.AddWithValue("@k012", 0);
                cmd9.Parameters.AddWithValue("@k013", 0);
                cmd9.Parameters.AddWithValue("@k014", 0);
                cmd9.Parameters.AddWithValue("@k015", 0);
                cmd9.Parameters.AddWithValue("@k016", 0);
                cmd9.Parameters.AddWithValue("@k017", 0);
                cmd9.Parameters.AddWithValue("@k018", 0);
                cmd9.Parameters.AddWithValue("@k019", 0);
                cmd9.Parameters.AddWithValue("@k020", 0);
                cmd9.Parameters.AddWithValue("@k021", 0);
                cmd9.Parameters.AddWithValue("@k022", 0);
                cmd9.Parameters.AddWithValue("@k023", 0);
                cmd9.Parameters.AddWithValue("@k024", 0);
                cmd9.Parameters.AddWithValue("@k025", 0);
                cmd9.Parameters.AddWithValue("@k026", 0);
                cmd9.Parameters.AddWithValue("@k027", 0);
                cmd9.Parameters.AddWithValue("@k028", 0);
                cmd9.Parameters.AddWithValue("@k029", 0);
                cmd9.Parameters.AddWithValue("@k030", 0);
                cmd9.Parameters.AddWithValue("@k031", 0);
                cmd9.Parameters.AddWithValue("@k_skupaj", 0);
                cmd9.Parameters.AddWithValue("@znesek", 0);
                cmd9.Parameters.AddWithValue("@mesec", t_mesec);
                cmd9.Parameters.AddWithValue("@leto", t_leto);
                cmd9.Parameters.AddWithValue("@sestavil", "sestavil");
                cmd9.Parameters.AddWithValue("@odgovorni", "odgovorni");
                cmd9.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Shrani vrsto: " + ex.Message);
            }
            finally
            {
                if (con9 != null)
                {
                    con9.Close();
                }
            }

            // drugič
            try
            {
                q9 = "insert into tblsituacija_temp(zap,skupina_id,skupina_stor,storitev,em,cena,ddv,k01,k02,k03,k04,k05,k06,k07,k08,k09,k010" +
                    ",k011,k012,k013,k014,k015,k016,k017,k018,k019,k020,k021,k022,k023,k024,k025,k026,k027,k028,k029,k030,k031,k_skupaj,znesek,mesec,leto,sestavil,odgovorni) " +
                    "values(@zap,@skupina_id,@skupina_stor,@storitev,@em,@cena,@ddv,@k01,@k02,@k03,@k04,@k05,@k06,@k07,@k08,@k09,@k010,@k011,@k012,@k013,@k014,@k015,@k016" +
                    ",@k017,@k018,@k019,@k020,@k021,@k022,@k023,@k024,@k025,@k026,@k027,@k028,@k029,@k030,@k031,@k_skupaj,@znesek,@mesec,@leto,@sestavil,@odgovorni)";
                cmd9 = new SqlCommand(q9, con9);
                con9.Open();
                cmd9.Parameters.AddWithValue("@zap", 0);
                cmd9.Parameters.AddWithValue("@skupina_id", tmp_skupina_id);
                cmd9.Parameters.AddWithValue("@skupina_stor", "Nova skupina");
                cmd9.Parameters.AddWithValue("@storitev", tmp_skupina);
                cmd9.Parameters.AddWithValue("@em", "");
                cmd9.Parameters.AddWithValue("@cena", 0);
                cmd9.Parameters.AddWithValue("@ddv", 0);
                cmd9.Parameters.AddWithValue("@k01", 0);
                cmd9.Parameters.AddWithValue("@k02", 0);
                cmd9.Parameters.AddWithValue("@k03", 0);
                cmd9.Parameters.AddWithValue("@k04", 0);
                cmd9.Parameters.AddWithValue("@k05", 0);
                cmd9.Parameters.AddWithValue("@k06", 0);
                cmd9.Parameters.AddWithValue("@k07", 0);
                cmd9.Parameters.AddWithValue("@k08", 0);
                cmd9.Parameters.AddWithValue("@k09", 0);
                cmd9.Parameters.AddWithValue("@k010", 0);
                cmd9.Parameters.AddWithValue("@k011", 0);
                cmd9.Parameters.AddWithValue("@k012", 0);
                cmd9.Parameters.AddWithValue("@k013", 0);
                cmd9.Parameters.AddWithValue("@k014", 0);
                cmd9.Parameters.AddWithValue("@k015", 0);
                cmd9.Parameters.AddWithValue("@k016", 0);
                cmd9.Parameters.AddWithValue("@k017", 0);
                cmd9.Parameters.AddWithValue("@k018", 0);
                cmd9.Parameters.AddWithValue("@k019", 0);
                cmd9.Parameters.AddWithValue("@k020", 0);
                cmd9.Parameters.AddWithValue("@k021", 0);
                cmd9.Parameters.AddWithValue("@k022", 0);
                cmd9.Parameters.AddWithValue("@k023", 0);
                cmd9.Parameters.AddWithValue("@k024", 0);
                cmd9.Parameters.AddWithValue("@k025", 0);
                cmd9.Parameters.AddWithValue("@k026", 0);
                cmd9.Parameters.AddWithValue("@k027", 0);
                cmd9.Parameters.AddWithValue("@k028", 0);
                cmd9.Parameters.AddWithValue("@k029", 0);
                cmd9.Parameters.AddWithValue("@k030", 0);
                cmd9.Parameters.AddWithValue("@k031", 0);
                cmd9.Parameters.AddWithValue("@k_skupaj", 0);
                cmd9.Parameters.AddWithValue("@znesek", 0);
                cmd9.Parameters.AddWithValue("@mesec", t_mesec);
                cmd9.Parameters.AddWithValue("@leto", t_leto);
                cmd9.Parameters.AddWithValue("@sestavil", "sestavil");
                cmd9.Parameters.AddWithValue("@odgovorni", "odgovorni");
                cmd9.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Shrani vrsto: " + ex.Message);
            }
            finally
            {
                if (con9 != null)
                {
                    con9.Close();
                }
            }
        }

        private void Beri_storitve()
        {
            tzap = 0;
            q2 = "select * from tblstoritve where skupina=@idx_skupina and ceniko=1";
            try
            {
                cmd = new SqlCommand(q2, con);
                con.Open();
                cmd.Parameters.AddWithValue("@idx_skupina", tmp_id_skupina);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    id_storitev = (int)rdr["Id"];
                    storitev = (string)rdr["storitev"];
                    id_em = (int)rdr["em"];
                    id_ddv = (int)rdr["ddv"];

                    // preberi em
                    q3 = "select em from tbl_enote where id = @indeks";
                    try
                    {
                        cmd3 = new SqlCommand(q3, con3);
                        con3.Open();
                        cmd3.Parameters.AddWithValue("@indeks", id_em);
                        cmd3.ExecuteNonQuery();
                        str_em = (string)cmd3.ExecuteScalar();
                        con3.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka: naziv_em : " + ex.Message);
                    }

                    // preberi ddv
                    q3 = "select stopnja from tbl_ddv where id = @indeks";
                    try
                    {
                        cmd3 = new SqlCommand(q3, con3);
                        con3.Open();
                        cmd3.Parameters.AddWithValue("@indeks", id_ddv);
                        cmd3.ExecuteNonQuery();
                        float_ddv = (double)cmd3.ExecuteScalar();
                        con3.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka: najdi ddv : " + ex.Message);
                    }

                    // preberi ceno
                    q3 = "select cena_obcina from tbl_cenik where storitev = @indeks";
                    try
                    {
                        cmd3 = new SqlCommand(q3, con3);
                        con3.Open();
                        cmd3.Parameters.AddWithValue("@indeks", id_storitev);
                        cmd3.ExecuteNonQuery();

                        object temp = cmd3.ExecuteScalar();
                        if (temp != null)
                        {
                            str_cena = temp.ToString();
                            float_cena = Convert.ToDouble(str_cena);
                        }
                        else
                        {
                            float_cena = 0;
                        }
                        con3.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka: najdi ceno : " + ex.Message);
                    }

                    // preberi situacijo
                    q3 = "select * from tblsituacije where id_situacije = @indeks";
                    try
                    {
                        cmd3 = new SqlCommand(q3, con3);
                        con3.Open();
                        cmd3.Parameters.AddWithValue("@indeks", id_situacije);
                        rdr3 = cmd3.ExecuteReader();
                        while (rdr3.Read())
                        {
                            id_izbrane_situacije = (int)rdr3["Id"];
                            t_mesec = (string)rdr3["mesec"];
                            t_leto = (string)rdr3["leto"];
                        }
                        con3.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Napaka: Preberi situacijo : " + ex.Message);
                    }

                    // preberi storitve situacije za vsak dan posebej
                    skupna_kolicina_za_mesec = 0;
                    for (dan = 1; dan < 32; dan++)
                    {
                        q3 = "select * from tbl_situacija_storitve where id_situacije = @indeks and id_storitve=@idx_storitve and dan=@idx_dan";
                        try
                        {
                            skupna_kolicina = 0;
                            cmd3 = new SqlCommand(q3, con3);
                            con3.Open();
                            cmd3.Parameters.AddWithValue("@indeks", id_izbrane_situacije);
                            cmd3.Parameters.AddWithValue("@idx_storitve", id_storitev);
                            cmd3.Parameters.AddWithValue("@idx_dan", dan);
                            rdr3 = cmd3.ExecuteReader();
                            while (rdr3.Read())
                            {
                               // tukaj sprememba za zimsko službo - razdeli procente za občino
                                
                                tmp_kolicina = (double)rdr3["kol_1"];
                                skupna_kolicina_za_dan = skupna_kolicina_za_dan + tmp_kolicina;
                            }
                            con3.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Napaka: Preberi situacijo : " + ex.Message);
                        }
                        
                        // predelaj za zimsko službo 29.10.2020
                        if (frmSituacije.zs==true)
                        {
                            skupna_kolicina_za_dan = skupna_kolicina_za_dan*frmSituacije.zs_proc;
                        }

                        
                        Uredi_kolicine();
                        Math.Round(skupna_kolicina_za_mesec, 3);
                        Math.Round(skupna_kolicina_za_dan, 3);
                        skupna_kolicina_za_mesec = skupna_kolicina_za_mesec + skupna_kolicina_za_dan;
                        skupna_kolicina_za_dan = 0;
                    }

                    tzap++;
                    
                    
                    
                    if (tzap == 1)
                          Shrani_vrsto_skupino();

                    // shrani vrsto samo, če je količina večja od 0 - 26.10.2020
                    if (skupna_kolicina_za_mesec != 0)
                        Shrani_vrsto();
                    
                    skupna_kolicina_za_mesec = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: Beri storitve " + ex.Message);
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

        private void Uredi_kolicine()
        {
            if (dan == 1)
                k01 = skupna_kolicina_za_dan;
            if (dan == 2)
                k02 = skupna_kolicina_za_dan;
            if (dan == 3)
                k03 = skupna_kolicina_za_dan;
            if (dan == 4)
                k04 = skupna_kolicina_za_dan;
            if (dan == 5)
                k05 = skupna_kolicina_za_dan;
            if (dan == 6)
                k06 = skupna_kolicina_za_dan;
            if (dan == 7)
                k07 = skupna_kolicina_za_dan;
            if (dan == 8)
                k08 = skupna_kolicina_za_dan;
            if (dan == 9)
                k09 = skupna_kolicina_za_dan;
            if (dan == 10)
                k010 = skupna_kolicina_za_dan;
            if (dan == 11)
                k011 = skupna_kolicina_za_dan;
            if (dan == 12)
                k012 = skupna_kolicina_za_dan;
            if (dan == 13)
                k013 = skupna_kolicina_za_dan;
            if (dan == 14)
                k014 = skupna_kolicina_za_dan;
            if (dan == 15)
                k015 = skupna_kolicina_za_dan;
            if (dan == 16)
                k016 = skupna_kolicina_za_dan;
            if (dan == 17)
                k017 = skupna_kolicina_za_dan;
            if (dan == 18)
                k018 = skupna_kolicina_za_dan;
            if (dan == 19)
                k019 = skupna_kolicina_za_dan;
            if (dan == 20)
                k020 = skupna_kolicina_za_dan;
            if (dan == 21)
                k021 = skupna_kolicina_za_dan;
            if (dan == 22)
                k022 = skupna_kolicina_za_dan;
            if (dan == 23)
                k023 = skupna_kolicina_za_dan;
            if (dan == 24)
                k024 = skupna_kolicina_za_dan;
            if (dan == 25)
                k025 = skupna_kolicina_za_dan;
            if (dan == 26)
                k026 = skupna_kolicina_za_dan;
            if (dan == 27)
                k027 = skupna_kolicina_za_dan;
            if (dan == 28)
                k028 = skupna_kolicina_za_dan;
            if (dan == 29)
                k029 = skupna_kolicina_za_dan;
            if (dan == 30)
                k030 = skupna_kolicina_za_dan;
            if (dan == 31)
                k031 = skupna_kolicina_za_dan;
        }

        private void Indeks_situacije()
        {
            string t_cb = cb21.Text;
            string[] razdeli = t_cb.Split(' ');
            string t_mesec = razdeli[0];
            string t_leto = razdeli[1];
            t_skupina = Convert.ToString(id_objekt);
            if (id_objekt == id_zimska)
                zs = true;  // izpis za zimsko službo 2x
            else
                zs = false;

            id_situacije = t_leto + t_mesec + t_skupina;
            //MessageBox.Show("Indeks situacije "+id_situacije);
        }

        private void Beri_skupine()
        {
            // MessageBox.Show("Začetek...");

            q2 = "select * from tblskupinestoritev";
            try
            {
                cmd2 = new SqlCommand(q2, con2);
                con2.Open();
                rdr2 = cmd2.ExecuteReader();
                while (rdr2.Read())
                {
                    tmp_id_skupina = (int)rdr2["Id"];
                    tmp_skupina_id = tmp_id_skupina;
                    tmp_skupina = (string)rdr2["skupina"];
                    Beri_storitve();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: Poišči id storitve in id skupine  " + ex.Message);
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
               // MessageBox.Show("Konec...");
            }

        }
        private void cb20_SelectedValueChanged(object sender, EventArgs e)
        {
            // naloži mesece v cb21
            q2 = "select * from tblsituacije where objekt=@id_objekt order by datum desc";
            try
            {
                cmd2 = new SqlCommand(q2, con2);
                con2.Open();
                cmd2.Parameters.AddWithValue("@id_objekt", cb20.Text);
                rdr2 = cmd2.ExecuteReader();
                cb21.Items.Clear();
                while (rdr2.Read())
                {
                    str_mesec = (string)rdr2["mesec"];
                    str_leto = (string)rdr2["leto"];
                    string str = str_mesec;
                    str = str.Replace(" ", "");
                    str_mesec = str;

                    str = str_leto;
                    str = str.Replace(" ", "");
                    str_leto = str;
                    string str_dodaj = str_mesec + " " + str_leto;
                    cb21.Items.Add(str_dodaj);
                }
            }
           catch (Exception ex)
            {
                MessageBox.Show("Napaka: Dodaj objekte cb20  " + ex.Message);
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
            // preberi id delovišča
            q2 = "select * from tbl_delovisca where naziv=@idx";
            try
            {
                cmd2 = new SqlCommand(q2, con2);
                con2.Open();
                cmd2.Parameters.AddWithValue("@idx", cb20.Text);
                rdr2 = cmd2.ExecuteReader();
                while (rdr2.Read())
                {
                    id_objekt = (int)rdr2["id_delovisca"];
                    str_objekt = (string)rdr2["naziv"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: Dodaj objekte cb1  " + ex.Message);
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


        }

        private void Brisi_tabelo()
        {
            q3 = "delete from tblsituacija_temp";
            try
            {
                cmd3 = new SqlCommand(q3, con3);
                con3.Open();
                cmd3.ExecuteNonQuery();
                str_em = (string)cmd3.ExecuteScalar();
                con3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: izprazni tabelo : " + ex.Message);
            }

        }

        private void Izprazni_dgv()
        {
            dgv1.Rows.Clear();
            dgv1.Refresh();
        }

        private void Display() // pokaži mrežo
        {
            Izprazni_dgv();
            try
            {
                q = "select * from tblsituacija_temp"; //vse
                cmd = new SqlCommand(q, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string stara_skupina_storitev = d_skupina_stor;
                    d_id = (int)rdr["id"];
                    d_zap = (int)rdr["zap"];
                    d_skupina_stor = (string)rdr["skupina_stor"];
                    d_storitev = (string)rdr["storitev"];
                    d_em = (string)rdr["em"];
                    d_cena = (Double)rdr["cena"];
                    d_ddv = (Double)rdr["ddv"];
                    d_k1 = (Double)rdr["k01"];
                    d_k2 = (Double)rdr["k02"];
                    d_k3 = (Double)rdr["k03"];
                    d_k4 = (Double)rdr["k04"];
                    d_k5 = (Double)rdr["k05"];
                    d_k6 = (Double)rdr["k06"];
                    d_k7 = (Double)rdr["k07"];
                    d_k8 = (Double)rdr["k08"];
                    d_k9 = (Double)rdr["k09"];
                    d_k10 = (Double)rdr["k010"];
                    d_k11 = (Double)rdr["k011"];
                    d_k12 = (Double)rdr["k012"];
                    d_k13 = (Double)rdr["k013"];
                    d_k14 = (Double)rdr["k014"];
                    d_k15 = (Double)rdr["k015"];
                    d_k16 = (Double)rdr["k016"];
                    d_k17 = (Double)rdr["k017"];
                    d_k18 = (Double)rdr["k018"];
                    d_k19 = (Double)rdr["k019"];
                    d_k20 = (Double)rdr["k020"];
                    d_k21 = (Double)rdr["k021"];
                    d_k22 = (Double)rdr["k022"];
                    d_k23 = (Double)rdr["k023"];
                    d_k24 = (Double)rdr["k024"];
                    d_k25 = (Double)rdr["k025"];
                    d_k26 = (Double)rdr["k026"];
                    d_k27 = (Double)rdr["k027"];
                    d_k28 = (Double)rdr["k028"];
                    d_k29 = (Double)rdr["k029"];
                    d_k30 = (Double)rdr["k030"];
                    d_k31 = (Double)rdr["k031"];
                    d_skupaj = (Double)rdr["k_skupaj"];
                    d_znesek = (Double)rdr["znesek"];

                    int sk = 37; // širina kolone z dnevi


                    DataGridViewTextBoxCell Id = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell Zap = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell Skupina = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell Storitev = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell EM = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell Cena = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell DDV = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k01 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k02 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k03 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k04 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k05 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k06 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k07 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k08 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k09 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k010 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k011 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k012 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k013 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k014 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k015 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k016 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k017 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k018 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k019 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k020 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k021 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k022 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k023 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k024 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k025 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k026 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k027 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k028 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k029 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k030 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k031 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell skupaj = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell znesek = new DataGridViewTextBoxCell();

                    Pretvori_v_string();

                    Id.Value = d_id;
                    Zap.Value = sd_zap;
                    Skupina.Value = d_skupina_stor;
                    Storitev.Value = d_storitev;
                    EM.Value = d_em;
                    Cena.Value = sd_cena;
                    DDV.Value = sd_ddv;
                    k01.Value = sd_k1;
                    k02.Value = sd_k2;
                    k03.Value = sd_k3;
                    k04.Value = sd_k4;
                    k05.Value = sd_k5;
                    k06.Value = sd_k6;
                    k07.Value = sd_k7;
                    k08.Value = sd_k8;
                    k09.Value = sd_k9;
                    k010.Value = sd_k10;
                    k011.Value = sd_k11;
                    k012.Value = sd_k12;
                    k013.Value = sd_k13;
                    k014.Value = sd_k14;
                    k015.Value = sd_k15;
                    k016.Value = sd_k16;
                    k017.Value = sd_k17;
                    k018.Value = sd_k18;
                    k019.Value = sd_k19;
                    k020.Value = sd_k20;
                    k021.Value = sd_k21;
                    k022.Value = sd_k22;
                    k023.Value = sd_k23;
                    k024.Value = sd_k24;
                    k025.Value = sd_k25;
                    k026.Value = sd_k26;
                    k027.Value = sd_k27;
                    k028.Value = sd_k28;
                    k029.Value = sd_k29;
                    k030.Value = sd_k30;
                    k031.Value = sd_k31;
                    skupaj.Value = sd_skupaj;
                    znesek.Value = sd_znesek;

                    DataGridViewColumn kolid = dgv1.Columns[0];
                    kolid.Width = 10;
                    DataGridViewColumn kolzap = dgv1.Columns[1];
                    kolzap.Width = 40;
                    DataGridViewColumn kolskupina = dgv1.Columns[2];
                    kolskupina.Width = 60;
                    DataGridViewColumn kolstoritev = dgv1.Columns[3];
                    kolstoritev.Width = 250;
                    DataGridViewColumn kolem = dgv1.Columns[4];
                    kolem.Width = 50;
                    DataGridViewColumn kolcena = dgv1.Columns[5];
                    kolcena.Width = 63;
                    DataGridViewColumn kolddv = dgv1.Columns[6];
                    kolddv.Width = 50;
                    DataGridViewColumn kolk1 = dgv1.Columns[7];
                    kolk1.Width = sk;
                    DataGridViewColumn kolk2 = dgv1.Columns[8];
                    kolk2.Width = sk;
                    DataGridViewColumn kolk3 = dgv1.Columns[9];
                    kolk3.Width = sk;
                    DataGridViewColumn kolk4 = dgv1.Columns[10];
                    kolk4.Width = sk;
                    DataGridViewColumn kolk5 = dgv1.Columns[11];
                    kolk5.Width = sk;
                    DataGridViewColumn kolk6 = dgv1.Columns[12];
                    kolk6.Width = sk;
                    DataGridViewColumn kolk7 = dgv1.Columns[13];
                    kolk7.Width = sk;
                    DataGridViewColumn kolk8 = dgv1.Columns[14];
                    kolk8.Width = sk;
                    DataGridViewColumn kolk9 = dgv1.Columns[15];
                    kolk9.Width = sk;
                    DataGridViewColumn kolk10 = dgv1.Columns[16];
                    kolk10.Width = sk;
                    DataGridViewColumn kolk11 = dgv1.Columns[17];
                    kolk11.Width = sk;
                    DataGridViewColumn kolk12 = dgv1.Columns[18];
                    kolk12.Width = sk;
                    DataGridViewColumn kolk13 = dgv1.Columns[19];
                    kolk13.Width = sk;
                    DataGridViewColumn kolk14 = dgv1.Columns[20];
                    kolk14.Width = sk;
                    DataGridViewColumn kolk15 = dgv1.Columns[21];
                    kolk15.Width = sk;
                    DataGridViewColumn kolk16 = dgv1.Columns[22];
                    kolk16.Width = sk;
                    DataGridViewColumn kolk17 = dgv1.Columns[23];
                    kolk17.Width = sk;
                    DataGridViewColumn kolk18 = dgv1.Columns[24];
                    kolk18.Width = sk;
                    DataGridViewColumn kolk19 = dgv1.Columns[25];
                    kolk19.Width = sk;
                    DataGridViewColumn kolk20 = dgv1.Columns[26];
                    kolk20.Width = sk;
                    DataGridViewColumn kolk21 = dgv1.Columns[27];
                    kolk21.Width = sk;
                    DataGridViewColumn kolk22 = dgv1.Columns[28];
                    kolk22.Width = sk;
                    DataGridViewColumn kolk23 = dgv1.Columns[29];
                    kolk23.Width = sk;
                    DataGridViewColumn kolk24 = dgv1.Columns[30];
                    kolk24.Width = sk;
                    DataGridViewColumn kolk25 = dgv1.Columns[31];
                    kolk25.Width = sk;
                    DataGridViewColumn kolk26 = dgv1.Columns[32];
                    kolk26.Width = sk;
                    DataGridViewColumn kolk27 = dgv1.Columns[33];
                    kolk27.Width = sk;
                    DataGridViewColumn kolk28 = dgv1.Columns[34];
                    kolk28.Width = sk;
                    DataGridViewColumn kolk29 = dgv1.Columns[35];
                    kolk29.Width = sk;
                    DataGridViewColumn kolk30 = dgv1.Columns[36];
                    kolk30.Width = sk;
                    DataGridViewColumn kolk31 = dgv1.Columns[37];
                    kolk31.Width = sk;
                    DataGridViewColumn kolskupaj = dgv1.Columns[38];
                    kolskupaj.Width = 70;
                    DataGridViewColumn kolznesek = dgv1.Columns[39];
                    kolznesek.Width = 70;

                    kolid.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolzap.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolskupina.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    kolstoritev.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    kolk1.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk2.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk3.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk4.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk5.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk6.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk7.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk8.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk9.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk10.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolskupaj.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolznesek.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolem.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    kolid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolzap.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolskupina.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    kolstoritev.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    kolem.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolcena.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolddv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk3.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk4.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk5.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk6.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk7.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk8.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk9.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk10.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk11.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk12.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk13.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //kolk13.DefaultCellStyle.BackColor = Color.Red;
                    kolk14.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk15.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk16.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk17.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk18.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk19.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk20.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk21.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk22.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk23.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk24.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk25.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk26.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk27.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk28.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk29.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk30.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk31.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolskupaj.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolznesek.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    foreach (DataGridViewColumn column in dgv1.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }

                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewColumn col = new DataGridViewColumn();

                    row.Cells.Add(Id);
                    row.Cells.Add(Zap);
                    row.Cells.Add(Skupina);
                    row.Cells.Add(Storitev);
                    row.Cells.Add(EM);
                    row.Cells.Add(Cena);
                    row.Cells.Add(DDV);
                    row.Cells.Add(k01);
                    row.Cells.Add(k02);
                    row.Cells.Add(k03);
                    row.Cells.Add(k04);
                    row.Cells.Add(k05);
                    row.Cells.Add(k06);
                    row.Cells.Add(k07);
                    row.Cells.Add(k08);
                    row.Cells.Add(k09);
                    row.Cells.Add(k010);
                    row.Cells.Add(k011);
                    row.Cells.Add(k012);
                    row.Cells.Add(k013);
                    row.Cells.Add(k014);
                    row.Cells.Add(k015);
                    row.Cells.Add(k016);
                    row.Cells.Add(k017);
                    row.Cells.Add(k018);
                    row.Cells.Add(k019);
                    row.Cells.Add(k020);
                    row.Cells.Add(k021);
                    row.Cells.Add(k022);
                    row.Cells.Add(k023);
                    row.Cells.Add(k024);
                    row.Cells.Add(k025);
                    row.Cells.Add(k026);
                    row.Cells.Add(k027);
                    row.Cells.Add(k028);
                    row.Cells.Add(k029);
                    row.Cells.Add(k030);
                    row.Cells.Add(k031);
                    row.Cells.Add(skupaj);
                    row.Cells.Add(znesek);

                    if (d_skupina_stor == "Nova skupina")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGray;
                        row.DefaultCellStyle.Font = new Font("Roboto", 9, FontStyle.Regular);
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                        row.DefaultCellStyle.Font = new Font("Roboto", 8, FontStyle.Regular);
                    }
                    dgv1.Rows.Add(row);  // dodaj vrstico
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka Display: " + ex.Message);
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

        private void Pretvori_v_string()
        {

            sd_zap = Convert.ToString(d_zap);
            if (sd_zap == "0")
                sd_zap = "";

            sd_ddv = Convert.ToString(d_ddv);
            if (sd_ddv == "0")
                sd_ddv = "";


            sd_cena = Convert.ToString(d_cena);
            if (sd_cena == "0")
            {
                sd_cena = "";
            }
            else
            {
                sd_cena = d_cena.ToString("F2");
            }

            sd_k1 = Convert.ToString(d_k1);
            if (sd_k1 == "0")
                sd_k1 = "";
            sd_k2 = Convert.ToString(d_k2);
            if (sd_k2 == "0")
                sd_k2 = "";
            sd_k3 = Convert.ToString(d_k3);
            if (sd_k3 == "0")
                sd_k3 = "";
            sd_k4 = Convert.ToString(d_k4);
            if (sd_k4 == "0")
                sd_k4 = "";
            sd_k5 = Convert.ToString(d_k5);
            if (sd_k5 == "0")
                sd_k5 = "";
            sd_k6 = Convert.ToString(d_k6);
            if (sd_k6 == "0")
                sd_k6 = "";
            sd_k7 = Convert.ToString(d_k7);
            if (sd_k7 == "0")
                sd_k7 = "";
            sd_k8 = Convert.ToString(d_k8);
            if (sd_k8 == "0")
                sd_k8 = "";
            sd_k9 = Convert.ToString(d_k9);
            if (sd_k9 == "0")
                sd_k9 = "";
            sd_k10 = Convert.ToString(d_k10);
            if (sd_k10 == "0")
                sd_k10 = "";
            sd_k11 = Convert.ToString(d_k11);
            if (sd_k11 == "0")
                sd_k11 = "";
            sd_k12 = Convert.ToString(d_k12);
            if (sd_k12 == "0")
                sd_k12 = "";
            sd_k13 = Convert.ToString(d_k13);
            if (sd_k13 == "0")
                sd_k13 = "";
            sd_k14 = Convert.ToString(d_k14);
            if (sd_k14 == "0")
                sd_k14 = "";
            sd_k15 = Convert.ToString(d_k15);
            if (sd_k15 == "0")
                sd_k15 = "";
            sd_k16 = Convert.ToString(d_k16);
            if (sd_k16 == "0")
                sd_k16 = "";
            sd_k17 = Convert.ToString(d_k17);
            if (sd_k17 == "0")
                sd_k17 = "";
            sd_k18 = Convert.ToString(d_k18);
            if (sd_k18 == "0")
                sd_k18 = "";
            sd_k19 = Convert.ToString(d_k19);
            if (sd_k19 == "0")
                sd_k19 = "";
            sd_k20 = Convert.ToString(d_k20);
            if (sd_k20 == "0")
                sd_k20 = "";
            sd_k21 = Convert.ToString(d_k21);
            if (sd_k21 == "0")
                sd_k21 = "";
            sd_k22 = Convert.ToString(d_k22);
            if (sd_k22 == "0")
                sd_k22 = "";
            sd_k23 = Convert.ToString(d_k23);
            if (sd_k23 == "0")
                sd_k23 = "";
            sd_k24 = Convert.ToString(d_k24);
            if (sd_k24 == "0")
                sd_k24 = "";
            sd_k25 = Convert.ToString(d_k25);
            if (sd_k25 == "0")
                sd_k25 = "";
            sd_k26 = Convert.ToString(d_k26);
            if (sd_k26 == "0")
                sd_k26 = "";
            sd_k27 = Convert.ToString(d_k27);
            if (sd_k27 == "0")
                sd_k27 = "";
            sd_k28 = Convert.ToString(d_k28);
            if (sd_k28 == "0")
                sd_k28 = "";
            sd_k29 = Convert.ToString(d_k29);
            if (sd_k29 == "0")
                sd_k29 = "";
            sd_k30 = Convert.ToString(d_k30);
            if (sd_k30 == "0")
                sd_k30 = "";
            sd_k31 = Convert.ToString(d_k31);
            if (sd_k31 == "0")
                sd_k31 = "";

            sd_skupaj = Convert.ToString(d_skupaj);
            if (sd_skupaj == "0")
                sd_skupaj = "";

            sd_znesek = Convert.ToString(d_znesek);

            if (sd_znesek == "0")
            {
                sd_znesek = "";
            }
            else
            {
                sd_znesek= d_znesek.ToString("F2");
            }
        }


        private void Display_skupine() // pokaži mrežo
        {
            Izprazni_dgv();
            try
            {
                q = "select * from tblsituacija_temp"; //vse
                cmd = new SqlCommand(q, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    d_id = (int)rdr["id"];
                    d_zap = (int)rdr["zap"];
                    d_skupina_stor = (string)rdr["skupina_stor"];
                    d_storitev = (string)rdr["storitev"];
                    d_em = (string)rdr["em"];
                    d_cena = (Double)rdr["cena"];
                    d_ddv = (Double)rdr["ddv"];
                    d_k1 = (Double)rdr["k01"];
                    d_k2 = (Double)rdr["k02"];
                    d_k3 = (Double)rdr["k03"];
                    d_k4 = (Double)rdr["k04"];
                    d_k5 = (Double)rdr["k05"];
                    d_k6 = (Double)rdr["k06"];
                    d_k7 = (Double)rdr["k07"];
                    d_k8 = (Double)rdr["k08"];
                    d_k9 = (Double)rdr["k09"];
                    d_k10 = (Double)rdr["k010"];
                    d_k11 = (Double)rdr["k011"];
                    d_k12 = (Double)rdr["k012"];
                    d_k13 = (Double)rdr["k013"];
                    d_k14 = (Double)rdr["k014"];
                    d_k15 = (Double)rdr["k015"];
                    d_k16 = (Double)rdr["k016"];
                    d_k17 = (Double)rdr["k017"];
                    d_k18 = (Double)rdr["k018"];
                    d_k19 = (Double)rdr["k019"];
                    d_k20 = (Double)rdr["k020"];
                    d_k21 = (Double)rdr["k021"];
                    d_k22 = (Double)rdr["k022"];
                    d_k23 = (Double)rdr["k023"];
                    d_k24 = (Double)rdr["k024"];
                    d_k25 = (Double)rdr["k025"];
                    d_k26 = (Double)rdr["k026"];
                    d_k27 = (Double)rdr["k027"];
                    d_k28 = (Double)rdr["k028"];
                    d_k29 = (Double)rdr["k029"];
                    d_k30 = (Double)rdr["k030"];
                    d_k31 = (Double)rdr["k031"];
                    d_skupaj = (Double)rdr["k_skupaj"];
                    d_znesek = (Double)rdr["znesek"];
                    int sk = 38; // širina kolone z dnevi


                    DataGridViewTextBoxCell Id = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell Zap = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell Skupina = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell Storitev = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell EM = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell Cena = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell DDV = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k01 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k02 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k03 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k04 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k05 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k06 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k07 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k08 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k09 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k010 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k011 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k012 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k013 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k014 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k015 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k016 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k017 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k018 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k019 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k020 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k021 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k022 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k023 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k024 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k025 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k026 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k027 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k028 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k029 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k030 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell k031 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell skupaj = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell znesek = new DataGridViewTextBoxCell();

                    Pretvori_v_string();

                    Id.Value = d_id;
                    Zap.Value = d_zap;
                    Skupina.Value = d_skupina_stor;
                    Storitev.Value = d_storitev;
                    EM.Value = d_em;
                    Cena.Value = sd_cena;
                    DDV.Value = d_ddv;
                    k01.Value = sd_k1;
                    k02.Value = sd_k2;
                    k03.Value = sd_k3;
                    k04.Value = sd_k4;
                    k05.Value = sd_k5;
                    k06.Value = sd_k6;
                    k07.Value = sd_k7;
                    k08.Value = sd_k8;
                    k09.Value = sd_k9;
                    k010.Value = sd_k10;
                    k011.Value = sd_k11;
                    k012.Value = sd_k12;
                    k013.Value = sd_k13;
                    k014.Value = sd_k14;
                    k015.Value = sd_k15;
                    k016.Value = sd_k16;
                    k017.Value = sd_k17;
                    k018.Value = sd_k18;
                    k019.Value = sd_k19;
                    k020.Value = sd_k20;
                    k021.Value = sd_k21;
                    k022.Value = sd_k22;
                    k023.Value = sd_k23;
                    k024.Value = sd_k24;
                    k025.Value = sd_k25;
                    k026.Value = sd_k26;
                    k027.Value = sd_k27;
                    k028.Value = sd_k28;
                    k029.Value = sd_k29;
                    k030.Value = sd_k30;
                    k031.Value = sd_k31;
                    skupaj.Value = sd_skupaj;
                    znesek.Value = sd_znesek;

                    DataGridViewColumn kolid = dgv1.Columns[0];
                    kolid.Width = 10;
                    DataGridViewColumn kolzap = dgv1.Columns[1];
                    kolzap.Width = 40;
                    DataGridViewColumn kolskupina = dgv1.Columns[2];
                    kolskupina.Width = 60;
                    DataGridViewColumn kolstoritev = dgv1.Columns[3];
                    kolstoritev.Width = 250;
                    DataGridViewColumn kolem = dgv1.Columns[4];
                    kolem.Width = 50;
                    DataGridViewColumn kolcena = dgv1.Columns[5];
                    kolcena.Width = 60;
                    DataGridViewColumn kolddv = dgv1.Columns[6];
                    kolddv.Width = 50;
                    DataGridViewColumn kolk1 = dgv1.Columns[7];
                    kolk1.Width = sk;
                    DataGridViewColumn kolk2 = dgv1.Columns[8];
                    kolk2.Width = sk;
                    DataGridViewColumn kolk3 = dgv1.Columns[9];
                    kolk3.Width = sk;
                    DataGridViewColumn kolk4 = dgv1.Columns[10];
                    kolk4.Width = sk;
                    DataGridViewColumn kolk5 = dgv1.Columns[11];
                    kolk5.Width = sk;
                    DataGridViewColumn kolk6 = dgv1.Columns[12];
                    kolk6.Width = sk;
                    DataGridViewColumn kolk7 = dgv1.Columns[13];
                    kolk7.Width = sk;
                    DataGridViewColumn kolk8 = dgv1.Columns[14];
                    kolk8.Width = sk;
                    DataGridViewColumn kolk9 = dgv1.Columns[15];
                    kolk9.Width = sk;
                    DataGridViewColumn kolk10 = dgv1.Columns[16];
                    kolk10.Width = sk;
                    DataGridViewColumn kolk11 = dgv1.Columns[17];
                    kolk11.Width = sk;
                    DataGridViewColumn kolk12 = dgv1.Columns[18];
                    kolk12.Width = sk;
                    DataGridViewColumn kolk13 = dgv1.Columns[19];
                    kolk13.Width = sk;
                    DataGridViewColumn kolk14 = dgv1.Columns[20];
                    kolk14.Width = sk;
                    DataGridViewColumn kolk15 = dgv1.Columns[21];
                    kolk15.Width = sk;
                    DataGridViewColumn kolk16 = dgv1.Columns[22];
                    kolk16.Width = sk;
                    DataGridViewColumn kolk17 = dgv1.Columns[23];
                    kolk17.Width = sk;
                    DataGridViewColumn kolk18 = dgv1.Columns[24];
                    kolk18.Width = sk;
                    DataGridViewColumn kolk19 = dgv1.Columns[25];
                    kolk19.Width = sk;
                    DataGridViewColumn kolk20 = dgv1.Columns[26];
                    kolk20.Width = sk;
                    DataGridViewColumn kolk21 = dgv1.Columns[27];
                    kolk21.Width = sk;
                    DataGridViewColumn kolk22 = dgv1.Columns[28];
                    kolk22.Width = sk;
                    DataGridViewColumn kolk23 = dgv1.Columns[29];
                    kolk23.Width = sk;
                    DataGridViewColumn kolk24 = dgv1.Columns[30];
                    kolk24.Width = sk;
                    DataGridViewColumn kolk25 = dgv1.Columns[31];
                    kolk25.Width = sk;
                    DataGridViewColumn kolk26 = dgv1.Columns[32];
                    kolk26.Width = sk;
                    DataGridViewColumn kolk27 = dgv1.Columns[33];
                    kolk27.Width = sk;
                    DataGridViewColumn kolk28 = dgv1.Columns[34];
                    kolk28.Width = sk;
                    DataGridViewColumn kolk29 = dgv1.Columns[35];
                    kolk29.Width = sk;
                    DataGridViewColumn kolk30 = dgv1.Columns[36];
                    kolk30.Width = sk;
                    DataGridViewColumn kolk31 = dgv1.Columns[37];
                    kolk31.Width = sk;
                    DataGridViewColumn kolskupaj = dgv1.Columns[38];
                    kolskupaj.Width = 70;
                    DataGridViewColumn kolznesek = dgv1.Columns[39];
                    kolznesek.Width = 70;

                    kolid.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolzap.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolskupina.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    kolstoritev.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    kolk1.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk2.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk3.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk4.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk5.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk6.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk7.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk8.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk9.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk10.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolskupaj.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolznesek.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    kolid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolzap.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolskupina.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    kolstoritev.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    kolem.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolcena.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolddv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk3.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk4.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk5.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk6.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk7.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk8.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk9.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk10.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk11.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk12.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk13.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk14.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk15.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk16.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk17.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk18.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk19.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk20.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk21.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk22.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk23.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk24.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk25.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk26.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk27.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk28.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk29.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk30.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolk31.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolskupaj.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    kolznesek.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    DataGridViewRow row = new DataGridViewRow();

                    row.Cells.Add(Id);
                    row.Cells.Add(Zap);
                    row.Cells.Add(Skupina);
                    row.Cells.Add(Storitev);
                    row.Cells.Add(EM);
                    row.Cells.Add(Cena);
                    row.Cells.Add(DDV);
                    row.Cells.Add(k01);
                    row.Cells.Add(k02);
                    row.Cells.Add(k03);
                    row.Cells.Add(k04);
                    row.Cells.Add(k05);
                    row.Cells.Add(k06);
                    row.Cells.Add(k07);
                    row.Cells.Add(k08);
                    row.Cells.Add(k09);
                    row.Cells.Add(k010);
                    row.Cells.Add(k011);
                    row.Cells.Add(k012);
                    row.Cells.Add(k013);
                    row.Cells.Add(k014);
                    row.Cells.Add(k015);
                    row.Cells.Add(k016);
                    row.Cells.Add(k017);
                    row.Cells.Add(k018);
                    row.Cells.Add(k019);
                    row.Cells.Add(k020);
                    row.Cells.Add(k021);
                    row.Cells.Add(k022);
                    row.Cells.Add(k023);
                    row.Cells.Add(k024);
                    row.Cells.Add(k025);
                    row.Cells.Add(k026);
                    row.Cells.Add(k027);
                    row.Cells.Add(k028);
                    row.Cells.Add(k029);
                    row.Cells.Add(k030);
                    row.Cells.Add(k031);
                    row.Cells.Add(skupaj);
                    row.Cells.Add(znesek);

                    dgv1.Rows.Add(row);  // dodaj vrstico
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka Display: " + ex.Message);
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

        private void Izpis_del1()  // pripravi tabelo situacija_tmp
        {
            li.Visible = true;
            li.Refresh();
            // zapiši tabelo temp
            Brisi_tabelo();
            Beri_skupine();
            // preberi situacijo
            q3 = "select * from tblsituacije where id_situacije = @indeks";
            try
            {
                cmd3 = new SqlCommand(q3, con3);
                con3.Open();
                cmd3.Parameters.AddWithValue("@indeks", id_situacije);
                rdr3 = cmd3.ExecuteReader();
                while (rdr3.Read())
                {
                    id_izbrane_situacije = (int)rdr3["Id"];
                    t_mesec = (string)rdr3["mesec"];
                    t_leto = (string)rdr3["leto"];
                }
                con3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: Preberi situacijo : " + ex.Message);
            }
        }

        private void Izpis_del2()  // zbriši prazne postavke iz tabele
        {
            // zbriši vse prazne naslove skupin iz tabele tblSituacija_temp 26-10-2020
            q2 = "select * from tblskupinestoritev";
            try
            {
                cmd2 = new SqlCommand(q2, con2);
                con2.Open();
                rdr2 = cmd2.ExecuteReader();
                while (rdr2.Read())
                {
                    tmp_id_skupina = (int)rdr2["Id"];

                    // preveri če je v skupini kaj polnih zapisov s količino
                    con.Open();
                    SqlCommand chk_record = new SqlCommand("SELECT COUNT(*) FROM tblSituacija_temp WHERE [Skupina_id] = @id_skupine and [k_skupaj]>0", con);
                    chk_record.Parameters.AddWithValue("@id_skupine", tmp_id_skupina);
                    int skupina_obstaja = (int)chk_record.ExecuteScalar();
                    con.Close();
                    if (skupina_obstaja == 0)
                    {
                        // ne obstaja polni zapis v skupini - zbriši celo skupino
                        q3 = "delete from tblsituacija_temp WHERE [Skupina_id] = @id_skupine";
                        try
                        {
                            cmd3 = new SqlCommand(q3, con3);
                            con3.Open();
                            cmd3.Parameters.AddWithValue("@id_skupine", tmp_id_skupina);
                            cmd3.ExecuteNonQuery();
                            str_em = (string)cmd3.ExecuteScalar();
                            con3.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Napaka: Zbriši prazne zapise iz tblSituacija_temp : " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: Poišči id storitve in id skupine  " + ex.Message);
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

        }

        private void Izpis_del3()  // pripravi variable in dejanski izpis
        {
            sestavil = cb22.Text;
            odobril = cb23.Text;
            index_print = id_izbrane_situacije;
            //MessageBox.Show("Situacija: " + Convert.ToString(index_print));
            datum = dt1.Value.ToString("dd. MMMM yyyy");
            frmSituacija_izpis secondForm = new frmSituacija_izpis();
            secondForm.ShowDialog();

            cb20.Items.Clear();
            cb20.ResetText();
            cb21.Items.Clear();
            cb21.ResetText();
            cb22.Items.Clear();
            cb22.ResetText();
            cb23.Items.Clear();
            cb23.ResetText();

            Zacetek();
            cb20.Focus();
        }

        private void btnIzpis_Click(object sender, EventArgs e)
        {
            if (cb20.Text == "" || cb21.Text == "" || cb22.Text == "" || cb23.Text == "")
            {
                MessageBox.Show("Vsi podatki morajo biti izbrani!");
                cb20.Focus();
            }
            else
            {
                zs = false;
                zs_prvic = true;
                Indeks_situacije();

                // preveri če situacija obstaja
                con.Open();
                SqlCommand check_record = new SqlCommand("SELECT COUNT(*) FROM tblSituacije WHERE ([id_situacije] = @id_situacije)", con);
                check_record.Parameters.AddWithValue("@id_situacije", id_situacije);
                int sit_obstaja = (int)check_record.ExecuteScalar();
                con.Close();
                if (sit_obstaja > 0)
                {
                    
                    if (zs == true)  // je zimska služba - izpiši dvakrat deljeno po procentih 29.10.2020
                    {
                        zs_proc = 0.7;
                        str_zs = "Zimska služba - javne poti";  // prvi izpis
                        li.Text = "Pripravljam izpis: "+ str_zs;
                        // ShowWaitForm(msg_pocakaj);
                        li.Refresh();
                        Izpis_del1();
                        Izpis_del2();
                        Izpis_del3();
                        zs_prvic = false;

                        zs_proc = 0.3;
                        this.Refresh();
                        str_zs = "Zimska služba - lokalne ceste";  // drugi izpis
                        li.Text = "Pripravljam izpis: " + str_zs;
                        li.Refresh();
                        Izpis_del1();
                        Izpis_del2();
                        Izpis_del3();
                        zs_prvic = false;

                    }

                    if (zs == false)  // NI zimska služba
                    {
                        li.Text = "Pripravljam izpis: " + str_objekt;
                        li.Refresh();
                        Izpis_del1();
                        Izpis_del2();
                        Izpis_del3();
                    }
                }
                else
                {
                    //ne obstaja
                    MessageBox.Show("Ta situacija ne obstaja.");
                    cb20.Items.Clear();
                    cb20.ResetText();
                    cb21.Items.Clear();
                    cb21.ResetText();
                    cb22.Items.Clear();
                    cb22.ResetText();
                    cb23.Items.Clear();
                    cb23.ResetText();

                    Zacetek();
                    cb20.Focus();
                }
            }

        }


        private void btnPokazi_Click(object sender, EventArgs e)
        {
            
            if (cb20.Text=="" || cb21.Text== "" || cb22.Text == "" || cb23.Text == "")
            {
                MessageBox.Show("Vsi podatki morajo biti izbrani!");
                cb20.Focus();
            }
            else
            {
                Indeks_situacije();

                // preveri če situacija obstaja
                con.Open();
                SqlCommand check_record = new SqlCommand("SELECT COUNT(*) FROM tblSituacije WHERE ([id_situacije] = @id_situacije)", con);
                check_record.Parameters.AddWithValue("@id_situacije", id_situacije);
                int sit_obstaja = (int)check_record.ExecuteScalar();
                con.Close();
                if (sit_obstaja > 0)
                {
                    //obstaja
                    sestavil = cb22.Text;
                    odobril = cb23.Text;
                    Brisi_tabelo();
                    Beri_skupine();
                    Display();
                    // izprazni cb20 in 21
                    cb20.Items.Clear();
                    cb20.ResetText();
                    cb21.Items.Clear();
                    cb21.ResetText();
                    cb22.Items.Clear();
                    cb22.ResetText();
                    cb23.Items.Clear();
                    cb23.ResetText();

                    Zacetek();
                }
                else
                {
                    //ne obstaja
                    MessageBox.Show("Ta situacija ne obstaja.");

                    // izprazni cb20 in 21
                    cb20.Items.Clear();
                    cb20.ResetText();
                    cb21.Items.Clear();
                    cb21.ResetText();
                    cb22.Items.Clear();
                    cb22.ResetText();
                    cb23.Items.Clear();
                    cb23.ResetText();

                    Zacetek();
                    cb20.Focus();
                }
            }
        }

        public void Zacetek()
        {

            // Napolni cb20
            li.Visible = false;
            q2 = "select * from tbl_delovisca order by naziv";
            try
            {
                cmd2 = new SqlCommand(q2, con2);
                con2.Open();
                rdr2 = cmd2.ExecuteReader();
                cb20.Items.Clear();
                while (rdr2.Read())
                {
                    objekt = (string)rdr2["naziv"];
                    id_objekt = (int)rdr2["id_delovisca"];
                    cb20.Items.Add(objekt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: Dodaj objekte cb1  " + ex.Message);
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

            // Napolni cb22 in cb23
            q2 = "select * from tbl_osebe order by oseba";
            try
            {
                cmd2 = new SqlCommand(q2, con2);
                con2.Open();
                rdr2 = cmd2.ExecuteReader();
                cb22.Items.Clear();
                cb23.Items.Clear();
                while (rdr2.Read())
                {
                    oseba = (string)rdr2["oseba"];
                    cb22.Items.Add(oseba);
                    cb23.Items.Add(oseba);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: Dodaj objekte cb1  " + ex.Message);
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

            //Izprazni_dgv();
        } // zacetek
        private void label2_Click(object sender, EventArgs e)
        {

        }
    

    }
}
