using Cadastro.CQRS.QueryStack.Interfaces;

namespace Cadastro.CQRS.QueryStack.Interfaces
{
    public interface IQueryDispatcher
    {
        TResult Executar<TQuery, TResult>(TQuery query) where TQuery : IQuery<TResult>;
        TResult Executar<TResult>();
    }
}
