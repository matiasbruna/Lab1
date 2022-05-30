using System;

namespace Propuestos3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Dia = 1;
            int Mes = 1;
            Console.Clear();
            Console.WriteLine("Ingrese una Fecha para evaluar: ");
            Console.Write("Dia: ");
            Dia = int.Parse(Console.ReadLine());
            Console.Write("Mes: ");
            Mes = int.Parse(Console.ReadLine());

            if (Dia >= 21 && Mes == 12|| Mes== 01 || Mes == 02 || Mes == 03 && Dia <=20)
            {
                System.Console.WriteLine($"La fecha:{Dia}/{Mes}, pertenece a la estacion, Verano.");
            }
            if (Dia >= 21 && Mes == 03|| Mes== 04 || Mes == 05 || Mes == 06 && Dia <=20)
            {
                System.Console.WriteLine($"La fecha:{Dia}/{Mes}, pertenece a la estacion, Otoño.");
            }
            if (Dia >= 21 && Mes == 06|| Mes== 07 || Mes == 08 || Mes == 09 && Dia <=20)
            {
                System.Console.WriteLine($"La fecha:{Dia}/{Mes}, pertenece a la estacion, Invierno.");
            }
            if (Dia >= 21 && Mes == 09|| Mes== 10 || Mes == 11 || Mes == 12 && Dia <=20)
            {
                System.Console.WriteLine($" La fecha:{Dia}/{Mes}, pertenece a la estacion, Primavera.");
            }
        }
    }
}