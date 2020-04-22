using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SAT.UI.Startup))]
namespace SAT.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
