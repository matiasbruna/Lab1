using System;

namespace tp4Console_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Numero = new int[5];     //me parecio mas util que declarar 5 variables distintas. 
                                        //ademas practico el uso del for y el foreach .

            for(int i = 0;i<=4;i++)
            {
                Console.WriteLine("Ingrese un Numero");
                Numero[i]= int.Parse(Console.ReadLine());
                if (Numero[i]< 5)
                {
                    Numero [i]*= 3;
                }
                else
                {
                    Numero[i]+= 10;
                }
            }
            foreach (int i in Numero)
            {
              Console.WriteLine($"Resultado: {i}");  
            }
            Console.ReadKey();
        }
    }
}