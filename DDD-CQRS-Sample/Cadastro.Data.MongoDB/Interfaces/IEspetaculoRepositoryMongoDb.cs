using Cadastro.Application.ReadModels;
using System;
using System.Collections.Generic;

namespace Cadastro.Data.Interfaces.Espetaculos
{
    public interface IEspetaculoRepositoryMongoDb
    {
        void Adicionar(EspetaculoReadModel espetaculo);

        IEnumerable<EspetaculoReadModel> ObterTodos();

        EspetaculoReadModel ObterPorId(Guid espetaculoId);
    }
}
