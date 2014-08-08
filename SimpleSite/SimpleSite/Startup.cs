using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleSite.Startup))]
namespace SimpleSite
{
    public partial class Startup
    {
        // The OwinStartupAttribute above is responsible for having
        // the method below being invoked almost immediately after 
        // Application_Start in Global.asax.cs
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
