using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TravelExpertsWebsite.Startup))]
namespace TravelExpertsWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
