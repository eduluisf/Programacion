using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @case
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Ingreese1 si es dep 2 si es ind");
            int entrada = int.Parse(Console.ReadLine());

            Console.WriteLine(" Ingreese su salario");
            double Salario = int.Parse(Console.ReadLine());

            double Deducciones = Salario * 0.4;


                           




            switch (entrada)
            {

                
            


            
             case 1:

                    double Des = Salario - (Deducciones * 0.08);

                    Console.WriteLine(" Su salario mensual es " + Des + " Su salario anual con prima " + (Des * 12 + Salario));


                    break;




                 case 2 :


                    double Desc = (Deducciones * 0.16);
                    double Des1 = (Deducciones* 0.125);
                    double ARL;


                    Console.WriteLine("ingrese su acitivdad");

                    int entrada1 = int.Parse(Console.ReadLine());

               

                    double SalarioInd = Salario -  Desc - Des1;


                    switch(entrada1 )
                    {



                       case 1: 
                        ARL = Deducciones * 0.005;


                        Console.WriteLine("Su Salario es" + (SalarioInd-ARL) + "Su Salario Anual es " + ((SalarioInd - ARL) * 12));
                            break;






                     case 2:
                    



                        ARL = Deducciones * 0.0052;


                        Console.WriteLine("Su Salario es" + (SalarioInd - ARL) + "Su Salario Anual es " + ((SalarioInd - ARL) * 12));
                                 break;
                    
                     case 3:
                    
                        ARL = Deducciones * 0.02436;



                        Console.WriteLine("Su Salario es" + (SalarioInd - ARL) + "Su Salario Anual es " + ((SalarioInd - ARL) * 12));
                                 break;


                      case 4:
                    
                        ARL = Deducciones * 0.04350;



                        Console.WriteLine("Su Salario es" + (SalarioInd - ARL) + "Su Salario Anual es " + ((SalarioInd - ARL) * 12));


                                 break;
                       case  5:
                    
                        ARL = Deducciones * 0.06960;


                        Console.WriteLine("Su Salario es" + (SalarioInd - ARL) + "Su Salario Anual es " + ((SalarioInd - ARL) * 12));

                      break;


                     }


                         break;


            }


        }
    }



}  
