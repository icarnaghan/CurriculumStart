using System.Web.Optimization;

namespace FlexMapper.UI
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

            bundles.Add(new ScriptBundle("~/bundles/AdminLTE").Include(
                "~/Scripts/AdminLTE/jquery-ui-1.10.3.min.js",
                "~/Scripts/AdminLTE/plugins/morris/morris.min.js",
                "~/Scripts/AdminLTE/plugins/sparkline/jquery.sparkline.min.js",
                "~/Scripts/AdminLTE/plugins/fullcalendar/fullcalendar.min.js",
                "~/Scripts/AdminLTE/plugins/jqueryKnob/jquery.knob.js",
                "~/Scripts/AdminLTE/plugins/daterangepicker/daterangepicker.js",
                "~/Scripts/AdminLTE/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js",
                "~/Scripts/AdminLTE/plugins/iCheck/icheck.min.js",
                "~/Scripts/AdminLTE/AdminLTE/app.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                "~/Scripts/kendo/2014.1.318/kendo.all.min.js",
                "~/Scripts/kendo/2014.1.318/kendo.aspnetmvc.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/site.css",
                "~/Content/AdminLTE/css/font-awesome.min.css",
                "~/Content/AdminLTE/css/ionicons.min.css",
                "~/Content/AdminLTE/css/morris/morris.css",
                "~/Content/AdminLTE/css/jvectormap/jquery-jvectormap-1.2.2.css",
                "~/Content/AdminLTE/css/fullcalendar/fullcalendar.css",
                "~/Content/AdminLTE/css/daterangepicker/daterangepicker-bs3.css",
                "~/Content/AdminLTE/css/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css",
                "~/Content/AdminLTE/css/AdminLTE.css"
                ));

            bundles.Add(new StyleBundle("~/Content/kendo/css").Include(
                "~/Content/kendo/2014.1.318/kendo.common.min.css",
                "~/Content/kendo/2014.1.318/kendo.metro.min.css"));

            // Allow minified files in debug mode.
            bundles.IgnoreList.Clear();
        }
    }
}