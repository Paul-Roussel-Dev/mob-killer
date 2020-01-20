using Mob_Killer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LootPhase
{
    public class MainClass
    {
        public MainClass()
        {

        }
        public void lootPhase(List<Item> AvailableItems, bool valeurItem, Random random, List<Item> ItemsAldreadyProposed)
        {
            int RamdomItemA = random.Next(0, AvailableItems.Count);
            ItemsAldreadyProposed.Add(AvailableItems[RamdomItemA]);


            Console.WriteLine("Bravo Vous venez de remporter votre duel ! \n Choisissez à présent l'item de votre choix : \n");

            Console.WriteLine("0 = " + AvailableItems[RamdomItemA]);

            int RamdomItemB = random.Next(0, AvailableItems.Count);


            do
            {
                for (int j = 0; j < ItemsAldreadyProposed.Count; j++)
                {
                    if (ItemsAldreadyProposed[j] == AvailableItems[RamdomItemB])
                    {
                        RamdomItemB = random.Next(0, AvailableItems.Count);
                    }
                }
            } while (RamdomItemA == RamdomItemB);

            ItemsAldreadyProposed.Add(AvailableItems[RamdomItemB]);


            Console.WriteLine("1 = " + AvailableItems[RamdomItemB]);

            string item = Console.ReadLine();


            if (item == "1")
            {
                Console.WriteLine("Vous avez choisi : " + AvailableItems[RamdomItemB]);
            }
            else
            {
                Console.WriteLine("Vous avez choisi : " + AvailableItems[RamdomItemA]);
            }


            AvailableItems.RemoveAt(RamdomItemA);
            AvailableItems.RemoveAt(RamdomItemB > RamdomItemA ? RamdomItemB - 1 : RamdomItemB);

        }
    }
}