using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Coincidencias : Form
    {
        public Coincidencias()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // obtiene();
            int index = comboBox1.SelectedIndex;

            Console.WriteLine(index);
                Process.Start((String)Lectura.path[index]);
            

                

        }


        public void obtiene()
        {
            //Console.WriteLine("tama2"+Lectura.nombre.Count+"traeENTRO " + comboBox1.Items.Count);
            int tama = comboBox1.Items.Count;

            if (tama == 0)
            {
                for (int i = 0; i < Lectura.nombre.Count; i++)
                {
                    Console.WriteLine("trae " + Lectura.nombre[i]);
                    //Lectura.nombre[i];
                    comboBox1.Items.Add((String)Lectura.nombre[i]);
                }

            }
            else
            {
                
                comboBox1.Items.Clear();
                for (int i = 0; i < Lectura.nombre.Count; i++)
                {
                    Console.WriteLine("trae else " + Lectura.nombre[i]);
                    //Lectura.nombre[i];
                    comboBox1.Items.Add((String)Lectura.nombre[i]);
                }
            }
            
        
        }

        


    }
}
