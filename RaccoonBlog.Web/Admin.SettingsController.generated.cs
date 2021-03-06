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
namespace RaccoonBlog.Web.Areas.Admin.Controllers
{
    public partial class SettingsController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public SettingsController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected SettingsController(Dummy d) { }

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
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> SubmitToReddit()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SubmitToReddit);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> ResetFailedRedditSubmission()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ResetFailedRedditSubmission);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public SettingsController Actions { get { return MVC.Admin.Settings; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "Admin";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Settings";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Settings";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string RedditSubmission = "RedditSubmission";
            public readonly string SubmitToReddit = "SubmitToReddit";
            public readonly string ResetFailedRedditSubmission = "ResetFailedRedditSubmission";
            public readonly string RssFutureAccess = "RssFutureAccess";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string RedditSubmission = "RedditSubmission";
            public const string SubmitToReddit = "SubmitToReddit";
            public const string ResetFailedRedditSubmission = "ResetFailedRedditSubmission";
            public const string RssFutureAccess = "RssFutureAccess";
        }


        static readonly ActionParamsClass_Index s_params_Index = new ActionParamsClass_Index();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Index IndexParams { get { return s_params_Index; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Index
        {
            public readonly string config = "config";
        }
        static readonly ActionParamsClass_SubmitToReddit s_params_SubmitToReddit = new ActionParamsClass_SubmitToReddit();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SubmitToReddit SubmitToRedditParams { get { return s_params_SubmitToReddit; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SubmitToReddit
        {
            public readonly string postId = "postId";
            public readonly string sr = "sr";
        }
        static readonly ActionParamsClass_ResetFailedRedditSubmission s_params_ResetFailedRedditSubmission = new ActionParamsClass_ResetFailedRedditSubmission();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ResetFailedRedditSubmission ResetFailedRedditSubmissionParams { get { return s_params_ResetFailedRedditSubmission; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ResetFailedRedditSubmission
        {
            public readonly string postId = "postId";
            public readonly string sr = "sr";
        }
        static readonly ActionParamsClass_RssFutureAccess s_params_RssFutureAccess = new ActionParamsClass_RssFutureAccess();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_RssFutureAccess RssFutureAccessParams { get { return s_params_RssFutureAccess; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_RssFutureAccess
        {
            public readonly string input = "input";
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
                public readonly string Index = "Index";
                public readonly string RedditSubmission = "RedditSubmission";
                public readonly string RssFutureAccess = "RssFutureAccess";
            }
            public readonly string Index = "~/Areas/Admin/Views/Settings/Index.cshtml";
            public readonly string RedditSubmission = "~/Areas/Admin/Views/Settings/RedditSubmission.cshtml";
            public readonly string RssFutureAccess = "~/Areas/Admin/Views/Settings/RssFutureAccess.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_SettingsController : RaccoonBlog.Web.Areas.Admin.Controllers.SettingsController
    {
        public T4MVC_SettingsController() : base(Dummy.Instance) { }

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
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, RaccoonBlog.Web.Models.BlogConfig config);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index(RaccoonBlog.Web.Models.BlogConfig config)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "config", config);
            IndexOverride(callInfo, config);
            return callInfo;
        }

        [NonAction]
        partial void RedditSubmissionOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> RedditSubmission()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RedditSubmission);
            RedditSubmissionOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        [NonAction]
        partial void SubmitToRedditOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string postId, string sr);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> SubmitToReddit(string postId, string sr)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SubmitToReddit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "postId", postId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "sr", sr);
            SubmitToRedditOverride(callInfo, postId, sr);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        [NonAction]
        partial void ResetFailedRedditSubmissionOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string postId, string sr);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> ResetFailedRedditSubmission(string postId, string sr)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ResetFailedRedditSubmission);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "postId", postId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "sr", sr);
            ResetFailedRedditSubmissionOverride(callInfo, postId, sr);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        [NonAction]
        partial void RssFutureAccessOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult RssFutureAccess()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RssFutureAccess);
            RssFutureAccessOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void RssFutureAccessOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, RaccoonBlog.Web.Areas.Admin.Models.FutureRssAccess input);

        [NonAction]
        public override System.Web.Mvc.ActionResult RssFutureAccess(RaccoonBlog.Web.Areas.Admin.Models.FutureRssAccess input)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RssFutureAccess);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "input", input);
            RssFutureAccessOverride(callInfo, input);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108
