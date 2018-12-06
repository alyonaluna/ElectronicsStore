using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ElectronicsStore.Web.Startup))]
namespace ElectronicsStore.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
