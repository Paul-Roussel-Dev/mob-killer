using Mob_Killer.Data;
using Mob_Killer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mob_Killer.Repository
{
    public class DialogueRepository
    {


        public List<Dialogue> GetDialogue()
        {
            using (var dboContext = new MobKillerDbContext())
            {
                var dialogue = dboContext.Dialogue;
                var list = dialogue.ToList();

                return list;
            }

        }

        public List<Dialogue> ShowDialogue(string type, List<Dialogue> availableDialogue, Random random)
        {

            using (var dboContext = new MobKillerDbContext())
            {
                availableDialogue = availableDialogue.Where(p => p.Type == type).ToList();

                if (availableDialogue.Count() > 0)
                {
                    var randomDialogueA = availableDialogue[random.Next(0, availableDialogue.Count())];
                    Utils.SlowConsoleWriter(randomDialogueA.Text);
                    availableDialogue.Remove(randomDialogueA);
                }
                else
                {
                    availableDialogue = dboContext.Dialogue.Where(p => p.Type == type).ToList();
                    var randomDialogueA = availableDialogue[random.Next(0, availableDialogue.Count())];
                    Utils.SlowConsoleWriter(randomDialogueA.Text);
                    availableDialogue.Remove(randomDialogueA);
                }

                Console.WriteLine();

                return availableDialogue;

            }

        }

    }
}
