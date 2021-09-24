using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Gestiona
    {

        ////public ArrayList Objetos;
        //public static ArrayList path;

        //public static ArrayList temp;
        //public static int selecciono=0;
        //public Gestiona()
        //{

        //    //Objetos = new ArrayList();
        //    path = new ArrayList();
        //    temp = new ArrayList();
        //}



        //public void abre()
        //{
            
        //    OpenFileDialog openFileDialog1 = new OpenFileDialog();
        //    openFileDialog1.Filter = "Cursor Files|*.txt";
        //    openFileDialog1.Title = "Select a Cursor File";

        //    if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //    {


        //        string dir = openFileDialog1.FileName;
        //        string destino = Path.GetFileName(dir);

                

        //        //Console.WriteLine(dir);
        //        String arrelgo = arregla(dir);
        //        lee(arrelgo);
        //        // Console.WriteLine(arregla(dir));
        //        selecciono = 1;
        //    }
        //    else { 
            
        //    }





        //}


        //public void lee(String ruta) {
        //    String line;

        //    int contador = 0;
        //    //try
        //    //{
        //        StreamReader sr = new StreamReader(ruta);
        //        line = sr.ReadLine();
        //        Lectura ana1 = new Lectura();

        //        Boolean salir = false;

        //    //line!=null
        //        while (!salir)
        //        {

        //            Console.WriteLine("LINEA A ANALIZAR "+line);
        //            if ((line == null)||("".Equals(line)))
        //            {

        //                if (contador == 5)
        //                {
        //                    salir = true;

        //                }
        //                else
        //                {
        //                    line = sr.ReadLine();
        //                    contador++;

        //                }

        //                Console.WriteLine("ENTRO NULO NULONULO");

        //            }
        //            else
        //            {

                        
        //                if (ana1.comentario1(line))
        //                {
        //                }
        //                else
        //                {
                            
        //                        temp.Add(line);
        //                        ana1.separacion(line);
        //                }

                        


        //                //ana1.separacion(line);



        //        }

        //            line = sr.ReadLine();


        //            }

        //            path.Add(ruta);
        //            //Ventana asew = new Ventana();
        //            //asew.Show();

        //            Console.WriteLine(path.Count + " estado de cout path 666666666666666666666666666666666666666666");

        //            Console.WriteLine(ana1.getLinea()[0] + " adsfasdfasdfasdfasdf--------------------------");
        //            //ana1.inter();
        //            //ana1.comentario2(0, 0);
        //            //ana1.imprime();

        //            //Objetos.Add(ana1.getArray());

        //            //close the file
        //            sr.Close();
        //            Console.ReadLine();
                    
                    
                    
        //            //}



                    
            

        //    //}catch(Exception asw){
            
        //    //Console.WriteLine("ERROR de NOSE PORQUE");
        //    //}

        //}

        //public ArrayList leeyanaliza(String ruta)
        //{
        //    String line;
        //    Boolean salir = false;
        //    int contador = 0;
        //    ArrayList regre = null;
        //    try
        //    {
        //        StreamReader sr = new StreamReader(ruta);
        //        line = sr.ReadLine();
        //        Lectura ana1 = new Lectura();

        //        while (!salir)
        //        {

        //            Console.WriteLine("LINEA A ANALIZAR " + line);
        //            if ((line == null) || ("".Equals(line)))
        //            {

        //                if (contador == 5)
        //                {
        //                    salir = true;

        //                }
        //                else
        //                {
        //                    line = sr.ReadLine();
        //                    contador++;

        //                }

        //                Console.WriteLine("ENTRO NULO NULONULO");

        //            }
        //            else
        //            {


        //                if (ana1.comentario1(line))
        //                {
        //                }
        //                else
        //                {

        //                    temp.Add(line);
        //                    ana1.separacion(line);
        //                }




        //                //ana1.separacion(line);



        //            }

        //            line = sr.ReadLine();


        //        }

        //        ana1.inter();
        //        ana1.comentario2(0, 0);
                

        //        regre = ana1.getArray();
                
        //        ana1.imprime();


        //        //path.Add(ruta);
        //        ///Ventana asew = new Ventana();
        //        //asew.Show();



        //        //Console.WriteLine(ana1.getLinea()[0] + " adsfasdfasdfasdfasdf--------------------------");
               
        //        //ana1.comentario2(0, 0);
        //        //ana1.imprime();

        //        //Objetos.Add(ana1.getArray());

        //        //close the file
        //        sr.Close();
        //        Console.ReadLine();


        //    }
        //    catch (Exception asw)
        //    {

        //        Console.WriteLine("ERROR");
        //    }


        //    return regre;
        //}



        //public void repite(ArrayList a1 ,ArrayList a2) {

        //    ana1.Repeticion(a1,a2);
        
        //}






        //private String arregla(String arregla){
        //    String conatena = "";
        //    int contador = 0;

            
        //    while(contador<arregla.Length){
                


        //        Char diagoi = '\\';
        //        switch (arregla[contador])
        //        {
        //            case '\\':
        //                Console.WriteLine("\\\\");
        //            Console.WriteLine(arregla[contador]);
        //            //conatena = conatena.Replace("\\","\\\\");
        //            conatena = conatena + "\\";
        //            conatena = conatena + "\\";
        //                break;

        //            default:
        //                Console.WriteLine(diagoi);
        //            Console.WriteLine(arregla[contador]);
        //            conatena = conatena + arregla[contador];
        //                break;
                
        //        }

               

        //        contador++;
        //    }
        //    Console.WriteLine(conatena+"*********");
        //    return conatena;

        //}




        //public void html(ArrayList tokens) { 
        

        
        
        
        
        
        //}


        //public void errorLexico(String token) { 
        
        
        
        
        //}




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
