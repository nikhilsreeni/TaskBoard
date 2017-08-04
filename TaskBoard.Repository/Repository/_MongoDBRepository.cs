//using MongoDB.Bson;
//using MongoDB.Bson.IO;
//using MongoDB.Bson.Serialization;
//using MongoDB.Driver;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TaskBoard.Model;
//using MongoDB.Driver.Linq;
//using System.Linq.Expressions;

//namespace TaskBoard.Repository.Repository
//{
//    public class _MongoDBRepository
//    {
//        MongoClient _client;
//        IMongoDatabase _db;
//        string outputFileName = "c:/test.txt"; // initialize to the output file

//        public _MongoDBRepository()
//        {
//            _client = new MongoClient();
//            _db = _client.GetDatabase("TaskBoard");
//        }


//        public IEnumerable<Backlog> GetBacklog()
//        {
//            var collection = _db.GetCollection<Backlog>("Backlog");
//            return collection.AsQueryable<Backlog>();
//        }
//        public IMongoQueryable<Backlog> GetFiltered(Expression<Func<Backlog, bool>> predicate)
//        {
//            return _db.GetCollection<Backlog>(typeof(Backlog).Name)
//                .AsQueryable().Where(predicate);
//        }

//    }
//}
