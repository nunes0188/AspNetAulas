using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aula250517.Startup))]
namespace Aula250517
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
