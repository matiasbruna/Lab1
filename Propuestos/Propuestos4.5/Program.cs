using System;

namespace Propuestos4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();

            string [,] Nombres = CargarMatrizDinamica();

            MostrarMatriz(Nombres);

            System.Console.WriteLine("");

            string[,] Tras = Traspuesta(Nombres);

            MostrarMatriz(Tras);
          
        }

        static string [,] Traspuesta (string[,]M)
        {
            string[,] MatrizT = new string [M.GetLength(1),M.GetLength(0)];
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(0); j++)
                {
                    MatrizT[j,i]= M[i,j]; 
                }
               
            }
            return MatrizT;
        }
        static void MostrarMatriz(string[,] M)  
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
        static string[,] CargarMatrizDinamica()     
        {   
            Console.Clear();
    
            System.Console.WriteLine("Construir el tamaño de una Matriz:");
            System.Console.Write("Filas: ");
            int F = int.Parse(Console.ReadLine());
            System.Console.Write("\n");    
            System.Console.Write("Columnas: ");
            int C = int.Parse(Console.ReadLine());
            Console.Clear();
            
            string[,] M = new string[F,C];
            System.Console.WriteLine("Ingrese los Nombres para cargar la matriz:");
            
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {                   
                    M[i,j] = ValidaValor(i,j);
                }
            }
        
            return M; 
        }

        static string ValidaValor(int i, int j)     
        {
            
            Boolean Condicion = true;
            string Nombre = ".";        
                
            
            
            while (Condicion)
            {
                try
                {
                System.Console.Write($"Nombre [{i}{j}] : ");
                Nombre = Console.ReadLine();
                Condicion = false;
                }
                catch
                {
                    System.Console.WriteLine("Valor incorrecto!!, Ingrese un Nombre.");
                }
                
            }    
                    
            return Nombre;
        }

    }
}