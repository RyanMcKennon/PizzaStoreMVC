using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreMVC.Client
{
    public class ValidAction : System.Web.Mvc.ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var context = filterContext.RequestContext.HttpContext;

            if (context.Request.UserAgent.Contains("IE"))
            {
                context.Response.Redirect("~/ie/index");
            }
        }
    }
}