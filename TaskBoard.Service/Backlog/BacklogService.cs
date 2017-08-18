using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBoard.PersistenceModel;
using TaskBoard.Repository.Interface;
using TaskBoard.Service.Interface.Backlog;

namespace TaskBoard.Service.Backlog
{
    public class BacklogService : IBacklogService
    {

        private readonly IMongoDbRepository _mongoDBRepository;

        public BacklogService(IMongoDbRepository MongoDbRepository)
        {
            _mongoDBRepository = MongoDbRepository;
        }
        
        public BacklogService()
        {
            // _mongoDBRepository = new MongoDBRepository();
        }
        public void Add(PersistenceModel.Backlog backlog)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid ID)
        {
            throw new NotImplementedException();
        }

        public IQueryable<PersistenceModel.Backlog> Get()
        {
            return _mongoDBRepository.GetAll<PersistenceModel.Backlog>();
            //return _mongoDBRepository.GetBacklog() as IEnumerable<PersistenceModel.Backlog>;
        }
    }
}
