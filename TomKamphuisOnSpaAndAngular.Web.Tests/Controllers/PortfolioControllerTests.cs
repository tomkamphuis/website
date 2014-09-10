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
        public void Profile_Action_Should_Redirect_To_Index_Action()
        {
            PortfolioController controller = new PortfolioController();

            RedirectToRouteResult result = controller.Profile() as RedirectToRouteResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.RouteValues["action"] as String);
        }

        [TestMethod]
        public void Resume_Action_Should_Redirect_To_Index_Action()
        {
            PortfolioController controller = new PortfolioController();

            RedirectToRouteResult result = controller.Resume() as RedirectToRouteResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.RouteValues["action"] as String);
        }
        [TestMethod]

        public void Portfolio_Action_Should_Redirect_To_Index_Action()
        {
            PortfolioController controller = new PortfolioController();

            RedirectToRouteResult result = controller.Portfolio() as RedirectToRouteResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.RouteValues["action"] as String);
        }

        [TestMethod]
        public void Contact_Action_Should_Redirect_To_Index_Action()
        {
            PortfolioController controller = new PortfolioController();

            RedirectToRouteResult result = controller.Contact() as RedirectToRouteResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.RouteValues["action"] as String);
        }
    }
}