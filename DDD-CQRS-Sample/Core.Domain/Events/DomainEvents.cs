using Core.Domain.Interfaces;

namespace Core.Domain.Events
{
    public static class DomainEvent
    {
        public static IContainer Container { get; set; }

        public static void Raise<T>(T args) where T : IDomainEvent
        {
            if (Container == null) return;

            var obj = Container.GetInstance(typeof(IDomainHandler<T>));
            ((IDomainHandler<T>)obj).Handle(args);
        }
    }
}