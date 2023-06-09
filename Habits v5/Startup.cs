using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Habits_v5.Startup))]
namespace Habits_v5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
