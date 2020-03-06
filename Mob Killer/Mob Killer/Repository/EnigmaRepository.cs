using Mob_Killer.Data;
using Mob_Killer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mob_Killer.Repository
{
    public class EnigmaRepository
    {
        public List<Enigma> GetEnigma()
        {
            using var dboContext = new MobKillerDbContext();
            var enigmas = dboContext.Enigmas;
            var listEnigma = enigmas.ToList();
            int ramdomQuestion = listEnigma.Count;

            var random = new Random();
            int ramdomQuestionChoice = random.Next(0, ramdomQuestion);

            return listEnigma;
        }
        public Enigma GetRamdomEnigma()
        {
            using var dboContext = new MobKillerDbContext();
            var enigmas = dboContext.Enigmas;
            var listEnigma = enigmas.ToList();
            int ramdomQuestion = listEnigma.Count;

            var random = new Random();
            int ramdomQuestionChoice = random.Next(0, ramdomQuestion);

            return listEnigma[ramdomQuestionChoice];
        }
    }
}
