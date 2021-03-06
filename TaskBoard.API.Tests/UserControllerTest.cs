using System.Collections.Generic;
using TaskBoard.PersistenceModel;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Generated;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskBoard.API.Controllers;
using TaskBoard.Service.Interface.User;

namespace TaskBoard.API.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for UserController</summary>
    [TestClass]
    [PexClass(typeof(UserController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class UserControllerTest
    {

        /// <summary>Test stub for Get()</summary>
        [PexMethod]
        public IEnumerable<User> GetTest([PexAssumeUnderTest]UserController target)
        {
            IEnumerable<User> result = target.Get();
            return result;
            // TODO: add assertions to method UserControllerTest.GetTest(UserController)
        }
        [TestMethod]
        [PexGeneratedBy(typeof(UserControllerTest))]
        [PexRaisedException(typeof(NullReferenceException))]
        public void GetTestThrowsNullReferenceException68801()
        {
            using (PexDisposableContext disposables = PexDisposableContext.Create())
            {
                IEnumerable<User> iEnumerable;
                var userController = new UserController((IUserService)null);
                disposables.Add((IDisposable)userController);
                iEnumerable = this.GetTest(userController);
                disposables.Dispose();
            }
        }




        /// <summary>Test stub for Add(User)</summary>
        [PexMethod]
        public void AddTest([PexAssumeUnderTest]UserController target, User user)
        {
            target.Add(user);
            // TODO: add assertions to method UserControllerTest.AddTest(UserController, User)
        }
    }
}
