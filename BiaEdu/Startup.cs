using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BiaEdu.Startup))]
namespace BiaEdu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
