using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HoangNamSport.Startup))]
namespace HoangNamSport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
