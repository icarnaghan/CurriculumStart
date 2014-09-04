using System.Web.Optimization;

namespace Mapper21.Site
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/AdminLTE/plugins").Include(
                "~/Scripts/Libraries/AdminLTE/jquery-ui-1.10.3.min.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/AdminLTE").Include(
                "~/Scripts/Libraries/AdminLTE/AdminLTE/app.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                "~/Scripts/Libraries/KendoUI/kendo.all.min.js",
                "~/Scripts/Libraries/KendoUI/kendo.aspnetmvc.min.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/Libraries/bootstrap.css",
                "~/Content/site.css",
                "~/Content/Libraries/AdminLTE/css/AdminLTE.css"
                ));

            bundles.Add(new StyleBundle("~/Content/AdminLTE/plugins").Include(
                "~/Content/Libraries/AdminLTE/css/font-awesome.min.css",
                "~/Content/Libraries/AdminLTE/css/ionicons.min.css"
                ));

            bundles.Add(new StyleBundle("~/Content/AdminLTE").Include(
                "~/Content/Libraries/AdminLTE/css/AdminLTE.css"
                ));

            bundles.Add(new StyleBundle("~/Content/Libraries/KendoUI/kendo").Include(
                "~/Content/Libraries/KendoUI/kendo.common.min.css",
                "~/Content/Libraries/KendoUI/kendo.bootstrap.min.css"));

            // Allow minified files in debug mode.
            bundles.IgnoreList.Clear();
        }
    }
}