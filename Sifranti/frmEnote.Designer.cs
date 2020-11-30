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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToResizeColumns = false;
            this.dgv1.AllowUserToResizeRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.ColumnHeadersVisible = false;
            this.dgv1.Location = new System.Drawing.Point(27, 95);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(260, 222);
            this.dgv1.TabIndex = 9;
            this.dgv1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellDoubleClick);
            this.dgv1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv1_KeyDown);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(27, 45);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(62, 20);
            this.tb1.TabIndex = 17;
            this.tb1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb1_KeyDown);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(108, 45);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(179, 20);
            this.tb2.TabIndex = 19;
            this.tb2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb2_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Opis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enota";
            // 
            // btnShrani
            // 
            this.btnShrani.Location = new System.Drawing.Point(27, 389);
            this.btnShrani.Name = "btnShrani";
            this.btnShrani.Size = new System.Drawing.Size(75, 23);
            this.btnShrani.TabIndex = 13;
            this.btnShrani.Text = "Shrani";
            this.btnShrani.UseVisualStyleBackColor = true;
            this.btnShrani.Click += new System.EventHandler(this.btnShrani_Click);
            // 
            // btnPreklici
            // 
            this.btnPreklici.Location = new System.Drawing.Point(108, 389);
            this.btnPreklici.Name = "btnPreklici";
            this.btnPreklici.Size = new System.Drawing.Size(75, 23);
            this.btnPreklici.TabIndex = 14;
            this.btnPreklici.Text = "Prekliči";
            this.btnPreklici.UseVisualStyleBackColor = true;
            this.btnPreklici.Click += new System.EventHandler(this.btnPreklici_Click);
            // 
            // btnNazaj
            // 
            this.btnNazaj.Location = new System.Drawing.Point(212, 389);
            this.btnNazaj.Name = "btnNazaj";
            this.btnNazaj.Size = new System.Drawing.Size(75, 23);
            this.btnNazaj.TabIndex = 16;
            this.btnNazaj.Text = "Nazaj";
            this.btnNazaj.UseVisualStyleBackColor = true;
            this.btnNazaj.Click += new System.EventHandler(this.btnNazaj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(27, 347);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnSpremeni
            // 
            this.btnSpremeni.Location = new System.Drawing.Point(108, 347);
            this.btnSpremeni.Name = "btnSpremeni";
            this.btnSpremeni.Size = new System.Drawing.Size(75, 23);
            this.btnSpremeni.TabIndex = 11;
            this.btnSpremeni.Text = "Spremeni";
            this.btnSpremeni.UseVisualStyleBackColor = true;
            this.btnSpremeni.Click += new System.EventHandler(this.btnSpremeni_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(212, 347);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(75, 23);
            this.btnBrisi.TabIndex = 12;
            this.btnBrisi.Text = "Briši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSpremeni);
            this.groupBox1.Controls.Add(this.dgv1);
            this.groupBox1.Controls.Add(this.btnBrisi);
            this.groupBox1.Controls.Add(this.tb1);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.tb2);
            this.groupBox1.Controls.Add(this.btnNazaj);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnPreklici);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnShrani);
            this.groupBox1.Location = new System.Drawing.Point(16, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 431);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(16, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Šifrant merskih enot";
            // 
            // frmEnote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 520);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEnote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Komunala Radgona";
            this.Load += new System.EventHandler(this.frmEnote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}