using System;

namespace Propuestos5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double [,] Matriz = {
                {30, 54, 25, -98 },
                {-18, 35, 2, 4,},
                {60, 125, 8, 39 }
            };
            Console.Clear();
            double[,] Tras = Traspuesta(Matriz);
            MostrarMatriz(Tras);
            MostrarPromedio(Tras);
        }
        static void MostrarPromedio(double[,]M)
        {
            double Suma = 0;
            double Cantidad = M.GetLength(0)* M.GetLength(1);  ///multiplico las filas y las columnas y obtengo la cantidad.

            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Suma+= M[i,j];
                }   
            }
            
            double Promedio = Math.Round(Suma/Cantidad, 2);

            System.Console.WriteLine($"El promedio de los elementos es : {Promedio}.");
        }
        static void MostrarMatriz(double[,] M)  
        {
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Console.Write($"{M[i,j]} ");
                }
                Console.Write("\n");
            }

        }

        static double [,] Traspuesta (double[,]M)
        {
            
            double[,] MatrizT = new double [M.GetLength(1),M.GetLength(0)];
            for (int i = 0; i < M.GetLength(1); i++)
            {

                for (int j = 0; j < M.GetLength(0); j++)
                {
                    MatrizT[i,j] = M[j,i];  

                }
            }
            return MatrizT;
        }
    }
}