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
        private string[] names = {"Dario", "Ruben", "Pau", "Caro", "Lu", "Chona", "Mati", "Joaco", "Ranzo", "Aro", "Ivo", "Jero", "Juli", "Ariel", "Natali", "Mica", "Vena", "Roberto"};
        private Dictionary<string, int> points = new Dictionary<string, int>();
        Dictionary<string, bool[]> profesores = new Dictionary<string, bool[]>();
        
        // Profesores
        //Profesores dario, ruben, pau, caro, lu, chona, mati, joaco, ranzo, aro, ivo, jero, julieta, ariel, natali, micaela, vena, roberto;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

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
            points.Add("Ariel", 0);
            points.Add("Natali", 0);
            points.Add("Mica", 0);
            points.Add("Aro", 0);
            points.Add("Vena", 0);
            points.Add("Roberto", 0);

            //Cargar los profesores
            profesores.Add("Dario",new bool[22]    { false, true,true, true, true, false, false, true, false, false, true, true, false, false, false, false, true, true, true, true, false, false} );
            profesores.Add("Ruben", new bool[22]   { false, true, true, true, true, false, false, false, false, false, false, true, false, true, false, false, false, true, false, true, false, false });
            profesores.Add("Pau", new bool[22]     { true, true, true, true, false, true, false, false, false, true, true, false, false, false, false, false, false, false, true, false, false, false });
            profesores.Add("Caro", new bool[22]    { true, true, false, true, false, false, false, false, true, false, false, false, true, true, true, true, true, false, false, true, true, false });
            profesores.Add("Lu", new bool[22]      { true, true, false, true, true, false, false, false, true, false, false, false, false, false, true, true, false, false, false, false, false, false });
            profesores.Add("Chona", new bool[22]   { false, false, false,true, true, true, false, false, false, false, false, false, true, true, false, true, false, false, false, false, false, false });
            profesores.Add("Mati", new bool[22]    { false, false, false, true, true, true, false, false, false, false, false, false, true, false, true, false, false, false, false, false, false, false });
            profesores.Add("Joaco", new bool[22]   { false, false, true, true, true, false, false, true, false, true, true, false, false, false, true, false, false, false, false, false, false, true });
            profesores.Add("Ranzo", new bool[22]   { false, true, true, true, true, false, false, false, false, false, true, true, false, false, false, false, false, false, true, true, true, false });
            profesores.Add("Ivo", new bool[22]     { false, true, false, true, false, false, false, true, false, false, false, true, false, false, false, false, false, false, false, true, true, false });
            profesores.Add("Jero", new bool[22]    { false, true, true, true, false, true, false, true, false, false, true, true, false, false, false, false, false, false, true, true, true, false });
            profesores.Add("Juli", new bool[22]    { true, true, true, true, false, false, false, false, false, false, true, false, true, false, false, false, false, false, false, true, true, true });
            profesores.Add("Ariel", new bool[22]   { false, true, true, true, true, false, false, false, true, true, true, true, false, true, false, false, true, false, true, true, true, false });
            profesores.Add("Natali", new bool[22]  { true, true, false, true, true, false, false, false, false, true, false, false, false, false, false, false, false, false, false, true, true, false });
            profesores.Add("Mica", new bool[22]    { true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false });
            profesores.Add("Aro", new bool[22]     { false, true, true, true, true, false, false, false, false, false, true, true, false, false, false, false, false, false, true, true, true, false });
            profesores.Add("Vena", new bool[22]    { false, true, true, true, false, false, false, true, false, true, true, false, false, false, false, false, false, false, true, false, false, false });
            profesores.Add("Roberto", new bool[22] { false, true, true, true, false, false, false, true, false, true, true, true, false, false, false, false, false, false, true, false, true, false });
        }
        private void btnSi_Click(object sender, EventArgs e)
        {
            if (num == 22)
            {
                label1.Text = getProfesor();
            }
            if(num == 7)
            {
                label1.Text = "Dario";
            }
            else
            {
                response[num] = true;
                label1.Text = pregs[num];
                ++num;
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if (num == 22)
            {
                label1.Text = getProfesor();
            }
            else
            {
                response[num] = false;
                label1.Text = pregs[num];
                ++num;
            }
        }

        private void lblPreguntas_Click(object sender, EventArgs e)
        {

        }

        private string getProfesor()
        {
            for(int i = 0; i < 18; ++i)
            {   
                for(int j = 0; j <= 21; ++j)
                {
                    if(response[j] == profesores[names[i]][j])
                    {
                        points[names[i]] += 1;
                    }
                }
            }

            for(int i = 0; i < 18; ++i)
            {
                if(points[names[i]] == points.Values.Max())
                {
                    return names[i];
                }
            }
            label1.Text = points.Values.Max().ToString();
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
