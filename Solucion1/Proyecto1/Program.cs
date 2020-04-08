using System;

namespace Proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            // -- Explicación de concatenar elementos con string.Format
            
            var text = string.Format(" = {0} {1}, hoy es {2}", "Bienvenidos", "usuarios", DateTime.Now.ToString("D"));
            Console.WriteLine(" ===================================================== ");
            Console.WriteLine(text);

            // -- Asigno jugador
            var player1 = new Player(1,"Carlos","Tevez",10);
            Console.WriteLine(" ===================================================== ");
            Console.WriteLine(" = Jugador: {0}",player1.FullName());

            // -- Asigno un equipo y agrego un jugador al equipo
            var team = new Team("Boca Juniors");
            team.Players.Add(player1);

            Console.WriteLine(" ===================================================== ");
            Console.WriteLine(" = Equipo: {0}", team.Name);
            Console.WriteLine(" = Cantidad de jugadores: {0}", team.Players.Count);
            Console.WriteLine(" ===================================================== ");
            Console.WriteLine(" =     Por favor ingrese       ");
            Console.WriteLine(" =        su nombre            ");
            Console.WriteLine(" =    y le diremos de que      ");
            Console.WriteLine(" =      equipo es usted        ");
            Console.WriteLine(" ===================================================== ");

            var nombre = Console.ReadLine();
            //cambios nuevos
            Console.WriteLine(" ===================================================== ");
            Console.WriteLine(" =        Su nombre es         ");
            Console.WriteLine($" =         {nombre}           ");
            Console.WriteLine($" =       y su equipo es       ");
            Console.WriteLine($" =         {team.Name}        ");
            Console.WriteLine(" ===================================================== ");

        }
    }
}
