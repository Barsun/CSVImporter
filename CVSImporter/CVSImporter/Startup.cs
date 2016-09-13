using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CVSImporter.Startup))]
namespace CVSImporter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
