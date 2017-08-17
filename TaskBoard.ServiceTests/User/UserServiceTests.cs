using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskBoard.Service.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using TaskBoard.Service.Interface.User;
using TaskBoard.Repository.Interface;

namespace TaskBoard.Service.UserTests
{
    [TestClass()]
    public class UserServiceTests
    {
        private readonly StandardKernel _kernel = new StandardKernel();
        IUserService _userService;
        IUnitOfWork _unitOfWork;

        public UserServiceTests()
        {

        }

        [TestMethod()]
        public void UserServiceTest()
        {

            Assert.IsInstanceOfType(new UserService(_unitOfWork), typeof(IUserService));
        }

        [TestMethod()]
        public void AddTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetTest()
        {
            Assert.Fail();
        }
    }
}