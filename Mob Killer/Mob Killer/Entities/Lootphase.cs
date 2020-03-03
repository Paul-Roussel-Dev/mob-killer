using Mob_Killer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mob_Killer.Entities
{
    public class Lootphase
    {
        public Lootphase()
        {
            var item = new Item();
            var listItem = item.GetItems().ToList();

        }
        public Item DroppedItems(List<Item> availableItems, Random random)
        {
            using (var dboContext = new MobKillerDbContext())
            {
                var randomItemA = availableItems[random.Next(0, availableItems.Count)];
                Console.WriteLine(randomItemA);
                availableItems = availableItems.Where(i => i != randomItemA).ToList();
                Console.WriteLine(availableItems);
                var randomItemB = availableItems[random.Next(0, availableItems.Count)];
                Console.WriteLine(randomItemB);
                availableItems = availableItems.Where(i => i != randomItemB).ToList();
                availableItems.ForEach(Console.WriteLine);

                Console.WriteLine("Bravo Vous venez de remporter votre duel ! \n Choisissez à présent l'item de votre choix : \n");

                Console.WriteLine("0 = " + randomItemA + "\n" + "1 = " + randomItemB);

                string readeditem = Console.ReadLine();

               
               while(readeditem!="0"||readeditem!="1")
                {
                    Console.WriteLine("Erreur de saisie veuillez écrire quelque chose de valide ! ");
                    Console.WriteLine("0 = " + randomItemA + "\n" + "1 = " + randomItemB);
                    readeditem = Console.ReadLine();
                }
                if (readeditem == "0")
                {
                    return randomItemA;
                }
                else if (readeditem == "1")
                {
                    return randomItemB;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}

