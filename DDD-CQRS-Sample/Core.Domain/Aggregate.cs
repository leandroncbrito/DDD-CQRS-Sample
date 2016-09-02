using System;
using Core.Domain.Interfaces;

namespace Core.Domain
{
    public class Aggregate : IAggregate
    {
        public Aggregate()
        {
            this.Id = Guid.NewGuid();
        }

        public Aggregate(Guid id)
        {
            this.Id = id;
        }

        public Guid Id { get; protected set; }
    }
}
