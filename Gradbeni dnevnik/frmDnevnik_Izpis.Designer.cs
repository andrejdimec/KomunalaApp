namespace Komunala
{
    partial class frmDnevnik_Izpis
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
            this.crv1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cr11 = new Komunala.cr1();
            this.SuspendLayout();
            // 
            // crv1
            // 
            this.crv1.ActiveViewIndex = -1;
            this.crv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv1.Location = new System.Drawing.Point(0, 0);
            this.crv1.Name = "crv1";
            this.crv1.ShowCopyButton = false;
            this.crv1.ShowGotoPageButton = false;
            this.crv1.ShowGroupTreeButton = false;
            this.crv1.ShowLogo = false;
            this.crv1.ShowParameterPanelButton = false;
            this.crv1.ShowRefreshButton = false;
            this.crv1.ShowTextSearchButton = false;
            this.crv1.ShowZoomButton = false;
            this.crv1.Size = new System.Drawing.Size(1143, 1093);
            this.crv1.TabIndex = 0;
            this.crv1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crv1.Load += new System.EventHandler(this.crv1_Load);
            // 
            // frmDnevnik_Izpis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 1093);
            this.Controls.Add(this.crv1);
            this.Name = "frmDnevnik_Izpis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Komunala Radgona";
            this.Load += new System.EventHandler(this.frmDnevnik_Izpis_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private cr1 cr11;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv1;
    }
}