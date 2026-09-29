using CQRS.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Core.Handlers
{
    public interface IEventSourcingHandlers<T>
    {
        Task SaveAsync(AggregateRoot aggregate);
        Task<T> GetByIdAsync(Guid aggregateId);
        Task RepublishEventsAsync();
    }
}
