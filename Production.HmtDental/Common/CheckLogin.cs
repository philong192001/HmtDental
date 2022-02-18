using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace Production.HmtDental.Common
{
    public class CheckLogin : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var user_id = HttpContext.Session.GetString("name");

            if (user_id == null)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Account", action = "Login", area = "" }));
            }
           

            base.OnActionExecuting(filterContext);
        }
    }
}
