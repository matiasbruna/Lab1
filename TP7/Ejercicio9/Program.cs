using System;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        int [,] matriz = new int [3,3];

        CargarMatriz (matriz);
        MostrarMatriz(matriz);

        }

        static void CargarMatriz(int[,] M)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                System.Console.WriteLine($"Ingrese los valores de la Fila {i+1}:");  
                
                for (int j = 0; j < 3; j++)
                {
                    System.Console.WriteLine($"Valor {j+1}:");
                    M[i,j] = int.Parse(Console.ReadLine());

                }

            }
          
        }

        static void MostrarMatriz(int[,] M)
        {   
            int suma = 0;
            int mayor = 0;
            int menor = 1000000000;

            Console.Clear();
            System.Console.WriteLine($"Muestro Matriz y resuelvo:");
           
            for (int i = 0; i < 3; i++)
            {
               
                for (int j = 0; j < 3; j++)
                {
                    System.Console.Write($"{M[i,j]} ");
                    
                    suma = suma + M[i,j];
                   
                    if (M[i,j] >= mayor )
                    {
                      mayor = M[i,j];      
                    }
                    if (M[i,j] <= menor )
                    {
                        menor = M[i,j];
                    }
                }
                Console.Write ($"\n");
                        
            }
            System.Console.WriteLine($"La suma de todos los elementos es: {suma}.");
            System.Console.WriteLine($"El mayor elemento es: {mayor}.");
            System.Console.WriteLine($"El menor elemento es: {menor}.");
        }

    }
}