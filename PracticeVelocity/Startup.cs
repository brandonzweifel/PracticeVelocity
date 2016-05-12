using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PracticeVelocity.Startup))]
namespace PracticeVelocity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
