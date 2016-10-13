using Cadastro.Application.ViewModels;
using Cadastro.Data.Interfaces;
using Cadastro.Data.Interfaces.Espetaculos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cadastro.Data.MongoDB.Repository
{
    public class EspetaculoRepositoryMongoDb : IEspetaculoRepositoryMongoDb
    {
        private readonly IRepositoryMongoDb<EspetaculoViewModel> repository;

        public EspetaculoRepositoryMongoDb(IRepositoryMongoDb<EspetaculoViewModel> repository)
        {
            this.repository = repository;
        }

        public void Adicionar(EspetaculoViewModel espetaculo)
        {
            repository.Adicionar(espetaculo);
        }

        public IEnumerable<EspetaculoViewModel> ObterTodos()
        {
            return repository.ObterTodos();
        }

        public EspetaculoViewModel ObterPorId(Guid espetaculoId)
        {
            return repository.Buscar(x => x.EspetaculoId == espetaculoId).FirstOrDefault();
        }
    }
}
