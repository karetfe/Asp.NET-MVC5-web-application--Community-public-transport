using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CommunityTransport.Startup))]
namespace CommunityTransport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
