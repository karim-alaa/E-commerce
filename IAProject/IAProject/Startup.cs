using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IAProject.Startup))]
namespace IAProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
