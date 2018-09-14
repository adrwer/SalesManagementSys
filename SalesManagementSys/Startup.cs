using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SalesManagementSys.Startup))]
namespace SalesManagementSys
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
