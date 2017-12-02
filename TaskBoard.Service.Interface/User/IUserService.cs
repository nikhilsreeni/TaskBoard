using System;
using System.Collections.Generic;

namespace TaskBoard.Service.Interface.User
{
    public interface IUserService
    {
        IEnumerable<PersistenceModel.User> Get();
        void Add(PersistenceModel.User user);
        void Delete(Guid UserID);
    }
}