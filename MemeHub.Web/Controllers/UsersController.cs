using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MemeHub.Services;

namespace MemeHub.Web.Controllers
{
    public class UsersController : Controller
    {
        private UsersService usersService;

        public UsersController()
        {
            this.usersService = new UsersService();
        }

        // GET: Users
        public ActionResult Profile()
        {
            string userName = this.User.Identity.Name;
            UserProfileViewModel upvm = this.usersService.GetProfile(userName);
            return View(upvm);
        }
    }
}