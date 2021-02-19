using System;
using System.IO;

// Tygo Imports
using static TygoMoments.ErrorMessages;
using TygoMoments.Commands;

namespace TygoMoments
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arguments = Environment.GetCommandLineArgs();

            ErrorState errorState = ErrorState.NoError;

            // Check if there are actually any args.
            if(args.Length == 0)
            {
                // Run the System Error message.
                errorState = ErrorState.NoArgsError;

                ErrorMessages.NoArgsError();
            }

            // Handle the Help command.
            if(arguments[1] == "--help" || arguments[1] == "-h")
            {
                Commands.Help.HelpInit();
            } else if(arguments[1] == "--generate" || arguments[1] == "-m")
            {
                Commands.Generate.GenerateRun();
            } else if (arguments[1] == "--recursive" || arguments[1] == "-r")
            {
                Console.WriteLine("How many do you want? PS. Loads = u want to kill urself");
                int times = int.Parse(Console.ReadLine());
                Commands.Recursive.StartRecursive(times);
            }
        }
    }
}
