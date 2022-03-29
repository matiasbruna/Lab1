namespace PrimerTrabajoPractico
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Escribe tu Apellido y Nombre");
            var _nombre = Console.ReadLine();
            
            Console.WriteLine("Escribe tu Lejago de Estudiante");
            var _domicilio = Console.ReadLine();

            Console.WriteLine("Año de Ingreso");
            var _telefono = Console.ReadLine();

            Console.WriteLine("Carrera que estudia");
            var _email = Console.ReadLine();

            Console.Clear();

            Console.WriteLine(_nombre);
            Console.WriteLine(_domicilio);
            Console.WriteLine(_telefono);
            Console.WriteLine(_email);
        }
    }
}