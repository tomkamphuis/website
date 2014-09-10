using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TomKamphuisOnSpaAndAngular.Controllers;
using System.Web.Mvc;
using TomKamphuisOnSpaAndAngular.Repositories.Interfaces;
using TomKamphuisOnSpaAndAngular.Repositories.AbstractRepositories;
using System.Threading.Tasks;

namespace TomKamphuisOnSpaAndAngular.Web.Tests.Controllers
{
    [TestClass]
    public class SlideControllerTests
    {
        [TestMethod]
        public async Task SlideTest()
        {
            ISlideRepository repo = new SlideRepository();
            SlideController controller = new SlideController(repo);

            var result = await controller.Get("Profile");

            Assert.IsNotNull(result);
        }
    }
}
