namespace Komunala
{
    partial class frmObcinaCenik
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnNazaj = new System.Windows.Forms.Button();
            this.btnIzpis = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnShrani = new System.Windows.Forms.Button();
            this.btnPreklici = new System.Windows.Forms.Button();
            this.btnSpremeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.crtal = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Storitev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.em = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena_o = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cenao_22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cenao95 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cena z 9,5 DDV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Enota mere";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cena z 22% DDV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Delavec / storitev";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cena brez DDV";
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(347, 343);
            this.tb3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(132, 26);
            this.tb3.TabIndex = 2;
            // 
            // tb7
            // 
            this.tb7.Location = new System.Drawing.Point(448, 228);
            this.tb7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb7.Name = "tb7";
            this.tb7.Size = new System.Drawing.Size(82, 26);
            this.tb7.TabIndex = 17;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(188, 343);
            this.tb2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(132, 26);
            this.tb2.TabIndex = 1;
            this.tb2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb2_KeyDown);
            // 
            // cb2
            // 
            this.cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb2.FormattingEnabled = true;
            this.cb2.Location = new System.Drawing.Point(28, 228);
            this.cb2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(395, 26);
            this.cb2.TabIndex = 16;
            this.cb2.DropDownClosed += new System.EventHandler(this.cb2_DropDownClosed);
            this.cb2.SelectedValueChanged += new System.EventHandler(this.cb2_SelectedValueChanged);
            this.cb2.Enter += new System.EventHandler(this.cb2_Enter);
            this.cb2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb2_KeyDown);
            this.cb2.Leave += new System.EventHandler(this.cb2_Leave);
            this.cb2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb2_MouseClick);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(28, 343);
            this.tb1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(132, 26);
            this.tb1.TabIndex = 0;
            this.tb1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb1_KeyDown);
            this.tb1.Leave += new System.EventHandler(this.tb1_Leave);
            // 
            // btnNazaj
            // 
            this.btnNazaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnNazaj.FlatAppearance.BorderSize = 0;
            this.btnNazaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazaj.Location = new System.Drawing.Point(289, 774);
            this.btnNazaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNazaj.Name = "btnNazaj";
            this.btnNazaj.Size = new System.Drawing.Size(110, 36);
            this.btnNazaj.TabIndex = 7;
            this.btnNazaj.Text = "Izhod";
            this.btnNazaj.UseVisualStyleBackColor = false;
            this.btnNazaj.Click += new System.EventHandler(this.btnNazaj_Click);
            // 
            // btnIzpis
            // 
            this.btnIzpis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnIzpis.FlatAppearance.BorderSize = 0;
            this.btnIzpis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzpis.Location = new System.Drawing.Point(420, 710);
            this.btnIzpis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIzpis.Name = "btnIzpis";
            this.btnIzpis.Size = new System.Drawing.Size(110, 36);
            this.btnIzpis.TabIndex = 6;
            this.btnIzpis.Text = "Izpis";
            this.btnIzpis.UseVisualStyleBackColor = false;
            this.btnIzpis.Click += new System.EventHandler(this.btnIzpis_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBrisi.FlatAppearance.BorderSize = 0;
            this.btnBrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrisi.Location = new System.Drawing.Point(289, 710);
            this.btnBrisi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(110, 36);
            this.btnBrisi.TabIndex = 4;
            this.btnBrisi.Text = "DEL - Briši";
            this.btnBrisi.UseVisualStyleBackColor = false;
            this.btnBrisi.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnShrani
            // 
            this.btnShrani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnShrani.FlatAppearance.BorderSize = 0;
            this.btnShrani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShrani.Location = new System.Drawing.Point(28, 774);
            this.btnShrani.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShrani.Name = "btnShrani";
            this.btnShrani.Size = new System.Drawing.Size(110, 36);
            this.btnShrani.TabIndex = 3;
            this.btnShrani.Text = "F5 - Shrani";
            this.btnShrani.UseVisualStyleBackColor = false;
            this.btnShrani.Click += new System.EventHandler(this.btnShrani_Click);
            // 
            // btnPreklici
            // 
            this.btnPreklici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPreklici.FlatAppearance.BorderSize = 0;
            this.btnPreklici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreklici.Location = new System.Drawing.Point(159, 774);
            this.btnPreklici.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPreklici.Name = "btnPreklici";
            this.btnPreklici.Size = new System.Drawing.Size(110, 36);
            this.btnPreklici.TabIndex = 2;
            this.btnPreklici.Text = "ESC - Prekliči";
            this.btnPreklici.UseVisualStyleBackColor = false;
            this.btnPreklici.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSpremeni
            // 
            this.btnSpremeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSpremeni.FlatAppearance.BorderSize = 0;
            this.btnSpremeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremeni.Location = new System.Drawing.Point(159, 710);
            this.btnSpremeni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSpremeni.Name = "btnSpremeni";
            this.btnSpremeni.Size = new System.Drawing.Size(110, 36);
            this.btnSpremeni.TabIndex = 1;
            this.btnSpremeni.Text = "F3 - Spremeni";
            this.btnSpremeni.UseVisualStyleBackColor = false;
            this.btnSpremeni.Click += new System.EventHandler(this.btnSpremeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Location = new System.Drawing.Point(28, 710);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(110, 36);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "F2 - Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(23, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cenik storitev za Občino";
            // 
            // cb1
            // 
            this.cb1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(28, 116);
            this.cb1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(303, 26);
            this.cb1.TabIndex = 15;
            this.cb1.SelectedValueChanged += new System.EventHandler(this.cb1_SelectedValueChanged);
            this.cb1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Vrsta storitev";
            // 
            // crtal
            // 
            this.crtal.Location = new System.Drawing.Point(27, 55);
            this.crtal.Name = "crtal";
            this.crtal.Size = new System.Drawing.Size(593, 18);
            this.crtal.TabIndex = 21;
            this.crtal.Text = "Vrsta storitev";
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToResizeColumns = false;
            this.dgv1.AllowUserToResizeRows = false;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv1.ColumnHeadersHeight = 25;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Storitev,
            this.em,
            this.Cena_o,
            this.Cenao_22,
            this.Cenao95});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgv1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv1.Location = new System.Drawing.Point(565, 22);
            this.dgv1.Margin = new System.Windows.Forms.Padding(0);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(739, 810);
            this.dgv1.TabIndex = 23;
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.em.DefaultCellStyle = dataGridViewCellStyle9;
            this.em.HeaderText = "EM";
            this.em.Name = "em";
            this.em.ReadOnly = true;
            // 
            // Cena_o
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.Cena_o.DefaultCellStyle = dataGridViewCellStyle10;
            this.Cena_o.HeaderText = "brez DDV";
            this.Cena_o.Name = "Cena_o";
            this.Cena_o.ReadOnly = true;
            // 
            // Cenao_22
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.Cenao_22.DefaultCellStyle = dataGridViewCellStyle11;
            this.Cenao_22.HeaderText = "z 22% DDV";
            this.Cenao_22.Name = "Cenao_22";
            this.Cenao_22.ReadOnly = true;
            // 
            // Cenao95
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.Cenao95.DefaultCellStyle = dataGridViewCellStyle12;
            this.Cenao95.HeaderText = "z 9,5 DDV";
            this.Cenao95.Name = "Cenao95";
            this.Cenao95.ReadOnly = true;
            // 
            // frmObcinaCenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 860);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.crtal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNazaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIzpis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.btnShrani);
            this.Controls.Add(this.tb7);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.btnPreklici);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.btnSpremeni);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.btnDodaj);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmObcinaCenik";
            this.Text = "frmObcinaCenik";
            this.Load += new System.EventHandler(this.frmObcinaCenik_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmObcinaCenik_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb7;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNazaj;
        private System.Windows.Forms.Button btnIzpis;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnShrani;
        private System.Windows.Forms.Button btnPreklici;
        private System.Windows.Forms.Button btnSpremeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label crtal;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Storitev;
        private System.Windows.Forms.DataGridViewTextBoxColumn em;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena_o;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cenao_22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cenao95;
    }
}