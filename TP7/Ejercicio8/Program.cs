using System;

namespace Ejercicio8
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

            Console.Clear();
            System.Console.WriteLine($"Muestro Matriz y resuelvo:");
           
            for (int i = 0; i < 3; i++)
            {
               
                for (int j = 0; j < 3; j++)
                {
                    System.Console.Write($"{M[i,j]} ");
                    if (j == i )
                    {
                        suma = suma + M[i,j];          //encuentro la posicion q corresponde a la diagonal. Cuando las filas y las columnas coinciden.
                    }
                }
                Console.Write ($"\n");
                        
            }
            System.Console.WriteLine($"La suma de la diagonal es: {suma}.");
        }

    }
}