using System.Collections.Generic;
using TaskBoard.PersistenceModel;

namespace TaskBoard.Repository.Interface
{
    public interface IElasticSearchRepository
    {
        void AddNewIndex(Backlog backlog);
        List<Backlog> GetResult();
    }
}