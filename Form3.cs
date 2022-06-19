using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkinatOrt
{
    public partial class temas : Form
    {
        public temas()
        {
            InitializeComponent();
        }
        

        private void temas_Load(object sender, EventArgs e)
        {

        }

        private void RbDefault_CheckedChanged(object sender, EventArgs e)
        {
            principal.tema = "Default";
        }

        private void RbPlaya_CheckedChanged(object sender, EventArgs e)
        {
            principal.tema = "Playa";
        }

        private void Rbpayaso_CheckedChanged(object sender, EventArgs e)
        {
            principal.tema = "Payaso";
        }

        private void RbOtaku_CheckedChanged(object sender, EventArgs e)
        {
            principal.tema = "Otaku";
        }
    }
}
