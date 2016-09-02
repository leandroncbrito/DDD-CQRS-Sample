using Cadastro.CQRS.CommandStack.Interfaces;
using Core.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.CQRS.CommandStack.Events
{
    public static class DomainEvent
    {
        public static IEventDispatcher Dispatcher { get; set; }

        public static void Raise<T>(T @event) where T : IDomainEvent
        {
            Dispatcher.Dispatch(@event);
        }

    }
}
