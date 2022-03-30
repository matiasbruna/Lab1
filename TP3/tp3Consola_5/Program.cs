using System;

namespace tp3Consola_5
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
        estados programa = estados.inactivo;

        Console.WriteLine(programa);

        }
    }

  enum estados {activo, inactivo, error};
}