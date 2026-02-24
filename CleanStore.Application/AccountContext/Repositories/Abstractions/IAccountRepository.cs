using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanStore.Application.AccountContext.UseCases.Get.Specifications;
using CleanStore.Application.SharedContext.Repositories.Abstractions;
using CleanStore.Domain.AccountContext.Entities;

namespace CleanStore.Application.AccountContext.Repositories.Abstractions
{
    public interface IAccountRepository : IRepository<Account>
    {
        Task <bool> VerifyEmailExistsAsync (string Email); 
        Task SaveAsync(Account account);

        Task<Account?> GetByIdAsync(GetByIdSpecification specification);
    }
}