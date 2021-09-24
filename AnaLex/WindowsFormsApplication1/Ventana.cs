using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Ventana : Form
    {
        public Ventana()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        public void ventanax(ArrayList array , int coinci, int tamano) {

            double coinci2 = Convert.ToDouble(coinci);
            double tamano2 = Convert.ToDouble(tamano);


            if ((label4.Text != "") || !(label4.Text.Equals("") || !(String.IsNullOrEmpty(label4.Text))))
            {
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";


                label4.Text = Convert.ToString(coinci);
                double porcentaje = Math.Round((coinci2 / tamano2) * 100, 2);
                label5.Text = Convert.ToString(porcentaje)+"%";
                if (porcentaje <= 20)
                {
                    label6.Text = "NO HAY PLAGIO";
                }
                else if ((porcentaje > 20) && (porcentaje <= 40))
                {
                    label6.Text = "PRECAUCION";
                }
                else if ((porcentaje > 40))
                {
                    label6.Text = "PLAGIO!";
                }




            }
            else {


                label4.Text = Convert.ToString(coinci);


                double porcentaje = Math.Round((coinci2 / tamano2) * 100, 2);
                label5.Text = Convert.ToString(porcentaje) + "%";
                if (porcentaje <= 20)
                {
                    label6.Text = "NO HAY PLAGIO";
                }
                else if ((porcentaje > 20) && (porcentaje <= 40))
                {
                    label6.Text = "PRECAUCION";
                }
                else if ((porcentaje > 40))
                {
                    label6.Text = "PLAGIO!";
                }
            
            
            }



            




            if ((textBox1.Text != null) || (textBox1.Text.Equals("")) || (String.IsNullOrEmpty(textBox1.Text)))
            {
                textBox1.Text = "Palabras Encontradas" + "\r\n";

                for (int i = 0; i < array.Count; i++)
                {
                    textBox1.Text += array[i] + "\r\n";
                }

            }
            else {

                textBox1.Text = "";


                textBox1.Text = "Palabras Encontradas" + "\r\n";

                for (int i = 0; i < array.Count; i++)
                {
                    textBox1.Text += array[i] + "\r\n";
                }
            
            }

            
            



        }

    }
}
