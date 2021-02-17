using System;
using System.Collections.Generic;
using System.Text;

namespace TygoMoments.Errors 
{
    [Serializable]
    public class NoArgsException : Exception
    {
        public NoArgsException() { }

        public NoArgsException (string message)
            : base(message) { }

        public NoArgsException (string message, Exception inner)
            : base(message, inner) { }
    }
}
