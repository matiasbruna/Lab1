using System;

namespace Parcial1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int Nota1 = 0;
           int Nota2 = 0;
           int Nota3 = 0;
           int nLegajo = 0;
           int MayorLegajo = 0;
           int MenorLegajo = 0;
           int Cont = 0;
           int Hombres = 0;
           int Mujeres = 0;
           int NotaMayorA6 = 0;
           int NotaMenorA6 = 0;
            int Numero = 1;
            float Promedio = 0;
            float Suma = 0;
            float SumaPromedio = 0;
            float PromedioTotal= 0;
            float MayorPromedio = 0;
            float MenorPromedio = 11 ;
           
           Console.Clear();

            while (Numero!=0)
            {
                
                Console.Clear();
                Console.WriteLine("Ingrese numero de Legajo:");
                Console.WriteLine("------------------------");
                Console.WriteLine("0- Para Salir");
                Console.WriteLine("------------------------");
                nLegajo = int.Parse(Console.ReadLine());
                Numero = nLegajo;
                Console.Clear();

                Console.WriteLine("Ingrese su Sexo:");
                Console.WriteLine("------------------------");
                Console.WriteLine("1- Masculino");
                Console.WriteLine("2- Femenino");
                Console.WriteLine("0- Para Salir");
                Console.WriteLine("------------------------");
                 
                switch (Numero)
                {
                    case 0:
                            Numero = int.Parse(Console.ReadLine());
                    break;
                    case 1:                             
                            Hombres++;                       
                    break;           
                    case 2:                             
                            Mujeres++;
                    break;
                    default: Console.WriteLine("Ingrese un numero del 0 al 3.");
                    Console.ReadKey();
                    break;
                }
                Console.Clear();
                Console.WriteLine("Ingrese 3 Notas:");
                Console.WriteLine("0- Para Salir");
                Console.WriteLine("------------------------");
                Console.WriteLine("Nota 1:");
                Nota1 = int.Parse(Console.ReadLine());
                if (Nota1 != 0)
                {
                    if (Cont < 5){ if (Nota1 >= 6){NotaMayorA6++;}else{NotaMenorA6++;}}  // cuento 5 entradas y sumo las notas menores y mayores.
                    

                     Console.WriteLine("Nota 2:");
                     Nota2 = int.Parse(Console.ReadLine());
                     if (Nota2 != 0)
                     {
                         if (Cont < 5){ if (Nota2 >= 6){NotaMayorA6++;}else{NotaMenorA6++;}}
                      

                       Console.WriteLine("Nota 3:");
                       Nota3 = int.Parse(Console.ReadLine());
                       if (Nota3!= 0)
                       {
                           if (Cont <5){ if (Nota3 >= 6){NotaMayorA6++;}else{NotaMenorA6++;} }
                           

                           Console.WriteLine("------------------------");
                           Suma = Nota1 + Nota2 + Nota3;
                           Promedio = Suma / 3;

                           if (Promedio > MayorPromedio)           ///encuentro el Mayor promedio.
                           {
                               MayorPromedio = Promedio;
                               MayorLegajo = nLegajo;             /// Guarde el Mayor Legajo.
                           }
                           if (Promedio < MenorPromedio)          ///encuentro el menor Promedio
                           {
                               MenorPromedio = Promedio;
                               MenorLegajo = nLegajo;            /// Guardo el Menor Legajo.
                           }

                       }  
                     }
                }
               
                SumaPromedio = SumaPromedio + Promedio;
                PromedioTotal = SumaPromedio / Cont;
                

                Cont++;
            }
      
            Console.Clear();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Nro. Legajo mayor promedio: {MayorLegajo}");
            Console.WriteLine($"Mayor promedio: {MayorPromedio}");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Nro. Legajo menor promedio: {MenorLegajo}");
            Console.WriteLine($"Menor promedio: {MenorPromedio}");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Cantidad de alumnos: {Cont}");
            Console.WriteLine($"Promedio general del curso: {PromedioTotal}");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("De los 5 primeros alumnos:");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Cantidad de notas igual o mayor a 6: {NotaMayorA6} Alumnos.");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Cantidad de notas igual o menor a 6: {NotaMenorA6} Alumnos.");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Cantidad de Hombres: {Hombres}");
            Console.WriteLine($"Cantidad de Mujeres:{Mujeres}");
            Console.WriteLine("----------------------------------------------");
        }
    }
}