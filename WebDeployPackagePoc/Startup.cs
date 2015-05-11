using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebDeployPackagePoc.Startup))]
namespace WebDeployPackagePoc
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
