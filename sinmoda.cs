using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebaparcial
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] malePetNames = { "Rufus", "Bear", "Dakota", "Fido",
                                "Vanya", "Samuel", "Koani", "Volodya",
                                "Prince", "Yiska"
            };


            List<string> nombres = new List<string>();
            List<int> numbs = new List<int>();

            int[] number = new int[malePetNames.Length];
           Random random = new Random();


            double promedio = 0;






            int suma = 0;
            double sum = 0;



            for (int i = 0; i < malePetNames.Length; i++) {

                int value = random.Next(0, 10);



                number[i] = value;




            }

            for (int i = 0; i < malePetNames.Length; i++)
            {




                Console.WriteLine(malePetNames[i] + " tiene " + number[i]);

            }


            for (int i = 0; i < malePetNames.Length; i++) suma += number[i];
            Console.WriteLine("suma: " + suma);
            promedio = (suma) / (malePetNames.Length);
            Console.WriteLine("su promedio es: " + promedio);


            Array.Sort(number);

            for (int i = 0; i < malePetNames.Length; i++)
            {




                Console.WriteLine(malePetNames[i] + " tiene " + number[i]);

            }

            int a = malePetNames.Length % 2;
            Console.WriteLine("---"+a);
            if (a == 0) {

               double t = number[(number.Length / 2)];
                   double c = number[(number.Length / 2)-1];
                Console.WriteLine(t);
                Console.WriteLine(c);

               double b = (c + t) / 2;

                Console.WriteLine("Mediana es"+b);

            }
              else {
                float b = number[number.Length / 2];




                        Console.WriteLine(b);
            }
            
            for (int i=0; i < malePetNames.Length; i++) {

               sum += (Math.Pow((number[i]-promedio),2));


                Console.WriteLine("diferencia de cuadrados" + sum);

            }
            Console.WriteLine("diferencia de cuadrados--" + sum);
            double desv = Math.Sqrt(sum / (number.Length - 1));
            Console.WriteLine("desv" + desv);
        }
    }
}
