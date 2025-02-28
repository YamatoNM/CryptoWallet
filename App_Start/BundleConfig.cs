using System.Web.Optimization;

public class BundleConfig
{
    public static void RegisterBundles(BundleCollection bundles)
    {
        // CSS Bundle
        bundles.Add(new StyleBundle("~/bundles/css")
            .Include("~/Content/css/normalize.css", new CssRewriteUrlTransform())
            .Include("~/Content/css/swiper-bundle.min.css", new CssRewriteUrlTransform())
            .Include("~/Content/css/vendor.css", new CssRewriteUrlTransform())
            .Include("~/Content/bootstrap.min.css", new CssRewriteUrlTransform()) // Bootstrap CSS is in the Content folder
            .Include("~/Content/css/style.css", new CssRewriteUrlTransform())); // Custom CSS last

        // JavaScript Bundle
        bundles.Add(new ScriptBundle("~/bundles/js").Include(
            "~/Scripts/jquery-1.11.0.min.js", // Corrected jQuery version based on your project
            "~/Scripts/modernizr.js",
            "~/Scripts/plugins.js",
            "~/Scripts/script.js",
            "~/Scripts/bootstrap.bundle.min.js", // Bootstrap JS is in the Scripts folder
            "~/Scripts/chocolat.js", // Chocolat JS is in the Scripts folder
            "~/Scripts/masonry.pkgd.min.js"
        ));

        // jQuery Validation Bundle
        bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            "~/Scripts/jquery.validate.min.js",
            "~/Scripts/jquery.validate.unobtrusive.min.js"
        ));

        // Enable bundling and minification
        BundleTable.EnableOptimizations = true;
    }
}
