using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(multitenanat.Startup))]
namespace multitenanat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
