using DomainValidation.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //public string Classificacao { get; private set; }

        //public int Duracao { get; private set; }

        //public string Observacoes { get; private set; }

        //public string Video { get; private set; }

        //public byte Destaque { get; private set; }

        //public IEnumerable<Evento> Eventos { get; private set; }

        //public ICollection<Comentario> Comentarios { get; private set; }

        public void Registrar()
        {
            if (!this.RegistrarEspetaculoScopeValido())
                return;
        }
        
    }
}
