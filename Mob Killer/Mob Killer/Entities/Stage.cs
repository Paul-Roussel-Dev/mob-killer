using Mob_Killer.Data;
using Mob_Killer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mob_Killer.Entities
{
    public class Stage
    {
        public bool StartStage(Player player, List<Monster> monsters, MonsterRepository instanceofmonster, List<Item> items, List<Dialogue> allDialogue)
        {
            var dialogue = allDialogue;
            var Dialogues = new DialogueRepository();
            allDialogue = Dialogues.ShowDialogue("Transition", allDialogue, Utils.random);


            var monster = instanceofmonster.MonsterChoosen(monsters, Utils.random);
            var battle = new Battle();
            var win = battle.BattleResult(player, monster);
            Utils.SlowConsoleWriter(win ? "vous avez gagné !!" : "Vous avez perdu ... ");

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
