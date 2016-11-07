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
        public Espetaculo Espetaculo { get; private set; }

        public EspetaculoCadastradoEvent(Espetaculo espetaculo)
        {
            this.Espetaculo = espetaculo;
        }
    }
}
