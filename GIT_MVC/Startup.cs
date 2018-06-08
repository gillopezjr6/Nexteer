using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GIT_MVC.Startup))]
namespace GIT_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
