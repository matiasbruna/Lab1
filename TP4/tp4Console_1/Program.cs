using System;

namespace MyApp // Note: actual namespace depends on the project name.
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