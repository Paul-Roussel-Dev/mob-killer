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
                var game = new Game();
                game.StartGame();
            }

            Console.ReadLine();
        }
    }
}
