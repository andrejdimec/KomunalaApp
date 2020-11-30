namespace Komunala
{
    partial class frmCenikt_Izpis
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
            this.crvCenikt = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crCeniktrg1 = new Komunala.crCeniktrg();
            this.SuspendLayout();
            // 
            // crvCenikt
            // 
            this.crvCenikt.ActiveViewIndex = 0;
            this.crvCenikt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCenikt.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCenikt.DisplayStatusBar = false;
            this.crvCenikt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCenikt.Location = new System.Drawing.Point(0, 0);
            this.crvCenikt.Name = "crvCenikt";
            this.crvCenikt.ReportSource = this.crCeniktrg1;
            this.crvCenikt.Size = new System.Drawing.Size(922, 729);
            this.crvCenikt.TabIndex = 0;
            this.crvCenikt.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmCenikt_Izpis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 729);
            this.Controls.Add(this.crvCenikt);
            this.Name = "frmCenikt_Izpis";
            this.Text = "frmCenikt_Izpis";
            this.Load += new System.EventHandler(this.frmCenikt_Izpis_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCenikt;
        private crCeniktrg crCeniktrg1;
    }
}