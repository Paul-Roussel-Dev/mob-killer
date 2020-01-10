using System;
using System.Collections.Generic;
using System.Text;

namespace Mob_Killer.Entities
{
    public class Player
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Health { get; set; }

        public double Evasion { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }


        public Player()
        {

        }

        public Player(int id, string name, double health,int itemId, Item item, double evasion)
        {
            this.Id = id;
            this.Name = name;
            this.Health = health;
            this.ItemId = itemId;
            this.Item = item;
            this.Evasion = evasion;
        }
    }
}
