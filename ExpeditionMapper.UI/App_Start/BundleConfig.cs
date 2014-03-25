using System.Web.Optimization;

namespace ExpeditionMapper.UI.App_Start
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
                "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                "~/Scripts/kendo/2014.1.318/kendo.all.min.js",
                "~/Scripts/kendo/2014.1.318/kendo.aspnetmvc.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/site.css",
                "~/Content/melon/main.css",
                "~/Content/melon/plugins.css", 
                "~/Content/melon/responsive.css", 
                "~/Content/melon/icons.css",
                "~/Content/melon/fontawesome/font-awesome.min.css"));

            bundles.Add(new StyleBundle("~/Content/kendo/css").Include(
                "~/Content/kendo/2014.1.318/kendo.common.min.css",
                "~/Content/kendo/2014.1.318/kendo.silver.min.css"));

            //bundles.Add(new StyleBundle("~/bundles/flatui").Include(
            //    "~/Content/flatui/css/flat-ui.css"));

            // Allow minified files in debug mode.
            bundles.IgnoreList.Clear();
        }
    }
}