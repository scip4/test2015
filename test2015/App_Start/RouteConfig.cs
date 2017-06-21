using SimpleMvcUserManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace test2015
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            // AreaRegistration.RegisterAllAreas();
            UserManagementController.RegisterMe();
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
        protected void Application_AuthenticateRequest()
        {
            // check if the user management controller is the target controller for this request
            if (UserManagementController.IsTargeted())
            {
                // Do any custom authorization checks here (e.g. Roles.IsUserInRole("Admin")) 
                UserManagementController.IsRequestAuthorized = true;
            }
        }
    }
}
