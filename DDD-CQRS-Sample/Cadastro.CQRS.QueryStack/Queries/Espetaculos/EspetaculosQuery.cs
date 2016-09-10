using Cadastro.Application.ViewModels;
using Cadastro.CQRS.QueryStack.Interfaces;
using System;
using System.Collections.Generic;

namespace Cadastro.CQRS.QueryStack.Queries.Espetaculos
{
    public class EspetaculosQuery : IQuery<IEnumerable<EspetaculoViewModel>>
    {
        public EspetaculosQuery()
        {
        }
    }
}
