using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HandyMan.Startup))]
namespace HandyMan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
