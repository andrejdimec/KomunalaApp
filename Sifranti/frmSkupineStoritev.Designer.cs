namespace Komunala
{
    partial class frmSkupineStoritev
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
            this.btnSpremeni = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnNazaj = new System.Windows.Forms.Button();
            this.btnPreklici = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShrani = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.crtal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpremeni
            // 
            this.btnSpremeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSpremeni.FlatAppearance.BorderSize = 0;
            this.btnSpremeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremeni.Location = new System.Drawing.Point(143, 474);
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
            this.dgv1.Location = new System.Drawing.Point(21, 173);
            this.dgv1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(347, 280);
            this.dgv1.TabIndex = 9;
            this.dgv1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellDoubleClick);
            this.dgv1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv1_KeyDown);
            // 
            // btnBrisi
            // 
            this.btnBrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBrisi.FlatAppearance.BorderSize = 0;
            this.btnBrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrisi.Location = new System.Drawing.Point(266, 474);
            this.btnBrisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(100, 32);
            this.btnBrisi.TabIndex = 12;
            this.btnBrisi.Text = "Briši";
            this.btnBrisi.UseVisualStyleBackColor = false;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(21, 125);
            this.tb1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(345, 26);
            this.tb1.TabIndex = 17;
            this.tb1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb1_KeyDown);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Location = new System.Drawing.Point(21, 474);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 32);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnNazaj
            // 
            this.btnNazaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnNazaj.FlatAppearance.BorderSize = 0;
            this.btnNazaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazaj.Location = new System.Drawing.Point(266, 526);
            this.btnNazaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNazaj.Name = "btnNazaj";
            this.btnNazaj.Size = new System.Drawing.Size(100, 32);
            this.btnNazaj.TabIndex = 16;
            this.btnNazaj.Text = "Izhod";
            this.btnNazaj.UseVisualStyleBackColor = false;
            this.btnNazaj.Click += new System.EventHandler(this.btnNazaj_Click);
            // 
            // btnPreklici
            // 
            this.btnPreklici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPreklici.FlatAppearance.BorderSize = 0;
            this.btnPreklici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreklici.Location = new System.Drawing.Point(143, 526);
            this.btnPreklici.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPreklici.Name = "btnPreklici";
            this.btnPreklici.Size = new System.Drawing.Size(100, 32);
            this.btnPreklici.TabIndex = 14;
            this.btnPreklici.Text = "Prekliči";
            this.btnPreklici.UseVisualStyleBackColor = false;
            this.btnPreklici.Click += new System.EventHandler(this.btnPreklici_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Skupina";
            // 
            // btnShrani
            // 
            this.btnShrani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnShrani.FlatAppearance.BorderSize = 0;
            this.btnShrani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShrani.Location = new System.Drawing.Point(21, 526);
            this.btnShrani.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShrani.Name = "btnShrani";
            this.btnShrani.Size = new System.Drawing.Size(100, 32);
            this.btnShrani.TabIndex = 13;
            this.btnShrani.Text = "Shrani";
            this.btnShrani.UseVisualStyleBackColor = false;
            this.btnShrani.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 27);
            this.label1.TabIndex = 32;
            this.label1.Text = "Skupine storitev";
            // 
            // crtal
            // 
            this.crtal.Location = new System.Drawing.Point(18, 55);
            this.crtal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.crtal.Name = "crtal";
            this.crtal.Size = new System.Drawing.Size(348, 18);
            this.crtal.TabIndex = 33;
            this.crtal.Text = "Skupina";
            // 
            // frmSkupineStoritev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 583);
            this.Controls.Add(this.crtal);
            this.Controls.Add(this.btnSpremeni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.btnShrani);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNazaj);
            this.Controls.Add(this.btnPreklici);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSkupineStoritev";
            this.Text = "Vrste storitev";
            this.Load += new System.EventHandler(this.frmVrsteStoritev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSpremeni;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnNazaj;
        private System.Windows.Forms.Button btnPreklici;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShrani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label crtal;
    }
}