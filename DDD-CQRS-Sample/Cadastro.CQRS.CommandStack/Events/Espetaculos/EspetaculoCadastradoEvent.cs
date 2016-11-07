using Core.Domain.Interfaces;
using Domain.Espetaculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.CQRS.CommandStack.Events.Espetaculos
{
    public class EspetaculoCadastradoEvent : IDomainEvent
    {
        public int Versao { get; private set; }
        public DateTime DataOcorrencia { get; private set; }
        public Espetaculo Espetaculo { get; private set; }

        public EspetaculoCadastradoEvent(Espetaculo espetaculo)
        {
            this.Versao = 1;
            this.Espetaculo = espetaculo;
            this.DataOcorrencia = DateTime.Now;
        }
    }
}
