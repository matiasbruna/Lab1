using System;

namespace Parcial2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Matriz = CargaMatrizDinamica();

            Console.Clear();

            SumaCantidadYPromedio(Matriz);

            MostrarMayoYPosicion(Matriz);

            int[] VectorColumna = SumaVectorPrimeraColumna(Matriz);

            Console.Write("Vector, valores: ");
            MostrarVector(VectorColumna);

            Array.Sort(VectorColumna);

            Console.Write("Vector, valores ordenado: ");
            MostrarVector(VectorColumna);

        }
        static void MostrarVector(int[]V)
        {
            for (int i = 0; i < V.Length; i++)
            {
                Console.Write($"{V[i]} ");
            }

            Console.Write("\n");
        }
        static void SumaCantidadYPromedio (int[,]M)
        {
            double Suma = 0;
            int Cant = 0;
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    if(j != 0)    //Valido que sea no la Primera Columna.
                    {
                        Suma+= M[i,j];
                        Cant++;
                    }
                }
            }

            double Promedio = Math.Round(Suma/Cant,2); //Solo muestra 2 decimales si llega a ser Decimal el resultado.
            System.Console.WriteLine($"La suma de todos los elementos menos la primera columna es: {Suma}.");
            System.Console.WriteLine($"La cantidad de elemetos sumados es: {Cant}.");
            System.Console.WriteLine($"El Promedio de la Matriz sin la primera columna es: {Promedio}.");
        }
        static int[] SumaVectorPrimeraColumna (int[,]M)
        {
            int[] V = new int[M.GetLength(0)];

            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        V[i] = M[i,j];
                    }
                }
            }
            int suma = 0;
            for (int i = 0; i < V.Length; i++)
            {
                suma+= V[i];
            }
            System.Console.WriteLine($"La suma del Vector es: {suma}.");
            
            return V; //restorno el vector para poder Mostrarlo y ordenarlo.
        }
   
     
        static void MostrarMayoYPosicion (int[,]M)
        {
            int Mayor = M[0,0];
            int [] posMayor = new int[2];

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
                }
            }
            System.Console.WriteLine($"El mayor elemento es: {Mayor} y su Pocision es: [{posMayor[0]},{posMayor[1]}].");
           
        }
        static int[,] CargaMatrizDinamica()
        {
            Console.Clear();
           
            System.Console.WriteLine("Construir el tamaño de una Matriz:");
            System.Console.Write("Filas: ");
            int F = ValidaNumero("F");             //valido que si o si ingrese numero distinto de cero y positivo.
            System.Console.Write("\n");    
            System.Console.Write("Columnas: ");
            int C = ValidaNumero("C");             //paso por parametro un string para validar.
        
  
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
        static byte ValidaNumero(string Columna)     
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
                        if (Columna != "C") 
                        {
                            Condicion = false;
                        }
                        if(Columna == "C") ///Valido que las columnas no sean cero ni 1, sino no seria una Matriz.
                        {
                            if (Num > 1)
                            {
                                Condicion = false;
                            }
                            else
                            {
                                System.Console.WriteLine("La columna debe ser mayor a 1.");
                            }              
                            
                        }
        
                    }
                    else
                    {
                        System.Console.WriteLine("La Matriz No puede tener filas y colunas en Cero:");
                    }              
                }
                catch
                {
                    System.Console.WriteLine("Valor incorrecto!!, Ingrese un numero Entero Positivo, distinto de cero:");
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
                    System.Console.WriteLine("Valor incorrecto!!, Ingrese un Numero Entero.");
                }
            }       
            return valor ;
        }
    }
}