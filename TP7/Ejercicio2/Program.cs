using System;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double [] Numeros = new double [5];
            double Suma = 0;
            for (int i = 0; i < Numeros.Length; i++)
            {
                Console.Clear();
                Console.WriteLine ("Ingrese un Numero:");
                Numeros[i]= double.Parse(Console.ReadLine());
            }
            
            for (int i = 0; i < Numeros.Length; i++)
            {
                Suma = Suma + Numeros[i];
            }   
           
            Console.Clear();
            Console.WriteLine($"El promedio de los numeros Ingresados es: {Suma/ Numeros.Length}");
        }
    }
}