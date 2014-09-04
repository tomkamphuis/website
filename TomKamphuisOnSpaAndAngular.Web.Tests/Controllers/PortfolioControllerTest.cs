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
    public class PortfolioControllerTest
    {
        [TestMethod]
        public void Index()
        {
            ISlideRepository repo = new SlideRepository();

            // Arrange
            PortfolioController controller = new PortfolioController(repo);

            // Act
            ViewResult result = controller.Index(string.Empty) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}