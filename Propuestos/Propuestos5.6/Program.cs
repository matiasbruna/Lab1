using System;

namespace Propuestos5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double [,] Matriz = {
                {30, 54, 25, -98 },
                {-18, 35, 2, 4,},
                {60, 125, 8, 39 },
                {30, 14, 36, 78}
            };
            Console.Clear();
            double[] Vector =  VectorDiagonal(Matriz);
            
            System.Console.Write("Vector: ");
            MostrarVector(Vector);
            
            Array.Sort(Vector);
            System.Console.Write("Vector ordenado: ");
            MostrarVector(Vector);
    
        }
        static void MostrarVector(double[]V)
        {
            for (int i = 0; i < V.Length; i++)
            {
                Console.Write($"{V[i]} ");
            }

            Console.Write("\n");
        }
        static double[] VectorDiagonal (double[,] M)
        {
            double[] V = new double[M.GetLength(0)];

            for (int i = 0; i < M.GetLength(0); i++)
            {   
                for (int j = 0; j < M.GetLength(1); j++)
                {
                     if (j == (M.GetLength(1) - 1) - i) //diagonal Invertida
                    {
                       V[i] = M[i,j];          
                    }
                }
            }
            return V;
        }
    }
}