using System.Collections.Generic;
using System.Web.Http;
using TaskBoard.PersistenceModel;
using TaskBoard.Service.Interface.User;

namespace TaskBoard.API.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IEnumerable<User> Get()
        {
            return _userService.Get();
        }

        public void Add(User user)
        {
            _userService.Add(user);
        }
    }
}