using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Core.Consumers
{
    public interface IEventConsumer
    {
        void consume(string topic);
    }
}
