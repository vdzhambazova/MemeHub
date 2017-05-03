using System.Collections.Generic;
using System.Web.Mvc;
using MemeHub.Models.ViewModels.Memes;
using MemeHub.Services.Contracts;

namespace MemeHub.Web.Controllers
{
    [RequireHttps]
    [RoutePrefix("Home")]
    [Authorize(Roles="Poster, Admin")]
    public class HomeController : Controller
    {
        private readonly IHomeService homeService;

        public HomeController(IHomeService homeService)
        {
            this.homeService = homeService;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("All")]
        [Route("~/", Name = "default")]
        public ActionResult All()
        {
            IEnumerable<MemeDisplayViewModel> mdvm = this.homeService.GetAll();

            return View("Index", mdvm);
        }

        [HttpGet]
        [Route("Freshest")]
        public ActionResult Freshest()
        {
            IEnumerable<MemeDisplayViewModel> mdvm = this.homeService.GetNew();

            return View("Index", mdvm);
        }

        [HttpGet]
        [Route("Dank")]
        public ActionResult Dank()
        {
            IEnumerable<MemeDisplayViewModel> mdvm = this.homeService.GetDank();

            return View("Index", mdvm);
        }

        [HttpGet]
        [Route("Fun")]
        public ActionResult Fun()
        {
            IEnumerable<MemeDisplayViewModel> mdvm = this.homeService.GetFun();

            return View("Index", mdvm);
        }

        [HttpGet]
        [Route("Awesome")]
        public ActionResult Awesome()
        {
            IEnumerable<MemeDisplayViewModel> mdvm = this.homeService.GetAwesome();

            return View("Index", mdvm);
        }
    }
}