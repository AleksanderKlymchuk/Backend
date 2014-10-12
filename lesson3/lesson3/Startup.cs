using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lesson3.Startup))]
namespace lesson3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
