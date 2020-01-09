using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public Player(Player player)
        {
            player.Id = this.Id;
            player.Name = this.Name;
            player.Health = this.Health;
            player.Evasion = this.Evasion;
            player.Id = this.Id;
            player.Item = this.Item;
        }
        public Player()
        {

        }
    }
}
