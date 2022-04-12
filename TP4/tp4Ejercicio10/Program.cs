using System;

namespace tp4Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int Milaneza = 0;
           int pizza = 0;
           int Especial = 0;
           int Mozo1 = 0;
           int Mozo2 = 0;
            int Numero =0;
            while (Numero!=0)
            {
                Console.Clear();
                Console.WriteLine("Ingrese numero de Mozo:(O ingrese 0 para SALIR)");
                Numero = int.Parse(Console.ReadLine());
                if (Numero == 1)
                {
                    Mozo1++;
                }
                if (Numero==2)
                {
                        Mozo2++;
                }
                Console.Clear();
                Console.WriteLine("Ingrese el Menu: (Ingrese Cero para Salir)");
                Console.WriteLine("1- Milaneza con Papas Fritas");
                Console.WriteLine("2- Pizzas");
                Console.WriteLine("3- Plato Especial");
                Numero = int.Parse(Console.ReadLine());


                switch (Numero)
                {
                    case 0: Console.WriteLine("Saliendo....");
                            Console.ReadKey();
                    break;
                    case: 1 Milaneza++;

                    break;
                    case: 2 pizza++;

                    break;
                    case: 3 Especial++;

                    break;


                    default: Console.WriteLine("Ingrese un numero del 1 al 3. o cero para salir.");
                    break;
                }             


            }



           
           
           
           
            
        }
    }
}