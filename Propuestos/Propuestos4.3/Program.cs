using System;

namespace Propuestos4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.Clear();
           double[,] Notas = CargarMatriz(3,5);
           MostrarMayoryMenor(Notas);
           MostrarPromedio(Notas);
        }

        static void MostrarPromedio(double[,]M)
        {
            double Suma = 0;

             for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Suma += M[i,j];
                }
            }
            
            System.Console.WriteLine($"El promedio de las general es: {Math.Round(Suma/15,2)}.");    
        }
        static void MostrarMayoryMenor(double [,] M)
        {

            double Mayor = M [0,0];
            double Menor = M [0,0];
            int [] posMenor = new int [2];
            int [] posMayor = new int [2]; 
            
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    if (M[i,j]>Mayor)
                    {
                        Mayor = M[i,j];
                        posMayor[0] = i;
                        posMayor[1] = j; 
                    }
                    if (M[i,j]< Menor)
                    {
                        Menor= M[i,j];
                        posMenor[0] = i;
                        posMenor[1] = j; 
                    }
                }
                }
            System.Console.WriteLine($"La NOTA mayor es {Mayor}, y su pocision es; [{posMayor[0]},{posMayor[1]}].");
            System.Console.WriteLine($"La NOTA menor es {Menor}, y su pocision es; [{posMenor[0]},{posMenor[1]}].");

            }
            static double[,] CargarMatriz(int F, int C)     
            {
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
                System.Console.Write($"Nota[{i}{j}] : ");
                valor = double.Parse(Console.ReadLine());
                if (valor<= 10 & valor >= 1)
                {
                Condicion = false;
                }
                else
                {
                System.Console.WriteLine("Debe ingresar un numero de 1 al 10");
                }

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