using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wardrobe.Startup))]
namespace Wardrobe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
