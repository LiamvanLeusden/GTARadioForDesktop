using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandTheftAutoRadioForDesktop
{
    [Serializable]
    public class TypeOfFileNotFoundException : Exception
    {
        public TypeOfFileNotFoundException() : base() { }
        public TypeOfFileNotFoundException(string message) : base(message) { }
        public TypeOfFileNotFoundException(string message, Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client.
        protected TypeOfFileNotFoundException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
