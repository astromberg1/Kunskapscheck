using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kunskapscheckMVC.Startup))]
namespace kunskapscheckMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
