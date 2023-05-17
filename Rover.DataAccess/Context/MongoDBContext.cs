using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Rover.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover.DataAccess.Context
{

    //public static IMongoClient mongoClient = new MongoClient();
    //public static IMongoDatabase mongoDatabase = mongoClient.GetDatabase("RoverDataBase");
    //public IMongoCollection<Entity.Concrete.Rover> mongoCollection = mongoDatabase.GetCollection<Entity.Concrete.Rover>("Rover");

    // mongo settingsi dataaccess e taşı



    public class MongoDBContext
    {
        private readonly IMongoDatabase _mongoDatabase;

        public MongoDBContext(IOptions<MongoDBSettings> mongoDBSettings)
        {
            var mongoClient = new MongoClient(mongoDBSettings.Value.ConnectionString);
            _mongoDatabase = mongoClient.GetDatabase(mongoDBSettings.Value.DatabaseName);
        }

        public IMongoCollection<T> GetMongoCollection<T>()
        {
            return _mongoDatabase.GetCollection<T>(typeof(T).Name);
        }

        public IMongoDatabase GetMongoDatabase()
        {
            return _mongoDatabase;
        }
    }
}