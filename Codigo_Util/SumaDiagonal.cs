static double SumaDiagonal (double[,] M)
{
    double Suma = 0;

    for (int i = 0; i < M.GetLength(0); i++)
    {   
        for (int j = 0; j < M.GetLength(1); j++)
        {
            System.Console.Write($"{M[i,j]} ");
            if (j == i )
            {
                Suma += M[i,j];          //encuentro la posicion q corresponde a la diagonal. Cuando las filas y las columnas coinciden.
            }
        }
    }
    return Suma;
}