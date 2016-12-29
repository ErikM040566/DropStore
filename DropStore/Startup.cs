using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DropStore.Startup))]
namespace DropStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
