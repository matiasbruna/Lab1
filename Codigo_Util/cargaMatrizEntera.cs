 static int[,] CargarMatriz()     
{
    int[,] M = new int[5,5];   
    System.Console.WriteLine("Ingrese los valores para cargar la matriz:");
    for (int i = 0; i < M.GetLength(0); i++)
    {
        for (int j = 0; j < M.GetLength(1); j++)
        {
            System.Console.Write($"Fila {i+1}, valor {j+1}: ");
            M[i,j] = ValidaValor();
        }
    }
    return M; 
}
static int ValidaValor()     
{
    
    Boolean Condicion = true;
    int valor = 0;        
    while (Condicion)
    {
        try
        {
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