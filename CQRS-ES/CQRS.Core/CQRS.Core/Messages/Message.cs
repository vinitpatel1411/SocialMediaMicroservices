using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Core.Messages
{
    public abstract class Message
    {
        // Unique identifier for the message
        public Guid Id { get; set; }
    }
}
