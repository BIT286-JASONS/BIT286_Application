using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BIT286_Application.Startup))]
namespace BIT286_Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
