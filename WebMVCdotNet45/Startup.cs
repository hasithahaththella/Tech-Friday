using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebMVCdotNet45.Startup))]
namespace WebMVCdotNet45
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
