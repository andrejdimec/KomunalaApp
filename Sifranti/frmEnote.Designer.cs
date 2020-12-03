namespace Komunala
{
    partial class frmEnote
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShrani = new System.Windows.Forms.Button();
            this.btnPreklici = new System.Windows.Forms.Button();
            this.btnNazaj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnSpremeni = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.crtal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToResizeColumns = false;
            this.dgv1.AllowUserToResizeRows = false;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv1.Location = new System.Drawing.Point(27, 179);
            this.dgv1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(347, 307);
            this.dgv1.TabIndex = 9;
            this.dgv1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellDoubleClick);
            this.dgv1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv1_KeyDown);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(27, 128);
            this.tb1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(81, 26);
            this.tb1.TabIndex = 17;
            this.tb1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb1_KeyDown);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(135, 128);
            this.tb2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(237, 26);
            this.tb2.TabIndex = 19;
            this.tb2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb2_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Opis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enota";
            // 
            // btnShrani
            // 
            this.btnShrani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnShrani.FlatAppearance.BorderSize = 0;
            this.btnShrani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShrani.Location = new System.Drawing.Point(27, 555);
            this.btnShrani.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShrani.Name = "btnShrani";
            this.btnShrani.Size = new System.Drawing.Size(100, 32);
            this.btnShrani.TabIndex = 13;
            this.btnShrani.Text = "Shrani";
            this.btnShrani.UseVisualStyleBackColor = false;
            this.btnShrani.Click += new System.EventHandler(this.btnShrani_Click);
            // 
            // btnPreklici
            // 
            this.btnPreklici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPreklici.FlatAppearance.BorderSize = 0;
            this.btnPreklici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreklici.Location = new System.Drawing.Point(151, 555);
            this.btnPreklici.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPreklici.Name = "btnPreklici";
            this.btnPreklici.Size = new System.Drawing.Size(100, 32);
            this.btnPreklici.TabIndex = 14;
            this.btnPreklici.Text = "Prekliči";
            this.btnPreklici.UseVisualStyleBackColor = false;
            this.btnPreklici.Click += new System.EventHandler(this.btnPreklici_Click);
            // 
            // btnNazaj
            // 
            this.btnNazaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnNazaj.FlatAppearance.BorderSize = 0;
            this.btnNazaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazaj.Location = new System.Drawing.Point(274, 555);
            this.btnNazaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNazaj.Name = "btnNazaj";
            this.btnNazaj.Size = new System.Drawing.Size(100, 32);
            this.btnNazaj.TabIndex = 16;
            this.btnNazaj.Text = "Izhod";
            this.btnNazaj.UseVisualStyleBackColor = true;
            this.btnNazaj.Click += new System.EventHandler(this.btnNazaj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Location = new System.Drawing.Point(27, 505);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 32);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnSpremeni
            // 
            this.btnSpremeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSpremeni.FlatAppearance.BorderSize = 0;
            this.btnSpremeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremeni.Location = new System.Drawing.Point(151, 505);
            this.btnSpremeni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSpremeni.Name = "btnSpremeni";
            this.btnSpremeni.Size = new System.Drawing.Size(100, 32);
            this.btnSpremeni.TabIndex = 11;
            this.btnSpremeni.Text = "Spremeni";
            this.btnSpremeni.UseVisualStyleBackColor = false;
            this.btnSpremeni.Click += new System.EventHandler(this.btnSpremeni_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBrisi.FlatAppearance.BorderSize = 0;
            this.btnBrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrisi.Location = new System.Drawing.Point(274, 505);
            this.btnBrisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(100, 32);
            this.btnBrisi.TabIndex = 12;
            this.btnBrisi.Text = "Briši";
            this.btnBrisi.UseVisualStyleBackColor = false;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(21, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "Šifrant merskih enot";
            // 
            // crtal
            // 
            this.crtal.Location = new System.Drawing.Point(24, 55);
            this.crtal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.crtal.Name = "crtal";
            this.crtal.Size = new System.Drawing.Size(350, 18);
            this.crtal.TabIndex = 22;
            this.crtal.Text = "Enota";
            // 
            // frmEnote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(402, 606);
            this.Controls.Add(this.crtal);
            this.Controls.Add(this.btnSpremeni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.btnShrani);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnPreklici);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNazaj);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEnote";
            this.Text = "Komunala Radgona";
            this.Load += new System.EventHandler(this.frmEnote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShrani;
        private System.Windows.Forms.Button btnPreklici;
        private System.Windows.Forms.Button btnNazaj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnSpremeni;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label crtal;
    }
}