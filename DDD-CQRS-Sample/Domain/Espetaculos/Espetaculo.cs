using System;

namespace Domain.Espetaculos
{
    public class Espetaculo
    {
        protected Espetaculo() { }

        public Espetaculo(string nome, string sinopse, Guid genero, Guid tipo)
        {
            EspetaculoId = Guid.NewGuid();
            Nome = nome;
            Sinopse = sinopse;
            GeneroId = genero;
            TipoId = tipo;
        }

        public Guid EspetaculoId { get; private set; }

        public Guid TipoId { get; private set; }

        public Guid GeneroId { get; private set; }

        public string Nome { get; private set; }

        public string Sinopse { get; private set; }

        public void Registrar()
        {
            if (!this.RegistrarEspetaculoScopeValido())
                return;
        }
        
    }
}
