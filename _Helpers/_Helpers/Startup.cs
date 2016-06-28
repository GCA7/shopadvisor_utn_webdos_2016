using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_Helpers.Startup))]
namespace _Helpers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
