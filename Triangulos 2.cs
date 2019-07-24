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

              Console.WriteLine("ingrese el angulo");


              double angulo1 = double.Parse(Console.ReadLine());



              double hipotenusa = Math.Sqrt((y * y) + (x * x));
              Console.WriteLine("La hipotenusa es:  " + hipotenusa);

              double sangulo = Math.Asin(y / hipotenusa) * 180 / Math.PI;
              double eangulo = Math.Acos(y / hipotenusa) * 180 / Math.PI;

              Console.WriteLine("Angulo1:  " + sangulo);
              Console.WriteLine("Angulo 2:  " + eangulo);



              double angulo3 = 180 - sangulo;
              double angulo4 = 180 - angulo1 - angulo3;
              double lado3 = (((Math.Sin(angulo1 * Math.PI / 180)) * hipotenusa) / (Math.Sin(angulo4 * Math.PI / 180) ));


              Console.WriteLine("el lado es"+lado3);


              //programa 2
              Console.WriteLine("ingrese el angulo");

              double A1 = double.Parse((Console.ReadLine()));

              Console.WriteLine("ingresw el angulo 2");

              double A2 = double.Parse((Console.ReadLine()));
              Console.WriteLine("ingrese el lado");

              double L1 = double.Parse((Console.ReadLine()));



              double A3 = 90-A1;
              double A4 = A3 - A2;

              double A5 = 90 - A4;
              Console.WriteLine("Angulo 4:  " + A4);

              double l1 = (((Math.Sin(A5 * Math.PI / 180)) *L1) / (Math.Sin(A4 * Math.PI / 180)));


              Console.WriteLine("el lado es" + l1);
           
       





            // programa 3

            Console.WriteLine("ingrese el cateto");

            double c = double.Parse((Console.ReadLine()));

            Console.WriteLine("ingrese el cateto");

            double c1 = double.Parse((Console.ReadLine()));
            Console.WriteLine("ingrese el angulo");

            double an = double.Parse((Console.ReadLine()));

            double hipo = c/ Math.Sin(an * Math.PI / 180);
            double 
                
                c2 = Math.Sqrt((Math.Pow(c,2))+(Math.Pow(c1,2))-2*c*c1*Math.Cos(an*Math.PI/180));



            Console.WriteLine("otro cateto:  " + c2);

            double An1 = Math.Acos(((Math.Pow(c1, 2)) + (Math.Pow(c2, 2)) - (Math.Pow(c, 2))) / (2 * c1 * c2)) *180/Math.PI
                ;


            Console.WriteLine("El angulo" + An1);
            double an2 = 180 - An1;
            Console.WriteLine("El otro angulo es :  " + (an2));

            double an3 = 180-an2;

            double La1 = c2  * Math.Sin(an3* Math.PI / 180);

            Console.WriteLine("El otro es :  " + (La1));

            
            


            // Programa 4             

            Console.WriteLine("ingrese el cateto");

            double VX = double.Parse((Console.ReadLine()));

            Console.WriteLine("ingrese el cateto");

            double VY = double.Parse((Console.ReadLine()));
            Console.WriteLine("ingrese el angulo");

            double CA = double.Parse((Console.ReadLine()));



            double cb = 180 - CA;


            double Ang = Math.Asin((VX * Math.Sin(cb*Math.PI/180))/(VY))*180/Math.PI;

            Console.WriteLine(cb);
            Console.WriteLine(Ang);












        }
    }
}
