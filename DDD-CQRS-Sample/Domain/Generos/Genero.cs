using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Generos
{
    public class Genero
    {
        public Guid GeneroId { get; private set; }
        public string Nome { get; private set; }
        //public IEnumerable<Tipo> Tipos { get; set; }
        //public IEnumerable<Espetaculo> Espetaculos { get; set; }

        public Genero()
        {
            
        }

        public Genero(string nome)
        {
            GeneroId = Guid.NewGuid();
            Nome = nome;
        }

        public void Registrar()
        {
            return;
        }
    }
}
