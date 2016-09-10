using Cadastro.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using MongoDB.Driver;
using Cadastro.Data.MongoDB.Context;
using Domain;

namespace Cadastro.Data.MongoDB.Repository
{
    public class RepositoryMongoDb<TEntity> : IRepositoryMongoDb<TEntity> where TEntity : EntityBase
    {
        protected MongoDbContext Db;
        protected IMongoCollection<TEntity> collection;

        public RepositoryMongoDb(MongoDbContext context)
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

        public void Atualizar(TEntity entity)
        {
            collection.FindOneAndReplace(x => x.Id == entity.Id, entity);
        }

        public void Apagar(TEntity entity)
        {
            collection.DeleteOne(x => x.Id == entity.Id);
        }
        
        public void ApagarVarios(Expression<Func<TEntity, bool>> predicate)
        {
            collection.DeleteMany(predicate);
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return collection.Find(predicate).ToList();
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return collection.Find(FilterDefinition<TEntity>.Empty).ToList();
        }

        public TEntity ObterPorId(Guid id)
        {
            return collection.Find(x => x.Id == id).FirstOrDefault();
        }

    }
}
