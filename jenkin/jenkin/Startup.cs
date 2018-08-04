using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jenkin.Startup))]
namespace jenkin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
