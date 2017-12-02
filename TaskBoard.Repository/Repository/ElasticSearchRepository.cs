using System.Collections.Generic;
using TaskBoard.PersistenceModel;
using TaskBoard.Repository.Interface;

namespace TaskBoard.Repository.Repository
{
    public class ElasticSearchRepository : IElasticSearchRepository
    {
        private readonly ElasticSearchContext _elasticSearchContext;

        public ElasticSearchRepository(ElasticSearchContext elasticSearchContext = null)
        {
            _elasticSearchContext = elasticSearchContext != null ? elasticSearchContext : new ElasticSearchContext();
        }

        public void AddNewIndex(Backlog backlog)
        {
            _elasticSearchContext.AddNewIndex(backlog);
        }

        public List<Backlog> GetResult()
        {
            return _elasticSearchContext.GetResult();
        }
    }
}