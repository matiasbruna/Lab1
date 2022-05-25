using System;

namespace Ejercicio1   ///arrays, vectores, tablas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] nombre  = new String [] {"Matias","Guillermo","Ana Laura","Paola","Jose" };

            for (int i = 0; i < nombre.Length; i++)  
            {
                Console.WriteLine(nombre[i]);
            }
            
        }
    }
}
