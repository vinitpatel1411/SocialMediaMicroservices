using CQRS.Core.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Core.Events
{
    public abstract class BaseEvent: Message
    {
        protected BaseEvent(string type)
        {
            this.Type = type;
        }
        public int Version { get; set; }
        public string Type { get; set; }
    }
}
