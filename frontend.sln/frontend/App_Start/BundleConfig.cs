using System.Web;
using System.Web.Optimization;

namespace frontend
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                       "~/Content/bootstrap.css",
                       "~/Content/app/css/error_maintenance.css",
                       "~/Content/app/css/loader.css",
                       "~/Content/app/css/HOME_index.css",
                       "~/Content/app/css/contatti.css",
                       "~/Content/app/css/style.css",
                       "~/Content/app/css/HOME_serviziofferti.css",
                       "~/Content/app/css/HOME_iprogetti.css",
                       "~/Content/app/css/PROJ_dettaglicivile.css",
                       "~/Content/app/css/PROJ_sliderDettagli.css",
                       "~/Content/app/css/mediaquery.css",
                       "~/Content/app/css/PROJ_filter.css",
                       "~/Content/app/css/PROJ_index.css",
                       "~/Content/app/css/news.css",
                       "~/Content/app/css/HOME_slider-index.css",
                       "~/Content/app/css/HOME_homepage.css",
                       "~/Content/app/css/PROJ_descrizioneprogetti.css",
                       "~/Content/app/css/HOME_grid.css",
                       "~/Content/site.css"));
        }
    }
}
