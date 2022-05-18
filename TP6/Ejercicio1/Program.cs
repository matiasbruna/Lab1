using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double B = 0;
            double A = 0;

            Console.Clear();
            
            Console.WriteLine("Calculo del Area de Triangulo.");
            Console.WriteLine("Ingrese la Base:");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la Altura:");
            A = double.Parse(Console.ReadLine());

            
            Console.WriteLine($" El Area es: {areaT(B,A)}");

            Console.ReadKey();

            areatriangulo(B,A);


        }

        static double  areaT (double ba , double al){     ///metodo con parametro y return.

             double  Calculo = (ba * al)/2;
            return Calculo;
        }

        static void areatriangulo (double ba , double altura){     ///Metodo Void no retorna nada.
           
            double Calculo = (ba * altura )/2 ;
            Console.WriteLine($" El Area es: {Calculo}");
          
        }


    }
}