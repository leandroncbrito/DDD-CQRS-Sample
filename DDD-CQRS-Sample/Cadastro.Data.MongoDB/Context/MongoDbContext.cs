using MongoDB.Driver;
using System.Configuration;

namespace Cadastro.Data.MongoDB.Context
{
    public class MongoDbContext
    {
        public const string CONNECTION_STRING_NAME = "MongoConnection";
        public const string DATABASE_NAME = "DDD-CQRS-Sample-R";

        private static readonly IMongoClient _client;
        private static readonly IMongoDatabase _database;

        static MongoDbContext()
        {
            var connectionString = ConfigurationManager.ConnectionStrings[CONNECTION_STRING_NAME].ConnectionString;
            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase(DATABASE_NAME);
        }
        
        public IMongoCollection<TEntity> GetCollection<TEntity>()
        {
            return _database.GetCollection<TEntity>(typeof(TEntity).Name.ToLower());
        }
    }
}
