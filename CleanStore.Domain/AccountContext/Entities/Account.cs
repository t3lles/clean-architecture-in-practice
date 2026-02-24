using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanStore.Domain.AccountContext.ValueObjects;
using CleanStore.Domain.ShareContextContext.Entities;
using CleanStore.Domain.AccountContext.Events;
using CleanStore.Domain.SharedContext.AggregateRoots.Abstractions;

namespace CleanStore.Domain.AccountContext.Entities
{
    public sealed class Account : Entity, IAggregateRoot
    {
        #region Constructors 
        private Account() : base(Guid.NewGuid())
        {
            
        }

        private Account(
            Guid id,
            Email email) : base (id)
        {
            Email = email;
        }

        #endregion
        
        #region Properties 
        public Email Email {get; private set;} = null!;

        #endregion
    
        #region Factories

         public static Account Create(Email email)
        {
            var id = Guid.NewGuid();
            var account = new Account(id, email);
            account.RaiseDomainEvent(new OnAccountCreateEvent(id, email));

            return account;
        }
        #endregion
    }
}