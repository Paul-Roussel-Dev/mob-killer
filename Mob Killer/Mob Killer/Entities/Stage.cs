using LootPhase;
using Mob_Killer.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mob_Killer.Entities
{
    public class Stage
    {
        public void StartStage(Player player, Monster monster, Item item, Dialogue dialogue)
        {
            using (var dboContext = new MobKillerDbContext())
            {
                dialogue.getDialogue("Transition");
                var battle = new Battle();
                var win = battle.BattleResult(player, monster);
                Console.WriteLine(win ? "vous avez gagné !!" : "Vous avez perdu ... ");
                if (win)
                {
                    var classi = new MainClass();
                    classi.lootPhase1(Utils.random);
                }
                else
                {

                }
            }
        }
    }
}
