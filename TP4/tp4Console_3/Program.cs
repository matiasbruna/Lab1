using System;

namespace tp4Console_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero1, Numero2, suma ;

            Console.WriteLine("Escriba un Numero: ");
            Numero1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Escriba un Numero: ");
            Numero2 = int.Parse(Console.ReadLine());
            
            suma = Numero1 + Numero2;
            
            if ((suma %2) == 0)
            {
                Console.WriteLine($"La suma da como resultado un Numero Par = {suma}");    
            }
            else
            {
                Console.WriteLine($"La suma da como resultado un Numero Impar = {suma}");
            }
                
            Console.ReadKey();
            


        }
    }
}
