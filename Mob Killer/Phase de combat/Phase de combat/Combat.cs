using System;
using System.Collections.Generic;
using System.Text;

namespace Mob_Killer.Battle_Phase
{
    public class Combat
    {

        public bool isPlayerTurn;
        public int Turns;
        public Player PlayerStats;
        public Monster MonsterStats;
        public Turn turn;
        public int TurnCounter = 0;
        public bool win = false;
        public Combat () {
        
        }
        public bool CombatResult (Player player,Monster monster)
        {
            this.PlayerStats = player;
            this.MonsterStats = monster;
            this.isPlayerTurn = true;

            Console.WriteLine("Que le combat commence !");
            while(MonsterStats.Health > 0 && PlayerStats.Health > 0)
            {
                var turn = new Turn();
                Console.WriteLine("Tour n°" + (TurnCounter + 1));
                turn.StartTurn(PlayerStats, MonsterStats ,isPlayerTurn);
                isPlayerTurn = !isPlayerTurn;
                TurnCounter++;
                Console.WriteLine(Environment.NewLine);
            }

            if(MonsterStats.Health <= 0)
            {
                Console.WriteLine("Combat Terminé !");
                return true;
            }
            else
            {
                Console.WriteLine("Combat Terminé !");
                return false;
            }


        }



    }
}
