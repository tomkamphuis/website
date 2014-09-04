using System.Web.Mvc;
using TomKamphuisOnSpaAndAngular.Models.Slides;
using TomKamphuisOnSpaAndAngular.Repositories.Interfaces;

namespace TomKamphuisOnSpaAndAngular.Web.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly ISlideRepository _repo;

        public PortfolioController(ISlideRepository repo)
        {
            _repo = repo;
        }

        public ActionResult Index(string slide)
        {
            // Haal de hashtag uit de url voor directe repo actie...
            if(!string.IsNullOrEmpty(slide))
            {
                SlideModel model = new SlideModel();
            }

            return View();
        }
    }
}