using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project_F.Startup))]
namespace Project_F
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
