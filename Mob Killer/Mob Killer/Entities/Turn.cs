using System;
using System.Collections.Generic;
using System.Text;

namespace Mob_Killer.Entities
{
    public class Turn
    {
        public Turn()
        {

        }
        public void StartTurn(Player player, Monster monster, bool isTurn)
        {
            double attackForce;
            double evasionForce;

            if (isTurn)
            {
                attackForce = player.Item.BaseAttack;
                evasionForce = monster.Evasion;
                var resultFromRollDice = Randoming.RollDices(attackForce, evasionForce);
                var param = new { attack = 0, evasion = 1 };
                Utils.SlowConsoleWriter(resultFromRollDice[param.attack] + " / " + resultFromRollDice[param.evasion] + "\n");
                var damageDeal = (resultFromRollDice[param.attack] - (resultFromRollDice[param.attack] * (resultFromRollDice[param.evasion] == 0 ? (1 / 100) : (resultFromRollDice[param.evasion] / 100))));
                var damageDisplay = Convert.ToInt32(damageDeal);
                Utils.SlowConsoleWriter("Vous attaquez ! Vous infligez " + damageDisplay + " de dégat !" + "\n");
                monster.Health -= damageDeal;
                Utils.SlowConsoleWriter("Il lui reste : " + monster.Health + "hp" + "\n");
            }
            else
            {
                attackForce = monster.Attack;
                evasionForce = player.Evasion + player.Item.BonusEvasion;

                var resultFromRollDice = Randoming.RollDices(attackForce, evasionForce);
                var param = new { attack = 0, evasion = 1 };
                Utils.SlowConsoleWriter(resultFromRollDice[param.attack] + " / " + resultFromRollDice[param.evasion] + "\n");

                var damageDeal = (resultFromRollDice[param.attack] - (resultFromRollDice[param.attack] * (resultFromRollDice[param.evasion] == 0 ? (1 / 100) : (resultFromRollDice[param.evasion] / 100))));
                var damageDisplay = Convert.ToInt32(damageDeal);

                Utils.SlowConsoleWriter(monster.Name + " vous attaque et vous inflige " + damageDisplay + " de dégat !" + "\n");

                player.Health -= damageDeal;
                Utils.SlowConsoleWriter("Il vous reste : " + player.Health + "hp" + "\n");
            }
        }
    }

}
