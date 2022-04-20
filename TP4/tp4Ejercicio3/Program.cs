using System;

namespace tp4Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Ingrese un Numero segun Corresponda");
            Console.WriteLine("1 : Suma");
            Console.WriteLine("2 : Resta");
            Console.WriteLine("3 : Multiplicacion");
            Console.WriteLine("4 : Division");
            int Operacion = int.Parse(Console.ReadLine());
            Console.Clear ();
            
            double Numero1 , Numero2 , Resultado;
            
            switch (Operacion)
            {
                    case 1: Console.WriteLine("--------SUMA---------");
                            Console.WriteLine("Ingrese el Primer Numero :");
                            Numero1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el Segundo  Numero :");
                            Numero2 = double.Parse(Console.ReadLine());
                            Resultado = Numero1 + Numero2;
                            Console.WriteLine($"La Suma es : {Resultado} "); 
                            Console.ReadKey();
                    break;

                    case 2:Console.WriteLine("--------RESTA---------"); 
                            Console.WriteLine("Ingrese el Primer Numero :");
                            Numero1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el Segundo  Numero :");
                            Numero2 = double.Parse(Console.ReadLine());
                            Resultado = Numero1 - Numero2;
                            Console.WriteLine($"La Resta es : {Resultado} "); 
                            Console.ReadKey();
                    break;

                    case 3: Console.WriteLine("--------MULTIPLICACION---------");
                            Console.WriteLine("Ingrese el Primer Numero :");
                            Numero1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el Segundo  Numero :");
                            Numero2 = double.Parse(Console.ReadLine());
                            Resultado = Numero1 * Numero2;
                            Console.WriteLine($"La Multiplicacion es : {Resultado} "); 
                            Console.ReadKey();
                    break;

                    case 4: Console.WriteLine("--------DIVISION---------");
                            Console.WriteLine("Ingrese el Primer Numero :");
                            Numero1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el Segundo  Numero :");
                            Numero2 = double.Parse(Console.ReadLine());
                            Resultado = Numero1 / Numero2;
                            Console.WriteLine($"La Division es : {Resultado} "); 
                            Console.ReadKey();
                    break;
                default: Console.WriteLine("Usted ingreso un valor incorrecto");
                    break;
            }


        }
    }
}
