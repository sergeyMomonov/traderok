using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Traderok.Web.Startup))]
namespace Traderok.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
