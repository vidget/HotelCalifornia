using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HotelCalifornia.Startup))]
namespace HotelCalifornia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
