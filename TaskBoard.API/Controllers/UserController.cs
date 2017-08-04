using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaskBoard.Service.User;

namespace TaskBoard.API.Controllers
{
    public class UserController : ApiController
    {
        IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        public IEnumerable<Model.User> Get()
        {
            return _userService.Get();
        }

        public void Add(Model.User user)
        {
            _userService.Add(user);
        }

    }
}
