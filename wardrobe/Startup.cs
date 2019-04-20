using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(wardrobe.Startup))]
namespace wardrobe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
