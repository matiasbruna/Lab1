using System;

namespace Propuestos5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            double[,] Matriz = {
                {3, 5, 6, 34, -6},
                {12, 65, -98, 3, 6},
                {14, 1, 0, 7, 2},
                {9, 65, 12, -34, -9},
            };

            CargarVectorMostrar(Matriz);
           
        }
        static void CargarVectorMostrar (double[,]M)
        {
            double[] V = new double[M.GetLength(0)];
            int aux = M.GetLength(1)-1;
            for (int i = 0; i < M.GetLength(0); i++)
            {
                V[i] = M[i,aux];
            }

            for (int i = 0; i < V.Length; i++)
            {
                System.Console.WriteLine(V[i]);
            }

        }
    }
}