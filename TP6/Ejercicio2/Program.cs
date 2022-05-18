using System;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string Nombre = "Matias";
            
            Console.Clear();
            Console.WriteLine("Ingrese su nombre:");
            Nombre = Console.ReadLine();
            
           Console.WriteLine($" La cantidad de caracteres es: {calculo(ref Nombre)}.");


        }

        static int calculo (ref string nom)
        {
            int Cantidad = nom.Length;
            return Cantidad ;
        }
    }
}