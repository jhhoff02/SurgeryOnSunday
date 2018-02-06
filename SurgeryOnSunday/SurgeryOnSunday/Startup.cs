using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SurgeryOnSunday.Startup))]
namespace SurgeryOnSunday
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
