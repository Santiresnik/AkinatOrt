using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// electro 20 was here....

namespace AkinatOrt
{
    public partial class juego : Form
    {
        //Contador de pregunta
        private int num = 0;
        private bool[] response = new bool[22];

        private string[] names = { "Dario", "Ruben", "Pau", "Caro", "Lu", "Chona", "Mati", "Joaco", "Ranzo", "Aro", "Ivo", "Jero", "Juli", "Nacho", "Julian", "Mica", "Vena", "Roberto", "Luca" };
        private Dictionary<string, int> points = new Dictionary<string, int>();
        Dictionary<string, bool[]> profesores = new Dictionary<string, bool[]>();

        //Array de preguntas(22)
        string[] pregs = {
            "¿Su personaje es mujer?",
            "¿Es profesor/a de tic?",
            "¿Trabajó en ort hace más de 3 años?",
            "¿Es buena onda?",
            "¿Trabaja en el área de la programación?",
            "¿Trabaja en el área de diseño?",
            "¿Es tambien el director de la especialidad tic?",
            "¿Es alto/a?",
            "¿Es rubio/a?",
            "¿Usa anteojos?",
            "¿Su personaje tiene más de 30 años?",
            "¿Tiene barba?",
            "¿Su personaje suele usar bufanda?",
            "¿Su personaje tiene ojos claros?",
            "¿Su personaje es actualmente MEP?",
            "¿Su personaje antes era MEP?",
            "¿Su personaje llega tarde?",
            "¿Tu personaje te podria amenazar con sacarte de tic?",
            "¿Tiene hijos?",
            "¿Te deja tareas?",
            "¿Tu personaje te pondria un formulario evaluatorio?",
            "¿Tiene rulos?"
        };
        public juego()
        {
            InitializeComponent();
        }

        private void juego_Load(object sender, EventArgs e)
        {
            // inciar en la primera pregunta
            label1.Text = pregs[num];

            //Puntos de profesores
            points.Add("Dario", 0);
            points.Add("Ruben", 0);
            points.Add("Pau", 0);
            points.Add("Caro", 0);
            points.Add("Lu", 0);
            points.Add("Chona", 0);
            points.Add("Mati", 0);
            points.Add("Joaco", 0);
            points.Add("Ranzo", 0);
            points.Add("Ivo", 0);
            points.Add("Jero", 0);
            points.Add("Juli", 0);
            points.Add("Nacho", 0);
            points.Add("Julian", 0);
            points.Add("Mica", 0);
            points.Add("Aro", 0);
            points.Add("Vena", 0);
            points.Add("Roberto", 0);
            points.Add("Luca", 0);

            //Cargar los profesores
            profesores.Add("Dario", new bool[22] { false, true, true, true, false, false, true, false, true, true, true, false, false, true, false, true, true, true, false, false, true, false });
            profesores.Add("Ruben", new bool[22] { false, false, true, true, false, false, false, false, false, true, true, false, true, false, false, false, true, true, true, false, true, false });
            profesores.Add("Pau", new bool[22] { true, true, true, true, false, true, false, false, false, true, true, false, false, false, false, false, false, false, true, false, false, false });
            profesores.Add("Caro", new bool[22] { true, true, false, true, false, false, false, false, true, false, false, false, true, true, true, true, true, false, false, true, true, false });
            profesores.Add("Lu", new bool[22] { true, true, false, true, true, false, false, false, true, false, false, false, false, false, false, true, true, false, false, false, false, false });
            profesores.Add("Chona", new bool[22] { false, true, false, true, true, false, false, false, false, false, false, true, true, false, true, false, false, false, false, true, false, false });
            profesores.Add("Mati", new bool[22] { false, false, false, true, true, true, false, false, false, false, false, false, true, false, true, false, false, false, false, false, false, false });
            profesores.Add("Joaco", new bool[22] { false, true, true, true, true, false, false, true, false, true, true, false, false, false, true, false, false, false, false, false, false, true });
            profesores.Add("Ranzo", new bool[22] { false, true, true, true, true, true, false, false, false, true, true, true, false, false, false, false, true, false, true, true, false, false });
            profesores.Add("Ivo", new bool[22] { false, true, false, true, false, false, false, true, false, false, false, true, false, false, false, false, false, false, false, true, true, false });
            profesores.Add("Jero", new bool[22] { false, true, true, true, false, true, false, true, false, false, true, true, false, false, false, false, false, false, true, true, true, false });
            profesores.Add("Juli", new bool[22] { true, true, true, true, false, false, false, false, false, false, true, false, true, false, false, false, false, false, false, false, true, true });
            profesores.Add("Nacho", new bool[22] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false }); //faltan resp
            profesores.Add("Julian", new bool[22] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false }); //faltan resp
            profesores.Add("Mica", new bool[22] { true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false });
            profesores.Add("Aro", new bool[22] { false, true, true, true, true, false, false, false, false, false, true, true, false, false, false, false, false, false, true, true, true, false });
            profesores.Add("Vena", new bool[22] { false, true, true, true, false, false, false, true, false, true, true, false, false, false, false, false, false, false, true, false, false, false });
            profesores.Add("Roberto", new bool[22] { false, true, true, true, false, false, false, true, false, true, true, true, false, false, false, false, false, false, true, false, true, false });
            profesores.Add("Luca", new bool[22] { false, false, false, true, true, false, false, false, false, false, false, false, false, false, true, true, true, false, false, false, false, true }); //faltan resp

