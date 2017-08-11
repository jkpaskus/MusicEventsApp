using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicApp_Aug2017.Startup))]
namespace MusicApp_Aug2017
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
