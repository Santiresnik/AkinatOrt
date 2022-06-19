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
        
        private void btnDefault_Click(object sender, EventArgs e)
        {
            principal.tema = "default";
        }

        private void btnElegante_Click(object sender, EventArgs e)
        {
            principal.tema = "Elegante";
        }

        private void btnJedi_Click(object sender, EventArgs e)
        {

            principal.tema = "jedi";
        }
        private void btnOtaku_Click(object sender, EventArgs e)
        {
            principal.tema = "otaku";
        }

        private void btnPayaso_Click(object sender, EventArgs e)
        {
            principal.tema = "Payaso";
        }

        private void Playa_Click(object sender, EventArgs e)
        {
            principal.tema = "Playa";
        }
    }
}
