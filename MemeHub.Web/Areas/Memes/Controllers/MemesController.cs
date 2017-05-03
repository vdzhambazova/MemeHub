using System.Net;
using System.Web.Mvc;
using AutoMapper;
using MemeHub.Models.BindingModels.Comments;
using MemeHub.Models.BindingModels.Memes;
using MemeHub.Models.ViewModels.Comments;
using MemeHub.Models.ViewModels.Memes;
using MemeHub.Services.Contracts;

namespace MemeHub.Web.Areas.Memes.Controllers
{
    [RouteArea("Memes")]
    [Authorize(Roles = "Poster, Admin")]
    public class MemesController : Controller
    {
        private readonly IMemesService memesService;

        public MemesController(IMemesService memesService)
        {
            this.memesService = memesService;
        }

        [HttpGet]
        [Route("Details/{id}")]
        public ActionResult Details(int? id)
        {
            try
            {
                MemeDetailsViewModel mdvm = this.memesService.GetMemeDetails(id);
                return this.View(mdvm);
            }
            catch
            {
                return this.HttpNotFound();
            }
        }

        [HttpGet]
        [Route("Create")]
        public ActionResult Create()
        {
            return this.View(new MemeCreateViewModel());
        }

        [HttpPost]
        [Route("Create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MemeCreateBindingModel mcbm)
        {

            if (this.ModelState.IsValid)
            {
                string userName = this.User.Identity.Name;
                this.memesService.CreateMeme(mcbm, userName);

                return this.RedirectToAction("Profile", "Users");
            }

            return this.HttpNotFound();
        }

        [HttpGet]
        [Route("Edit/{id}")]
        public ActionResult Edit(int id)
        {
            MemeEditViewModel mevm = this.memesService.GetEditMeme(id);

            return this.View(mevm);
        }

        [HttpPost]
        [Route("Edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MemeEditBindingModel bind)
        {
            if (this.ModelState.IsValid)
            {
                this.memesService.EditMeme(id, bind);
                return RedirectToAction("Profile", "Users");
            }

            MemeEditViewModel mevm = Mapper.Map<MemeEditBindingModel, MemeEditViewModel>(bind);
            return this.View(mevm);
        }

        [HttpGet]
        [Route("Delete/{id}")]
        public ActionResult Delete(int? id)
        {
            MemeDeleteViewModel mdvm = this.memesService.GetDeleteMeme(id);

            return this.View(mdvm);
        }


        [HttpPost]
        [Route("Delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            this.memesService.DeleteMeme(id);

            return this.RedirectToAction("Profile", "Users");
        }

        [HttpPost]
        [Route("Details/{id}/addComment")]
        [ValidateAntiForgeryToken]
        public ActionResult CreateComment(MemeDetailsBindingModel mdbm, int id)
        {
            if (this.ModelState.IsValid)
            {
                this.memesService.CreateComment(mdbm.CreateComment, id);
                return RedirectToAction("Details", "Memes");
            }

            CommentCreateViewModel mevm = Mapper.Map<CommentCreateBindingModel, CommentCreateViewModel>(mdbm.CreateComment);
            return this.RedirectToAction("Details", "Memes", mevm);
        }

        [HttpGet]
        [Route("Details/{id}/loveMeme")]
        public ActionResult LoveMeme(int id)
        {
            this.memesService.LoveMeme(id);

            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
    }
}
