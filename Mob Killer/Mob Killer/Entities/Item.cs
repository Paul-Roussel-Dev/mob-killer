using Mob_Killer.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Mob_Killer.Entities
{
    public class Item
    {
        [Key]
        public int IdItem { get; set; }
        public string Name { get; set; }
        public double BaseAttack { get; set; }
        public double BonusEvasion { get; set; }

        public Item()
        {

        }

        public Item(int id, string name, double baseAttack, double bonusEvasion)
        {
            this.IdItem = id;
            this.Name = name;
            this.BaseAttack = baseAttack;
            this.BonusEvasion = bonusEvasion;
        }
    }
}