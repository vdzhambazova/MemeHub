using System.Collections.Generic;
using System.Web.Mvc;
using MemeHub.Models.ViewModels.Memes;
using MemeHub.Services;

namespace MemeHub.Web.Controllers
{
    [RequireHttps]
    [RoutePrefix("Home")]
    [Authorize(Roles="Poster")]
    public class HomeController : Controller
    {
        private HomeService homeService;

        public HomeController()
        {
            this.homeService = new HomeService();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("Hottest")]
        public ActionResult All()
        {
            IEnumerable<MemeпProfileViewModel> mdvm = this.homeService.GetAll();

            //return RedirectToAction("Index", mdvm);
            return View("~/Views/Home/Index.cshtml", mdvm);
        }

        [HttpGet]
        [Route("Freshest")]
        public ActionResult New()
        {
            IEnumerable<MemeпProfileViewModel> mdvm = this.homeService.GetNew();

            return View("~/Views/Home/Index.cshtml", mdvm);
        }

        [HttpGet]
        [Route("Dank")]
        public ActionResult Dank()
        {
            IEnumerable<MemeпProfileViewModel> mdvm = this.homeService.GetDank();

            return View("~/Views/Home/Index.cshtml", mdvm);
        }

        [HttpGet]
        [Route("Fun")]
        public ActionResult Fun()
        {
            IEnumerable<MemeпProfileViewModel> mdvm = this.homeService.GetFun();

            return View("~/Views/Home/Index.cshtml", mdvm);
        }

        [HttpGet]
        [Route("Awesome")]
        public ActionResult Awesome()
        {
            IEnumerable<MemeпProfileViewModel> mdvm = this.homeService.GetAwesome();

            return View("~/Views/Home/Index.cshtml", mdvm);
        }

        //public ActionResult Index(IEnumerable<MemeDisplayViewModel> mdvm)
        //{
        //    return this.View(mdvm);
        //}
    }
}