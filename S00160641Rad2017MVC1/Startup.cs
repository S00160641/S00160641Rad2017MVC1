using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(S00160641Rad2017MVC1.Startup))]
namespace S00160641Rad2017MVC1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
