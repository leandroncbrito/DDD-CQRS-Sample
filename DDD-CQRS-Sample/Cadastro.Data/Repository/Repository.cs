using Cadastro.Data.Context;
using Cadastro.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected CadastroContext Db;
        protected DbSet<TEntity> DbSet;

        public Repository(CadastroContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Adicionar(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            DbSet.Add(entity);
        }
        
        public virtual void Atualizar(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            
            DbSet.Attach(entity);
            Db.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Remover(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public virtual TEntity ObterPorId(Guid id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> ObterTodos()
        {
            return DbSet.ToList();
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
