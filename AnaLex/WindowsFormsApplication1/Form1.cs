using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Lectura gesti;
        static int contador = 1;
        static int contador2 = 1;
        public Form1()
        {
            InitializeComponent();
            gesti = new Lectura();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inicoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cosaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenFileDialog Response = new OpenFileDialog();
            //openFileDialog1.Filter = "Cursor Files|*.txt";
            //openFileDialog1.Title = "Select a Cursor File";


            
            

              gesti.abre();

              
              
              
              


              if (Lectura.selecciono == 1)
              {

                  if (contador == 1)
                  {

                      comboBox1.Items.Add("Ventana" + contador);
                      comboBox2.Items.Add("Ventana" + contador);
                  }
                  else
                  {

                      if (contador2 >= contador)
                      {




                      }
                      else
                      {

                          pesta();
                      }


                      
                      comboBox1.Items.Add("Ventana" + contador);
                      comboBox2.Items.Add("Ventana" + contador);
                  }



                  ingresaventana();
                  
                  Lectura.tempLINEA = new ArrayList();
                  Lectura.selecciono = 0;
              }
              else { 
              
              
              
              }
              
        
        }

        private void button1_Click(object sender, EventArgs e)
        {


            String line; 

           

            StreamReader sr = new StreamReader("C:\\Users\\KRUIZ9\\Desktop\\hola.txt");
                line = sr.ReadLine();
                Lectura ana1 = new Lectura();
                
                while (line != null)
                {
                   
                    Console.WriteLine(line);
                    Console.WriteLine(ana1.comentario1(line));


                    

                    if (ana1.comentario1(line))
                    {
                        
                        
                    }
                    else {

                        ana1.separacion(line);
                        
                    
                    }

                    line = sr.ReadLine();
                    //ana1.separacion(line);
                    



                }

                
                ana1.inter();
                ana1.comentario2(0,0);
                ana1.imprime();
                


                //close the file
                sr.Close();
                Console.ReadLine();
            
            




          





        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void asdbasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pesta();
            
        }

        private void analisisLexicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            int pri = comboBox1.SelectedIndex;
            int segu = comboBox2.SelectedIndex;

            Console.WriteLine(pri);
            Console.WriteLine(segu);



            






            if (((pri == -1)||(pri == 0)) && ((segu != 0) &&(segu != -1)))
            {
                MessageBox.Show("Seleccione 2 Archivos"); 
            }

            else if (((segu == 0) || (segu == -1)) && ((pri == -1) || (pri == 0)))
            {
                MessageBox.Show("Seleccione 2 Archivos");

            }
            else if (((segu == 0) || (segu == -1)) && ((pri != -1) || (pri != 0)))
            {
                MessageBox.Show("Seleccione 2 Archivos");

            }
            else
            {
                Console.WriteLine(pri+"adfa");
                Console.WriteLine(segu+"asdfas");
               

                ArrayList temp1 = lineaCOMBO(pri);

                if (temp1.Count == 0)
                {



                }
                else
                {
                    //try
                    //{
                        ArrayList sigui = gesti.leeyanaliza2(temp1);
                        Console.WriteLine(sigui[0] + "asdfas");
                        gesti.html(sigui);

                        ArrayList temp2 = lineaCOMBO(segu);
                        ArrayList sigui2 = gesti.leeyanaliza2(temp2);
                        Console.WriteLine(sigui2[0] + "asdfas");
                        gesti.html(sigui2);
                    //}catch(Exception ttt){
                    
                    //Console.WriteLine("ERROR EN LEXICO");
                    
                    //}

                }



            }
            //Lectura.temp = new ArrayList();
            
            

        }














        private void pesta() {

            contador2++;
            switch (contador2)
            {

                case 2:
                    this.tabControl1.Controls.Add(this.tabPage2);
                    break;
                case 3:
                    this.tabControl1.Controls.Add(this.tabPage4);
                    break;

                case 4:
                    this.tabControl1.Controls.Add(this.tabPage5);
                    break;
                case 5:
                    this.tabControl1.Controls.Add(this.tabPage6);
                    break;
                case 6:
                    this.tabControl1.Controls.Add(this.tabPage7);
                    break;
                case 7:
                    this.tabControl1.Controls.Add(this.tabPage8);
                    break;
                case 8:
                    this.tabControl1.Controls.Add(this.tabPage9);
                    break;
                case 9:
                    this.tabControl1.Controls.Add(this.tabPage10);
                    break;
                case 10:
                    this.tabControl1.Controls.Add(this.tabPage11);
                    break;
                case 11:
                    this.tabControl1.Controls.Add(this.tabPage12);
                    break;
                case 12:
                    this.tabControl1.Controls.Add(this.tabPage13);
                    break;
                case 13:
                    this.tabControl1.Controls.Add(this.tabPage14);
                    break;
                case 14:
                    this.tabControl1.Controls.Add(this.tabPage15);
                    break;
                case 15:
                    this.tabControl1.Controls.Add(this.tabPage18);
                    break;



                default:

                    break;













            }


            //contador2++;
        
        }

        private void ingresaventana() {

            






            Console.WriteLine(Lectura.tempLINEA.Count + "Tama;o a iongresar text ");
            switch (contador)
            {




                case 1:
                    //this.tabControl1.Controls.Add(this.tabPage1);
                    for (int i = 0; i < Lectura.tempLINEA.Count; i++)
                    {
                        Console.WriteLine("i "+i);
                        Primero.Text += Lectura.tempLINEA[i] + "\r\n";
                    }
                    //contador++;
                    break;
                case 2:

                    for (int i = 0; i < Lectura.tempLINEA.Count; i++)
                    {
                        textBox1.Text += Lectura.tempLINEA[i] + "\r\n";
                    }
                    //contador++;
                    break;
                case 3:
                    for (int i = 0; i < Lectura.tempLINEA.Count; i++)
                    {
                        textBox2.Text += Lectura.tempLINEA[i] + "\r\n";
                    }
                    break;
                case 4:
                    for (int i = 0; i < Lectura.tempLINEA.Count; i++)
                    {
                        textBox3.Text += Lectura.tempLINEA[i] + "\r\n";
                    }
                    break;
                case 5:
                    for (int i = 0; i < Lectura.tempLINEA.Count; i++)
                    {
                        textBox4.Text += Lectura.tempLINEA[i] + "\r\n";
                    }
                    break;
                case 6:
                    for (int i = 0; i < Lectura.tempLINEA.Count; i++)
                    {
                        textBox5.Text += Lectura.tempLINEA[i] + "\r\n";
                    }
                    break;
                case 7:
                    for (int i = 0; i < Lectura.tempLINEA.Count; i++)
                    {
                        textBox6.Text += Lectura.tempLINEA[i] + "\r\n";
                    }
                    break;
                case 8:
                    for (int i = 0; i < Lectura.tempLINEA.Count; i++)
                    {
                        textBox7.Text += Lectura.tempLINEA[i] + "\r\n";
                    }
                    break;
                case 9:
                    for (int i = 0; i < Lectura.tempLINEA.Count; i++)
                    {
                        textBox8.Text += Lectura.tempLINEA[i] + "\r\n";
                    }
                    break;
                case 10:
                    for (int i = 0; i < Lectura.tempLINEA.Count; i++)
                    {
                        textBox9.Text += Lectura.tempLINEA[i] + "\r\n";
                    }
                    break;
                case 11:
                    for (int i = 0; i < Lectura.tempLINEA.Count; i++)
                    {
                        textBox10.Text += Lectura.tempLINEA[i] + "\r\n";
                    }
                    break;
                case 12:
                    for (int i = 0; i < Lectura.tempLINEA.Count; i++)
                    {
                        textBox11.Text += Lectura.tempLINEA[i] + "\r\n";
                    }
                    break;
                case 13:
                    for (int i = 0; i < Lectura.tempLINEA.Count; i++)
                    {
                        textBox12.Text += Lectura.tempLINEA[i] + "\r\n";
                    }
                    break;
                case 14:
                    for (int i = 0; i < Lectura.tempLINEA.Count; i++)
                    {
                        textBox14.Text += Lectura.tempLINEA[i] + "\r\n";
                    }
                    break;
                default:

                    break;




            }
            contador++;


            
            //Console.WriteLine("-----"+Primero.GetLineText(0) );

            //TextReader read = new System.IO.StringReader(Primero.Text);
            //int rows = 100;

            //string[] text1 = new string[rows];
            //for (int r = 1; r < rows; r++)
            //{
            //    text1[r] = read.ReadLine();
            //    Console.WriteLine("-----" + text1[r]);
            //}





        }













        //StringCollection GetLinesCollectionFromTextBox(TextBox textBox)
        //{
        //    StringCollection lines = new StringCollection();

        //    // lineCount may be -1 if TextBox layout info is not up-to-date.
        //    int lineCount = textBox.LineCount;

        //    for (int line = 0; line < lineCount; line++)
        //        // GetLineText takes a zero-based line index.
        //        lines.Add(textBox.GetLineText(line));

        //    return lines;
        //}





        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buscarCoincidenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //evento de coincidencias






            int pri = comboBox1.SelectedIndex;
            int segu = comboBox2.SelectedIndex;

            Console.WriteLine(pri);
            Console.WriteLine(segu);










            if (((pri == -1) || (pri == 0)) && ((segu != 0) && (segu != -1)))
            {
                MessageBox.Show("Seleccione 2 Archivos");
            }

            else if (((segu == 0) || (segu == -1)) && ((pri == -1) || (pri == 0)))
            {
                MessageBox.Show("Seleccione 2 Archivos");

            }
            else if (((segu == 0) || (segu == -1)) && ((pri != -1) || (pri != 0)))
            {
                MessageBox.Show("Seleccione 2 Archivos");

            }
            else
            {
                Console.WriteLine(pri + "adfa");
                Console.WriteLine(segu + "asdfas");


                ArrayList temp1 = lineaCOMBO(pri);
                if (temp1.Count == 0)
                {



                }
                else {
                    //try
                    //{
                        ArrayList sigui = gesti.leeyanaliza2(temp1);

                        //array / contador / tama;ao




                        //Console.WriteLine(sigui[0] + "asdfas");
                        //gesti.html(sigui);

                        ArrayList temp2 = lineaCOMBO(segu);
                        ArrayList sigui2 = gesti.leeyanaliza2(temp2);

                        ArrayList info = Coincidencias(sigui, sigui2);


                        Ventana ven = new Ventana();
                        ven.ventanax((ArrayList)info[0], (int)info[1], (int)info[2]);
                        ven.Show();
                    //}catch(Exception vvv){
                    
                    //Console.WriteLine("ERROR EN LEXICO");
                    
                    //}
                
                
                
                }
               


                //Console.WriteLine(sigui2[0] + "asdfas");
                //gesti.html(sigui2);
            }


        }





        public ArrayList Coincidencias(ArrayList a1 , ArrayList a2) {

            ArrayList regresa = new ArrayList();




            int tama1 = a1.Count;
            int tama2 = a2.Count;

            int contador = 0;
            ArrayList coincidencias = new ArrayList();

            for (int i = 0; i < tama1;i++ )
            {
                for (int j = 0; j < tama2; j++)
                {

                    if (a1[i].Equals(a2[j]))
                    {
                        coincidencias.Add(a1[i]);
                        contador++;
                    }
                    else { 
                    
                    
                    
                    }

                }


            }

            regresa.Add(coincidencias);
            regresa.Add(contador);
            regresa.Add(tama1);

            return regresa;
        
        
        
        }







        private void guardarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {


            int index = comboBox1.SelectedIndex;
            if ((index == -1) || (index == 0))
            {
                MessageBox.Show("Seleccione 1 pestaña");
            }
            else
            {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt|*.txt";
            saveFileDialog1.Title = "Guardar Archivo";
            saveFileDialog1.ShowDialog();
            
           
            if (saveFileDialog1.FileName != "")
            {
                

                System.IO.FileStream fs =
                      (System.IO.FileStream)saveFileDialog1.OpenFile();
                fs.Close();

                string dir = saveFileDialog1.FileName;
                String arreglo = (String)arregla(dir);
                
                    Console.WriteLine(arreglo+"-------------------");
                    StreamWriter sw = new StreamWriter(arreglo);
                        

                    for (int i = 0; i < tm.Count; i++)
                    {
                        sw.WriteLine(tm[i]);
                    }

                    sw.Close();

                    

                
            }


            }
        }

        public String arregla(String arregla)
        {
            String conatena = "";
            int contador = 0;


            while (contador < arregla.Length)
            {



                Char diagoi = '\\';
                switch (arregla[contador])
                {
                    case '\\':
                        Console.WriteLine("\\\\");
                        Console.WriteLine(arregla[contador]);
                        //conatena = conatena.Replace("\\","\\\\");
                        conatena = conatena + "\\";
                        conatena = conatena + "\\";
                        break;

                    default:
                        Console.WriteLine(diagoi);
                        Console.WriteLine(arregla[contador]);
                        conatena = conatena + arregla[contador];
                        break;

                }



                contador++;
            }
            Console.WriteLine(conatena + "*********");
            return conatena;

        }
        public ArrayList llenalin(String a){
            ArrayList regresa = new ArrayList();
        TextReader read = new System.IO.StringReader(a);
                        String linea = read.ReadLine();
                        ArrayList tempx = new ArrayList();
                        Boolean salir = false;
                        int salenull = 0;
                        while (!salir)
                        {
                            if (("".Equals(linea)) || (linea == null) || (String.IsNullOrEmpty(linea)) || (" ".Equals(linea)))
                            {

                                if(salenull==5){
                                    salir = true;
                                }else{
                                    linea = read.ReadLine();
                                    salenull++;
                                }

                                



                            }else{
                                tempx.Add(linea);
                                Console.WriteLine(linea+"55555555");
                                linea = read.ReadLine();
                            }
                        }
                        regresa = (ArrayList)tempx.Clone();


                        return regresa;
        }
        public ArrayList lineaCOMBO(int index) {


            ArrayList regresa = new ArrayList();

            switch (index)
            {




                case 1:
                    regresa=llenalin(Primero.Text);
                        //TextReader read = new System.IO.StringReader(Primero.Text);
                        //String linea = read.ReadLine();
                        //ArrayList tempx = new ArrayList();
                        //Boolean salir = false;
                        //while (!salir)
                        //{
                        //    if (("".Equals(linea)) || (linea == null) || (String.IsNullOrEmpty(linea)) || (" ".Equals(linea)))
                        //    {

                        //        salir = true;
                        //    }else{
                        //        tempx.Add(linea);
                        //        Console.WriteLine(linea+"55555555");
                        //        linea = read.ReadLine();
                        //    }
                        //}
                        //regresa = (ArrayList)tempx.Clone();


                    break;
                case 2:


                    regresa = llenalin(textBox1.Text);
                    //contador++;
                    break;
                case 3:
                    regresa = llenalin(textBox2.Text);
                    break;
                case 4:
                    regresa = llenalin(textBox3.Text);
                    break;
                case 5:
                    regresa = llenalin(textBox4.Text);
                    break;
                case 6:
                    regresa = llenalin(textBox5.Text);
                    break;
                case 7:
                    regresa = llenalin(textBox6.Text);
                    break;
                case 8:
                    regresa = llenalin(textBox7.Text);
                    break;
                case 9:
                    regresa = llenalin(textBox8.Text);
                    break;
                case 10:
                    regresa = llenalin(textBox9.Text);
                    break;
                case 11:
                    regresa = llenalin(textBox10.Text);
                    break;
                case 12:
                    regresa = llenalin(textBox11.Text);
                    break;
                case 13:
                    regresa = llenalin(textBox12.Text);
                    break;
                case 14:
                    regresa = llenalin(textBox13.Text);
                    break;
                default:

                    break;




            }





            return regresa;
        
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void archivosSalidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Coincidencias coinci = new Coincidencias();
            Console.WriteLine("entro salidas");
            coinci.obtiene();
            
            coinci.Show();


        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datos da = new datos();
            da.Show();





        }

        private void manualUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("ManualUsuario.pdf");
        }

        private void manualTecnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("ManualTecnico.pdf");
        }




        ////this.tabControl1.Controls.Add(this.tabPage2);
        ////    this.tabControl1.Controls.Add(this.tabPage4);
        ////    this.tabControl1.Controls.Add(this.tabPage5);
        ////    this.tabControl1.Controls.Add(this.tabPage6);
        ////    this.tabControl1.Controls.Add(this.tabPage7);
        ////    this.tabControl1.Controls.Add(this.tabPage8);
        ////    this.tabControl1.Controls.Add(this.tabPage9);
        ////    this.tabControl1.Controls.Add(this.tabPage10);
        ////    this.tabControl1.Controls.Add(this.tabPage11);
        ////    this.tabControl1.Controls.Add(this.tabPage12);
        ////    this.tabControl1.Controls.Add(this.tabPage13);
        ////    this.tabControl1.Controls.Add(this.tabPage14);
        ////    this.tabControl1.Controls.Add(this.tabPage15);
        ////    this.tabControl1.Controls.Add(this.tabPage16);



    }
}
