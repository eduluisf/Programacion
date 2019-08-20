using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciclofor
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int vidas = 3;
            int vidaacumulada =0 ;

            int puntos = 20;
            int turno = 0;
            int C1 = 0;
            int consecutivo = 0;

            int turno1 = 0;


            while (true)
            {
                Random rnd = new Random();

                int dado = rnd.Next(1, 3);
                turno++;
                turno1++;
                if (turno == 2) { vidas--; }


                if (turno1==3) {


                    int dado1 = rnd.Next(1, 3);

                    Console.WriteLine(" turno doble");
                    if (dado1 == dado) { vidas++; }


                    turno1 = 0;
                }


              
                puntos += dado;

                Console.WriteLine(" sus puntos son    " + puntos);

                Console.WriteLine(" sus vidas son   " + vidas);

                Console.WriteLine(" acmulada   " +vidaacumulada);
                Console.WriteLine(" consecutivo :  " + consecutivo);
                if (dado == 1) {C1++; }

                if (C1 == 2) {

                    vidas--;
                    puntos -=10;

                    C1 = 0;
                  
                }


                if (dado == 6)
                { consecutivo ++; }
                else { consecutivo = 0;
                                    
                }

                if (dado == 6 && consecutivo == 2) {

                    Console.WriteLine(" Haz acumulado unavida");
                    vidaacumulada++;
                    consecutivo = 0;

                    vidas += vidaacumulada;
                }
              

                if (vidaacumulada==3) {


                    vidaacumulada = 3;

                   
                    Console.WriteLine("Ya no puedes acumular mas vida");
                        
                        
                }


                Console.WriteLine("Su Dado: " +dado);

                if ( vidas == 0) break;



                

               
                Console.WriteLine(" lanzar " );
              int L = int.Parse (Console.ReadLine());
                if (L != 1)
                {
                    Console.WriteLine(" Acabo, sus puntos son"+ dado
                        );
                    break;
                }

             
            }

            Console.WriteLine("Acabo, sus puntos son" +  puntos + "en" + turno + "turnos");



        }
    }
}
