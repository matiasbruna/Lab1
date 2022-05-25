using System;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] Nombres = new string[5];
            double[] Nota = new double [5];

            
            for (int i = 0; i < Nombres.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("Ingresar Nombre: ");
                Nombres [i] = Console.ReadLine();
                Console.WriteLine("Ingresar Nota: ");
                Nota[i] = double.Parse(Console.ReadLine());
            }

            Console.Clear();

            for (int i = 0; i < Nombres.Length; i++)
            {    
                Console.WriteLine( string.Format("{0,-10} {1,-10}",Nombres[i], Nota[i]));
            } 
        }


    }
}