namespace PrimerTrabajoPractico
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Escribe tu Apellido y Nombre");
            var _nombre = Console.ReadLine();
            
            Console.WriteLine("Escribe tu Domicilio");
            var _domicilio = Console.ReadLine();

            Console.WriteLine("Escribe tu Telefono");
            var _telefono = Console.ReadLine();

            Console.WriteLine("Escribe tu Correo Electronico");
            var _email = Console.ReadLine();

            Console.WriteLine("Escribe tu Ciudad");
            var _ciudad = Console.ReadLine();

            Console.Clear();

            Console.WriteLine(_nombre);
            Console.WriteLine(_domicilio);
            Console.WriteLine(_telefono);
            Console.WriteLine(_email);
            Console.WriteLine(_ciudad);



        }
    }
}