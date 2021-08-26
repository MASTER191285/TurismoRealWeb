using System.Web;
using System.Web.Optimization;

namespace AppTurismoReal.Web
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Scripts/js/jquery.min.js",
                       "~/Scripts/js/bootstrap.min.js",                      
                       "~/Scripts/js/jquery.flexslider.js",
                       "~/Scripts/js/numscroller-1.0.js",
                       "~/Scripts/js/owl.carousel.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap.css",
                      "~/Content/css/flexslider.css",
                      "~/Content/css/galleryeffect.css",
                      "~/Content/css/owl.carousel.css",
                      "~/Content/css/style.css"));           
        }
    }
}
