using System.Web;
using System.Web.Optimization;

namespace MvcMusicStore3
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include
                ("~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include
                ("~/Scripts/jquery.validate*", 
                "~/Scripts/jquery.unobtrusive*"));
        }
    }
}