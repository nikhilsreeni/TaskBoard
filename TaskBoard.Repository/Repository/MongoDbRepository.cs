﻿using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using MongoDB.Bson;
using TaskBoard.Model;
using TaskBoard.Repository.Repository.Services;
using MongoDB.Driver.Linq;
using System.Linq;

namespace TaskBoard.Repository.Repository
{
    public class MongoDBRepository : IMongoDbRepository
    {

        private MongoDbContext _mongoDbContext = null;

        public MongoDBRepository(MongoDbContext mongoDbContext = null)
        {
            _mongoDbContext = mongoDbContext != null ? mongoDbContext : new MongoDbContext();
        }

        /// <summary>
        /// A generic get all method
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        public  IMongoQueryable<TEntity> GetAll<TEntity>() where TEntity : class, new()
        {
            return _mongoDbContext.GetCollection<TEntity>();
        }

        public void Add<TEntity>(TEntity entity) where TEntity : class, new()
        {
            _mongoDbContext.AddCollectionAsync(entity);
        }
    }
}