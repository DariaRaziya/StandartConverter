using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Standards_Converter.Startup))]
namespace Standards_Converter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
