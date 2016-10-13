using Cadastro.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace Cadastro.Data.Interfaces.Espetaculos
{
    public interface IEspetaculoRepositoryMongoDb
    {
        void Adicionar(EspetaculoViewModel espetaculo);

        IEnumerable<EspetaculoViewModel> ObterTodos();

        EspetaculoViewModel ObterPorId(Guid espetaculoId);
    }
}
