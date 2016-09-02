using System;

namespace Core.Domain.Interfaces
{
    public interface IDomainEvent
    {
        int Versao { get; set; }
        DateTime DataOcorrencia { get; }
    }
}