using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_de_combat
{
    public class Player
    {
        public string Name { get; set; }

        public double Health { get; set; }

        public double Evasion { get; set; }
  
        public Item Item { get; set; }


        public Player()
        {

        }

        public Player(string name, double health, Item item, double evasion)
        {
            this.Name = name;
            this.Health = health;
            this.Item = item;
            this.Evasion = evasion;
        }
    }
}
