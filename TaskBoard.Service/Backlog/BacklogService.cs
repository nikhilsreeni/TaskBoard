using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBoard.Model;
using TaskBoard.Repository.Repository;

namespace TaskBoard.Service.Backlog
{
    public class BacklogService : IBacklogService
    {

        private readonly MongoDBRepository _mongoDBRepository;

        public BacklogService()
        {
            _mongoDBRepository = new MongoDBRepository();
        }
        public void Add(Model.Backlog backlog)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid ID)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Model.Backlog> Get()
        {
            return _mongoDBRepository.GetAll<Model.Backlog>();
            //return _mongoDBRepository.GetBacklog() as IEnumerable<Model.Backlog>;
        }
    }
}
