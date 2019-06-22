using System.Web;
using System.Web.Optimization;

namespace IAProject
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
                      "~/Scripts/respond.js",
                      "~/Scripts/star-rating.js",
                      "~/Scripts/star-rating.min.js",
                      "~/Scripts/star-rating_locale_de.js",
                      "~/Scripts/star-rating_locale_fr.js",
                      "~/Scripts/star-rating_locale_LANG.js",
                      "~/Scripts/star-rating_locale_pt-br.js",
                      "~/Scripts/star-rating_locale_ru.js",
                    //  "~/Scripts/creative.js",
                    //  "~/Scripts/jquery.easing.min.js",
                    //  "~/Scripts/jquery.fittext.js",
                    //  "~/Scripts/wow.min.js",
                      "~/Scripts/star-rating_locale_ua.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/star-rating.css",
                      "~/Content/star-rating.min.css",
                      "~/Content/theme-krajee-fa.css",
                      "~/Content/theme-krajee-fa.min.css",
                      "~/Content/theme-krajee-svg.css",
                      "~/Content/theme-krajee-svg.min.css",
                      "~/Content/theme-krajee-uni.css",
                      "~/Content/theme-krajee-uni.min.css"
                    //  "~/Content/creative.css",
                     // "~/Content/animate.css",
                     // "~/Content/font-awesome.min.css"
                      ));
        }
    }
}
