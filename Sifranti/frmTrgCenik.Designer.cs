﻿namespace Komunala
{
    partial class frmTrgCenik
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle73 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle78 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle74 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle75 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle76 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle77 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle79 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle80 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle81 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb7 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnNazaj = new System.Windows.Forms.Button();
            this.btnIzpis = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnShrani = new System.Windows.Forms.Button();
            this.btnPreklici = new System.Windows.Forms.Button();
            this.btnSpremeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Storitev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.em = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena_o = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cenao_22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cenao95 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(37, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cenik storitev za trg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Vrsta storitev";
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(44, 103);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(266, 21);
            this.cb1.TabIndex = 20;
            this.cb1.SelectedValueChanged += new System.EventHandler(this.cb1_SelectedValueChanged);
            this.cb1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb1_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb3);
            this.groupBox2.Controls.Add(this.tb7);
            this.groupBox2.Controls.Add(this.tb2);
            this.groupBox2.Controls.Add(this.cb2);
            this.groupBox2.Controls.Add(this.tb1);
            this.groupBox2.Location = new System.Drawing.Point(27, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 190);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cena z 9,5 DDV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Enota mere";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cena z 22% DDV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Delavec / storitev";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cena brez DDV";
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(294, 142);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(116, 20);
            this.tb3.TabIndex = 2;
            // 
            // tb7
            // 
            this.tb7.Location = new System.Drawing.Point(446, 53);
            this.tb7.Name = "tb7";
            this.tb7.Size = new System.Drawing.Size(88, 20);
            this.tb7.TabIndex = 17;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(155, 142);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(116, 20);
            this.tb2.TabIndex = 1;
            this.tb2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb2_KeyDown);
            // 
            // cb2
            // 
            this.cb2.FormattingEnabled = true;
            this.cb2.Location = new System.Drawing.Point(15, 53);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(412, 21);
            this.cb2.TabIndex = 16;
            this.cb2.DropDownClosed += new System.EventHandler(this.cb2_DropDownClosed);
            this.cb2.SelectedValueChanged += new System.EventHandler(this.cb2_SelectedValueChanged);
            this.cb2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb2_KeyDown);
            this.cb2.Leave += new System.EventHandler(this.cb2_Leave);
            this.cb2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb2_MouseClick);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(15, 142);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(116, 20);
            this.tb1.TabIndex = 0;
            this.tb1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb1_KeyDown);
            this.tb1.Leave += new System.EventHandler(this.tb1_Leave);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnNazaj);
            this.groupBox4.Controls.Add(this.btnIzpis);
            this.groupBox4.Controls.Add(this.btnBrisi);
            this.groupBox4.Controls.Add(this.btnShrani);
            this.groupBox4.Controls.Add(this.btnPreklici);
            this.groupBox4.Controls.Add(this.btnSpremeni);
            this.groupBox4.Controls.Add(this.btnDodaj);
            this.groupBox4.Location = new System.Drawing.Point(27, 557);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(546, 160);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            // 
            // btnNazaj
            // 
            this.btnNazaj.Location = new System.Drawing.Point(121, 91);
            this.btnNazaj.Name = "btnNazaj";
            this.btnNazaj.Size = new System.Drawing.Size(91, 34);
            this.btnNazaj.TabIndex = 7;
            this.btnNazaj.Text = "Konec";
            this.btnNazaj.UseVisualStyleBackColor = true;
            this.btnNazaj.Click += new System.EventHandler(this.btnNazaj_Click);
            // 
            // btnIzpis
            // 
            this.btnIzpis.Location = new System.Drawing.Point(15, 91);
            this.btnIzpis.Name = "btnIzpis";
            this.btnIzpis.Size = new System.Drawing.Size(91, 34);
            this.btnIzpis.TabIndex = 6;
            this.btnIzpis.Text = "Izpis";
            this.btnIzpis.UseVisualStyleBackColor = true;
            this.btnIzpis.Click += new System.EventHandler(this.btnIzpis_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(227, 31);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(91, 34);
            this.btnBrisi.TabIndex = 4;
            this.btnBrisi.Text = "DEL - Briši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // btnShrani
            // 
            this.btnShrani.Location = new System.Drawing.Point(333, 31);
            this.btnShrani.Name = "btnShrani";
            this.btnShrani.Size = new System.Drawing.Size(91, 34);
            this.btnShrani.TabIndex = 3;
            this.btnShrani.Text = "F5 - Shrani";
            this.btnShrani.UseVisualStyleBackColor = true;
            this.btnShrani.Click += new System.EventHandler(this.btnShrani_Click);
            // 
            // btnPreklici
            // 
            this.btnPreklici.Location = new System.Drawing.Point(439, 31);
            this.btnPreklici.Name = "btnPreklici";
            this.btnPreklici.Size = new System.Drawing.Size(91, 34);
            this.btnPreklici.TabIndex = 2;
            this.btnPreklici.Text = "ESC - Prekliči";
            this.btnPreklici.UseVisualStyleBackColor = true;
            this.btnPreklici.Click += new System.EventHandler(this.btnPreklici_Click);
            // 
            // btnSpremeni
            // 
            this.btnSpremeni.Location = new System.Drawing.Point(121, 31);
            this.btnSpremeni.Name = "btnSpremeni";
            this.btnSpremeni.Size = new System.Drawing.Size(91, 34);
            this.btnSpremeni.TabIndex = 1;
            this.btnSpremeni.Text = "F3 - Spremeni";
            this.btnSpremeni.UseVisualStyleBackColor = true;
            this.btnSpremeni.Click += new System.EventHandler(this.btnSpremeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(15, 31);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(91, 34);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "F2 - Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv1);
            this.groupBox1.Controls.Add(this.dgv2);
            this.groupBox1.Location = new System.Drawing.Point(606, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 702);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToResizeColumns = false;
            this.dgv1.AllowUserToResizeRows = false;
            dataGridViewCellStyle73.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle73.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle73.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle73.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle73.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle73.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle73.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle73;
            this.dgv1.ColumnHeadersHeight = 25;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Storitev,
            this.em,
            this.Cena_o,
            this.Cenao_22,
            this.Cenao95});
            this.dgv1.Location = new System.Drawing.Point(16, 49);
            this.dgv1.Margin = new System.Windows.Forms.Padding(0);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            dataGridViewCellStyle78.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle78.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle78.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle78.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle78.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle78.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle78.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.RowHeadersDefaultCellStyle = dataGridViewCellStyle78;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(647, 630);
            this.dgv1.TabIndex = 1;
            this.dgv1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellDoubleClick);
            this.dgv1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv1_KeyDown);
            this.dgv1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv1_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Storitev
            // 
            this.Storitev.HeaderText = "Storitev";
            this.Storitev.Name = "Storitev";
            this.Storitev.ReadOnly = true;
            // 
            // em
            // 
            dataGridViewCellStyle74.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.em.DefaultCellStyle = dataGridViewCellStyle74;
            this.em.HeaderText = "EM";
            this.em.Name = "em";
            this.em.ReadOnly = true;
            // 
            // Cena_o
            // 
            dataGridViewCellStyle75.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle75.Format = "N2";
            dataGridViewCellStyle75.NullValue = null;
            dataGridViewCellStyle75.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.Cena_o.DefaultCellStyle = dataGridViewCellStyle75;
            this.Cena_o.HeaderText = "brez DDV";
            this.Cena_o.Name = "Cena_o";
            this.Cena_o.ReadOnly = true;
            // 
            // Cenao_22
            // 
            dataGridViewCellStyle76.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle76.Format = "N2";
            dataGridViewCellStyle76.NullValue = null;
            dataGridViewCellStyle76.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.Cenao_22.DefaultCellStyle = dataGridViewCellStyle76;
            this.Cenao_22.HeaderText = "z 22% DDV";
            this.Cenao_22.Name = "Cenao_22";
            this.Cenao_22.ReadOnly = true;
            // 
            // Cenao95
            // 
            dataGridViewCellStyle77.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle77.Format = "N2";
            dataGridViewCellStyle77.NullValue = null;
            dataGridViewCellStyle77.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.Cenao95.DefaultCellStyle = dataGridViewCellStyle77;
            this.Cenao95.HeaderText = "z 9,5 DDV";
            this.Cenao95.Name = "Cenao95";
            this.Cenao95.ReadOnly = true;
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.AllowUserToOrderColumns = true;
            this.dgv2.AllowUserToResizeColumns = false;
            this.dgv2.AllowUserToResizeRows = false;
            this.dgv2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle79.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle79.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle79.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle79.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle79.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle79.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle79.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle79;
            this.dgv2.ColumnHeadersHeight = 25;
            this.dgv2.Location = new System.Drawing.Point(16, 21);
            this.dgv2.Margin = new System.Windows.Forms.Padding(0);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle80.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle80.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle80.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle80.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle80.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle80.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle80.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv2.RowHeadersDefaultCellStyle = dataGridViewCellStyle80;
            this.dgv2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle81.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle81.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.dgv2.RowsDefaultCellStyle = dataGridViewCellStyle81;
            this.dgv2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv2.Size = new System.Drawing.Size(647, 26);
            this.dgv2.TabIndex = 0;
            // 
            // frmTrgCenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 737);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb1);
            this.Name = "frmTrgCenik";
            this.Text = "Komunala Radgona";
            this.Load += new System.EventHandler(this.frmTrgCenik_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTrgCenik_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb7;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnNazaj;
        private System.Windows.Forms.Button btnIzpis;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnShrani;
        private System.Windows.Forms.Button btnPreklici;
        private System.Windows.Forms.Button btnSpremeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Storitev;
        private System.Windows.Forms.DataGridViewTextBoxColumn em;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena_o;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cenao_22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cenao95;
        private System.Windows.Forms.DataGridView dgv2;
    }
}