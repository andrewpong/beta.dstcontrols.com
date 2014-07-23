using System.Web;
using System.Web.Optimization;

namespace DSTWebsite
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/progressive/*.js")); 

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/buttons/social-icons.css",
                        "~/Content/font-awesome.min.css",
                        "~/Content/bootstrap-3.1.1/bootstrap.css",
                        "~/Content/jslider.css",
                        "~/Content/settings.css",
                        "~/Content/jquery.fancybox.css",
                        "~/Content/animate.css",
                        "~/Content/video-js.css",
                        "~/Content/morris.css",
                        "~/Content/royalslider/royalslider.css",
                        "~/Content/royalslider/skins/minimal-white/rs-minimal-white.css",
                        "~/Content/ladda.min.css",
                        "~/Content/style.css",
                        "~/Content/responsive.css",
                        "~/Content/customizer/pages.css",
                        "~/Content/customizer/home-pages-customizer.css",
                        "~/Content/site.css"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}
