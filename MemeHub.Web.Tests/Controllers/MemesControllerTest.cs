using System;
using System.Text;
using System.Collections.Generic;
using MemeHub.Services;
using MemeHub.Services.Contracts;
using MemeHub.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MemeHub.Web.Tests.Controllers
{
    /// <summary>
    /// Summary description for MemesControllerTest
    /// </summary>
    [TestClass]
    public class MemesControllerTest
    {
        private MemesController memeController;
        private IMemesService memeService;



        [TestInitialize]
        public void Init()
        {
            this.memeService = new MemesService();
            this.memeController= new MemesController(memeService);
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            //
            // TODO: Add test logic here
            //
        }
    }
}
