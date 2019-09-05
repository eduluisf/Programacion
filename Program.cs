using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            string[] nombre = new string[5];
          
            string analisis = "";

            string[] vocales = new string[contador];


            for (int i = 0; i < nombre.Length; i++)
            {

                nombre[i] = Console.ReadLine();

            }


            for (int i = 0; i < nombre.Length; i++)
            {
                analisis = nombre[i];



                char[] vocal = new char[nombre.Length];

                vocal[i] = analisis[0];


               


                

                for ( int t=0; t<nombre.Length; t++) { 

                      if (vocal[t] == 'a' || vocal[t] == 'e' || vocal[t] == 'i' ||  vocal[t] == 'o' || vocal[t] == 'u')
                    {


                        contador++;


                        Console.WriteLine(analisis);



                    }

                   
                    

                       
                


                       
                    



                }



            }

    

       






        }
    }
}
