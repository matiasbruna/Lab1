namespace tp3Consola_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 21;
            int edad2 = 25;

            edad++;
            
            edad2--;

            Console.WriteLine($"Muestro incremento {edad} , muestro decremento {edad2}");
            Console.ReadKey();
        }
    }
}