using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZeroApp1.Startup))]
namespace ZeroApp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
