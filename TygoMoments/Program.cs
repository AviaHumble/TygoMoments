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
            }
        }
    }
}
