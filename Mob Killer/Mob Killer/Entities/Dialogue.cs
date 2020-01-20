using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Mob_Killer.Data;

namespace Mob_Killer.Entities
{
    public class Dialogue
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string Text { get; set; }

        public void getDialogue(string type)
        {

            using (var dboContext = new MobKillerDbContext())
            {
                var Dialogues = dboContext.Dialogue.Where(p => p.Type == type);
                var list = Dialogues.ToList();
                int nombreEntrees = list.Count;
                
                var random = new Random();
                int choix = random.Next(0, nombreEntrees);

                int compteur = 0;

                foreach (var Dialogue in list)
                {
                    if (compteur==choix)
                    {
                        Console.WriteLine($"{Dialogue?.Text}");
                    }

                    compteur++;
                }
                
            }

        }

    }

}



