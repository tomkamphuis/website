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
            return RedirectToAction(_defaultIndexAction);
        }

        public ActionResult Resume()
        {
            return RedirectToAction(_defaultIndexAction);
        }

        public ActionResult Portfolio()
        {
            return RedirectToAction(_defaultIndexAction);
        }

        public ActionResult Contact()
        {
            return RedirectToAction(_defaultIndexAction);
        }
    }
}