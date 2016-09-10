using Cadastro.Data.Interfaces;
using Domain.Espetaculos;
using System;
using System.Linq;

namespace Cadastro.Data.Repository
{
    public class EspetaculoRepository
    {
        private readonly IRepository<Espetaculo> repository;

        public EspetaculoRepository(IRepository<Espetaculo> repository)
        {
            this.repository = repository;
        }

        public void Adicionar(Espetaculo espetaculo)
        {
            repository.Adicionar(espetaculo);
        }

        public void Atualizar(Espetaculo espetaculo)
        {
            repository.Atualizar(espetaculo);
        }

        public void Remover(Guid id)
        {
            repository.Remover(id);
        }

        public Espetaculo ObterPorId(Guid id)
        {
            return repository.ObterPorId(id);
        }

    }
}
