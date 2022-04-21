using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Admin_Presentation_API.Auth
{
    public class CustomAuth : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var token = actionContext.Request.Headers.Authorization;
            if (token == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.BadRequest, "No token supplied");
            }
            else
            {
                var rs = AuthService.ValidateToken(token.ToString());
                if (!rs)
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.BadRequest, "Invalid Token");
                }
            }
            base.OnAuthorization(actionContext);
        }

    }
}