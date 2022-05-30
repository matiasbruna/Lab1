using System;

namespace Propuestos3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int Cantidad = 0;
         List<double> Numero = new List<double>();
         string  Control = "NO";   
         while (Control == "NO")
         {
            Console.Clear();
            System.Console.Write("Ingrese un Numero:");
            Numero.Add (double.Parse(Console.ReadLine()));
            Cantidad++;
            Control = Pregunta();
         }        

         Calcular(Numero);
        }
        static void  Calcular (List<Double> Num)
        {

        int par = 0;
        int inpar = 0;
        int primo = 0;
        int noprimo = 0;
        double mayor = 0;
        double menor = 10000000000000000;
        int posMayor = 0;
        int posMenor = 0;
        double suma = 0;

        for (int i = 0; i < Num.Count; i++)
        {
            if ((Num[i]%2)==0)
            {
               par++;     
            }
            else
            {
                inpar++;
            }
            if(EsPrimo(Num[i]))
            {
                
                primo++; // es primo
            }
            else
            {
                noprimo++; //No es primo

            }
            if (Num[i]>= mayor)
            {
               mayor = Num[i];
               posMayor = i;     
            }
            if (Num[i]< menor)
            {
                menor = Num[i];
                posMenor = i;
            }

            suma = suma + Num[i];

        }
        
        Console.Clear();    
        System.Console.WriteLine("---------------------------------------------------");
        System.Console.WriteLine($"Cantidad de Numeros Ingresados: {Num.Count}.");
        System.Console.WriteLine("---------------------------------------------------");
        System.Console.WriteLine($"La cantidad de Numeros Pares es: {par}.");
        System.Console.WriteLine("---------------------------------------------------");
        System.Console.WriteLine($"La cantidad de Numeros Impares es: {inpar}.");
        System.Console.WriteLine("---------------------------------------------------");
        System.Console.WriteLine($"La cantidad de Numeros Primos es: {primo}.");
        System.Console.WriteLine("---------------------------------------------------");
        System.Console.WriteLine($"La cantidad de Numeros No Primos es: {noprimo}.");
        System.Console.WriteLine("---------------------------------------------------");
        System.Console.WriteLine($"El Mayor numero regristado es: {mayor} y su orden de carga es: {posMayor}.");
        System.Console.WriteLine("---------------------------------------------------");
        System.Console.WriteLine($"El Menor numero registrado es: {menor} y su orden de carga es: {posMenor}.");
        System.Console.WriteLine("---------------------------------------------------");
        System.Console.WriteLine($"El Promedio de todos los numeros ingresados es: {Math.Round(suma/Num.Count, 2)}.");
        System.Console.WriteLine("---------------------------------------------------");
        
        }

        static bool EsPrimo(double numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if((numero % i) == 0)
                {
                  
                    return false;
                }
            }
            return true;
        }

        static string  Pregunta()
        {
            string respuesta = "";
            System.Console.Write("Salir: SI/NO: ");
            respuesta = Console.ReadLine();

            respuesta = respuesta.ToUpper();

            return respuesta;          
        }
    }
}