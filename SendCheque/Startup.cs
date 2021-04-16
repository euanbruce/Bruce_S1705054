using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SendCheque.Startup))]
namespace SendCheque
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
