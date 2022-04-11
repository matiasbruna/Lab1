using System;

namespace tp4Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int Numero = 0;
          double Contador = 0;  

          Console.Clear();
          Console.WriteLine("Ingrese un Numero para saber si es primo");
          Numero = int.Parse(Console.ReadLine());

          for (int i = 1; i <= Numero  ; i++)
          {
           if (Numero % i  == 0)
           {
           Contador ++;    
           }          
          }
          if (Numero == 1)
          {
            Contador = Contador +1;
          }
          if (Contador!= 2)
          {
            Console.WriteLine($"El Numero {Numero} , no es Primo");
                                      
          }
          else
          {
            Console.WriteLine($"El numero {Numero} si es Primo.");  
          }
          

        }
    }
}