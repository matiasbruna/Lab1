using System;

namespace Propuestos3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Legajo = 0;
            int mayorLegajo = 0;
            int menorLegajo = 0;
            double Promedio = 0;
            double sumaPromedio = 0;
            double mayorPromedio = 0;
            double menorPromedio = 10;
            int Control = 1;
            int Cantidad = 0;
          
            while (Control != 0)
            {
                Legajo= PedirLegajo();
                Promedio = PedirNotas();

                if (Promedio >= mayorPromedio)
                {
                    mayorPromedio = Promedio;
                    mayorLegajo = Legajo;
                }
                if (Promedio <= menorPromedio)
                {
                    menorPromedio = Promedio;
                    menorLegajo = Legajo;
                }

                sumaPromedio = sumaPromedio + Promedio;
                Cantidad = Cantidad +1;

                Control = Salir();
            }
            
            
            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine($" Nro. Legajo mayor promedio: {mayorLegajo}");
            Console.WriteLine($" Mayor Promedio: {Math.Round(mayorPromedio,2)}");
            Console.WriteLine($"----------------------------------------");    
            Console.WriteLine($" Nro. Legajo mayor promedio: {menorLegajo}");
            Console.WriteLine($" Menor Promedio: {Math.Round(menorPromedio,2)}");
            Console.WriteLine($"-----------------------------------------");
            Console.WriteLine($" Cantidad de Alumnos: {Cantidad}");
            Console.WriteLine($" Promedio general del curso: {Math.Round(sumaPromedio/Cantidad,2)}");
            Console.WriteLine("==========================================");
        }
        
        static int PedirLegajo ()
        {
        int Legajo = 0;
        Console.Clear();
        System.Console.WriteLine("Ingrese Los el Numero de Legajo y tres Notas para Evaluar.");
        System.Console.Write("Legajo: ");
        Legajo = int.Parse(Console.ReadLine());

        return Legajo;
        }

        static double PedirNotas ()
        {
            double Not1, Not2, Not3 ;
            double Promedio = 0;
            
            
            System.Console.Write("Nota 1: ");
            Not1 = int.Parse(Console.ReadLine());
            System.Console.Write("Nota 2: ");
            Not2 = int.Parse(Console.ReadLine());
            System.Console.Write("Nota 3: ");
            Not3 = int.Parse(Console.ReadLine());

            Promedio = (Not1 + Not2 + Not3 )/3;

            return Promedio;
        }

       
        static int Salir()
        {
            int control = 0;
            System.Console.WriteLine("---------¿Desea seguir cargando?-----------");
            System.Console.WriteLine("Presione .1 Para Continuar o .0 para Salir.");
            control = int.Parse(Console.ReadLine());
            return control;
        }
    }
}