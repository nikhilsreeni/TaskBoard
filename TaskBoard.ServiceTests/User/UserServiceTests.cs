using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskBoard.Repository.Interface;
using TaskBoard.Service.Interface.User;
using TaskBoard.Service.User;

namespace TaskBoard.Service.UserTests
{
    [TestClass]
    public class UserServiceTests
    {
        private IUnitOfWork _unitOfWork;
        private IUserService _userService;

        [TestMethod]
        public void UserServiceInstanceNullException()
        {
            Assert.IsNotNull(new UserServiceTests());
        }

        [TestMethod]
        public void UserServiceInterfaceImplementation()
        {
            Assert.IsInstanceOfType(new UserService(_unitOfWork), typeof (IUserService));
        }

        [TestMethod]
        public void AddTest()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void DeleteTest()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void GetTest()
        {
            Assert.Fail();
        }
    }
}