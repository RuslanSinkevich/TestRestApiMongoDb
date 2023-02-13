using MongoDB.Driver;
using WebResrApi.Models;

namespace WebResrApi.Database
{
    
    public class MongoDataBase
    {
        public static string connectionString = "mongodb://localhost:27017/";
        public static string databaseProduct = "product";

        static readonly MongoClient Client = new MongoClient(connectionString);
        static readonly IMongoDatabase DbName = Client.GetDatabase(databaseProduct);

        public async Task CreateDbAsync()
        {
            var collection = DbName.GetCollection<Product>("prod");
            var person = new Product() {  Name = "Dick" };
             await collection.InsertOneAsync(person);
        }
}

}
