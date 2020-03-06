using Mob_Killer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mob_Killer.Entities
{
    public class BossBattle
    {
        public bool isPlayerTurn;
        public int Turns;
        public Player PlayerStats;
        public Monster MonsterStats;
        public BossTurn InteractiveTurn;
        public Turn Turn;
        public int TurnCounter = 0;

        public BossBattle()
        {

        }
        public bool BossBattleResult(Player player, Monster monster, List<Enigma> enigmas)
        {
            this.PlayerStats = player;
            this.MonsterStats = monster;
            this.isPlayerTurn = false;
            string newPhase = "|\n|\n|\n|\n|\n";

            Utils.SlowConsoleWriter("Vous vous battez contre: " + monster.Name + "\n\n");
            Console.WriteLine(monster.Image + "\n\n");

            while (MonsterStats.Health > 0 && PlayerStats.Health > 0)
            {
                var turn = new BossTurn();
                var Turn = new Turn();
                Utils.SlowConsoleWriter("Tour n°" + (TurnCounter + 1));
                if (TurnCounter > enigmas.Count - 1)
                {
                    Utils.SlowConsoleWriter("TROOOOOOOOOOP TARRRRDDD  HAHAHAHAH !");
                    return false;
                }
                else
                {
                    if (isPlayerTurn)
                    {
                        var enigmarandom = new EnigmaRepository();
                        turn.StartBossTurn(PlayerStats, MonsterStats, enigmarandom.GetRamdomEnigma());
                        isPlayerTurn = !isPlayerTurn;
                        TurnCounter++;
                        Utils.SlowConsoleWriter(newPhase);
                    }
                    else
                    {

                        Turn.StartTurn(PlayerStats, MonsterStats, isPlayerTurn);
                        isPlayerTurn = !isPlayerTurn;
                        Utils.SlowConsoleWriter(newPhase);
                    }
                }

            }

            if (MonsterStats.Health <= 0)
            {
                Utils.SlowConsoleWriter("Combat Terminé !");
                return true;
            }
            else
            {
                Utils.SlowConsoleWriter("Combat Terminé !");
                return false;
            }
        }
    }
}