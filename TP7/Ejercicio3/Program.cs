using System;

namespace Ejercicio3
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
            Numeros[i] = i;                
            }
            
            Console.Clear();

            for (int i = 0; i < Numeros.Length; i++)
            { 
            Console.WriteLine (Numeros[i]);               
            }            

        }
    }
}