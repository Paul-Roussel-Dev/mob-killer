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
            var item = new Item();
            var items = item.GetItems();
            
            var lootphase = new Lootphase();
            Console.WriteLine("Heuh j'ai affaire à qui la ?? (Entrez votre nom) :");
            var playerName = Console.ReadLine();
            var playerItem = lootphase.DroppedItems(items, Utils.random);
            var player = new Player(0, playerName, Utils.random.Next(25, 100), playerItem.IdItem, playerItem, Utils.random.Next(5,25));
            var monster = new Monster();
            var monsters = monster.GetMonsters();
            var stage = new Stage();
            var dialogue = new Dialogue();
            stage.StartStage(player, monsters, monster, items, dialogue);
        }

    }
}
