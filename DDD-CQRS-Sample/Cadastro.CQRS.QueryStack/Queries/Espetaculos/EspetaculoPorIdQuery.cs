using Cadastro.Application.ReadModels;
using Cadastro.CQRS.QueryStack.Interfaces;
using System;

namespace Cadastro.CQRS.QueryStack.Queries.Espetaculo
{
    public class EspetaculoPorIdQuery : IQuery<EspetaculoReadModel>
    {
        public EspetaculoPorIdQuery(Guid espetaculoid)
        {
            this.EspetaculoId = espetaculoid;
        }

        public Guid EspetaculoId;

    }
}
