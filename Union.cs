using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interseccion
{
    class Program
    {
        static void Main(string[] args)
        {



            int[] pares = new int[] { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 29, 30 };

            int[] inpares = new int[] { 0, 3, 6, 9, 12, 15, 18, 21, 24, 27,  30 };

            int[] U = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };




            int contador = 0;


      

            for (int i = 0; i < pares.Length; i++)
                        {

                            for (int x = 0; x < inpares.Length; x++) { 
                                if (pares[i] == inpares[x])
                                {
                                    contador++;

                               
                                     
                                     

                                        

                                 }

                                  int[] inter = new int[contador];

                                          if (pares[i] == inpares[x])
                                        {                



                                            for (int h = 0; h < inter.Length; h++) { inter[h] = pares[i]; }


                                        for (int t = 0; t < contador; t++)
                                        {
                                            Console.WriteLine(inter[t]);


                                        }

                    }

                                        



                                   
                              }


     

            }


         
           


        }
    }
}





