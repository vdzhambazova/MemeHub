using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MemeHub.Web.Startup))]
namespace MemeHub.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
