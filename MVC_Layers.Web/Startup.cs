using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Layers.Startup))]
namespace MVC_Layers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
