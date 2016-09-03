using Cadastro.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using MongoDB.Driver;
using Cadastro.Data.MongoDB.Context;

namespace Cadastro.Data.MongoDB.Repository
{
    public class RepositoryNoSql<TEntity> : IRepositoryNoSql<TEntity> where TEntity : class
    {
        //private IMongoDatabase database;
        //private IMongoCollection<TEntity> collection;

        protected MongoDbContext Db;
        protected IMongoCollection<TEntity> collection;

        public RepositoryNoSql(MongoDbContext context)
        {
            Db = context;
            collection = Db.GetCollection<TEntity>();
        }

        public void Adicionar(TEntity entity)
        {            
            collection.InsertOne(entity);            
        }        

        public void AdicionarVarios(IEnumerable<TEntity> entities)
        {
            collection.InsertMany(entities);
        }

        public bool Atualizar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Apagar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public TEntity ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

    }
}
