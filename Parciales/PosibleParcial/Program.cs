using System;

namespace Posible_parcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Mariz = CargaMatrizDinamica();

            int[] V = SumaFilas(Mariz);

            Console.Clear();
            Console.Write("Vector: ");
            MostrarVector(V);
            Array.Sort(V);
            Console.Write("Vector ordenado: ");
            MostrarVector(V);
            MostrarPar(V);
            MostrarMayorMenorYPosicion(Mariz);
            Promedio(Mariz);

        }
        static void MostrarVector(int[]V)
        {
            for (int i = 0; i < V.Length; i++)
            {
                Console.Write($"{V[i]} ");
            }

            Console.Write("\n");
        }
        static int[] SumaFilas(int[,]M)
        {
            int[] V = new int[M.GetLength(0)];
            int Suma = 0;
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Suma+= M[i,j];
                }
                V[i] = Suma;
                Suma = 0;
            }
            return V;
        }
        static void MostrarPar(int[]V)
        {
            int Par = 0;
            for (int i = 0; i < V.Length; i++)
            {
                if ((V[i]%2) == 0)
                {
                    Par++;
                }
            }
            System.Console.WriteLine($"Cantidad de numeros pares : {Par}.");
        }
        static void MostrarMayorMenorYPosicion (int[,]M)
        {
            int Mayor = M[0,0];
            int Menor = M[0,0];
            int [] posMayor = new int[2];
            int [] posMenor = new int[2];

            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    if (M[i,j] > Mayor)
                    {
                        Mayor = M[i,j];
                        posMayor[0] = i;
                        posMayor[1] = j;
                    }
                    if (M[i,j]< Menor)
                    {
                        Menor = M[i,j];
                        posMenor[0] = i;
                        posMenor[1] = j;
                    }
                }
            }
            System.Console.WriteLine($"El mayor elemento es: {Mayor} y su Pocision es: [{posMayor[0]},{posMayor[1]}].");
            System.Console.WriteLine($"El menor elemento es: {Menor} y su Pocision es: [{posMenor[0]},{posMenor[1]}].");
        }
        static void Promedio (int[,]M)
        {
            double Suma = 0;
            int Cantidad = M.GetLength(0) * M.GetLength(1);
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Suma+= M[i,j];   
                }
            }
            double Promedio = Math.Round(Suma/Cantidad,2);

            System.Console.WriteLine($"El promedio de la Matriz es: {Promedio}");
        }
        static int[,] CargaMatrizDinamica()
        {
            Console.Clear();
           
            System.Console.WriteLine("Construir el tamaño de una Matriz:");
            System.Console.Write("Filas: ");
            int F = ValidaNumero();             //valido que si o si ingrese numero distinto de cero y positivo.
            System.Console.Write("\n");    
            System.Console.Write("Columnas: ");
            int C = ValidaNumero();
        
  
            Console.Clear();
            
            int[,] M = new int[F,C];
            System.Console.WriteLine("Ingrese los valores para cargar la matriz:");
            
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {                   
                    M[i,j] = ValidaValor();   //Valido que sea un numero y no una letra o un valor vacio.
                }
            }
        
            return M; 

        }
        static byte ValidaNumero()     
        {  
            Boolean Condicion = true;
            byte Num = 0;         
            
            while (Condicion)
            {
                try
                {        
                    Num = byte.Parse(Console.ReadLine());
                    if(Num > 0)
                    {
                        Condicion = false;
                    }
                    else
                    {
                        System.Console.WriteLine("La Matriz No puede tener filas y colunas en Cero:");
                    }              
                }
                catch
                {
                    System.Console.WriteLine("Valor incorrecto!!, Ingrese un numero Positivo, distinto de cero:");
                }       
            }                
            return Num;
        }
        static int ValidaValor()     
        {
            
            Boolean Condicion = true;
            int valor = 0;        
            while (Condicion)
            {
                try
                {
                    Console.Write("Valor: ");
                    valor = int.Parse(Console.ReadLine());
                 
                    Condicion = false;
                }
                catch
                {
                    System.Console.WriteLine("Valor incorrecto!!, Ingrese un Numero.");
                }
            }       
            return valor ;
        }
    }
}