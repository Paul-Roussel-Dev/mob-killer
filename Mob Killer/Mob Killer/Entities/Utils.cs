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

        public static void slowConsoleWriter(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
        }


        //public static void displayImage()
        //{
        //    Image Picture = Image.FromFile(@"C:\Users\Amiral\Pictures\sumi_16x16.png");
        //    //Console.SetBufferSize((Picture.Width * 0x2), (Picture.Height * 0x2));
        //    FrameDimension Dimension = new FrameDimension(Picture.FrameDimensionsList[0x0]);
        //    int FrameCount = Picture.GetFrameCount(Dimension);
        //    int Left = Console.WindowLeft, Top = Console.WindowTop;
        //    char[] Chars = { ' ', '#', '.', '%', '=', '+', '*', ':', '-', '.', ' ' };
        //    Picture.SelectActiveFrame(Dimension, 0x0);
        //    for (int i = 0x0; i < Picture.Height; i++)
        //    {
        //        for (int x = 0x0; x < Picture.Width; x++)
        //        {
        //            Color Color = ((Bitmap)Picture).GetPixel(x, i);
        //            int Gray = (Color.R + Color.G + Color.B) / 0x3;
        //            int Index = (Gray * (Chars.Length - 0x1)) / 0xFF;
        //            //Console.WriteLine(Index);
        //            Console.Write(Chars[Index]);
        //        }
        //        Console.Write('\n');
        //    }

        //}


        /*
        public static void displayImage()
        {
            Image Picture = Image.FromFile(@"C:\Users\Amiral\Pictures\sumi_16x16.png");
            //Console.SetBufferSize((Picture.Width * 0x2), (Picture.Height * 0x2));
            FrameDimension Dimension = new FrameDimension(Picture.FrameDimensionsList[0x0]);
            int FrameCount = Picture.GetFrameCount(Dimension);
            int Left = Console.WindowLeft, Top = Console.WindowTop;
            char[] Chars = { ' ', '#', '.', '%', '=', '+', '*', ':', '-', '.', ' ' };
            Picture.SelectActiveFrame(Dimension, 0x0);
            for (int i = 0x0; i < Picture.Height; i++)
            {
                for (int x = 0x0; x < Picture.Width; x++)
                {
                    Color Color = ((Bitmap)Picture).GetPixel(x, i);
                    int Gray = (Color.R + Color.G + Color.B) / 0x3;
                    int Index = (Gray * (Chars.Length - 0x1)) / 0xFF;
                    //Console.WriteLine(Index);
                    Console.Write(Chars[Index]);
                }
                Console.Write('\n');
            }

        }
        */
        public static string centaur = "  <=======]}======\n    --.   /|\n   _\"/_.'/\n .'._._,.'\n :/ \\{}/\n(L  /--',----._\n    |          \\\n   : /-\\ .'-'\\ / |\n    \\, ||    \\|\n     \\/ ||    ||\n";
    }
}
