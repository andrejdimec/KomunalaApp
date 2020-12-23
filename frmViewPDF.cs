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
    public partial class frmViewPDF : Form
    {
        public frmViewPDF()
        {
            InitializeComponent();
        }

        private void frmViewPDF_Load(object sender, EventArgs e)
        {
            
            axAcroPDF1.LoadFile(frmPogodbeTel.pdf_datoteka);
        }

        private void frmViewPDF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (axAcroPDF1 != null)
            {
                this.Controls.Remove(axAcroPDF1);
                axAcroPDF1 = null;
            }
        }
    }
}
