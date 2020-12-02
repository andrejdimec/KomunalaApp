
namespace Komunala
{
    partial class frmSodelavci
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        //private System.Windows.Forms.Button btnSpremeni;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnNazaj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnSpremeni = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnShrani = new System.Windows.Forms.Button();
            this.btnPreklici = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.crtal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodatno = new System.Windows.Forms.Button();
            this.tc = new TablessControl();
            this.tpOsnovno = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.tbSm = new System.Windows.Forms.TextBox();
            this.tbDelovnoMesto = new System.Windows.Forms.TextBox();
            this.tbOddelek = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbPrivatMail = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbSluzbeniMail = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbPrivatMob = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tbMpo = new System.Windows.Forms.TextBox();
            this.tbSluzbeniMob = new System.Windows.Forms.TextBox();
            this.tbSluzbeniStac = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tbNazivPoste = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tbPriimek = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tbPosta = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.tbUlica = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tbHs = new System.Windows.Forms.TextBox();
            this.tpDodatno = new System.Windows.Forms.TabPage();
            this.tbDs = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbIzobrazba = new System.Windows.Forms.TextBox();
            this.tbEmso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.tbTrr = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbBanka = new System.Windows.Forms.TextBox();
            this.tbIme2 = new System.Windows.Forms.TextBox();
            this.tbPriimek2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.crtal2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.tc.SuspendLayout();
            this.tpOsnovno.SuspendLayout();
            this.tpDodatno.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToOrderColumns = true;
            this.dgv1.AllowUserToResizeColumns = false;
            this.dgv1.AllowUserToResizeRows = false;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv1.Location = new System.Drawing.Point(31, 87);
            this.dgv1.Name = "dgv1";
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(433, 446);
            this.dgv1.TabIndex = 32;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            this.dgv1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_RowEnter);
            this.dgv1.SelectionChanged += new System.EventHandler(this.dgv1_SelectionChanged);
            this.dgv1.LocationChanged += new System.EventHandler(this.dgv1_LocationChanged);
            // 
            // btnNazaj
            // 
            this.btnNazaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.btnNazaj.FlatAppearance.BorderSize = 0;
            this.btnNazaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazaj.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNazaj.Location = new System.Drawing.Point(330, 612);
            this.btnNazaj.Name = "btnNazaj";
            this.btnNazaj.Size = new System.Drawing.Size(120, 36);
            this.btnNazaj.TabIndex = 35;
            this.btnNazaj.Text = "Izhod";
            this.btnNazaj.UseVisualStyleBackColor = false;
            this.btnNazaj.Click += new System.EventHandler(this.btnNazaj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDodaj.Location = new System.Drawing.Point(43, 560);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(120, 36);
            this.btnDodaj.TabIndex = 36;
            this.btnDodaj.Text = "Nov sodelavec";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click_1);
            // 
            // btnSpremeni
            // 
            this.btnSpremeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.btnSpremeni.FlatAppearance.BorderSize = 0;
            this.btnSpremeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremeni.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSpremeni.Location = new System.Drawing.Point(188, 560);
            this.btnSpremeni.Name = "btnSpremeni";
            this.btnSpremeni.Size = new System.Drawing.Size(120, 36);
            this.btnSpremeni.TabIndex = 37;
            this.btnSpremeni.Text = "Uredi";
            this.btnSpremeni.UseVisualStyleBackColor = false;
            this.btnSpremeni.Click += new System.EventHandler(this.btnSpremeni_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.btnBrisi.FlatAppearance.BorderSize = 0;
            this.btnBrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrisi.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBrisi.Location = new System.Drawing.Point(330, 560);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(120, 36);
            this.btnBrisi.TabIndex = 38;
            this.btnBrisi.Text = "Briši";
            this.btnBrisi.UseVisualStyleBackColor = false;
            // 
            // btnShrani
            // 
            this.btnShrani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.btnShrani.FlatAppearance.BorderSize = 0;
            this.btnShrani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShrani.ForeColor = System.Drawing.SystemColors.Window;
            this.btnShrani.Location = new System.Drawing.Point(43, 612);
            this.btnShrani.Name = "btnShrani";
            this.btnShrani.Size = new System.Drawing.Size(120, 36);
            this.btnShrani.TabIndex = 39;
            this.btnShrani.Text = "Shrani";
            this.btnShrani.UseVisualStyleBackColor = false;
            this.btnShrani.Click += new System.EventHandler(this.btnShrani_Click);
            // 
            // btnPreklici
            // 
            this.btnPreklici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.btnPreklici.FlatAppearance.BorderSize = 0;
            this.btnPreklici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreklici.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPreklici.Location = new System.Drawing.Point(188, 612);
            this.btnPreklici.Name = "btnPreklici";
            this.btnPreklici.Size = new System.Drawing.Size(120, 36);
            this.btnPreklici.TabIndex = 40;
            this.btnPreklici.Text = "Prekliči";
            this.btnPreklici.UseVisualStyleBackColor = false;
            this.btnPreklici.Click += new System.EventHandler(this.btnPreklici_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 27);
            this.label1.TabIndex = 41;
            this.label1.Text = "Sodelavci";
            // 
            // crtal
            // 
            this.crtal.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.crtal.Location = new System.Drawing.Point(28, 55);
            this.crtal.Name = "crtal";
            this.crtal.Size = new System.Drawing.Size(436, 18);
            this.crtal.TabIndex = 42;
            this.crtal.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(508, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 27);
            this.label2.TabIndex = 55;
            this.label2.Text = "Osnovni podatki";
            // 
            // btnDodatno
            // 
            this.btnDodatno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.btnDodatno.FlatAppearance.BorderSize = 0;
            this.btnDodatno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodatno.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDodatno.Location = new System.Drawing.Point(677, 560);
            this.btnDodatno.Name = "btnDodatno";
            this.btnDodatno.Size = new System.Drawing.Size(202, 41);
            this.btnDodatno.TabIndex = 56;
            this.btnDodatno.Text = "Pokaži dodatne podatke";
            this.btnDodatno.UseVisualStyleBackColor = false;
            this.btnDodatno.Click += new System.EventHandler(this.btnDodatno_Click);
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tpOsnovno);
            this.tc.Controls.Add(this.tpDodatno);
            this.tc.Location = new System.Drawing.Point(493, 87);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(592, 467);
            this.tc.TabIndex = 54;
            // 
            // tpOsnovno
            // 
            this.tpOsnovno.Controls.Add(this.label17);
            this.tpOsnovno.Controls.Add(this.tbSm);
            this.tpOsnovno.Controls.Add(this.tbDelovnoMesto);
            this.tpOsnovno.Controls.Add(this.tbOddelek);
            this.tpOsnovno.Controls.Add(this.label18);
            this.tpOsnovno.Controls.Add(this.label19);
            this.tpOsnovno.Controls.Add(this.tbPrivatMail);
            this.tpOsnovno.Controls.Add(this.label20);
            this.tpOsnovno.Controls.Add(this.tbSluzbeniMail);
            this.tpOsnovno.Controls.Add(this.label21);
            this.tpOsnovno.Controls.Add(this.tbPrivatMob);
            this.tpOsnovno.Controls.Add(this.label22);
            this.tpOsnovno.Controls.Add(this.label23);
            this.tpOsnovno.Controls.Add(this.tbMpo);
            this.tpOsnovno.Controls.Add(this.tbSluzbeniMob);
            this.tpOsnovno.Controls.Add(this.tbSluzbeniStac);
            this.tpOsnovno.Controls.Add(this.label24);
            this.tpOsnovno.Controls.Add(this.label25);
            this.tpOsnovno.Controls.Add(this.tbNazivPoste);
            this.tpOsnovno.Controls.Add(this.label26);
            this.tpOsnovno.Controls.Add(this.tbIme);
            this.tpOsnovno.Controls.Add(this.label27);
            this.tpOsnovno.Controls.Add(this.tbPriimek);
            this.tpOsnovno.Controls.Add(this.label28);
            this.tpOsnovno.Controls.Add(this.tbPosta);
            this.tpOsnovno.Controls.Add(this.label29);
            this.tpOsnovno.Controls.Add(this.label30);
            this.tpOsnovno.Controls.Add(this.tbUlica);
            this.tpOsnovno.Controls.Add(this.label31);
            this.tpOsnovno.Controls.Add(this.tbHs);
            this.tpOsnovno.Location = new System.Drawing.Point(4, 27);
            this.tpOsnovno.Name = "tpOsnovno";
            this.tpOsnovno.Padding = new System.Windows.Forms.Padding(3);
            this.tpOsnovno.Size = new System.Drawing.Size(584, 436);
            this.tpOsnovno.TabIndex = 0;
            this.tpOsnovno.Text = "tabPage1";
            this.tpOsnovno.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(322, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 18);
            this.label17.TabIndex = 100;
            this.label17.Text = "SM";
            // 
            // tbSm
            // 
            this.tbSm.Location = new System.Drawing.Point(325, 100);
            this.tbSm.Name = "tbSm";
            this.tbSm.Size = new System.Drawing.Size(49, 26);
            this.tbSm.TabIndex = 4;
            this.tbSm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDelovnoMesto
            // 
            this.tbDelovnoMesto.Location = new System.Drawing.Point(16, 100);
            this.tbDelovnoMesto.Name = "tbDelovnoMesto";
            this.tbDelovnoMesto.Size = new System.Drawing.Size(278, 26);
            this.tbDelovnoMesto.TabIndex = 3;
            // 
            // tbOddelek
            // 
            this.tbOddelek.Location = new System.Drawing.Point(411, 100);
            this.tbOddelek.Name = "tbOddelek";
            this.tbOddelek.Size = new System.Drawing.Size(152, 26);
            this.tbOddelek.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 79);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 18);
            this.label18.TabIndex = 97;
            this.label18.Text = "Delovno mesto";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(408, 79);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 18);
            this.label19.TabIndex = 98;
            this.label19.Text = "Oddelek";
            // 
            // tbPrivatMail
            // 
            this.tbPrivatMail.Location = new System.Drawing.Point(313, 393);
            this.tbPrivatMail.Name = "tbPrivatMail";
            this.tbPrivatMail.Size = new System.Drawing.Size(250, 26);
            this.tbPrivatMail.TabIndex = 16;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(310, 372);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 18);
            this.label20.TabIndex = 94;
            this.label20.Text = "Privat e-pošta";
            // 
            // tbSluzbeniMail
            // 
            this.tbSluzbeniMail.Location = new System.Drawing.Point(16, 393);
            this.tbSluzbeniMail.Name = "tbSluzbeniMail";
            this.tbSluzbeniMail.Size = new System.Drawing.Size(278, 26);
            this.tbSluzbeniMail.TabIndex = 15;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 372);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(114, 18);
            this.label21.TabIndex = 92;
            this.label21.Text = "Službena e-pošta";
            // 
            // tbPrivatMob
            // 
            this.tbPrivatMob.Location = new System.Drawing.Point(421, 321);
            this.tbPrivatMob.Name = "tbPrivatMob";
            this.tbPrivatMob.Size = new System.Drawing.Size(142, 26);
            this.tbPrivatMob.TabIndex = 14;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(418, 300);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 18);
            this.label22.TabIndex = 90;
            this.label22.Text = "Privat mobilni";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(177, 300);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 18);
            this.label23.TabIndex = 88;
            this.label23.Text = "MPO";
            // 
            // tbMpo
            // 
            this.tbMpo.Location = new System.Drawing.Point(180, 321);
            this.tbMpo.Margin = new System.Windows.Forms.Padding(0);
            this.tbMpo.Name = "tbMpo";
            this.tbMpo.Size = new System.Drawing.Size(49, 26);
            this.tbMpo.TabIndex = 11;
            this.tbMpo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSluzbeniMob
            // 
            this.tbSluzbeniMob.Location = new System.Drawing.Point(16, 321);
            this.tbSluzbeniMob.Name = "tbSluzbeniMob";
            this.tbSluzbeniMob.Size = new System.Drawing.Size(142, 26);
            this.tbSluzbeniMob.TabIndex = 10;
            // 
            // tbSluzbeniStac
            // 
            this.tbSluzbeniStac.Location = new System.Drawing.Point(251, 321);
            this.tbSluzbeniStac.Name = "tbSluzbeniStac";
            this.tbSluzbeniStac.Size = new System.Drawing.Size(147, 26);
            this.tbSluzbeniStac.TabIndex = 12;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(13, 300);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(112, 18);
            this.label24.TabIndex = 85;
            this.label24.Text = "Službeni mobilni";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(248, 300);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(132, 18);
            this.label25.TabIndex = 86;
            this.label25.Text = "Službeni stacionarni";
            // 
            // tbNazivPoste
            // 
            this.tbNazivPoste.Location = new System.Drawing.Point(379, 213);
            this.tbNazivPoste.Name = "tbNazivPoste";
            this.tbNazivPoste.Size = new System.Drawing.Size(184, 26);
            this.tbNazivPoste.TabIndex = 9;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(376, 192);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(80, 18);
            this.label26.TabIndex = 82;
            this.label26.Text = "Naziv pošte";
            // 
            // tbIme
            // 
            this.tbIme.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbIme.Location = new System.Drawing.Point(16, 32);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(278, 29);
            this.tbIme.TabIndex = 1;
            this.tbIme.WordWrap = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(308, 192);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(42, 18);
            this.label27.TabIndex = 81;
            this.label27.Text = "Pošta";
            // 
            // tbPriimek
            // 
            this.tbPriimek.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPriimek.Location = new System.Drawing.Point(311, 32);
            this.tbPriimek.Name = "tbPriimek";
            this.tbPriimek.Size = new System.Drawing.Size(252, 29);
            this.tbPriimek.TabIndex = 2;
            this.tbPriimek.WordWrap = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(13, 11);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(32, 18);
            this.label28.TabIndex = 73;
            this.label28.Text = "Ime";
            // 
            // tbPosta
            // 
            this.tbPosta.Location = new System.Drawing.Point(311, 213);
            this.tbPosta.Name = "tbPosta";
            this.tbPosta.Size = new System.Drawing.Size(50, 26);
            this.tbPosta.TabIndex = 8;
            this.tbPosta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(308, 11);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(56, 18);
            this.label29.TabIndex = 74;
            this.label29.Text = "Priimek";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(248, 192);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(24, 18);
            this.label30.TabIndex = 78;
            this.label30.Text = "HŠ";
            // 
            // tbUlica
            // 
            this.tbUlica.Location = new System.Drawing.Point(16, 213);
            this.tbUlica.Name = "tbUlica";
            this.tbUlica.Size = new System.Drawing.Size(215, 26);
            this.tbUlica.TabIndex = 6;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(13, 192);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(97, 18);
            this.label31.TabIndex = 77;
            this.label31.Text = "Ulica / Naselje";
            // 
            // tbHs
            // 
            this.tbHs.Location = new System.Drawing.Point(251, 213);
            this.tbHs.Name = "tbHs";
            this.tbHs.Size = new System.Drawing.Size(43, 26);
            this.tbHs.TabIndex = 7;
            this.tbHs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tpDodatno
            // 
            this.tpDodatno.Controls.Add(this.tbDs);
            this.tpDodatno.Controls.Add(this.label12);
            this.tpDodatno.Controls.Add(this.tbIzobrazba);
            this.tpDodatno.Controls.Add(this.tbEmso);
            this.tpDodatno.Controls.Add(this.label6);
            this.tpDodatno.Controls.Add(this.label7);
            this.tpDodatno.Controls.Add(this.l);
            this.tpDodatno.Controls.Add(this.tbTrr);
            this.tpDodatno.Controls.Add(this.label11);
            this.tpDodatno.Controls.Add(this.tbBanka);
            this.tpDodatno.Controls.Add(this.tbIme2);
            this.tpDodatno.Controls.Add(this.tbPriimek2);
            this.tpDodatno.Controls.Add(this.label3);
            this.tpDodatno.Controls.Add(this.label4);
            this.tpDodatno.Location = new System.Drawing.Point(4, 27);
            this.tpDodatno.Name = "tpDodatno";
            this.tpDodatno.Padding = new System.Windows.Forms.Padding(3);
            this.tpDodatno.Size = new System.Drawing.Size(584, 436);
            this.tpDodatno.TabIndex = 1;
            this.tpDodatno.Text = "tabPage2";
            this.tpDodatno.UseVisualStyleBackColor = true;
            // 
            // tbDs
            // 
            this.tbDs.Location = new System.Drawing.Point(238, 197);
            this.tbDs.Name = "tbDs";
            this.tbDs.Size = new System.Drawing.Size(201, 26);
            this.tbDs.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(235, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 18);
            this.label12.TabIndex = 116;
            this.label12.Text = "Davčna številka";
            // 
            // tbIzobrazba
            // 
            this.tbIzobrazba.Location = new System.Drawing.Point(16, 130);
            this.tbIzobrazba.Name = "tbIzobrazba";
            this.tbIzobrazba.Size = new System.Drawing.Size(423, 26);
            this.tbIzobrazba.TabIndex = 20;
            // 
            // tbEmso
            // 
            this.tbEmso.Location = new System.Drawing.Point(16, 197);
            this.tbEmso.Name = "tbEmso";
            this.tbEmso.Size = new System.Drawing.Size(201, 26);
            this.tbEmso.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 111;
            this.label6.Text = "Izobrazba";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 112;
            this.label7.Text = "EMŠO";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(235, 256);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(45, 18);
            this.l.TabIndex = 104;
            this.l.Text = "Banka";
            // 
            // tbTrr
            // 
            this.tbTrr.Location = new System.Drawing.Point(16, 277);
            this.tbTrr.Name = "tbTrr";
            this.tbTrr.Size = new System.Drawing.Size(201, 26);
            this.tbTrr.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 18);
            this.label11.TabIndex = 103;
            this.label11.Text = "Transakcijski račun";
            // 
            // tbBanka
            // 
            this.tbBanka.Location = new System.Drawing.Point(238, 277);
            this.tbBanka.Name = "tbBanka";
            this.tbBanka.Size = new System.Drawing.Size(201, 26);
            this.tbBanka.TabIndex = 24;
            // 
            // tbIme2
            // 
            this.tbIme2.Enabled = false;
            this.tbIme2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbIme2.Location = new System.Drawing.Point(16, 32);
            this.tbIme2.Name = "tbIme2";
            this.tbIme2.ReadOnly = true;
            this.tbIme2.Size = new System.Drawing.Size(278, 29);
            this.tbIme2.TabIndex = 75;
            this.tbIme2.WordWrap = false;
            // 
            // tbPriimek2
            // 
            this.tbPriimek2.Enabled = false;
            this.tbPriimek2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPriimek2.Location = new System.Drawing.Point(311, 32);
            this.tbPriimek2.Name = "tbPriimek2";
            this.tbPriimek2.ReadOnly = true;
            this.tbPriimek2.Size = new System.Drawing.Size(252, 29);
            this.tbPriimek2.TabIndex = 76;
            this.tbPriimek2.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 77;
            this.label3.Text = "Ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 78;
            this.label4.Text = "Priimek";
            // 
            // crtal2
            // 
            this.crtal2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.crtal2.Location = new System.Drawing.Point(513, 55);
            this.crtal2.Name = "crtal2";
            this.crtal2.Size = new System.Drawing.Size(547, 18);
            this.crtal2.TabIndex = 57;
            this.crtal2.Text = "label2";
            // 
            // frmSodelavci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1091, 682);
            this.Controls.Add(this.crtal2);
            this.Controls.Add(this.btnDodatno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.crtal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPreklici);
            this.Controls.Add(this.btnShrani);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnSpremeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnNazaj);
            this.Controls.Add(this.dgv1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSodelavci";
            this.Text = "Komunala Radgona";
            this.Load += new System.EventHandler(this.frmSodelavci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.tc.ResumeLayout(false);
            this.tpOsnovno.ResumeLayout(false);
            this.tpOsnovno.PerformLayout();
            this.tpDodatno.ResumeLayout(false);
            this.tpDodatno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnNazaj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnSpremeni;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnShrani;
        private System.Windows.Forms.Button btnPreklici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label crtal;
        private TablessControl tc;
        private System.Windows.Forms.TabPage tpOsnovno;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbSm;
        private System.Windows.Forms.TextBox tbDelovnoMesto;
        private System.Windows.Forms.TextBox tbOddelek;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbPrivatMail;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbSluzbeniMail;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbPrivatMob;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbMpo;
        private System.Windows.Forms.TextBox tbSluzbeniMob;
        private System.Windows.Forms.TextBox tbSluzbeniStac;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tbNazivPoste;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tbPriimek;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tbPosta;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tbUlica;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox tbHs;
        private System.Windows.Forms.TabPage tpDodatno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodatno;
        private System.Windows.Forms.Label crtal2;
        private System.Windows.Forms.TextBox tbIme2;
        private System.Windows.Forms.TextBox tbPriimek2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDs;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbIzobrazba;
        private System.Windows.Forms.TextBox tbEmso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.TextBox tbTrr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbBanka;
    }
}