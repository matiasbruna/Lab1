static void MosMayMenorPosicion (double[,]M)
{
    double Mayor = M[0,0];
    double Menor = M[0,0];
    int [] posMayor = new int[2];
    int [] posMenor = new int[2];

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
            if (M[i,j]< Menor)
            {
                Menor = M[i,j];
                posMenor[0] = i;
                posMenor[1] = j;
            }
        }
    }
    System.Console.WriteLine($"El mayor elemento es: {Mayor} y su Pocision es: [{posMayor[0]},{posMayor[1]}].");
    System.Console.WriteLine($"El mayor elemento es: {Menor} y su Pocision es: [{posMenor[0]},{posMenor[1]}].");
}