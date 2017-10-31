using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WNomina.Startup))]
namespace WNomina
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
