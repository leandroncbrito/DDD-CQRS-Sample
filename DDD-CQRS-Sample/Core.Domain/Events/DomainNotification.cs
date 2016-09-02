using System;
using Core.Domain.Interfaces;

namespace Core.Domain.Events
{
    public class DomainNotification : IDomainEvent
    {
        public string Key { get; private set; }
        public string Value { get; private set; }
        public DateTime DataOcorrencia { get; private set; }
        public int Versao { get; set; }

        public DomainNotification(string key, string value)
        {
            this.Key = key;
            this.Value = value;
            this.DataOcorrencia = DateTime.Now;
        }
    }
}