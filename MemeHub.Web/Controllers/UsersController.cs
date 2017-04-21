using System.Web.Mvc;
using MemeHub.Models.Models;
using MemeHub.Models.ViewModels.Users;
using MemeHub.Services;

namespace MemeHub.Web.Controllers
{
    [Authorize(Roles = "Poster")]
    [RoutePrefix("users")]
    public class UsersController : Controller
    {
        private UsersService usersService;

        public UsersController()
        {
            this.usersService = new UsersService();
        }

        // GET: Users
        [HttpGet]
        [Route("profile")]
        public ActionResult Profile()
        {
            string userName = this.User.Identity.Name;
            UserProfileViewModel upvm = this.usersService.GetProfile(userName);
            return View(upvm);
        }

        [HttpGet]
        [Route("edit")]
        public ActionResult Edit()
        {
            return this.View();
        }
    }
}