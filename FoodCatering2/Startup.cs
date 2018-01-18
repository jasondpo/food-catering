using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodCatering2.Startup))]
namespace FoodCatering2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
