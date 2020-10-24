using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SalesSystem.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.API.Attributes
{
    
        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
        public class AuthorizeAttribute : Attribute, IAuthorizationFilter
        {
            public void OnAuthorization(AuthorizationFilterContext context)
            {
                var user = (DTO_User)context.HttpContext.Items["User"];
                if (user == null)
                {
                    // not logged in
                    context.Result = new JsonResult(new { message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
                }
            }
        }
    
}
