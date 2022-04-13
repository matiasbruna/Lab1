using System;

namespace tp5Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int Numero = 0;
                

                Console.Clear();

                Console.WriteLine("Ingrese un numero:");
                Numero = int.Parse(Console.ReadLine());

            }
            catch (FormatException ex)
            {   
                Console.WriteLine(ex.Message);    
                Console.WriteLine("Cuidado!!!, Ingrese un Numero.");
                
            }
        }
    }
}
