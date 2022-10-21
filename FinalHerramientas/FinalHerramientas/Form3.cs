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
    public partial class Form3 : Form4
    {
        string[,] equipos;
        int cantidadEquipos = new int();
        string[,] partidos;
        public Form3(string[,] equipos, int cantidadEquipos, string[,] partidos)
        {
            InitializeComponent();
            this.partidos = partidos;
            this.equipos = equipos;
            this.cantidadEquipos = cantidadEquipos;

            for (int i = 0; i < cantidadEquipos; i++)
                comboBox1.Items.Add(equipos[i, 1]);

            ordenEquipos();

            switch(cantidadEquipos)
            {
                case 2:
                    //Uno;
                    label12.Text = equipos[0, 0];
                    label13.Text = equipos[0, 1];
                    label14.Text = equipos[0, 2];
                    label15.Text = equipos[0, 3];
                    label16.Text = equipos[0, 4];
                    label17.Text = equipos[0, 5];
                    label18.Text = equipos[0, 6];
                    label20.Text = equipos[0, 7];
                    label21.Text = equipos[0, 8];
                    label22.Text = equipos[0, 9];


                    //Dos;
                    label23.Text = equipos[1, 0];
                    label24.Text = equipos[1, 1];
                    label25.Text = equipos[1, 2];
                    label26.Text = equipos[1, 3];
                    label27.Text = equipos[1, 4];
                    label28.Text = equipos[1, 5];
                    label29.Text = equipos[1, 6];
                    label30.Text = equipos[1, 7];
                    label31.Text = equipos[1, 8];
                    label32.Text = equipos[1, 9];
                    

                    //Tres;
                    label33.Visible = false;
                    label34.Visible = false;
                    label35.Visible = false;
                    label36.Visible = false;
                    label37.Visible = false;
                    label38.Visible = false;
                    label39.Visible = false;
                    label40.Visible = false;
                    label41.Visible = false;
                    label42.Visible = false;
                    


                    //Cuatro;
                    label43.Visible = false;
                    label44.Visible = false;
                    label45.Visible = false;
                    label46.Visible = false;
                    label47.Visible = false;
                    label48.Visible = false;
                    label49.Visible = false;
                    label50.Visible = false;
                    label51.Visible = false;
                    label52.Visible = false;
                    

                    //Cinco;
                    label53.Visible = false;
                    label54.Visible = false;
                    label55.Visible = false;
                    label56.Visible = false;
                    label57.Visible = false;
                    label58.Visible = false;
                    label59.Visible = false;
                    label60.Visible = false;
                    label61.Visible = false;
                    label62.Visible = false;


                    //Seis;
                    label63.Visible = false;
                    label64.Visible = false;
                    label65.Visible = false;
                    label66.Visible = false;
                    label67.Visible = false;
                    label68.Visible = false;
                    label69.Visible = false;
                    label70.Visible = false;
                    label71.Visible = false;
                    label72.Visible = false;

                    label75.Visible = false;
                    label76.Visible = false;
                    label77.Visible = false;
                    label78.Visible = false;
                    break;

                case 3:
                    //Uno;
                    label12.Text = equipos[0, 0];
                    label13.Text = equipos[0, 1];
                    label14.Text = equipos[0, 2];
                    label15.Text = equipos[0, 3];
                    label16.Text = equipos[0, 4];
                    label17.Text = equipos[0, 5];
                    label18.Text = equipos[0, 6];
                    label20.Text = equipos[0, 7];
                    label21.Text = equipos[0, 8];
                    label22.Text = equipos[0, 9];

                    //Dos;
                    label23.Text = equipos[1, 0];
                    label24.Text = equipos[1, 1];
                    label25.Text = equipos[1, 2];
                    label26.Text = equipos[1, 3];
                    label27.Text = equipos[1, 4];
                    label28.Text = equipos[1, 5];
                    label29.Text = equipos[1, 6];
                    label30.Text = equipos[1, 7];
                    label31.Text = equipos[1, 8];
                    label32.Text = equipos[1, 9];

                    //Tres;
                    label33.Text = equipos[2, 0];
                    label34.Text = equipos[2, 1];
                    label35.Text = equipos[2, 2];
                    label36.Text = equipos[2, 3];
                    label37.Text = equipos[2, 4];
                    label38.Text = equipos[2, 5];
                    label39.Text = equipos[2, 6];
                    label40.Text = equipos[2, 7];
                    label41.Text = equipos[2, 8];
                    label42.Text = equipos[2, 9];

                    //Cuatro;
                    label43.Visible = false;
                    label44.Visible = false;
                    label45.Visible = false;
                    label46.Visible = false;
                    label47.Visible = false;
                    label48.Visible = false;
                    label49.Visible = false;
                    label50.Visible = false;
                    label51.Visible = false;
                    label52.Visible = false;

                    //Cinco;
                    label53.Visible = false;
                    label54.Visible = false;
                    label55.Visible = false;
                    label56.Visible = false;
                    label57.Visible = false;
                    label58.Visible = false;
                    label59.Visible = false;
                    label60.Visible = false;
                    label61.Visible = false;
                    label62.Visible = false;

                    //Seis;
                    label63.Visible = false;
                    label64.Visible = false;
                    label65.Visible = false;
                    label66.Visible = false;
                    label67.Visible = false;
                    label68.Visible = false;
                    label69.Visible = false;
                    label70.Visible = false;
                    label71.Visible = false;
                    label72.Visible = false;
                    label76.Visible = false;
                    label77.Visible = false;
                    label78.Visible = false;
                    break;

                case 4:
                    //Uno;
                    label12.Text = equipos[0, 0];
                    label13.Text = equipos[0, 1];
                    label14.Text = equipos[0, 2];
                    label15.Text = equipos[0, 3];
                    label16.Text = equipos[0, 4];
                    label17.Text = equipos[0, 5];
                    label18.Text = equipos[0, 6];
                    label20.Text = equipos[0, 7];
                    label21.Text = equipos[0, 8];
                    label22.Text = equipos[0, 9];

                    //Dos;
                    label23.Text = equipos[1, 0];
                    label24.Text = equipos[1, 1];
                    label25.Text = equipos[1, 2];
                    label26.Text = equipos[1, 3];
                    label27.Text = equipos[1, 4];
                    label28.Text = equipos[1, 5];
                    label29.Text = equipos[1, 6];
                    label30.Text = equipos[1, 7];
                    label31.Text = equipos[1, 8];
                    label32.Text = equipos[1, 9];

                    //Tres;
                    label33.Text = equipos[2, 0];
                    label34.Text = equipos[2, 1];
                    label35.Text = equipos[2, 2];
                    label36.Text = equipos[2, 3];
                    label37.Text = equipos[2, 4];
                    label38.Text = equipos[2, 5];
                    label39.Text = equipos[2, 6];
                    label40.Text = equipos[2, 7];
                    label41.Text = equipos[2, 8];
                    label42.Text = equipos[2, 9];

                    //Cuatro;
                    label43.Text = equipos[3, 0];
                    label44.Text = equipos[3, 1];
                    label45.Text = equipos[3, 2];
                    label46.Text = equipos[3, 3];
                    label47.Text = equipos[3, 4];
                    label48.Text = equipos[3, 5];
                    label49.Text = equipos[3, 6];
                    label50.Text = equipos[3, 7];
                    label51.Text = equipos[3, 8];
                    label52.Text = equipos[3, 9];

                    //Cinco;
                    label53.Visible = false;
                    label54.Visible = false;
                    label55.Visible = false;
                    label56.Visible = false;
                    label57.Visible = false;
                    label58.Visible = false;
                    label59.Visible = false;
                    label60.Visible = false;
                    label61.Visible = false;
                    label62.Visible = false;

                    //Seis;
                    label63.Visible = false;
                    label64.Visible = false;
                    label65.Visible = false;
                    label66.Visible = false;
                    label67.Visible = false;
                    label68.Visible = false;
                    label69.Visible = false;
                    label70.Visible = false;
                    label71.Visible = false;
                    label72.Visible = false;
                    label77.Visible = false;
                    label78.Visible = false;
                    break;

                case 5:
                    //Uno;
                    label12.Text = equipos[0, 0];
                    label13.Text = equipos[0, 1];
                    label14.Text = equipos[0, 2];
                    label15.Text = equipos[0, 3];
                    label16.Text = equipos[0, 4];
                    label17.Text = equipos[0, 5];
                    label18.Text = equipos[0, 6];
                    label20.Text = equipos[0, 7];
                    label21.Text = equipos[0, 8];
                    label22.Text = equipos[0, 9];

                    //Dos;
                    label23.Text = equipos[1, 0];
                    label24.Text = equipos[1, 1];
                    label25.Text = equipos[1, 2];
                    label26.Text = equipos[1, 3];
                    label27.Text = equipos[1, 4];
                    label28.Text = equipos[1, 5];
                    label29.Text = equipos[1, 6];
                    label30.Text = equipos[1, 7];
                    label31.Text = equipos[1, 8];
                    label32.Text = equipos[1, 9];

                    //Tres;
                    label33.Text = equipos[2, 0];
                    label34.Text = equipos[2, 1];
                    label35.Text = equipos[2, 2];
                    label36.Text = equipos[2, 3];
                    label37.Text = equipos[2, 4];
                    label38.Text = equipos[2, 5];
                    label39.Text = equipos[2, 6];
                    label40.Text = equipos[2, 7];
                    label41.Text = equipos[2, 8];
                    label42.Text = equipos[2, 9];

                    //Cuatro;
                    label43.Text = equipos[3, 0];
                    label44.Text = equipos[3, 1];
                    label45.Text = equipos[3, 2];
                    label46.Text = equipos[3, 3];
                    label47.Text = equipos[3, 4];
                    label48.Text = equipos[3, 5];
                    label49.Text = equipos[3, 6];
                    label50.Text = equipos[3, 7];
                    label51.Text = equipos[3, 8];
                    label52.Text = equipos[3, 9];

                    //Cinco;
                    label53.Text = equipos[4, 0];
                    label54.Text = equipos[4, 1];
                    label55.Text = equipos[4, 2];
                    label56.Text = equipos[4, 3];
                    label57.Text = equipos[4, 4];
                    label58.Text = equipos[4, 5];
                    label59.Text = equipos[4, 6];
                    label60.Text = equipos[4, 7];
                    label61.Text = equipos[4, 8];
                    label62.Text = equipos[4, 9];
                    //Seis;
                    label63.Visible = false;
                    label64.Visible = false;
                    label65.Visible = false;
                    label66.Visible = false;
                    label67.Visible = false;
                    label68.Visible = false;
                    label69.Visible = false;
                    label70.Visible = false;
                    label71.Visible = false;
                    label72.Visible = false;
                    label78.Visible = false;

                    break;

                case 6:

                    //Uno;
                    label12.Text = equipos[0, 0];
                    label13.Text = equipos[0, 1];
                    label14.Text = equipos[0, 2];
                    label15.Text = equipos[0, 3];
                    label16.Text = equipos[0, 4];
                    label17.Text = equipos[0, 5];
                    label18.Text = equipos[0, 6];
                    label20.Text = equipos[0, 7];
                    label21.Text = equipos[0, 8];
                    label22.Text = equipos[0, 9];

                    //Dos;
                    label23.Text = equipos[1, 0];
                    label24.Text = equipos[1, 1];
                    label25.Text = equipos[1, 2];
                    label26.Text = equipos[1, 3];
                    label27.Text = equipos[1, 4];
                    label28.Text = equipos[1, 5];
                    label29.Text = equipos[1, 6];
                    label30.Text = equipos[1, 7];
                    label31.Text = equipos[1, 8];
                    label32.Text = equipos[1, 9];

                    //Tres;
                    label33.Text = equipos[2, 0];
                    label34.Text = equipos[2, 1];
                    label35.Text = equipos[2, 2];
                    label36.Text = equipos[2, 3];
                    label37.Text = equipos[2, 4];
                    label38.Text = equipos[2, 5];
                    label39.Text = equipos[2, 6];
                    label40.Text = equipos[2, 7];
                    label41.Text = equipos[2, 8];
                    label42.Text = equipos[2, 9];

                    //Cuatro;
                    label43.Text = equipos[3, 0];
                    label44.Text = equipos[3, 1];
                    label45.Text = equipos[3, 2];
                    label46.Text = equipos[3, 3];
                    label47.Text = equipos[3, 4];
                    label48.Text = equipos[3, 5];
                    label49.Text = equipos[3, 6];
                    label50.Text = equipos[3, 7];
                    label51.Text = equipos[3, 8];
                    label52.Text = equipos[3, 9];

                    //Cinco;
                    label53.Text = equipos[4, 0];
                    label54.Text = equipos[4, 1];
                    label55.Text = equipos[4, 2];
                    label56.Text = equipos[4, 3];
                    label57.Text = equipos[4, 4];
                    label58.Text = equipos[4, 5];
                    label59.Text = equipos[4, 6];
                    label60.Text = equipos[4, 7];
                    label61.Text = equipos[4, 8];
                    label62.Text = equipos[4, 9];

                    //Seis;
                    label63.Text = equipos[5, 0];
                    label64.Text = equipos[5, 1];
                    label65.Text = equipos[5, 2];
                    label66.Text = equipos[5, 3];
                    label67.Text = equipos[5, 4];
                    label68.Text = equipos[5, 5];
                    label69.Text = equipos[5, 6];
                    label70.Text = equipos[5, 7];
                    label71.Text = equipos[5, 8];
                    label72.Text = equipos[5, 9];
                    break;
            }
        }

        public void ordenEquipos()
        {
            string[] auxNombre = new string[10];

            for (int i = 0; i < cantidadEquipos-1; i++)
            {
                for (int j = 0; j < cantidadEquipos-1; j++)
                {
                    if (Convert.ToInt32(equipos[j, 9]) < Convert.ToInt32(equipos[j + 1, 9]))
                    {
                        for (int k = 0; k < 10; k++)
                            auxNombre[k] = (equipos[j, k]);

                        for (int h = 0; h < 10; h++)
                            equipos[j, h] = equipos[j + 1, h];

                        for (int o = 0; o < 10; o++)
                            equipos[j + 1, o] = auxNombre[o];

                    }

                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            label80.Text = "";
            for (int i = 0; i < 5; i++)
                label80.Text = label80.Text + "\n" + partidos[index, i];
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }


    }
}
