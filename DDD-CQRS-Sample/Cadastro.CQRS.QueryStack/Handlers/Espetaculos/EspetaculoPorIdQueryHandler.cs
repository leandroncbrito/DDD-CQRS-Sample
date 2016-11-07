using Cadastro.Application.ReadModels;
using Cadastro.CQRS.QueryStack.Interfaces;
using Cadastro.CQRS.QueryStack.Queries.Espetaculo;
using Cadastro.Data.Interfaces.Espetaculos;

namespace Cadastro.CQRS.QueryStack.Handlers.Espetaculos
{
    public class EspetaculoPorIdQueryHandler : IQueryHandler<EspetaculoPorIdQuery, EspetaculoReadModel>
    {
        private readonly IEspetaculoRepositoryMongoDb repository;

        public EspetaculoPorIdQueryHandler(IEspetaculoRepositoryMongoDb repository)
        {
            this.repository = repository;
        }

        public EspetaculoReadModel Executar(EspetaculoPorIdQuery query)
        {
            return repository.ObterPorId(query.EspetaculoId);
        }
    }
}
