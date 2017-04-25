using System.Web.Mvc;
using MemeHub.Models.BindingModels;
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

        //  GET: Users
        [HttpGet]
        [Route("profile")]
        public ActionResult Profile()
        {
            string userName = this.User.Identity.Name;
            UserProfileViewModel upvm = this.usersService.GetProfile(userName);

            return this.View(upvm);
        }

        [HttpGet]
        [Route("edit")]
        public ActionResult Edit()
        {
            string userName = this.User.Identity.Name;
            UserEditViewModel epvm = this.usersService.GetEditUser(userName);

            return this.View(epvm);
        }

        [HttpPost]
        [Route("edit")]
        public ActionResult Edit(UserEditBindingModel uebm)
        {
            string userName = this.User.Identity.Name;

            if (ModelState.IsValid)
            {
                this.usersService.EditUser(uebm, userName);
                return this.RedirectToAction("Profile");
            }


            UserEditViewModel uevm = this.usersService.GetEditUser(userName);

            return this.View(uevm);
        }
    }
}