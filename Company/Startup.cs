using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using WebApplication2.Models;

[assembly: OwinStartupAttribute(typeof(WebApplication2.Startup))]
namespace WebApplication2
{
    public partial class Startup
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateDefaultAdminUser();
        }

        public void CreateDefaultAdminUser()
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            ApplicationUser user = new ApplicationUser();
            user.UserName = "import@harbson.com";
            user.Email = "import@harsob.com";
            var check = userManager.Create(user, "import@harbson.com");

        }
    }
}
