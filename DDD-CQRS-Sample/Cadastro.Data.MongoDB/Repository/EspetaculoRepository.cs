using Cadastro.Application.ViewModels;
using Cadastro.CQRS.QueryStack.Queries.EspetaculoPorId;
using Cadastro.Data.Interfaces;
using Domain.Espetaculos;

namespace Cadastro.Data.MongoDB.Repository
{
    public class EspetaculoRepository
    {
        private readonly IRepositoryMongoDb<EspetaculoViewModel> repository;

        public EspetaculoRepository(IRepositoryMongoDb<EspetaculoViewModel> repository)
        {
            this.repository = repository;
        }

        // TO DO: Verificar objeto a ser passado como parametro para o Mongo
        public void Adicionar(EspetaculoViewModel espetaculo)
        {
            repository.Adicionar(espetaculo);
        }

    }
}
