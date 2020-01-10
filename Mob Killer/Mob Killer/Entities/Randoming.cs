using System;
using System.Collections.Generic;
using System.Text;

namespace Mob_Killer.Entities
{
    public static class Randoming
    {

        public static double[] rollDices(double attackForce, double evasionForce)
        {
            var attackInted = Convert.ToInt32(attackForce * 100);
            var evasionInted = Convert.ToInt32(evasionForce * 100);

            var attack = (Utils.random.Next(Convert.ToInt32(attackInted/4), attackInted) / 100)+1;
            var evasion = (Utils.random.Next(1, evasionInted) / 100)+1;
            double[] result = { attack, evasion };
            return result;

        }
    }
}
