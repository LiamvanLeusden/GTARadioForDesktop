using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandTheftAutoRadioForDesktop
{
    [Serializable]
    public class NumberOfLinesException : Exception
    {
        public NumberOfLinesException() : base() { }
        public NumberOfLinesException(string message) : base(message) { }
        public NumberOfLinesException(string message, Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client.
        protected NumberOfLinesException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
