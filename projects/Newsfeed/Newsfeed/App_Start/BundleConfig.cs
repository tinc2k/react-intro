using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Optimization.React;

namespace Newsfeed.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/core").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/react/react-with-addons-{version}.js",
                        "~/Scripts/react/JSXTransformer-{version}.js"
                        ));

            bundles.Add(new JsxBundle("~/bundles/components").Include(
                "~/Scripts/HelloWorld.jsx"
            ));

            //BundleTable.EnableOptimizations = true;
        }

    }
}