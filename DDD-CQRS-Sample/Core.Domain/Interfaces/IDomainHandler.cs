using System;
using System.Collections.Generic;

namespace Core.Domain.Interfaces
{
    public interface IDomainHandler<T> : IDisposable where T : IDomainEvent
    {
        void Handle(T args);
        IEnumerable<T> Notify();
        bool HasNotifications();
        List<T> GetValues();
    }
}