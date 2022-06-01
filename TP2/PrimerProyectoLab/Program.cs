namespace PrimerTrabajoPractico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Escribe tu Apellido y Nombre");
            string nombre = Console.ReadLine();
            
            Console.WriteLine("Escribe tu Lejago de Estudiante");
            int legajo = int.Parse(Console.ReadLine());

            Console.WriteLine("Año de Ingreso");
            string Año = Console.ReadLine();

            Console.WriteLine("Carrera que estudia");
            string Carrera= Console.ReadLine();

            Console.Clear();

            Console.WriteLine(nombre);
            Console.WriteLine(legajo);
            Console.WriteLine(Año);
            Console.WriteLine(Carrera);
        }
    }
}