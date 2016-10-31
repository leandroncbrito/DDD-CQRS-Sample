using MongoDB.Driver;
using System.Configuration;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;

namespace Cadastro.Data.MongoDB.Context
{
    public class MongoDbContext
    {
        public const string CONNECTION_STRING_NAME = "MongoDbConnection";

        private static readonly IMongoClient cliente;
        private static readonly IMongoDatabase banco;

        static MongoDbContext()
        {
            MongoDefaults.GuidRepresentation = GuidRepresentation.Standard;

            //var convetionPack = new ConventionPack();
            //convetionPack.Add(new CamelCaseElementNameConvention());
            //ConventionRegistry.Register("camelCase", convetionPack, x => true);

            var connectionString = ConfigurationManager.ConnectionStrings[CONNECTION_STRING_NAME].ConnectionString;
            var databaseName = ConfigurationManager.AppSettings["MongoDbDataBaseName"];

            cliente = new MongoClient(connectionString);
            banco = cliente.GetDatabase(databaseName);
        }
        
        public IMongoCollection<TEntity> GetCollection<TEntity>()
        {
            return banco.GetCollection<TEntity>(typeof(TEntity).Name.ToLower());
        }
    }
}
