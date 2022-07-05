using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AkinatOrt
{
    public partial class juego : Form
    {
        //Contador de pregunta
        private int num = 0;
        private bool[] response = new bool[22];
        // Profesores
        Profesores dario, ruben, pau, caro, lu, chona, mati, joaco, ranzo, aro, ivo, jero, julieta, ariel, natali, micaela, vena, roberto;

        //Array de preguntas(22)
        string[] pregs  = { 
            "¿Su personaje es mujer?",
            "¿Es profeso/a de tic?",
            "¿Trabaja en ort hace mas de 3 años?",
            "¿Es buena honda?",
            "¿Trabaja en el area de la programación?",
            "¿Trabaja en el area de diseño?",
            "¿Es tambien el director de la especialidad tic?",
            "¿Es alto/a?",
            "¿Es rubio/a?",
            "¿Usa anteojos?",
            "¿Su personaje tiene mas de 30 años?",
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
            //Cargar los profesores

            dario = new Profesores(new bool [22] { false, true,true, true, true, false, false, true, false, false, true, true, false, false, false, false, true, true, true, true, false, false });
            ruben = new Profesores(new bool[22] { false, true,true, true, true, false, false, false, false, false, false, true, false, true, false, false, false, true, false, true, false, false});
            pau = new Profesores(new bool[22] {true, true, true, true, false, true, false, false, false, true, true, false, false, false, false, false, false, false, true, false, false, false});
            caro = new Profesores(new bool[22] {true, true, false, true, false, false,false, false, true,false,false,false,true,true,true,true,true,false,false,true,true,false });
            lu = new Profesores(new bool[22] {true, true, false, true, true, false, false, false,true, false, false, false, false, false, true,true, false, false, false, false, false, false });
            chona = new Profesores(new bool[21] { false, false, false, true, true, false, false, false, false, false, false, true, true, false, true, false, false, false, false, false, false });
            mati = new Profesores(new bool[22] {false,false,false,true,true,true,false,false,false,false,false,false, true,false,true,false,false,false,false,false,false,false});
            joaco = new Profesores(new bool[22] {false,false,true,true,true,false,false,true,false,true,true,false,false,false,true,false,false,false,false,false,false,true});
            ranzo = new Profesores(new bool[22] {false,true,true,true,true,false,false,false,false,false,true,true,false,false,false,false,false,false,true,true,true,false});
            ivo = new Profesores(new bool[22] {false,true,false,true,false,false,false,true,false,false,false,true,false,false,false,false,false,false,false,true,true,false});
            jero = new Profesores(new bool[22] {false,true,true,true,false,true,false,true,false,false,true,true,false,false,false,false,false,false,true,true,true,false});
            julieta = new Profesores(new bool[22] {true,true,true,true,false,false,false,false,false,false,true,false,true,false,false,false,false,false,false,true,true,true});
            ariel = new Profesores(new bool[22] {false,true,true,true,true,false,false,false,true,true,true,true,false,true,false,false,true,false,true,true,true,false});
            natali = new Profesores(new bool[22] {true,true,false,true,true,false,false,false,false,true,false,false,false,false, false,false,false,false,false,true,true,false});
            micaela = new Profesores(new bool[22] {true,true,true,true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false });
            aro = new Profesores(new bool[22] { false, true, true, true, true, false, false, false, false, false, true, true, false, false, false, false, false, false, true, true, true, false });
            vena = new Profesores(new bool[22] { false, true, true, true, false, false, false, true, false, true, true, false, false, false, false, false, false, false, true, false, false, false });
            roberto = new Profesores(new bool[22] { false, true, true, true, false, false, false, true, false, true, true, true, false, false, false, false, false, false, true, false, true, false });


        }
        private void btnSi_Click(object sender, EventArgs e)
        {
            if (num == 22)
            {
                getProfesor();
            }
            else
            {
                response.Append(true);
                label1.Text = pregs[num];
                ++num;
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if (num == 22)
            {
                getProfesor();
            }
            else
            {
                response.Append(false);
                label1.Text = pregs[num];
                ++num;
            }
        }

        private void lblPreguntas_Click(object sender, EventArgs e)
        {

        }

        private string getProfesor()
        {
            dario.getPoint(response);
            ruben.getPoint(response);
            pau.getPoint(response);
            caro.getPoint(response);
            lu.getPoint(response);
            chona.getPoint(response);
            mati.getPoint(response);
            joaco.getPoint(response);
            ranzo.getPoint(response);
            ivo.getPoint(response);
            jero.getPoint(response);
            julieta.getPoint(response);
            ariel.getPoint(response);
            natali.getPoint(response);
            micaela.getPoint(response);
            aro.getPoint(response);
            vena.getPoint(response);
            roberto.getPoint(response);

            for (int i = 0; i < 18; ++i)
            {
                
            }
            return "";
        }
    }
    public class Profesores{
        private int point = 0;
        private bool[] data = new bool[22];

        public Profesores(bool[] Gdata)
        {
            data = Gdata;
        }
        public bool GetAttrib(int position)
        {
            return data[position];
        }
        public void AddPoint()
        {
            ++point;
        }
        public int getPoint(bool[] Fdata)
        {
            for(int i = 0; i < 22; ++i)
            {
                if (data[i] == Fdata[i])
                {
                    point++;
                }
            }
            return point;
        }
    }
    // No me siento orgulloso de este codigo...
}
