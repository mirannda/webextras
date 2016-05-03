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
    using WebExtras.Core;
    using WebExtras.Mvc.Core;
    using WebExtras.Mvc.Html;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Core/_PagedSetup.cshtml")]
    public partial class _Views_Core__PagedSetup_cshtml : System.Web.Mvc.WebViewPage<WebExtras.JQDataTables.Datatable>
    {
        public _Views_Core__PagedSetup_cshtml()
        {
        }
        public override void Execute()
        {

WriteLiteral("\r\n<p>\r\n  Paging support can be added by slightly modifying our AJAX callback acti" +
"on/request handler\r\n</p>\r\n<div class=\"well ui-well\">\r\n  <h4>Creating table setti" +
"ngs</h4>\r\n  Table settings are created by instantiating the <i>WebExtras.JQDataT" +
"ables.DatatableSettings</i> class \r\n  <pre><code>  \r\n  DatatableSettings dtSetti" +
"ngs = new DatatableSettings \r\n  (\r\n    5,                                      <" +
"span class=\"comment\">// specify the number of records per page</span>\r\n    dtCol" +
"umns,\r\n    new AASort(0, ESort.Ascending),         <span class=\"comment\">// spec" +
"ify one initial sort, multiple initial sorts, or leave null for no sort</span>\r\n" +
"    <span class=\"highlight\">\"~/getpageddata\"</span>,                      <span " +
"class=\"comment\">// specify an AJAX source to retrieve data from</span>\r\n    \"pag" +
"ed records\",                        <span class=\"comment\">// specify a table foo" +
"ter suffix</span>\r\n    \"150px\"                                 <span class=\"comm" +
"ent\">// specify a maximum table height, once reached you will get scroll bars</s" +
"pan>\r\n  );\r\n  </code></pre>\r\n</div>\r\n\r\n<div class=\"well ui-well\">\r\n  <h4>Creatin" +
"g a data handler</h4>\r\n  We make use of the C# LinqToSQL feature in order to sim" +
"ulate the paging behavior. This is how your paging method will normally look:\r\n " +
" <pre><code>  \r\n  public DatatableRecords GetPagedRecords(DatatableFilters filte" +
"rs)\r\n  {\r\n    <span class=\"comment\">// Let\'s create the actual data to go into t" +
"he table by adding 15 records</span>\r\n    List&lt;string[]&gt; dtData = new List" +
"&lt;string[]&gt;();\r\n\r\n    <span class=\"comment\">// You can retrieve data from y" +
"our repository here</span>\r\n    for (int i = 0; i < 15; i++)\r\n    {\r\n      dtDat" +
"a.Add(new string[] { \r\n        string.Format(\"first column paged row {0}\", i + 1" +
"), \r\n        string.Format(\"second column paged row {0}\", i + 1) \r\n      });\r\n  " +
"  }\r\n\r\n    DatatableRecords dtRecords = new DatatableRecords\r\n    {\r\n      sEcho" +
" = filters.sEcho,\r\n      iTotalRecords = dtData.Length,                         " +
"               <span class=\"comment\">// Total records in table</span>\r\n      iTo" +
"talDisplayRecords = dtData.Length,                                 <span class=\"" +
"comment\">// Total records to be displayed in the table</span>\r\n      aaData = dt" +
"Data<span class=\"highlight\">.Skip(filters.iDisplayStart).Take(iDisplayLength)</s" +
"pan>      <span class=\"comment\">// The paged data to be displayed</span>\r\n    };" +
"\r\n\r\n    return dtRecords;\r\n  }\r\n  </code></pre>\r\n  The reason we use the Datatab" +
"leFilters as a parameter will soon be apparent\r\n</div>\r\n\r\n<div class=\"well ui-we" +
"ll\">\r\n  <h4>Make the first page of the table</h4>\r\n  We need to create the first" +
" page of the table in order to have the paging behavior kick in. This should be " +
"done when you display\r\n  the table the first time.\r\n  <pre><code>  \r\n  Datatable" +
"Records dtRecords = GetPagedRecords(new DatatableFilters { iDisplayStart = 0, iD" +
"isplayLength = 5 });\r\n  Datatable dTable = new Datatable(\"paged-table\", dtSettin" +
"gs, dtRecords);\r\n  </code></pre>\r\n</div>\r\n\r\n<div class=\"well ui-well\">\r\n  <h4>A " +
"slightly modified AJAX callback handler</h4>\r\n  We will now make use of the meth" +
"od that we have already created before to do our grunt work and get the data. Th" +
"e fact that\r\n  we have used DatatableFilters as one of the parameters means that" +
" we can simply forward the filtering parameters we got \r\n  from the HTTP GET req" +
"uest from the client side.\r\n  <pre><code>\r\n  public JsonResult GetPagedData(Data" +
"tableFilters filters)\r\n  {\r\n    DatatableRecords dtRecords = GetPagedRecords(fil" +
"ters);\r\n\r\n    return Json(dtRecords, JsonRequestBehavior.AllowGet);\r\n  }\r\n  </co" +
"de></pre>\r\n</div>\r\n\r\n<div class=\"well ui-well\">\r\n  <h4>And our paging enabled ou" +
"tput is</h4>\r\n  <div class=\"output\">\r\n    ");


            
            #line 82 "..\..\Views\Core\_PagedSetup.cshtml"
Write(Html.Partial(MVC.Shared.Views._Datatable, Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n  </div>\r\n</div>\r\n\r\n<div class=\"well ui-well\">\r\n  <h4>Some more thing you shoul" +
"d know</h4>\r\n  <p>\r\n    WebExtras in conjunction with the core jQuery DataTables" +
" library provides 5 paging mechanism, 2 of which come from the native library an" +
"d 3 more\r\n    from plugins.\r\n  </p>\r\n  <p>Paging mechanism is controlled by the " +
"<strong>SetupPaging()</strong> method on the <strong>WebExtras.JQDataTables.Data" +
"tableSettings</strong> class.</p>\r\n  <p>\r\n    By default the <strong>Bootstrap</" +
"strong> paging mechanism will be selected by the library. Paging can be disabled" +
" by setting the pagination type\r\n    as <strong>None</strong>.\r\n  </p>\r\n  <div c" +
"lass=\"output\">\r\n    <table class=\"table table-bordered rounded ui-table\">\r\n     " +
" <thead>\r\n        <tr>\r\n          <th style=\"width: 20%\">Pagination type</th>\r\n " +
"         <th>Description</th>\r\n        </tr>\r\n      </thead>\r\n      <tbody>\r\n   " +
"     <tr>\r\n          <td>None</td>\r\n          <td>Disables paging</td>\r\n        " +
"</tr>\r\n        <tr>\r\n          <td>Full Numbers</td>\r\n          <td>Provides the" +
" forward, back, first and last button along with individual page buttons</td>\r\n " +
"       </tr>\r\n        <tr>\r\n          <td>Two buttons</td>\r\n          <td>Provid" +
"es a more compact version of full numbers with only 2 buttons - previous and nex" +
"t</td>\r\n        </tr>\r\n        <tr>\r\n          <td>Bootstrap</td>\r\n          <td" +
">This comes from a plug-in and provides the mark-up needed for using pagination " +
"styling of Bootstrap 2.x with \r\n          DataTables. Note that this plug-in use" +
"s the fnPagingInfo API plug-in method to obtain paging information.</td>\r\n      " +
"  </tr>\r\n        <tr>\r\n          <td>Bootstrap3</td>\r\n          <td>This comes f" +
"rom a plug-in and provides the mark-up needed for using pagination styling of Bo" +
"otstrap 3 with \r\n          DataTables.</td>\r\n        </tr>\r\n        <tr>\r\n      " +
"    <td>Four Button</td>\r\n          <td>The built-in pagination functions provid" +
"e either two buttons (forward / back) \r\n          or lots of buttons (forward, b" +
"ack, first, last and individual pages). This \r\n          plug-in meets the two i" +
"n the middle providing navigation controls for forward, \r\n          back, first " +
"and last.\r\n          </td>\r\n        </tr>\r\n        <tr>\r\n          <td>Scrolling" +
"</td>\r\n          <td>This modification of DataTables\' standard two button pagina" +
"tion controls adds a \r\n          little animation effect to the paging action by" +
" redrawing the table multiple times \r\n          for each event, each draw progre" +
"ssing by one row until the required point in the \r\n          table is reached.\r\n" +
"          </td>\r\n        </tr>\r\n        <tr>\r\n          <td>Gumby</td>\r\n        " +
"  <td>This is the default <strong>Full Numbers</strong> paging scheme with Gumby" +
" styling\r\n            and layout applied\r\n          </td>\r\n        </tr>\r\n      " +
"</tbody>\r\n    </table>\r\n  </div>\r\n</div>\r\n");


        }
    }
}
#pragma warning restore 1591
