using System;

namespace tp4Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero = 0;
            long Factorial = 0;
            
            Console.Clear();
            Console.WriteLine("Ingrese el Numero a Factoriar:");
            Numero = int.Parse(Console.ReadLine());
            
            Factorial = Numero;

            for (int i = 1; i < Numero; i++)
            {
                 Factorial = Factorial * i;
            }

            Console.WriteLine($"El factorial del Numero {Numero} es: {Factorial}");
        }
    }
}