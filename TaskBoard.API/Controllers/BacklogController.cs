using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using TaskBoard.PersistenceModel;
using TaskBoard.Service.Interface.Backlog;

namespace TaskBoard.API.Controllers
{
    [EnableCors("http://localhost:4200", "*", "*")]
    public class BacklogController : ApiController
    {
        private readonly IBacklogService _backlogService;

        public BacklogController(IBacklogService backlogService)
        {
            _backlogService = backlogService;
        }

        // GET: api/Backlog
        [ResponseType(typeof (Backlog))]
        public IQueryable<Backlog> Get()
        {
            return _backlogService.Get();
        }

        // GET: api/Backlog/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Backlog
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Backlog/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Backlog/5
        public void Delete(int id)
        {
        }
    }
}