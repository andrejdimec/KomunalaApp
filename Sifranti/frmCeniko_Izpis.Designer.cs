namespace Komunala
{
    partial class frmCeniko_Izpis
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
            this.crvCeniko = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crCeniko1 = new Komunala.crCeniko();
            this.SuspendLayout();
            // 
            // crvCeniko
            // 
            this.crvCeniko.ActiveViewIndex = 0;
            this.crvCeniko.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCeniko.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCeniko.DisplayStatusBar = false;
            this.crvCeniko.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCeniko.Location = new System.Drawing.Point(0, 0);
            this.crvCeniko.Name = "crvCeniko";
            this.crvCeniko.ReportSource = this.crCeniko1;
            this.crvCeniko.Size = new System.Drawing.Size(890, 628);
            this.crvCeniko.TabIndex = 0;
            this.crvCeniko.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmCeniko_Izpis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 628);
            this.Controls.Add(this.crvCeniko);
            this.Name = "frmCeniko_Izpis";
            this.Text = "Komunala Radgona";
            this.Load += new System.EventHandler(this.frmCeniko_Izpis_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCeniko;
        private crCeniko crCeniko1;
    }
}