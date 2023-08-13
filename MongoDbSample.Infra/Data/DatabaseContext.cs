using MongDbSample.Business.Entities;
using MongoDB.Driver;

namespace MongoDbSample.Infra.Data
{
    public abstract class DatabaseContext
    {
        private readonly IMongoDatabase _database;

        public DatabaseContext(IMongoDatabase database)
        {
            _database = database;
        }

        protected IMongoCollection<User> Users => _database.GetCollection<User>("Users");
    }
}
