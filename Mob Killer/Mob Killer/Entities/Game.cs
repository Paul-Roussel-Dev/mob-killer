using Mob_Killer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mob_Killer.Entities
{
    public class Game
    {
        public Game()
        {

        }

        public void StartGame()
        {
            var item = new ItemRepository();
            var items = item.GetItems();
            
            var lootphase = new Lootphase();
            Console.WriteLine("Heuh j'ai affaire à qui la ?? (Entrez votre nom) :");
            var playerName = Console.ReadLine();
            var playerItem = lootphase.DroppedItems(items, Utils.random);
            var player = new Player(0, playerName, Utils.random.Next(25, 100), playerItem.IdItem, playerItem, Utils.random.Next(5,25));
            var monster = new MonsterRepository();
            var monsters = monster.GetMonsters();
            var stage = new Stage();
            var dialogue = new DialogueRepository();
            var resultstage = stage.StartStage(player, monsters, monster, items, dialogue);
            if (resultstage == true)
            {
                int i = 0;
                do
                {
                    resultstage = stage.StartStage(player, monsters, monster, items, dialogue);
                    i++;

                }
                while (resultstage == true && i < 2);
                if(resultstage == true)
                {
                    var bossbattle = new BossBattle();
                    var enigma = new EnigmaRepository();
                    bool bossbatlleresult = bossbattle.BossBattleResult(player, monster.MonsterChoosen(monsters, Utils.random), enigma.GetEnigma());
                }
            }
            else
            {
                Console.WriteLine("Vous avez perdu !");
            }
        }

    }
}
