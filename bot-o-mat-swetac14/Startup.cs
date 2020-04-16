using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bot_o_mat_swetac14.Startup))]
namespace bot_o_mat_swetac14
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
