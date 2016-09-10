using Cadastro.Application.Adapter;
using Cadastro.Application.ViewModels;
using Cadastro.CQRS.QueryStack.Interfaces;
using Cadastro.CQRS.QueryStack.Queries;
using Cadastro.Data.Context;
using Cadastro.Data.Interfaces;
using Cadastro.Data.Repository;
using Domain.Espetaculos;

namespace Cadastro.CQRS.QueryStack.Queries.EspetaculoPorId
{
    //public class EspetaculoPorIdQueryHandler : IQueryHandler<EspetaculoPorIdQuery, EspetaculoViewModel>
    //{
    //    private CadastroContext context;
    //    private readonly IRepositoryMongoDb<EspetaculoViewModel> repository;

    //    public EspetaculoPorIdQueryHandler(CadastroContext context, IRepositoryMongoDb<EspetaculoViewModel> repository)
    //    {
    //        this.context = context;
    //        this.repository = repository;
    //    }

    //    public EspetaculoViewModel Executar(EspetaculoPorIdQuery query)
    //    {           
    //        return repository.ObterPorId(query.EspetaculoId);            
    //    }
    //}
}
