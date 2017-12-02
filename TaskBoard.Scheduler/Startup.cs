using Hangfire;
using Microsoft.Owin;
using Owin;
using TaskBoard.Scheduler;

[assembly: OwinStartup(typeof (Startup))]

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