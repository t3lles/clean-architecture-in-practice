using CleanStore.Domain.AccountContext.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanStore.Application.AccountContext.UseCases.Create.Events
{
    internal class OnAccountCreatedEventHandler : INotificationHandler<OnAccountCreateEvent>
    {
        public Task Handle(OnAccountCreateEvent notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"{notification.Email} se cadastrou!");
            return Task.CompletedTask;
        }
    }
}
