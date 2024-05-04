using MongoDB.Driver;

namespace NswagDemo.Entity
{
    public class MongoDBContext 
    {
        private readonly IMongoDatabase _database;

        public MongoDBContext(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }

        public IMongoCollection<T> GetCollection<T>()
        {
            var collectionName = GetCollectionName(typeof(T));
            return _database.GetCollection<T>(collectionName);
        }

        private static string GetCollectionName(Type type)
        {
            var attribute = (BsonCollectionAttribute)Attribute.GetCustomAttribute(type, typeof(BsonCollectionAttribute));
            return attribute?.CollectionName ?? type.Name.ToLower();
        }
    }
}
