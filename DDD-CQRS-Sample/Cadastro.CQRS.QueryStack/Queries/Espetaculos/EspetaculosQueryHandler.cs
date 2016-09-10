using Cadastro.Application.ViewModels;
using Cadastro.CQRS.QueryStack.Interfaces;
using Cadastro.Data.Context;
using Cadastro.Data.Interfaces;
using System.Collections.Generic;

namespace Cadastro.CQRS.QueryStack.Queries.Espetaculos
{
    public class EspetaculosQueryHandler : IQueryHandler<IEnumerable<EspetaculoViewModel>>
    {
        private readonly CadastroContext context;
        private readonly IRepositoryMongoDb<EspetaculoViewModel> repository;

        public EspetaculosQueryHandler(CadastroContext context, IRepositoryMongoDb<EspetaculoViewModel> repository)
        {
            this.context = context;
            this.repository = repository;
        }

        public IEnumerable<EspetaculoViewModel> Executar()
        {
            return repository.ObterTodos();
        }
    }
}
