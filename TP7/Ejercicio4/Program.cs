using System;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Nombres = new string[]{"Mario", "Ana","Jose","Eduardo","Norberto"};

           Console.WriteLine("Muestra el vector Original: ");
           Mostrar(Nombres);

            Console.WriteLine("Muestra el vector ordenado Alfabeticamnte: ");
            Array.Sort(Nombres);
            Mostrar(Nombres);

        }

        static void Mostrar (string[] arr)
        {
            foreach (var Nombres in arr)
            {
                Console.Write($"{Nombres}; ");
            }   
            Console.WriteLine("\n");
        } 
    }
}
