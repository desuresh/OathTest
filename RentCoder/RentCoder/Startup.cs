using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentCoder.Startup))]
namespace RentCoder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
