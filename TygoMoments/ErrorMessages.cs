using System;
using System.Collections.Generic;
using System.Text;

// Tygo Imports
using TygoMoments.Errors;

namespace TygoMoments
{
    class ErrorMessages
    {
        public enum ErrorState
        {
            NoError,
            NoArgsError
        }

        public static void NoArgsError()
        {
            throw new NoArgsException("No Arguments Specified: run TygoMoments -h to see all help commands.");
        }
    }
}
