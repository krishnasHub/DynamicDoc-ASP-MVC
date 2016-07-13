using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DynamicDoc2.Startup))]
namespace DynamicDoc2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
