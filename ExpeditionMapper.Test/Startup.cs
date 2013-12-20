using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExpeditionMapper.Test.Startup))]
namespace ExpeditionMapper.Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
