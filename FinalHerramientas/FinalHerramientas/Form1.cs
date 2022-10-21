using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalHerramientas
{
    public partial class Form1 : Form
    {
        public string[,] equipos = new string[6,10];
        public int cantidadEquipos = new int();
        public int i = new int();
        public int fechas = new int();
        public int partidosPorFecha = new int();
        public int totalPartidos = new int();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cantidadEquipos = Convert.ToInt32(textBox1.Text);

            if (cantidadEquipos <= 6 && cantidadEquipos > 1)
            {
                textBox1.Enabled = false;
                button1.Enabled = false;
                groupBox1.Visible = true;
            }
            else
            {
                cantidadEquipos = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Los equipos permitidos varían entre 2 y 6... Reintente");
                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            label4.Text = Convert.ToString(i+1);


            equipos[i, 0] = label4.Text;
            equipos[i, 1] = textBox2.Text;

            i += 1;
            textBox2.Text = "";

            if (i == cantidadEquipos)
            {
                groupBox1.Enabled = false;
                button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(cantidadEquipos%2 == 0)
            {
                fechas = cantidadEquipos - 1;
                partidosPorFecha = cantidadEquipos / 2;
                totalPartidos = fechas * partidosPorFecha;
            }
            else if(cantidadEquipos %2 != 0)
            {
                fechas = cantidadEquipos;
                partidosPorFecha = ((cantidadEquipos - 1) / 2) + 1;
                totalPartidos = fechas * partidosPorFecha;
            }

            Form2 formularioDos = new Form2(cantidadEquipos,equipos,fechas,partidosPorFecha,totalPartidos);
            formularioDos.Show();
            this.Hide();
        }

    }
}
