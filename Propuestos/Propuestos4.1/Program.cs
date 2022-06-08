using System;

namespace Propuestos4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Fila = 3;
            int Columna = 3;
           
            double [,] Matriz = new double [Fila, Columna];
            double [] SumaFilas;
            double [] SumaColumnas;
            Console.Clear();

            Matriz = CargarMatriz(Fila, Columna);

            Console.Clear();

            SumaFilas = CargarSumaFilas(Matriz);
            SumaColumnas = CargarSumaColumnas(Matriz);

            Console.WriteLine("Resultado:");

            MostrarVectorFilaColumna(SumaFilas, SumaColumnas);

            Array.Sort(SumaFilas);     //ordena el vector de las filas 
            Array.Sort(SumaColumnas);   //ordena el vector de la columnas.
            
            Console.WriteLine("Resultado Ordenado:");

            MostrarVectorFilaColumna(SumaFilas, SumaColumnas);
            
        }
        static void MostrarVectorFilaColumna(double[] F, double[] C)
        {
            
            Console.WriteLine("------------------------------------");
             Console.WriteLine("Suma de cada Fila:");
            foreach (var item in F)
            {
                Console.Write($"{item}, ");
            }
            Console.Write("\n");
            Console.WriteLine("Suma de cada Columna:");
            foreach (var item in C)
            {
                Console.Write($"{item}, ");
            }
            Console.Write($"\n");
            System.Console.WriteLine("-----------------------------------");


        }
        static double[] CargarSumaFilas(double [,] M)
        {
            double [] SumaFilas = new double[M.GetLength(0)];
            double Suma = 0;

            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Suma += M[i,j];
                }

                SumaFilas[i]= Suma;
                Suma = 0;
            }
            return SumaFilas;
        }
        static double[] CargarSumaColumnas(double [,] M)
        {
            double [] SumaColumnas = new double[M.GetLength(1)];
            double Suma = 0;

            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Suma += M[j,i];
                }

                SumaColumnas[i]= Suma;
                Suma = 0;
            }
            return SumaColumnas;
        }
        static double[,] CargarMatriz(int F, int C)
        {
            double[,] M = new double[F,C];

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

    }
}