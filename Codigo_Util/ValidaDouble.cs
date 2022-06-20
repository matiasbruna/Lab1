static double ValidaDouble()     
{  
    Boolean Condicion = true;
    double Num = 0;         
    
    while (Condicion)
    {
        try
        {   
            System.Console.Write("valor: ");     
            Num = double.Parse(Console.ReadLine());
            System.Console.Write("\n");
            Condicion = false;
        }
        catch
        {
            System.Console.WriteLine("Valor incorrecto!!, Ingrese un numero:");
        }       
    }                
    return Num;
}