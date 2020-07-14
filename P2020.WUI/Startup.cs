using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(P2020.WUI.Startup))]
namespace P2020.WUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
