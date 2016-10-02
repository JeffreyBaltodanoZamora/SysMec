using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SysMec.Startup))]
namespace SysMec
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
