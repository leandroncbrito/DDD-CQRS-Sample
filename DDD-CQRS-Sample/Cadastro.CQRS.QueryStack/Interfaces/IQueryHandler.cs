using Cadastro.CQRS.QueryStack.Interfaces;

namespace Cadastro.CQRS.QueryStack.Interfaces
{
    public interface IQueryHandler<TQuery, TResult> where TQuery : IQuery<TResult>
    {
        TResult Executar(TQuery query);
    }
}
