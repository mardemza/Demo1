using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto1
{
    public class Player
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Surname { get; set; }
        private int Number { get; set; }


        public Team Team { get; set; }

        /// <summary>
        /// Parametros de entrada
        /// </summary>
        /// <param name="id">Registro</param>
        /// <param name="name">Nombre</param>
        /// <param name="surname">Apellido</param>
        /// <param name="number">Numero de camiseta</param>
        public Player(int id,string name, string surname, int number)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Number = number;
        }


        public string FullName()
        {
            return $"{Name} {Surname} | {Number}";
        }
    }
}
