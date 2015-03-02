using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TakeANumber.Startup))]
namespace TakeANumber
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
