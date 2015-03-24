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
namespace WebExtras.DemoApp.Areas.Gumby.Controllers
{
    public partial class MvcController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public MvcController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected MvcController(Dummy d) { }

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
        public virtual System.Web.Mvc.ActionResult GumbyHtml()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GumbyHtml);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ActionMessageDemo()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ActionMessageDemo);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public MvcController Actions { get { return MVC.Gumby.Mvc; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "Gumby";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Mvc";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Mvc";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string CoreHtml = "CoreHtml";
            public readonly string CoreForm = "CoreForm";
            public readonly string GumbyHtml = "GumbyHtml";
            public readonly string GumbyForm = "GumbyForm";
            public readonly string ActionMessageDemo = "ActionMessageDemo";
            public readonly string UserAlertsDemo = "UserAlertsDemo";
            public readonly string ActionResults = "ActionResults";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string CoreHtml = "CoreHtml";
            public const string CoreForm = "CoreForm";
            public const string GumbyHtml = "GumbyHtml";
            public const string GumbyForm = "GumbyForm";
            public const string ActionMessageDemo = "ActionMessageDemo";
            public const string UserAlertsDemo = "UserAlertsDemo";
            public const string ActionResults = "ActionResults";
        }


        static readonly ActionParamsClass_GumbyHtml s_params_GumbyHtml = new ActionParamsClass_GumbyHtml();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GumbyHtml GumbyHtmlParams { get { return s_params_GumbyHtml; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GumbyHtml
        {
            public readonly string msg = "msg";
        }
        static readonly ActionParamsClass_ActionMessageDemo s_params_ActionMessageDemo = new ActionParamsClass_ActionMessageDemo();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ActionMessageDemo ActionMessageDemoParams { get { return s_params_ActionMessageDemo; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ActionMessageDemo
        {
            public readonly string success = "success";
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
                public readonly string ActionResults = "ActionResults";
                public readonly string CoreForm = "CoreForm";
                public readonly string CoreHtml = "CoreHtml";
                public readonly string GumbyForm = "GumbyForm";
                public readonly string GumbyHtml = "GumbyHtml";
            }
            public readonly string ActionResults = "~/Areas/Gumby/Views/Mvc/ActionResults.cshtml";
            public readonly string CoreForm = "~/Areas/Gumby/Views/Mvc/CoreForm.cshtml";
            public readonly string CoreHtml = "~/Areas/Gumby/Views/Mvc/CoreHtml.cshtml";
            public readonly string GumbyForm = "~/Areas/Gumby/Views/Mvc/GumbyForm.cshtml";
            public readonly string GumbyHtml = "~/Areas/Gumby/Views/Mvc/GumbyHtml.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_MvcController : WebExtras.DemoApp.Areas.Gumby.Controllers.MvcController
    {
        public T4MVC_MvcController() : base(Dummy.Instance) { }

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
        partial void CoreHtmlOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult CoreHtml()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CoreHtml);
            CoreHtmlOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void CoreFormOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult CoreForm()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CoreForm);
            CoreFormOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void GumbyHtmlOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, bool? msg);

        [NonAction]
        public override System.Web.Mvc.ActionResult GumbyHtml(bool? msg)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GumbyHtml);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "msg", msg);
            GumbyHtmlOverride(callInfo, msg);
            return callInfo;
        }

        [NonAction]
        partial void GumbyFormOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult GumbyForm()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.GumbyForm);
            GumbyFormOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ActionMessageDemoOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, bool success);

        [NonAction]
        public override System.Web.Mvc.ActionResult ActionMessageDemo(bool success)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ActionMessageDemo);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "success", success);
            ActionMessageDemoOverride(callInfo, success);
            return callInfo;
        }

        [NonAction]
        partial void UserAlertsDemoOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult UserAlertsDemo()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UserAlertsDemo);
            UserAlertsDemoOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ActionResultsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult ActionResults()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ActionResults);
            ActionResultsOverride(callInfo);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108
