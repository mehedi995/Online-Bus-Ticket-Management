using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BTM.Startup))]
namespace BTM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
