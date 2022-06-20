  ///carga una matriz que le pasas por parametro la fila y la columna.
//Devuelve una Matris.Pide todos los valores por consola.
static double[,] CargarMatriz(int F, int C)     
{
    double[,] M = new double[F,C];
    System.Console.WriteLine("Ingrese los valores para cargar la matriz:");
    for (int i = 0; i < M.GetLength(0); i++)
    {
        for (int j = 0; j < M.GetLength(1); j++)
        {
            System.Console.Write($"Fila {i+1}, valor {j+1}: ");
            M[i,j] = double.Parse(Console.ReadLine());
        }
    }

    return M; 
}
