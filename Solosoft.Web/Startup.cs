using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Solosoft.Web.Startup))]
namespace Solosoft.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
