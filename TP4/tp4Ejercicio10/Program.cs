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
            int Numero = 1;
           
           Console.Clear();

            while (Numero!=0)
            {
                Console.Clear();
                Console.WriteLine("Ingrese numero de Mozo:");
                Console.WriteLine("------------------------");
                Console.WriteLine("0- Salir");
                Console.WriteLine("1- Mozo n°1");
                Console.WriteLine("2- Mozo n°2");
                Console.WriteLine("------------------------");
                Numero = int.Parse(Console.ReadLine());
                
                switch (Numero)
                {
                    case 0:
                    break;
                    case 1: Mozo1++;
                    break;
                    case 2: Mozo2++;
                    break;
                    default: Console.WriteLine("¡¡¡Ingrese 1 o 2!!!!");
                    Console.ReadKey();
                    break;
                }
                  
             if (Numero != 0)         //Valida Para salir del Bucle
            {
                if (Numero==1 || Numero ==2)    //valida si ingresan un numero distinto de 1 o 2
                {    
                Console.Clear();
                Console.WriteLine("Ingrese el Menu:");
                 Console.WriteLine("-----------------------------");
                Console.WriteLine("0- Salir.");
                Console.WriteLine("1- Milaneza con Papas Fritas.");
                Console.WriteLine("2- Pizzas.");
                Console.WriteLine("3- Plato Especial.");
                 Console.WriteLine("------------------------------");
                Numero = int.Parse(Console.ReadLine());


                switch (Numero)
                {
                    
                    case 1:                             
                            Milaneza++;                         
                    break;
                    
                    case 2:                             
                            pizza++;
                    break;

                    case 3:                             
                            Especial++;
                    break;
                    default: Console.WriteLine("Ingrese un numero del 0 al 3.");
                    Console.ReadKey();
                    break;
                }
                }    
             }
            }
            
            Console.Clear();          
            
            if (Mozo1 == Mozo2)
            {
                Console.WriteLine("Ambos Mozos sirvieron la misma cantidad de Platos");
            }
            if (Mozo1 > Mozo2)
            {
                Console.WriteLine("El mozo que mas Platos sirvio es: Mozo 1");    
            }
            if (Mozo1 < Mozo2)
            {
                Console.WriteLine("El mozo que mas Platos sirvio es: Mozo 2");    
            }
            
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Cantidad de platos servidos : {Milaneza + pizza + Especial} ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Cantidad de Platos del menu n°1: {Milaneza}");
            Console.WriteLine($"Cantidad de Platos del menu n°2: {pizza}");
            Console.WriteLine($"Cantidad de Platos del menu n°1: {Especial}");
            Console.WriteLine("----------------------------------------------");
        }
    }
}