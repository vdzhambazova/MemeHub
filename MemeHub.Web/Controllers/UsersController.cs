using System.Web.Mvc;
using MemeHub.Models.BindingModels.Users;
using MemeHub.Models.ViewModels.Users;
using MemeHub.Services.Contracts;

namespace MemeHub.Web.Controllers
{
    [Authorize(Roles = "Poster")]
    [RoutePrefix("Users")]
    public class UsersController : Controller
    {
        private IUsersService usersService;

        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        //  GET: Users
        [HttpGet]
        [Route("Profile")]
        public ActionResult Profile()
        {
            string userName = this.User.Identity.Name;
            UserProfileViewModel upvm = this.usersService.GetProfile(userName);

            return this.View(upvm);
        }

        [HttpGet]
        [Route("Edit")]
        public ActionResult Edit()
        {
            string userName = this.User.Identity.Name;
            UserEditViewModel epvm = this.usersService.GetEditUser(userName);

            return this.View(epvm);
        }

        [HttpPost]
        [Route("Edit")]
        [ValidateAntiForgeryToken]
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