using System;

namespace tp4Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double Suma = 0 ;
            
            for (int i = 0; i < 15; i++)
            {
            Console.Clear();    
            Console.WriteLine("Ingrese Un Numero "); 
            Suma = Suma + int.Parse(Console.ReadLine());   
            }
            
            if (Suma == 0)
            {
                Console.WriteLine("NO se puede Hacer el Promedio de Cero (0)");
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"El promedio es: {Suma /15}");
            }
        
        }
    }
}