using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hipotenusa
{
    class Program
    {
        static void Main(string[] args)
        {
            // programa 1

            Console.WriteLine("ingrese la altura");

            double y = double.Parse((Console.ReadLine()));

            Console.WriteLine("ingrese la base");

            double x = double.Parse((Console.ReadLine()));

            double hipotenusa = Math.Sqrt((y * y) + (x * x));
                        Console.WriteLine("La hipotenusa es:  "+hipotenusa);

            double sangulo = Math.Asin(y / hipotenusa) * 180 /Math.PI;
            double eangulo = Math.Acos( y / hipotenusa) *  180/ Math.PI ;

            Console.WriteLine("Angulo1:  " +sangulo);
            Console.WriteLine("Angulo 2:  " + eangulo);


            //programa 2
            Console.WriteLine("ingrese la hipotenusa");

            double h = double.Parse((Console.ReadLine()));

            Console.WriteLine("ingrese el angulo");

            double a = double.Parse((Console.ReadLine()));

            double ladox = (Math.Sin(a * Math.PI / 180) * h);
            double ladoy = h * (Math.Cos(a * Math.PI / 180));


            Console.WriteLine("La componentente en x:  " + ladox);

            Console.WriteLine("La componente en y:  " + ladoy);


            Console.WriteLine("El otro angulo es :  " + (180-90-a));



            // programa 3

            Console.WriteLine("ingrese el cateto");

            double c = double.Parse((Console.ReadLine()));

            Console.WriteLine("ingrese el angulo");

            double an = double.Parse((Console.ReadLine()));

            double hipo = c/ Math.Sin(an * Math.PI / 180);
            double c1 = Math.Sqrt((hipo*hipo)-(c*c));
            Console.WriteLine("La hipotenusa:  " + hipo);

            Console.WriteLine("El cateto" +
                ":  " + c1);
            Console.WriteLine("El otro angulo es :  " + (180 - 90 - an));

        }
    }
}
