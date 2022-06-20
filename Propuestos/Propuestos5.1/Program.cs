using System;

namespace Propuestos5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int Tamaño = ValidaNumero();
            
            double[] Vector = new double[Tamaño];
            
            CargarVector(Vector);

            Console.Clear();

            foreach (var item in Vector)
            {
                System.Console.WriteLine(item);
            }

            MostrarParImpar(Vector);

        }
        static void MostrarParImpar(double[]V)
        {
            int Par = 0;
            int Impar = 0;
            for (int i = 0; i < V.Length; i++)
            {
                if ((V[i]%2) == 0)
                {
                    Par++;
                }
                else
                {
                    Impar++;
                }
            }
            System.Console.WriteLine($"Cantidad de numeros pares : {Par}.");
            System.Console.WriteLine($"Cantidad de numeros Impares: {Impar}.");

        }
        static double[] CargarVector(double[]V)
        {
            double []V1 = new double [V.Length];
            for (int i = 0; i < V.Length; i++)
            {
                V[i] = ValidaDouble();                
            }

            return V;

        }
        static double ValidaDouble()     
        {  
            Boolean Condicion = true;
            double Num = 0;         
            
            while (Condicion)
            {
                try
                {   
                    System.Console.Write("valor: ");     
                    Num = double.Parse(Console.ReadLine());
                    System.Console.Write("\n");
                    Condicion = false;
                }
                catch
                {
                    System.Console.WriteLine("Valor incorrecto!!, Ingrese un numero:");
                }       
            }                
            return Num;
        }

        static byte ValidaNumero()     
        {  
            Boolean Condicion = true;
            byte Num = 0;         
            
            while (Condicion)
            {
                try
                {   
                    System.Console.Write("Ingrese el tamaño del Vector: ");     
                    Num = byte.Parse(Console.ReadLine());
                    System.Console.WriteLine("\n");
                    if(Num > 0)
                    {
                        Condicion = false;
                    }
                    else
                    {
                        System.Console.WriteLine("El vector no puede tener tamaño cero, Ingrese un numero:");
                    }              
                }
                catch
                {
                    System.Console.WriteLine("Valor incorrecto!!, Ingrese un numero Positivo, distinto de cero:");
                }       
            }                
            return Num;
        }
    }
}