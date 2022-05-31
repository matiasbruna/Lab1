using System;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string [,] matriz = {{"Fiat","Ferrari","Ford"},{"Chebrolet","Audi","Citroen"}};


            MostrarMatriz(matriz);
            
        }
        static void MostrarMatriz (string [,] M)
        {

            foreach (var item in M)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}