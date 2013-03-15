﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static class MVC
{
    public static WebExtras.DemoApp.Controllers.AssetsController Assets = new WebExtras.DemoApp.Controllers.T4MVC_AssetsController();
    public static WebExtras.DemoApp.Controllers.CoreController Core = new WebExtras.DemoApp.Controllers.T4MVC_CoreController();
    public static WebExtras.DemoApp.Controllers.MvcController Mvc = new WebExtras.DemoApp.Controllers.T4MVC_MvcController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC
{
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}
[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public class T4MVC_System_Web_Mvc_JsonResult : System.Web.Mvc.JsonResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_JsonResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        private const string URLPATH = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string bootstrap_2_3_1_min_js = Url("bootstrap-2.3.1.min.js");
        public static readonly string jquery_1_9_1_min_js = Url("jquery-1.9.1.min.js");
        public static readonly string jquery_datatables_1_9_4_min_js = Url("jquery.datatables-1.9.4.min.js");
        public static readonly string jquery_datatables_pagination_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.datatables.pagination.min.js") ? Url("jquery.datatables.pagination.min.js") : Url("jquery.datatables.pagination.js");
                      
        public static readonly string jquery_flot_0_7_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.flot-0.7.min.js") ? Url("jquery.flot-0.7.min.js") : Url("jquery.flot-0.7.js");
                      
        public static readonly string jquery_flot_axislabels_1_0_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.flot.axislabels-1.0.min.js") ? Url("jquery.flot.axislabels-1.0.min.js") : Url("jquery.flot.axislabels-1.0.js");
                      
        public static readonly string jquery_flot_curvedlines_0_2_3_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.flot.curvedlines-0.2.3.min.js") ? Url("jquery.flot.curvedlines-0.2.3.min.js") : Url("jquery.flot.curvedlines-0.2.3.js");
                      
        public static readonly string jquery_flot_dashes_0_1_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.flot.dashes-0.1.min.js") ? Url("jquery.flot.dashes-0.1.min.js") : Url("jquery.flot.dashes-0.1.js");
                      
        public static readonly string jquery_migrate_1_1_1_min_js = Url("jquery.migrate-1.1.1.min.js");
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        private const string URLPATH = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string base_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/base.min.css") ? Url("base.min.css") : Url("base.css");
             
        public static readonly string bootstrap_2_3_1_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap-2.3.1.min.css") ? Url("bootstrap-2.3.1.min.css") : Url("bootstrap-2.3.1.css");
             
        public static readonly string favicon_ico = Url("favicon.ico");
        public static readonly string favicon_png = Url("favicon.png");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class img {
            private const string URLPATH = "~/Content/img";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class bootstrap {
                private const string URLPATH = "~/Content/img/bootstrap";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string glyphicons_halflings_white_png = Url("glyphicons-halflings-white.png");
                public static readonly string glyphicons_halflings_png = Url("glyphicons-halflings.png");
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class datatables {
                private const string URLPATH = "~/Content/img/datatables";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string back_disabled_png = Url("back_disabled.png");
                public static readonly string back_enabled_png = Url("back_enabled.png");
                public static readonly string back_enabled_hover_png = Url("back_enabled_hover.png");
                public static readonly string forward_disabled_png = Url("forward_disabled.png");
                public static readonly string forward_enabled_png = Url("forward_enabled.png");
                public static readonly string forward_enabled_hover_png = Url("forward_enabled_hover.png");
                public static readonly string sort_asc_png = Url("sort_asc.png");
                public static readonly string sort_asc_disabled_png = Url("sort_asc_disabled.png");
                public static readonly string sort_both_png = Url("sort_both.png");
                public static readonly string sort_desc_png = Url("sort_desc.png");
                public static readonly string sort_desc_disabled_png = Url("sort_desc_disabled.png");
                public static readonly string Sorting_icons_psd = Url("Sorting icons.psd");
            }
        
            public static readonly string draft_png = Url("draft.png");
        }
    
        public static readonly string jquery_dataTables_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.dataTables.min.css") ? Url("jquery.dataTables.min.css") : Url("jquery.dataTables.css");
             
        public static readonly string webextras_dataTables_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/webextras.dataTables.min.css") ? Url("webextras.dataTables.min.css") : Url("webextras.dataTables.css");
             
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Scripts {}
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Styles {}
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;


    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591


