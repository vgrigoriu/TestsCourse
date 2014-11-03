using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    [Serializable]
    public class DivideException : Exception
    {
        public DivideException() { }
        public DivideException(string message) : base(message) { }
        public DivideException(string message, Exception inner) : base(message, inner) { }
        protected DivideException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
