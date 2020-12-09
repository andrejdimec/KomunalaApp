
namespace Komunala
{
    partial class frmTelBaza
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
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPreklici = new System.Windows.Forms.Button();
            this.btnShrani = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnSpremeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnNazaj = new System.Windows.Forms.Button();
            this.crtal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.cbSkupina = new System.Windows.Forms.ComboBox();
            this.tbIskanje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbStevilka = new System.Windows.Forms.TextBox();
            this.tbMpo = new System.Windows.Forms.TextBox();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chbImenik = new System.Windows.Forms.CheckBox();
            this.rbOseba = new System.Windows.Forms.RadioButton();
            this.p2 = new System.Windows.Forms.Panel();
            this.rbInternet = new System.Windows.Forms.RadioButton();
            this.rbDrugo = new System.Windows.Forms.RadioButton();
            this.rbTelemetrija = new System.Windows.Forms.RadioButton();
            this.chbAktivna = new System.Windows.Forms.CheckBox();
            this.lOseba = new System.Windows.Forms.Label();
            this.cbOseba = new System.Windows.Forms.ComboBox();
            this.cbObjekt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbOpombe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Panel();
            this.rbStacionarna = new System.Windows.Forms.RadioButton();
            this.rbMobilna = new System.Windows.Forms.RadioButton();
            this.stevilke = new System.Windows.Forms.Label();
            this.btnRacun = new System.Windows.Forms.Button();
            this.btnIzpis = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stevilka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imenik = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbSm = new System.Windows.Forms.TextBox();
            this.lsm = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.p2.SuspendLayout();
            this.p1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPreklici
            // 
            this.btnPreklici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.btnPreklici.FlatAppearance.BorderSize = 0;
            this.btnPreklici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreklici.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPreklici.Location = new System.Drawing.Point(512, 838);
            this.btnPreklici.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreklici.Name = "btnPreklici";
            this.btnPreklici.Size = new System.Drawing.Size(110, 36);
            this.btnPreklici.TabIndex = 46;
            this.btnPreklici.Text = "Prekliči";
            this.btnPreklici.UseVisualStyleBackColor = false;
            this.btnPreklici.Click += new System.EventHandler(this.btnPreklici_Click);
            // 
            // btnShrani
            // 
            this.btnShrani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.btnShrani.FlatAppearance.BorderSize = 0;
            this.btnShrani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShrani.ForeColor = System.Drawing.SystemColors.Window;
            this.btnShrani.Location = new System.Drawing.Point(390, 838);
            this.btnShrani.Margin = new System.Windows.Forms.Padding(4);
            this.btnShrani.Name = "btnShrani";
            this.btnShrani.Size = new System.Drawing.Size(110, 36);
            this.btnShrani.TabIndex = 45;
            this.btnShrani.Text = "Shrani";
            this.btnShrani.UseVisualStyleBackColor = false;
            this.btnShrani.Click += new System.EventHandler(this.btnShrani_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.btnBrisi.FlatAppearance.BorderSize = 0;
            this.btnBrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrisi.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBrisi.Location = new System.Drawing.Point(268, 838);
            this.btnBrisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(110, 36);
            this.btnBrisi.TabIndex = 44;
            this.btnBrisi.Text = "Briši";
            this.btnBrisi.UseVisualStyleBackColor = false;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // btnSpremeni
            // 
            this.btnSpremeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.btnSpremeni.FlatAppearance.BorderSize = 0;
            this.btnSpremeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremeni.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSpremeni.Location = new System.Drawing.Point(146, 838);
            this.btnSpremeni.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpremeni.Name = "btnSpremeni";
            this.btnSpremeni.Size = new System.Drawing.Size(110, 36);
            this.btnSpremeni.TabIndex = 43;
            this.btnSpremeni.Text = "Spremeni";
            this.btnSpremeni.UseVisualStyleBackColor = false;
            this.btnSpremeni.Click += new System.EventHandler(this.btnSpremeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDodaj.Location = new System.Drawing.Point(24, 838);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(110, 36);
            this.btnDodaj.TabIndex = 42;
            this.btnDodaj.Text = "Dodaj številko";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnNazaj
            // 
            this.btnNazaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.btnNazaj.FlatAppearance.BorderSize = 0;
            this.btnNazaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazaj.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNazaj.Location = new System.Drawing.Point(905, 838);
            this.btnNazaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnNazaj.Name = "btnNazaj";
            this.btnNazaj.Size = new System.Drawing.Size(110, 36);
            this.btnNazaj.TabIndex = 41;
            this.btnNazaj.Text = "Izhod";
            this.btnNazaj.UseVisualStyleBackColor = false;
            this.btnNazaj.Click += new System.EventHandler(this.btnNazaj_Click);
            // 
            // crtal
            // 
            this.crtal.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.crtal.Location = new System.Drawing.Point(15, 49);
            this.crtal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.crtal.Name = "crtal";
            this.crtal.Size = new System.Drawing.Size(1004, 25);
            this.crtal.TabIndex = 48;
            this.crtal.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 27);
            this.label1.TabIndex = 47;
            this.label1.Text = "Telefonske številke";
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToResizeColumns = false;
            this.dgv1.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgv1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Stevilka,
            this.Opis,
            this.Imenik});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv1.EnableHeadersVisualStyles = false;
            this.dgv1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv1.Location = new System.Drawing.Point(24, 147);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(572, 663);
            this.dgv1.TabIndex = 49;
            this.dgv1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_RowEnter);
            // 
            // cbSkupina
            // 
            this.cbSkupina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSkupina.FormattingEnabled = true;
            this.cbSkupina.Location = new System.Drawing.Point(24, 105);
            this.cbSkupina.Name = "cbSkupina";
            this.cbSkupina.Size = new System.Drawing.Size(273, 26);
            this.cbSkupina.TabIndex = 50;
            this.cbSkupina.SelectedIndexChanged += new System.EventHandler(this.cbSkupina_SelectedIndexChanged);
            this.cbSkupina.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbSkupina_MouseClick);
            // 
            // tbIskanje
            // 
            this.tbIskanje.Location = new System.Drawing.Point(314, 105);
            this.tbIskanje.Name = "tbIskanje";
            this.tbIskanje.Size = new System.Drawing.Size(282, 26);
            this.tbIskanje.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 52;
            this.label2.Text = "Skupina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 53;
            this.label3.Text = "Iskanje po opisu";
            // 
            // tbStevilka
            // 
            this.tbStevilka.Location = new System.Drawing.Point(621, 226);
            this.tbStevilka.Name = "tbStevilka";
            this.tbStevilka.Size = new System.Drawing.Size(165, 26);
            this.tbStevilka.TabIndex = 54;
            // 
            // tbMpo
            // 
            this.tbMpo.Location = new System.Drawing.Point(813, 226);
            this.tbMpo.Name = "tbMpo";
            this.tbMpo.Size = new System.Drawing.Size(56, 26);
            this.tbMpo.TabIndex = 55;
            // 
            // tbOpis
            // 
            this.tbOpis.Location = new System.Drawing.Point(621, 292);
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.Size = new System.Drawing.Size(394, 26);
            this.tbOpis.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(621, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 57;
            this.label4.Text = "Telefonska številka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(813, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 58;
            this.label5.Text = "MPO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(623, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 18);
            this.label6.TabIndex = 59;
            this.label6.Text = "Opis";
            // 
            // chbImenik
            // 
            this.chbImenik.AutoSize = true;
            this.chbImenik.Location = new System.Drawing.Point(620, 609);
            this.chbImenik.Name = "chbImenik";
            this.chbImenik.Size = new System.Drawing.Size(210, 22);
            this.chbImenik.TabIndex = 60;
            this.chbImenik.Text = "Prikaz v telefonskem imeniku";
            this.chbImenik.UseVisualStyleBackColor = true;
            this.chbImenik.CheckedChanged += new System.EventHandler(this.chbImenik_CheckedChanged);
            // 
            // rbOseba
            // 
            this.rbOseba.AutoSize = true;
            this.rbOseba.Location = new System.Drawing.Point(1, 12);
            this.rbOseba.Name = "rbOseba";
            this.rbOseba.Size = new System.Drawing.Size(65, 22);
            this.rbOseba.TabIndex = 61;
            this.rbOseba.TabStop = true;
            this.rbOseba.Text = "Oseba";
            this.rbOseba.UseVisualStyleBackColor = true;
            this.rbOseba.CheckedChanged += new System.EventHandler(this.rbOseba_CheckedChanged);
            // 
            // p2
            // 
            this.p2.Controls.Add(this.rbInternet);
            this.p2.Controls.Add(this.rbDrugo);
            this.p2.Controls.Add(this.rbTelemetrija);
            this.p2.Controls.Add(this.rbOseba);
            this.p2.Location = new System.Drawing.Point(621, 339);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(394, 43);
            this.p2.TabIndex = 62;
            // 
            // rbInternet
            // 
            this.rbInternet.AutoSize = true;
            this.rbInternet.Location = new System.Drawing.Point(205, 12);
            this.rbInternet.Name = "rbInternet";
            this.rbInternet.Size = new System.Drawing.Size(77, 22);
            this.rbInternet.TabIndex = 64;
            this.rbInternet.TabStop = true;
            this.rbInternet.Text = "Internet";
            this.rbInternet.UseVisualStyleBackColor = true;
            this.rbInternet.CheckedChanged += new System.EventHandler(this.rbInternet_CheckedChanged);
            // 
            // rbDrugo
            // 
            this.rbDrugo.AutoSize = true;
            this.rbDrugo.Location = new System.Drawing.Point(305, 12);
            this.rbDrugo.Name = "rbDrugo";
            this.rbDrugo.Size = new System.Drawing.Size(63, 22);
            this.rbDrugo.TabIndex = 63;
            this.rbDrugo.TabStop = true;
            this.rbDrugo.Text = "Drugo";
            this.rbDrugo.UseVisualStyleBackColor = true;
            this.rbDrugo.CheckedChanged += new System.EventHandler(this.rbDrugo_CheckedChanged);
            // 
            // rbTelemetrija
            // 
            this.rbTelemetrija.AutoSize = true;
            this.rbTelemetrija.Location = new System.Drawing.Point(86, 12);
            this.rbTelemetrija.Name = "rbTelemetrija";
            this.rbTelemetrija.Size = new System.Drawing.Size(97, 22);
            this.rbTelemetrija.TabIndex = 62;
            this.rbTelemetrija.TabStop = true;
            this.rbTelemetrija.Text = "Telemetrija";
            this.rbTelemetrija.UseVisualStyleBackColor = true;
            this.rbTelemetrija.CheckedChanged += new System.EventHandler(this.rbTelemetrija_CheckedChanged);
            // 
            // chbAktivna
            // 
            this.chbAktivna.AutoSize = true;
            this.chbAktivna.Location = new System.Drawing.Point(895, 184);
            this.chbAktivna.Name = "chbAktivna";
            this.chbAktivna.Size = new System.Drawing.Size(124, 22);
            this.chbAktivna.TabIndex = 64;
            this.chbAktivna.Text = "Aktivna številka";
            this.chbAktivna.UseVisualStyleBackColor = true;
            // 
            // lOseba
            // 
            this.lOseba.AutoSize = true;
            this.lOseba.Location = new System.Drawing.Point(619, 407);
            this.lOseba.Name = "lOseba";
            this.lOseba.Size = new System.Drawing.Size(47, 18);
            this.lOseba.TabIndex = 68;
            this.lOseba.Text = "Oseba";
            // 
            // cbOseba
            // 
            this.cbOseba.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbOseba.FormattingEnabled = true;
            this.cbOseba.Location = new System.Drawing.Point(620, 428);
            this.cbOseba.Name = "cbOseba";
            this.cbOseba.Size = new System.Drawing.Size(395, 26);
            this.cbOseba.TabIndex = 69;
            this.cbOseba.SelectedIndexChanged += new System.EventHandler(this.cbOseba_SelectedIndexChanged);
            this.cbOseba.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbOseba_MouseClick);
            // 
            // cbObjekt
            // 
            this.cbObjekt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbObjekt.FormattingEnabled = true;
            this.cbObjekt.Location = new System.Drawing.Point(620, 497);
            this.cbObjekt.Name = "cbObjekt";
            this.cbObjekt.Size = new System.Drawing.Size(395, 26);
            this.cbObjekt.TabIndex = 71;
            this.cbObjekt.SelectedIndexChanged += new System.EventHandler(this.cbObjekt_SelectedIndexChanged);
            this.cbObjekt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbObjekt_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(619, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 18);
            this.label7.TabIndex = 70;
            this.label7.Text = "Objekt s telemetrijo";
            // 
            // tbOpombe
            // 
            this.tbOpombe.Location = new System.Drawing.Point(620, 669);
            this.tbOpombe.Multiline = true;
            this.tbOpombe.Name = "tbOpombe";
            this.tbOpombe.Size = new System.Drawing.Size(395, 141);
            this.tbOpombe.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(621, 648);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 73;
            this.label8.Text = "Opombe";
            // 
            // p1
            // 
            this.p1.Controls.Add(this.rbStacionarna);
            this.p1.Controls.Add(this.rbMobilna);
            this.p1.Location = new System.Drawing.Point(620, 144);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(192, 43);
            this.p1.TabIndex = 65;
            // 
            // rbStacionarna
            // 
            this.rbStacionarna.AutoSize = true;
            this.rbStacionarna.Location = new System.Drawing.Point(86, 12);
            this.rbStacionarna.Name = "rbStacionarna";
            this.rbStacionarna.Size = new System.Drawing.Size(98, 22);
            this.rbStacionarna.TabIndex = 62;
            this.rbStacionarna.TabStop = true;
            this.rbStacionarna.Text = "Stacionarna";
            this.rbStacionarna.UseVisualStyleBackColor = true;
            // 
            // rbMobilna
            // 
            this.rbMobilna.AutoSize = true;
            this.rbMobilna.Location = new System.Drawing.Point(1, 12);
            this.rbMobilna.Name = "rbMobilna";
            this.rbMobilna.Size = new System.Drawing.Size(77, 22);
            this.rbMobilna.TabIndex = 61;
            this.rbMobilna.TabStop = true;
            this.rbMobilna.Text = "Mobilna";
            this.rbMobilna.UseVisualStyleBackColor = true;
            // 
            // stevilke
            // 
            this.stevilke.AutoSize = true;
            this.stevilke.Location = new System.Drawing.Point(244, 29);
            this.stevilke.Name = "stevilke";
            this.stevilke.Size = new System.Drawing.Size(58, 18);
            this.stevilke.TabIndex = 74;
            this.stevilke.Text = "Številke";
            // 
            // btnRacun
            // 
            this.btnRacun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.btnRacun.FlatAppearance.BorderSize = 0;
            this.btnRacun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRacun.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRacun.Location = new System.Drawing.Point(756, 838);
            this.btnRacun.Margin = new System.Windows.Forms.Padding(4);
            this.btnRacun.Name = "btnRacun";
            this.btnRacun.Size = new System.Drawing.Size(110, 36);
            this.btnRacun.TabIndex = 75;
            this.btnRacun.Text = "Za račun";
            this.btnRacun.UseVisualStyleBackColor = false;
            // 
            // btnIzpis
            // 
            this.btnIzpis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.btnIzpis.FlatAppearance.BorderSize = 0;
            this.btnIzpis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzpis.ForeColor = System.Drawing.SystemColors.Window;
            this.btnIzpis.Location = new System.Drawing.Point(634, 838);
            this.btnIzpis.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzpis.Name = "btnIzpis";
            this.btnIzpis.Size = new System.Drawing.Size(110, 36);
            this.btnIzpis.TabIndex = 76;
            this.btnIzpis.Text = "Izpis";
            this.btnIzpis.UseVisualStyleBackColor = false;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Stevilka
            // 
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Stevilka.DefaultCellStyle = dataGridViewCellStyle7;
            this.Stevilka.HeaderText = "Številka";
            this.Stevilka.Name = "Stevilka";
            this.Stevilka.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // Imenik
            // 
            this.Imenik.HeaderText = "   Imenik";
            this.Imenik.Name = "Imenik";
            this.Imenik.ReadOnly = true;
            // 
            // tbSm
            // 
            this.tbSm.Location = new System.Drawing.Point(620, 561);
            this.tbSm.Name = "tbSm";
            this.tbSm.Size = new System.Drawing.Size(63, 26);
            this.tbSm.TabIndex = 77;
            this.tbSm.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // lsm
            // 
            this.lsm.AutoSize = true;
            this.lsm.Location = new System.Drawing.Point(697, 569);
            this.lsm.Name = "lsm";
            this.lsm.Size = new System.Drawing.Size(117, 18);
            this.lsm.TabIndex = 78;
            this.lsm.Text = "stroškovno mesto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(621, 540);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 18);
            this.label9.TabIndex = 79;
            this.label9.Text = "SM";
            // 
            // frmTelBaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 907);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lsm);
            this.Controls.Add(this.tbSm);
            this.Controls.Add(this.btnIzpis);
            this.Controls.Add(this.btnRacun);
            this.Controls.Add(this.stevilke);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbOpombe);
            this.Controls.Add(this.cbObjekt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbOseba);
            this.Controls.Add(this.lOseba);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.chbImenik);
            this.Controls.Add(this.chbAktivna);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbOpis);
            this.Controls.Add(this.tbMpo);
            this.Controls.Add(this.tbStevilka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIskanje);
            this.Controls.Add(this.cbSkupina);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.crtal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPreklici);
            this.Controls.Add(this.btnShrani);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnSpremeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnNazaj);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTelBaza";
            this.Text = "frmTelBaza";
            this.Load += new System.EventHandler(this.frmTelBaza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.p2.ResumeLayout(false);
            this.p2.PerformLayout();
            this.p1.ResumeLayout(false);
            this.p1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPreklici;
        private System.Windows.Forms.Button btnShrani;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnSpremeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnNazaj;
        private System.Windows.Forms.Label crtal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.ComboBox cbSkupina;
        private System.Windows.Forms.TextBox tbIskanje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbStevilka;
        private System.Windows.Forms.TextBox tbMpo;
        private System.Windows.Forms.TextBox tbOpis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chbImenik;
        private System.Windows.Forms.RadioButton rbOseba;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.RadioButton rbDrugo;
        private System.Windows.Forms.RadioButton rbTelemetrija;
        private System.Windows.Forms.CheckBox chbAktivna;
        private System.Windows.Forms.RadioButton rbInternet;
        private System.Windows.Forms.Label lOseba;
        private System.Windows.Forms.ComboBox cbOseba;
        private System.Windows.Forms.ComboBox cbObjekt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbOpombe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.RadioButton rbStacionarna;
        private System.Windows.Forms.RadioButton rbMobilna;
        private System.Windows.Forms.Label stevilke;
        private System.Windows.Forms.Button btnRacun;
        private System.Windows.Forms.Button btnIzpis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stevilka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Imenik;
        private System.Windows.Forms.TextBox tbSm;
        private System.Windows.Forms.Label lsm;
        private System.Windows.Forms.Label label9;
    }
}