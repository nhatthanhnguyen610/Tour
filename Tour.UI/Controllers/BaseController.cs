using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tour.Base;
using Tour.UI;

namespace Tour.UI.Controllers
{
    public abstract class BaseController : Controller
    {
        public BaseController()
        {
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!string.IsNullOrWhiteSpace(context.HttpContext.Session.GetString(DefinedConstants.SessionUser)))
            {
                var jsonUser = context.HttpContext.Session.GetString(DefinedConstants.SessionUser);
                var infoMemer = JsonConvert.DeserializeObject<SysCustomerModel>(jsonUser);
            }
            base.OnActionExecuting(context);
        }
    }
}
