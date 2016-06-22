using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserDefinedException
{
    class NegetiveNumberException : Exception
    {
        public NegetiveNumberException()
            : base("Illigal operation for a negetive number.")
        {
        }

        public NegetiveNumberException(string message)
            : base(message)
        {
        }

        public NegetiveNumberException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
