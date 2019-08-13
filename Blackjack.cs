using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        private static object random;

        static void Main(string[] args)
        {




            Random rnd = new Random();

            int eliminado= 0;

            int Carta1 = rnd.Next(1, 11);


            int Carta2 = rnd.Next(1, 11);

            int Sumacartas = Carta1 + Carta2;



            while (eliminado == 0 && Sumacartas <= 21 ){

                Console.WriteLine("Carta1:  " + Carta1);
                Console.WriteLine("Carta2 :" + Carta2);
                Console.WriteLine("sumaCarta:" + Sumacartas);


                Console.WriteLine("Quieres seguir, 1 para sí y 0 para no");

                int seguir = int.Parse(Console.ReadLine());

              
                while(seguir==1) {


                    int Carta3 = rnd.Next(1, 11);


                    Console.WriteLine("Carta 3 : " + Carta3);


                    Sumacartas = Sumacartas + Carta3;
                                                                                                        
                   seguir++;


                    Console.WriteLine(" la suma de tus Cartas es: " + Sumacartas);


                    if (Sumacartas> 21) {


                        Console.WriteLine("haz sido eliminado con:  " + Sumacartas);
                        eliminado = 1;
                    }


                }


              
                
                    Console.WriteLine("sus Cartas son" + Sumacartas);
                
                


            }


        }
    }
}
