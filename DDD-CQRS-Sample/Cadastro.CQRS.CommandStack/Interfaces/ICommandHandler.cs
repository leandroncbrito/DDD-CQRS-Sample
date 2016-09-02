namespace Cadastro.CQRS.CommandStack.Interfaces
{
    public interface ICommandHandler<TCommand>
    {
        void Executar(TCommand command);
    }
}
