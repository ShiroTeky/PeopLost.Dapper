using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PeopLost.Startup))]
namespace PeopLost
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
