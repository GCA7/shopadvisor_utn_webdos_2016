using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRUDTarea.Startup))]
namespace CRUDTarea
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
