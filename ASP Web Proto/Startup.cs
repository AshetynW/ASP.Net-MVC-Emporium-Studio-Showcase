using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_Web_Proto.Startup))]
namespace ASP_Web_Proto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
