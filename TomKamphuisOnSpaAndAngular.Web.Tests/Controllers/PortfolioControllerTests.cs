using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TomKamphuisOnSpaAndAngular;
using TomKamphuisOnSpaAndAngular.Web.Controllers;
using TomKamphuisOnSpaAndAngular.Repositories.AbstractRepositories;
using TomKamphuisOnSpaAndAngular.Repositories.Interfaces;

namespace TomKamphuisOnSpaAndAngular.Web.Tests.Controllers
{
    [TestClass]
    public class PortfolioControllerTests
    {
        [TestMethod]
        public void Index_Action_Should_Return_ViewResult()
        {
            PortfolioController controller = new PortfolioController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Profile_Action_Should_Use_Index_View()
        {
            PortfolioController controller = new PortfolioController();

            ViewResult result = controller.Profile() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]
        public void Resume_Action_Should_Use_Index_View()
        {
            PortfolioController controller = new PortfolioController();

            ViewResult result = controller.Resume() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ViewName);
        }
        [TestMethod]

        public void Portfolio_Action_Should_Use_Index_View()
        {
            PortfolioController controller = new PortfolioController();

            ViewResult result = controller.Portfolio() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]
        public void Contact_Action_Should_Use_Index_View()
        {
            PortfolioController controller = new PortfolioController();

            ViewResult result = controller.Contact() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ViewName);
        }
    }
}