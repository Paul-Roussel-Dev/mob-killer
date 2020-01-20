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
            Utils.slowConsoleWriter(" Le Boss vous pose cette colle : " + enigma.Question);
            Console.WriteLine(" 0 : " + enigma.AnswerA + "  ||  1 : " + enigma.AnswerB);

            string Response = Console.ReadLine();

            return Response;

        }
        public void StartBossTurn(Player player, Monster monster, Enigma enigma)
        {
            // get boss questions 

            double attackForce = 0;
            double evasionForce = 0;
            double attack = 0;
            double evasion = 0;

            attackForce = player.Item.BaseAttack;
            evasionForce = monster.Evasion;

            var resultFromRollDice = Randoming.rollDices(attackForce, evasionForce);
            var param = new { attack = 0, evasion = 1 };
            Console.WriteLine(resultFromRollDice[param.attack] + " / " + resultFromRollDice[param.evasion]);
            var damageDeal = (resultFromRollDice[param.attack] - (resultFromRollDice[param.attack] * (resultFromRollDice[param.evasion] == 0 ? (1 / 100) : (resultFromRollDice[param.evasion] / 100))));


            // begin interactive phase
            var Response = GetAnswerFromQuestion(enigma);
            while (Response != "0" && Response != "1")
            {
                Console.WriteLine(" Veuillez entrer une réponse valide ! ");
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
                Utils.slowConsoleWriter("Bonne réponse ! Vous attaquez avec un bonus ! ");
                Console.WriteLine("Vous infligez " + damageDeal + " de dégat !");
                monster.Health -= (damageDeal);
                Utils.slowConsoleWriter("Il lui reste : " + monster.Health + "hp");
            }
            else
            {
                damageDeal = (resultFromRollDice[param.attack] - (resultFromRollDice[param.attack] * (resultFromRollDice[param.evasion] == 0 ? (1 / 100) : (resultFromRollDice[param.evasion] / 100)))) * 0.2;
                Utils.slowConsoleWriter("Mauvaise réponse ! Vous attaquez avec un malus !");
                Console.WriteLine(" Vous infligez " + damageDeal + " de dégat !");
                monster.Health -= (damageDeal);
                Utils.slowConsoleWriter("Il lui reste : " + monster.Health + "hp");
            }
        }
    }
}
