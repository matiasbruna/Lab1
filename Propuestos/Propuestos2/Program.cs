using System;

namespace Propuestos2
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int lunes =0, martes=0, miercoles=0,jueves=0 , viernes=0 ,sabado=0,domingo=0 ;
            
            int NumeroEmpleado = 1;
            int NumeroSemana = 1;
          
            double mejorVenta = 0;
           
            string mejorVendedor = "";
            double mejorDia = 0;
            int cantSusana = 0;
            int cantMatias = 0;
            int cantGuillermo = 0;
          
            double venta = 0;

            Console.Clear();

            while (NumeroEmpleado != 0)
            {
                
            

            Console.WriteLine("Ingrese el Numero de Empleado:");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("0- Salir.");
            Console.WriteLine("1- Susana.");
            Console.WriteLine("2- Matias.");
            Console.WriteLine("3- Guillermo.");
            Console.WriteLine("-------------------------------");
            
            NumeroEmpleado = int.Parse(Console.ReadLine());

            if (NumeroEmpleado != 0)
            {
            Console .Clear();
            Console.WriteLine("Ingrese el Numero de la Semana");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("0- Salir.");
            Console.WriteLine("1- Lunes.");
            Console.WriteLine("2- Martes.");
            Console.WriteLine("3- Miercoles.");
            Console.WriteLine("4- Jueves.");
            Console.WriteLine("5- Viernes.");
            Console.WriteLine("6- Sabado.");
            Console.WriteLine("7- Domingo.");
            Console.WriteLine("-------------------------------");
            
            NumeroSemana = int.Parse(Console.ReadLine());
            Console.Clear();
            if (NumeroSemana!=0)
            {
            Console.WriteLine("Ingrese el Valor de la Venta:");
            Console.WriteLine("-------------------------------");
            
            venta = double.Parse(Console.ReadLine());
            Console.Clear();
            }


            switch (NumeroEmpleado)
            {
                case 0:
                break;
                case 1:
                    
                    if (mejorVenta < venta)
                    {
                        mejorVenta = venta;
                        
                        cantSusana++;
                        mejorDia = NumeroSemana;
                    }
                

                break;
                case 2:
                     if (mejorVenta < venta)
                    {
                        mejorVenta = venta;
                       
                        cantMatias++;
                        mejorDia = NumeroSemana;
                    }


                break;
                case 3:
                     if (mejorVenta < venta)
                    {
                        mejorVenta = venta;
                       
                        cantGuillermo++;
                        mejorDia = NumeroSemana;
                    }
                


                break;
                default:Console.WriteLine("Ingrese un Numero Del 0 al 3.");
                Console.ReadKey();
                break;
            }
            
            switch (NumeroSemana)
            {
                case 0:
                break;
                case 1:lunes++;
                break;
                case 2: martes++;
                break;
                case 3: miercoles++;
                break;
                case 4: jueves++;
                break;
                case 5: viernes++;
                break;
                case 6: sabado++;
                break;
                case 7: domingo++;
                break;
                default: Console.WriteLine("Ingrese un Numero del 0 al 7.");
                        Console.ReadKey();
                break;
            }
                

            }
            }
            
            //saber que dia  de la semana se vendio mas 
            int valorsemana = 0;
            String diaSemana = "";
            for(int i = 0 ; i<7;i++)
            {
                
                switch (i)
                {
                    case 0:
                    break;
                    case 1: if (lunes > valorsemana){valorsemana = lunes;diaSemana = "LUNES";}
                    break;
                    case 2: if (martes > valorsemana){valorsemana = martes;diaSemana= "MARTES";}
                    break;
                    case 3: if (miercoles > valorsemana){valorsemana = miercoles;diaSemana= "MIERCOLES";}
                    break;
                    case 4: if (jueves > valorsemana){valorsemana = jueves;diaSemana= "JUEVES";}
                    break;
                    case 5: if (viernes > valorsemana){valorsemana = viernes;diaSemana= "VIERNES";}
                    break;
                    case 6: if (sabado > valorsemana){valorsemana = sabado;diaSemana= "SABADO";}
                    break;
                    case 7: if (domingo > valorsemana){valorsemana = domingo;diaSemana= "DOMINGO";}
                    break;
                    default: 
                     break;
                 }
            }
            ///saber quien vendio mas 
            if (cantSusana > cantMatias & cantSusana> cantGuillermo)     
            {
                mejorVendedor= "SUSANA"; 
            }
            if (cantSusana < cantMatias & cantMatias > cantGuillermo)     
            {
                mejorVendedor= "MATIAS"; 
            }
            if (cantSusana < cantGuillermo & cantMatias < cantGuillermo)     
            {
                mejorVendedor= "GUILLERMO"; 
            }
            
            ///muestro todos los datos.

            Console.Clear();
            Console.WriteLine($"Vendedor con mayor cantidad de Ventas: {mejorVendedor}.");
            Console.WriteLine($"Cantidad de Ventas: {cantSusana + cantMatias + cantGuillermo}");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Dia de la venta con mayor Importe: {mejorDia}");
            Console.WriteLine($"Dias de mayor Ventas: {diaSemana}.");
            Console.WriteLine($"Importe de la Mayor venta: {mejorVenta}.");
        }
       
            
            


        
    }
}