using Gymone.Web.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymone.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        string[] ignorecontrollerNames = { "Account" };

        string[] ignorecontrollerActionMethodNames = { "Login", "ForgotPassword", "RegisterUser", "TermsAndConditions" };

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //if (!ignorecontrollerNames.ToList().Exists(controlllername => controlllername == ((Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor)filterContext.ActionDescriptor).ControllerName))
            //{
                if (!ignorecontrollerActionMethodNames.ToList().Exists(actionmethodname => actionmethodname == ((Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor)filterContext.ActionDescriptor).ActionName))
                {
                    if (filterContext.HttpContext.Session.Get<string>("UserID") == "" || filterContext.HttpContext.Session.Get<string>("UserID") == null)
                        filterContext.Result = new RedirectToRouteResult(new Microsoft.AspNetCore.Routing.RouteValueDictionary { { "controller", "Account" }, { "action", "Login" } });
                }
            //}
            base.OnActionExecuting(filterContext);  
        }
    }
}
