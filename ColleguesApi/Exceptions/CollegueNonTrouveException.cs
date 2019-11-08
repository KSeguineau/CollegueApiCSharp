using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColleguesApi.Exceptions
{


    [Serializable]
    public class CollegueNonTrouveException : Exception
    {
        public CollegueNonTrouveException() {}
        public CollegueNonTrouveException(string message) : base(message) { }
        public CollegueNonTrouveException(string message, Exception inner) : base(message, inner) { }
        protected CollegueNonTrouveException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
