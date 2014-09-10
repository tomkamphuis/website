using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Web.Http.Results;
using TomKamphuisOnSpaAndAngular.Controllers;
using TomKamphuisOnSpaAndAngular.Models.Slides;
using TomKamphuisOnSpaAndAngular.Repositories.AbstractRepositories;
using TomKamphuisOnSpaAndAngular.Repositories.Interfaces;

namespace TomKamphuisOnSpaAndAngular.Web.Tests.Controllers
{
    [TestClass]
    public class SlideControllerTests
    {
        [TestMethod]
        public async Task Get_Profile_Slide_When_Requesting_A_Profile_Slide()
        {
            string slideName = "Profile";

            ISlideRepository repo = new SlideRepository();
            SlideController controller = new SlideController(repo);

            var result = await controller.Get(slideName) as OkNegotiatedContentResult<SlideModel>;

            Assert.IsNotNull(result);
            Assert.AreEqual(slideName, result.Content.CurrentSlide.PageTitle, true);
        }

        [TestMethod]
        public async Task Get_Collection_With_All_Slides_When_Requesting_One()
        {
            string slideName = "Resume";

            ISlideRepository repo = new SlideRepository();
            SlideController controller = new SlideController(repo);

            var result = await controller.Get(slideName) as OkNegotiatedContentResult<SlideModel>;

            Assert.IsNotNull(result);
            Assert.AreEqual(4, result.Content.Slides.Count);
        }
    }
}