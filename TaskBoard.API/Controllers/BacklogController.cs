using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using TaskBoard.Model;
using TaskBoard.Service.Backlog;

namespace TaskBoard.API.Controllers
{
    public class BacklogController : ApiController
    {
        IBacklogService _backlogService;

        public BacklogController(IBacklogService backlogService)
        {
            _backlogService = backlogService;
        }

        // GET: api/Backlog
        [ResponseType(typeof(Backlog))]
        public IQueryable<Model.Backlog> Get()
        {
            return _backlogService.Get(); 
        }

        // GET: api/Backlog/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Backlog
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Backlog/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Backlog/5
        public void Delete(int id)
        {
        }
    }
}
