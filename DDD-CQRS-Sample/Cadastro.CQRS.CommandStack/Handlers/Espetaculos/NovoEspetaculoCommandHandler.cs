using Cadastro.Application;
using Cadastro.Application.Adapter;
using Cadastro.Application.ViewModels;
using Cadastro.CQRS.CommandStack.Commands.Espetaculos;
using Cadastro.CQRS.CommandStack.Events;
using Cadastro.CQRS.CommandStack.Interfaces;
using Cadastro.Data.Interfaces;
using Cadastro.Data.Interfaces.Espetaculos;
using Core.Domain.Events;
using Domain.Espetaculos;
using System;

namespace Cadastro.CQRS.CommandStack.Handlers.Espetaculos
{
    public class NovoEspetaculoCommandHandler : ApplicationService, ICommandHandler<NovoEspetaculoCommand>
    {
        private readonly IEspetaculoRepository repository;
        

        public NovoEspetaculoCommandHandler(IEspetaculoRepository repository, IUnitOfWork uow) : base(uow)
        {
            this.repository = repository;            
        }

        public void Executar(NovoEspetaculoCommand command)
        {
            var espetaculo = new Espetaculo(command.Nome, command.Sinopse, command.GeneroId, command.TipoId);

            espetaculo.Registrar();
                        
            repository.Adicionar(espetaculo);
            
            if (Commit())
            {   
                DomainEvent.Raise(new EspetaculoCadastradoEvent(espetaculo));
            }
            
        }

    }

}
