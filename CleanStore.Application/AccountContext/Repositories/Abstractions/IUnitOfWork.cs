using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanStore.Application.AccountContext.Repositories.Abstractions
{
    public interface IUnitOfWork
    {
        Task CommitAsync();

        Task RollbackAsync();
    }
}