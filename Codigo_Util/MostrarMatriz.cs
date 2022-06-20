    //muestra los valores por consola como una matriz convencional.
    
static void MostrarMatriz(double[,] M)  
{
    for (int i = 0; i < M.GetLength(0); i++)
    {
        for (int j = 0; j < M.GetLength(1); j++)
        {
            Console.Write($"{M[i,j]} ");
        }
        Console.Write("\n");
    }

}
