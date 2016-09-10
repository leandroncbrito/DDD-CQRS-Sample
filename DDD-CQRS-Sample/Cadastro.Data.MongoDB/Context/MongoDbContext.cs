using MongoDB.Driver;
using System.Configuration;
using MongoDB.Bson;

namespace Cadastro.Data.MongoDB.Context
{
    public class MongoDbContext
    {
        public const string CONNECTION_STRING_NAME = "MongoDbConnection";
        public const string DATABASE_NAME = "DDD-CQRS-Sample-R";

        private static readonly IMongoClient cliente;
        private static readonly IMongoDatabase banco;

        static MongoDbContext()
        {
            MongoDefaults.GuidRepresentation = GuidRepresentation.Standard;

            var connectionString = ConfigurationManager.ConnectionStrings[CONNECTION_STRING_NAME].ConnectionString;
            cliente = new MongoClient(connectionString);
            banco = cliente.GetDatabase(DATABASE_NAME);
        }
        
        public IMongoCollection<TEntity> GetCollection<TEntity>()
        {
            return banco.GetCollection<TEntity>(typeof(TEntity).Name.ToLower());
        }
    }
}
