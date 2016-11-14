using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomerActivityLog.Startup))]
namespace CustomerActivityLog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
