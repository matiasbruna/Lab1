using System;

namespace tp4Console_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero;
            Console.WriteLine("Escribe un Numero Entero:");
            Numero = int.Parse(Console.ReadLine());
            
            if ((Numero%2)==0)
            {
                Console.WriteLine("El Numero es Par");
            }
            else
            { 
                Console.WriteLine("El Numero es Impar");    
            }
            Console.ReadKey();           
        
        }
    }
}