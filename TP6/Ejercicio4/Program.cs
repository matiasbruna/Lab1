using System;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           double num1 = 0;
           double num2 = 0;
           int operacion = 1;
            
            pedirNumeros();
            num1= double.Parse(Console.ReadLine());
            num2= double.Parse(Console.ReadLine());
            

            while (operacion != 0)
            {
            operadores();
            operacion = int.Parse(Console.ReadLine());
            
            Console.Clear();
            switch (operacion)
            {
                case 1: Console.WriteLine($"El resultado es: {Suma(num1, num2)}"); break;
                case 2: Console.WriteLine($"El resultado es: {Resta(num1,num2)}"); break;                      
                case 3: Console.WriteLine($"El resultado es: {Multiplicacion(num1,num2)}"); break;
                case 4: Division(num1,num2); break;
                case 0: operacion = 0; break;
                default: 
                
                    Console.WriteLine("Ingrese el algun numero solicitado en Pantalla");
                    Console.ReadKey();
                
                 break;
            }
            Console.ReadKey();
            }

            despedida();
                   
        }

        static void pedirNumeros()
        {
            Console.Clear();
            Console.WriteLine("----CALCULADORA----");
            Console.WriteLine("=====================");    
            Console.WriteLine("Ingrese dos Numeros:");
        }
        static void operadores ()
        {
            Console.Clear();
            Console.WriteLine("----CALCULADORA----");
            Console.WriteLine("=====================");    
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            Console.WriteLine("0. Salir");
        }


        static double Suma (double n1, double n2)
        {
            return n1 + n2;
        }
        static double Resta (double n1, double n2)
        {
            return n1 - n2;
        }
        static double Multiplicacion (double n1, double n2)
        {
            return n1 * n2;
        }
        static void Division (double n1, double n2)
        {
            if (n2 == 0 )
            {
                Console.WriteLine("No se puede realizar la division por 0");
               
                
            }
            else
            {
                Console.WriteLine($"El resultado es: {n1/n2}.");
            }
        }
        static void despedida ()
        {
            Console.Clear();
            Console.WriteLine("---GRACIAS POR UTILIZAR LA CALCULADORA :-) ---");
            Console.ReadKey();
            Console.Clear();
        }
        
        





    }
}