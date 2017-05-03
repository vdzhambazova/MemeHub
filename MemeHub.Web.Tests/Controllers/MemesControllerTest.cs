using MemeHub.Models.BindingModels.Memes;
using MemeHub.Services.Contracts;
using MemeHub.Web.Areas.Memes.Controllers;
using MemeHub.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TestStack.FluentMVCTesting;

namespace MemeHub.Web.Tests.Controllers
{
    [TestClass]
    public class MemesControllerTest
    {
        private MemesController memeController;


        [TestInitialize]
        public void Init()
        {
            var memeServiceMock = new Mock<IMemesService>();
            this.memeController = new MemesController(memeServiceMock.Object);
        }

        [TestMethod]
        public void TestCreateGet_ShouldRenderDefaultView()
        {
            this.memeController.WithCallTo(c => c.Create())
                .ShouldRenderDefaultView();
        }

        [TestMethod]
        public void TestEditGet_ShouldRenderDefaultView()
        {
            this.memeController.WithCallTo(c => c.Edit(6))
                .ShouldRenderDefaultView();
        }

        [TestMethod]
        public void TestEditPost_ShouldRedirectCorrectly()
        {
            var mcbm = new MemeEditBindingModel()
            {
                Caption = "OMG",
            };

            this.memeController.WithCallTo(c => c.Edit(6,mcbm))
                .ShouldRedirectTo<UsersController>(co => co.Profile());
        }

        [TestMethod]
        public void TestDeleteGet_ShouldRedirectCorrectly()
        {
            int? id = 6;
            this.memeController.WithCallTo(c => c.Delete(id))
                .ShouldRenderDefaultView();
        }

        [TestMethod]
        public void TestDeletePost_ShouldRedirectCorrectly()
        {
            this.memeController.WithCallTo(c => c.Delete(6))
                .ShouldRedirectTo<UsersController>(co => co.Profile());
        }
    }
}
