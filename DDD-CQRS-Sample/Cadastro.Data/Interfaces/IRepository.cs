using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Data.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity obj);
        void Atualizar(TEntity obj);
        void Remover(Guid id);
        TEntity ObterPorId(Guid id);
        IEnumerable<TEntity> ObterTodos();        
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);
        int SaveChanges();
    }
}
