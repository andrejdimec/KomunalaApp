﻿namespace Komunala
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bm_nastavitve = new System.Windows.Forms.Button();
            this.bm_šifranti = new System.Windows.Forms.Button();
            this.bm_ijsvo = new System.Windows.Forms.Button();
            this.bm_izhod = new System.Windows.Forms.Button();
            this.bm_storitve = new System.Windows.Forms.Button();
            this.bm_ponudbe = new System.Windows.Forms.Button();
            this.bm_nalogi = new System.Windows.Forms.Button();
            this.bm_dnevnik = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tc = new TablessControl();
            this.tp_dnevnik = new System.Windows.Forms.TabPage();
            this.crta_dnevnik = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tp_storitve = new System.Windows.Forms.TabPage();
            this.cr_storitve = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tp_ponudbe = new System.Windows.Forms.TabPage();
            this.cr_ponudbe = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tp_nalogi = new System.Windows.Forms.TabPage();
            this.cr_nalogi = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tp_ijsvo = new System.Windows.Forms.TabPage();
            this.cr_ijsvo = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tp_sifranti = new System.Windows.Forms.TabPage();
            this.cr_sifranti = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tp_nastavitve = new System.Windows.Forms.TabPage();
            this.cr_nastavitve = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.lverzija = new System.Windows.Forms.Label();
            this.lbaza = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tc.SuspendLayout();
            this.tp_dnevnik.SuspendLayout();
            this.tp_storitve.SuspendLayout();
            this.tp_ponudbe.SuspendLayout();
            this.tp_nalogi.SuspendLayout();
            this.tp_ijsvo.SuspendLayout();
            this.tp_sifranti.SuspendLayout();
            this.tp_nastavitve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 603);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.splitContainer1.Panel1.Controls.Add(this.bm_nastavitve);
            this.splitContainer1.Panel1.Controls.Add(this.bm_šifranti);
            this.splitContainer1.Panel1.Controls.Add(this.bm_ijsvo);
            this.splitContainer1.Panel1.Controls.Add(this.bm_izhod);
            this.splitContainer1.Panel1.Controls.Add(this.bm_storitve);
            this.splitContainer1.Panel1.Controls.Add(this.bm_ponudbe);
            this.splitContainer1.Panel1.Controls.Add(this.bm_nalogi);
            this.splitContainer1.Panel1.Controls.Add(this.bm_dnevnik);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(936, 601);
            this.splitContainer1.SplitterDistance = 193;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 18;
            // 
            // bm_nastavitve
            // 
            this.bm_nastavitve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.bm_nastavitve.FlatAppearance.BorderSize = 0;
            this.bm_nastavitve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bm_nastavitve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bm_nastavitve.ForeColor = System.Drawing.Color.White;
            this.bm_nastavitve.Location = new System.Drawing.Point(-1, 395);
            this.bm_nastavitve.Name = "bm_nastavitve";
            this.bm_nastavitve.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bm_nastavitve.Size = new System.Drawing.Size(220, 57);
            this.bm_nastavitve.TabIndex = 18;
            this.bm_nastavitve.Text = "Nastavitve";
            this.bm_nastavitve.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bm_nastavitve.UseVisualStyleBackColor = false;
            this.bm_nastavitve.Click += new System.EventHandler(this.bm_nastavitve_Click);
            this.bm_nastavitve.MouseEnter += new System.EventHandler(this.bm_nastavitve_MouseEnter);
            this.bm_nastavitve.MouseLeave += new System.EventHandler(this.bm_nastavitve_MouseLeave);
            // 
            // bm_šifranti
            // 
            this.bm_šifranti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.bm_šifranti.FlatAppearance.BorderSize = 0;
            this.bm_šifranti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bm_šifranti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bm_šifranti.ForeColor = System.Drawing.Color.White;
            this.bm_šifranti.Location = new System.Drawing.Point(-1, 332);
            this.bm_šifranti.Name = "bm_šifranti";
            this.bm_šifranti.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bm_šifranti.Size = new System.Drawing.Size(220, 57);
            this.bm_šifranti.TabIndex = 17;
            this.bm_šifranti.Text = "Šifranti";
            this.bm_šifranti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bm_šifranti.UseVisualStyleBackColor = false;
            this.bm_šifranti.Click += new System.EventHandler(this.bm_šifranti_Click);
            this.bm_šifranti.MouseEnter += new System.EventHandler(this.bm_šifranti_MouseEnter);
            this.bm_šifranti.MouseLeave += new System.EventHandler(this.bm_šifranti_MouseLeave);
            // 
            // bm_ijsvo
            // 
            this.bm_ijsvo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.bm_ijsvo.FlatAppearance.BorderSize = 0;
            this.bm_ijsvo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bm_ijsvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bm_ijsvo.ForeColor = System.Drawing.Color.White;
            this.bm_ijsvo.Location = new System.Drawing.Point(-1, 273);
            this.bm_ijsvo.Name = "bm_ijsvo";
            this.bm_ijsvo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bm_ijsvo.Size = new System.Drawing.Size(220, 57);
            this.bm_ijsvo.TabIndex = 16;
            this.bm_ijsvo.Text = "IJSVO";
            this.bm_ijsvo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bm_ijsvo.UseVisualStyleBackColor = false;
            this.bm_ijsvo.Click += new System.EventHandler(this.bm_ijsvo_Click);
            this.bm_ijsvo.MouseEnter += new System.EventHandler(this.bm_ijsvo_MouseEnter);
            this.bm_ijsvo.MouseLeave += new System.EventHandler(this.bm_ijsvo_MouseLeave);
            // 
            // bm_izhod
            // 
            this.bm_izhod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.bm_izhod.FlatAppearance.BorderSize = 0;
            this.bm_izhod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bm_izhod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bm_izhod.ForeColor = System.Drawing.Color.White;
            this.bm_izhod.Location = new System.Drawing.Point(-1, 524);
            this.bm_izhod.Name = "bm_izhod";
            this.bm_izhod.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bm_izhod.Size = new System.Drawing.Size(220, 57);
            this.bm_izhod.TabIndex = 4;
            this.bm_izhod.Text = "Izhod";
            this.bm_izhod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bm_izhod.UseVisualStyleBackColor = false;
            this.bm_izhod.Click += new System.EventHandler(this.button19_Click);
            this.bm_izhod.MouseEnter += new System.EventHandler(this.bm_izhod_MouseEnter);
            this.bm_izhod.MouseLeave += new System.EventHandler(this.bm_izhod_MouseLeave);
            // 
            // bm_storitve
            // 
            this.bm_storitve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.bm_storitve.FlatAppearance.BorderSize = 0;
            this.bm_storitve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bm_storitve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bm_storitve.ForeColor = System.Drawing.Color.White;
            this.bm_storitve.Location = new System.Drawing.Point(-1, 84);
            this.bm_storitve.Margin = new System.Windows.Forms.Padding(0);
            this.bm_storitve.Name = "bm_storitve";
            this.bm_storitve.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bm_storitve.Size = new System.Drawing.Size(224, 57);
            this.bm_storitve.TabIndex = 3;
            this.bm_storitve.Text = "Storitve GJS";
            this.bm_storitve.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bm_storitve.UseVisualStyleBackColor = false;
            this.bm_storitve.Click += new System.EventHandler(this.bm_storitve_Click);
            this.bm_storitve.Leave += new System.EventHandler(this.bm_storitve_Leave);
            this.bm_storitve.MouseEnter += new System.EventHandler(this.bm_storitve_MouseEnter);
            this.bm_storitve.MouseLeave += new System.EventHandler(this.bm_storitve_MouseLeave);
            // 
            // bm_ponudbe
            // 
            this.bm_ponudbe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.bm_ponudbe.FlatAppearance.BorderSize = 0;
            this.bm_ponudbe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bm_ponudbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bm_ponudbe.ForeColor = System.Drawing.Color.White;
            this.bm_ponudbe.Location = new System.Drawing.Point(-1, 144);
            this.bm_ponudbe.Name = "bm_ponudbe";
            this.bm_ponudbe.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bm_ponudbe.Size = new System.Drawing.Size(220, 57);
            this.bm_ponudbe.TabIndex = 2;
            this.bm_ponudbe.Text = "Ponudbe";
            this.bm_ponudbe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bm_ponudbe.UseVisualStyleBackColor = false;
            this.bm_ponudbe.Click += new System.EventHandler(this.bm_ponudbe_Click);
            this.bm_ponudbe.MouseEnter += new System.EventHandler(this.bm_ponudbe_MouseEnter);
            this.bm_ponudbe.MouseLeave += new System.EventHandler(this.bm_ponudbe_MouseLeave);
            // 
            // bm_nalogi
            // 
            this.bm_nalogi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.bm_nalogi.FlatAppearance.BorderSize = 0;
            this.bm_nalogi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bm_nalogi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bm_nalogi.ForeColor = System.Drawing.Color.White;
            this.bm_nalogi.Location = new System.Drawing.Point(-1, 207);
            this.bm_nalogi.Name = "bm_nalogi";
            this.bm_nalogi.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bm_nalogi.Size = new System.Drawing.Size(220, 57);
            this.bm_nalogi.TabIndex = 1;
            this.bm_nalogi.Text = "Potni nalogi";
            this.bm_nalogi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bm_nalogi.UseVisualStyleBackColor = false;
            this.bm_nalogi.Click += new System.EventHandler(this.bm_nalogi_Click);
            this.bm_nalogi.MouseEnter += new System.EventHandler(this.bm_nalogi_MouseEnter);
            this.bm_nalogi.MouseLeave += new System.EventHandler(this.bm_nalogi_MouseLeave);
            // 
            // bm_dnevnik
            // 
            this.bm_dnevnik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.bm_dnevnik.FlatAppearance.BorderSize = 0;
            this.bm_dnevnik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bm_dnevnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bm_dnevnik.ForeColor = System.Drawing.Color.White;
            this.bm_dnevnik.Location = new System.Drawing.Point(-1, 27);
            this.bm_dnevnik.Name = "bm_dnevnik";
            this.bm_dnevnik.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bm_dnevnik.Size = new System.Drawing.Size(220, 57);
            this.bm_dnevnik.TabIndex = 0;
            this.bm_dnevnik.Text = "Gradbeni dnevnik";
            this.bm_dnevnik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bm_dnevnik.UseVisualStyleBackColor = false;
            this.bm_dnevnik.Click += new System.EventHandler(this.bm_dnevnik_Click);
            this.bm_dnevnik.MouseEnter += new System.EventHandler(this.bm_dnevnik_MouseEnter);
            this.bm_dnevnik.MouseLeave += new System.EventHandler(this.bm_dnevnik_MouseLeave);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tc);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer2.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer2.Panel2.Controls.Add(this.lverzija);
            this.splitContainer2.Panel2.Controls.Add(this.lbaza);
            this.splitContainer2.Size = new System.Drawing.Size(742, 601);
            this.splitContainer2.SplitterDistance = 540;
            this.splitContainer2.TabIndex = 0;
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tp_dnevnik);
            this.tc.Controls.Add(this.tp_storitve);
            this.tc.Controls.Add(this.tp_ponudbe);
            this.tc.Controls.Add(this.tp_nalogi);
            this.tc.Controls.Add(this.tp_ijsvo);
            this.tc.Controls.Add(this.tp_sifranti);
            this.tc.Controls.Add(this.tp_nastavitve);
            this.tc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc.Location = new System.Drawing.Point(0, 0);
            this.tc.Margin = new System.Windows.Forms.Padding(0);
            this.tc.Name = "tc";
            this.tc.Padding = new System.Drawing.Point(0, 0);
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(742, 540);
            this.tc.TabIndex = 19;
            // 
            // tp_dnevnik
            // 
            this.tp_dnevnik.BackColor = System.Drawing.Color.AliceBlue;
            this.tp_dnevnik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tp_dnevnik.Controls.Add(this.crta_dnevnik);
            this.tp_dnevnik.Controls.Add(this.button2);
            this.tp_dnevnik.Controls.Add(this.label10);
            this.tp_dnevnik.Controls.Add(this.button1);
            this.tp_dnevnik.Controls.Add(this.button22);
            this.tp_dnevnik.Location = new System.Drawing.Point(4, 22);
            this.tp_dnevnik.Margin = new System.Windows.Forms.Padding(0);
            this.tp_dnevnik.Name = "tp_dnevnik";
            this.tp_dnevnik.Size = new System.Drawing.Size(734, 514);
            this.tp_dnevnik.TabIndex = 0;
            this.tp_dnevnik.Text = "Dnevnik";
            this.tp_dnevnik.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // crta_dnevnik
            // 
            this.crta_dnevnik.Location = new System.Drawing.Point(35, 64);
            this.crta_dnevnik.Name = "crta_dnevnik";
            this.crta_dnevnik.Size = new System.Drawing.Size(654, 12);
            this.crta_dnevnik.TabIndex = 18;
            this.crta_dnevnik.Text = "label8";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(48, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 33);
            this.label10.TabIndex = 17;
            this.label10.Text = "Gradbeni dnevnik";
            // 
            // tp_storitve
            // 
            this.tp_storitve.BackColor = System.Drawing.Color.AliceBlue;
            this.tp_storitve.Controls.Add(this.button5);
            this.tp_storitve.Controls.Add(this.cr_storitve);
            this.tp_storitve.Controls.Add(this.label11);
            this.tp_storitve.Controls.Add(this.button10);
            this.tp_storitve.Location = new System.Drawing.Point(4, 22);
            this.tp_storitve.Name = "tp_storitve";
            this.tp_storitve.Padding = new System.Windows.Forms.Padding(3);
            this.tp_storitve.Size = new System.Drawing.Size(734, 514);
            this.tp_storitve.TabIndex = 1;
            this.tp_storitve.Text = "Storitve";
            // 
            // cr_storitve
            // 
            this.cr_storitve.Location = new System.Drawing.Point(35, 64);
            this.cr_storitve.Name = "cr_storitve";
            this.cr_storitve.Size = new System.Drawing.Size(654, 12);
            this.cr_storitve.TabIndex = 23;
            this.cr_storitve.Text = "label8";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(48, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(470, 33);
            this.label11.TabIndex = 22;
            this.label11.Text = "Pregled storitev gospodarskih javnih služb";
            // 
            // tp_ponudbe
            // 
            this.tp_ponudbe.BackColor = System.Drawing.Color.AliceBlue;
            this.tp_ponudbe.Controls.Add(this.cr_ponudbe);
            this.tp_ponudbe.Controls.Add(this.label9);
            this.tp_ponudbe.Location = new System.Drawing.Point(4, 22);
            this.tp_ponudbe.Name = "tp_ponudbe";
            this.tp_ponudbe.Size = new System.Drawing.Size(734, 514);
            this.tp_ponudbe.TabIndex = 2;
            this.tp_ponudbe.Text = "Ponudbe";
            // 
            // cr_ponudbe
            // 
            this.cr_ponudbe.Location = new System.Drawing.Point(35, 64);
            this.cr_ponudbe.Name = "cr_ponudbe";
            this.cr_ponudbe.Size = new System.Drawing.Size(654, 12);
            this.cr_ponudbe.TabIndex = 25;
            this.cr_ponudbe.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(48, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 33);
            this.label9.TabIndex = 24;
            this.label9.Text = "Ponudbe";
            // 
            // tp_nalogi
            // 
            this.tp_nalogi.BackColor = System.Drawing.Color.AliceBlue;
            this.tp_nalogi.Controls.Add(this.cr_nalogi);
            this.tp_nalogi.Controls.Add(this.label13);
            this.tp_nalogi.Location = new System.Drawing.Point(4, 22);
            this.tp_nalogi.Name = "tp_nalogi";
            this.tp_nalogi.Size = new System.Drawing.Size(734, 514);
            this.tp_nalogi.TabIndex = 3;
            this.tp_nalogi.Text = "Nalogi";
            // 
            // cr_nalogi
            // 
            this.cr_nalogi.Location = new System.Drawing.Point(35, 64);
            this.cr_nalogi.Name = "cr_nalogi";
            this.cr_nalogi.Size = new System.Drawing.Size(654, 12);
            this.cr_nalogi.TabIndex = 25;
            this.cr_nalogi.Text = "label8";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(48, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 33);
            this.label13.TabIndex = 24;
            this.label13.Text = "Potni nalogi";
            // 
            // tp_ijsvo
            // 
            this.tp_ijsvo.BackColor = System.Drawing.Color.AliceBlue;
            this.tp_ijsvo.Controls.Add(this.cr_ijsvo);
            this.tp_ijsvo.Controls.Add(this.label15);
            this.tp_ijsvo.Location = new System.Drawing.Point(4, 22);
            this.tp_ijsvo.Name = "tp_ijsvo";
            this.tp_ijsvo.Size = new System.Drawing.Size(734, 514);
            this.tp_ijsvo.TabIndex = 4;
            this.tp_ijsvo.Text = "IJSVO";
            // 
            // cr_ijsvo
            // 
            this.cr_ijsvo.Location = new System.Drawing.Point(35, 64);
            this.cr_ijsvo.Name = "cr_ijsvo";
            this.cr_ijsvo.Size = new System.Drawing.Size(654, 12);
            this.cr_ijsvo.TabIndex = 25;
            this.cr_ijsvo.Text = "label8";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(48, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(189, 33);
            this.label15.TabIndex = 24;
            this.label15.Text = "Poročanje IJSVO";
            // 
            // tp_sifranti
            // 
            this.tp_sifranti.BackColor = System.Drawing.Color.AliceBlue;
            this.tp_sifranti.Controls.Add(this.button3);
            this.tp_sifranti.Controls.Add(this.button7);
            this.tp_sifranti.Controls.Add(this.button4);
            this.tp_sifranti.Controls.Add(this.button16);
            this.tp_sifranti.Controls.Add(this.button15);
            this.tp_sifranti.Controls.Add(this.button14);
            this.tp_sifranti.Controls.Add(this.button13);
            this.tp_sifranti.Controls.Add(this.cr_sifranti);
            this.tp_sifranti.Controls.Add(this.label17);
            this.tp_sifranti.Location = new System.Drawing.Point(4, 22);
            this.tp_sifranti.Name = "tp_sifranti";
            this.tp_sifranti.Size = new System.Drawing.Size(734, 514);
            this.tp_sifranti.TabIndex = 5;
            this.tp_sifranti.Text = "Šifranti";
            // 
            // cr_sifranti
            // 
            this.cr_sifranti.Location = new System.Drawing.Point(35, 64);
            this.cr_sifranti.Name = "cr_sifranti";
            this.cr_sifranti.Size = new System.Drawing.Size(654, 12);
            this.cr_sifranti.TabIndex = 25;
            this.cr_sifranti.Text = "label8";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(48, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 33);
            this.label17.TabIndex = 24;
            this.label17.Text = "Šifranti";
            // 
            // tp_nastavitve
            // 
            this.tp_nastavitve.BackColor = System.Drawing.Color.AliceBlue;
            this.tp_nastavitve.Controls.Add(this.cr_nastavitve);
            this.tp_nastavitve.Controls.Add(this.button6);
            this.tp_nastavitve.Controls.Add(this.label19);
            this.tp_nastavitve.Location = new System.Drawing.Point(4, 22);
            this.tp_nastavitve.Name = "tp_nastavitve";
            this.tp_nastavitve.Size = new System.Drawing.Size(734, 514);
            this.tp_nastavitve.TabIndex = 6;
            this.tp_nastavitve.Text = "Nastavitve";
            // 
            // cr_nastavitve
            // 
            this.cr_nastavitve.Location = new System.Drawing.Point(35, 64);
            this.cr_nastavitve.Name = "cr_nastavitve";
            this.cr_nastavitve.Size = new System.Drawing.Size(654, 12);
            this.cr_nastavitve.TabIndex = 25;
            this.cr_nastavitve.Text = "label8";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(112, 206);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 32);
            this.button6.TabIndex = 14;
            this.button6.Text = "Nastavitve";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(48, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(130, 33);
            this.label19.TabIndex = 24;
            this.label19.Text = "Nastavitve";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // lverzija
            // 
            this.lverzija.AutoSize = true;
            this.lverzija.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lverzija.ForeColor = System.Drawing.Color.Black;
            this.lverzija.Location = new System.Drawing.Point(507, 6);
            this.lverzija.Name = "lverzija";
            this.lverzija.Size = new System.Drawing.Size(69, 13);
            this.lverzija.TabIndex = 14;
            this.lverzija.Text = "v 28.10.2020";
            this.lverzija.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbaza
            // 
            this.lbaza.AutoSize = true;
            this.lbaza.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbaza.ForeColor = System.Drawing.Color.Black;
            this.lbaza.Location = new System.Drawing.Point(507, 24);
            this.lbaza.Name = "lbaza";
            this.lbaza.Size = new System.Drawing.Size(69, 13);
            this.lbaza.TabIndex = 15;
            this.lbaza.Text = "v 28.10.2020";
            this.lbaza.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Komunala.Resources.bm_situacije;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(496, 189);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 206);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Komunala.Resources.bm_pregled_dnevnikov;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(276, 189);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 206);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Transparent;
            this.button22.BackgroundImage = global::Komunala.Resources.gumbi_170x200_dnevnik;
            this.button22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button22.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Location = new System.Drawing.Point(54, 189);
            this.button22.Margin = new System.Windows.Forms.Padding(0);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(176, 206);
            this.button22.TabIndex = 3;
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::Komunala.Resources.bm_baze;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(276, 189);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 206);
            this.button5.TabIndex = 22;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.BackgroundImage = global::Komunala.Resources.bm_gjs;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(54, 189);
            this.button10.Margin = new System.Windows.Forms.Padding(0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(176, 206);
            this.button10.TabIndex = 19;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Komunala.Resources.gumbi_manjsi_sodelavci;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(379, 282);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 148);
            this.button3.TabIndex = 32;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImage = global::Komunala.Resources.gumbi_enote;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(216, 104);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(126, 148);
            this.button7.TabIndex = 31;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::Komunala.Resources.gumbi_cenik;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(216, 282);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 148);
            this.button4.TabIndex = 30;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Transparent;
            this.button16.BackgroundImage = global::Komunala.Resources.gumbi_podpisniki;
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(379, 104);
            this.button16.Margin = new System.Windows.Forms.Padding(0);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(126, 148);
            this.button16.TabIndex = 29;
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click_1);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Transparent;
            this.button15.BackgroundImage = global::Komunala.Resources.gumbi_manjši_ddv;
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(54, 104);
            this.button15.Margin = new System.Windows.Forms.Padding(0);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(126, 148);
            this.button15.TabIndex = 28;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Transparent;
            this.button14.BackgroundImage = global::Komunala.Resources.gumbi_manjši_skupine;
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(546, 104);
            this.button14.Margin = new System.Windows.Forms.Padding(0);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(126, 148);
            this.button14.TabIndex = 27;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click_1);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Transparent;
            this.button13.BackgroundImage = global::Komunala.Resources.bm_storitve;
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(54, 282);
            this.button13.Margin = new System.Windows.Forms.Padding(0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(126, 148);
            this.button13.TabIndex = 26;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Komunala.Properties.Resources.logo_komunala_radgona_2020_100;
            this.pictureBox1.Location = new System.Drawing.Point(58, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 31);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 603);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Komunala Radgona";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tc.ResumeLayout(false);
            this.tp_dnevnik.ResumeLayout(false);
            this.tp_dnevnik.PerformLayout();
            this.tp_storitve.ResumeLayout(false);
            this.tp_storitve.PerformLayout();
            this.tp_ponudbe.ResumeLayout(false);
            this.tp_ponudbe.PerformLayout();
            this.tp_nalogi.ResumeLayout(false);
            this.tp_nalogi.PerformLayout();
            this.tp_ijsvo.ResumeLayout(false);
            this.tp_ijsvo.PerformLayout();
            this.tp_sifranti.ResumeLayout(false);
            this.tp_sifranti.PerformLayout();
            this.tp_nastavitve.ResumeLayout(false);
            this.tp_nastavitve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bm_nastavitve;
        private System.Windows.Forms.Button bm_šifranti;
        private System.Windows.Forms.Button bm_ijsvo;
        private System.Windows.Forms.Button bm_izhod;
        private System.Windows.Forms.Button bm_storitve;
        private System.Windows.Forms.Button bm_ponudbe;
        private System.Windows.Forms.Button bm_nalogi;
        private System.Windows.Forms.Button bm_dnevnik;
        private System.Windows.Forms.Label lverzija;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Label lbaza;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button10;
        private TablessControl tc;
        private System.Windows.Forms.TabPage tp_dnevnik;
        private System.Windows.Forms.Label crta_dnevnik;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tp_storitve;
        private System.Windows.Forms.Label cr_storitve;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tp_ponudbe;
        private System.Windows.Forms.TabPage tp_nalogi;
        private System.Windows.Forms.TabPage tp_ijsvo;
        private System.Windows.Forms.TabPage tp_sifranti;
        private System.Windows.Forms.TabPage tp_nastavitve;
        private System.Windows.Forms.Label cr_ponudbe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label cr_nalogi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label cr_ijsvo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label cr_sifranti;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label cr_nastavitve;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
    }
}
