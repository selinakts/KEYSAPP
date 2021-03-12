using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Covid19ApiConsume.Startup))]
namespace Covid19ApiConsume
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
