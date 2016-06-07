using System.Web.Optimization;

namespace MvcSample
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Bootstrap style
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                "~/Content/bootstrap.css"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
                       "~/Scripts/bootstrap.js"));

            // Vendor JS
            bundles.Add(new ScriptBundle("~/bundles/vendor/js").Include(
                "~/Vendor/LightBox/js/lightgallery.js",
                "~/Vendor/LightBox/js/lg-hash.js",
                "~/Vendor/LightBox/js/lg-thumbnail.js",
                "~/Vendor/LightBox/js/lg-fullscreen.js",
                "~/Vendor/LightBox/js/lg-video.js"
                ));

            // Vendor style
            bundles.Add(new StyleBundle("~/bundles/vendor/css").Include(
                "~/Vendor/LightBox/css/lightgallery.css",
                "~/Vendor/LightBox/css/lg-transitions.css",
                "~/Vendor/LightBox/css/lg-fb-comment-box.css"
                ));


            // Angular App
            bundles.Add(new ScriptBundle("~/bundles/ngApp/js")
               .Include("~/Vendor/angularjs/angular.js")
               .Include("~/app/app.js")
               .Include("~/app/controllers/home.js"));


        }
    }
}
