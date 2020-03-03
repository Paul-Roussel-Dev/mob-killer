using Mob_Killer.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mob_Killer.Entities
{
    public class Stage
    {
        public bool StartStage(Player player, List<Monster> monsters,Monster instanceofmonster, List<Item> items, Dialogue dialogue)
        {
            using var dboContext = new MobKillerDbContext();
            dialogue.GetDialogue("Transition");

            var monster = instanceofmonster.MonsterChoosen(monsters, Utils.random);
            var battle = new Battle();
            var win = battle.BattleResult(player, monster);
            Console.WriteLine(win ? "vous avez gagné !!" : "Vous avez perdu ... ");
            if (win)
            {
                var lootphase = new Lootphase();
                var itemlootphase = lootphase.DroppedItems(items, Utils.random);
                player.Item = itemlootphase;
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
