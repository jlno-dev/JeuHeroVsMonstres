using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApplWebSite.Startup))]
namespace ApplWebSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
