    static double[,] CargarMatriz(int F, int C)     
    {
        double[,] M = new double[F,C];
        System.Console.WriteLine("Ingrese los valores para cargar la matriz:");
        
        for (int i = 0; i < M.GetLength(0); i++)
        {
            for (int j = 0; j < M.GetLength(1); j++)
            {                   
                M[i,j] = ValidaValor(i,j);
        }
    }
    return M; 
}

static double ValidaValor(int i, int j)     
{
    
    Boolean Condicion = true;
    double valor = 0;        
        
    
    
    while (Condicion)
    {
        try
        {
        System.Console.Write($"Nota[{i}{j}] : ");
        valor = double.Parse(Console.ReadLine());
        if (valor<= 10 & valor >= 1)
        {
        Condicion = false;
        }
        else
        {
        System.Console.WriteLine("Debe ingresar un numero de 1 al 10");
        }

        }

        catch
        {
            System.Console.WriteLine("Valor incorrecto!!, Ingrese un Numero.");
        }
        
    }    
            
    return valor ;
}