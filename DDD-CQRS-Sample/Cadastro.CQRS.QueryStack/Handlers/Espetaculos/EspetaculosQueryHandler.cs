using Cadastro.Application.ViewModels;
using Cadastro.CQRS.QueryStack.Interfaces;
using System.Collections.Generic;
using Cadastro.CQRS.QueryStack.Queries.Espetaculo;
using Cadastro.Data.Interfaces.Espetaculos;

namespace Cadastro.CQRS.QueryStack.Handlers.Espetaculos
{
    public class EspetaculosQueryHandler : IQueryHandler<IEnumerable<EspetaculoViewModel>>
    {
        private readonly IEspetaculoRepositoryMongoDb repository;

        public EspetaculosQueryHandler(IEspetaculoRepositoryMongoDb repository)
        {
            this.repository = repository;
        }

        public IEnumerable<EspetaculoViewModel> Executar()
        {
            return repository.ObterTodos();
        }

    }
}
