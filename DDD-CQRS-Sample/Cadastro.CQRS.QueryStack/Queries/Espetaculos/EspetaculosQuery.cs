using Cadastro.Application.ReadModels;
using Cadastro.CQRS.QueryStack.Interfaces;
using System.Collections.Generic;

namespace Cadastro.CQRS.QueryStack.Queries.Espetaculos
{
    public class EspetaculosQuery : IQuery<IEnumerable<EspetaculoReadModel>>
    {
        public EspetaculosQuery()
        {
        }
    }
}
