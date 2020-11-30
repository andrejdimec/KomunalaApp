namespace Komunala
{
    partial class frmSituacija_izpis
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
            this.crvSituacije = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvSituacije
            // 
            this.crvSituacije.ActiveViewIndex = -1;
            this.crvSituacije.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSituacije.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvSituacije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvSituacije.Location = new System.Drawing.Point(0, 0);
            this.crvSituacije.Name = "crvSituacije";
            this.crvSituacije.Size = new System.Drawing.Size(1784, 861);
            this.crvSituacije.TabIndex = 0;
            this.crvSituacije.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmSituacija_izpis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 861);
            this.Controls.Add(this.crvSituacije);
            this.Name = "frmSituacija_izpis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izpis situacije";
            this.Load += new System.EventHandler(this.frmSituacija_izpis_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSituacije;
    }
}