﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Mob_Killer.Data;

namespace Mob_Killer.Entities
{
    public class Monster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Health { get; set; }
        public double Attack { get; set; }
        public double Evasion { get; set; }

        public Monster()
        {

        }

        public List<Monster> getMonstres()
        {

            using (var dboContext = new MobKillerDbContext())
            {
                var Monstres = dboContext.Monsters;
                var list = Monstres.ToList();

                return list;
            }
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
