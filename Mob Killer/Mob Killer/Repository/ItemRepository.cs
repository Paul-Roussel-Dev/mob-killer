using Mob_Killer.Data;
using Mob_Killer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mob_Killer.Repository
{
    public class ItemRepository
    {
        public List<Item> GetItems()
        {
            using var dboContext = new MobKillerDbContext();
            var Items = dboContext.Items;
            var listItems = Items.ToList();
            return listItems;
        }
    }
}
