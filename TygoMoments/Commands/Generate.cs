using System;
using System.Collections.Generic;
using System.Text;

namespace TygoMoments.Commands
{
    class Generate
    {
        public static void GenerateRun()
        {
            List<string> momentsArray = new List<string> { "Cock", "Ok", "Lol", "what", "we big funny", "FAT", "Roboootootoototototo", "Yes", "No", "pp", "yesyes pp", "FAT", "robot.bald = miau miuo pio pio", "fun fact earth is a plate in a sphere", "i do be faLLIN DOE", "in spaxce here", "/ban @robotdance23", "wafels", "carlos", "stop", "Hello! Welcome to Central Hospital! How can I help you?", "ur so old big grandpa", "BOBOT", "im 12", "uhjk", "im playing rust", "bc i was gone", "bc i had to eat", "a", "so i open and close on command", "im being spammed by a kid", "steam vc", "No rbx furries better", "Yff6fycuc", "Y", "discord rpc: playing soundpad", "big yes server", "@robotdance23 @robotdance23 @robotdance23 @robotdance23 @robotdance23 @robotdance23 @robotdance23 @robotdance23 @robotdance23 @robotdance23 free mention button", "[DR] Tygay", "i forgot abour crossing", "i dont care", "im currently learnign javascrupt tho", "but i can learn c#", "did humnle tell", "i just wanna have some fun", "im on discord bc my school has discord server", "i have online school", "does alternos hosting lagg?", "ok idid it", "Hi", "School proof", "Il do it In a bit When im home", "Cool", "Im on phone", "ok my birthday is 5 februari", "im 19 and i hate neighbours neighbour neighbour neighbour neighbour neighbour neighbour neighbour neighbour neighbour", "permsission to join?", "Can i join?", "fuck your mom", "add back plsplsplspls", "Why", "I might have to do homewirk tho", "Im on school to", "Oj", "Oh ok", };
            Random random = new Random();
            int index = random.Next(momentsArray.Count);
            Console.WriteLine(momentsArray[index]);
        }
    }
}
