﻿using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace TaskBoard.Repository.Repository
{
    public class MongoDbContext
    {
        public const string CONNECTION_STRING_NAME = "TaskBoardConnection";
        public const string DATABASE_NAME = "TaskBoard";

        private static readonly IMongoClient _client;
        private static readonly IMongoDatabase _database;

        static MongoDbContext()
        {
            //var connectionString = ConfigurationManager.ConnectionStrings[CONNECTION_STRING_NAME].ConnectionString;
            _client = new MongoClient();
            _database = _client.GetDatabase(DATABASE_NAME);
        }

        public IMongoQueryable<TEntity> GetCollection<TEntity>()
        {
            return _database.GetCollection<TEntity>(typeof(TEntity).Name).AsQueryable();
        }

        public void AddToCollection<TEntity>(TEntity entity)
        {
            _database.GetCollection<TEntity>(typeof(TEntity).Name).InsertOne(entity);
        }
        public async Task AddCollectionAsync<TEntity>(TEntity entity)
        {
            await _database.GetCollection<TEntity>(typeof(TEntity).Name).InsertOneAsync(entity);
        }
        public async void UpdateEntity<TEntity>(TEntity entity)
        {

            var filter = Builders<TEntity>.Filter.Eq("name", "Juni");
            var update = Builders<TEntity>.Update.Set("cuisine", "American (New)").CurrentDate("lastModified");
            var result = await _database.GetCollection<TEntity>(typeof(TEntity).Name).UpdateOneAsync(filter, update);
        }
    }
}