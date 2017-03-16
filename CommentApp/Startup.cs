using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CommentApp.Startup))]
namespace CommentApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
