using System;
using System.Collections.Generic;
using System.Text;

namespace Mob_Killer.Entities
{
    public class Enigma
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }

        // if bool Response == true responseA is the good response if Response == false its responseB who is the good response
    }
}
