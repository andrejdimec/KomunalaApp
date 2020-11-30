using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komunala
{
    public partial class frmPocakaj : Form
    {
        public frmPocakaj()
        {
            InitializeComponent();
        }
        public void SetMessage(string mess)
        {
            label1.Text = "Pripravljam izpis... " + mess;
            label1.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
