using System;
using System.Collections.Generic;
using System.Text;

namespace Mob_Killer.Entities
{
    public class BossTurn
    {

        public BossTurn()
        {

        }

        public string GetAnswerFromQuestion(Enigma enigma)
        {
            Utils.SlowConsoleWriter(" Le Boss vous pose cette colle : " + enigma.Question);
            Utils.SlowConsoleWriter("\n  0 : " + enigma.AnswerA + " \n  1 : " + enigma.AnswerB + "\n");

            string Response = Console.ReadLine();

            return Response;

        }
        public void StartBossTurn(Player player, Monster monster, Enigma enigma)
        {
            // get boss questions 

            double attackForce;
            double evasionForce;

            attackForce = player.Item.BaseAttack;
            evasionForce = monster.Evasion;

            var resultFromRollDice = Randoming.RollDices(attackForce, evasionForce);
            var param = new { attack = 0, evasion = 1 };
            Utils.SlowConsoleWriter(resultFromRollDice[param.attack] + " / " + resultFromRollDice[param.evasion]);
            double damageDeal;


            // begin interactive phase
            var Response = GetAnswerFromQuestion(enigma);
            while (Response != "0" && Response != "1")
            {
                Utils.SlowConsoleWriter(" Veuillez entrer une réponse valide ! ");
                Response = GetAnswerFromQuestion(enigma);
            };

            if (Response == "0")
            {
                Response = enigma.AnswerA;
            }
            else
            {
                Response = enigma.AnswerB;
            }

            if (Response == enigma.Answer)
            {
                damageDeal = (resultFromRollDice[param.attack] - (resultFromRollDice[param.attack] * (resultFromRollDice[param.evasion] == 0 ? (1 / 100) : (resultFromRollDice[param.evasion] / 100)))) * 2;
                Utils.SlowConsoleWriter("Bonne réponse ! Vous attaquez avec un bonus ! ");
                Utils.SlowConsoleWriter("Vous infligez " + damageDeal + " de dégat !");
                monster.Health -= (damageDeal);
                Utils.SlowConsoleWriter("Il lui reste : " + monster.Health + "hp");
            }
            else
            {
                damageDeal = (resultFromRollDice[param.attack] - (resultFromRollDice[param.attack] * (resultFromRollDice[param.evasion] == 0 ? (1 / 100) : (resultFromRollDice[param.evasion] / 100)))) * 0.2;
                Utils.SlowConsoleWriter("Mauvaise réponse ! Vous attaquez avec un malus !");
                Utils.SlowConsoleWriter("Vous infligez " + damageDeal + " de dégat !");
                monster.Health -= (damageDeal);
                Utils.SlowConsoleWriter("Il lui reste : " + monster.Health + "hp");
            }
        }
    }
}
