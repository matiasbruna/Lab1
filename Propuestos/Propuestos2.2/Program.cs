using System;

namespace Propuestos2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Grupos Gp1 = new Grupos();


            CargarDatos(Gp1);
            Console.Clear();
            System.Console.WriteLine(Gp1.getNombre());
            for (int i = 0; i < 5; i++)
            {
            System.Console.WriteLine(Gp1.getEdad(i));
            System.Console.WriteLine(Gp1.getSexo(i));
            
                
            }

        }
        ////falta meter todos los calculos en la clase Grupos para calcular segun pide el ejercicio. 
        //y tambien el resumen final.. queda bastante trabajo...

        static void  CargarDatos(Grupos G)    // el objeto por parametro.
        {
            
            Console.Clear();
            System.Console.Write("Ingrese el nombre del Grupo: "); //carga el nombre 
            G.setNombre(Console.ReadLine());          

            int edad;
            string sexo;
            for (int i = 0; i < 5; i++)     //itera 5 veces para cargar las edaddes y sexos de cada uno.
            {
            Console.Clear();
            System.Console.WriteLine($"Integrante n°{i+1}.");
            System.Console.Write("Ingrese una edad: ");
            
            edad = int.Parse(Console.ReadLine());
            G.setEdad(edad,i);

            System.Console.Write("Ingrese un sexo M/F: ");
            
            sexo = Console.ReadLine();
            G.setSexo(sexo,i);      

            }
            



        }

    }
    public class Grupos 
    {
        private string nombre = "";
        private int[] edad = new int[5] ;
        private string[] sexo = new string[5];


        public void setSexo (string Sexo, int val)
        {
            this.sexo[val]= Sexo.ToUpper();
        }   
        public void setNombre (string Nombre)
        {
            this.nombre = Nombre;
        }   

        public void setEdad (int Edad, int val)
        {
            this.edad[val]= Edad;
        }   

        public int getEdad (int val)
        {

            return edad[val]; 
        }
        public string getSexo(int val)
        {
            return sexo[val];
        }
        public string getNombre ()
        {
            return nombre;
        }

    }


}