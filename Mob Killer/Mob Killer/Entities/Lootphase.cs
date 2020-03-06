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
        }
        public Item DroppedItems(List<Item> availableItems, Random random)
        {
            using var dboContext = new MobKillerDbContext();
            var randomItemA = availableItems[random.Next(0, availableItems.Count)];
            //Utils.SlowConsoleWriter(randomItemA.Name);
            availableItems = availableItems.Where(i => i != randomItemA).ToList();
            var randomItemB = availableItems[random.Next(0, availableItems.Count)];
            //Utils.SlowConsoleWriter(randomItemB.Name);
            availableItems = availableItems.Where(i => i != randomItemB).ToList();

            Utils.SlowConsoleWriter(" \n Choisissez à présent l'item de votre choix : \n");

            Utils.SlowConsoleWriter("0 = " + randomItemA.Name + "\n" + "1 = " + randomItemB.Name);

            var readeditem = Console.ReadLine();
            Utils.SlowConsoleWriter("Vous avez choisi : " + readeditem + "\n");

            if (readeditem != "0" && readeditem != "1")
            {
                do
                {
                    Utils.SlowConsoleWriter("Erreur de saisie veuillez écrire quelque chose de valide ! ");
                    Utils.SlowConsoleWriter("0 = " + randomItemA.Name + "\n" + "1 = " + randomItemB.Name);
                    readeditem = Console.ReadLine();
                }
                while (readeditem != "0" || readeditem != "1");
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

