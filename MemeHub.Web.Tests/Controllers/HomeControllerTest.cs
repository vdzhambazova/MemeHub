using System.Collections.Generic;
using System.Linq;
using MemeHub.Models.ViewModels.Memes;
using MemeHub.Services.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MemeHub.Web.Controllers;
using Moq;
using TestStack.FluentMVCTesting;

namespace MemeHub.Web.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private HomeController homeController;


        [TestInitialize]
        public void Init()
        {
            var homeService = new Mock<IHomeService>();
            this.homeController = new HomeController(homeService.Object);

            IEnumerable<MemeDisplayViewModel> memes = new List<MemeDisplayViewModel>()
            {
                new MemeDisplayViewModel()
                {
                    Caption = "OMG",
                    MemeImageUrl = "http://i0.kym-cdn.com/photos/images/facebook/000/993/875/084.png",
                    MemePoints = 20,
                },

                new MemeDisplayViewModel()
                {
                    Caption = "WOWW",
                    MemeImageUrl = "https://imgflip.com/s/meme/Doge.jpg",
                    MemePoints = 100000
                }
            };

            homeService.Setup(h => h.GetAll()).Returns(memes);
        }

        [TestMethod]
        public void TestAll_ShouldRenderIndexViewAndShouldReturnCorrectModelWithCorrectPropertyValues()
        {
            this.homeController.WithCallTo(c => c.All())
                .ShouldRenderView("Index")
                .WithModel<IEnumerable<MemeDisplayViewModel>>(l => l.ElementAt(0).MemeImageUrl == "http://i0.kym-cdn.com/photos/images/facebook/000/993/875/084.png" 
                && l.ElementAt(0).Caption == "OMG" 
                && l.ElementAt(0).MemePoints == 20);
        }   

        [TestMethod]
        public void TestFreshest_ShouldRenderIndexView()
        {
            this.homeController.WithCallTo(c => c.Freshest()).ShouldRenderView("Index");
        }

        [TestMethod]
        public void TestDank_ShouldRenderIndexView()
        {
            this.homeController.WithCallTo(c => c.Dank()).ShouldRenderView("Index");
        }

        [TestMethod]
        public void TestFun_ShouldRenderIndexView()
        {
            this.homeController.WithCallTo(c => c.Fun()).ShouldRenderView("Index");
        }

        [TestMethod]
        public void TestAwesome_ShouldRenderIndexView()
        {
            this.homeController.WithCallTo(c => c.Awesome()).ShouldRenderView("Index");
        }


    }
}
