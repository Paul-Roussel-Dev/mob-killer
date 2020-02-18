using Mob_Killer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LootPhase
{
    public class MainClass
    {
        public MainClass()
        {
            var item = new Item();
            var listItem = item.GetItems().ToList();

        }
        public List<string> lootPhase(List<string> availableItems, bool valeurItem, Random random)
        {
            using (var dboContext = new MobKillerDbContext())
            {
                var randomItemA = availableItems[random.Next(0, availableItems.Count)];
                Console.WriteLine(randomItemA);
                availableItems = availableItems.Where(i => i != randomItemA.ToString()).ToList();
                Console.WriteLine(availableItems);
                var randomItemB = availableItems[random.Next(0, availableItems.Count)];
                Console.WriteLine(randomItemB);
                availableItems = availableItems.Where(i => i != randomItemB.ToString()).ToList();
                availableItems.ForEach(Console.WriteLine);




                Console.WriteLine("Bravo Vous venez de remporter votre duel ! \n Choisissez à présent l'item de votre choix : \n");


                Console.WriteLine("0 = " + randomItemA + "\n" + "1 = " + randomItemB);

                string item = Console.ReadLine();


                return availableItems;
            }
        }
    }
}