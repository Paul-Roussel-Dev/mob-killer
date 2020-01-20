﻿using System;
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

            while (MonsterStats.Health > 0 && PlayerStats.Health > 0)
            {
                var turn = new BossTurn();
                var Turn = new Turn();
                Console.WriteLine("Tour n°" + (TurnCounter + 1));
                if (TurnCounter > enigmas.Count - 1)
                {
                    Console.WriteLine("TROOOOOOOOOOP TARRRRDDD  HAHAHAHAH !");
                    return false;
                }
                else
                {
                    if (isPlayerTurn)
                    {
                        turn.StartBossTurn(PlayerStats, MonsterStats, enigmas[TurnCounter]);
                        isPlayerTurn = !isPlayerTurn;
                        TurnCounter++;
                        Utils.slowConsoleWriter(newPhase);
                    }
                    else
                    {

                        Turn.StartTurn(PlayerStats, MonsterStats, isPlayerTurn);
                        isPlayerTurn = !isPlayerTurn;
                        Console.WriteLine(Utils.centaur);
                        Utils.slowConsoleWriter(newPhase);
                    }
                }

            }

            if (MonsterStats.Health <= 0)
            {
                Console.WriteLine("Combat Terminé !");
                return true;
            }
            else
            {
                Console.WriteLine("Combat Terminé !");
                return false;
            }

            return false;
        }
    }
}