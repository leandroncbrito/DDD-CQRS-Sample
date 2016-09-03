using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Data.Interfaces
{
    public interface IRepositoryNoSql<TEntity> where TEntity : class
    {
        void Adicionar(TEntity entity);
        void AdicionarVarios(IEnumerable<TEntity> entities);
        bool Atualizar(TEntity entity);
        bool Apagar(TEntity entity);
        IList<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);
        IList<TEntity> ObterTodos();
        TEntity ObterPorId(Guid id);
    }
}
