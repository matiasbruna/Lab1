﻿using System;

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

            MostrarMatriz(Matriz);
            Console.ReadKey();

            SumaFilas = CargarSumaFilas(Matriz);
            SumaColumnas = CargarSumaColumnas(Matriz);

            MostrarVectorFilaColumna(SumaFilas, SumaColumnas);

            Array.Sort(SumaFilas);
            Array.Sort(SumaColumnas);
            
            Console.ReadKey();

            MostrarVectorFilaColumna(SumaFilas, SumaColumnas);
            

            SumaFilaColumna(Matriz);
        }
        static void MostrarVectorFilaColumna(double[] F, double[] C)
        {
            Console.Clear();
            Console.WriteLine("--------------------------");
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
        static void SumaFilaColumna (double[,]M )
        {
            double []Filas = new double [M.GetLength(0)];
            double[] Columnas = new double [M.GetLength(1)];
            
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Filas[j]= M[i,j];
                }

                MostrarSumaFilas(Filas, i);
            }
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Columnas[j]= M[j,i];
                }

                MostrarSumaColumna(Columnas, i);
            }


        }
        static void MostrarSumaFilas (double []F, int Pos)
        {
            double SumaFila = 0;
           
            for (int i = 0; i < F.Length; i++)
            {
                SumaFila += F[i];
            }

            System.Console.WriteLine($"La suma de la fila {Pos} es: {SumaFila}.");
        }
        static void MostrarSumaColumna (double []C, int Pos)
        {
            double SumaColumna = 0;

            for (int i = 0; i < C.Length; i++)
            {
                SumaColumna += C[i];
            }
            System.Console.WriteLine($"La suma de la columna {Pos} es: {SumaColumna}.");
        }
        static void MostrarOrdenados(double[] F,double[] C)
        {
            Array.Sort(F);
            foreach (var item in F)
            {
                System.Console.Write($"{item}, ");
            }
            Array.Sort(C);
            foreach (var item in C)
            {
                System.Console.Write($"{item}, ");
            }

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

    }
}