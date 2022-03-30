namespace tp3Consola_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           int var1 = 384654684;
           long var2 = 456546513843513843;

           var2= (int)var2;

           Console.WriteLine($" el Cast de var2 que es de tipo long y ahora es int, y se igualan sus tamaños:");
           Console.WriteLine(var1);
           Console.WriteLine(var2);
        }
    }
}