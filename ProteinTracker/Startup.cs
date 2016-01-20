using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProteinTracker.Startup))]
namespace ProteinTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
