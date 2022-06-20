//retorna la interseccion de una matriz , siempre que sea cuadrada y filas y columnas impar mayor o igual a 3.

static double Interseccion (int [,]M)
{
    double Valor = 0;
    int Interseccion = (M.GetLength(0)/2)+1;
    for (int i = 0; i < M.GetLength(0); i++)
    {   
        for (int j = 0; j < M.GetLength(1); j++)
        {
            if ( i== Interseccion & j == Interseccion )
            {
                Valor = M[i,j];          //encuentro la posicion q corresponde a la interseccion.
            }
        }
    }
    return Valor; 
}