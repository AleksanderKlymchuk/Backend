using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lesson01.Startup))]
namespace lesson01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
