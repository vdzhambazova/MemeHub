using System.Web.Mvc;
using MemeHub.Services;
using MemeHub.Services.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MemeHub.Web.Controllers;

namespace MemeHub.Web.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private HomeController homeController;
        private IHomeService homeService;

        
         
        [TestInitialize]
        public void Init()
        {
            this.homeService = new HomeService();
            this.homeController = new HomeController(homeService);
        }

        [TestMethod]
        public void Index()
        {
           

            // Act
            ViewResult result = this.homeController.All() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
