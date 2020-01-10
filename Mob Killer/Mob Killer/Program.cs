﻿using System;
using System.Collections.Generic;
using System.Linq;
using Mob_Killer.Data;
using Mob_Killer.Entities;

namespace Mob_Killer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var dboContext = new MobKillerDbContext())
            {
                //var Joueur = dboContext.Joueurs.Find(1);
                //Console.WriteLine($"{Joueur?.NameJoueur} | {Joueur?.HealthJoueur}");
                
                //var Item = dboContext.Items.Find(1);
                //Console.WriteLine($"{Item?.NameItem} | {Item?.BaseAttack}");
                
                //Item = dboContext.Items.Find(3);
                //Console.WriteLine($"{Item?.NameItem} | {Item?.BaseAttack}");
                
                //Item = dboContext.Items.Find(2);
                //Console.WriteLine($"{Item?.NameItem} | {Item?.BaseAttack}");

                //Lootphase
                var classi = new MainClass();
                List<string> Items = new List<string>() { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
                bool ValeurItem = false;
                List<string> ListItem = new List<string>();
                Random random = new Random(); // ne mettre dans le programme qu'une seule fois sinon risque de bug sur le ramdom
                classi.lootPhase(Items, ValeurItem, random, ListItem);
                ListItem.ForEach(Console.WriteLine);
                Console.WriteLine(Environment.NewLine);
                Items.ForEach(Console.WriteLine);
                Console.WriteLine(Environment.NewLine);

                classi.lootPhase(Items, ValeurItem, random, ListItem);
                Console.WriteLine(Environment.NewLine);
                ListItem.ForEach(Console.WriteLine);
                Console.WriteLine(Environment.NewLine);
                Items.ForEach(Console.WriteLine);

                //BattlePhase
                var item = new Item(1, "le Rougail Saucisse", 25, 5);
                var player = new Player(1, "BotAlviss", 100, 1, item, 30);
                var monster = new Monster("AnneSo La Beuglante", 150, 15, 15);
                var battle = new Battle();
                var win = battle.BattleResult(player, monster);

                Console.WriteLine(win ? "vous avez gagné !!" : "Vous avez perdu ... ");

            }

            Console.ReadLine();
        }
    }
}
