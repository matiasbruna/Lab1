using System;

namespace tp4Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int Numero = 0;
        double Contador = 0;
        int cantidad = 0; 
        int primos = 0;
        int noPrimos = 0; 

        Console.Clear();
        Console.WriteLine("Ingrasa la cantidad de Numeros para evaluar");
        cantidad = int.Parse(Console.ReadLine());
        
        for (int j = 0 ;j< cantidad;j++)
        {

          Console.Clear();
          Console.WriteLine("Ingrese un Numero: ");
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
            noPrimos ++;
                                      
          }
          else
          {
            primos++;
          }
          Contador = 0;
        } 
            Console.Clear();
          Console.WriteLine($"Se enconstraron {primos} numeros Primos y {noPrimos} no Primos.");

        }
    }
}