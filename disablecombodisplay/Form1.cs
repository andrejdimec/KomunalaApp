using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            regularCombo.SelectedIndex = 2;
            regularCombo.Enabled = false;
            withEnableCombo.SelectedIndex = 2;
            withEnableCombo.Enabled = false;
            enableDisplayCombo2.SelectedIndex = 3;
            enableDisplayCombo2.Enabled = true;
        }

       
    }
}