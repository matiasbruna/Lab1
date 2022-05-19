using System;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[]  nacimiento = new int [100];       //supunindo que no carga mas de 100 personas.. solo para practicar el uso de arrays..
           string [] nombre = new string [100]; 
            int cantidad = 0;

            Console.Clear();
            Console.WriteLine("¿Cuantas personas desea Cargar?, ingrese un Numero:");
            cantidad = int.Parse(Console.ReadLine());
          
           for (int i = 0; i < cantidad; i++)
           {
            Console.Clear();
            Console.WriteLine("Ingrese un Nombre:");
            nombre[i] = Console.ReadLine();
            Console.WriteLine("Ingrese su Año de Nacimiento:");
            nacimiento[i]= int.Parse(Console.ReadLine());
           }
         
            Console.Clear();
         
           for (int i = 0; i < cantidad; i++)
           {
               Console.WriteLine($"La edad de {nombre[i]}, es de: {calcularfecha(nacimiento[i])} años.");
           }
            
        }
        static int calcularfecha(int años)
        {

            int edad =  DateTime.Now.Year - años;

            return edad;
        }
    }


}