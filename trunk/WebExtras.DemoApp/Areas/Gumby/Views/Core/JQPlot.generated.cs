﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Areas\Gumby\Views\Core\JQPlot.cshtml"
    using SquishIt.Framework;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Areas\Gumby\Views\Core\JQPlot.cshtml"
    using SquishIt.Mvc;
    
    #line default
    #line hidden
    using WebExtras.Core;
    
    #line 3 "..\..\Areas\Gumby\Views\Core\JQPlot.cshtml"
    using WebExtras.DemoApp.App_Start;
    
    #line default
    #line hidden
    using WebExtras.Mvc.Core;
    using WebExtras.Mvc.Gumby;
    using WebExtras.Mvc.Html;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Gumby/Views/Core/JQPlot.cshtml")]
    public partial class _Areas_Gumby_Views_Core_JQPlot_cshtml : System.Web.Mvc.WebViewPage<WebExtras.DemoApp.Models.Core.JQPlotViewModel>
    {
        public _Areas_Gumby_Views_Core_JQPlot_cshtml()
        {
        }
        public override void Execute()
        {




WriteLiteral("\r\n");


            
            #line 6 "..\..\Areas\Gumby\Views\Core\JQPlot.cshtml"
  
  ViewBag.Title = "jqPlot";


            
            #line default
            #line hidden
WriteLiteral("\r\n");


DefineSection("scripts", () => {

WriteLiteral("\r\n  ");


            
            #line 12 "..\..\Areas\Gumby\Views\Core\JQPlot.cshtml"
Write(Bundle.JavaScript().MvcRenderCachedAssetTag(ContentBundle.JSjqPlot.GetStringValue()));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


});

WriteLiteral(@"


<h3 class=""keep-center"">jqPlot Bindings</h3>

<div class=""row"">
  <div class=""six columns"">
    <div class=""row"">
      <div class=""three columns"">
        <strong>Assembly</strong>
      </div>
      <div class=""four columns"">
        WebExtras.dll
      </div>
    </div>
    <div class=""row"">
      <div class=""three columns"">
        <strong>Namespace</strong>
      </div>
      <div class=""four columns"">
        WebExtras.JQPlot
      </div>
    </div>
  </div>
  <div class=""six columns"">
    <div class=""three columns"">
      <strong>Dependancies</strong>
    </div>
    <div class=""seven columns"">
      <ul class=""dependancies"">
        <li>Appropriate third party libraries</li>
        <li>webextras.gumby.css</li>
      </ul>
    </div>
  </div>
</div>

<div class=""row"">
  <div class=""nine columns"">
    Steps involved in creating a jqPlot graph
    <ul>
      <li>Creating graph options</li>
      <li>Creating graph data</li>
      <li>Rendering the graph</li>
    </ul>
  </div>
</div>

<div class=""row"">
  <div class=""navbar metro eleven columns centered"">
    <ul id=""jqPlot-nav"" class=""nav nav-pills"">
      <li>");


            
            #line 64 "..\..\Areas\Gumby\Views\Core\JQPlot.cshtml"
     Write(Html.Hyperlink("Basic Line Graph", MVC.Gumby.Core.JQPlot(0)));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n      <li>");


            
            #line 65 "..\..\Areas\Gumby\Views\Core\JQPlot.cshtml"
     Write(Html.Hyperlink("Non-numeric Axis Values", MVC.Gumby.Core.JQPlot(1)));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n      <li>");


            
            #line 66 "..\..\Areas\Gumby\Views\Core\JQPlot.cshtml"
     Write(Html.Hyperlink("Bar Graphs", MVC.Gumby.Core.JQPlot(2)));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n      <li>");


            
            #line 67 "..\..\Areas\Gumby\Views\Core\JQPlot.cshtml"
     Write(Html.Hyperlink("Multiple Axes", MVC.Gumby.Core.JQPlot(3)));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n      <li>");


            
            #line 68 "..\..\Areas\Gumby\Views\Core\JQPlot.cshtml"
     Write(Html.Hyperlink("Ajax Data", MVC.Gumby.Core.JQPlot(4)));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n      <li>");


            
            #line 69 "..\..\Areas\Gumby\Views\Core\JQPlot.cshtml"
     Write(Html.Hyperlink("OHLC Graph", MVC.Gumby.Core.JQPlot(5)));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n    </ul>\r\n  </div>\r\n</div>\r\n\r\n<script type=\"text/javascript\">\r\n  $(docume" +
"nt).ready(function () {\r\n    $(\'#jqPlot-nav li:eq(\' + ");


            
            #line 76 "..\..\Areas\Gumby\Views\Core\JQPlot.cshtml"
                        Write(Model.DisplayMode);

            
            #line default
            #line hidden
WriteLiteral(" + \')\').addClass(\'active\');\r\n  });\r\n</script>\r\n\r\n");


            
            #line 80 "..\..\Areas\Gumby\Views\Core\JQPlot.cshtml"
 switch (Model.DisplayMode)
{
  case 1:
  
            
            #line default
            #line hidden
            
            #line 83 "..\..\Areas\Gumby\Views\Core\JQPlot.cshtml"
Write(Html.Partial(MVC.Core.Views._JQPlotNonNumericAxisValues, Model.Charts));

            
            #line default
            #line hidden
            
            #line 83 "..\..\Areas\Gumby\Views\Core\JQPlot.cshtml"
                                                                         
    break;

  case 2:
  
            
            #line default
            #line hidden
            
            #line 87 "..\..\Areas\Gumby\Views\Core\JQPlot.cshtml"
Write(Html.Partial(MVC.Core.Views._JQPlotBarGraph, Model.Charts));

            
            #line default
            #line hidden
            
            #line 87 "..\..\Areas\Gumby\Views\Core\JQPlot.cshtml"
                                                             
    break;

  case 3:
  
            
            #line default
            #line hidden
            
            #line 91 "..\..\Areas\Gumby\Views\Core\JQPlot.cshtml"
Write(Html.Partial(MVC.Core.Views._JQPlotMultipleAxes, Model.Charts[0]));

            
            #line default
            #line hidden
            
            #line 91 "..\..\Areas\Gumby\Views\Core\JQPlot.cshtml"
                                                                    
    break;

  case 4:
  
            
            #line default
            #line hidden
            
            #line 95 "..\..\Areas\Gumby\Views\Core\JQPlot.cshtml"
Write(Html.Partial(MVC.Core.Views._JQPlotAjaxData, Model.Charts[0]));

            
            #line default
            #line hidden
            
            #line 95 "..\..\Areas\Gumby\Views\Core\JQPlot.cshtml"
                                                                
    break;

  case 5:
  
            
            #line default
            #line hidden
            
            #line 99 "..\..\Areas\Gumby\Views\Core\JQPlot.cshtml"
Write(Html.Partial(MVC.Core.Views._JQPlotOHLCGraph, Model.Charts[0]));

            
            #line default
            #line hidden
            
            #line 99 "..\..\Areas\Gumby\Views\Core\JQPlot.cshtml"
                                                                 
    break;
    
  default:
  
            
            #line default
            #line hidden
            
            #line 103 "..\..\Areas\Gumby\Views\Core\JQPlot.cshtml"
Write(Html.Partial(MVC.Core.Views._JQPlotLineGraph, Model.Charts[0]));

            
            #line default
            #line hidden
            
            #line 103 "..\..\Areas\Gumby\Views\Core\JQPlot.cshtml"
                                                                 
    break;
}

            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591