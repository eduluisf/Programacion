using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {

            int c = int.Parse(Console.ReadLine());
           double Tarifa = c / 828116;

           if (Tarifa < 2)
            { Console.WriteLine("Su tarifa es A");   }

           else if (Tarifa > 2 && Tarifa <= 4)
            {  Console.WriteLine("Su tarifa es B"); }

           else
           
            { Console.WriteLine("Su tarifa es C");}




            if (Tarifa < 2)
            { Console.WriteLine("Su tarifa es A y su cuota moderadora es $ 3200"); }

            else if (Tarifa > 2 && Tarifa <= 5)
            { Console.WriteLine("Su tarifa es B: $ 12700"); }

            else

            { Console.WriteLine("Su tarifa es C : $33500"); }








        }
    }
}