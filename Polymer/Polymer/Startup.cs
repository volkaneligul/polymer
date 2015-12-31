using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Polymer.Startup))]
namespace Polymer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
