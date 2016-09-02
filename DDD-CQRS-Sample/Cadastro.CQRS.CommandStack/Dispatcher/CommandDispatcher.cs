
using Cadastro.CQRS.CommandStack.Interfaces;
using Core.Domain.Exceptions;
using SimpleInjector;
using System;

namespace Cadastro.CQRS.CommandStack.Dispatcher
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly Container _resolver;

        public CommandDispatcher(Container resolver)
        {
            _resolver = resolver;
        }

        public void Executar<TCommand>(TCommand command) where TCommand : ICommand
        {
            if (command == null)
            {
                throw new ArgumentNullException("Commando nulo.");
            }

            var handler = _resolver.GetInstance<ICommandHandler<TCommand>>();

            if (handler == null)
            {
                throw new CommandHandlerNotFoundException(typeof(TCommand));
            }

            handler.Executar(command);
        }
    }

}
