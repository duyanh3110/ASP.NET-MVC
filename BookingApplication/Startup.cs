using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookingApplication.Startup))]
namespace BookingApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
