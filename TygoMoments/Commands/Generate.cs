using System;
using System.Collections.Generic;
using System.Text;

namespace TygoMoments.Commands
{
    class Generate
    {
        public static void GenerateRun()
        {
            List<string> momentsArray = new List<string> { "Cock", "Ok", "Lol", "what", "we big funny", "FAT", "Roboootootoototototo", "Yes", "No", "pp", "yesyes pp", "FAT", "robot.bald = miau miuo pio pio", "fun fact earth is a plate in a sphere", "i do be faLLIN DOE", "in spaxce here", "/ban @robotdance23", "wafels", "carlos", "stop", "Hello! Welcome to Central Hospital! How can I help you?", "ur so old big grandpa", "BOBOT" };
            Random random = new Random();
            int index = random.Next(momentsArray.Count);
            Console.WriteLine(momentsArray[index]);
        }
    }
}
