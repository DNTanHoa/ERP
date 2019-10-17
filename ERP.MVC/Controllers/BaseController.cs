using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP.MVC.Commons;
using ERP.MVC.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace ERP.MVC.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var session = HttpContext.Session.GetString("User");
            if(session == null)
            {
                context.Result = new RedirectToRouteResult(new
                    RouteValueDictionary(new { controller = "Login", action = "Index", Area = "Admin" }));
            }
            base.OnActionExecuting(context);
        }
    }
}