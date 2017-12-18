using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestPatterns.Startup))]
namespace TestPatterns
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
