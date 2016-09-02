using System;

namespace Core.Domain.Interfaces
{
    public interface IAggregate
    {
        Guid Id { get; }
    }
}