using Cadastro.Application.ViewModels;
using Cadastro.CQRS.QueryStack.Interfaces;
using System;
using System.Collections.Generic;

namespace Cadastro.CQRS.QueryStack.Queries.Espetaculo
{
    public class EspetaculoPorIdQuery : IQuery<EspetaculoViewModel>
    {
        public EspetaculoPorIdQuery(Guid espetaculoid)
        {
            this.EspetaculoId = espetaculoid;
        }

        public Guid EspetaculoId;

    }
}
