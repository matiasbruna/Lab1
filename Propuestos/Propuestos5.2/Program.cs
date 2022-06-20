using System;

namespace Propuestos5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int[] V1 = {31, 44, 66, 76};
            int[] V2 = {87, 93, 22, 11};

            SumaVector(V1, V2);        
          

        }
        static void OrdenaryMostrar(int[]V)
        {
            Array.Sort(V);

            for (int i = 0; i < V.Length; i++)
            {
                System.Console.WriteLine(V[i]);
            }

        }
        static void SumaVector (int[]V1, int[]V2)
        {
            int[]V3 = new int [V1.Length];

            for (int i = 0; i < V3.Length; i++)
            {
                V3[i] = V1[i] + V2[i];
            }

            System.Console.WriteLine("Vector :");           
            for (int i = 0; i < V3.Length; i++)
            {
                System.Console.WriteLine(V3[i]);
            }
          
            System.Console.WriteLine("-----");
            System.Console.WriteLine("Vector ordenado:");
            OrdenaryMostrar(V3);
            System.Console.WriteLine("-----");
        }
    }
}