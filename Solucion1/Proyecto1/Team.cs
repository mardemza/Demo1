using System;
using System.Collections.Generic;

namespace Proyecto1
{
    public class Team
    {
        private string v;

        public Team(string name)
        {
            Id = new Random(1).Next();
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public List<Player> Players { get; set; } = new List<Player>();
    }
}