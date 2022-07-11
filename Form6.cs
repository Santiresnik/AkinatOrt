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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(AkinatORT_Main_Theme_1.wav);
            simpleSound.Play();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.Volume = trackBar1.Value;
        }
    }
}
