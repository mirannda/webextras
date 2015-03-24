// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
#pragma warning disable 1591, 3008, 3009, 0108
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace WebExtras.DemoApp.Areas.Bootstrap3.Controllers
{
    public partial class CoreController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected CoreController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Datatables()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Datatables);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.JsonResult GetAjaxData()
        {
            return new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetAjaxData);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.JsonResult GetPagedData()
        {
            return new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetPagedData);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.JsonResult GetSortedData()
        {
            return new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetSortedData);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.JsonResult GetPostbackData()
        {
            return new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetPostbackData);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Flot()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Flot);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult JQPlot()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.JQPlot);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public CoreController Actions { get { return MVC.Bootstrap3.Core; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "Bootstrap3";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Core";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Core";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string Generic = "Generic";
            public readonly string Datatables = "Datatables";
            public readonly string GetAjaxData = "GetAjaxData";
            public readonly string GetPagedData = "GetPagedData";
            public readonly string GetSortedData = "GetSortedData";
            public readonly string GetPostbackData = "GetPostbackData";
            public readonly string Flot = "Flot";
            public readonly string JQPlot = "JQPlot";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string Generic = "Generic";
            public const string Datatables = "Datatables";
            public const string GetAjaxData = "GetAjaxData";
            public const string GetPagedData = "GetPagedData";
            public const string GetSortedData = "GetSortedData";
            public const string GetPostbackData = "GetPostbackData";
            public const string Flot = "Flot";
            public const string JQPlot = "JQPlot";
        }


        static readonly ActionParamsClass_Datatables s_params_Datatables = new ActionParamsClass_Datatables();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Datatables DatatablesParams { get { return s_params_Datatables; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Datatables
        {
            public readonly string mode = "mode";
            public readonly string viewModel = "viewModel";
        }
        static readonly ActionParamsClass_GetAjaxData s_params_GetAjaxData = new ActionParamsClass_GetAjaxData();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetAjaxData GetAjaxDataParams { get { return s_params_GetAjaxData; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetAjaxData
        {
            public readonly string filters = "filters";
        }
        static readonly ActionParamsClass_GetPagedData s_params_GetPagedData = new ActionParamsClass_GetPagedData();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetPagedData GetPagedDataParams { get { return s_params_GetPagedData; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetPagedData
        {
            public readonly string filters = "filters";
        }
        static readonly ActionParamsClass_GetSortedData s_params_GetSortedData = new ActionParamsClass_GetSortedData();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetSortedData GetSortedDataParams { get { return s_params_GetSortedData; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetSortedData
        {
            public readonly string filters = "filters";
        }
        static readonly ActionParamsClass_GetPostbackData s_params_GetPostbackData = new ActionParamsClass_GetPostbackData();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetPostbackData GetPostbackDataParams { get { return s_params_GetPostbackData; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetPostbackData
        {
            public readonly string filters = "filters";
            public readonly string postbacks = "postbacks";
        }
        static readonly ActionParamsClass_Flot s_params_Flot = new ActionParamsClass_Flot();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Flot FlotParams { get { return s_params_Flot; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Flot
        {
            public readonly string mode = "mode";
        }
        static readonly ActionParamsClass_JQPlot s_params_JQPlot = new ActionParamsClass_JQPlot();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_JQPlot JQPlotParams { get { return s_params_JQPlot; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_JQPlot
        {
            public readonly string mode = "mode";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string _AxisLabels = "_AxisLabels";
                public readonly string _PostbackSetup = "_PostbackSetup";
                public readonly string Datatables = "Datatables";
                public readonly string Flot = "Flot";
                public readonly string Generic = "Generic";
                public readonly string JQPlot = "JQPlot";
            }
            public readonly string _AxisLabels = "~/Areas/Bootstrap3/Views/Core/_AxisLabels.cshtml";
            public readonly string _PostbackSetup = "~/Areas/Bootstrap3/Views/Core/_PostbackSetup.cshtml";
            public readonly string Datatables = "~/Areas/Bootstrap3/Views/Core/Datatables.cshtml";
            public readonly string Flot = "~/Areas/Bootstrap3/Views/Core/Flot.cshtml";
            public readonly string Generic = "~/Areas/Bootstrap3/Views/Core/Generic.cshtml";
            public readonly string JQPlot = "~/Areas/Bootstrap3/Views/Core/JQPlot.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_CoreController : WebExtras.DemoApp.Areas.Bootstrap3.Controllers.CoreController
    {
        public T4MVC_CoreController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void GenericOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Generic()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Generic);
            GenericOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void DatatablesOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int? mode);

        [NonAction]
        public override System.Web.Mvc.ActionResult Datatables(int? mode)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Datatables);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "mode", mode);
            DatatablesOverride(callInfo, mode);
            return callInfo;
        }

        [NonAction]
        partial void DatatablesOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, WebExtras.DemoApp.Models.Core.DatatablesViewModel viewModel);

        [NonAction]
        public override System.Web.Mvc.ActionResult Datatables(WebExtras.DemoApp.Models.Core.DatatablesViewModel viewModel)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Datatables);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "viewModel", viewModel);
            DatatablesOverride(callInfo, viewModel);
            return callInfo;
        }

        [NonAction]
        partial void GetAjaxDataOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, WebExtras.JQDataTables.DatatableFilters filters);

        [NonAction]
        public override System.Web.Mvc.JsonResult GetAjaxData(WebExtras.JQDataTables.DatatableFilters filters)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetAjaxData);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "filters", filters);
            GetAjaxDataOverride(callInfo, filters);
            return callInfo;
        }

        [NonAction]
        partial void GetPagedDataOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, WebExtras.JQDataTables.DatatableFilters filters);

        [NonAction]
        public override System.Web.Mvc.JsonResult GetPagedData(WebExtras.JQDataTables.DatatableFilters filters)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetPagedData);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "filters", filters);
            GetPagedDataOverride(callInfo, filters);
            return callInfo;
        }

        [NonAction]
        partial void GetSortedDataOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, WebExtras.JQDataTables.DatatableFilters filters);

        [NonAction]
        public override System.Web.Mvc.JsonResult GetSortedData(WebExtras.JQDataTables.DatatableFilters filters)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetSortedData);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "filters", filters);
            GetSortedDataOverride(callInfo, filters);
            return callInfo;
        }

        [NonAction]
        partial void GetPostbackDataOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, WebExtras.JQDataTables.DatatableFilters filters, WebExtras.DemoApp.Models.Core.PostbackSetupViewModel postbacks);

        [NonAction]
        public override System.Web.Mvc.JsonResult GetPostbackData(WebExtras.JQDataTables.DatatableFilters filters, WebExtras.DemoApp.Models.Core.PostbackSetupViewModel postbacks)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetPostbackData);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "filters", filters);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "postbacks", postbacks);
            GetPostbackDataOverride(callInfo, filters, postbacks);
            return callInfo;
        }

        [NonAction]
        partial void FlotOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int? mode);

        [NonAction]
        public override System.Web.Mvc.ActionResult Flot(int? mode)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Flot);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "mode", mode);
            FlotOverride(callInfo, mode);
            return callInfo;
        }

        [NonAction]
        partial void JQPlotOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int? mode);

        [NonAction]
        public override System.Web.Mvc.ActionResult JQPlot(int? mode)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.JQPlot);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "mode", mode);
            JQPlotOverride(callInfo, mode);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108
