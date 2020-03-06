using Mob_Killer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mob_Killer.Repository
{
    public class DialogueRepository
    {
        public void GetDialogue(string type)
        {

            using var dboContext = new MobKillerDbContext();
            var Dialogues = dboContext.Dialogue.Where(p => p.Type == type);
            var list = Dialogues.ToList();
            int nombreEntrees = list.Count;

            var random = new Random();
            int choix = random.Next(0, nombreEntrees);

            int compteur = 0;

            foreach (var Dialogue in list)
            {
                if (compteur == choix)
                {
                    Console.WriteLine($"{Dialogue?.Text}");
                }

                compteur++;
            }

        }
    }
}
