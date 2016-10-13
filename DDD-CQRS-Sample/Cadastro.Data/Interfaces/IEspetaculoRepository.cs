using Domain.Espetaculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Data.Interfaces
{
    public interface IEspetaculoRepository
    {
        void Adicionar(Espetaculo espetaculo);

        void Atualizar(Espetaculo espetaculo);

        Espetaculo ObterPorId(Guid id);

        void Remover(Guid id);
    }
}
