using System;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;

            Console.WriteLine("Ingrese un numero:");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero:");
            num2 = double.Parse(Console.ReadLine());

            metodoLlamador(num1, num2);
        }
        static void metodoLlamador(double n1, double n2)
        {
            
            double Resultado = calculo (n1, n2);    // llama el metodo para hacer la Mult.
            
            Console.WriteLine(n1+n2);
            Console.WriteLine(Resultado);


        } 
        static double calculo (double a, double b)
        {
            return a * b; 
        }
    }
}