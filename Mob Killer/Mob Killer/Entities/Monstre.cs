using System;
using System.Collections.Generic;
using System.Text;

namespace Mob_Killer.Entities
{
    public class Monstre
    {
        public int IdMonstre { get; set; }

        public string NameMonstre { get; set; }

        public double HealthMonste { get; set; }

        public double EvasionMonstre { get; set; }

        public double AttackMonstre { get; set; }

        public Monstre(Monstre monstre)
        {
            monstre.IdMonstre = this.IdMonstre;
            monstre.NameMonstre = this.NameMonstre;
            monstre.HealthMonste = this.HealthMonste;
            monstre.EvasionMonstre = this.EvasionMonstre;
            monstre.AttackMonstre = this.AttackMonstre;
        }

        public Monstre()
        {

        }
    }
}
