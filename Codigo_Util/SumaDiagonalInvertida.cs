static double SumaInvertida(int[,]M)
{
    double Suma = 0;

    for (int i = 0; i < M.GetLength(0); i++)
    {   
        for (int j = 0; j < M.GetLength(1); j++)
        {
            if (j == (M.GetLength(1) - 1) - i)
            {
                Suma+= M[i,j]; 
            }
        }
    }
    return Suma;
}