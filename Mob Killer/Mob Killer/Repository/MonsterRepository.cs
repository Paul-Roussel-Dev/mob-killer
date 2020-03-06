using Mob_Killer.Data;
using Mob_Killer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mob_Killer.Repository
{
    public class MonsterRepository
    {

        public List<Monster> GetMonsters()
        {

            using var dboContext = new MobKillerDbContext();
            var Monstres = dboContext.Monsters;
            var list = Monstres.ToList();

            return list;
        }

        public Monster MonsterChoosen(List<Monster> monsters, Random random)
        {
            var randomMonster = monsters[random.Next(0, monsters.Count)];
            monsters = monsters.Where(i => i != randomMonster).ToList();
            return randomMonster;
        }

    }
}
