using Hangfire;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TaskBoard.Scheduler.Startup))]
namespace TaskBoard.Scheduler
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configuration.UseSqlServerStorage
                (@"data source=PIA3232\sqlserver;initial catalog=TaskBoard;integrated security=True;MultipleActiveResultSets=True");
            app.UseHangfireDashboard();
            app.UseHangfireServer();
        }
    }
}