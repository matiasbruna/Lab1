using System;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        int [,] matriz = new int [5,5];

        CargarMatriz (matriz);
        MostrarMatriz(matriz);

        }

        static void CargarMatriz(int[,] M)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                System.Console.WriteLine($"Ingrese los valores de la Fila {i+1}:");  
                
                for (int j = 0; j < 5; j++)
                {
                    System.Console.WriteLine($"Valor {j+1}:");
                    M[i,j] = int.Parse(Console.ReadLine());

                }

            }
          
        }

        static void MostrarMatriz(int[,] M)
        {
            int suma ;
            Console.Clear();

            for (int i = 0; i < 5; i++)
            {
               
                System.Console.WriteLine($"Muestro los valores de la Fila {i+1} y resuelvo:");  
                suma = 0;
                for (int j = 0; j < 5; j++)
                {
                    System.Console.Write($"{M[i,j]}, ");
                    suma = suma + M[i,j];

                }
                Console.Write ($" = {suma}.\n");

            }
        }

    }
}