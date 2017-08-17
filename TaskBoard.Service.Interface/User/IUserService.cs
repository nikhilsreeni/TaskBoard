using System;
using System.Collections.Generic;
using TaskBoard.Model;

namespace TaskBoard.Service.Interface.User
{
    public interface IUserService
    {
        IEnumerable<Model.User> Get();
        void Add(Model.User user);
        void Delete(Guid UserID);
    }
}