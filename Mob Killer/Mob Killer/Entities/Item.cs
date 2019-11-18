using System;
using System.Collections.Generic;
using System.Text;

namespace Mob_Killer.Entities
{
    public class Item
    {
        public int IdItem { get; set; }

        public string NameItem { get; set; }

        public double BaseAttack { get; set; }

        public double BonusEvasion { get; set; }

        //public int DiceId { get; set; }

        //public Dice Dice { get; set; }
    }
}
