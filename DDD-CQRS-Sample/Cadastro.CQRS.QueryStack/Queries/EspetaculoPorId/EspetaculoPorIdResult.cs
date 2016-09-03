using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.CQRS.QueryStack.Queries.EspetaculoPorId
{
    public class EspetaculoPorIdResult
    {
        public Guid EspetaculoId { get; set; }

        public Guid TipoId { get; set; }

        public Guid GeneroId { get; set; }

        public string Nome { get; set; }

        public string Sinopse { get; set; }
    }
}
