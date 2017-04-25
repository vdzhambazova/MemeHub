using System.Web.Mvc;
using MemeHub.Models.ViewModels.Memes;
using MemeHub.Services;

namespace MemeHub.Web.Controllers
{
    [RoutePrefix("memes")]
    [Authorize(Roles = "Poster")]
    public class MemesController : Controller
    {
        private MemesService memesService;

        public MemesController()
        {
            this.memesService = new MemesService();
        }

        [HttpGet]
        [Route("details/{id}")]
        public ActionResult Details(int? id)
        { 
            MemeDetailsViewModel mdvm = this.memesService.GetMemeDetails(id);

            if (mdvm == null)
            {
                return HttpNotFound();
            }

            return View(mdvm);
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            string userName = this.User.Identity.Name;
            MemeCreateViewModel mcvm = this.memesService.GetCreateMeme(userName);
            return View();
        }

        [HttpPost]
        [Route("create")]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [Route("edit/{id}")]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Profile", "Users");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            return View();
        }


        [HttpPost]
        [Route("delete/{Id}")]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Profile", "Users");
            }
            catch
            {
                return View();
            }
        }
    }
}
