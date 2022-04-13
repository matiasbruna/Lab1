
using System;

namespace tp5Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           try
           {
               int Valor1 = 0;
               int Valor2 = 0;

                Console.Clear();
                
                Console.WriteLine("Ingrese un Numero:");
                Valor1 = int.Parse(Console.ReadLine());

                
                Console.WriteLine("Ingrese un Numero:");
                Valor2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"La division es: {Valor1 / Valor2}");


           }
           catch (DivideByZeroException ex)
           {
               Console.WriteLine(ex.Message);
                Console.WriteLine("Cuidado!!!, estas dividiendo por Cero (0)");

           }
            catch (FormatException ex)
           {
               Console.WriteLine(ex.Message);
                Console.WriteLine("Cuidado!!!, Formato Incorrecto");
           }
                      catch (Exception ex)
           {
               Console.WriteLine(ex.Message);
                Console.WriteLine("Mensaje de exepcion.");
           }
            finally
            {
                Console.WriteLine("Este Bloque de codigo se ejecuta seimpre.");


            }


        }
    }
}