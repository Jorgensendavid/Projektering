using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hemsidan.Startup))]
namespace Hemsidan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
