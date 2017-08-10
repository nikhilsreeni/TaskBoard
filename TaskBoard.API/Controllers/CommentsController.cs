using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using TaskBoard.API.Models;

namespace TaskBoard.API.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class CommentsController : ApiController
    {

        // GET: api/Comments
        public IEnumerable<Comment> GetComments()
        {
            return new List<Comment> {
                new Comment { author = "dfsd" },
                new Comment { text="dfsdfsd"}
            };
        }

      
    }
}