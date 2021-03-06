﻿using System.Threading.Tasks;
using MongoDB.Driver.Linq;
using TaskBoard.Repository.Interface;

namespace TaskBoard.Repository.Repository
{
    public class MongoDBRepository : IMongoDbRepository
    {
        private readonly MongoDbContext _mongoDbContext;

        public MongoDBRepository()
        {
            _mongoDbContext = new MongoDbContext();
        }

        /// <summary>
        ///     A generic get all method
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        public IMongoQueryable<TEntity> GetAll<TEntity>() where TEntity : class, new()
        {
            return _mongoDbContext.GetCollection<TEntity>();
        }

        public void Add<TEntity>(TEntity entity)
        {
            _mongoDbContext.AddToCollection(entity);
        }

        public async Task AddAsyc<TEntity>(TEntity entity)
        {
            await _mongoDbContext.AddCollectionAsync(entity);
        }
    }
}