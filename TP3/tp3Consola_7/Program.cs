namespace tp3Consola_7
{

    public struct Auto  {

        public string nombre;
        public string descripcion;
    }
    public struct Persona{

        public string nombre;
        public string apellido;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        
        Auto miAuto;
        miAuto.nombre= "Fiat";
        miAuto.descripcion="Tiene 4 puertas y es a gas.";
        
       Console.WriteLine($"Contenido de la Estructura Auto: {miAuto.nombre} ademas {miAuto.descripcion}");

       Persona p;
        p.nombre= "Matias";
        p.apellido= "Bruna";

        Console.WriteLine($"Contenido de la Estructura Persona; {p.nombre} {p.apellido} ");
        





        }
    }
}
