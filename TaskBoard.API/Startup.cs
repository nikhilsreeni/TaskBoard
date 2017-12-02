using Microsoft.Owin;
using Owin;
using TaskBoard.API;

[assembly: OwinStartup(typeof (Startup))]

namespace TaskBoard.API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}