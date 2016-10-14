using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcPagingDemo.Startup))]
namespace MvcPagingDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
