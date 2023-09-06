using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webapp.Backend.Startup))]
namespace Webapp.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
