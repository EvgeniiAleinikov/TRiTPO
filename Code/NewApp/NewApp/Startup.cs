using Microsoft.Owin;
using System;
using System.Threading.Tasks;
using Owin;
[assembly: OwinStartupAttribute(typeof(NewApp.Startup))]
[assembly: OwinStartup(typeof(NewApp.Startup))]
namespace NewApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
