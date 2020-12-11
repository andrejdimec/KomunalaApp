
namespace Komunala
{
    partial class frmPogodbeTel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPogodbeTel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.button1 = new System.Windows.Forms.Button();
            this.tbStevilka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbVrsta = new System.Windows.Forms.ComboBox();
            this.crtal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDatoteka = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnPreklici = new System.Windows.Forms.Button();
            this.btnShrani = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnSpremeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnNazaj = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StDok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaDokumenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odpri = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(995, 338);
            this.axAcroPDF1.Margin = new System.Windows.Forms.Padding(4);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(227, 350);
            this.axAcroPDF1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1029, 282);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbStevilka
            // 
            this.tbStevilka.Location = new System.Drawing.Point(49, 619);
            this.tbStevilka.Name = "tbStevilka";
            this.tbStevilka.Size = new System.Drawing.Size(78, 26);
            this.tbStevilka.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 598);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Št. dok.";
            // 
            // cbVrsta
            // 
            this.cbVrsta.FormattingEnabled = true;
            this.cbVrsta.Location = new System.Drawing.Point(272, 619);
            this.cbVrsta.Name = "cbVrsta";
            this.cbVrsta.Size = new System.Drawing.Size(175, 26);
            this.cbVrsta.TabIndex = 4;
            // 
            // crtal
            // 
            this.crtal.Location = new System.Drawing.Point(43, 55);
            this.crtal.Name = "crtal";
            this.crtal.Size = new System.Drawing.Size(923, 18);
            this.crtal.TabIndex = 5;
            this.crtal.Text = "Crta";
            this.crtal.Click += new System.EventHandler(this.crtal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(41, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pogodbe in aneksi - telefonija";
            // 
            // dtDatum
            // 
            this.dtDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDatum.Location = new System.Drawing.Point(146, 619);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(109, 26);
            this.dtDatum.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 598);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vrsta dokumenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 598);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Opis";
            // 
            // tbOpis
            // 
            this.tbOpis.Location = new System.Drawing.Point(466, 619);
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.Size = new System.Drawing.Size(381, 26);
            this.tbOpis.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 598);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Datum";
            // 
            // btnDatoteka
            // 
            this.btnDatoteka.Location = new System.Drawing.Point(869, 615);
            this.btnDatoteka.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatoteka.Name = "btnDatoteka";
            this.btnDatoteka.Size = new System.Drawing.Size(100, 33);
            this.btnDatoteka.TabIndex = 12;
            this.btnDatoteka.Text = "Datoteka";
            this.btnDatoteka.UseVisualStyleBackColor = true;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.StDok,
            this.Datum,
            this.VrstaDokumenta,
            this.Opis,
            this.Odpri});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv1.Location = new System.Drawing.Point(46, 116);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv1.Size = new System.Drawing.Size(920, 459);
            this.dgv1.TabIndex = 13;
            // 
            // btnPreklici
            // 
            this.btnPreklici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.btnPreklici.FlatAppearance.BorderSize = 0;
            this.btnPreklici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreklici.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPreklici.Location = new System.Drawing.Point(606, 672);
            this.btnPreklici.Name = "btnPreklici";
            this.btnPreklici.Size = new System.Drawing.Size(120, 36);
            this.btnPreklici.TabIndex = 46;
            this.btnPreklici.Text = "Prekliči";
            this.btnPreklici.UseVisualStyleBackColor = false;
            // 
            // btnShrani
            // 
            this.btnShrani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.btnShrani.FlatAppearance.BorderSize = 0;
            this.btnShrani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShrani.ForeColor = System.Drawing.SystemColors.Window;
            this.btnShrani.Location = new System.Drawing.Point(466, 672);
            this.btnShrani.Name = "btnShrani";
            this.btnShrani.Size = new System.Drawing.Size(120, 36);
            this.btnShrani.TabIndex = 45;
            this.btnShrani.Text = "Shrani";
            this.btnShrani.UseVisualStyleBackColor = false;
            // 
            // btnBrisi
            // 
            this.btnBrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.btnBrisi.FlatAppearance.BorderSize = 0;
            this.btnBrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrisi.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBrisi.Location = new System.Drawing.Point(326, 672);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(120, 36);
            this.btnBrisi.TabIndex = 44;
            this.btnBrisi.Text = "Briši";
            this.btnBrisi.UseVisualStyleBackColor = false;
            // 
            // btnSpremeni
            // 
            this.btnSpremeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.btnSpremeni.FlatAppearance.BorderSize = 0;
            this.btnSpremeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremeni.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSpremeni.Location = new System.Drawing.Point(186, 672);
            this.btnSpremeni.Name = "btnSpremeni";
            this.btnSpremeni.Size = new System.Drawing.Size(120, 36);
            this.btnSpremeni.TabIndex = 43;
            this.btnSpremeni.Text = "Uredi";
            this.btnSpremeni.UseVisualStyleBackColor = false;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDodaj.Location = new System.Drawing.Point(46, 672);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(120, 36);
            this.btnDodaj.TabIndex = 42;
            this.btnDodaj.Text = "Nov dokument";
            this.btnDodaj.UseVisualStyleBackColor = false;
            // 
            // btnNazaj
            // 
            this.btnNazaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(77)))));
            this.btnNazaj.FlatAppearance.BorderSize = 0;
            this.btnNazaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazaj.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNazaj.Location = new System.Drawing.Point(846, 672);
            this.btnNazaj.Name = "btnNazaj";
            this.btnNazaj.Size = new System.Drawing.Size(120, 36);
            this.btnNazaj.TabIndex = 41;
            this.btnNazaj.Text = "Izhod";
            this.btnNazaj.UseVisualStyleBackColor = false;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // StDok
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StDok.DefaultCellStyle = dataGridViewCellStyle2;
            this.StDok.HeaderText = "Številka";
            this.StDok.Name = "StDok";
            this.StDok.ReadOnly = true;
            this.StDok.Width = 70;
            // 
            // Datum
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.Datum.DefaultCellStyle = dataGridViewCellStyle3;
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            this.Datum.Width = 90;
            // 
            // VrstaDokumenta
            // 
            this.VrstaDokumenta.HeaderText = "Vrsta dokumenta";
            this.VrstaDokumenta.Name = "VrstaDokumenta";
            this.VrstaDokumenta.ReadOnly = true;
            this.VrstaDokumenta.Width = 280;
            // 
            // Opis
            // 
            this.Opis.HeaderText = "Opis dokumenta";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            this.Opis.Width = 396;
            // 
            // Odpri
            // 
            this.Odpri.HeaderText = "";
            this.Odpri.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Odpri.Name = "Odpri";
            this.Odpri.ReadOnly = true;
            // 
            // frmPogodbeTel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 735);
            this.Controls.Add(this.btnPreklici);
            this.Controls.Add(this.btnShrani);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnSpremeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnNazaj);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btnDatoteka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbOpis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtDatum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.crtal);
            this.Controls.Add(this.cbVrsta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbStevilka);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axAcroPDF1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPogodbeTel";
            this.Text = "frmPogodbeTel";
            this.Load += new System.EventHandler(this.frmPogodbeTel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbStevilka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbVrsta;
        private System.Windows.Forms.Label crtal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbOpis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDatoteka;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnPreklici;
        private System.Windows.Forms.Button btnShrani;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnSpremeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnNazaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn StDok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaDokumenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewLinkColumn Odpri;
    }
}