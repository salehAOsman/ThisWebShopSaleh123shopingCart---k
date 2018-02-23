using System.Web;
using System.Web.Optimization;

namespace WebShopSaleh1
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //5  for bundle we add code as
            //BundleTable.EnableOptimizations = true;
            /* 1 renderBundle for script  I add this line to do bundle for all javascript files then go to Layout to do render*/
            //bundles.Add(new ScriptBundle("~/customBundle/javascript").Include("~/Scripts/*.js"));
            /* 2 renderBundle for style  I add this line to do bundle for all javascript files then go to Layout to do render*/
            //bundles.Add(new StyleBundle("~/customBundle/style").Include("~/Content/*.css"));


            //*CDN* cdn we do it as this way
            /*var cdn = @"//code.jquery.com/jquery-3.2.1.min.js";
            bundles.Add(new ScriptBundle("~/bundles/jquery",cdn).Include(
                        "~/Scripts/jquery-{version}.js"));*/

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

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
