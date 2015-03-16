using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Midrange.Startup))]
namespace Midrange
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
