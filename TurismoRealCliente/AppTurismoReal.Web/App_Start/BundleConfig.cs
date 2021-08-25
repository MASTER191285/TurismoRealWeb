using System.Web;
using System.Web.Optimization;

namespace AppTurismoReal.Web
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.min.js",
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/bootstrap-dialog.js",
                        "~/Scripts/modernizr.min.js",
                        "~/Scripts/detect.js",
                        "~/Scripts/fastclick.js",
                        "~/Scripts/jquery.slimscroll.js",
                        "~/Scripts/jquery.blockUI.js",
                        "~/Scripts/waves.js",
                        "~/Scripts/wow.min.js",
                        "~/Scripts/jquery.nicescroll.js",
                        "~/Scripts/jquery.scrollTo.min.js",
                        "~/Scripts/spin.min.js",
                        "~/Scripts/app.js",
                        "~/Scripts/jquery.flexslider.js",
                        "~/Scripts/numscroller-1.0.js",
                        "~/Scripts/owl.carousel.js",
                        "~/Scripts/deloitte-core.js"
            ));
        }
    }
}
