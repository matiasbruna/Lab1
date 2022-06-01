using System;

namespace Propuestos1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno [] alumno = new Alumno[5];

            CargarDatos (alumno);
            MostrarDatos(alumno);

        }

        static void CargarDatos (Alumno[]A)
        {
            for(int i = 0; i< A.Length;i++)
            {
            Console.Clear();
            System.Console.WriteLine("Ingresa una Materia:");
            A[i].materia = Console.ReadLine();
            System.Console.WriteLine("Ingresa numero de Legajo:");
            A[i].legajo = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa Nota:");
            A[i].nota = int.Parse(Console.ReadLine());
            }
        }
        static void MostrarDatos (Alumno[]A)
        {
                foreach (var item in A)
                {
                    System.Console.WriteLine(item.materia);
                }
        }
    }
    
    public struct Alumno
    {
        public int legajo;
        public int nota;
        public string materia;

        
    }
}