using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Association_UMS.Auth
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)] //we will use this in class and attributes
    public class AdminAccess :AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            
            //from we have to check if the login user Admin or not
            var authenticated = base.AuthorizeCore(httpContext);
            
            if(!authenticated)
            {
                return false;  //if the user is authenticate but role is not Admin return false
            }

            if(httpContext.Session["role"].ToString().Equals("Admin"))
            {
                return true; //if the user is authenticate and role is Admin return true
            }
            return false; //if the user is not authenticate return false
            //return base.AuthorizeCore(httpContext);
        }

        //if there is any unauthorize Request
       /*
         protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.HttpContext.Response.Redirect("/home/login");
            base.HandleUnauthorizedRequest(filterContext);
        }
       */
    }
}