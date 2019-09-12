using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Parcial {

    string[] names;
    double[] data;


    public Parcial(string[] _names, double[] _data) {
        data = new double[_data.Length];
        _data.CopyTo(data, 0);
        names = new string[_names.Length];
        _names.CopyTo(names, 0);
    }


    public int PrimerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double suma = 0;
        double sum = 0;
        int salida = 0;
        
        for (int i = 0; i < nombres.Length; i++) suma += notas[i];
        Console.WriteLine("suma: " + suma);
         double promedio = (suma) / (nombres.Length);
        Console.WriteLine("su promedio es: " + promedio);

        for (int i = 0; i <nombres.Length; i++)
        {

            sum += (Math.Pow((notas[i] - promedio), 2));


       

        }
        Console.WriteLine("diferencia de cuadrados--" + sum);
        double desv = Math.Sqrt(sum / (notas.Length - 1));
        Console.WriteLine("desv" + desv);
        double a = promedio + desv;

        for (int i = 0; i < nombres.Length; i++)
        {
            if ( notas [i] >= a)
            {

                salida++;

            }

        }
          


        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] SegundoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
     
        string[] salida = new string[5];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double[] desvi = new double[nombres.Length];
        double suma = 0;
        for (int i = 0; i < nombres.Length; i++) suma += notas[i];
        Console.WriteLine("suma: " + suma);
        double promedio = (suma) / (nombres.Length);
        Console.WriteLine("su promedio es: " + promedio);

        for (int i = 0; i < nombres.Length; i++)
        {
           desvi[i] = (Math.Pow((notas[i] - promedio), 2));                                 
        }



        double desvitemp = 0;
        string nombretemp = "";

        for (int i = 0; i < desvi.Length; i++)
        {
            for (int j = 0; j < nombres.Length-1; j++)
            {
            
            if ( desvi[j]< desvi[j + 1])
                {
                    desvitemp = desvi[j + 1];

                   desvi[j+1] = desvi[j ]  ;
                    desvi[j] = desvitemp; ;

                    nombretemp = nombres[j+1];

                   nombres[j + 1] = nombres[j];
                   nombres[j] = nombretemp;

               }

          }
        }

        for (int j = 0; j < salida.Length; j++)
        {
            salida[j] = nombres[j];
        }


        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] TercerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
 

        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] CuartoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------


        //- Arriba de esta línea va su código --------
        return salida;
    }

    public List<string> TercerPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
       double suma = 0;
        double sum = 0;
        for (int i = 0; i < nombres.Length; i++) suma += notas[i];
        double promedio = (suma) / (nombres.Length);
        for (int i = 0; i < nombres.Length; i++) sum += (Math.Pow((notas[i] - promedio), 2));
        double desv = Math.Sqrt(sum / (notas.Length - 1));


        double a = promedio + desv;

        for (int i = 0; i < nombres.Length; i++)
        {
            if (notas[i] > a)
            {

                salida.Add(nombres[i]);

            }

        }



        //- Arriba de esta línea va su código --------
        return salida;
    }

    public List<string> CuartoPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        string nombre = "";
        for ( int i = 0; i< nombres.Length; i++)
        {
              nombre = nombres[i];
            char[] letra = new char[nombre.Length];
            for (int t = 0; t < nombre.Length; t++)
            {
                letra[t] = nombre[t];

                if (letra[t] == 'A')
                {
                    salida.Add(nombres[i]);
                    break;
                }
               



               


            }



        }


        //- Arriba de esta línea va su código --------
        return salida;
    }
}


