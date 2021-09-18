using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Tour;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tour.Admin;
using Tour.Common.Constants;
using Tour.Base;
using Newtonsoft.Json;

namespace Tour.Admin.Controllers
{
    public abstract class BaseController : Controller
    {
        public BaseController()
        {

        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string actionName = ControllerContext.RouteData.Values["action"].ToString();
            string controllerName = ControllerContext.RouteData.Values["controller"].ToString();
            ViewBag.ActionName = actionName;
            ViewBag.ControllerName = controllerName;
            if (actionName != "Login" && string.IsNullOrWhiteSpace(context.HttpContext.Session.GetString(DefinedConstants.SessionUser)))
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "SysUsrUser", action = "Login" }));
                base.OnActionExecuting(context);
            }
            if (!string.IsNullOrWhiteSpace(context.HttpContext.Session.GetString(DefinedConstants.SessionUser)))
            {
                var jsonUser = context.HttpContext.Session.GetString(DefinedConstants.SessionUser);
                var infoMemer = JsonConvert.DeserializeObject<UserLoginModel>(jsonUser);
            }
            base.OnActionExecuting(context);
        }
    }
}