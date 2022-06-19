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
        public juego()
        {
            InitializeComponent();
        }
        //Variables
        int NroPreg = 1;
        string sql;

        string profefinal;

        int puntos_finales = 0, id = 0;

        string preg1;
        string preg2;
        string preg3;
        string preg4;
        string preg5;
        string preg6;
        string preg7;
        string preg8;
        string preg9;
        string preg10;
        string preg11;
        string preg12;
        string preg13;
        string preg14;
        string preg15;
        string preg16;
        string preg17;
        string preg18;
        string preg19;
        string preg20;
        string preg21;
        string preg22;

        DataSet ds = new DataSet();
        //Variables

        private void juego_Load(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = |DataDirectory|\\Acess proyecto.accdb");
            conexion.Open();

            sql = "SELECT id,nombre,puntos FROM profes";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "profes");
            conexion.Close();

            dataGridView1.DataSource = ds.Tables["profes"];
        }




        private void btnSi_Click(object sender, EventArgs e)
        {
            if (NroPreg == 1)
            {
                preg1 = "preg1";
                lblPreguntas.Text = "Es profesor/a de tic?";
                NroPreg++;
                actualizarBase(preg1, 200);
            }

            else if (NroPreg == 2)
            {
                preg2 = "preg2";
                lblPreguntas.Text = "Trabaja en ort hace más de 3 años?";
                NroPreg++;
                actualizarBase(preg2, 55);
            }

            else if (NroPreg == 3)
            {
                preg3 = "preg3";
                lblPreguntas.Text = "Es buena onda?";
                NroPreg++;
                actualizarBase(preg3, 10);
            }

            else if (NroPreg == 4)
            {
                preg4 = "preg4";
                lblPreguntas.Text = "Trabaja en el área de programación?";
                NroPreg++;
                actualizarBase(preg4, 52);
            }

            else if (NroPreg == 5)
            {
                preg5 = "preg5";
                lblPreguntas.Text = "Trabaja en el área de arte?";
                NroPreg++;
                actualizarBase(preg5, 31);
            }

            else if (NroPreg == 6)
            {
                preg6 = "preg6";
                lblPreguntas.Text = "Es tambien el director de TIC?";
                NroPreg++;
                actualizarBase(preg6, 10);
            }

            else if (NroPreg == 7)
            {
                preg7 = "preg7";
                //Seria Daro
                NroPreg = 23;
                actualizarBase(preg7, 1000);
                Decicion();
            }

            else if (NroPreg == 8)
            {
                preg8 = "preg8";
                lblPreguntas.Text = "Es rubi@?";
                NroPreg++;
                actualizarBase(preg8, 66);
            }

            else if (NroPreg == 9)
            {
                preg9 = "preg9";
                lblPreguntas.Text = "Usa anteojos?";
                NroPreg++;
                actualizarBase(preg9, 14);
            }

            else if (NroPreg == 10)
            {
                preg10 = "preg10";
                lblPreguntas.Text = "Su personaje tiene más de 30 años?";
                NroPreg++;
                actualizarBase(preg10, 15);
            }

            else if (NroPreg == 11)
            {
                preg11 = "preg11";
                lblPreguntas.Text = "Tiene barba?";
                NroPreg++;
                actualizarBase(preg11, 88);
            }

            else if (NroPreg == 12)
            {
                preg12 = "preg12";
                lblPreguntas.Text = "Su personaje suele usar bufanda?";
                NroPreg++;
                actualizarBase(preg12, 18);
            }

            else if (NroPreg == 13)
            {
                preg13 = "preg13";
                lblPreguntas.Text = "Su personaje tiene los ojos claros?";
                NroPreg++;
                actualizarBase(preg13, 13);
            }

            else if (NroPreg == 14)
            {
                preg14 = "preg14";
                lblPreguntas.Text = "Su personaje es actualmente MEP?";
                NroPreg++;
                actualizarBase(preg14, 111);
            }

            else if (NroPreg == 15)
            {
                preg15 = "preg15";
                lblPreguntas.Text = "Su personaje antes era un MEP?";
                NroPreg++;
                actualizarBase(preg15, 9);
            }

            else if (NroPreg == 16)
            {
                preg16 = "preg16";
                lblPreguntas.Text = "Su profesor llega tarde?";
                NroPreg++;
                actualizarBase(preg16, 22);
            }

            else if (NroPreg == 17)
            {
                preg17 = "preg17";
                lblPreguntas.Text = "Tu personaje te amenaza para sacarte de TIC?";
                NroPreg++;
                actualizarBase(preg17, 90);
            }

            else if (NroPreg == 18)
            {
                preg18 = "preg18";
                lblPreguntas.Text = "Tiene hijos?";
                NroPreg++;
                actualizarBase(preg18, 10);
            }

            else if (NroPreg == 19)
            {
                preg19 = "preg19";
                lblPreguntas.Text = "Te deja tareas?";
                NroPreg++;
                actualizarBase(preg19, 40);
            }

            else if (NroPreg == 20)
            {
                preg20 = "preg20";
                lblPreguntas.Text = "Tu profesor te pondría una prueba/formulario?";
                NroPreg++;
                actualizarBase(preg20, 10);
            }

            else if (NroPreg == 21)
            {
                preg21 = "preg21";
                lblPreguntas.Text = "Tiene rulos?";
                NroPreg++;
                actualizarBase(preg21, 70);
            }

            else if (NroPreg == 22)
            {
                preg22 = "preg22";
                actualizarBase(preg22, 10);
                Decicion();


            }

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if (NroPreg == 1)
            {
                preg1 = "preg1";
                lblPreguntas.Text = "Es profesor/a de tic?";
                NroPreg++;
            }

            else if (NroPreg == 2)
            {
                preg2 = "no";
                lblPreguntas.Text = "Trabaja en ort hace más de 3 años?";
                NroPreg++;
            }

            else if (NroPreg == 3)
            {
                preg3 = "no";
                lblPreguntas.Text = "Es buena onda?";
                NroPreg++;
            }

            else if (NroPreg == 4)
            {
                preg4 = "no";
                lblPreguntas.Text = "Trabaja en el área de programación?";
                NroPreg++;
            }

            else if (NroPreg == 5)
            {
                preg5 = "no";
                lblPreguntas.Text = "Trabaja en el área de arte?";
                NroPreg++;
            }

            else if (NroPreg == 6)
            {
                preg6 = "no";
                lblPreguntas.Text = "Es tambien el director de TIC?";
                NroPreg++;
            }

            else if (NroPreg == 7)
            {
                preg7 = "no";
                lblPreguntas.Text = "Es alt@?";
                NroPreg++;
            }

            else if (NroPreg == 8)
            {
                preg8 = "no";
                lblPreguntas.Text = "Es rubi@?";
                NroPreg++;
            }

            else if (NroPreg == 9)
            {
                preg9 = "no";
                lblPreguntas.Text = "Usa anteojos?";
                NroPreg++;
            }

            else if (NroPreg == 10)
            {
                preg10 = "no";
                lblPreguntas.Text = "Su personaje tiene más de 30 años?";
                NroPreg++;
            }

            else if (NroPreg == 11)
            {
                preg11 = "no";
                lblPreguntas.Text = "Tiene barba?";
                NroPreg++;
            }

            else if (NroPreg == 12)
            {
                preg12 = "no";
                lblPreguntas.Text = "Su personaje suele usar bufanda?";
                NroPreg++;
            }

            else if (NroPreg == 13)
            {
                preg13 = "no";
                lblPreguntas.Text = "Su personaje tiene los ojos claros?";
                NroPreg++;
            }

            else if (NroPreg == 14)
            {
                preg14 = "no";
                lblPreguntas.Text = "Su personaje es actualmente MEP?";
                NroPreg++;
            }

            else if (NroPreg == 15)
            {
                preg15 = "no";
                lblPreguntas.Text = "Su personaje antes era un MEP?";
                NroPreg++;
            }

            else if (NroPreg == 16)
            {
                preg16 = "no";
                lblPreguntas.Text = "Su profesor llega tarde?";
                NroPreg++;
            }

            else if (NroPreg == 17)
            {
                preg17 = "no";
                lblPreguntas.Text = "Tu personaje te amenaza para sacarte de TIC?";
                NroPreg++;
            }

            else if (NroPreg == 18)
            {
                preg18 = "no";
                lblPreguntas.Text = "Tiene hijos?";
                NroPreg++;
            }

            else if (NroPreg == 19)
            {
                preg19 = "no";
                lblPreguntas.Text = "Te deja tareas?";
                NroPreg++;
            }

            else if (NroPreg == 20)
            {
                preg20 = "no";
                lblPreguntas.Text = "Tu profesor te pondría una prueba/formulario?";
                NroPreg++;
            }

            else if (NroPreg == 21)
            {
                preg21 = "no";
                lblPreguntas.Text = "Tiene rulos?";
                NroPreg++;
            }

            else if (NroPreg == 22)
            {
                preg22 = "no";
                Decicion();



            }
        }


        private void actualizarBase(string pregunta, int punto)
        {
            OleDbConnection conexion = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =.\Acess proyecto.accdb");
            conexion.Open();

            //Llamar los puntos que ya estan
            sql = "SELECT id,nombre,puntos FROM profes WHERE "+pregunta+" = 'si'";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "profes");
            conexion.Close();

            conexion.Open();
            for (int i = (ds.Tables["profes"].Rows.Count - 1); i > 0; i--)
            {
                //subir los nuevos puntos
                puntos_finales = Convert.ToInt32(ds.Tables["profes"].Rows[i]["puntos"].ToString()) + punto;
                id = Convert.ToInt32(ds.Tables["profes"].Rows[i]["id"].ToString());

                sql = "UPDATE profes SET puntos = "+puntos_finales+ " WHERE " + pregunta + " = 'si' AND id = "+id+""; 
                cmd = new OleDbCommand(sql, conexion);
                cmd.ExecuteNonQuery();
            }
            
            conexion.Close();
            ds.Clear();
        }


        private void Decicion()
        {
            OleDbConnection conexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = |DataDirectory|\\Acess proyecto.accdb");
            conexion.Open();
            
            sql = "SELECT nombre,puntos  FROM profes WHERE puntos = (SELECT MAX(puntos) FROM profes)";
            OleDbCommand cmd = new OleDbCommand(sql, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "profes");
            conexion.Close();
            profefinal = ds.Tables["profes"].Rows[0]["nombre"].ToString();

            MessageBox.Show(profefinal);

            conexion.Open();
            sql = "UPDATE profes SET puntos = 0";
            cmd = new OleDbCommand(sql, conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }


    }
}
