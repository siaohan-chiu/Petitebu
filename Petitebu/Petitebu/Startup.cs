using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Petitebu.Startup))]
namespace Petitebu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
