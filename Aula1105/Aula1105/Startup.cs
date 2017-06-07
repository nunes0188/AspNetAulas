using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aula1105.Startup))]
namespace Aula1105
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
