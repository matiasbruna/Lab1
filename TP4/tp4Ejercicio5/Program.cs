using System;

namespace tp4Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Cant  = 0;
            int Salir = 1;
            int Total = 0;
            int Menor = 10000;
            long Promedio = 0;
            
            while (Salir!= 0)
            {
                Console.Clear();
                Console.WriteLine("Ingrese un Numero (Ingrese Cero para salir)");
                Salir = int.Parse(Console.ReadLine());

                Total = Total + Salir;
                Cant++;
                
                if (Salir < Menor)
                {
                    if(Salir != 0)
                    {
                        Menor = Salir;
                    }                    
                }
            }
            if (Total == 0)
            {
            Console.WriteLine("No se puede calcular el promedio porque no se puede hacer la division por Cero");   
            } 
            else
            {
            Promedio = (Total- Menor )/(Cant-1);
            Console.Clear();
            Console.WriteLine($"El promedio de todos los Numeros ingresados, menos el Menor es: {Promedio}"); 
            Console.WriteLine($"El Numero Menor es: {Menor} ");
            }
        }
    }
}