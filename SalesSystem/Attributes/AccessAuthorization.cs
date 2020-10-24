using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SalesSystem.BLL.DTO;
using SalesSystem.Helpers;
using System;

namespace SalesSystem.Attributes
{



    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AccessAuthorizationSupplierOnly : Attribute, IAuthorizationFilter
    {

        public void OnAuthorization(AuthorizationFilterContext context)
        {

            var user = SessionManager.Get<DTO_User>(context.HttpContext.Session, "LoggedUser");
            if (user == null)
            {
                context.Result = new RedirectResult("~/");
            }
            else if (user.username == "Dealer")
            {
                context.Result = new RedirectResult("~/");
            }

        }
    }


    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AccessAuthorizationAll : Attribute, IAuthorizationFilter
    {

        public void OnAuthorization(AuthorizationFilterContext context)
        {

            var user = SessionManager.Get<DTO_User>(context.HttpContext.Session, "LoggedUser");
            if (user == null)
            {
                context.Result = new RedirectResult("~/");
            }


        }
    }
}
