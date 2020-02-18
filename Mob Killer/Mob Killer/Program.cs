using System;
using System.Collections.Generic;
using System.Linq;
using LootPhase;
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
                Console.WriteLine(Utils.centaur);
                //var Joueur = dboContext.Joueurs.Find(1);
                //Console.WriteLine($"{Joueur?.NameJoueur} | {Joueur?.HealthJoueur}");

                //var Item = dboContext.Items.Find(1);
                //Console.WriteLine($"{Item?.NameItem} | {Item?.BaseAttack}");

                //Item = dboContext.Items.Find(3);
                //Console.WriteLine($"{Item?.NameItem} | {Item?.BaseAttack}");

                //Item = dboContext.Items.Find(2);
                //Console.WriteLine($"{Item?.NameItem} | {Item?.BaseAttack}");

                //Lootphase
                //var classi = new MainClass();

                //classi.lootPhase1(Utils.random);

                //var Item = new Item();
                //List<int> ListAvailableItemsId = new List<int>();
                //List<Item> ListAvailableItems = new List<Item>();
                //ListAvailableItems = Item.GetItems();
                //foreach (Item item1 in ListAvailableItems)
                //{
                //    int AvailableItemId = item1.IdItem;
                //    ListAvailableItemsId.Add(AvailableItemId);
                //}               
                //bool ValeurItem = false;
                //List<int> ListAlreadyProposedItemId = new List<int>();
                //List<Item> ListAlreadyProposedItem = new List<Item>();
                //ListAlreadyProposedItem = Item.GetItems();

                //Random random = new Random(); // ne mettre dans le programme qu'une seule fois sinon risque de bug sur le ramdom
                //classi.lootPhase(ListAvailableItemsId, ValeurItem, random, ListAlreadyProposedItemId);
                //ListAlreadyProposedItemId.ForEach(Console.WriteLine);
                //Console.WriteLine(Environment.NewLine);
                //ListAvailableItemsId.ForEach(Console.WriteLine);
                //Console.WriteLine(Environment.NewLine);

                //classi.lootPhase(ListAvailableItemsId, ValeurItem, random, ListAlreadyProposedItemId);
                //Console.WriteLine(Environment.NewLine);
                //ListAlreadyProposedItemId.ForEach(Console.WriteLine);
                //Console.WriteLine(Environment.NewLine);
                //ListAvailableItemsId.ForEach(Console.WriteLine);

                //BattlePhase
<<<<<<< HEAD
                var listMonster = new Monster().GetMonsters();
                var randomMonster = Utils.random.Next(0, listMonster.Count);
                var listItem = new Item().GetItems();
                var randomItem = Utils.random.Next(0, listItem.Count);
                var dialogue = new Dialogue();
                ////var item = new Item(1, "le Rougail Saucisse", 25, 5);
                var player = new Player(1, "BotAlviss", 100, 1, listItem[randomItem], 30);
                //var battle = new Battle();
                //var win = battle.BattleResult(player, listMonster[randomMonster]);

                //Console.WriteLine(win ? "vous avez gagné !!" : "Vous avez perdu ... ");
=======
                var item = new Item(1, "le Rougail Saucisse", 25, 5);
                var player = new Player(1, "BotAlviss", 100, 1, item, 30);
                var monster = new Monster("AnneSo La Beuglante", 150, 15, 15, "-*-");
                var battle = new Battle();
                var win = battle.BattleResult(player, monster);
>>>>>>> master

                var stage = new Stage();
                stage.StartStage(player, listMonster[randomMonster],listItem[randomItem], dialogue);

            }

            Console.ReadLine();
        }
    }
}
