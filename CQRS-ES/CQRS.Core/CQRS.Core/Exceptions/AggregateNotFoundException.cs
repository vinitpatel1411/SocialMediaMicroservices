using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Core.Exceptions
{
    public class AggregateNotFoundException : Exception
    {
        public AggregateNotFoundException(string message) : base(message)
        {
        }
    }
}
