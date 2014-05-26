using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdoptionShelter.Startup))]
namespace AdoptionShelter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
