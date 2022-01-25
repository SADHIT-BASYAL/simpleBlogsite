using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(simpleBlogsite.Startup))]
namespace simpleBlogsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
