using Cadastro.Application.Adapter;
using Cadastro.Application.ViewModels;
using Cadastro.CQRS.QueryStack.Interfaces;
using Cadastro.CQRS.QueryStack.Queries;
using Cadastro.Data.Context;
using Cadastro.Data.Interfaces;
using Domain.Espetaculos;

namespace Cadastro.CQRS.QueryStack.Queries.EspetaculoPorId
{
    public class EspetaculoPorIdQueryHandler : IQueryHandler<EspetaculoPorIdQuery, EspetaculoPorIdResult>
    {
        private CadastroContext context;
        private readonly IRepository<Espetaculo> repository;

        public EspetaculoPorIdQueryHandler(CadastroContext context, IRepository<Espetaculo> repository)
        {
            this.context = context;
            this.repository = repository;
        }

        public EspetaculoPorIdResult Executar(EspetaculoPorIdQuery query)
        {
            var result = repository.ObterPorId(query.EspetaculoId);

            // USAR MONGODB
            return new EspetaculoPorIdResult();
            //return EspetaculoAdapter.ToViewModel(result);
        }
    }
}
