﻿using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using TaskBoard.BehaviorTest.Common;
using TaskBoard.Repository;
using TaskBoard.Repository.Interface;
using TaskBoard.Service.Interface.User;
using TaskBoard.Service.User;
using TechTalk.SpecFlow;

namespace TaskBoard.BehaviorTest.User
{
    [Binding]
    public class UserSteps
    {
        private readonly StandardKernel _kernel = new StandardKernel();
        private readonly ICacheStorage _cacheStorage;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserService _userService;

        public UserSteps()
        {
            _kernel.Bind<IUserService>().To<UserService>().InSingletonScope();
            _kernel.Bind(typeof (IRepository<>)).To(typeof (EntityFrameworkRepository<>)).InThreadScope();
            _kernel.Bind<IUnitOfWork>().To<UnitOfWork>().InSingletonScope();
            _kernel.Bind<ICacheStorage>().To<ScenarioConetxtCacheStorage>().InSingletonScope();
            _unitOfWork = _kernel.Get<IUnitOfWork>();
            _userService = _kernel.Get<IUserService>();
            _cacheStorage = _kernel.Get<ICacheStorage>();
        }

        [Given(@"Database connection is present")]
        public void GivenDatabaseConnectionIsPresent()
        {
            Assert.IsNotNull(
                Convert.ToString(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString));
        }


        [Given(@"User details with username as (.*), password as (.*) and  dateofbirth as (.*)"),
         Scope(Tag = "UserHooks")]
        public void GivenUserDetailsWithUsernameAsTestPasswordAsTestpassAndDateOfBirthAs(string username,
            string password, string dateofbirth)
        {
            var NewUser = new PersistenceModel.User
            {
                UserID = Guid.NewGuid(),
                UserName = username,
                Password = password,
                DateOfBirth = DateTime.ParseExact(dateofbirth, "dd-mm-yyyy", null)
            };
            _userService.Add(NewUser);

            _cacheStorage.Store("User", NewUser);
        }

        [When(@"I save"), Scope(Tag = "UserHooks")]
        public void WhenISave()
        {
            _unitOfWork.Save();
        }

        [Then(@"value shoud be saved to database"), Scope(Tag = "UserHooks")]
        public void ThenValueShoudBeSavedToDatabase()
        {
            _userService.Get();
        }
    }
}