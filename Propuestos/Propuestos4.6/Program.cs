using System;

namespace Propuestos4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int[,] Matriz = {
            
                {1,1,1,1,2,},
                {1,1,1,1,1,},
                {1,1,1,1,1,},
                {1,1,1,1,1,},
                {2,1,1,1,1,},
            };
            
            double diagPrincipal =SumaDiagonal (Matriz);
            System.Console.WriteLine($"Suma de la Diagonal Principal es: {diagPrincipal}.");
            double diagInvertida = SumaInvertida(Matriz);
            System.Console.WriteLine($"Suma de la Diagonal Invertida es: {diagInvertida}.");
            double Inter = Interseccion(Matriz);
            System.Console.WriteLine($"El Valor de la Intereseccion es: {Inter}");
            System.Console.WriteLine("---------------------------------------------------");
            System.Console.WriteLine($"La suma de las dos diagonales menos la Interseccion es : {diagPrincipal+diagInvertida - Inter}.");       
            
        }
        static double Interseccion (int [,]M)
        {
            double Valor = 0;
            int Interseccion = (M.GetLength(0)/2)+1;
            for (int i = 0; i < M.GetLength(0); i++)
            {   
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    if ( i== Interseccion & j == Interseccion )  //encuentro la posicion q corresponde a la interseccion.
                    {
                        Valor = M[i,j];         
                    }
                }
            }
            return Valor; 
        }
        static double SumaDiagonal (int [,] M)
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
        static double SumaInvertida(int[,]M)
        {
            double Suma = 0;

            for (int i = 0; i < M.GetLength(0); i++)
            {   
                for (int j = 0; j < M.GetLength(1); j++)
                {
                   if (j == (M.GetLength(1) - 1) - i)
                   {
                       Suma+= M[i,j]; 
                   }
                }
            }
            return Suma;
        }


    }
}
