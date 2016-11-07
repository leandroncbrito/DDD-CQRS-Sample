using Cadastro.Application.ReadModels;
using Cadastro.CQRS.QueryStack.Interfaces;
using System.Collections.Generic;
using Cadastro.Data.Interfaces.Espetaculos;

namespace Cadastro.CQRS.QueryStack.Handlers.Espetaculos
{
    public class EspetaculosQueryHandler : IQueryHandler<IEnumerable<EspetaculoReadModel>>
    {
        private readonly IEspetaculoRepositoryMongoDb repository;

        public EspetaculosQueryHandler(IEspetaculoRepositoryMongoDb repository)
        {
            this.repository = repository;
        }

        public IEnumerable<EspetaculoReadModel> Executar()
        {
            return repository.ObterTodos();
        }

    }
}
