using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test2015.Startup))]
namespace test2015
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
