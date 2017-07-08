using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrainingApp.Startup))]
namespace TrainingApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
