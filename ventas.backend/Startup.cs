using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ventas.backend.Startup))]
namespace ventas.backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
