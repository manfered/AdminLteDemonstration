using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdminLteDemonstration.Startup))]
namespace AdminLteDemonstration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
