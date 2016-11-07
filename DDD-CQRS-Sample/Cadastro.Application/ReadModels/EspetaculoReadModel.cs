using Domain;
using System;

namespace Cadastro.Application.ReadModels
{
    public class EspetaculoReadModel : EntityBase
    {
        public Guid EspetaculoId { get; set; }

        public Guid TipoId { get; set; }

        public Guid GeneroId { get; set; }

        public string Nome { get; set; }

        public string Sinopse { get; set; }
    }
}
