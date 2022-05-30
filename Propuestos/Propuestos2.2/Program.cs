using System;

namespace Propuestos2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Grupos Gp1 = new Grupos();
            Grupos Gp2 = new Grupos();
            Grupos Gp3 = new Grupos();

            CargarDatos(Gp1);
            CargarDatos(Gp2);
            CargarDatos(Gp3);

            MostrarGrupos(Gp1);
            Console.ReadKey();
            
            MostrarGrupos(Gp2);
            Console.ReadKey();

            MostrarGrupos(Gp3);
            Console.ReadKey();

            //Aca resuelvo el resumen .investigar para ponerlo dentro de una funcion .
            int mayor= 0;
            string nombreMayor = "";

            if (Gp1.getEdadMayor() > mayor)
            {
                mayor = Gp1.getEdadMayor();
                nombreMayor = Gp1.getNombre();
            }
             if (Gp2.getEdadMayor() > mayor)
            {
                mayor = Gp2.getEdadMayor();
                nombreMayor = Gp2.getNombre();
            }
             if (Gp3.getEdadMayor() > mayor)
            {
                mayor = Gp3.getEdadMayor();
                nombreMayor = Gp3.getNombre();
            }
            Console.Clear();
            System.Console.WriteLine("Resumen:");
            System.Console.WriteLine("---------------------------------------------");
            System.Console.WriteLine($"Nombre del grupo de mayor edad: {nombreMayor}.");
            System.Console.WriteLine($"Edad del mayor del Grupo: {mayor} años.");
            System.Console.WriteLine("---------------------------------------------");
            

        }
       
        static void IngrDatosPrueba(Grupos G)
        {
            G.setNombre("Los Genios");
            G.setEdad(12,0);
            G.setSexo("M",0);
             G.setEdad(15,1);
            G.setSexo("F",1);
             G.setEdad(21,2);
            G.setSexo("M",2);
             G.setEdad(14,3);
            G.setSexo("F",3);
             G.setEdad(78,4);
            G.setSexo("M",4);
  
        }

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
        static void MostrarGrupos(Grupos G)
        {
            Console.Clear();
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine($"Nombre del Gupo: {G.getNombre()}.");
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine($"Edad del mayor del grupo: {G.getEdadMayor()} Años.");
            System.Console.WriteLine($"Sexo del mayor del grupo: {G.getSexoMayor()}.");
            System.Console.WriteLine($"Orden de carga: {G.getPosMayor()+1}.");
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine($"Edad del menor del grupo: {G.getEdadMenor()} Años.");
            System.Console.WriteLine($"Sexo del menor del grupo:  {G.getSexoMenor()}.");
            System.Console.WriteLine($"Orden de Carga: {G.getPosMenor()+1}.");
            System.Console.WriteLine("---------------------------");

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
         public int getEdadMenor()
        {           
            int menor = 150;
           
            for (int i = 0; i < edad.Length; i++)
            {
                if(edad[i] < menor)
                {
                    menor = edad[i];            
                }
            }
            return menor;
        }

        public int getEdadMayor()
        {
            
            int mayor = 0;
           
            for (int i = 0; i < edad.Length; i++)
            {
                if(edad[i]>mayor)
                {
                    mayor = edad[i];
                   
                  
                }
            }
            return mayor;
        }
         public string getSexoMenor()
        {
            string menorSexo = "";
            int menor = 150;
          
            for (int i = 0; i < edad.Length; i++)
            {
                if(edad[i] < menor)
                {
                    menor = edad[i];
                    menorSexo = sexo[i];
                   
                }
            }
            return menorSexo;
        }
         public string getSexoMayor()
        {
            string mayorSexo = "";
            int mayor = 0;
          
            for (int i = 0; i < edad.Length; i++)
            {
                if(edad[i]>mayor)
                {
                    mayor = edad[i];
                    mayorSexo = sexo[i];
                   
                }
            }
            return mayorSexo;
        }
          public int getPosMenor()
        {
            int menor = 150;
            int pos = 0;
            for (int i = 0; i < edad.Length; i++)
            {
                if(edad[i] < menor)
                {
                    menor = edad[i];           
                    pos= i;
                }
            }
            return pos;
        }
         public int getPosMayor()
        {
          
            int mayor = 0;
            int pos = 0;
            for (int i = 0; i < edad.Length; i++)
            {
                if(edad[i]>mayor)
                {
                    mayor = edad[i];
                  
                    pos= i;
                }
            }
            return pos;
        }

        public string getNombre ()
        {
            return nombre;
        }
    }

}