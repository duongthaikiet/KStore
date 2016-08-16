using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KStore.Web.Startup))]
namespace KStore.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
