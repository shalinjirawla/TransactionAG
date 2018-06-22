using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TAG.Startup))]
namespace TAG
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
