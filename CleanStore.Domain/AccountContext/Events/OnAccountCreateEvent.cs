using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanStore.Domain.ShareContext.Events;

namespace CleanStore.Domain.AccountContext.Events
{
    public sealed record OnAccountCreateEvent(Guid Id, string Email) : IDomainEvent
    {
        
    }
}