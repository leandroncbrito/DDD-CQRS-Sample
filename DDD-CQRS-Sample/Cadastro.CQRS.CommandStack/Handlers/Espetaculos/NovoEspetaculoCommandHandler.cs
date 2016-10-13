using Cadastro.Application;
using Cadastro.CQRS.CommandStack.Commands.Espetaculos;
using Cadastro.CQRS.CommandStack.Interfaces;
using Cadastro.Data.Interfaces;
using Domain.Espetaculos;

namespace Cadastro.CQRS.CommandStack.Handlers.Espetaculos
{
    public class NovoEspetaculoCommandHandler : ApplicationService, ICommandHandler<NovoEspetaculoCommand>
    {
        //private CadastroContext context;
        private readonly IEspetaculoRepository repository;

        public NovoEspetaculoCommandHandler(IEspetaculoRepository repository, IUnitOfWork uow) : base(uow)
        {
            //this.context = context;
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
