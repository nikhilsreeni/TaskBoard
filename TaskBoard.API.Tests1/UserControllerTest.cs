// <copyright file="UserControllerTest.cs" company="Microsoft">Copyright © Microsoft 2017</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskBoard.API.Controllers;
using TaskBoard.Service.Interface.User;

namespace TaskBoard.API.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for UserController</summary>
    [PexClass(typeof(UserController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class UserControllerTest
    {
        /// <summary>Test stub for .ctor(IUserService)</summary>
        [PexMethod]
        public UserController ConstructorTest(IUserService userService)
        {
            UserController target = new UserController(userService);
            return target;
            // TODO: add assertions to method UserControllerTest.ConstructorTest(IUserService)
        }
    }
}
