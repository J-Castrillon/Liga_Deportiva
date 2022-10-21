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
    public partial class Form2 : Form
    {
        Form1 formularioUno = new Form1();
        int i = new int();
        private string[,] equipos;
        int j = new int();
        int aux = new int();
        int aux2 = new int();
        string[,] partidos= new string[6,5];

        int cantidadEquipos = new int();
        int fechas = new int();
        int partidosPorFecha = new int();
        int totalPartidos = new int();

        public Form2(int cantidadEquipos,string[,] equipos, int fechas,int partidosPorFecha, int totalPartidos)
        {
            InitializeComponent();

            for (int o = 0; o < 6; o++)
            {
                for(int p = 2; p < 10; p++)
                {
                    equipos[o, p] = Convert.ToString(0);
                }
            }
            label1.Text = "Fecha número: 1";
            j = 1;

            label4.Text = "Partido número: "+ (j);

            this.cantidadEquipos = cantidadEquipos;
            this.equipos = equipos;
            this.fechas = fechas;
            this.partidosPorFecha = partidosPorFecha;
            this.totalPartidos = totalPartidos;

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            switch (cantidadEquipos)
            {
                case 2:
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    label2.Text = equipos[0, 1];
                    label3.Text = equipos[1, 1];
                    equipos[0, 2] = Convert.ToString(fechas);
                    equipos[1, 2] = Convert.ToString(fechas);
                    break;

                case 3:
                    label5.Visible = true;
                    label5.Text = "Descansa el equipo: " + equipos[0, 1];
                    label2.Text = "";
                    label3.Text = "";
                    equipos[0, 2] = Convert.ToString(fechas - 1);
                    equipos[1, 2] = Convert.ToString(fechas - 1);
                    equipos[2, 2] = Convert.ToString(fechas - 1);
                    break;

                case 4:
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    label2.Text = equipos[0, 1];
                    label3.Text = equipos[1, 1];
                    equipos[0, 2] = Convert.ToString(fechas);
                    equipos[1, 2] = Convert.ToString(fechas);
                    equipos[2, 2] = Convert.ToString(fechas);
                    equipos[3, 2] = Convert.ToString(fechas);
                    break;

                case 5:
                    label5.Visible = true;
                    label5.Text = "Descansa el equipo: " + equipos[0, 1];
                    label2.Text = "";
                    label3.Text = "";
                    equipos[0, 2] = Convert.ToString(fechas - 1);
                    equipos[1, 2] = Convert.ToString(fechas - 1);
                    equipos[2, 2] = Convert.ToString(fechas - 1);
                    equipos[3, 2] = Convert.ToString(fechas - 1);
                    equipos[4, 2] = Convert.ToString(fechas - 1);

                    break;

                case 6:
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    label2.Text = equipos[0, 1];
                    label3.Text = equipos[1, 1];
                    equipos[0, 2] = Convert.ToString(fechas);
                    equipos[1, 2] = Convert.ToString(fechas);
                    equipos[2, 2] = Convert.ToString(fechas);
                    equipos[3, 2] = Convert.ToString(fechas);
                    equipos[4, 2] = Convert.ToString(fechas);
                    equipos[5, 2] = Convert.ToString(fechas);
                    break;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (j != partidosPorFecha)
            {
                j += 1; //partidos;
            }
            else
            {
                i += 1; //fechas;
                j = 1;
            }
            label1.Text = "Fecha número: " + (i + 1);
            label4.Text = "Partido número: " + (j);

            switch (cantidadEquipos)
            {
                case 2:
                    label2.Text = equipos[0, 1];
                    aux = Convert.ToInt32(textBox1.Text);
                    aux2 = Convert.ToInt32(equipos[0, 6]) + aux;
                    equipos[0, 6] = Convert.ToString(aux2);

                    aux = Convert.ToInt32(textBox2.Text);
                    aux2 = Convert.ToInt32(equipos[0, 7]) + aux;
                    equipos[0, 7] = Convert.ToString(aux2);


                    label3.Text = equipos[1, 1];
                    aux = Convert.ToInt32(textBox2.Text);
                    aux2 = Convert.ToInt32(equipos[1, 6]) + aux;
                    equipos[1, 6] = Convert.ToString(aux2);

                    aux = Convert.ToInt32(textBox1.Text);
                    aux2 = Convert.ToInt32(equipos[1, 7]) + aux;
                    equipos[1, 7] = Convert.ToString(aux2);

                    aux= Convert.ToInt32(textBox1.Text);
                    aux2 = Convert.ToInt32(textBox2.Text);

                    if (aux > aux2)
                    {
                        aux = 3;
                        aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                        equipos[0, 9] = Convert.ToString(aux2);
                        aux = Convert.ToInt32(equipos[0, 3]) + 1;
                        equipos[0, 3] = Convert.ToString(aux);

                        aux = Convert.ToInt32(equipos[1, 5]) + 1;
                        equipos[1, 5] = Convert.ToString(aux);

                    }
                    else if (aux < aux2)
                    {
                        aux = 3;
                        aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                        equipos[1, 9] = Convert.ToString(aux2);
                        aux = Convert.ToInt32(equipos[1, 3]) + 1;
                        equipos[1, 3] = Convert.ToString(aux);

                        aux = Convert.ToInt32(equipos[0, 5]) + 1;
                        equipos[0, 5] = Convert.ToString(aux);

                    }
                    else
                    {
                        aux = 1;
                        aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                        equipos[1, 9] = Convert.ToString(aux2);
                        aux2 = Convert.ToInt32(equipos[1, 4]) + aux;
                        equipos[1, 4] = Convert.ToString(aux2);

                        aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                        equipos[0, 9] = Convert.ToString(aux2);
                        aux2 = Convert.ToInt32(equipos[0, 4]) + aux;
                        equipos[0, 4] = Convert.ToString(aux2);

                    }

                    aux = Convert.ToInt32(equipos[0, 6]) - Convert.ToInt32(equipos[0, 7]);
                    equipos[0, 8] = Convert.ToString(aux);
                    aux = Convert.ToInt32(equipos[1, 6]) - Convert.ToInt32(equipos[1, 7]);
                    equipos[1, 8] = Convert.ToString(aux);

                    partidos[0,0] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                    partidos[1,0] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                    break;

                case 3://fechas_3//
                    label5.Visible = true;
                    switch (i)
                    {
                        case 0:
                            if (j == 1)
                            {
                                label5.Visible = true;
                                label5.Text = "Descansa: " + equipos[0, 1];
                                textBox1.Enabled = false;
                                textBox2.Enabled = false;
                                label2.Text = "";
                                label3.Text = "";
                            }
                            else if (j == 2)
                            {
                                label2.Text = equipos[1, 1];
                                label3.Text = equipos[2, 1];
                                label5.Visible = false;
                                textBox1.Enabled = true;
                                textBox2.Enabled = true;
                            }

                            break;

                        case 1:
                            if (j == 1)
                            {
                                //goles a favor;
                                aux = Convert.ToInt32(textBox1.Text);
                                aux2 = Convert.ToInt32(equipos[1, 6]) + Convert.ToInt32(textBox1.Text);
                                equipos[1, 6] = Convert.ToString(aux2);

                                //goles en contra;
                                aux = Convert.ToInt32(textBox2.Text);
                                aux2 = Convert.ToInt32(equipos[1, 7]) + aux;
                                equipos[1, 7] = Convert.ToString(aux2);


                                label3.Text = equipos[2, 1];
                                aux = Convert.ToInt32(textBox2.Text);
                                aux2 = Convert.ToInt32(equipos[2, 6]) + aux;
                                equipos[2, 6] = Convert.ToString(aux2);

                                aux = Convert.ToInt32(textBox1.Text);
                                aux2 = Convert.ToInt32(equipos[2, 7]) + aux;
                                equipos[2, 7] = Convert.ToString(aux2);

                                aux = Convert.ToInt32(textBox1.Text);
                                aux2 = Convert.ToInt32(textBox2.Text);

                                if (aux > aux2)
                                {
                                    aux = 3;
                                    aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                                    equipos[1, 9] = Convert.ToString(aux2);
                                    aux = Convert.ToInt32(equipos[1, 3]) + 1;
                                    equipos[1, 3] = Convert.ToString(aux);

                                    aux = Convert.ToInt32(equipos[2, 5]) + 1;
                                    equipos[2, 5] = Convert.ToString(aux);

                                }
                                else if (aux < aux2)
                                {
                                    aux = 3;
                                    aux2 = Convert.ToInt32(equipos[2, 9]) + aux;
                                    equipos[2, 9] = Convert.ToString(aux2);
                                    aux = Convert.ToInt32(equipos[2, 3]) + 1;
                                    equipos[2, 3] = Convert.ToString(aux);

                                    aux = Convert.ToInt32(equipos[1, 5]) + 1;
                                    equipos[1, 5] = Convert.ToString(aux);

                                }
                                else
                                {

                                    aux = 1;
                                    aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                                    equipos[1, 9] = Convert.ToString(aux2);
                                    aux2 = Convert.ToInt32(equipos[1, 4]) + aux;
                                    equipos[1, 4] = Convert.ToString(aux2);

                                    aux2 = Convert.ToInt32(equipos[2, 9]) + aux;
                                    equipos[2, 9] = Convert.ToString(aux2);
                                    aux2 = Convert.ToInt32(equipos[2, 4]) + aux;
                                    equipos[2, 4] = Convert.ToString(aux2);

                                }

                                aux = Convert.ToInt32(equipos[1, 6]) - Convert.ToInt32(equipos[1, 7]);
                                equipos[1, 8] = Convert.ToString(aux);
                                aux = Convert.ToInt32(equipos[2, 6]) - Convert.ToInt32(equipos[2, 7]);
                                equipos[2, 8] = Convert.ToString(aux);

                                partidos[1,0] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                partidos[2,0] = label3.Text + " " + textBox2.Text + "-" + textBox1.Text + " " + label2.Text;

                                label5.Visible = true;
                                label5.Text = "Descansa el equipo: " + equipos[1, 1];
                                textBox1.Enabled = false;
                                textBox2.Enabled = false;
                                label2.Text = "";
                                label3.Text = "";
                                textBox1.Text = "";
                                textBox2.Text = "";

                            }
                            else if (j == 2)
                            {
                                textBox1.Enabled = true;
                                textBox2.Enabled = true;
                                label5.Visible = false;
                                label2.Text = equipos[0, 1];
                                label3.Text = equipos[2, 1];
                                //------------------------------//

                            }

                            break;

                        case 2:
                            if (j == 1)
                            {
                                //goles a favor;
                                aux = Convert.ToInt32(textBox1.Text);
                                aux2 = Convert.ToInt32(equipos[0, 6]) + aux;
                                equipos[0, 6] = Convert.ToString(aux2);

                                //goles en contra;
                                aux = Convert.ToInt32(textBox2.Text);
                                aux2 = Convert.ToInt32(equipos[0, 7]) + aux;
                                equipos[0, 7] = Convert.ToString(aux2);


                                aux = Convert.ToInt32(textBox2.Text);
                                aux2 = Convert.ToInt32(equipos[2, 6]) + aux;
                                equipos[2, 6] = Convert.ToString(aux2);

                                aux = Convert.ToInt32(textBox1.Text);
                                aux2 = Convert.ToInt32(equipos[2, 7]) + aux;
                                equipos[2, 7] = Convert.ToString(aux2);

                                aux = Convert.ToInt32(textBox1.Text);
                                aux2 = Convert.ToInt32(textBox2.Text);

                                if (aux > aux2)
                                {
                                    aux = 3;
                                    aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                                    equipos[0, 9] = Convert.ToString(aux2);
                                    aux = Convert.ToInt32(equipos[0, 3]) + 1;
                                    equipos[0, 3] = Convert.ToString(aux);

                                    aux = Convert.ToInt32(equipos[2, 5]) + 1;
                                    equipos[2, 5] = Convert.ToString(aux);

                                }
                                else if (aux < aux2)
                                {
                                    aux = 3;
                                    aux2 = Convert.ToInt32(equipos[2, 9]) + aux;
                                    equipos[2, 9] = Convert.ToString(aux2);
                                    aux = Convert.ToInt32(equipos[2, 3]) + 1;
                                    equipos[2, 3] = Convert.ToString(aux);

                                    aux = Convert.ToInt32(equipos[0, 5]) + 1;
                                    equipos[0, 5] = Convert.ToString(aux);

                                }
                                else
                                {

                                    aux = 1;
                                    aux2 = Convert.ToInt32(equipos[2, 9]) + aux;
                                    equipos[2, 9] = Convert.ToString(aux2);
                                    aux2 = Convert.ToInt32(equipos[2, 4]) + aux;
                                    equipos[2, 4] = Convert.ToString(aux2);

                                    aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                                    equipos[0, 9] = Convert.ToString(aux2);
                                    aux2 = Convert.ToInt32(equipos[0, 4]) + aux;
                                    equipos[0, 4] = Convert.ToString(aux2);

                                }
                                partidos[2, 1] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                partidos[0, 0] = label3.Text + " " + textBox2.Text + "-" + textBox1.Text + " " + label2.Text;

                                aux = Convert.ToInt32(equipos[0, 6]) - Convert.ToInt32(equipos[0, 7]);
                                equipos[0, 8] = Convert.ToString(aux);
                                aux = Convert.ToInt32(equipos[2, 6]) - Convert.ToInt32(equipos[2, 7]);
                                equipos[2, 8] = Convert.ToString(aux);

                                label5.Visible = true;
                                label5.Text = "Descansa el equipo: " + equipos[2, 1];
                                textBox1.Enabled = false;
                                textBox2.Enabled = false;
                                label2.Text = "";
                                label3.Text = "";
                                textBox1.Text = "";
                                textBox2.Text = "";
                            }
                            else if (j == 2)
                            {
                                textBox1.Enabled = true;
                                textBox2.Enabled = true;
                                label5.Visible = false;
                                label2.Text = equipos[0, 1];
                                label3.Text = equipos[1, 1];

                            }
                            break;
                    }

                    break;
                case 4:
                    {
                        switch (i) 
                        {
                            case 0:

                                if (j == 1)
                                {
                                    label2.Text = equipos[0, 1];
                                    label3.Text = equipos[1, 1];
                                }
                                else if (j == 2)
                                {
                                    //goles a favor;
                                    aux = Convert.ToInt32(textBox1.Text);
                                    aux2 = Convert.ToInt32(equipos[0, 6]) + aux;
                                    equipos[0, 6] = Convert.ToString(aux2);

                                    //goles en contra;
                                    aux = Convert.ToInt32(textBox2.Text);
                                    aux2 = Convert.ToInt32(equipos[0, 7]) + aux;
                                    equipos[0, 7] = Convert.ToString(aux2);


                                    aux = Convert.ToInt32(textBox2.Text);
                                    aux2 = Convert.ToInt32(equipos[1, 6]) + aux;
                                    equipos[1, 6] = Convert.ToString(aux2);

                                    aux = Convert.ToInt32(textBox1.Text);
                                    aux2 = Convert.ToInt32(equipos[1, 7]) + aux;
                                    equipos[1, 7] = Convert.ToString(aux2);

                                    aux = Convert.ToInt32(textBox1.Text);
                                    aux2 = Convert.ToInt32(textBox2.Text);

                                    if (aux > aux2)
                                    {
                                        aux = 3;
                                        aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                                        equipos[0, 9] = Convert.ToString(aux2);
                                        aux = Convert.ToInt32(equipos[0, 3]) + 1;
                                        equipos[0, 3] = Convert.ToString(aux);

                                        aux = Convert.ToInt32(equipos[1, 5]) + 1;
                                        equipos[1, 5] = Convert.ToString(aux);

                                    }
                                    else if (aux < aux2)
                                    {
                                        aux = 3;
                                        aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                                        equipos[1, 9] = Convert.ToString(aux2);
                                        aux = Convert.ToInt32(equipos[1, 3]) + 1;
                                        equipos[1, 3] = Convert.ToString(aux);

                                        aux = Convert.ToInt32(equipos[0, 5]) + 1;
                                        equipos[0, 5] = Convert.ToString(aux);

                                    }
                                    else
                                    {

                                        aux = 1;
                                        aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                                        equipos[0, 9] = Convert.ToString(aux2);
                                        aux2 = Convert.ToInt32(equipos[0, 4]) + aux;
                                        equipos[0, 4] = Convert.ToString(aux2);

                                        aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                                        equipos[1, 9] = Convert.ToString(aux2);
                                        aux2 = Convert.ToInt32(equipos[1, 4]) + aux;
                                        equipos[1, 4] = Convert.ToString(aux2);

                                    }

                                    partidos[0, 0] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                    partidos[1, 0] = label3.Text + " " + textBox2.Text + "-" + textBox1.Text + " " + label2.Text;
                                    textBox1.Text = "";
                                    textBox2.Text = "";

                                    label2.Text = equipos[3, 1];
                                    label3.Text = equipos[2, 1];
                                }
                                break;

                            case 1:
                                if (j == 1)
                                {
                                    //goles a favor;
                                    aux = Convert.ToInt32(textBox1.Text);
                                    aux2 = Convert.ToInt32(equipos[3, 6]) + aux;
                                    equipos[3, 6] = Convert.ToString(aux2);

                                    //goles en contra;
                                    aux = Convert.ToInt32(textBox2.Text);
                                    aux2 = Convert.ToInt32(equipos[3, 7]) + aux;
                                    equipos[3, 7] = Convert.ToString(aux2);


                                    aux = Convert.ToInt32(textBox2.Text);
                                    aux2 = Convert.ToInt32(equipos[2, 6]) + aux;
                                    equipos[2, 6] = Convert.ToString(aux2);

                                    aux = Convert.ToInt32(textBox1.Text);
                                    aux2 = Convert.ToInt32(equipos[2, 7]) + aux;
                                    equipos[2, 7] = Convert.ToString(aux2);

                                    aux = Convert.ToInt32(textBox1.Text);
                                    aux2 = Convert.ToInt32(textBox2.Text);

                                    if (aux > aux2)
                                    {
                                        aux = 3;
                                        aux2 = Convert.ToInt32(equipos[3, 9]) + aux;
                                        equipos[3, 9] = Convert.ToString(aux2);
                                        aux = Convert.ToInt32(equipos[3, 3]) + 1;
                                        equipos[3, 3] = Convert.ToString(aux);

                                        aux = Convert.ToInt32(equipos[2, 5]) + 1;
                                        equipos[2, 5] = Convert.ToString(aux);

                                    }
                                    else if (aux < aux2)
                                    {
                                        aux = 3;
                                        aux2 = Convert.ToInt32(equipos[2, 9]) + aux;
                                        equipos[2, 9] = Convert.ToString(aux2);
                                        aux = Convert.ToInt32(equipos[2, 3]) + 1;
                                        equipos[2, 3] = Convert.ToString(aux);

                                        aux = Convert.ToInt32(equipos[3, 5]) + 1;
                                        equipos[3, 5] = Convert.ToString(aux);

                                    }
                                    else
                                    {

                                        aux = 1;
                                        aux2 = Convert.ToInt32(equipos[3, 9]) + aux;
                                        equipos[3, 9] = Convert.ToString(aux2);
                                        aux2 = Convert.ToInt32(equipos[3, 4]) + aux;
                                        equipos[3, 4] = Convert.ToString(aux2);

                                        aux2 = Convert.ToInt32(equipos[2, 9]) + aux;
                                        equipos[2, 9] = Convert.ToString(aux2);
                                        aux2 = Convert.ToInt32(equipos[2, 4]) + aux;
                                        equipos[2, 4] = Convert.ToString(aux2);

                                    }
                                    partidos[3, 0] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                    partidos[2, 0] = label3.Text + " " + textBox2.Text + "-" + textBox1.Text + " " + label2.Text;

                                    textBox1.Text = "";
                                    textBox2.Text = "";

                                    label2.Text = equipos[0, 1];
                                    label3.Text = equipos[2, 1];
                                }
                                else if (j == 2)
                                {
                                    //goles a favor;
                                    aux = Convert.ToInt32(textBox1.Text);
                                    aux2 = Convert.ToInt32(equipos[0, 6]) + aux;
                                    equipos[0, 6] = Convert.ToString(aux2);

                                    //goles en contra;
                                    aux = Convert.ToInt32(textBox2.Text);
                                    aux2 = Convert.ToInt32(equipos[0, 7]) + aux;
                                    equipos[0, 7] = Convert.ToString(aux2);


                                    aux = Convert.ToInt32(textBox2.Text);
                                    aux2 = Convert.ToInt32(equipos[2, 6]) + aux;
                                    equipos[2, 6] = Convert.ToString(aux2);

                                    aux = Convert.ToInt32(textBox1.Text);
                                    aux2 = Convert.ToInt32(equipos[2, 7]) + aux;
                                    equipos[2, 7] = Convert.ToString(aux2);

                                    aux = Convert.ToInt32(textBox1.Text);
                                    aux2 = Convert.ToInt32(textBox2.Text);

                                    if (aux > aux2)
                                    {
                                        aux = 3;
                                        aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                                        equipos[0, 9] = Convert.ToString(aux2);
                                        aux = Convert.ToInt32(equipos[0, 3]) + 1;
                                        equipos[0, 3] = Convert.ToString(aux);

                                        aux = Convert.ToInt32(equipos[2, 5]) + 1;
                                        equipos[2, 5] = Convert.ToString(aux);

                                    }
                                    else if (aux < aux2)
                                    {
                                        aux = 3;
                                        aux2 = Convert.ToInt32(equipos[2, 9]) + aux;
                                        equipos[2, 9] = Convert.ToString(aux2);
                                        aux = Convert.ToInt32(equipos[2, 3]) + 1;
                                        equipos[2, 3] = Convert.ToString(aux);

                                        aux = Convert.ToInt32(equipos[0, 5]) + 1;
                                        equipos[0, 5] = Convert.ToString(aux);

                                    }
                                    else
                                    {

                                        aux = 1;
                                        aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                                        equipos[0, 9] = Convert.ToString(aux2);
                                        aux2 = Convert.ToInt32(equipos[0, 4]) + aux;
                                        equipos[0, 4] = Convert.ToString(aux2);

                                        aux2 = Convert.ToInt32(equipos[2, 9]) + aux;
                                        equipos[2, 9] = Convert.ToString(aux2);
                                        aux2 = Convert.ToInt32(equipos[2, 4]) + aux;
                                        equipos[2, 4] = Convert.ToString(aux2);

                                    }
                                    partidos[0, 1] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                    partidos[2, 1] = label3.Text + " " + textBox2.Text + "-" + textBox1.Text + " " + label2.Text;

                                    textBox1.Text = "";
                                    textBox2.Text = "";
                                    label2.Text = equipos[1, 1];
                                    label3.Text = equipos[3, 1];
                                }
                                break;

                            case 2:
                                if (j == 1)
                                {
                                    //goles a favor;
                                    aux = Convert.ToInt32(textBox1.Text);
                                    aux2 = Convert.ToInt32(equipos[1, 6]) + aux;
                                    equipos[1, 6] = Convert.ToString(aux2);

                                    //goles en contra;
                                    aux = Convert.ToInt32(textBox2.Text);
                                    aux2 = Convert.ToInt32(equipos[1, 7]) + aux;
                                    equipos[1, 7] = Convert.ToString(aux2);


                                    aux = Convert.ToInt32(textBox2.Text);
                                    aux2 = Convert.ToInt32(equipos[3, 6]) + aux;
                                    equipos[3, 6] = Convert.ToString(aux2);

                                    aux = Convert.ToInt32(textBox1.Text);
                                    aux2 = Convert.ToInt32(equipos[3, 7]) + aux;
                                    equipos[3, 7] = Convert.ToString(aux2);

                                    aux = Convert.ToInt32(textBox1.Text);
                                    aux2 = Convert.ToInt32(textBox2.Text);

                                    if (aux > aux2)
                                    {
                                        aux = 3;
                                        aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                                        equipos[1, 9] = Convert.ToString(aux2);
                                        aux = Convert.ToInt32(equipos[1, 3]) + 1;
                                        equipos[1, 3] = Convert.ToString(aux);

                                        aux = Convert.ToInt32(equipos[3, 5]) + 1;
                                        equipos[3, 5] = Convert.ToString(aux);

                                    }
                                    else if (aux < aux2)
                                    {
                                        aux = 3;
                                        aux2 = Convert.ToInt32(equipos[3, 9]) + aux;
                                        equipos[3, 9] = Convert.ToString(aux2);
                                        aux = Convert.ToInt32(equipos[3, 3]) + 1;
                                        equipos[3, 3] = Convert.ToString(aux);

                                        aux = Convert.ToInt32(equipos[1, 5]) + 1;
                                        equipos[1, 5] = Convert.ToString(aux);

                                    }
                                    else
                                    {

                                        aux = 1;
                                        aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                                        equipos[1, 9] = Convert.ToString(aux2);
                                        aux2 = Convert.ToInt32(equipos[1, 4]) + aux;
                                        equipos[1, 4] = Convert.ToString(aux2);

                                        aux2 = Convert.ToInt32(equipos[3, 9]) + aux;
                                        equipos[3, 9] = Convert.ToString(aux2);
                                        aux2 = Convert.ToInt32(equipos[3, 4]) + aux;
                                        equipos[3, 4] = Convert.ToString(aux2);
                                    }
                                    partidos[1, 1] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                    partidos[3, 1] = label3.Text + " " + textBox2.Text + "-" + textBox1.Text + " " + label2.Text;

                                    textBox1.Text = "";
                                    textBox2.Text = "";
                                    label2.Text = equipos[0, 1];
                                    label3.Text = equipos[3, 1];

                                }
                                else if (j == 2)
                                {
                                    //goles a favor;
                                    aux = Convert.ToInt32(textBox1.Text);
                                    aux2 = Convert.ToInt32(equipos[0, 6]) + aux;
                                    equipos[0, 6] = Convert.ToString(aux2);

                                    //goles en contra;
                                    aux = Convert.ToInt32(textBox2.Text);
                                    aux2 = Convert.ToInt32(equipos[0, 7]) + aux;
                                    equipos[0, 7] = Convert.ToString(aux2);


                                    aux = Convert.ToInt32(textBox2.Text);
                                    aux2 = Convert.ToInt32(equipos[3, 6]) + aux;
                                    equipos[3, 6] = Convert.ToString(aux2);

                                    aux = Convert.ToInt32(textBox1.Text);
                                    aux2 = Convert.ToInt32(equipos[3, 7]) + aux;
                                    equipos[3, 7] = Convert.ToString(aux2);

                                    aux = Convert.ToInt32(textBox1.Text);
                                    aux2 = Convert.ToInt32(textBox2.Text);

                                    if (aux > aux2)
                                    {
                                        aux = 3;
                                        aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                                        equipos[0, 9] = Convert.ToString(aux2);
                                        aux = Convert.ToInt32(equipos[0, 3]) + 1;
                                        equipos[0, 3] = Convert.ToString(aux);

                                        aux = Convert.ToInt32(equipos[3, 5]) + 1;
                                        equipos[3, 5] = Convert.ToString(aux);

                                    }
                                    else if (aux < aux2)
                                    {
                                        aux = 3;
                                        aux2 = Convert.ToInt32(equipos[3, 9]) + aux;
                                        equipos[3, 9] = Convert.ToString(aux2);
                                        aux = Convert.ToInt32(equipos[3, 3]) + 1;
                                        equipos[3, 3] = Convert.ToString(aux);

                                        aux = Convert.ToInt32(equipos[0, 5]) + 1;
                                        equipos[0, 5] = Convert.ToString(aux);

                                    }
                                    else
                                    {

                                        aux = 1;
                                        aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                                        equipos[0, 9] = Convert.ToString(aux2);
                                        aux2 = Convert.ToInt32(equipos[0, 4]) + aux;
                                        equipos[0, 4] = Convert.ToString(aux2);

                                        aux2 = Convert.ToInt32(equipos[3, 9]) + aux;
                                        equipos[3, 9] = Convert.ToString(aux2);
                                        aux2 = Convert.ToInt32(equipos[3, 4]) + aux;
                                        equipos[3, 4] = Convert.ToString(aux2);

                                    }
                                    partidos[0, 2] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                    partidos[3, 2] = label3.Text + " " + textBox2.Text + "-" + textBox1.Text + " " + label2.Text;

                                    textBox1.Text = "";
                                    textBox2.Text = "";
                                    label2.Text = equipos[2, 1];
                                    label3.Text = equipos[1, 1];
                                }
                                break;
                        }
                        break;
                    }
                case 5:
                    {
                        label5.Visible = true;

                        switch (i)//fechas
                        {
                            case 0:
                                switch (j)//partidos
                                {
                                    case 1:
                                        {
                                            label5.Visible = true;
                                            label5.Text = "Descansa el equipo: " + equipos[0, 1];
                                            textBox1.Enabled = false;
                                            textBox2.Enabled = false;
                                            label2.Text = "";
                                            label3.Text = "";
                                            textBox1.Text = "";
                                            textBox2.Text = "";
                                        }
                                        break;
                                    case 2:
                                        {
                                            textBox1.Enabled = true;
                                            textBox2.Enabled = true;
                                            label5.Visible = false;
                                            label2.Text = equipos[4, 1];
                                            label3.Text = equipos[1, 1];

                                        }
                                        break;
                                    case 3:
                                        {
                                            //goles a favor;
                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[4, 6]) + aux;
                                            equipos[4, 6] = Convert.ToString(aux2);

                                            //goles en contra;
                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[4, 7]) + aux;
                                            equipos[4, 7] = Convert.ToString(aux2);


                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[1, 6]) + aux;
                                            equipos[1, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[1, 7]) + aux;
                                            equipos[1, 7] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(textBox2.Text);

                                            if (aux > aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[4, 9]) + aux;
                                                equipos[4, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[4, 3]) + 1;
                                                equipos[4, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[1, 5]) + 1;
                                                equipos[1, 5] = Convert.ToString(aux);

                                            }
                                            else if (aux < aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                                                equipos[1, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[1, 3]) + 1;
                                                equipos[1, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[4, 5]) + 1;
                                                equipos[4, 5] = Convert.ToString(aux);

                                            }
                                            else
                                            {

                                                aux = 1;
                                                aux2 = Convert.ToInt32(equipos[4, 9]) + aux;
                                                equipos[4, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[4, 4]) + aux;
                                                equipos[4, 4] = Convert.ToString(aux2);

                                                aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                                                equipos[1, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[1, 4]) + aux;
                                                equipos[1, 4] = Convert.ToString(aux2);

                                            }
                                            partidos[4, 0] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                            partidos[1, 0] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                            textBox1.Text = "";
                                            textBox2.Text = "";

                                            textBox1.Enabled = true;
                                            textBox2.Enabled = true;
                                            label5.Visible = false;
                                            label2.Text = equipos[3, 1];
                                            label3.Text = equipos[2, 1];
                                        }
                                        break;

                                }
                                break;
                            case 1:
                                switch (j)//partidos
                                {
                                    case 1:
                                        {
                                            //goles a favor;
                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[3, 6]) + Convert.ToInt32(textBox1.Text);
                                            equipos[3, 6] = Convert.ToString(aux2);

                                            //goles en contra;
                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[3, 7]) + aux;
                                            equipos[3, 7] = Convert.ToString(aux2);


                                            label3.Text = equipos[2, 1];
                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[2, 6]) + aux;
                                            equipos[2, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[2, 7]) + aux;
                                            equipos[2, 7] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(textBox2.Text);

                                            if (aux > aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[3, 9]) + aux;
                                                equipos[3, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[3, 3]) + 1;
                                                equipos[3, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[2, 5]) + 1;
                                                equipos[2, 5] = Convert.ToString(aux);

                                            }
                                            else if (aux < aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[2, 9]) + aux;
                                                equipos[2, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[2, 3]) + 1;
                                                equipos[2, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[3, 5]) + 1;
                                                equipos[3, 5] = Convert.ToString(aux);

                                            }
                                            else
                                            {

                                                aux = 1;
                                                aux2 = Convert.ToInt32(equipos[3, 9]) + aux;
                                                equipos[3, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[3, 4]) + aux;
                                                equipos[3, 4] = Convert.ToString(aux2);

                                                aux2 = Convert.ToInt32(equipos[2, 9]) + aux;
                                                equipos[2, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[2, 4]) + aux;
                                                equipos[2, 4] = Convert.ToString(aux2);

                                            }
                                            partidos[3, 0] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                            partidos[2, 0] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;

                                            label5.Visible = true;
                                            label5.Text = "Descansa el equipo: " + equipos[1, 1];
                                            textBox1.Enabled = false;
                                            textBox2.Enabled = false;
                                            label2.Text = "";
                                            label3.Text = "";
                                            textBox1.Text = "";
                                            textBox2.Text = "";
                                        }
                                        break;
                                    case 2:
                                        {
                                            textBox1.Enabled = true;
                                            textBox2.Enabled = true;
                                            label5.Visible = false;
                                            label2.Text = equipos[0, 1];
                                            label3.Text = equipos[2, 1];

                                            textBox1.Text = "";
                                            textBox2.Text = "";
                                        }
                                        break;
                                    case 3:
                                        {
                                            //goles a favor;
                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[0, 6]) + aux;
                                            equipos[0, 6] = Convert.ToString(aux2);

                                            //goles en contra;
                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[0, 7]) + aux;
                                            equipos[0, 7] = Convert.ToString(aux2);


                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[2, 6]) + aux;
                                            equipos[2, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[2, 7]) + aux;
                                            equipos[2, 7] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(textBox2.Text);

                                            if (aux > aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                                                equipos[0, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[0, 3]) + 1;
                                                equipos[0, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[2, 5]) + 1;
                                                equipos[2, 5] = Convert.ToString(aux);

                                            }
                                            else if (aux < aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[2, 9]) + aux;
                                                equipos[2, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[2, 3]) + 1;
                                                equipos[2, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[0, 5]) + 1;
                                                equipos[0, 5] = Convert.ToString(aux);

                                            }
                                            else
                                            {

                                                aux = 1;
                                                aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                                                equipos[0, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[0, 4]) + aux;
                                                equipos[0, 4] = Convert.ToString(aux2);

                                                aux2 = Convert.ToInt32(equipos[2, 9]) + aux;
                                                equipos[2, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[2, 4]) + aux;
                                                equipos[2, 4] = Convert.ToString(aux2);

                                            }
                                            partidos[0, 0] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                            partidos[2, 1] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                            textBox1.Text = "";
                                            textBox2.Text = "";

                                            textBox1.Enabled = true;
                                            textBox2.Enabled = true;
                                            label5.Visible = false;
                                            label2.Text = equipos[4, 1];
                                            label3.Text = equipos[3, 1];

                                        }
                                        break;

                                }
                                break;
                            case 2:
                                switch (j)//partidos
                                {
                                    case 1:
                                        {
                                            //goles a favor;
                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[4, 6]) + aux;
                                            equipos[4, 6] = Convert.ToString(aux2);

                                            //goles en contra;
                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[4, 7]) + aux;
                                            equipos[4, 7] = Convert.ToString(aux2);


                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[3, 6]) + aux;
                                            equipos[3, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[3, 7]) + aux;
                                            equipos[3, 7] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(textBox2.Text);

                                            if (aux > aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[4, 9]) + aux;
                                                equipos[4, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[4, 3]) + 1;
                                                equipos[4, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[3, 5]) + 1;
                                                equipos[3, 5] = Convert.ToString(aux);

                                            }
                                            else if (aux < aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[3, 9]) + aux;
                                                equipos[3, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[3, 3]) + 1;
                                                equipos[3, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[4, 5]) + 1;
                                                equipos[4, 5] = Convert.ToString(aux);

                                            }
                                            else
                                            {

                                                aux = 1;
                                                aux2 = Convert.ToInt32(equipos[4, 9]) + aux;
                                                equipos[4, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[4, 4]) + aux;
                                                equipos[4, 4] = Convert.ToString(aux2);

                                                aux2 = Convert.ToInt32(equipos[3, 9]) + aux;
                                                equipos[3, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[3, 4]) + aux;
                                                equipos[3, 4] = Convert.ToString(aux2);

                                            }
                                            partidos[4, 1] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                            partidos[3, 1] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;

                                            label5.Visible = true;
                                            label5.Text = "Descansa el equipo: " + equipos[2, 1];
                                            textBox1.Enabled = false;
                                            textBox2.Enabled = false;
                                            label2.Text = "";
                                            label3.Text = "";
                                            textBox1.Text = "";
                                            textBox2.Text = "";
                                        }
                                        break;
                                    case 2:
                                        {
                                            textBox1.Enabled = true;
                                            textBox2.Enabled = true;
                                            label5.Visible = false;
                                            label2.Text = equipos[1, 1];
                                            label3.Text = equipos[3, 1];

                                        }
                                        break;
                                    case 3:
                                        {
                                            //goles a favor;
                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[1, 6]) + aux;
                                            equipos[1, 6] = Convert.ToString(aux2);

                                            //goles en contra;
                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[1, 7]) + aux;
                                            equipos[1, 7] = Convert.ToString(aux2);


                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[3, 6]) + aux;
                                            equipos[3, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[3, 7]) + aux;
                                            equipos[3, 7] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(textBox2.Text);

                                            if (aux > aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                                                equipos[1, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[1, 3]) + 1;
                                                equipos[1, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[3, 5]) + 1;
                                                equipos[3, 5] = Convert.ToString(aux);

                                            }
                                            else if (aux < aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[3, 9]) + aux;
                                                equipos[3, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[3, 3]) + 1;
                                                equipos[3, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[1, 5]) + 1;
                                                equipos[1, 5] = Convert.ToString(aux);

                                            }
                                            else
                                            {

                                                aux = 1;
                                                aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                                                equipos[1, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[1, 4]) + aux;
                                                equipos[1, 4] = Convert.ToString(aux2);

                                                aux2 = Convert.ToInt32(equipos[3, 9]) + aux;
                                                equipos[3, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[3, 4]) + aux;
                                                equipos[3, 4] = Convert.ToString(aux2);

                                            }
                                            partidos[1, 1] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                            partidos[3, 2] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;

                                            textBox1.Text = "";
                                            textBox2.Text = "";
                                            textBox1.Enabled = true;
                                            textBox2.Enabled = true;
                                            label5.Visible = false;
                                            label2.Text = equipos[0, 1];
                                            label3.Text = equipos[4, 1];
                                        }
                                        break;

                                }
                                break;
                            case 3:
                                switch (j)//partidos
                                {
                                    case 1:
                                        {
                                            //goles a favor;
                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[0, 6]) + aux;
                                            equipos[0, 6] = Convert.ToString(aux2);

                                            //goles en contra;
                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[0, 7]) + aux;
                                            equipos[0, 7] = Convert.ToString(aux2);


                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[4, 6]) + aux;
                                            equipos[4, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[4, 7]) + aux;
                                            equipos[4, 7] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(textBox2.Text);

                                            if (aux > aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                                                equipos[0, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[0, 3]) + 1;
                                                equipos[0, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[4, 5]) + 1;
                                                equipos[4, 5] = Convert.ToString(aux);

                                            }
                                            else if (aux < aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[4, 9]) + aux;
                                                equipos[4, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[4, 3]) + 1;
                                                equipos[4, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[0, 5]) + 1;
                                                equipos[0, 5] = Convert.ToString(aux);

                                            }
                                            else
                                            {

                                                aux = 1;
                                                aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                                                equipos[0, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[0, 4]) + aux;
                                                equipos[0, 4] = Convert.ToString(aux2);

                                                aux2 = Convert.ToInt32(equipos[4, 9]) + aux;
                                                equipos[4, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[4, 4]) + aux;
                                                equipos[4, 4] = Convert.ToString(aux2);
                                            }
                                            partidos[0, 2] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                            partidos[4, 2] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;

                                            label5.Visible = true;
                                            label5.Text = "Descansa el equipo: " + equipos[3, 1];
                                            textBox1.Enabled = false;
                                            textBox2.Enabled = false;
                                            label2.Text = "";
                                            label3.Text = "";
                                            textBox1.Text = "";
                                            textBox2.Text = "";
                                        }
                                        break;
                                    case 2:
                                        {
                                            textBox1.Enabled = true;
                                            textBox2.Enabled = true;
                                            label5.Visible = false;
                                            label2.Text = equipos[2, 1];
                                            label3.Text = equipos[4, 1];
                                        }
                                        break;
                                    case 3:
                                        {
                                            //goles a favor;
                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[2, 6]) + aux;
                                            equipos[2, 6] = Convert.ToString(aux2);

                                            //goles en contra;
                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[2, 7]) + aux;
                                            equipos[2, 7] = Convert.ToString(aux2);


                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[4, 6]) + aux;
                                            equipos[4, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[4, 7]) + aux;
                                            equipos[4, 7] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(textBox2.Text);

                                            if (aux > aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[2, 9]) + aux;
                                                equipos[2, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[2, 3]) + 1;
                                                equipos[2, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[4, 5]) + 1;
                                                equipos[4, 5] = Convert.ToString(aux);

                                            }
                                            else if (aux < aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[4, 9]) + aux;
                                                equipos[4, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[4, 3]) + 1;
                                                equipos[4, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[2, 5]) + 1;
                                                equipos[2, 5] = Convert.ToString(aux);

                                            }
                                            else
                                            {

                                                aux = 1;
                                                aux2 = Convert.ToInt32(equipos[2, 9]) + aux;
                                                equipos[2, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[2, 4]) + aux;
                                                equipos[2, 4] = Convert.ToString(aux2);

                                                aux2 = Convert.ToInt32(equipos[4, 9]) + aux;
                                                equipos[4, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[4, 4]) + aux;
                                                equipos[4, 4] = Convert.ToString(aux2);
                                            }

                                            partidos[2, 2] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                            partidos[4, 3] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                            textBox1.Text = "";
                                            textBox2.Text = "";
                                            textBox1.Enabled = true;
                                            textBox2.Enabled = true;
                                            label5.Visible = false;
                                            label2.Text = equipos[1, 1];
                                            label3.Text = equipos[0, 1];
                                        }
                                        break;

                                }
                                break;
                            case 4:
                                switch (j)//partidos
                                {
                                    case 1:
                                        {
                                            //goles a favor;
                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[1, 6]) + aux;
                                            equipos[1, 6] = Convert.ToString(aux2);

                                            //goles en contra;
                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[1, 7]) + aux;
                                            equipos[1, 7] = Convert.ToString(aux2);


                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[0, 6]) + aux;
                                            equipos[0, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[0, 7]) + aux;
                                            equipos[0, 7] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(textBox2.Text);

                                            if (aux > aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                                                equipos[1, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[1, 3]) + 1;
                                                equipos[1, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[0, 5]) + 1;
                                                equipos[0, 5] = Convert.ToString(aux);

                                            }
                                            else if (aux < aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                                                equipos[0, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[0, 3]) + 1;
                                                equipos[0, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[1, 5]) + 1;
                                                equipos[1, 5] = Convert.ToString(aux);

                                            }
                                            else
                                            {

                                                aux = 1;
                                                aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                                                equipos[1, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[1, 4]) + aux;
                                                equipos[1, 4] = Convert.ToString(aux2);

                                                aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                                                equipos[0, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[0, 4]) + aux;
                                                equipos[0, 4] = Convert.ToString(aux2);

                                            }
                                            partidos[1, 2] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                            partidos[0, 3] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;

                                            label5.Visible = true;
                                            label5.Text = "Descansa el equipo: " + equipos[4, 1];
                                            textBox1.Enabled = false;
                                            textBox2.Enabled = false;
                                            label2.Text = "";
                                            label3.Text = "";
                                            textBox1.Text = "";
                                            textBox2.Text = "";
                                        }
                                        break;
                                    case 2:
                                        {
                                            textBox1.Enabled = true;
                                            textBox2.Enabled = true;
                                            label5.Visible = false;
                                            label2.Text = equipos[3, 1];
                                            label3.Text = equipos[0, 1];

                                        }
                                        break;
                                    case 3:
                                        {
                                            //goles a favor;
                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[3, 6]) + aux;
                                            equipos[3, 6] = Convert.ToString(aux2);

                                            //goles en contra;
                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[3, 7]) + aux;
                                            equipos[3, 7] = Convert.ToString(aux2);


                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[0, 6]) + aux;
                                            equipos[0, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[0, 7]) + aux;
                                            equipos[0, 7] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(textBox2.Text);

                                            if (aux > aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[3, 9]) + aux;
                                                equipos[3, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[3, 3]) + 1;
                                                equipos[3, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[0, 5]) + 1;
                                                equipos[0, 5] = Convert.ToString(aux);

                                            }
                                            else if (aux < aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                                                equipos[0, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[0, 3]) + 1;
                                                equipos[0, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[3, 5]) + 1;
                                                equipos[3, 5] = Convert.ToString(aux);

                                            }
                                            else
                                            {

                                                aux = 1;
                                                aux2 = Convert.ToInt32(equipos[3, 9]) + aux;
                                                equipos[3, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[3, 4]) + aux;
                                                equipos[3  , 4] = Convert.ToString(aux2);

                                                aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                                                equipos[0, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[0, 4]) + aux;
                                                equipos[0, 4] = Convert.ToString(aux2);

                                            }
                                            partidos[3, 3] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                            partidos[0, 4] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;

                                            textBox1.Text = "";
                                            textBox2.Text = "";
                                            textBox1.Enabled = true;
                                            textBox2.Enabled = true;
                                            label5.Visible = false;
                                            label2.Text = equipos[2, 1];
                                            label3.Text = equipos[1, 1];

                                        }
                                        break;

                                }
                                break;
                        }
                        break;
                    }
                case 6:
                    {
                        label5.Visible = true;

                        switch (i)//fechas
                        {
                            case 0:
                                switch (j)//partidos
                                {
                                    case 1:
                                        {
                                            label2.Text = equipos[0, 1];
                                            label3.Text = equipos[1, 1];
                                        }
                                        break;
                                    case 2:
                                        {
                                            label2.Text = equipos[0, 1];
                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[0, 6]) + aux;
                                            equipos[0, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[0, 7]) + aux;
                                            equipos[0, 7] = Convert.ToString(aux2);


                                            label3.Text = equipos[1, 1];
                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[1, 6]) + aux;
                                            equipos[1, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[1, 7]) + aux;
                                            equipos[1, 7] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(textBox2.Text);

                                            if (aux > aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                                                equipos[0, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[0, 3]) + 1;
                                                equipos[0, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[1, 5]) + 1;
                                                equipos[1, 5] = Convert.ToString(aux);

                                            }
                                            else if (aux < aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                                                equipos[1, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[1, 3]) + 1;
                                                equipos[1, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[0, 5]) + 1;
                                                equipos[0, 5] = Convert.ToString(aux);

                                            }
                                            else
                                            {

                                                aux = 1;
                                                aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                                                equipos[1, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[1, 4]) + aux;
                                                equipos[1, 4] = Convert.ToString(aux2);

                                                aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                                                equipos[0, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[0, 4]) + aux;
                                                equipos[0, 4] = Convert.ToString(aux2);

                                            }

                                            aux = Convert.ToInt32(equipos[0, 6]) - Convert.ToInt32(equipos[0, 7]);
                                            equipos[0, 8] = Convert.ToString(aux);
                                            aux = Convert.ToInt32(equipos[1, 6]) - Convert.ToInt32(equipos[1, 7]);
                                            equipos[1, 8] = Convert.ToString(aux);

                                            partidos[0, 0] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                            partidos[1, 0] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;

                                            textBox1.Text = "";
                                            textBox2.Text = "";

                                            label2.Text = equipos[5, 1];
                                            label3.Text = equipos[2, 1];
                                        }
                                        break;
                                    case 3:
                                        {
                                            label2.Text = equipos[5, 1];
                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[5, 6]) + aux;
                                            equipos[5, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[5, 7]) + aux;
                                            equipos[5, 7] = Convert.ToString(aux2);


                                            label3.Text = equipos[2, 1];
                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[2, 6]) + aux;
                                            equipos[2, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[2, 7]) + aux;
                                            equipos[2, 7] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(textBox2.Text);

                                            if (aux > aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[5, 9]) + aux;
                                                equipos[5, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[5, 3]) + 1;
                                                equipos[5, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[2, 5]) + 1;
                                                equipos[2, 5] = Convert.ToString(aux);

                                            }
                                            else if (aux < aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[2, 9]) + aux;
                                                equipos[2, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[2, 3]) + 1;
                                                equipos[2, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[5, 5]) + 1;
                                                equipos[5, 5] = Convert.ToString(aux);

                                            }
                                            else
                                            {

                                                aux = 1;
                                                aux2 = Convert.ToInt32(equipos[2, 9]) + aux;
                                                equipos[2, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[2, 4]) + aux;
                                                equipos[2, 4] = Convert.ToString(aux2);

                                                aux2 = Convert.ToInt32(equipos[5, 9]) + aux;
                                                equipos[5, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[5, 4]) + aux;
                                                equipos[5, 4] = Convert.ToString(aux2);

                                            }
                                            partidos[2, 0] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                            partidos[5, 0] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;

                                            aux = Convert.ToInt32(equipos[5, 6]) - Convert.ToInt32(equipos[5, 7]);
                                            equipos[5, 8] = Convert.ToString(aux);
                                            aux = Convert.ToInt32(equipos[2, 6]) - Convert.ToInt32(equipos[2, 7]);
                                            equipos[2, 8] = Convert.ToString(aux);

                                            textBox1.Text = "";
                                            textBox2.Text = "";

                                            label2.Text = equipos[4, 1];
                                            label3.Text = equipos[3, 1];
                                        }
                                        break;

                                }
                                break;
                            case 1:
                                switch (j)//partidos
                                {
                                    case 1:
                                        {
                                            label2.Text = equipos[4, 1];
                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[4, 6]) + aux;
                                            equipos[4, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[4, 7]) + aux;
                                            equipos[4, 7] = Convert.ToString(aux2);


                                            label3.Text = equipos[3, 1];
                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[3, 6]) + aux;
                                            equipos[3, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[3, 7]) + aux;
                                            equipos[3, 7] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(textBox2.Text);

                                            if (aux > aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[4, 9]) + aux;
                                                equipos[4, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[4, 3]) + 1;
                                                equipos[4, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[3, 5]) + 1;
                                                equipos[3, 5] = Convert.ToString(aux);

                                            }
                                            else if (aux < aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[3, 9]) + aux;
                                                equipos[3, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[3, 3]) + 1;
                                                equipos[3, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[4, 5]) + 1;
                                                equipos[4, 5] = Convert.ToString(aux);

                                            }
                                            else
                                            {

                                                aux = 1;
                                                aux2 = Convert.ToInt32(equipos[3, 9]) + aux;
                                                equipos[3, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[3, 4]) + aux;
                                                equipos[3, 4] = Convert.ToString(aux2);

                                                aux2 = Convert.ToInt32(equipos[4, 9]) + aux;
                                                equipos[4, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[4, 4]) + aux;
                                                equipos[4, 4] = Convert.ToString(aux2);

                                            }

                                            aux = Convert.ToInt32(equipos[4, 6]) - Convert.ToInt32(equipos[4, 7]);
                                            equipos[4, 8] = Convert.ToString(aux);
                                            aux = Convert.ToInt32(equipos[3, 6]) - Convert.ToInt32(equipos[3, 7]);
                                            equipos[3, 8] = Convert.ToString(aux);

                                            partidos[3, 0] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                            partidos[4, 0] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;

                                            textBox1.Text = "";
                                            textBox2.Text = "";

                                            label2.Text = equipos[0, 1];
                                            label3.Text = equipos[2, 1];
                                            
                                        }
                                        break;
                                    case 2:
                                        {
                                            label2.Text = equipos[0, 1];
                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[0, 6]) + aux;
                                            equipos[0, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[0, 7]) + aux;
                                            equipos[0, 7] = Convert.ToString(aux2);


                                            label3.Text = equipos[2, 1];
                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[2, 6]) + aux;
                                            equipos[2, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[2, 7]) + aux;
                                            equipos[2, 7] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(textBox2.Text);

                                            if (aux > aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                                                equipos[0, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[0, 3]) + 1;
                                                equipos[0, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[2, 5]) + 1;
                                                equipos[2, 5] = Convert.ToString(aux);

                                            }
                                            else if (aux < aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[2, 9]) + aux;
                                                equipos[2, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[2, 3]) + 1;
                                                equipos[2, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[0, 5]) + 1;
                                                equipos[0, 5] = Convert.ToString(aux);

                                            }
                                            else
                                            {

                                                aux = 1;
                                                aux2 = Convert.ToInt32(equipos[2, 9]) + aux;
                                                equipos[2, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[2, 4]) + aux;
                                                equipos[2, 4] = Convert.ToString(aux2);

                                                aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                                                equipos[0, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[0, 4]) + aux;
                                                equipos[0, 4] = Convert.ToString(aux2);

                                            }

                                            aux = Convert.ToInt32(equipos[0, 6]) - Convert.ToInt32(equipos[0, 7]);
                                            equipos[0, 8] = Convert.ToString(aux);
                                            aux = Convert.ToInt32(equipos[2, 6]) - Convert.ToInt32(equipos[2, 7]);
                                            equipos[2, 8] = Convert.ToString(aux);

                                            partidos[2, 1] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                            partidos[0, 1] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;

                                            textBox1.Text = "";
                                            textBox2.Text = "";

                                            label2.Text = equipos[1, 1];
                                            label3.Text = equipos[3, 1];
                                        }
                                        break;
                                    case 3:
                                        {
                                            label2.Text = equipos[1, 1];
                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[1, 6]) + aux;
                                            equipos[1, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[1, 7]) + aux;
                                            equipos[1, 7] = Convert.ToString(aux2);


                                            label3.Text = equipos[3, 1];
                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[3, 6]) + aux;
                                            equipos[3, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[3, 7]) + aux;
                                            equipos[3, 7] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(textBox2.Text);

                                            if (aux > aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                                                equipos[1, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[1, 3]) + 1;
                                                equipos[1, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[3, 5]) + 1;
                                                equipos[3, 5] = Convert.ToString(aux);

                                            }
                                            else if (aux < aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[3, 9]) + aux;
                                                equipos[3, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[3, 3]) + 1;
                                                equipos[3, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[1, 5]) + 1;
                                                equipos[1, 5] = Convert.ToString(aux);

                                            }
                                            else
                                            {

                                                aux = 1;
                                                aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                                                equipos[1, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[1, 4]) + aux;
                                                equipos[1, 4] = Convert.ToString(aux2);

                                                aux2 = Convert.ToInt32(equipos[3, 9]) + aux;
                                                equipos[3, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[3, 4]) + aux;
                                                equipos[3, 4] = Convert.ToString(aux2);

                                            }

                                            aux = Convert.ToInt32(equipos[3, 6]) - Convert.ToInt32(equipos[3, 7]);
                                            equipos[3, 8] = Convert.ToString(aux);
                                            aux = Convert.ToInt32(equipos[1, 6]) - Convert.ToInt32(equipos[1, 7]);
                                            equipos[1, 8] = Convert.ToString(aux);

                                            partidos[1, 1] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                            partidos[3, 1] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;

                                            textBox1.Text = "";
                                            textBox2.Text = "";

                                            label2.Text = equipos[5, 1];
                                            label3.Text = equipos[4, 1];
                                        }
                                        break;
                                }
                                break;
                            case 2:
                                switch (j)//partidos
                                {
                                    case 1:
                                        {
                                            label2.Text = equipos[5, 1];
                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[5, 6]) + aux;
                                            equipos[5, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[5, 7]) + aux;
                                            equipos[5, 7] = Convert.ToString(aux2);


                                            label3.Text = equipos[4, 1];
                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[4, 6]) + aux;
                                            equipos[4, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[4, 7]) + aux;
                                            equipos[4, 7] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(textBox2.Text);

                                            if (aux > aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[5, 9]) + aux;
                                                equipos[5, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[5, 3]) + 1;
                                                equipos[5, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[4, 5]) + 1;
                                                equipos[4, 5] = Convert.ToString(aux);

                                            }
                                            else if (aux < aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[4, 9]) + aux;
                                                equipos[4, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[4, 3]) + 1;
                                                equipos[4, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[5, 5]) + 1;
                                                equipos[5, 5] = Convert.ToString(aux);

                                            }
                                            else
                                            {

                                                aux = 1;
                                                aux2 = Convert.ToInt32(equipos[4, 9]) + aux;
                                                equipos[4, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[4, 4]) + aux;
                                                equipos[4, 4] = Convert.ToString(aux2);

                                                aux2 = Convert.ToInt32(equipos[5, 9]) + aux;
                                                equipos[5, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[5, 4]) + aux;
                                                equipos[5, 4] = Convert.ToString(aux2);

                                            }

                                            aux = Convert.ToInt32(equipos[5, 6]) - Convert.ToInt32(equipos[5, 7]);
                                            equipos[5, 8] = Convert.ToString(aux);
                                            aux = Convert.ToInt32(equipos[4, 6]) - Convert.ToInt32(equipos[4, 7]);
                                            equipos[4, 8] = Convert.ToString(aux);

                                            partidos[4, 1] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                            partidos[5, 1] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;

                                            textBox1.Text = "";
                                            textBox2.Text = "";

                                            label2.Text = equipos[0, 1];
                                            label3.Text = equipos[3, 1];
                                        }
                                        break;
                                    case 2:
                                        {
                                            label2.Text = equipos[0, 1];
                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[0, 6]) + aux;
                                            equipos[0, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[0, 7]) + aux;
                                            equipos[0, 7] = Convert.ToString(aux2);


                                            label3.Text = equipos[3, 1];
                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[3, 6]) + aux;
                                            equipos[3, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[3, 7]) + aux;
                                            equipos[3, 7] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(textBox2.Text);

                                            if (aux > aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                                                equipos[0, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[0, 3]) + 1;
                                                equipos[0, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[3, 5]) + 1;
                                                equipos[3, 5] = Convert.ToString(aux);

                                            }
                                            else if (aux < aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[3, 9]) + aux;
                                                equipos[3, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[3, 3]) + 1;
                                                equipos[3, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[0, 5]) + 1;
                                                equipos[0, 5] = Convert.ToString(aux);

                                            }
                                            else
                                            {

                                                aux = 1;
                                                aux2 = Convert.ToInt32(equipos[3, 9]) + aux;
                                                equipos[3, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[3, 4]) + aux;
                                                equipos[3, 4] = Convert.ToString(aux2);

                                                aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                                                equipos[0, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[0, 4]) + aux;
                                                equipos[0, 4] = Convert.ToString(aux2);

                                            }

                                            aux = Convert.ToInt32(equipos[0, 6]) - Convert.ToInt32(equipos[0, 7]);
                                            equipos[0, 8] = Convert.ToString(aux);
                                            aux = Convert.ToInt32(equipos[3, 6]) - Convert.ToInt32(equipos[3, 7]);
                                            equipos[3, 8] = Convert.ToString(aux);

                                            partidos[0, 2] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                            partidos[3, 2] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;

                                            textBox1.Text = "";
                                            textBox2.Text = "";

                                            label2.Text = equipos[2, 1];
                                            label3.Text = equipos[4, 1];
                                        }
                                        break;
                                    case 3:
                                        {
                                            label2.Text = equipos[2, 1];
                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[2, 6]) + aux;
                                            equipos[2, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[4, 7]) + aux;
                                            equipos[4, 7] = Convert.ToString(aux2);


                                            label3.Text = equipos[4, 1];
                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[4, 6]) + aux;
                                            equipos[4, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[2, 7]) + aux;
                                            equipos[2, 7] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(textBox2.Text);

                                            if (aux > aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[2, 9]) + aux;
                                                equipos[2, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[2, 3]) + 1;
                                                equipos[2, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[4, 5]) + 1;
                                                equipos[4, 5] = Convert.ToString(aux);

                                            }
                                            else if (aux < aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[4, 9]) + aux;
                                                equipos[4, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[4, 3]) + 1;
                                                equipos[4, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[2, 5]) + 1;
                                                equipos[2, 5] = Convert.ToString(aux);

                                            }
                                            else
                                            {

                                                aux = 1;
                                                aux2 = Convert.ToInt32(equipos[4, 9]) + aux;
                                                equipos[4, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[4, 4]) + aux;
                                                equipos[4, 4] = Convert.ToString(aux2);

                                                aux2 = Convert.ToInt32(equipos[2, 9]) + aux;
                                                equipos[2, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[2, 4]) + aux;
                                                equipos[2, 4] = Convert.ToString(aux2);

                                            }

                                            aux = Convert.ToInt32(equipos[2, 6]) - Convert.ToInt32(equipos[2, 7]);
                                            equipos[2, 8] = Convert.ToString(aux);
                                            aux = Convert.ToInt32(equipos[4, 6]) - Convert.ToInt32(equipos[4, 7]);
                                            equipos[4, 8] = Convert.ToString(aux);

                                            partidos[4, 2] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                            partidos[2, 2] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;

                                            textBox1.Text = "";
                                            textBox2.Text = "";

                                            label2.Text = equipos[1, 1];
                                            label3.Text = equipos[5, 1];
                                        }
                                        break;
                                }
                                break;
                            case 3:
                                switch (j)//partidos
                                {
                                    case 1:
                                        {
                                            label2.Text = equipos[1, 1];
                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[1, 6]) + aux;
                                            equipos[1, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[1, 7]) + aux;
                                            equipos[1, 7] = Convert.ToString(aux2);


                                            label3.Text = equipos[5, 1];
                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[5, 6]) + aux;
                                            equipos[5, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[5, 7]) + aux;
                                            equipos[5, 7] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(textBox2.Text);

                                            if (aux > aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                                                equipos[1, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[1, 3]) + 1;
                                                equipos[1, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[5, 5]) + 1;
                                                equipos[5, 5] = Convert.ToString(aux);

                                            }
                                            else if (aux < aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[5, 9]) + aux;
                                                equipos[5, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[5, 3]) + 1;
                                                equipos[5, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[1, 5]) + 1;
                                                equipos[1, 5] = Convert.ToString(aux);

                                            }
                                            else
                                            {

                                                aux = 1;
                                                aux2 = Convert.ToInt32(equipos[5, 9]) + aux;
                                                equipos[5, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[5, 4]) + aux;
                                                equipos[5, 4] = Convert.ToString(aux2);

                                                aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                                                equipos[1, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[1, 4]) + aux;
                                                equipos[1, 4] = Convert.ToString(aux2);

                                            }

                                            aux = Convert.ToInt32(equipos[1, 6]) - Convert.ToInt32(equipos[1, 7]);
                                            equipos[1, 8] = Convert.ToString(aux);
                                            aux = Convert.ToInt32(equipos[5, 6]) - Convert.ToInt32(equipos[5, 7]);
                                            equipos[5, 8] = Convert.ToString(aux);

                                            partidos[5, 2] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                            partidos[1, 2] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;

                                            textBox1.Text = "";
                                            textBox2.Text = "";

                                            label2.Text = equipos[0, 1];
                                            label3.Text = equipos[4, 1];
                                        }
                                        break;
                                    case 2:
                                        {
                                            label2.Text = equipos[0, 1];
                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[0, 6]) + aux;
                                            equipos[0, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[0, 7]) + aux;
                                            equipos[0, 7] = Convert.ToString(aux2);


                                            label3.Text = equipos[4, 1];
                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[4, 6]) + aux;
                                            equipos[4, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[4, 7]) + aux;
                                            equipos[4, 7] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(textBox2.Text);

                                            if (aux > aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                                                equipos[0, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[0, 3]) + 1;
                                                equipos[0, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[4, 5]) + 1;
                                                equipos[4, 5] = Convert.ToString(aux);

                                            }
                                            else if (aux < aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[4, 9]) + aux;
                                                equipos[4, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[4, 3]) + 1;
                                                equipos[4, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[0, 5]) + 1;
                                                equipos[0, 5] = Convert.ToString(aux);

                                            }
                                            else
                                            {

                                                aux = 1;
                                                aux2 = Convert.ToInt32(equipos[4, 9]) + aux;
                                                equipos[4, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[4, 4]) + aux;
                                                equipos[4, 4] = Convert.ToString(aux2);

                                                aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                                                equipos[0, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[0, 4]) + aux;
                                                equipos[0, 4] = Convert.ToString(aux2);

                                            }

                                            aux = Convert.ToInt32(equipos[0, 6]) - Convert.ToInt32(equipos[0, 7]);
                                            equipos[0, 8] = Convert.ToString(aux);
                                            aux = Convert.ToInt32(equipos[4, 6]) - Convert.ToInt32(equipos[4, 7]);
                                            equipos[4, 8] = Convert.ToString(aux);

                                            partidos[4, 3] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                            partidos[0, 3] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;

                                            textBox1.Text = "";
                                            textBox2.Text = "";

                                            label2.Text = equipos[3, 1];
                                            label3.Text = equipos[5, 1];
                                        }
                                        break;
                                    case 3:
                                        {
                                            label2.Text = equipos[3, 1];
                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[3, 6]) + aux;
                                            equipos[3, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[3, 7]) + aux;
                                            equipos[3, 7] = Convert.ToString(aux2);


                                            label3.Text = equipos[5, 1];
                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[5, 6]) + aux;
                                            equipos[5, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[5, 7]) + aux;
                                            equipos[5, 7] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(textBox2.Text);

                                            if (aux > aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[3, 9]) + aux;
                                                equipos[3, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[3, 3]) + 1;
                                                equipos[3, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[5, 5]) + 1;
                                                equipos[5, 5] = Convert.ToString(aux);

                                            }
                                            else if (aux < aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[5, 9]) + aux;
                                                equipos[5, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[5, 3]) + 1;
                                                equipos[5, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[3, 5]) + 1;
                                                equipos[3, 5] = Convert.ToString(aux);

                                            }
                                            else
                                            {

                                                aux = 1;
                                                aux2 = Convert.ToInt32(equipos[5, 9]) + aux;
                                                equipos[5, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[5, 4]) + aux;
                                                equipos[5, 4] = Convert.ToString(aux2);

                                                aux2 = Convert.ToInt32(equipos[3, 9]) + aux;
                                                equipos[3, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[3, 4]) + aux;
                                                equipos[3, 4] = Convert.ToString(aux2);

                                            }

                                            aux = Convert.ToInt32(equipos[3, 6]) - Convert.ToInt32(equipos[3, 7]);
                                            equipos[3, 8] = Convert.ToString(aux);
                                            aux = Convert.ToInt32(equipos[5, 6]) - Convert.ToInt32(equipos[5, 7]);
                                            equipos[5, 8] = Convert.ToString(aux);

                                            partidos[5, 3] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                            partidos[3, 3] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;

                                            textBox1.Text = "";
                                            textBox2.Text = "";

                                            label2.Text = equipos[2, 1];
                                            label3.Text = equipos[1, 1];
                                        }
                                        break;

                                }
                                break;
                            case 4:
                                switch (j)//partidos
                                {
                                    case 1:
                                        {
                                            label2.Text = equipos[2, 1];
                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[2, 6]) + aux;
                                            equipos[2, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[2, 7]) + aux;
                                            equipos[2, 7] = Convert.ToString(aux2);


                                            label3.Text = equipos[1, 1];
                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[1, 6]) + aux;
                                            equipos[1, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[1, 7]) + aux;
                                            equipos[1, 7] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(textBox2.Text);

                                            if (aux > aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[2, 9]) + aux;
                                                equipos[2, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[2, 3]) + 1;
                                                equipos[2, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[1, 5]) + 1;
                                                equipos[1, 5] = Convert.ToString(aux);

                                            }
                                            else if (aux < aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                                                equipos[1, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[1, 3]) + 1;
                                                equipos[1, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[2, 5]) + 1;
                                                equipos[2, 5] = Convert.ToString(aux);

                                            }
                                            else
                                            {

                                                aux = 1;
                                                aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                                                equipos[1, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[1, 4]) + aux;
                                                equipos[1, 4] = Convert.ToString(aux2);

                                                aux2 = Convert.ToInt32(equipos[2, 9]) + aux;
                                                equipos[2, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[2, 4]) + aux;
                                                equipos[2, 4] = Convert.ToString(aux2);

                                            }

                                            aux = Convert.ToInt32(equipos[2, 6]) - Convert.ToInt32(equipos[2, 7]);
                                            equipos[2, 8] = Convert.ToString(aux);
                                            aux = Convert.ToInt32(equipos[1, 6]) - Convert.ToInt32(equipos[1, 7]);
                                            equipos[1, 8] = Convert.ToString(aux);

                                            partidos[1, 3] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                            partidos[2, 3] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;

                                            textBox1.Text = "";
                                            textBox2.Text = "";

                                            label2.Text = equipos[0, 1];
                                            label3.Text = equipos[5, 1];
                                        }
                                        break;
                                    case 2:
                                        {
                                            label2.Text = equipos[0, 1];
                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[0, 6]) + aux;
                                            equipos[0, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[0, 7]) + aux;
                                            equipos[0, 7] = Convert.ToString(aux2);


                                            label3.Text = equipos[5, 1];
                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[5, 6]) + aux;
                                            equipos[5, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[5, 7]) + aux;
                                            equipos[5, 7] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(textBox2.Text);

                                            if (aux > aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                                                equipos[0, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[0, 3]) + 1;
                                                equipos[0, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[5, 5]) + 1;
                                                equipos[5, 5] = Convert.ToString(aux);

                                            }
                                            else if (aux < aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[5, 9]) + aux;
                                                equipos[5, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[5, 3]) + 1;
                                                equipos[5, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[0, 5]) + 1;
                                                equipos[0, 5] = Convert.ToString(aux);

                                            }
                                            else
                                            {

                                                aux = 1;
                                                aux2 = Convert.ToInt32(equipos[5, 9]) + aux;
                                                equipos[5, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[5, 4]) + aux;
                                                equipos[5, 4] = Convert.ToString(aux2);

                                                aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                                                equipos[0, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[0, 4]) + aux;
                                                equipos[0, 4] = Convert.ToString(aux2);

                                            }

                                            aux = Convert.ToInt32(equipos[0, 6]) - Convert.ToInt32(equipos[0, 7]);
                                            equipos[0, 8] = Convert.ToString(aux);
                                            aux = Convert.ToInt32(equipos[5, 6]) - Convert.ToInt32(equipos[5, 7]);
                                            equipos[5, 8] = Convert.ToString(aux);

                                            partidos[5, 4] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                            partidos[0, 4] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;

                                            textBox1.Text = "";
                                            textBox2.Text = "";

                                            label2.Text = equipos[4, 1];
                                            label3.Text = equipos[1, 1];
                                        }
                                        break;
                                    case 3:
                                        {
                                            label2.Text = equipos[4, 1];
                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[4, 6]) + aux;
                                            equipos[4, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[4, 7]) + aux;
                                            equipos[4, 7] = Convert.ToString(aux2);


                                            label3.Text = equipos[1, 1];
                                            aux = Convert.ToInt32(textBox2.Text);
                                            aux2 = Convert.ToInt32(equipos[1, 6]) + aux;
                                            equipos[1, 6] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(equipos[1, 7]) + aux;
                                            equipos[1, 7] = Convert.ToString(aux2);

                                            aux = Convert.ToInt32(textBox1.Text);
                                            aux2 = Convert.ToInt32(textBox2.Text);

                                            if (aux > aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[4, 9]) + aux;
                                                equipos[4, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[4, 3]) + 1;
                                                equipos[4, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[1, 5]) + 1;
                                                equipos[1, 5] = Convert.ToString(aux);

                                            }
                                            else if (aux < aux2)
                                            {
                                                aux = 3;
                                                aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                                                equipos[1, 9] = Convert.ToString(aux2);
                                                aux = Convert.ToInt32(equipos[1, 3]) + 1;
                                                equipos[1, 3] = Convert.ToString(aux);

                                                aux = Convert.ToInt32(equipos[4, 5]) + 1;
                                                equipos[4, 5] = Convert.ToString(aux);

                                            }
                                            else
                                            {

                                                aux = 1;
                                                aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                                                equipos[1, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[1, 4]) + aux;
                                                equipos[1, 4] = Convert.ToString(aux2);

                                                aux2 = Convert.ToInt32(equipos[4, 9]) + aux;
                                                equipos[4, 9] = Convert.ToString(aux2);
                                                aux2 = Convert.ToInt32(equipos[4, 4]) + aux;
                                                equipos[4, 4] = Convert.ToString(aux2);

                                            }

                                            aux = Convert.ToInt32(equipos[4, 6]) - Convert.ToInt32(equipos[4, 7]);
                                            equipos[4, 8] = Convert.ToString(aux);
                                            aux = Convert.ToInt32(equipos[1, 6]) - Convert.ToInt32(equipos[1, 7]);
                                            equipos[1, 8] = Convert.ToString(aux);

                                            partidos[1, 4] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                                            partidos[4, 4] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;

                                            textBox1.Text = "";
                                            textBox2.Text = "";

                                            label2.Text = equipos[3, 1];
                                            label3.Text = equipos[2, 1];
                                        }
                                        break;

                                }
                                break;
                        }
                        break;
                    }
            }

            if (i == fechas)
            {
                switch (cantidadEquipos)
                {
                    case 3:
                        {
                            //---------------------------------//
                            //goles a favor;
                            aux = Convert.ToInt32(textBox1.Text);
                            aux2 = Convert.ToInt32(equipos[0, 6]) + aux;
                            equipos[0, 6] = Convert.ToString(aux2);

                            //goles en contra;
                            aux = Convert.ToInt32(textBox2.Text);
                            aux2 = Convert.ToInt32(equipos[0, 7]) + aux;
                            equipos[0, 7] = Convert.ToString(aux2);

                            aux = Convert.ToInt32(textBox2.Text);
                            aux2 = Convert.ToInt32(equipos[1, 6]) + aux;
                            equipos[1, 6] = Convert.ToString(aux2);

                            aux = Convert.ToInt32(textBox1.Text);
                            aux2 = Convert.ToInt32(equipos[1, 7]) + aux;
                            equipos[1, 7] = Convert.ToString(aux2);

                            aux = Convert.ToInt32(textBox1.Text);
                            aux2 = Convert.ToInt32(textBox2.Text);

                            if (aux > aux2)
                            {
                                aux = 3;
                                aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                                equipos[0, 9] = Convert.ToString(aux2);
                                aux = Convert.ToInt32(equipos[0, 3]) + 1;
                                equipos[0, 3] = Convert.ToString(aux);

                                aux = Convert.ToInt32(equipos[1, 5]) + 1;
                                equipos[1, 5] = Convert.ToString(aux);

                            }
                            else if (aux < aux2)
                            {
                                aux = 3;
                                aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                                equipos[1, 9] = Convert.ToString(aux2);
                                aux = Convert.ToInt32(equipos[1, 3]) + 1;
                                equipos[1, 3] = Convert.ToString(aux);

                                aux = Convert.ToInt32(equipos[0, 5]) + 1;
                                equipos[0, 5] = Convert.ToString(aux);

                            }
                            else
                            {

                                aux = 1;
                                aux2 = Convert.ToInt32(equipos[0, 9]) + aux;
                                equipos[0, 9] = Convert.ToString(aux2);
                                aux2 = Convert.ToInt32(equipos[0, 4]) + aux;
                                equipos[0, 4] = Convert.ToString(aux2);

                                aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                                equipos[1, 9] = Convert.ToString(aux2);
                                aux2 = Convert.ToInt32(equipos[1, 4]) + aux;
                                equipos[1, 4] = Convert.ToString(aux2);

                            }
                            partidos[0, 1] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                            partidos[1, 1] = label3.Text + " " + textBox2.Text + "-" + textBox1.Text + " " + label2.Text;

                            textBox1.Text = "";
                            textBox2.Text = "";

                            aux = Convert.ToInt32(equipos[0, 6]) - Convert.ToInt32(equipos[0, 7]);
                            equipos[0, 8] = Convert.ToString(aux);
                            aux = Convert.ToInt32(equipos[1, 6]) - Convert.ToInt32(equipos[1, 7]);
                            equipos[1, 8] = Convert.ToString(aux);
                        }
                        break;
                    case 4:
                        {
                            //goles a favor;
                            aux = Convert.ToInt32(textBox1.Text);
                            aux2 = Convert.ToInt32(equipos[2, 6]) + aux;
                            equipos[2, 6] = Convert.ToString(aux2);

                            //goles en contra;
                            aux = Convert.ToInt32(textBox2.Text);
                            aux2 = Convert.ToInt32(equipos[2, 7]) + aux;
                            equipos[2, 7] = Convert.ToString(aux2);


                            aux = Convert.ToInt32(textBox2.Text);
                            aux2 = Convert.ToInt32(equipos[1, 6]) + aux;
                            equipos[1, 6] = Convert.ToString(aux2);

                            aux = Convert.ToInt32(textBox1.Text);
                            aux2 = Convert.ToInt32(equipos[1, 7]) + aux;
                            equipos[1, 7] = Convert.ToString(aux2);

                            aux = Convert.ToInt32(textBox1.Text);
                            aux2 = Convert.ToInt32(textBox2.Text);

                            if (aux > aux2)
                            {
                                aux = 3;
                                aux2 = Convert.ToInt32(equipos[2, 9]) + aux;
                                equipos[2, 9] = Convert.ToString(aux2);
                                aux = Convert.ToInt32(equipos[2, 3]) + 1;
                                equipos[2, 3] = Convert.ToString(aux);

                                aux = Convert.ToInt32(equipos[1, 5]) + 1;
                                equipos[1, 5] = Convert.ToString(aux);

                            }
                            else if (aux < aux2)
                            {
                                aux = 3;
                                aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                                equipos[1, 9] = Convert.ToString(aux2);
                                aux = Convert.ToInt32(equipos[1, 3]) + 1;
                                equipos[1, 3] = Convert.ToString(aux);

                                aux = Convert.ToInt32(equipos[2, 5]) + 1;
                                equipos[2, 5] = Convert.ToString(aux);

                            }
                            else
                            {

                                aux = 1;
                                aux2 = Convert.ToInt32(equipos[2, 9]) + aux;
                                equipos[2, 9] = Convert.ToString(aux2);
                                aux2 = Convert.ToInt32(equipos[2, 4]) + aux;
                                equipos[2, 4] = Convert.ToString(aux2);

                                aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                                equipos[1, 9] = Convert.ToString(aux2);
                                aux2 = Convert.ToInt32(equipos[1, 4]) + aux;
                                equipos[1, 4] = Convert.ToString(aux2);

                            }
                            aux = Convert.ToInt32(equipos[0, 6]) - Convert.ToInt32(equipos[0, 7]);
                            equipos[0, 8] = Convert.ToString(aux);
                            aux = Convert.ToInt32(equipos[1, 6]) - Convert.ToInt32(equipos[1, 7]);
                            equipos[1, 8] = Convert.ToString(aux);
                            aux = Convert.ToInt32(equipos[2, 6]) - Convert.ToInt32(equipos[2, 7]);
                            equipos[2, 8] = Convert.ToString(aux);
                            aux = Convert.ToInt32(equipos[3, 6]) - Convert.ToInt32(equipos[3, 7]);
                            equipos[3, 8] = Convert.ToString(aux);

                            partidos[2, 2] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                            partidos[1, 2] = label3.Text + " " + textBox2.Text + "-" + textBox1.Text + " " + label2.Text;

                            textBox1.Text = "";
                            textBox2.Text = "";
                        }
                        break;
                    case 5:
                        {
                            //goles a favor;
                            aux = Convert.ToInt32(textBox1.Text);
                            aux2 = Convert.ToInt32(equipos[2, 6]) + aux;
                            equipos[2, 6] = Convert.ToString(aux2);

                            //goles en contra;
                            aux = Convert.ToInt32(textBox2.Text);
                            aux2 = Convert.ToInt32(equipos[2, 7]) + aux;
                            equipos[2, 7] = Convert.ToString(aux2);


                            aux = Convert.ToInt32(textBox2.Text);
                            aux2 = Convert.ToInt32(equipos[1, 6]) + aux;
                            equipos[1, 6] = Convert.ToString(aux2);

                            aux = Convert.ToInt32(textBox1.Text);
                            aux2 = Convert.ToInt32(equipos[1, 7]) + aux;
                            equipos[1, 7] = Convert.ToString(aux2);

                            aux = Convert.ToInt32(textBox1.Text);
                            aux2 = Convert.ToInt32(textBox2.Text);

                            if (aux > aux2)
                            {
                                aux = 3;
                                aux2 = Convert.ToInt32(equipos[2, 9]) + aux;
                                equipos[2, 9] = Convert.ToString(aux2);
                                aux = Convert.ToInt32(equipos[2, 3]) + 1;
                                equipos[2, 3] = Convert.ToString(aux);

                                aux = Convert.ToInt32(equipos[1, 5]) + 1;
                                equipos[1, 5] = Convert.ToString(aux);

                            }
                            else if (aux < aux2)
                            {
                                aux = 3;
                                aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                                equipos[1, 9] = Convert.ToString(aux2);
                                aux = Convert.ToInt32(equipos[1, 3]) + 1;
                                equipos[1, 3] = Convert.ToString(aux);

                                aux = Convert.ToInt32(equipos[2, 5]) + 1;
                                equipos[2, 5] = Convert.ToString(aux);

                            }
                            else
                            {

                                aux = 1;
                                aux2 = Convert.ToInt32(equipos[2, 9]) + aux;
                                equipos[2, 9] = Convert.ToString(aux2);
                                aux2 = Convert.ToInt32(equipos[2, 4]) + aux;
                                equipos[2, 4] = Convert.ToString(aux2);

                                aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                                equipos[1, 9] = Convert.ToString(aux2);
                                aux2 = Convert.ToInt32(equipos[1, 4]) + aux;
                                equipos[1, 4] = Convert.ToString(aux2);
                            }
                            partidos[2, 3] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                            partidos[1, 4] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;

                            aux = Convert.ToInt32(equipos[0, 6]) - Convert.ToInt32(equipos[0, 7]);
                            equipos[0, 8] = Convert.ToString(aux);
                            aux = Convert.ToInt32(equipos[1, 6]) - Convert.ToInt32(equipos[1, 7]);
                            equipos[1, 8] = Convert.ToString(aux);
                            aux = Convert.ToInt32(equipos[2, 6]) - Convert.ToInt32(equipos[2, 7]);
                            equipos[2, 8] = Convert.ToString(aux);
                            aux = Convert.ToInt32(equipos[3, 6]) - Convert.ToInt32(equipos[3, 7]);
                            equipos[3, 8] = Convert.ToString(aux);
                            aux = Convert.ToInt32(equipos[4, 6]) - Convert.ToInt32(equipos[4, 7]);
                            equipos[4, 8] = Convert.ToString(aux);

                            textBox1.Text = "";
                            textBox2.Text = "";
                        }
                        break;
                    case 6:
                        label2.Text = equipos[2, 1];
                        aux = Convert.ToInt32(textBox1.Text);
                        aux2 = Convert.ToInt32(equipos[2, 6]) + aux;
                        equipos[2, 6] = Convert.ToString(aux2);

                        aux = Convert.ToInt32(textBox2.Text);
                        aux2 = Convert.ToInt32(equipos[2, 7]) + aux;
                        equipos[2, 7] = Convert.ToString(aux2);


                        label3.Text = equipos[1, 1];
                        aux = Convert.ToInt32(textBox2.Text);
                        aux2 = Convert.ToInt32(equipos[1, 6]) + aux;
                        equipos[1, 6] = Convert.ToString(aux2);

                        aux = Convert.ToInt32(textBox1.Text);
                        aux2 = Convert.ToInt32(equipos[1, 7]) + aux;
                        equipos[1, 7] = Convert.ToString(aux2);

                        aux = Convert.ToInt32(textBox1.Text);
                        aux2 = Convert.ToInt32(textBox2.Text);

                        if (aux > aux2)
                        {
                            aux = 3;
                            aux2 = Convert.ToInt32(equipos[2, 9]) + aux;
                            equipos[2, 9] = Convert.ToString(aux2);
                            aux = Convert.ToInt32(equipos[2, 3]) + 1;
                            equipos[2, 3] = Convert.ToString(aux);

                            aux = Convert.ToInt32(equipos[1, 5]) + 1;
                            equipos[1, 5] = Convert.ToString(aux);

                        }
                        else if (aux < aux2)
                        {
                            aux = 3;
                            aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                            equipos[1, 9] = Convert.ToString(aux2);
                            aux = Convert.ToInt32(equipos[1, 3]) + 1;
                            equipos[1, 3] = Convert.ToString(aux);

                            aux = Convert.ToInt32(equipos[2, 5]) + 1;
                            equipos[2, 5] = Convert.ToString(aux);

                        }
                        else
                        {

                            aux = 1;
                            aux2 = Convert.ToInt32(equipos[1, 9]) + aux;
                            equipos[1, 9] = Convert.ToString(aux2);
                            aux2 = Convert.ToInt32(equipos[1, 4]) + aux;
                            equipos[1, 4] = Convert.ToString(aux2);

                            aux2 = Convert.ToInt32(equipos[2, 9]) + aux;
                            equipos[2, 9] = Convert.ToString(aux2);
                            aux2 = Convert.ToInt32(equipos[2, 4]) + aux;
                            equipos[2, 4] = Convert.ToString(aux2);

                        }


                        aux = Convert.ToInt32(equipos[2, 6]) - Convert.ToInt32(equipos[2, 7]);
                        equipos[2, 8] = Convert.ToString(aux);
                        aux = Convert.ToInt32(equipos[1, 6]) - Convert.ToInt32(equipos[1, 7]);
                        equipos[1, 8] = Convert.ToString(aux);

                        partidos[2, 4] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;
                        partidos[1, 4] = label2.Text + " " + textBox1.Text + "-" + textBox2.Text + " " + label3.Text;

                        textBox1.Text = "";
                        textBox2.Text = "";

                        break;
                }
                label5.Text = "";
                label2.Text = "";
                label3.Text = "";
                label1.Text = "Fecha número: X";
                label4.Text = "Partido número: X";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = true;
                button2.Visible = true;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 formularioTres = new Form3(equipos,cantidadEquipos,partidos);
            formularioTres.Show();
            this.Close();
        }
    }
}
