namespace PrimerTrabajoPractico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Escribe tu Apellido y Nombre");
            string nombre = Console.ReadLine();
            
            Console.WriteLine("Escribe tu Domicilio");
            string domicilio = Console.ReadLine();

            Console.WriteLine("Escribe tu Telefono");
            int telefono = int.Parse(Console.ReadLine());

            Console.WriteLine("Escribe tu Correo Electronico");
            string email = Console.ReadLine();

            Console.WriteLine("Escribe tu Ciudad");
            string ciudad = Console.ReadLine();

            Console.Clear();

            Console.WriteLine(nombre);
            Console.WriteLine(domicilio);
            Console.WriteLine(telefono);
            Console.WriteLine(email);
            Console.WriteLine(ciudad);
        }
    }
}