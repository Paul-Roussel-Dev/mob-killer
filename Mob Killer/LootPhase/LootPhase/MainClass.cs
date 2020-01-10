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
        public void lootPhase(List<string> Items, Random random, List<string> ListItem)
        {
            int RamdomItemA = random.Next(0, Items.Count);
            ListItem.Add(Items[RamdomItemA]);


            Console.WriteLine("Bravo Vous venez de remporter votre duel ! \n Choisissez à présent l'item de votre choix : \n");

            Console.WriteLine("0 = " + Items[RamdomItemA]);
            
            int RamdomItemB = random.Next(0, Items.Count);
            

            do
            {
                for (int j = 0; j < ListItem.Count; j++)
                {
                    if (ListItem[j] == Items[RamdomItemB])
                    {
                        RamdomItemB = random.Next(0, Items.Count);
                    }
                }
            } while (RamdomItemA == RamdomItemB);

            ListItem.Add(Items[RamdomItemB]);


            Console.WriteLine("1 = " + Items[RamdomItemB]);

            string item = Console.ReadLine();
            

            if (item == "1")
            {
                Console.WriteLine("Vous avez choisi : " + Items[RamdomItemB]);
            }
            else
            {
                Console.WriteLine("Vous avez choisi : " + Items[RamdomItemA]);
            }


            Items.RemoveAt(RamdomItemA);
            Items.RemoveAt(RamdomItemB>RamdomItemA ? RamdomItemB - 1 : RamdomItemB );

        }
    }
}
