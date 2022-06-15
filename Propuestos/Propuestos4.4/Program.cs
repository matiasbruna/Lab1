using System;

namespace Propuestos4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] Matriz = CargarMatrizDinamica();
            
            double []  Vector = Diagonal(Matriz);

            Console.Clear();
            System.Console.Write("Variable Desordenada: ");
            foreach (var item in Vector)
            {
                System.Console.Write($"{item}, ");
            }
            System.Console.WriteLine();
            
            Array.Sort(Vector);
            System.Console.Write("Varibles Ordenadas: ");
            foreach (var item in Vector)
            {
                System.Console.Write($"{item}, ");
            }
            System.Console.WriteLine();





        }
        static double[] Diagonal (double[,] M)
        {
            double [] vector = new double[M.GetLength(0)];

            for (int i = 0; i < M.GetLength(0); i++)
            {   
                for (int j = 0; j < M.GetLength(1); j++)
                {
                     if (j == i )
                     {
                      vector[i] = M[i,j];     
                     }
                }
            }
            return vector;
        }
  

        static double[,] CargarMatrizDinamica()     
        {   
            Console.Clear();
    
            System.Console.WriteLine("Construir el tamaño de una Matriz:");
            System.Console.Write("Filas: ");
            int F = int.Parse(Console.ReadLine());
            System.Console.Write("\n");    
            System.Console.Write("Columnas: ");
            int C = int.Parse(Console.ReadLine());
            Console.Clear();
            
            double[,] M = new double[F,C];
            System.Console.WriteLine("Ingrese los valores para cargar la matriz:");
            
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {                   
                    M[i,j] = ValidaValor(i,j);
                }
            }
        
        return M; 
        }

        static double ValidaValor(int i, int j)     
        {
            
            Boolean Condicion = true;
            double valor = 0;        
                
            
            
            while (Condicion)
            {
                try
                {
                System.Console.Write($"Valor[{i}{j}] : ");
                valor = double.Parse(Console.ReadLine());
                Condicion = false;
                }
                catch
                {
                    System.Console.WriteLine("Valor incorrecto!!, Ingrese un Numero.");
                }
                
            }    
                    
            return valor ;
        }
        

        
    }
}