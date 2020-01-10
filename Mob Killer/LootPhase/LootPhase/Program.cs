using System;
using System.Collections.Generic;

namespace LootPhase
{
    class Program
    {
        static void Main(string[] args)
        {
            var classi = new MainClass();
            List<string> Items = new List<string>() { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            
            List<string> ListItem = new List<string>();
            Random random = new Random(); // ne mettre dans le programme qu'une seule fois sinon risque de bug sur le ramdom
            classi.lootPhase(Items, random, ListItem);
            ListItem.ForEach(Console.WriteLine);
            Console.WriteLine(Environment.NewLine);
            Items.ForEach(Console.WriteLine);
            Console.WriteLine(Environment.NewLine);

            classi.lootPhase(Items, random, ListItem);
            Console.WriteLine(Environment.NewLine);
            ListItem.ForEach(Console.WriteLine);
            Console.WriteLine(Environment.NewLine);
            Items.ForEach(Console.WriteLine);




        }
    }
}
