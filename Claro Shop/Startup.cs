using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Claro_Shop.Startup))]
namespace Claro_Shop
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
