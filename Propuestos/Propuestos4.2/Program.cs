using System;

namespace Propuestos4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            double [,] Matriz1 = CargarMatriz();
            double [,] Matriz2 = CargarMatriz();
            
            Console.Clear();

            double [,] Matriz3 = SumarMatrices(Matriz1, Matriz2);

            MostrarMatriz(Matriz1);
            Console.WriteLine("------------");
            MostrarMatriz(Matriz2);
            Console.WriteLine("------------");
            Console.WriteLine("Suma de Matriz1 y Matriz2 = ");
            Console.WriteLine("------------");
            MostrarMatriz(Matriz3);
            Console.WriteLine("------------");
            double Suma = SumaDiagonal(Matriz3);
            System.Console.WriteLine($"La suma de la diagonal es: {Suma}.");
        }
        static double[,] CargarMatriz()     
        {
            int F = 3;      //definimos las filas 
            int C = 3;      // definimos las columnas 

            double[,] M = new double[F,C];
            System.Console.WriteLine("Ingrese los valores para cargar la matriz:");
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    System.Console.Write($"Fila {i+1}, valor {j+1}: ");
                    M[i,j] = double.Parse(Console.ReadLine());
                }
            }

            return M; 
        }
         static void MostrarMatriz(double[,] M)  
        {
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(0); j++)
                {
                    Console.Write($"{M[i,j]} ");
                }
                Console.Write("\n");
            }

        }

        static double[,] SumarMatrices (double[,]M1, double[,]M2)
        {
            double [,] M3 = new double [M1.GetLength(0),M1.GetLength(1)];

            for (int i = 0; i < M3.GetLength(0); i++)
            {
                for (int j = 0; j < M3.GetLength(0); j++)
                {
                    M3[i,j] =  M1[i,j] +  M2[i,j];
                }
                
            }

            return M3;
        }
        static double SumaDiagonal (double[,] M)
        {
            double Suma = 0;

            for (int i = 0; i < M.GetLength(0); i++)
            {   
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    if (j == i )
                    {
                        Suma += M[i,j];          //encuentro la posicion q corresponde a la diagonal. Cuando las filas y las columnas coinciden.
                    }
                }
            }
            return Suma;
        }
    }
}