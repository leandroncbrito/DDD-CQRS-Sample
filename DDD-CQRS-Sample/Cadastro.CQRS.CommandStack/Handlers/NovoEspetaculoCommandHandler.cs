using Cadastro.Application;
using Cadastro.CQRS.CommandStack.Commands;
using Cadastro.CQRS.CommandStack.Events;
using Cadastro.CQRS.CommandStack.Interfaces;
using Cadastro.Data.Context;
using Cadastro.Data.Interfaces;
using Domain.Espetaculos;

namespace Cadastro.CQRS.CommandStack.Handlers
{
    public class NovoEspetaculoCommandHandler : ApplicationService, ICommandHandler<NovoEspetaculoCommand>
    {
        private CadastroContext context;
        private readonly IRepository<Espetaculo> repository;

        public NovoEspetaculoCommandHandler(CadastroContext context, IRepository<Espetaculo> repository, IUnitOfWork uow) : base(uow)
        {
            this.context = context;
            this.repository = repository;
        }

        public void Executar(NovoEspetaculoCommand command)
        {
            var espetaculo = new Espetaculo(command.Nome, command.Sinopse, command.GeneroId, command.TipoId);

            repository.Adicionar(espetaculo);

            if (Commit())
            {
                // TO DO: Lançar evento
                // DomainEvent.Raise(new AlunoPremiumEvent(pagamento.AlunoId));
            }
            
        }

    }

}
