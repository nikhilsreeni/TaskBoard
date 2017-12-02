using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using TaskBoard.API.Models;

namespace TaskBoard.API.Controllers
{
    [EnableCors("http://localhost:4200", "*", "*")]
    public class CommentsController : ApiController
    {
        // GET: api/Comments
        public IEnumerable<Comment> GetComments()
        {
            return new List<Comment>
            {
                new Comment {author = "dfsd"},
                new Comment {text = "dfsdfsd"}
            };
        }
    }
}