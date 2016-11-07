using Cadastro.Application.ReadModels;
using Cadastro.Data.Interfaces;
using Cadastro.Data.Interfaces.Espetaculos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cadastro.Data.MongoDB.Repository
{
    public class EspetaculoRepositoryMongoDb : IEspetaculoRepositoryMongoDb
    {
        private readonly IRepositoryMongoDb<EspetaculoReadModel> repository;

        public EspetaculoRepositoryMongoDb(IRepositoryMongoDb<EspetaculoReadModel> repository)
        {
            this.repository = repository;
        }

        public void Adicionar(EspetaculoReadModel espetaculo)
        {
            repository.Adicionar(espetaculo);
        }

        public IEnumerable<EspetaculoReadModel> ObterTodos()
        {
            return repository.ObterTodos();
        }

        public EspetaculoReadModel ObterPorId(Guid espetaculoId)
        {
            return repository.Buscar(x => x.EspetaculoId == espetaculoId).FirstOrDefault();
        }
    }
}
