
namespace Komunala.Kataster
{
    partial class frmLokacijeBass
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.cbl = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lz = new System.Windows.Forms.Label();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.tbom = new System.Windows.Forms.TextBox();
            this.btnNazaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lds = new System.Windows.Forms.Label();
            this.lza = new System.Windows.Forms.Label();
            this.lpr = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ln = new System.Windows.Forms.Label();
            this.lp = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lhsmid = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lomn = new System.Windows.Forms.Label();
            this.lom = new System.Windows.Forms.Label();
            this.dgvs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToOrderColumns = true;
            this.dgv1.AllowUserToResizeColumns = false;
            this.dgv1.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv1.EnableHeadersVisualStyles = false;
            this.dgv1.GridColor = System.Drawing.SystemColors.Control;
            this.dgv1.Location = new System.Drawing.Point(33, 62);
            this.dgv1.MultiSelect = false;
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(1330, 840);
            this.dgv1.TabIndex = 0;
            this.dgv1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_RowEnter);
            this.dgv1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv1_KeyDown);
            // 
            // cbl
            // 
            this.cbl.AutoSize = true;
            this.cbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbl.Location = new System.Drawing.Point(1252, 918);
            this.cbl.Name = "cbl";
            this.cbl.Size = new System.Drawing.Size(91, 19);
            this.cbl.TabIndex = 1;
            this.cbl.Text = "Brez lokacije";
            this.cbl.UseVisualStyleBackColor = true;
            this.cbl.CheckedChanged += new System.EventHandler(this.cbl_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(1274, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zapisov: ";
            // 
            // lz
            // 
            this.lz.AutoSize = true;
            this.lz.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lz.Location = new System.Drawing.Point(1323, 36);
            this.lz.Name = "lz";
            this.lz.Size = new System.Drawing.Size(54, 15);
            this.lz.TabIndex = 3;
            this.lz.Text = "Zapisov: ";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(16, 18);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(77, 19);
            this.rb1.TabIndex = 5;
            this.rb1.TabStop = true;
            this.rb1.Text = "Naziv OM";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb3);
            this.panel1.Controls.Add(this.rb2);
            this.panel1.Controls.Add(this.rb1);
            this.panel1.Location = new System.Drawing.Point(352, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 45);
            this.panel1.TabIndex = 6;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(227, 18);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(63, 19);
            this.rb3.TabIndex = 7;
            this.rb3.TabStop = true;
            this.rb3.Text = "Plačnik";
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.CheckedChanged += new System.EventHandler(this.rb3_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(119, 18);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(84, 19);
            this.rb2.TabIndex = 6;
            this.rb2.TabStop = true;
            this.rb2.Text = "Naslov OM";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // tbom
            // 
            this.tbom.Location = new System.Drawing.Point(33, 28);
            this.tbom.Name = "tbom";
            this.tbom.Size = new System.Drawing.Size(254, 23);
            this.tbom.TabIndex = 7;
            this.tbom.TextChanged += new System.EventHandler(this.tbom_TextChanged);
            this.tbom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbom_KeyDown);
            // 
            // btnNazaj
            // 
            this.btnNazaj.BackColor = System.Drawing.SystemColors.Window;
            this.btnNazaj.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNazaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazaj.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNazaj.Location = new System.Drawing.Point(1645, 952);
            this.btnNazaj.Name = "btnNazaj";
            this.btnNazaj.Size = new System.Drawing.Size(119, 40);
            this.btnNazaj.TabIndex = 8;
            this.btnNazaj.Text = "Konec";
            this.btnNazaj.UseVisualStyleBackColor = false;
            this.btnNazaj.Click += new System.EventHandler(this.btnNazaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lds);
            this.groupBox1.Controls.Add(this.lza);
            this.groupBox1.Controls.Add(this.lpr);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ln);
            this.groupBox1.Controls.Add(this.lp);
            this.groupBox1.Location = new System.Drawing.Point(1397, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 129);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plačnik";
            // 
            // lds
            // 
            this.lds.AutoSize = true;
            this.lds.Location = new System.Drawing.Point(296, 79);
            this.lds.Name = "lds";
            this.lds.Size = new System.Drawing.Size(22, 15);
            this.lds.TabIndex = 17;
            this.lds.Text = "lds";
            // 
            // lza
            // 
            this.lza.AutoSize = true;
            this.lza.Location = new System.Drawing.Point(237, 79);
            this.lza.Name = "lza";
            this.lza.Size = new System.Drawing.Size(21, 15);
            this.lza.TabIndex = 16;
            this.lza.Text = "lza";
            // 
            // lpr
            // 
            this.lpr.AutoSize = true;
            this.lpr.Location = new System.Drawing.Point(97, 79);
            this.lpr.Name = "lpr";
            this.lpr.Size = new System.Drawing.Size(21, 15);
            this.lpr.TabIndex = 15;
            this.lpr.Text = "lpr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Zavezanec za DDV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "DŠ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pravna oseba:";
            // 
            // ln
            // 
            this.ln.AutoSize = true;
            this.ln.Location = new System.Drawing.Point(18, 56);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(43, 15);
            this.ln.TabIndex = 10;
            this.ln.Text = "Naslov";
            // 
            // lp
            // 
            this.lp.AutoSize = true;
            this.lp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lp.Location = new System.Drawing.Point(17, 28);
            this.lp.Name = "lp";
            this.lp.Size = new System.Drawing.Size(55, 20);
            this.lp.TabIndex = 10;
            this.lp.Text = "Plačnik";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.lhsmid);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lomn);
            this.groupBox2.Controls.Add(this.lom);
            this.groupBox2.Location = new System.Drawing.Point(1397, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 123);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odjemno mesto";
            // 
            // lhsmid
            // 
            this.lhsmid.AutoSize = true;
            this.lhsmid.Location = new System.Drawing.Point(64, 79);
            this.lhsmid.Name = "lhsmid";
            this.lhsmid.Size = new System.Drawing.Size(38, 15);
            this.lhsmid.TabIndex = 15;
            this.lhsmid.Text = "label7";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "HSMID:";
            // 
            // lomn
            // 
            this.lomn.AutoSize = true;
            this.lomn.Location = new System.Drawing.Point(18, 56);
            this.lomn.Name = "lomn";
            this.lomn.Size = new System.Drawing.Size(43, 15);
            this.lomn.TabIndex = 10;
            this.lomn.Text = "Naslov";
            // 
            // lom
            // 
            this.lom.AutoSize = true;
            this.lom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lom.Location = new System.Drawing.Point(17, 28);
            this.lom.Name = "lom";
            this.lom.Size = new System.Drawing.Size(55, 20);
            this.lom.TabIndex = 10;
            this.lom.Text = "Plačnik";
            // 
            // dgvs
            // 
            this.dgvs.AllowUserToAddRows = false;
            this.dgvs.AllowUserToDeleteRows = false;
            this.dgvs.AllowUserToResizeColumns = false;
            this.dgvs.AllowUserToResizeRows = false;
            this.dgvs.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvs.ColumnHeadersHeight = 22;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvs.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvs.Enabled = false;
            this.dgvs.EnableHeadersVisualStyles = false;
            this.dgvs.GridColor = System.Drawing.SystemColors.Control;
            this.dgvs.Location = new System.Drawing.Point(1397, 366);
            this.dgvs.Name = "dgvs";
            this.dgvs.ReadOnly = true;
            this.dgvs.Size = new System.Drawing.Size(367, 536);
            this.dgvs.TabIndex = 21;
            // 
            // frmLokacijeBass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1798, 1039);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvs);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnNazaj);
            this.Controls.Add(this.tbom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbl);
            this.Controls.Add(this.dgv1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "frmLokacijeBass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odjemna mesta";
            this.Load += new System.EventHandler(this.frmLokacijeBass_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLokacijeBass_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.CheckBox cbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lz;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.TextBox tbom;
        private System.Windows.Forms.Button btnNazaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lp;
        private System.Windows.Forms.Label ln;
        private System.Windows.Forms.Label lds;
        private System.Windows.Forms.Label lza;
        private System.Windows.Forms.Label lpr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lhsmid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lomn;
        private System.Windows.Forms.Label lom;
        private System.Windows.Forms.DataGridView dgvs;
    }
}