using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _250401_텍스트RPG
{
    class Util
    {
        public static void Print(string context, ConsoleColor textcolor = ConsoleColor.White, int delay = 0)
        {
            Console.ForegroundColor = textcolor;
            Console.WriteLine(context);
            Thread.Sleep(delay);
            Console.ResetColor();
        }
    }
}
