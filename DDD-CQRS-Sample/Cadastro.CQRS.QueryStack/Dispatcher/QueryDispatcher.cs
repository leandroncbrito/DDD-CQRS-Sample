using Cadastro.CQRS.QueryStack.Interfaces;
using Core.Domain.Exceptions;
using SimpleInjector;
using System;

namespace Cadastro.CQRS.QueryStack.Dispatcher
{
    public class QueryDispatcher : IQueryDispatcher
    {
        private readonly Container _resolver;

        public QueryDispatcher(Container resolver)
        {
            _resolver = resolver;
        }

        public TResult Executar<TQuery, TResult>(TQuery query) where TQuery : IQuery<TResult>
        {
            if (query == null)
            {
                throw new ArgumentNullException("query");
            }

            var handler = _resolver.GetInstance<IQueryHandler<TQuery, TResult>>();

            if (handler == null)
            {
                throw new QueryHandlerNofFoundException(typeof(TQuery));
            }

            return handler.Executar(query);
        }

        public TResult Executar<TResult>()
        {
            var handler = _resolver.GetInstance<IQueryHandler<TResult>>();

            if (handler == null)
            {
                throw new QueryHandlerNofFoundException(null);
            }

            return handler.Executar();
        }
    }
}
