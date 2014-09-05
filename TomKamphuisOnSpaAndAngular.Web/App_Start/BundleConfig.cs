using System.Web;
using System.Web.Optimization;

namespace TomKamphuisOnSpaAndAngular
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Bundles/Bootstrap").Include(
                      "~/Static/JS/plugins.js",
                      "~/Static/JS/custom.js"));

            bundles.Add(new ScriptBundle("~/Bundles/JQueryComponents").Include(
                      "~/Static/JS/jquery.easytabs.min.js",
                      "~/Static/JS/respond.min.js",
                      "~/Static/JS/jquery.prettyPhoto.js",
                      "~/Static/JS/jquery.isotope.min.js",
                      "~/Static/JS/jquery-ui-map.js",
                      "~/Static/JS/jquery.carouFredSel.js"));

            bundles.Add(new ScriptBundle("~/Bundles/Angular").Include(
                      "~/Static/JS/Angular/angular.js",
                      "~/Static/JS/Angular/angular-sanitize.js"));

            bundles.Add(new StyleBundle("~/Content/CSS").Include(
                      "~/Static/CSS/reset.css",
                      "~/Static/CSS/style.css",
                      "~/Static/CSS/prettyPhoto.css"));

            bundles.Add(new StyleBundle("~/Content/IEMobile").Include(
                      "~/Static/CSS/iemobile.css"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}
