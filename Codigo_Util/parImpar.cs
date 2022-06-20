static void MostrarParImpar(double[]V)
{
    int Par = 0;
    int Impar = 0;
    for (int i = 0; i < V.Length; i++)
    {
        if ((V[i]%2) == 0)
        {
            Par++;
        }
        else
        {
            Impar++;
        }
    }
    System.Console.WriteLine($"Cantidad de numeros pares : {Par}.");
    System.Console.WriteLine($"Cantidad de numeros Impares: {Impar}.");

}