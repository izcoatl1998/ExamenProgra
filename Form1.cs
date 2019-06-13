using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Examen3ra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int j = 0, k = 1;
        int contador = 0;
        List<string> jugadores = new List<string>();
        Jugador a = new Jugador();
        Equipo[] b = new Equipo[20];
        Jornada c = new Jornada();
        List<string> equipos = new List<string>();
        List<int> jornadas = new List<int>();
        //int[] num = new int[5];
        string[] equipo1 = new string[10];
        string[,] jugador = new string[10, 11];
        //Me falto las jornadas pero solo era crear numeros aleatorios para cada equipo y escojer el ganador

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int s =0; s < 10; s++)
             {
                for (int f = 0; f < 11; f++)
                {
                    jugador[s, f] = "";
                }
             }
        }

        private void Btn_CrearEquipo_Click(object sender, EventArgs e)
        {
            if (j>=20) {
                //ya no se que hacer equipos.Add(NombreEquipo.Text) Ocupo 8.5 :(;
            }
            else
            {
                //comboBox1.Items.Add(equipos[j]);
                equipo1[j] = NombreEquipo.Text;
                jugador[k,j] = NombreEquipo.Text;
                
                comboBox1.Items.Add(equipo1[j]);
               
                j++;
                k++;

                NombreEquipo.Text = "";
            }
        }

        private void borrarJugador_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string numero = comboBox1.SelectedIndex.ToString();
            Jornada.Text = numero.ToString();
            */
            listBox1.Items.Clear();
            
            k = 1;
            string equipos = comboBox1.SelectedItem.ToString();
          
            for (int cont =0; cont <10; cont++)
            {
                listBox1.Items.Add(jugador[comboBox1.SelectedIndex,cont]);
            }
        }

        private void Jornada_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string rutaArchivo;
            rutaArchivo = saveFileDialog1.FileName;
            FileStream fs = new FileStream(rutaArchivo, FileMode.Create);
            StreamWriter Jornada = new StreamWriter(fs);
            Jornada.WriteLine("Ticket");
            Jornada.WriteLine("Kiosko" + Environment.NewLine);
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                Jornada.WriteLine(comboBox1.Items[i].ToString());
            }
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                Jornada.WriteLine("Jugadores: " +listBox1.Items[i].ToString()+Environment.NewLine);
            }
            Jornada.Close();
            fs.Close();
        }

        private void agregar_jugador_Click(object sender, EventArgs e)
        {
            jugadores.Add(Nombre_Jugador.Text);
            listBox1.Items.Add(jugadores[contador]);
            contador++;       
        }
    }
}
