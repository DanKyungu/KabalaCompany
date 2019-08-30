using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KabalaCompany.Web.Startup))]
namespace KabalaCompany.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
