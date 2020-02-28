using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CycleUK.Startup))]
namespace CycleUK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
