using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace EnableDisplayCombo
{
    public partial class EnableDisplayCombo : ComboBox
    {
        public EnableDisplayCombo()
        {
            InitializeComponent();
            // Required for ownerdraw
            this.DrawItem += new DrawItemEventHandler(EnableDisplayCombo_DrawItem);
            // Required for ownerdraw
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.EnabledChanged += new EventHandler(EnableDisplayCombo_EnabledChanged);
        }
        // If control is disabled, we switch to DropDownList style, so we can control the appearance of the
        // edit box
        void EnableDisplayCombo_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled)
                this.DropDownStyle = ComboBoxStyle.DropDown;
            else
                this.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        // Ownerdraw routine
        void EnableDisplayCombo_DrawItem(object sender, DrawItemEventArgs e)
        {
            System.Drawing.Graphics g = e.Graphics;
            Rectangle r = e.Bounds;
            
            if (e.Index >= 0)
            {
                string label = this.Items[e.Index].ToString();
                
                // This is how we draw a disabled control
                if (e.State == (DrawItemState.Disabled | DrawItemState.NoAccelerator | DrawItemState.NoFocusRect | DrawItemState.ComboBoxEdit))
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.White), r);
                    g.DrawString(label, e.Font, Brushes.Black, r);
                    e.DrawFocusRectangle();
                }
                // This is how we draw the items in an enabled control that aren't in focus
                else if (e.State == (DrawItemState.NoAccelerator | DrawItemState.NoFocusRect))
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.White), r);
                    g.DrawString(label, e.Font, Brushes.Black, r);
                    e.DrawFocusRectangle();
                }
                // This is how we draw the focused items
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.Blue), r);
                    g.DrawString(label, e.Font, Brushes.White, r);
                    e.DrawFocusRectangle();
                }
                
                
            }
            g.Dispose();
            
            
        }
    }
}


