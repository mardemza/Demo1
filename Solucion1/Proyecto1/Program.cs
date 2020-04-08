using System;

namespace Proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {

            // -- Asigno jugador
            var player1 = new Player(1,"Carlos","Tevez",10);

            Console.WriteLine("Jugador: {0}",player1.FullName());
            var text = string.Format("{0} {1}, hoy es {2}", "Bienvenidos", "Juan", DateTime.Now.ToString("D"));
            
            Console.WriteLine(text);

            Console.WriteLine(" =============================== ");
            Console.WriteLine(" =                             = ");
            Console.WriteLine(" =     Por favor ingrese       = ");
            Console.WriteLine(" =        su nombre            = ");
            Console.WriteLine(" =                             = ");
            Console.WriteLine(" =============================== ");

            var nombre = Console.ReadLine();
             //cambios nuevos
            Console.WriteLine(" =============================== ");
            Console.WriteLine(" =                             = ");
            Console.WriteLine(" =        Su nombre es         = ");
            Console.WriteLine($" =         {nombre}           = ");
            Console.WriteLine(" =                             = ");
            Console.WriteLine(" =============================== ");

        }
    }
}
