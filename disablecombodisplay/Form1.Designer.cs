namespace TestWinForm
{
    partial class Form1
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
            this.regularCombo = new System.Windows.Forms.ComboBox();
            this.withEnableCombo = new EnableDisplayCombo.EnableDisplayCombo();
            this.enableDisplayCombo2 = new EnableDisplayCombo.EnableDisplayCombo();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regularCombo
            // 
            this.regularCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.regularCombo.FormattingEnabled = true;
            this.regularCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.regularCombo.Location = new System.Drawing.Point(224, 54);
            this.regularCombo.Name = "regularCombo";
            this.regularCombo.Size = new System.Drawing.Size(121, 23);
            this.regularCombo.TabIndex = 0;
            // 
            // withEnableCombo
            // 
            this.withEnableCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.withEnableCombo.FormattingEnabled = true;
            this.withEnableCombo.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.withEnableCombo.Location = new System.Drawing.Point(224, 107);
            this.withEnableCombo.Name = "withEnableCombo";
            this.withEnableCombo.Size = new System.Drawing.Size(121, 23);
            this.withEnableCombo.TabIndex = 1;
            // 
            // enableDisplayCombo2
            // 
            this.enableDisplayCombo2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.enableDisplayCombo2.FormattingEnabled = true;
            this.enableDisplayCombo2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.enableDisplayCombo2.Location = new System.Drawing.Point(224, 164);
            this.enableDisplayCombo2.Name = "enableDisplayCombo2";
            this.enableDisplayCombo2.Size = new System.Drawing.Size(121, 23);
            this.enableDisplayCombo2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Regular Combo, Disabled";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modified Combo, Disabled";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modified Combo, Enabled";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 260);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enableDisplayCombo2);
            this.Controls.Add(this.withEnableCombo);
            this.Controls.Add(this.regularCombo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox regularCombo;
        private EnableDisplayCombo.EnableDisplayCombo withEnableCombo;
        private EnableDisplayCombo.EnableDisplayCombo enableDisplayCombo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

