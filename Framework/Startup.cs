using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Framework.Startup))]
namespace Framework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
