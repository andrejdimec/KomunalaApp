namespace Komunala
{
    partial class frmStoritve
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSpremeni = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnNazaj = new System.Windows.Forms.Button();
            this.btnPreklici = new System.Windows.Forms.Button();
            this.btnShrani = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skupina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb2);
            this.groupBox1.Controls.Add(this.cb1);
            this.groupBox1.Controls.Add(this.tb1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(882, 87);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // cb3
            // 
            this.cb3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb3.FormattingEnabled = true;
            this.cb3.Location = new System.Drawing.Point(663, 43);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(75, 22);
            this.cb3.TabIndex = 35;
            this.cb3.Enter += new System.EventHandler(this.cb3_Enter);
            this.cb3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb3_KeyDown);
            this.cb3.Leave += new System.EventHandler(this.cb3_Leave);
            this.cb3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb3_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(665, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 14);
            this.label5.TabIndex = 38;
            this.label5.Text = "DDV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(17, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 14);
            this.label4.TabIndex = 35;
            this.label4.Text = "Skupina";
            // 
            // cb2
            // 
            this.cb2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb2.FormattingEnabled = true;
            this.cb2.Location = new System.Drawing.Point(575, 42);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(71, 22);
            this.cb2.TabIndex = 34;
            this.cb2.Enter += new System.EventHandler(this.cb2_Enter);
            this.cb2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb2_KeyDown);
            this.cb2.Leave += new System.EventHandler(this.cb2_Leave);
            this.cb2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb2_MouseClick);
            // 
            // cb1
            // 
            this.cb1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb1.Location = new System.Drawing.Point(17, 43);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(180, 22);
            this.cb1.TabIndex = 0;
            this.cb1.Enter += new System.EventHandler(this.cb1_Enter);
            this.cb1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb1_KeyDown);
            this.cb1.Leave += new System.EventHandler(this.cb1_Leave);
            this.cb1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb1_MouseClick);
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb1.Location = new System.Drawing.Point(205, 42);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(354, 22);
            this.tb1.TabIndex = 17;
            this.tb1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb1_KeyDown);
            this.tb1.Leave += new System.EventHandler(this.tb1_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(577, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 14);
            this.label2.TabIndex = 18;
            this.label2.Text = "Enota mere";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(202, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "Storitev";
            // 
            // btnSpremeni
            // 
            this.btnSpremeni.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremeni.Location = new System.Drawing.Point(111, 24);
            this.btnSpremeni.Name = "btnSpremeni";
            this.btnSpremeni.Size = new System.Drawing.Size(89, 23);
            this.btnSpremeni.TabIndex = 11;
            this.btnSpremeni.Text = "F3 - Spremeni";
            this.btnSpremeni.UseVisualStyleBackColor = true;
            this.btnSpremeni.Click += new System.EventHandler(this.btnSpremeni_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToResizeColumns = false;
            this.dgv1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.ColumnHeadersVisible = false;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.col5,
            this.EM,
            this.DDV,
            this.Skupina});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv1.Location = new System.Drawing.Point(11, 24);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(860, 730);
            this.dgv1.TabIndex = 9;
            this.dgv1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellDoubleClick);
            this.dgv1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv1_KeyDown);
            // 
            // btnBrisi
            // 
            this.btnBrisi.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBrisi.Location = new System.Drawing.Point(206, 24);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(89, 23);
            this.btnBrisi.TabIndex = 12;
            this.btnBrisi.Text = "Del - Briši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.Location = new System.Drawing.Point(16, 24);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(89, 23);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "F2 - Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnNazaj
            // 
            this.btnNazaj.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNazaj.Location = new System.Drawing.Point(782, 24);
            this.btnNazaj.Name = "btnNazaj";
            this.btnNazaj.Size = new System.Drawing.Size(89, 23);
            this.btnNazaj.TabIndex = 16;
            this.btnNazaj.Text = "Nazaj";
            this.btnNazaj.UseVisualStyleBackColor = true;
            this.btnNazaj.Click += new System.EventHandler(this.btnNazaj_Click);
            // 
            // btnPreklici
            // 
            this.btnPreklici.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPreklici.Location = new System.Drawing.Point(419, 24);
            this.btnPreklici.Name = "btnPreklici";
            this.btnPreklici.Size = new System.Drawing.Size(89, 23);
            this.btnPreklici.TabIndex = 14;
            this.btnPreklici.Text = "Esc - Prekliči";
            this.btnPreklici.UseVisualStyleBackColor = true;
            this.btnPreklici.Click += new System.EventHandler(this.btnPreklici_Click);
            // 
            // btnShrani
            // 
            this.btnShrani.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShrani.Location = new System.Drawing.Point(324, 24);
            this.btnShrani.Name = "btnShrani";
            this.btnShrani.Size = new System.Drawing.Size(89, 23);
            this.btnShrani.TabIndex = 13;
            this.btnShrani.Text = "F5 - Shrani";
            this.btnShrani.UseVisualStyleBackColor = true;
            this.btnShrani.Click += new System.EventHandler(this.btnShrani_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(33, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Šifrant storitev";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDodaj);
            this.groupBox2.Controls.Add(this.btnSpremeni);
            this.groupBox2.Controls.Add(this.btnBrisi);
            this.groupBox2.Controls.Add(this.btnShrani);
            this.groupBox2.Controls.Add(this.btnPreklici);
            this.groupBox2.Controls.Add(this.btnNazaj);
            this.groupBox2.Location = new System.Drawing.Point(12, 909);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(882, 65);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv1);
            this.groupBox3.Location = new System.Drawing.Point(12, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(882, 768);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // col5
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.col5.DefaultCellStyle = dataGridViewCellStyle2;
            this.col5.HeaderText = "Storitev";
            this.col5.Name = "col5";
            this.col5.ReadOnly = true;
            this.col5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col5.Width = 350;
            // 
            // EM
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.EM.DefaultCellStyle = dataGridViewCellStyle3;
            this.EM.HeaderText = "EM";
            this.EM.Name = "EM";
            this.EM.ReadOnly = true;
            // 
            // DDV
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DDV.DefaultCellStyle = dataGridViewCellStyle4;
            this.DDV.HeaderText = "DDV";
            this.DDV.Name = "DDV";
            this.DDV.ReadOnly = true;
            // 
            // Skupina
            // 
            this.Skupina.HeaderText = "Skupina";
            this.Skupina.Name = "Skupina";
            this.Skupina.ReadOnly = true;
            // 
            // frmStoritve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 982);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "frmStoritve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vozila in delovni stroji";
            this.Load += new System.EventHandler(this.frmVozila_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVozila_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmVozila_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSpremeni;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnNazaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPreklici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShrani;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cb3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col5;
        private System.Windows.Forms.DataGridViewTextBoxColumn EM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skupina;
    }
}