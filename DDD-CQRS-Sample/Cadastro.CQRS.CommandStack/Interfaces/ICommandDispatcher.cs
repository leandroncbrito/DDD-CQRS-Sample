using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.CQRS.CommandStack.Interfaces
{
    public interface ICommandDispatcher
    {
        void Executar<TCommand>(TCommand command) where TCommand : ICommand;
    }
}
