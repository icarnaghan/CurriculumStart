using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExpeditionMapper.Startup))]
namespace ExpeditionMapper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
