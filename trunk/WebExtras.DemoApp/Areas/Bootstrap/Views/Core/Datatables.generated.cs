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
    
    #line 2 "..\..\Areas\Bootstrap\Views\Core\Datatables.cshtml"
    using WebExtras.Core;
    
    #line default
    #line hidden
    using WebExtras.Mvc.Bootstrap;
    using WebExtras.Mvc.Bootstrap.v2;
    using WebExtras.Mvc.Core;
    using WebExtras.Mvc.Html;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Bootstrap/Views/Core/Datatables.cshtml")]
    public partial class _Areas_Bootstrap_Views_Core_Datatables_cshtml : System.Web.Mvc.WebViewPage<WebExtras.DemoApp.Models.Core.DatatablesViewModel>
    {
        public _Areas_Bootstrap_Views_Core_Datatables_cshtml()
        {
        }
        public override void Execute()
        {


WriteLiteral("\r\n");


            
            #line 4 "..\..\Areas\Bootstrap\Views\Core\Datatables.cshtml"
  
  ViewBag.Title = "jQuery Datatables";


            
            #line default
            #line hidden
WriteLiteral(@"<h3 class=""keep-center"">jQuery Datatables Bindings</h3>

<div class=""row-fluid"">
  <div class=""span6"">
    <div class=""row-fluid"">
      <div class=""span3"">
        <strong>Assembly</strong>
      </div>
      <div class=""span4"">
        WebExtras.dll
      </div>
    </div>
    <div class=""row-fluid"">
      <div class=""span3"">
        <strong>Namespace</strong>
      </div>
      <div class=""span4"">
        WebExtras.JQDataTables
      </div>
    </div>
  </div>
  <div class=""span6"">
    <div class=""span3"">
      <strong>Dependancies</strong>
    </div>
    <div class=""span6"">
      <ul class=""dependancies"">
        <li>Appropriate third party libraries</li>
        <li>jquery.datatables.bootstrap.js</li>
        <li>webextras.bootstrap.css</li>
      </ul>
    </div>
  </div>
</div>
<div class=""row-fluid"">
  <div class=""span9"">
    Steps involved in creating a Datatable
    <ul>
      <li>Creating the column definitions</li>
      <li>Creating the table settings</li>
      <li>Creating the table records</li>
      <li>Creating the table object</li>
      <li>And finally the output.....</li>
    </ul>
  </div>
</div>
<ul id=""dt-nav"" class=""nav nav-pills"">
  <li>");


            
            #line 54 "..\..\Areas\Bootstrap\Views\Core\Datatables.cshtml"
 Write(Html.Hyperlink("Basic Setup", MVC.Bootstrap.Core.Datatables(0)));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n  <li>");


            
            #line 55 "..\..\Areas\Bootstrap\Views\Core\Datatables.cshtml"
 Write(Html.ActionLink("Ajax Setup", MVC.Bootstrap.Core.Datatables(1)));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n  <li>");


            
            #line 56 "..\..\Areas\Bootstrap\Views\Core\Datatables.cshtml"
 Write(Html.ActionLink("Paging", MVC.Bootstrap.Core.Datatables(2)));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n  <li>");


            
            #line 57 "..\..\Areas\Bootstrap\Views\Core\Datatables.cshtml"
 Write(Html.ActionLink("Sorting", MVC.Bootstrap.Core.Datatables(3)));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n  <li>");


            
            #line 58 "..\..\Areas\Bootstrap\Views\Core\Datatables.cshtml"
 Write(Html.ActionLink("Adding status column", MVC.Bootstrap.Core.Datatables(4)));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n  <li>");


            
            #line 59 "..\..\Areas\Bootstrap\Views\Core\Datatables.cshtml"
 Write(Html.ActionLink("Adding extra postbacks", MVC.Bootstrap.Core.Datatables(5)));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n</ul>\r\n\r\n");


            
            #line 62 "..\..\Areas\Bootstrap\Views\Core\Datatables.cshtml"
 switch (Model.DisplayMode)
{
  case 1:
  
            
            #line default
            #line hidden
            
            #line 65 "..\..\Areas\Bootstrap\Views\Core\Datatables.cshtml"
Write(Html.Partial(MVC.Core.Views._AjaxSetup, Model.Table));

            
            #line default
            #line hidden
            
            #line 65 "..\..\Areas\Bootstrap\Views\Core\Datatables.cshtml"
                                                       
    break;

  case 2:
  
            
            #line default
            #line hidden
            
            #line 69 "..\..\Areas\Bootstrap\Views\Core\Datatables.cshtml"
Write(Html.Partial(MVC.Core.Views._PagedSetup, Model.Table));

            
            #line default
            #line hidden
            
            #line 69 "..\..\Areas\Bootstrap\Views\Core\Datatables.cshtml"
                                                        
    break;

  case 3:
  
            
            #line default
            #line hidden
            
            #line 73 "..\..\Areas\Bootstrap\Views\Core\Datatables.cshtml"
Write(Html.Partial(MVC.Core.Views._SortedSetup, Model.Table));

            
            #line default
            #line hidden
            
            #line 73 "..\..\Areas\Bootstrap\Views\Core\Datatables.cshtml"
                                                         
    break;

  case 4:
  
            
            #line default
            #line hidden
            
            #line 77 "..\..\Areas\Bootstrap\Views\Core\Datatables.cshtml"
Write(Html.Partial(MVC.Core.Views._StatusSetup, Model.Table));

            
            #line default
            #line hidden
            
            #line 77 "..\..\Areas\Bootstrap\Views\Core\Datatables.cshtml"
                                                         
    break;

  case 5:
  
            
            #line default
            #line hidden
            
            #line 81 "..\..\Areas\Bootstrap\Views\Core\Datatables.cshtml"
Write(Html.Partial(MVC.Bootstrap.Core.Views._PostbackSetup, Model));

            
            #line default
            #line hidden
            
            #line 81 "..\..\Areas\Bootstrap\Views\Core\Datatables.cshtml"
                                                               
    break;

  case 6:
  
            
            #line default
            #line hidden
            
            #line 85 "..\..\Areas\Bootstrap\Views\Core\Datatables.cshtml"
Write(Html.Partial(MVC.Core.Views._PostbackResult, Model));

            
            #line default
            #line hidden
            
            #line 85 "..\..\Areas\Bootstrap\Views\Core\Datatables.cshtml"
                                                      
    break;

  case 0:
  default:
  
            
            #line default
            #line hidden
            
            #line 90 "..\..\Areas\Bootstrap\Views\Core\Datatables.cshtml"
Write(Html.Partial(MVC.Core.Views._BasicSetup, Model.Table));

            
            #line default
            #line hidden
            
            #line 90 "..\..\Areas\Bootstrap\Views\Core\Datatables.cshtml"
                                                        
    break;
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<script type=\"text/javascript\">\r\n  $(document).ready(function () {\r\n    $(\'#dt-" +
"nav li:eq(\' + ");


            
            #line 96 "..\..\Areas\Bootstrap\Views\Core\Datatables.cshtml"
                    Write(Model.DisplayMode);

            
            #line default
            #line hidden
WriteLiteral(" + \')\').addClass(\'active\');\r\n  });\r\n</script>\r\n");


        }
    }
}
#pragma warning restore 1591
