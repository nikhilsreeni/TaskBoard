﻿using System;
using System.Reflection;
using System.Web;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject;
using Ninject.Web.Common;
using TaskBoard.API.App_Start;
using TaskBoard.Repository;
using TaskBoard.Repository.Interface;
using TaskBoard.Repository.Repository;
using TaskBoard.Service.Backlog;
using TaskBoard.Service.Interface.Backlog;
using TaskBoard.Service.Interface.User;
using TaskBoard.Service.User;
using WebActivatorEx;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof (NinjectConfig), "Start")]
[assembly: ApplicationShutdownMethod(typeof (NinjectConfig), "Stop")]

namespace TaskBoard.API.App_Start
{
    /// <summary>
    ///     Bootstrapper for the application.
    /// </summary>
    public static class NinjectConfig
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        ///     Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof (OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof (NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        ///     Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        ///     Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

            RegisterServices(kernel);
            return kernel;
        }

        /// <summary>
        ///     Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Load(Assembly.GetExecutingAssembly());
            kernel.Bind<IUserService>().To<UserService>().InSingletonScope();
            kernel.Bind(typeof (IRepository<>)).To(typeof (EntityFrameworkRepository<>)).InRequestScope();
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>().InSingletonScope();
            kernel.Bind<IBacklogService>().To<BacklogService>().InSingletonScope();
            kernel.Bind<IMongoDbRepository>().To<MongoDBRepository>();
        }
    }
}