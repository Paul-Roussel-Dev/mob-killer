using System;
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
                var Joueur = dboContext.Joueurs.Find(1);
                Console.WriteLine($"{Joueur?.NameJoueur} | {Joueur?.HealthJoueur}");
                
                var Item = dboContext.Items.Find(1);
                Console.WriteLine($"{Item?.NameItem} | {Item?.BaseAttack}");
                
                Item = dboContext.Items.Find(3);
                Console.WriteLine($"{Item?.NameItem} | {Item?.BaseAttack}");
                
                Item = dboContext.Items.Find(2);
                Console.WriteLine($"{Item?.NameItem} | {Item?.BaseAttack}");


                //var newItem = new Item() { 
                //    IdItem = 2,
                //    NameItem = "Excalibur",
                //    BaseAttack = 5.00,
                //    BonusEvasion = 5.00
                //};

                //var newJoueur = new Joueur()
                //{
                //    IdJoueur = 2,
                //    NameJoueur = "Roger",
                //    HealthJoueur = 100.00,
                //    EvasionJoueur = 15.00,
                //    ItemId = 2
                //};

                //dboContext.Items.Add(newItem);
                //dboContext.Joueurs.Add(newJoueur);
                //dboContext.SaveChanges();

            }

            Console.ReadLine();
        }
    }
}
