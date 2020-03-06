using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Text;
using System.Threading;
using System.Drawing;

namespace Mob_Killer.Entities
{
    public static class Utils
    {
        public static Random random = new Random();

        public static void SlowConsoleWriter(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(5);
            }
        }
        public static string centaur = "  <=======]}======\n    --.   /|\n   _\"/_.'/\n .'._._,.'\n :/ \\{}/\n(L  /--',----._\n    |          \\\n   : /-\\ .'-'\\ / |\n    \\, ||    \\|\n     \\/ ||    ||\n";
    }
}
