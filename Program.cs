using System;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            ComidaPrincipal cp = Creador.CreadorComida(Creador.pizza);
            Console.WriteLine("Cantidad: " + cp.Cantidad());
            Console.ReadKey();
        }
    }
}
