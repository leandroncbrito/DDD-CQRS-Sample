using Cadastro.Application.ViewModels;
using Cadastro.CQRS.QueryStack.Interfaces;
using Cadastro.CQRS.QueryStack.Queries.Espetaculo;
using Cadastro.Data.Context;
using Cadastro.Data.Interfaces;
using Cadastro.Data.Interfaces.Espetaculos;

namespace Cadastro.CQRS.QueryStack.Handlers.Espetaculos
{
    public class EspetaculoPorIdQueryHandler : IQueryHandler<EspetaculoPorIdQuery, EspetaculoViewModel>
    {
        private readonly IEspetaculoRepositoryMongoDb repository;

        public EspetaculoPorIdQueryHandler(IEspetaculoRepositoryMongoDb repository)
        {
            this.repository = repository;
        }

        public EspetaculoViewModel Executar(EspetaculoPorIdQuery query)
        {
            return repository.ObterPorId(query.EspetaculoId);
        }
    }
}
