using System;
using System.Collections.Generic;
using System.Text;

namespace Mob_Killer.Entities
{
    public class Monster
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double Attack { get; set; }
        public double Evasion { get; set; }

        public Monster()
        {

        }

        public Monster(string name, double health, double attack, double evasion)
        {
            this.Name = name;
            this.Health = health;
            this.Attack = attack;
            this.Evasion = evasion;
        }
    }

}
