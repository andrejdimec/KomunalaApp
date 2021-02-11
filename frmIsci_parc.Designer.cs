
namespace Komunala
{
    partial class frmIsci_parc
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
            this.dgv5 = new System.Windows.Forms.DataGridView();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.l1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv5)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv5
            // 
            this.dgv5.AllowUserToAddRows = false;
            this.dgv5.AllowUserToDeleteRows = false;
            this.dgv5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv5.Location = new System.Drawing.Point(24, 146);
            this.dgv5.Margin = new System.Windows.Forms.Padding(4);
            this.dgv5.Name = "dgv5";
            this.dgv5.ReadOnly = true;
            this.dgv5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv5.Size = new System.Drawing.Size(290, 375);
            this.dgv5.TabIndex = 0;
            this.dgv5.DoubleClick += new System.EventHandler(this.dgv5_DoubleClick);
            this.dgv5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv5_KeyDown);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(157, 26);
            this.tb1.Margin = new System.Windows.Forms.Padding(4);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(74, 26);
            this.tb1.TabIndex = 20;
            this.tb1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Katastrska občina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Številka parcele";
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(157, 65);
            this.tb2.Margin = new System.Windows.Forms.Padding(4);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(119, 26);
            this.tb2.TabIndex = 30;
            this.tb2.TextChanged += new System.EventHandler(this.tb2_TextChanged);
            this.tb2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb2_KeyDown);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(32, 116);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(25, 18);
            this.l1.TabIndex = 32;
            this.l1.Text = "KO";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(108, 549);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 32);
            this.button3.TabIndex = 33;
            this.button3.Text = "Nazaj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmIsci_parc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 606);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.dgv5);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmIsci_parc";
            this.Text = "frmIsci_parc";
            this.Load += new System.EventHandler(this.frmIsci_parc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmIsci_parc_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv5;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Button button3;
    }
}