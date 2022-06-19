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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }
        //variables
        public static string tema = "default";

        private void btnJugar_Click(object sender, EventArgs e)
        {
            juego juego = new juego();
            juego.Show();
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proyecto creado por Felipe Kraefft, Maxi Falzone, Santiago Resnik y Muriel Galvan");
        }

        private void btnTemas_Click(object sender, EventArgs e)
        {
            temas temas = new temas();
            temas.Show();
        }

        private void principal_Load(object sender, EventArgs e)
        {
            lblprueba.Text = principal.tema;
        }

    }
}
