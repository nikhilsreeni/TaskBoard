using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBoard.Model;
using TaskBoard.Repository;
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

        public void Add(Model.User user)
        {
            _unitOfWork.UserRepository.Add(user);
        }

        public void Delete(Guid UserID)
        {
            _unitOfWork.UserRepository.Delete(UserID);
        }

        public IEnumerable<Model.User> Get()
        {
            var users = _unitOfWork.UserRepository.GetAll().ToList();
            if (users.Any())
            {
                return users;
            }
            return Enumerable.Empty<Model.User>();
        }
    }
}
