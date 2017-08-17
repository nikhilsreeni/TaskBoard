using System.Collections.Generic;
using TaskBoard.Model;

namespace TaskBoard.Repository.Interface
{
    public interface IElasticSearchRepository
    {
        void AddNewIndex(Backlog backlog);
        List<Backlog> GetResult();
    }
}