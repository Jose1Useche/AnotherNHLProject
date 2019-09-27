using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NHL_Project.Startup))]
namespace NHL_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
