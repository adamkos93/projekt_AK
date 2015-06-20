using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(project_AK.Startup))]
namespace project_AK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
