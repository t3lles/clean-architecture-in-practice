using CleanStore.Application.AccountContext.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanStore.Infrastructure.SharedContext
{
    internal class UnitOfWork (AppDbContext context) : IUnitOfWork
    {
        public async Task CommitAsync()
        {
            await context.SaveChangesAsync();
        }

        public Task RollbackAsync()
          => Task.CompletedTask;
        
    }
}
