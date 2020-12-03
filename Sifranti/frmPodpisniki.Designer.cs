namespace Komunala
{
    partial class frmPodpisniki
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSpremeni = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.btnNazaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPreklici = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShrani = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.crtal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 509);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Zaporedje: Vrstni red skupin pri izpisu";
            // 
            // btnSpremeni
            // 
            this.btnSpremeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSpremeni.FlatAppearance.BorderSize = 0;
            this.btnSpremeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremeni.Location = new System.Drawing.Point(177, 554);
            this.btnSpremeni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSpremeni.Name = "btnSpremeni";
            this.btnSpremeni.Size = new System.Drawing.Size(100, 32);
            this.btnSpremeni.TabIndex = 11;
            this.btnSpremeni.Text = "Spremeni";
            this.btnSpremeni.UseVisualStyleBackColor = false;
            this.btnSpremeni.Click += new System.EventHandler(this.btnSpremeni_Click);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv1.Location = new System.Drawing.Point(24, 179);
            this.dgv1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(487, 307);
            this.dgv1.TabIndex = 9;
            this.dgv1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellDoubleClick);
            this.dgv1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv1_KeyDown);
            // 
            // btnBrisi
            // 
            this.btnBrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBrisi.FlatAppearance.BorderSize = 0;
            this.btnBrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrisi.Location = new System.Drawing.Point(324, 554);
            this.btnBrisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(100, 32);
            this.btnBrisi.TabIndex = 12;
            this.btnBrisi.Text = "Briši";
            this.btnBrisi.UseVisualStyleBackColor = false;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(341, 132);
            this.tb2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(168, 26);
            this.tb2.TabIndex = 17;
            this.tb2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb2_KeyDown);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Location = new System.Drawing.Point(29, 554);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 32);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(24, 132);
            this.tb1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(285, 26);
            this.tb1.TabIndex = 19;
            this.tb1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb1_KeyDown);
            // 
            // btnNazaj
            // 
            this.btnNazaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnNazaj.FlatAppearance.BorderSize = 0;
            this.btnNazaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazaj.Location = new System.Drawing.Point(324, 604);
            this.btnNazaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNazaj.Name = "btnNazaj";
            this.btnNazaj.Size = new System.Drawing.Size(100, 32);
            this.btnNazaj.TabIndex = 16;
            this.btnNazaj.Text = "Izhod";
            this.btnNazaj.UseVisualStyleBackColor = false;
            this.btnNazaj.Click += new System.EventHandler(this.btnNazaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ime in priimek";
            // 
            // btnPreklici
            // 
            this.btnPreklici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPreklici.FlatAppearance.BorderSize = 0;
            this.btnPreklici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreklici.Location = new System.Drawing.Point(177, 604);
            this.btnPreklici.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPreklici.Name = "btnPreklici";
            this.btnPreklici.Size = new System.Drawing.Size(100, 32);
            this.btnPreklici.TabIndex = 14;
            this.btnPreklici.Text = "Prekliči";
            this.btnPreklici.UseVisualStyleBackColor = false;
            this.btnPreklici.Click += new System.EventHandler(this.btnPreklici_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Funkcija";
            // 
            // btnShrani
            // 
            this.btnShrani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnShrani.FlatAppearance.BorderSize = 0;
            this.btnShrani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShrani.Location = new System.Drawing.Point(29, 604);
            this.btnShrani.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShrani.Name = "btnShrani";
            this.btnShrani.Size = new System.Drawing.Size(100, 32);
            this.btnShrani.TabIndex = 13;
            this.btnShrani.Text = "Shrani";
            this.btnShrani.UseVisualStyleBackColor = false;
            this.btnShrani.Click += new System.EventHandler(this.btnShrani_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "Podpisniki dokumentov";
            // 
            // crtal
            // 
            this.crtal.Location = new System.Drawing.Point(26, 52);
            this.crtal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.crtal.Name = "crtal";
            this.crtal.Size = new System.Drawing.Size(483, 18);
            this.crtal.TabIndex = 23;
            this.crtal.Text = "Ime in priimek";
            // 
            // frmPodpisniki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(535, 670);
            this.Controls.Add(this.crtal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSpremeni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnShrani);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnPreklici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNazaj);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPodpisniki";
            this.Text = "Komunala Radgona";
            this.Load += new System.EventHandler(this.frmPodpisniki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSpremeni;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Button btnNazaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPreklici;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShrani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label crtal;
    }
}