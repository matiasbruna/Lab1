using System;

namespace Propuestos2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
    
         List<double> Numero = new List<double>();
         
         string  Control = "NO";   
         
         while (Control == "NO")
         {
            Console.Clear();
            System.Console.Write("Ingrese un Numero:");
            Numero.Add (double.Parse(Console.ReadLine()));

            Control = Pregunta();    //cargo la varible control con el resultado de la funcion pregunta().
         }        

            Calcular(Numero);         //a la funcion calcular le paso una lista por parametro.
        }

        static void  Calcular (List<Double> Num)  //le pase una lista por parametro.
        {

        int par = 0;
        int inpar = 0;
        double mayor = 0;
        int posMayor = 0;

        for (int i = 0; i < Num.Count; i++)   //recorro la lista. 
        {
            //obtengo el par o el impar.
            if ((Num[i]%2)==0)
            {
               par++;     
            }
            else
            {
                inpar++;
            }
            //obtengo el mayor y la pociosion.
             if (Num[i]>= mayor)
            {
               mayor = Num[i];
               posMayor = i;     
            }
        }
        // muestro todos los datos en consola.
        Console.Clear();    
        System.Console.WriteLine("--------------------------------------------------------------------");
        System.Console.WriteLine($"Cantidad de Numeros Ingresados: {Num.Count}.");
        System.Console.WriteLine("--------------------------------------------------------------------");
        System.Console.WriteLine($"El Mayor numero regristado es: {mayor} y su orden de carga es: {posMayor}.");
        System.Console.WriteLine("--------------------------------------------------------------------");
        System.Console.WriteLine($"La cantidad de Numeros Pares es: {par}.");
        System.Console.WriteLine("--------------------------------------------------------------------");
        System.Console.WriteLine($"La cantidad de Numeros Impares es: {inpar}.");
        System.Console.WriteLine("--------------------------------------------------------------------");
        
        }
        static string  Pregunta()  //Valido si quiero seguir cargando.
        {
            string respuesta = "";
            System.Console.Write("Salir: SI/NO: ");
            respuesta = Console.ReadLine();

            respuesta = respuesta.ToUpper();

            return respuesta;          
        }
    }
}