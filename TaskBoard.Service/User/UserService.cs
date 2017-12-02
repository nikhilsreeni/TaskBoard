using System;
using System.Collections.Generic;
using System.Linq;
using TaskBoard.Repository.Interface;
using TaskBoard.Service.Interface.User;

namespace TaskBoard.Service.User
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(PersistenceModel.User user)
        {
            _unitOfWork.UserRepository.Add(user);
        }

        public void Delete(Guid UserID)
        {
            _unitOfWork.UserRepository.Delete(UserID);
        }

        public IEnumerable<PersistenceModel.User> Get()
        {
            var users = _unitOfWork.UserRepository.GetAll().ToList();
            if (users.Any())
            {
                return users;
            }
            return Enumerable.Empty<PersistenceModel.User>();
        }
    }
}