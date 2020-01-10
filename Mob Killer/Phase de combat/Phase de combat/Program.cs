using System;

namespace Mob_Killer.Battle_Phase
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = new Item(1, "le Rougail Saucisse", 25, 5);
            var player = new Player("BotAlviss",100,item,30);
            var monster = new Monster("AnneSo La Beuglante", 150, 15, 15);
            var combat = new Combat();
            var win = combat.CombatResult(player, monster);

            Console.WriteLine(win ? "vous avez gagné !!" : "Vous avez perdu ... ");
        }
        
    }
}
