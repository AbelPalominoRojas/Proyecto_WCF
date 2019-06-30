using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace WebEventos.App_Start
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new StyleBundle("~/assets/template/css").Include(
                        "~/assets/admincast/assets/vendors/bootstrap/dist/css/bootstrap.min.css",
                        "~/assets/admincast/assets/vendors/font-awesome/css/font-awesome.min.css",
                        "~/assets/admincast/assets/vendors/themify-icons/css/themify-icons.css",
                        "~/assets/admincast/assets/css/main.css",
                        "~/assets/admincast/assets/css/themes/green.css"));

            bundles.Add(new StyleBundle("~/assets/template/date/css").Include(
                        "~/assets/admincast/assets/vendors/bootstrap-datepicker/dist/css/bootstrap-datepicker3.min.css",
                        "~/assets/admincast/assets/vendors/bootstrap-timepicker/css/bootstrap-timepicker.min.css"));

            bundles.Add(new StyleBundle("~/assets/vendors/datetime/css").Include(
                "~/assets/vendors/bootstrap4-datetimepicker/css/bootstrap-datetimepicker.min.css"));

            bundles.Add(new StyleBundle("~/assets/sisce/css").Include(
                        "~/assets/css/sisce.css"));

            bundles.Add(new ScriptBundle("~/assets/template/js").Include(
                "~/assets/admincast/assets/vendors/jquery/dist/jquery.min.js",
                "~/assets/admincast/assets/vendors/popper.js/dist/umd/popper.min.js",
                "~/assets/admincast/assets/vendors/bootstrap/dist/js/bootstrap.min.js",
                "~/assets/admincast/assets/vendors/metisMenu/dist/metisMenu.min.js",
                "~/assets/admincast/assets/vendors/jquery-slimscroll/jquery.slimscroll.min.js",
                "~/assets/admincast/assets/js/app.min.js"));

            bundles.Add(new ScriptBundle("~/assets/template/date/js").Include(
                "~/assets/admincast/assets/vendors/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js",
                "~/assets/admincast/assets/vendors/bootstrap-timepicker/js/bootstrap-timepicker.min.js",
                "~/assets/js/siscedate.js"));
            

            bundles.Add(new ScriptBundle("~/assets/vendors/datetime/js").Include(
                "~/assets/vendors/bootstrap4-datetimepicker/js/moment.js",
                "~/assets/vendors/bootstrap4-datetimepicker/js/bootstrap-datetimepicker.min.js",
                "~/assets/js/siscedatetime.js"));
        }
    }
}