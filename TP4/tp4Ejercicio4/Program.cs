using System;

namespace tp4Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto;
            int cantidad = 0 ;

            Console.Clear();
            Console.WriteLine("Ingrese la cantidad de veces que quiere ejecutar el Programa.");
            cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
            Console.Clear();
            Console.WriteLine("Ingrese una Palabra:");    
            texto = Console.ReadLine();
            
            if (texto.Length< 5)
            {
                Console.WriteLine($"La palabra: {texto}");
                Console.WriteLine($"La cantidad de caracteres es menor que 5.");

            }
            else
            {
                Console.WriteLine($"La palabra: {texto}");
            }
            
            Console.ReadKey();

            }
            
        }  



    }
}