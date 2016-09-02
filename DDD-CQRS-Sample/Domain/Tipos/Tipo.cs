using Domain.Generos;
using System;
using System.Collections.Generic;

namespace Domain.Tipos
{
    public class Tipo
    {
        public Guid TipoId { get; private set; }
        public string Nome { get; private set; }
        public IEnumerable<Genero> Generos { get; private set; }

        public Tipo()
        {

        }

        public Tipo(string nome)
        {
            TipoId = Guid.NewGuid();
            Nome = nome;
        }

        public void Registrar()
        {
            return;
        }
    }
}