            actualizarFondo();
        }
        private void btnSi_Click(object sender, EventArgs e)
        {
            if (num == 21)
            {
                label1.Text = getProfesor();
            }
            if(num == 3)
            {
                btnNo.Show();
            }
            if (num == 6)
            {
                label1.Text = "Dario";
                btnNo.Hide();
                btnSi.Hide();
            }
            else
            {
                response[num] = true;
                ++num;
                label1.Text = pregs[num];
            }
            actualizarFondo();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if (num == 21)
            {
                label1.Text = getProfesor();
            }
            else if (num == 3)
            {
                btnNo.Hide();
            }
            else
            {
                response[num] = false;
                ++num;
                label1.Text = pregs[num];
            }
            actualizarFondo();
        }

        private string getProfesor()
        {
            btnNo.Hide();
            btnSi.Hide();
            for (int i = 0; i < 19; ++i)
            {
                for (int j = 0; j <= 21; ++j)
                {
                    try
                    {
                        if (response[j] == profesores[names[i]][j])
                        {
                            points[names[i]] += 1;
                        }
                    }
                    catch { }
                }
            }

            for (int i = 0; i < 19; ++i)
            {
                if (points[names[i]] == points.Values.Max())
                {
                    return names[i];
                }
            }
            label1.Text = points.Values.Max().ToString();
            return "";
        }
        public void actualizarFondo()
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 4);

            //caso default
            if (random == 1 && principal.tema == "default")
            {
                pbDaro.Image = Properties.Resources.dario_default_contento;
            }
            else if (random == 2 && principal.tema == "default")
            {
                pbDaro.Image = Properties.Resources.dario_default_triste;
            }
            else if (random == 3 && principal.tema == "default")
            {
                pbDaro.Image = Properties.Resources.dario_default_sonriendo;
            }
            //Caso playa
            else if (random == 1 && principal.tema == "playa")
            {
                pbDaro.Image = Properties.Resources.dario_playa_contento;
            }

            else if (random == 2 && principal.tema == "playa")
            {
                pbDaro.Image = Properties.Resources.dario_playa_triste;
            }

            else if (random == 3 && principal.tema == "playa")
            {
                pbDaro.Image = Properties.Resources.dario_playa_sonriendo;
            }
            //Caso otaku
            else if (random == 1 && principal.tema == "otaku")
            {
                pbDaro.Image = Properties.Resources.dario_otaku_contento;
            }

            else if (random == 2 && principal.tema == "otaku")
            {
                pbDaro.Image = Properties.Resources.dario_otaku_sonriendo;
            }

            else if (random == 3 && principal.tema == "otaku")
            {
                pbDaro.Image = Properties.Resources.dario_otaku_triste;
            }
            //caso payaso
            else if (random == 1 && principal.tema == "payaso")
            {
                pbDaro.Image = Properties.Resources.dario_payaso_contento;
            }

            else if (random == 2 && principal.tema == "payaso")
            {
                pbDaro.Image = Properties.Resources.dario_payaso_sonriendo;
            }

            else if (random == 3 && principal.tema == "payaso")
            {
                pbDaro.Image = Properties.Resources.dario_payaso_triste;
            }


        }

        private void pbDaro_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            principal principal = new principal();
            principal.Show();
            this.Hide();
        }
    }

}