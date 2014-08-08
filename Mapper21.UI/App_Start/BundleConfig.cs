﻿using System.Web.Optimization;

namespace Mapper21.UI
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                //"~/Scripts/jquery-{version}.js"));
                "~/Scripts/Libraries/KendoUI/jquery.min.js"));

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
                "~/Scripts/Libraries/AdminLTE/jquery-ui-1.10.3.min.js",
                "~/Scripts/Libraries/AdminLTE/plugins/morris/morris.min.js",
                "~/Scripts/Libraries/AdminLTE/plugins/sparkline/jquery.sparkline.min.js",
                "~/Scripts/Libraries/AdminLTE/plugins/fullcalendar/fullcalendar.min.js",
                "~/Scripts/Libraries/AdminLTE/plugins/jqueryKnob/jquery.knob.js",
                "~/Scripts/Libraries/AdminLTE/plugins/daterangepicker/daterangepicker.js",
                "~/Scripts/Libraries/AdminLTE/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js",
                "~/Scripts/Libraries/AdminLTE/plugins/iCheck/icheck.min.js",
                "~/Scripts/Libraries/AdminLTE/AdminLTE/app.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                "~/Scripts/Libraries/KendoUI/kendo.all.min.js",
                "~/Scripts/Libraries/KendoUI/kendo.aspnetmvc.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/Libraries/bootstrap.css",
                "~/Content/site.css",
                "~/Content/Libraries/AdminLTE/css/font-awesome.min.css",
                "~/Content/Libraries/AdminLTE/css/ionicons.min.css",
                "~/Content/Libraries/AdminLTE/css/morris/morris.css",
                "~/Content/Libraries/AdminLTE/css/jvectormap/jquery-jvectormap-1.2.2.css",
                "~/Content/Libraries/AdminLTE/css/fullcalendar/fullcalendar.css",
                "~/Content/Libraries/AdminLTE/css/daterangepicker/daterangepicker-bs3.css",
                "~/Content/Libraries/AdminLTE/css/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css",
                "~/Content/Libraries/AdminLTE/css/AdminLTE.css"
                ));

            bundles.Add(new StyleBundle("~/Content/kendo/css").Include(
                "~/Content/Libraries/KendoUI/kendo.common.min.css",
                "~/Content/Libraries/KendoUI/kendo.bootstrap.min.css"));

            // Allow minified files in debug mode.
            bundles.IgnoreList.Clear();
        }
    }
}