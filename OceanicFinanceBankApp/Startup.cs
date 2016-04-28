using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OceanicFinanceBankApp.Startup))]
namespace OceanicFinanceBankApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
