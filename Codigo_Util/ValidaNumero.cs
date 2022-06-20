static byte ValidaNumero()     
{  
    Boolean Condicion = true;
    byte Num = 0;         
    
    while (Condicion)
    {
        try
        {        
            Num = byte.Parse(Console.ReadLine());
            if(Num > 0)
            {
                Condicion = false;
            }
            else
            {
                System.Console.WriteLine("La Matriz No puede tener filas y colunas en Cero:");
            }              
        }
        catch
        {
            System.Console.WriteLine("Valor incorrecto!!, Ingrese un numero Positivo, distinto de cero:");
        }       
    }                
    return Num;
}