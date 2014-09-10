using System.Web.Mvc;

namespace TomKamphuisOnSpaAndAngular.Web.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly string _defaultIndexAction = "Index";

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return View(_defaultIndexAction);
        }

        public ActionResult Resume()
        {
            return View(_defaultIndexAction);
        }

        public ActionResult Portfolio()
        {
            return View(_defaultIndexAction);
        }

        public ActionResult Contact()
        {
            return View(_defaultIndexAction);
        }
    }
}