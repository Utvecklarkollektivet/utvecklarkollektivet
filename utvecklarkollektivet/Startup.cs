using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(utvecklarkollektivet.Startup))]
namespace utvecklarkollektivet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
