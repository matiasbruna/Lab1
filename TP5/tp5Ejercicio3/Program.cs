using System;

namespace tp5Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
            int Numero = int.MaxValue;

            Console.Clear();  
            
            Console.WriteLine($" {Numero} es: ");

            Numero++;

            Console.WriteLine($" {Numero} es: ");
            
            

            }
            
            catch (OverflowException ex)
            {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Varible Desbordada.");
            }
        }

    }
}