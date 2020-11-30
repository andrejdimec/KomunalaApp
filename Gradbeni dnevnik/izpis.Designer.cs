namespace Komunala
{
    partial class frmIzpis
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
            this.crv2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv2
            // 
            this.crv2.ActiveViewIndex = -1;
            this.crv2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv2.Location = new System.Drawing.Point(0, 0);
            this.crv2.Name = "crv2";
            this.crv2.Size = new System.Drawing.Size(952, 795);
            this.crv2.TabIndex = 0;
            this.crv2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmIzpis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 795);
            this.Controls.Add(this.crv2);
            this.Name = "frmIzpis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "izpis";
            this.Load += new System.EventHandler(this.frmIzpis_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv2;
    }
}