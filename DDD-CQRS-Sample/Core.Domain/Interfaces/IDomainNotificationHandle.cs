using System.Collections.Generic;

namespace Core.Domain.Interfaces
{
    public interface IDomainNotificationHandle<T> : IHandles<T> where T : IDomainEvent
    {
        List<T> Notify();
        bool HasNotifications();
    }
}