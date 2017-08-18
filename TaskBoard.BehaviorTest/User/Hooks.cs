using Ninject;
using System;
using TaskBoard.BehaviorTest.Common;
using TaskBoard.Repository;
using TaskBoard.Repository.Interface;
using TaskBoard.Service.Interface.User;
using TaskBoard.Service.User;
using TechTalk.SpecFlow;

namespace TaskBoard.BehaviorTest.User
{
    [Binding, Scope(Tag ="UserHooks") ]
    public sealed class Hooks
    {
        private readonly StandardKernel _kernel = new StandardKernel();
        IUserService _userService;
        IUnitOfWork _unitOfWork;
        ICacheStorage _cacheStorage;
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        public Hooks()
        {
            _kernel.Bind<IUserService>().To<UserService>().InSingletonScope();
            _kernel.Bind(typeof(IRepository<>)).To(typeof(EntityFrameworkRepository<>)).InThreadScope();
            _kernel.Bind<IUnitOfWork>().To<UnitOfWork>().InSingletonScope();
            _kernel.Bind<ICacheStorage>().To<ScenarioConetxtCacheStorage>().InSingletonScope();
            _unitOfWork = _kernel.Get<IUnitOfWork>();
            _userService = _kernel.Get<IUserService>();
            _cacheStorage = _kernel.Get<ICacheStorage>();
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            PersistenceModel.User user = _cacheStorage.Retrieve<PersistenceModel.User>("User");
            _userService.Delete(user.UserID);
            _unitOfWork.Save();
        }
    }
}
