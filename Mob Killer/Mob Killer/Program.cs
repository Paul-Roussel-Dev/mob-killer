using System;
using System.Collections.Generic;
using System.Linq;
using Mob_Killer.Data;
using Mob_Killer.Entities;

namespace Mob_Killer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dboContext = new MobKillerDbContext())
            {
                var joueur = dboContext.Joueurs.FirstOrDefault();

                Console.WriteLine($"{joueur?.IdJoueur} | {joueur?.NameJoueur}");

                var item = new Item() { NameItem = "Excalibur" };
                var newJoueur = new Joueur()
                {
                    NameJoueur = "Roger",
                    HealthJoueur = 100.00,
                    EvasionJoueur = 15.00
                };

                dboContext.Joueurs.Add(newJoueur);
                dboContext.SaveChanges();
            }

            Console.ReadLine();
        }
    }
}
