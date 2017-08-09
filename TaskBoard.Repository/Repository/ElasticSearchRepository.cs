using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBoard.Model;

namespace TaskBoard.Repository.Repository
{
    public class ElasticSearchRepository
    {
        private ElasticSearchContext _elasticSearchContext = null;

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
