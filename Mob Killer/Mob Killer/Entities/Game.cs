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
            var player = new Player();
            var monster = new Monster();
            var monsters = monster.GetMonsters();
            var stage = new Stage();
            var dialogue = new Dialogue();
            stage.StartStage(player, monsters, monster, items, dialogue);
        }

    }
}
