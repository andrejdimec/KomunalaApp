namespace Komunala
{
    partial class frmDelovnaMesta
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.komunala_ds = new Komunala.komunala_ds();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tblDDVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEnoteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblEnoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.tbl_DelovnamestaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNazaj = new System.Windows.Forms.Button();
            this.btnPreklici = new System.Windows.Forms.Button();
            this.btnShrani = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnSpremeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.tbl_EnoteTableAdapter = new Komunala.komunala_dsTableAdapters.tbl_EnoteTableAdapter();
            this.tableAdapterManager = new Komunala.komunala_dsTableAdapters.TableAdapterManager();
            this.tbl_DDVTableAdapter = new Komunala.komunala_dsTableAdapters.tbl_DDVTableAdapter();
            this.tbl_DelovnamestaTableAdapter1 = new Komunala.komunala_dsTableAdapters.tbl_DelovnamestaTableAdapter();
            this.tblEnoteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblDDVBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cb3 = new System.Windows.Forms.ComboBox();
            this.cb4 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.komunala_ds)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDDVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEnoteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEnoteBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_DelovnamestaBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEnoteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDDVBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.komunala_ds, "tbl_Delovnamesta.Naziv", true));
            this.tb1.Location = new System.Drawing.Point(33, 55);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(187, 20);
            this.tb1.TabIndex = 0;
            // 
            // komunala_ds
            // 
            this.komunala_ds.DataSetName = "komunala_ds";
            this.komunala_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(33, 111);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(187, 20);
            this.tb2.TabIndex = 1;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(33, 221);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(100, 20);
            this.tb3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Delovno mesto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Opomba";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Urna postavka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "DDV (%)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb4);
            this.groupBox1.Controls.Add(this.cb3);
            this.groupBox1.Controls.Add(this.tb1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 330);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // tblDDVBindingSource
            // 
            this.tblDDVBindingSource.DataMember = "tbl_DDV";
            this.tblDDVBindingSource.DataSource = this.komunala_ds;
            // 
            // tblEnoteBindingSource1
            // 
            this.tblEnoteBindingSource1.DataMember = "tbl_Enote";
            this.tblEnoteBindingSource1.DataSource = this.komunala_ds;
            // 
            // tblEnoteBindingSource
            // 
            this.tblEnoteBindingSource.DataMember = "tbl_Enote";
            this.tblEnoteBindingSource.DataSource = this.komunala_ds;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv2);
            this.groupBox2.Location = new System.Drawing.Point(305, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 330);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv2.Location = new System.Drawing.Point(16, 22);
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv2.Size = new System.Drawing.Size(623, 291);
            this.dgv2.TabIndex = 13;
            this.dgv2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick_1);
            this.dgv2.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv2_CellMouseDoubleClick);
            this.dgv2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv2_KeyDown);
            this.dgv2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv1_MouseDoubleClick);
            // 
            // tbl_DelovnamestaBindingSource
            // 
            this.tbl_DelovnamestaBindingSource.DataMember = "tbl_Delovnamesta";
            this.tbl_DelovnamestaBindingSource.DataSource = this.komunala_ds;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNazaj);
            this.groupBox3.Controls.Add(this.btnPreklici);
            this.groupBox3.Controls.Add(this.btnShrani);
            this.groupBox3.Controls.Add(this.btnBrisi);
            this.groupBox3.Controls.Add(this.btnSpremeni);
            this.groupBox3.Controls.Add(this.btnDodaj);
            this.groupBox3.Location = new System.Drawing.Point(23, 378);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(937, 70);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // btnNazaj
            // 
            this.btnNazaj.Location = new System.Drawing.Point(846, 26);
            this.btnNazaj.Name = "btnNazaj";
            this.btnNazaj.Size = new System.Drawing.Size(75, 23);
            this.btnNazaj.TabIndex = 5;
            this.btnNazaj.Text = "Nazaj";
            this.btnNazaj.UseVisualStyleBackColor = true;
            this.btnNazaj.Click += new System.EventHandler(this.btnNazaj_Click);
            // 
            // btnPreklici
            // 
            this.btnPreklici.Location = new System.Drawing.Point(404, 26);
            this.btnPreklici.Name = "btnPreklici";
            this.btnPreklici.Size = new System.Drawing.Size(75, 23);
            this.btnPreklici.TabIndex = 4;
            this.btnPreklici.Text = "Prekliči";
            this.btnPreklici.UseVisualStyleBackColor = true;
            this.btnPreklici.Click += new System.EventHandler(this.btnPreklici_Click);
            // 
            // btnShrani
            // 
            this.btnShrani.Location = new System.Drawing.Point(313, 26);
            this.btnShrani.Name = "btnShrani";
            this.btnShrani.Size = new System.Drawing.Size(75, 23);
            this.btnShrani.TabIndex = 3;
            this.btnShrani.Text = "Shrani";
            this.btnShrani.UseVisualStyleBackColor = true;
            this.btnShrani.Click += new System.EventHandler(this.btnShrani_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(201, 26);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(75, 23);
            this.btnBrisi.TabIndex = 2;
            this.btnBrisi.Text = "Briši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // btnSpremeni
            // 
            this.btnSpremeni.Location = new System.Drawing.Point(110, 26);
            this.btnSpremeni.Name = "btnSpremeni";
            this.btnSpremeni.Size = new System.Drawing.Size(75, 23);
            this.btnSpremeni.TabIndex = 1;
            this.btnSpremeni.Text = "Spremeni";
            this.btnSpremeni.UseVisualStyleBackColor = true;
            this.btnSpremeni.Click += new System.EventHandler(this.btnSpremeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(19, 26);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // tbl_EnoteTableAdapter
            // 
            this.tbl_EnoteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_DDVTableAdapter = this.tbl_DDVTableAdapter;
            this.tableAdapterManager.tbl_DelovnamestaTableAdapter = null;
            this.tableAdapterManager.tbl_DnevnikTableAdapter = null;
            this.tableAdapterManager.tbl_EnoteTableAdapter = this.tbl_EnoteTableAdapter;
            this.tableAdapterManager.tbl_StrojiTableAdapter = null;
            this.tableAdapterManager.tbl_VozilaTableAdapter = null;
            this.tableAdapterManager.tbl_Vrstadela_TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Komunala.komunala_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_DDVTableAdapter
            // 
            this.tbl_DDVTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_DelovnamestaTableAdapter1
            // 
            this.tbl_DelovnamestaTableAdapter1.ClearBeforeFill = true;
            // 
            // tblEnoteBindingSource2
            // 
            this.tblEnoteBindingSource2.DataMember = "tbl_Enote";
            this.tblEnoteBindingSource2.DataSource = this.komunala_ds;
            // 
            // tblDDVBindingSource1
            // 
            this.tblDDVBindingSource1.DataMember = "tbl_DDV";
            this.tblDDVBindingSource1.DataSource = this.komunala_ds;
            // 
            // cb3
            // 
            this.cb3.AllowDrop = true;
            this.cb3.FormattingEnabled = true;
            this.cb3.Location = new System.Drawing.Point(33, 164);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(121, 21);
            this.cb3.TabIndex = 2;
            // 
            // cb4
            // 
            this.cb4.FormattingEnabled = true;
            this.cb4.Location = new System.Drawing.Point(33, 271);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(121, 21);
            this.cb4.TabIndex = 4;
            // 
            // frmDelovnaMesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 469);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDelovnaMesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Šifrant delovnih mest";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.komunala_ds)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDDVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEnoteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEnoteBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_DelovnamestaBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblEnoteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDDVBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnNazaj;
        private System.Windows.Forms.Button btnPreklici;
        private System.Windows.Forms.Button btnShrani;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnSpremeni;
        private System.Windows.Forms.Button btnDodaj;
        private komunala_ds komunala_ds;
        private System.Windows.Forms.BindingSource tblEnoteBindingSource;
        private komunala_dsTableAdapters.tbl_EnoteTableAdapter tbl_EnoteTableAdapter;
        private System.Windows.Forms.BindingSource tbl_DelovnamestaBindingSource;
        private komunala_dsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tblEnoteBindingSource1;
        private komunala_dsTableAdapters.tbl_DDVTableAdapter tbl_DDVTableAdapter;
        private System.Windows.Forms.BindingSource tblDDVBindingSource;
        private komunala_dsTableAdapters.tbl_DelovnamestaTableAdapter tbl_DelovnamestaTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource tblEnoteBindingSource2;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.BindingSource tblDDVBindingSource1;
        private System.Windows.Forms.ComboBox cb3;
        private System.Windows.Forms.ComboBox cb4;
    }
}