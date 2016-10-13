using Cadastro.CQRS.CommandStack.Interfaces;
using System;

namespace Cadastro.CQRS.CommandStack.Commands.Espetaculos
{
    public class NovoEspetaculoCommand : ICommand
    {
        public NovoEspetaculoCommand(string nome, string sinopse, Guid tipoId, Guid generoId)
        {
            Nome = nome;
            Sinopse = sinopse;
            TipoId = tipoId;
            GeneroId = generoId;
        }

        public Guid TipoId { get; private set; }

        public Guid GeneroId { get; private set; }

        public string Nome { get; private set; }

        public string Sinopse { get; private set; }
    }
}
