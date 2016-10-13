using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Data.Interfaces
{
    public interface IRepositoryMongoDb<TEntity> where TEntity : EntityBase
    {
        void Adicionar(TEntity entity);
        void AdicionarVarios(IEnumerable<TEntity> entities);
        void Atualizar(TEntity entity);
        void Apagar(TEntity entity);
        void ApagarVarios(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> ObterTodos();
        TEntity ObterPorId(Guid id);
    }
}
