using System;
using System.Collections.Generic;
using System.Text;

namespace TygoMoments.Commands
{
    class Help
    {
        public static void HelpInit()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Help.");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" Simple Commands.");
            Console.ResetColor();
            Console.WriteLine("     -m -> Generate a Tygo Moment");
        }
    }
}
