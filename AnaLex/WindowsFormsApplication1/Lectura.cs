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
    class Lectura
    {

        public ArrayList tokens;
        public ArrayList Tokens;

        public String[] letras;
        //public String[] letras2;
        //public String[] letras3;
        //public String[] letras4;
        public String[] numeros;
        public String[] signos;


        String concatena = "";
        public ArrayList ayu = new ArrayList();
        //-------------------------------

        public static ArrayList path;
        public static ArrayList nombre;



        public static ArrayList tempLINEA;
        public static int selecciono = 0;






        public Lectura() {
            char comilla = '"';
            tokens = new ArrayList();
            Tokens = new ArrayList();
            //letras = new String[27];
            nombre = new ArrayList();
            path = new ArrayList();


            letras = new String[] { "Á", "É", "Í", "Ó", "Ú", "á", "é", "í", "ó", "ú", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", };
            numeros = new String[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            signos = new String[] { "¿", "?", "!", "¡", ":", ";", ",", "(", ")", "-", Convert.ToString(comilla) };
            //---------------------
            
            tempLINEA = new ArrayList();

            //letras2 = new String[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", " P", "Q", "R", "S", "T", "U", "V", " W", " X", " Y", " Z" };
            //letras3 = new String[] { "á", "é", "í", "ó", "ú" };
            //letras4 = new String[] { "Á", "É", "Í", "Ó", "Ú" };
            //signos = new String[] { "¿", "?", "!", "¡", ":", ";", ",", ".", "(", ")", "...", "-", "_","" };
            
        }




        public void abre()
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Cursor Files|*.txt";
            openFileDialog1.Title = "Select a Cursor File";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {


                string dir = openFileDialog1.FileName;
                string destino = Path.GetFileName(dir);

                String arrelgo = arregla(dir);
                lee(arrelgo);
                selecciono = 1;
            }
            else
            {

            }





        }



        public void lee(String ruta)
        {
            String line;

            int contador = 0;
            //try
            //{
            StreamReader sr = new StreamReader(ruta);
            line = sr.ReadLine();
            int paramulti = 0;

            Boolean salir = false;

            //line!=null
            while (!salir)
            {

                Console.WriteLine("LINEA A ANALIZAR " + line);
                if ((line == null) || ("".Equals(line)))
                {

                    if (contador == 5)
                    {
                        salir = true;

                    }
                    else
                    {
                        line = sr.ReadLine();
                        contador++;

                    }

                    Console.WriteLine("ENTRO NULO NULONULO");

                }
                else
                {


                    ////////if (comentario1(line))
                    ////////{
                    ////////}
                    ////////else
                    ////////{

                    ////////    tempLINEA.Add(line);
                    ////////   // separacion(line);
                    ////////}


                    



                    if (comentario1(line))
                    {
                    }
                    else
                    {

                        ArrayList tempo = comenarioMultilinea(line, paramulti);

                        //valua vacio , valor 1 , texto trae
                        int valor = (int)tempo[0];
                        String trae = (String)tempo[1];


                        paramulti = valor;
                        
                        if (valor == 1)
                        {
                            if (trae.Length != 0)
                            {

                                tempLINEA.Add(trae);
                            }
                            else
                            {


                            }

                        }
                        else
                        {
                            if (trae.Length != 0)
                            {

                                tempLINEA.Add(trae);
                            }
                            else
                            {


                            }
                           // tempLINEA.Add(trae);

                        }





                    }








                    //ana1.separacion(line);



                }

                line = sr.ReadLine();


            }

            //path.Add(ruta);


            //Console.WriteLine(path.Count + " estado de cout path 666666666666666666666666666666666666666666");

            //Console.WriteLine(getLinea()[0] + " adsfasdfasdfasdfasdf--------------------------");

            sr.Close();
            Console.ReadLine();



            //}






            //}catch(Exception asw){

            //Console.WriteLine("ERROR de NOSE PORQUE");
            //}

        }

        public ArrayList leeyanaliza(String ruta)
        {
            String line;
            Boolean salir = false;
            int contador = 0;
            ArrayList regre = null;
            try
            {
                StreamReader sr = new StreamReader(ruta);
                line = sr.ReadLine();
                

                while (!salir)
                {
                    Console.WriteLine("LINEA A ANALIZAR " + line);
                    if ((line == null) || ("".Equals(line)))
                    {

                        if (contador == 5)
                        {
                            salir = true;
                        }
                        else
                        {
                            line = sr.ReadLine();
                            contador++;
                        }

                        Console.WriteLine("ENTRO NULO NULONULO");

                    }
                    else
                    {


                        if (comentario1(line))
                        {
                        }
                        else
                        {

                            //temp.Add(line);
                            separacion(line);
                        }

                    }

                    line = sr.ReadLine();
                }

                inter();
                comentario2(0, 0);
                Repeticion(null, null);//finaliza trabajo

                regre = getArray();
                imprime();
                tokens = new ArrayList();
                Tokens = new ArrayList();
                ayu = new ArrayList();


                
                
                sr.Close();
                Console.ReadLine();


            }
            catch (Exception asw)
            {

                Console.WriteLine("ERROR");
            }


            return regre;
        }


        public ArrayList leeyanaliza2(ArrayList ruta)
        {//ruta es lineas
            String line;
            
            int lines = 0;

            ArrayList regre = null;
            
                line = (String)ruta[lines];

                while (lines<ruta.Count)
                {
                    Console.WriteLine(ruta.Count+"LINEA A ANALIZAR " + line);
                   


                        if (comentario1(line))
                        {
                        }
                        else
                        {
                            separacion(line);
                        }



                        lines++;
                       

                    if(lines==(ruta.Count)){
                    
                    }else{

                        line = (String)ruta[lines];
                    }


                }

                inter();
                comentario2(0, 0);
                Repeticion(null, null);//finaliza trabajo

                regre = getArray();
                imprime();
                tokens = new ArrayList();
                Tokens = new ArrayList();
                ayu = new ArrayList();

            return regre;
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






        public void separacion(String lexema){

            Boolean salir = false;
            int conta = 0;


            String concatena = "";

            while(!salir==true){
               

                if (conta>(lexema.Length-1))
                {

                    if ((concatena==" ")||(concatena==""))
                    {


                    }
                    else {
                        //Console.WriteLine("agregao " + concatena);
                        tokens.Add(concatena);
                        
                    
                    }
                    concatena = "";
                    salir = true;
                }else{

                    if (lexema[conta]==' ')
                    {
                        //Console.WriteLine("agregao "+concatena);
                        tokens.Add(concatena);
                        concatena = "";

                    }
                    else
                    {
                        concatena = concatena + lexema[conta];

                    }
                    conta++;
                }
            }
            
        
        }

        
        


        public void inter() {

            for (int i = 0; i <tokens.Count;i++ )
            {

               // tercer((String)Tokens[i],0);
               //Console.WriteLine(concatena+" **********");
                analisis((String)tokens[i], 0);

               
            }

            for (int j= 0; j <ayu.Count; j++)
            {
              
                Console.WriteLine(  ayu[j]+"/////////////" );
            }
          
        }

        

        public void analisis(String token, int pos)
        {
            //ver cuando se termine cambie de posicion
            //ver try cathc final error

            //Console.WriteLine("poasds "+ayu.Count);
            //if ((pos < token.Length) || (" ".Equals(token)) || ("".Equals(token)))
           // Console.WriteLine("posss " + pos + " tamaaa " + token.Length);
            if ((" ".Equals(token)) || ("".Equals(token)))
            {


            }
            else
            {
                //Console.WriteLine("pos "+pos +" tama "+token.Length+" toke "+token+"||||||||" );
                Char asdf = token[pos];
                //Console.WriteLine("ANALIZA" + asdf + "SIGUE");
                switch (tipo2(asdf))
                {

                    case "letra":

                        LETRA(token, pos);
                        break;
                    case "numero":

                        NUMERO(token, pos, 0);
                        break;
                    case "signo":

                        SIGNO(token, pos);
                        break;
                    case "asterisco":

                        ASTERISCO(token, pos);
                        break;
                    case "desconocido":

                        LETRA(token, pos);
                        break;
                    case "guion":
                        GUION(token, pos);

                        break;
                    case "diagonal":
                        DIAGONAL(token, pos);

                        break;
                    case "punto":
                        PUNTO(token, pos, 0);

                        break;
                    default:

                        break;


                }





            }
        
        }

        public void LETRA(String token , int pos)
        {
           // Console.WriteLine(token);
            //Console.WriteLine(token[pos]);
            //Console.WriteLine(tipo2(token[pos])+"-------------+++++----");


            if (pos == (token.Length - 1))
            {
                if (tipo2(token[pos]).Equals("letra"))
                {
                    concatena = concatena + token[pos];
                    ayu.Add(concatena);
                    concatena = "";
                    

                }
                else if (tipo2(token[pos]).Equals("numero"))
                {
                    concatena = concatena + token[pos];
                    ayu.Add(concatena);
                    concatena = "";

                }
                else if (tipo2(token[pos]).Equals("guion"))
                {
                    concatena = concatena + token[pos];
                    ayu.Add(concatena);
                    concatena = "";
                }
                else if (tipo2(token[pos]).Equals("desconocido"))
                {
                    concatena = concatena + token[pos];
                    ayu.Add(concatena);
                    concatena = "";
                }
                else
                {
                   // Console.WriteLine("PASO ------------------------------------");
                    //concatena = concatena + token[pos];
                    ayu.Add(concatena);
                    concatena = "";
                    analisis(token, pos);
                    

                }
            }
            else { 
            
            if(tipo2(token[pos]).Equals("letra")){

                concatena = concatena + token[pos];
                LETRA(token, pos + 1);

            }
            else if (tipo2(token[pos]).Equals("numero"))
            {
                concatena = concatena + token[pos];
                LETRA(token, pos + 1);

            }
            else if (tipo2(token[pos]).Equals("guion"))
            {
                concatena = concatena + token[pos];
                LETRA(token, pos + 1);
            }
            else if (tipo2(token[pos]).Equals("desconocido"))
            {
                concatena = concatena + token[pos];
                LETRA(token, pos + 1);
            }
            else {
                
                ayu.Add(concatena);
                concatena = "";
                analisis(token, pos );
            
            }
            
            
            }

        }

        public void DESCONOCIDO(String token, int pos)
        {



            if (pos == (token.Length - 1))
            {
                if (tipo2(token[pos]).Equals("letra"))
                {
                    concatena = concatena + token[pos];
                    ayu.Add(concatena);
                    concatena = "";


                }
                else if (tipo2(token[pos]).Equals("numero"))
                {
                    concatena = concatena + token[pos];
                    ayu.Add(concatena);
                    concatena = "";

                }
                else if (tipo2(token[pos]).Equals("guion"))
                {
                    concatena = concatena + token[pos];
                    ayu.Add(concatena);
                    concatena = "";
                }
                else if (tipo2(token[pos]).Equals("desconocido"))
                {
                    concatena = concatena + token[pos];
                    ayu.Add(concatena);
                    concatena = "";
                }
                else
                {
                    //concatena = concatena + token[pos];
                    ayu.Add(concatena);
                    concatena = "";
                    analisis(token, pos);


                }
            }
            else
            {

                if (tipo2(token[pos]).Equals("letra"))
                {

                    concatena = concatena + token[pos];
                    LETRA(token, pos + 1);

                }
                else if (tipo2(token[pos]).Equals("numero"))
                {
                    concatena = concatena + token[pos];
                    LETRA(token, pos + 1);

                }
                else if (tipo2(token[pos]).Equals("guion"))
                {
                    concatena = concatena + token[pos];
                    LETRA(token, pos + 1);
                }
                else if (tipo2(token[pos]).Equals("desconocido"))
                {
                    concatena = concatena + token[pos];
                    LETRA(token, pos + 1);
                }
                else
                {

                    ayu.Add(concatena);
                    concatena = "";
                    analisis(token, pos);

                }


            }

        }
        public void NUMERO(String token, int pos,int num)
        {

            if (pos == (token.Length - 1))
            {
                if (tipo2(token[pos]).Equals("numero"))
                {

                    concatena = concatena + token[pos];
                    ayu.Add(concatena);
                    concatena = "";
                    

                }
                else if (tipo2(token[pos]).Equals("punto"))
                {

                    
                    ayu.Add(concatena);
                    concatena = "";
                    //analisis(token, pos);
                    
                }
                else
                {

                    ayu.Add(concatena);
                    concatena = "";
                    analisis(token, pos);

                }
            }
            else
            {

                if (tipo2(token[pos]).Equals("numero"))
                {

                    concatena = concatena + token[pos];
                    NUMERO(token, pos + 1,num);

                }
                else if (tipo2(token[pos]).Equals("punto"))
                {
                    int a = 1;

                    if ((tipo2(token[pos + 1]).Equals("numero"))&&(num!=1))
                    {

                        concatena = concatena + token[pos];
                        NUMERO(token, pos + 1,a);
                    }
                    else {

                        ayu.Add(concatena);
                        concatena = "";
                        analisis(token, pos);
                    }
                }
                else
                {

                    ayu.Add(concatena);
                    concatena = "";
                    analisis(token, pos);

                }


            }
        
        }

        public void SIGNO(String token, int pos)
        {
          //  Console.WriteLine("ana "+token[pos]);
            if (pos == (token.Length - 1))
            {
                if (tipo2(token[pos]).Equals("signo"))
                {

                    concatena = concatena + token[pos];
                    ayu.Add(concatena);
                    concatena = "";
                    


                }
                
            }
            else
            {

                concatena = concatena + token[pos];
                ayu.Add(concatena);
                concatena = "";
                analisis(token, pos+1);


            }
        
        }


        public void ASTERISCO(String token, int pos)
        {

            if (pos == (token.Length - 1))
            {
                if (tipo2(token[pos]).Equals("asterisco"))
                {
                    concatena = concatena + token[pos];
                    ayu.Add(concatena);
                    concatena = "";
                    

                }
                else if (tipo2(token[pos]).Equals("diagonal"))
                {
                    concatena = concatena + token[pos];
                    ayu.Add(concatena);
                    concatena = "";
                    

                }
                else
                {

                    ayu.Add(concatena);
                    concatena = "";
                    analisis(token, pos);
                }

            }
            else
            {

                if (tipo2(token[pos]).Equals("asterisco"))
                {
                    int a = 1;
                    concatena = concatena + token[pos];
                    ASTERISCO(token, pos + 1);

                }
                else if (tipo2(token[pos]).Equals("diagonal"))
                {
                    concatena = concatena + token[pos];
                    ayu.Add(concatena);
                    concatena = "";
                    analisis(token, pos);

                }
                else
                {

                    ayu.Add(concatena);
                    concatena = "";
                    analisis(token, pos);
                }




            }
        
        
        }


        public void GUION(String token, int pos)
        {

            if (pos == (token.Length - 1))
            {
               

                    concatena = concatena + token[pos];
                    ayu.Add(concatena);
                    concatena = "";
                    


            }
            else
            {

               

                    concatena = concatena + token[pos];
                    ayu.Add(concatena);
                    concatena = "";
                    analisis(token, pos+1);





            }
        
        }

        public void DIAGONAL(String token, int pos)
        {

            if (pos == (token.Length - 1))
            {
                if (tipo2(token[pos]).Equals("asterisco"))
                {
                    concatena = concatena + token[pos];
                    ayu.Add(concatena);
                    concatena = "";


                }
                else if (tipo2(token[pos]).Equals("diagonal"))
                {



                    concatena = concatena + token[pos];
                    ayu.Add(concatena);
                    concatena = "";
                    

                }
                else
                {

                    ayu.Add(concatena);
                    concatena = "";
                    analisis(token, pos);
                }

            }
            else
            {

                if (tipo2(token[pos]).Equals("asterisco"))
                {
                    
                    

                    concatena = concatena + token[pos];
                    ayu.Add(concatena);
                    concatena = "";
                    analisis(token, pos);

                }
                else if (tipo2(token[pos]).Equals("diagonal"))
                {

                    concatena = concatena + token[pos];
                    ASTERISCO(token, pos + 1);
                }
                else
                {

                    ayu.Add(concatena);
                    concatena = "";
                    analisis(token, pos);
                }




            }


        }


        public void PUNTO(String token, int pos, int contador) {


            if (pos == (token.Length - 1))
            {
                if (tipo2(token[pos]).Equals("punto"))
                {


                    if (contador == 2)
                    {

                        concatena = concatena + token[pos];
                        ayu.Add(concatena);
                        concatena = "";
                        
                    }
                    else if (contador == 3)
                    {
                        ayu.Add(concatena);
                        ayu.Add(".");
                        concatena = "";
                        
                    }
                    else if (contador == 1)
                    {
                        ayu.Add(concatena);
                        ayu.Add(concatena);
                        concatena = "";

                    }
                    else if (contador == 0)
                    {
                        concatena = concatena + token[pos];
                        ayu.Add(concatena);
                        concatena = "";

                    }
                   
                    


                }
                else
                {

                    if (contador == 2)
                    {

                        //concatena = concatena + token[pos];
                        ayu.Add(".");
                        ayu.Add(".");
                        concatena = "";
                        analisis(token, pos);
                    }
                    else if (contador == 1)
                    {
                        ayu.Add(concatena);
                        concatena = "";
                        analisis(token, pos);
                    }






                }
            }
            else
            {

                if (tipo2(token[pos]).Equals("punto"))
                {
                    

                    if (contador != 3)
                    {

                        concatena = concatena + token[pos];
                        PUNTO(token, pos + 1,contador+1 );
                    }
                    else if (contador == 3)
                    {
                        ayu.Add(concatena);
                        concatena = "";
                        analisis(token, pos);
                    }
                    
                    
                }
                else
                {


                    if (contador == 2)
                    {

                        //concatena = concatena + token[pos];
                        ayu.Add(".");
                        ayu.Add(".");
                        concatena = "";
                        analisis(token, pos);
                    }
                    else if (contador == 3)
                    {
                        ayu.Add(concatena);
                        concatena = "";
                        analisis(token, pos);

                    }
                    else if (contador == 1)
                    {
                        ayu.Add(concatena);
                        concatena = "";
                        analisis(token, pos);
                    }



                   





                }


            }
        
        
        }





        public ArrayList getArray(){
        
        

            return Tokens;
        }


        


        public Boolean comentario1(String linea) {

            
            Boolean retor = false;
            Console.WriteLine("esta trae para comentario"+linea);
            //Console.WriteLine("esta trae para comentario" + linea[0]);
            //Console.WriteLine("esta trae para comentario" + linea[1]);
            Boolean sale = false;
            int contador = 0;
            
                while ((!sale || (!(contador < linea.Length))))
                {
                    //Console.WriteLine("esta trae para comentario" + linea[contador]);
                    //Console.WriteLine("esta trae para comentario" + linea[contador + 1]);
                    
                    
                    if (linea[contador].Equals(' '))
                    {
                        contador++;
                    }
                    else
                    {
                        try
                        {
                            if ((linea[contador].Equals('/')) && (linea[contador + 1].Equals('/')))
                            {

                                retor = true;
                            }
                            else
                            {
                                retor = false;
                            }
                        }
                        catch (Exception dfsdf)
                        {

                            retor = false;

                        }
                        sale = true;
                        //contador++;
                    }


                }
            


            
            return retor;

        }

        
        public void comentario2(int posicion,int bandera) {
            Console.WriteLine("VERIFICA");
            Console.WriteLine("ENTRO SALE posi " + posicion + " bandera " + bandera + " ayucount " + ayu.Count);
        if(posicion>=ayu.Count){
            //Console.WriteLine("ENTRO SALE posi "+posicion+" bandera "+bandera+" ayucount "+ayu.Count);
        }else{

            Console.WriteLine("ENTRO SALE posi " + posicion + " bandera " + bandera + " ayucount " + ayu.Count);
            if (bandera != 1)
            {
                

                if (ayu[posicion].Equals("/*"))
                {
                    comentario2(posicion + 1, 1);
                }else
                {
                    Tokens.Add(ayu[posicion]);
                    comentario2(posicion + 1, 0);

                }


            }
            else
            {

                if (ayu[posicion].Equals("*/"))
                {

                    comentario2(posicion + 1, 0);

                }
                else
                {
                    comentario2(posicion + 1, 1);
                }


            }

        }

        
        
        }
            
        public String tipo2(Char cara)
        {//lexema es char 
           // String cas = Convert.ToString(gg).ToLower();
            //Char cara = Convert.ToChar(cas);
            String retor = "ee";
            if (verificaLetra(cara))
            { //VERIFICA LETRA
                retor = "letra";
            }
            else if (verificaNumero(cara))
            {
                //VERIFICA NUMERO   
                retor = "numero";
            }
            else if (verificaSigno(cara))
            {
                retor = "signo";
            }
            else if (cara.Equals('_'))
            {
                retor = "guion";
            }
            else if (cara.Equals('.'))
            {
                retor = "punto";
            }
            else if (cara.Equals('*'))
            {
                retor = "asterisco";
            }
            else if (cara.Equals('/'))
            {
                retor = "diagonal";
            }
                
            else
            {
                retor = "desconocido";
            }

            return retor;

        }




        public void Repeticion(ArrayList a1 ,ArrayList a2) {
            ArrayList aux =null;
            ArrayList aux2 = null;
            if ((a1 == null) || (a2 == null))
            {

               aux = (ArrayList)Tokens.Clone();
               aux2 = new ArrayList();
            }
            else {




                 aux = a1;
                 aux2 = a2;
            }
            
            //para iniciar llenado
            if (a1 == null){
                aux2.Add(aux[0]);

                Repeticion(aux,aux2);
            }else{

                for (int i = 1; i < aux.Count;i++ ){

                    for (int j = 0; j < aux2.Count; j++)
                    {

                        if (aux[i].Equals(aux2[j]))
                        {
                            break;

                        }
                        else
                        {

                            if (j == (aux2.Count - 1))
                            {
                                aux2.Add(aux[i]);
                            }
                            else { 
                            
                            }
                            
                        }

                    }

                }


                Tokens = (ArrayList)aux2.Clone();

            }

            

        
        
        }


        public void html(ArrayList array) {


            int contador=0;
//--------------------------

            Console.WriteLine("ENTRO PARA LLENADO TABLA");
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "html|*.html";
                    saveFileDialog1.Title = "Guardar Archivo";
                    saveFileDialog1.ShowDialog();

                    
                    if (saveFileDialog1.FileName != "")
                    {
                        
                        System.IO.FileStream fs =
                              (System.IO.FileStream)saveFileDialog1.OpenFile();
                        fs.Close();

                        string dir = saveFileDialog1.FileName;
                        String arreglo = (String)arregla(dir);
                        path.Add(arreglo);
                        String regre = Path.GetFileName(arreglo);
                        Console.WriteLine(regre + "------sdfasd-------------");
                        nombre.Add(regre);
                        Console.WriteLine(arreglo + "-------------------");
                        StreamWriter sw = new StreamWriter(arreglo);




                        //String estilo = " table {width: 100%;border: 1px solid #000;}th, td { width: 25%; text-align: left;vertical-align: top; border: 1px solid #000;   border-collapse: collapse;  padding: 0.3em;   caption-side: bottom;}caption {   padding: 0.3em;   color: #fff;    background: #000;}th {   background: #eee;}";


                        String estilo = "table{position:absolute; border: 1px solid #000;border-collapse: collapse;font-family:century gothic';}";

                        sw.WriteLine("<html>");
                        sw.WriteLine("<head>");
                        sw.WriteLine("<style type='text/css'>");
                        sw.WriteLine(estilo);
                        sw.WriteLine("</style>");
                        sw.WriteLine("</head>");
                        sw.WriteLine("<body>");
                        sw.WriteLine("<div id=data>");


                        sw.WriteLine("<table class='egt' border=1px style='margin-left:250px;font-family:century gothic'>");
                        sw.WriteLine("<tr><td colspan=4 align=center>titulo</td></tr>");
                        sw.WriteLine("<tr>");
                        sw.WriteLine("<th scope='row'>#</th>");
                        sw.WriteLine("<th>Tipo</th>");
                        sw.WriteLine("<th>Token</th>");
                        sw.WriteLine("<th>ID</th>");
                        sw.WriteLine("</tr>");
                        sw.WriteLine("<tr>");
                            
                            for (int i = 0; i < array.Count;i++ )
                            {
                                String temp = (String)array[i];
                                Console.WriteLine(temp[0]+"------------++++++++++++++++++++");
                                ArrayList tabla = lexicoL(temp);

                                if (!(tabla[0].Equals("error")))
                                {
                                    //tipo / token/ posiccionn o id seria i

                                    sw.WriteLine("<th>" +contador + "</th>");
                                    sw.WriteLine("<td>" + tabla[0] + "</td>");
                                    sw.WriteLine("<td>" + tabla[1] + "</td>");
                                    sw.WriteLine("<td>"+i+"</td>");
                                    sw.WriteLine("</tr>");
                                    sw.WriteLine("<tr>");
                                    contador++;
                                    //sw.WriteLine("<th>Temperatura</th>");
                                    //sw.WriteLine("<td>19°C</td>");
                                    //sw.WriteLine("<td>17°C</td>");
                                    //sw.WriteLine("<td>12°C</td>");
                                    //sw.WriteLine("</tr>");
                                    //sw.WriteLine("<tr>");

                                    //sw.WriteLine("<th>Vientos</th>");
                                    //sw.WriteLine("<td>E 13 km/h</td>");
                                    //sw.WriteLine("<td>E 11 km/h</td>");
                                    //sw.WriteLine("<td>S 16 km/h</td>");
                                ///sw.WriteLine(tabla[i]);
                                }
                                else
                                {

                                }
                            }
                            sw.WriteLine("</tr>");
                            sw.WriteLine("</table>");














                            sw.WriteLine("<table class='egt' border=1px style='margin-left:700px;font-family:century gothic'>");
                            sw.WriteLine("<tr><td colspan=4 align=center>titulo</td></tr>");   
                        sw.WriteLine("<tr>");
                            sw.WriteLine("<th scope='row'>#</th>");
                            sw.WriteLine("<th>Fila</th>");
                            sw.WriteLine("<th>Columna</th>");
                            sw.WriteLine("<th>Caracter</th>");

                            sw.WriteLine("</tr>");
                            sw.WriteLine("<tr>");
                            contador = 0;
                            for (int i = 0; i < array.Count; i++)
                            {
                                String temp = (String)array[i];
                                Console.WriteLine(temp[0] + "------------++++++++++++++++++++");

                                ArrayList tabla2 = Errores(temp);

                                if (!(tabla2[0].Equals("error")))
                                {
                                    //tipo / token/ posiccionn o id seria i
                                    Console.WriteLine(tabla2.Count+"--------------************//////////////");
                                    if (tabla2.Count > 2)
                                    {
                                        for (int j = 0; j < tabla2.Count; j+=2)
                                        {
                                            sw.WriteLine("<th>" + contador + "</th>");
                                            
                                            
                                            sw.WriteLine("<td>" + i + "</td>");
                                            
                                            sw.WriteLine("<td>" + tabla2[j] + "</td>");
                                            sw.WriteLine("<td>" + tabla2[j + 1] + "</td>");
                                            sw.WriteLine("</tr>");
                                            sw.WriteLine("<tr>");
                                            contador++;
                                        }
                                    }
                                    else {

                                        sw.WriteLine("<th>" + contador + "</th>");
                                        sw.WriteLine("<td>" + i + "</td>");
                                        sw.WriteLine("<td>" + tabla2[0] + "</td>");
                                        sw.WriteLine("<td>" + tabla2[1] + "</td>");
                                        
                                        sw.WriteLine("</tr>");
                                        sw.WriteLine("<tr>");
                                        contador++;
                                    
                                    
                                    }
                                    
                                    //sw.WriteLine("<th>Temperatura</th>");
                                    //sw.WriteLine("<td>19°C</td>");
                                    //sw.WriteLine("<td>17°C</td>");
                                    //sw.WriteLine("<td>12°C</td>");
                                    //sw.WriteLine("</tr>");
                                    //sw.WriteLine("<tr>");

                                    //sw.WriteLine("<th>Vientos</th>");
                                    //sw.WriteLine("<td>E 13 km/h</td>");
                                    //sw.WriteLine("<td>E 11 km/h</td>");
                                    //sw.WriteLine("<td>S 16 km/h</td>");
                                    ///sw.WriteLine(tabla[i]);
                                }
                                else
                                {

                                }
                            }
                            sw.WriteLine("</tr>");
                            sw.WriteLine("</table>");















                            sw.WriteLine("</div>");
                            sw.WriteLine("</body>");
                            sw.WriteLine("</html>");

                        
                        sw.Close();





                    } 





//----------------------------------

                


        }

        public void imprime() {
        int conta =0;
           while(conta<Tokens.Count){

               Console.WriteLine( Tokens[conta] );
               //Console.WriteLine(ayu[conta]);
               //Console.WriteLine(conta);

           conta++;
           }
        
        }

        



        public ArrayList lexicoL(String totemp)
        {
            ArrayList regresa = new ArrayList();
            int valor = 0;
                for (int i = 0; i < totemp.Length; i++)
                {



                    Char le = (Char)totemp[i];
                    //Boolean letra = verificaLetra(le);
                    //Boolean numer = verificaNumero(le);
                    //Boolean sign = verificaSigno(le);

                    if (tipo2(le).Equals("desconocido"))
                    {
                        valor = 1;

                        break;
                    }
                    else
                    {
                    
                    }




                }

                if (valor == 0)
                {

                    if (tipo2(totemp[0]).Equals("letra"))
                    {
                        regresa.Add("Identificador");
                        regresa.Add(totemp);
                        
                    }
                    else if (tipo2(totemp[0]).Equals("numero"))
                    {
                        regresa.Add("Numero");
                        regresa.Add(totemp);
                    }
                    else if ((tipo2(totemp[0]).Equals("signo")) || (tipo2(totemp[0]).Equals("asterisco")) || (tipo2(totemp[0]).Equals("guion")) || (tipo2(totemp[0]).Equals("punto")) || (tipo2(totemp[0]).Equals("diagnonal")))
                    {
                        regresa.Add("Signo Puntuacion");
                        regresa.Add(totemp);
                    }
                    else {

                        
                    }

                }
                else {
                    regresa.Add("error");
                }
                return regresa;
                
        }


        public ArrayList Errores(String totemp) {



            ArrayList regresa = new ArrayList();
            int valor = 0;


            for (int i = 0; i < totemp.Length; i++)
            {



                Char le = (Char)totemp[i];

                Console.WriteLine(le+"\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\"+tipo2(le));
                if (tipo2(le).Equals("desconocido"))
                {
                    valor = 1;
                    regresa.Add(i);
                    regresa.Add(le);

                    //break;
                }
                else
                {

                }




            }

            if (valor == 0)
            {

                regresa.Add("error");

            }
            else
            {
                
            }
            return regresa;

        
        }



        public Boolean verificaLetra(Char letratokens) {
            int con = 0;
            Boolean valor = false;
            //while(tokens[con]!=null)
            //{

                
                    for (int j = 0; j < letras.Length; j++)
                    {
                        String a1 = null;
                        //if (tokens[con].Equals(letras[j])){
                        
                           a1 = Convert.ToString(letratokens);
                        
                        
                        
                        
                        
                        String a2 =Convert.ToString(letras[j]);
                        //String a3 = Convert.ToString(letras2[j]);
                        //Char a4 = Convert.ToChar(letras3[j]);
                        //Char a5 = Convert.ToChar(letras4[j]);
                        //String a1 = a11.ToLower();
                        //String a2 = a22.ToLower();
                        //f (a1.Equals(a2) || (a1.Equals(a3)) || (a1.Equals(a4)) || (a1.Equals(a5)))
                        
                        if (a1.Equals(a2))
                        {
                           // Console.WriteLine("ESTA en LETRA");
                            valor= true;
                            break;
                        }
                        else{

                           // Console.WriteLine(letras[j]+"ERROR NO ESTA en LETRA"+letratokens);
                            //valor= false;
                        }

                    }
              //  con++;
               
            //}
            return valor;
        }

        public Boolean verificaNumero(Char letratokens)
        {
            int con = 0;
            Boolean valor = false;
            //while(tokens[con]!=null)
            //{


            for (int j = 0; j <= numeros.Length - 1; j++)
            {

                String a1 = Convert.ToString(letratokens);
                String a2 = Convert.ToString(numeros[j]);

                //if (tokens[con].Equals(letras[j])){
                if (a1.Equals(a2))
                {
                    //Console.WriteLine("ESTA en numero");
                    valor = true;
                    break;
                }
                else
                {

                    //Console.WriteLine("ERROR NO ESTA en numero");
                    valor = false;
                }

            }
            //  con++;

            //}
            return valor;
        }

        public Boolean verificaSigno(Char letratokens)
        {
            int con = 0;
            Boolean valor = false;
            //while(tokens[con]!=null)
            //{


            for (int j = 0; j < signos.Length; j++)
            {
                String a1 = Convert.ToString(letratokens)+1;
                String a2 = Convert.ToString(signos[j])+1;
                //if (tokens[con].Equals(letras[j])){
                //Console.WriteLine("prueba:"+a2+"Con:"+a1);
                if ((a1.Equals(a2))||(a2.Equals(a1)))
                
                {

                  // Console.WriteLine("ESTA en signo");
                    valor = true;
                    break;
                }
                else
                {

                    //Console.WriteLine("ERROR NO ESTA en sino");
                    valor = false;
                }

            }
            //  con++;

            //}
            return valor;
        }


        public ArrayList comenarioMultilinea(String linea,int valor) {
            String concatena = "";

            int val =0;

            int au = 1;
            if(valor==0){
                val = 0;
            }else{
                val = valor;
            }

            ArrayList regre = new ArrayList();
            for (int i = 0; i<linea.Length;i+=au )
            {
                if (au > 1)
                {
                    au = 1;
                }
                else { 
                }
                if(val==0){


                    if (linea[i].Equals('/') && (i != (linea.Length - 1)))
                    {
                        if (linea[i + 1].Equals('*'))
                        {
                            val = 1;

                        }
                        else
                        {

                            concatena = concatena + linea[i];
                        }

                    }
                    else
                    {

                        concatena = concatena + linea[i];

                    }


                
                }else{

                    if (linea[i].Equals('*') && (i != (linea.Length - 1)))
                    {
                        if (linea[i + 1].Equals('/'))
                        {
                            
                                val = 0;


                                au = 2;
                                
                            
                            
                            

                        }
                        else
                        {

                           // concatena = concatena + linea[i];
                        }

                    }
                    else
                    {
                       


                        //concatena = concatena + linea[i];

                    }
                
                }
                




            }
            regre.Add(val);
            regre.Add(concatena);

            return regre;
        }

    }
}
