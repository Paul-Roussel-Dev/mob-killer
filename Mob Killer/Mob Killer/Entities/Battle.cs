using System;
using System.Collections.Generic;
using System.Text;

namespace Mob_Killer.Entities
{
    public class Battle
    {
        public bool isPlayerTurn;
        public int Turns;
        public Player PlayerStats;
        public Monster MonsterStats;
        public Turn turn;
        public int TurnCounter = 0;
        public bool win = false;
        public Battle()
        {

        }
        public bool BattleResult(Player player, Monster monster)
        {
            this.PlayerStats = player;
            this.MonsterStats = monster;
            this.isPlayerTurn = true;

            Utils.SlowConsoleWriter("Que le combat commence !\n");
            Utils.SlowConsoleWriter("Vous vous battez contre: " + monster.Name + "\n\n");
            Console.WriteLine(monster.Image + "\n\n");
            while (MonsterStats.Health > 0 && PlayerStats.Health > 0)
            {
                var turn = new Turn();
                Utils.SlowConsoleWriter("Tour n°" + (TurnCounter + 1) + "\n");
                turn.StartTurn(PlayerStats, MonsterStats, isPlayerTurn);
                isPlayerTurn = !isPlayerTurn;
                TurnCounter++;
                Utils.SlowConsoleWriter(Environment.NewLine);
            }

            if (MonsterStats.Health <= 0)
            {
                Utils.SlowConsoleWriter("Combat Terminé !");
                return true;
            }
            else
            {
                Utils.SlowConsoleWriter("Combat Terminé!");
                return false;
            }


        }



    }

}

