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
            this.Hide();
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            creditos creditos = new creditos();
            creditos.Show();
        }


        private void principal_Load(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void btntemasf_Click(object sender, EventArgs e)
        {
            temas temas = new temas();
            temas.Show();
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            tutorial tutorial = new tutorial();
            tutorial.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
        }
    }
}
