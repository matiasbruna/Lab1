using System;

namespace Ejercicio3a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Tamaño = 0;

            Console.Clear();
            Console.WriteLine("Ingrese el tamaño del Vector: ");
            Tamaño = int.Parse(Console.ReadLine());

            double[] Numeros = new double [Tamaño];

            for (int i = 0; i < Numeros.Length; i++)
            {
            Console.Clear();
            Console.WriteLine("Ingrese un numero.: ");
            Numeros[i] = double.Parse(Console.ReadLine());                
            }
            
            Console.Clear();
            Console.WriteLine("Numeros Desordenados: ");
           
            foreach (var valor in Numeros)
            {
                Console.Write($"{valor} ");
            
            }

            Console.WriteLine("\n");
            Console.WriteLine("Numeros Ordenados :");

            Array.Sort(Numeros);          
            foreach (var valor in Numeros)
            {
                Console.Write($"{valor} ");
            }
           
            Console.WriteLine("\n");

           

        }
    }
}