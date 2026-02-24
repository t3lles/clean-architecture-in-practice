using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanStore.Domain.SharedContext.AggregateRoots.Abstractions;

namespace CleanStore.Application.SharedContext.Repositories.Abstractions
{
    public interface IRepository <TAggregateRoot> where TAggregateRoot : IAggregateRoot
    {
        //Task<TAggregateRoot> GetAsync(Guid id);
    }
}