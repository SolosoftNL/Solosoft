using System.Web;
using System.Web.Optimization;

namespace Solosoft.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.*",
                        "~/scripts/jquery.gmap.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/Templates/style/font-awesome.css",
                      "~/Content/Templates/style/ddlevelsmenu-base.css",
                      "~/Content/Templates/style/ddlevelsmenu-topbar.css",
                      "~/Content/Templates/style/slider.css",
                      "~/Content/Templates/style/prettyPhoto.css",
                      "~/Content/Templates/style/style.css"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/jsOverig").Include(
                "~/Scripts/ddlevelsmenu.js",
                "~/Scripts/filter.js",
                "~/Scripts/custom.js"
                ));
        }
    }
}
