static string [,] Traspuesta (string[,]M)
{
    
    string[,] MatrizT = new string [M.GetLength(1),M.GetLength(0)];
    for (int i = 0; i < M.GetLength(1); i++)
    {

        for (int j = 0; j < M.GetLength(0); j++)
        {
            MatrizT[i,j] = M[j,i];  

        }
    }
    return MatrizT;
}

//invierte filas por columnas ... ojo que el tipo de dato es string en este caso !! 
//recibe una matris y devuelve un matris cambiada.