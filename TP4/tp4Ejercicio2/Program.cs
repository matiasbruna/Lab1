using System;

namespace tp4Ejercio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int Mes = 0 ;
            Console.WriteLine("Ingrese un Numero: ");
            Mes = int.Parse(Console.ReadLine ());

            switch (Mes)
            {
                case 1 : Console.WriteLine("Usted a ingresado el Mes de ENERO");
                    break;
                case 2 : Console.WriteLine("Usted a ingresado el Mes de FEBRERO");
                    break;
                case 3 : Console.WriteLine("Usted a ingresado el Mes de MARZO");
                    break;
                case 4 : Console.WriteLine("Usted a ingresado el Mes de ABRIL");
                    break;
                case 5 : Console.WriteLine("Usted a ingresado el Mes de MAYO");
                    break;
                case 6 : Console.WriteLine("Usted a ingresado el Mes de JUNIO");
                    break;
                case 7 : Console.WriteLine("Usted a ingresado el Mes de JULIO");
                    break;
                case 8 : Console.WriteLine("Usted a ingresado el Mes de AGOSTO");
                    break;
                case 9 : Console.WriteLine("Usted a ingresado el Mes de SEPTIMBRE");
                    break;
                case 10 : Console.WriteLine("Usted a ingresado el Mes de OCTUBRE");
                    break;
                case 11 : Console.WriteLine("Usted a ingresado el Mes de NOVIEMBRE");
                    break;
                case 12 : Console.WriteLine("Usted a ingresado el Mes de DICIEMBRE");
                    break;

                default:Console.WriteLine("Usted a ingresado un Valor INCORRECTO");
                break;
            }
            Console.ReadKey();

        }
    }
}