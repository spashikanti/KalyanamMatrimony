using KalyanamMatrimony.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using System;

namespace KalyanamMatrimony.Models
{
    /// <summary>
    /// Dont use this attribute in all controllers else there is a chance of infinite loop
    /// Use it only in ProfileController, HomeController, AdminController
    /// </summary>
    public class RedirectingActionAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            if (filterContext.HttpContext.Session.GetString("UserRole") == null)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                {
                    controller = "Account",
                    action = "Logout"
                }));
            }
            else
            {
                if (filterContext.HttpContext.Session.GetString("OrgType") == Enum.GetName(typeof(CustomEnums.OrgType), CustomEnums.OrgType.Shared))
                {
                    //loggedin user admin or profile
                    string adminRole = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.Admin);
                    string adminAssistantRole = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.AdminAssistant);
                    string profileRole = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.Profile);

                    string userRole = filterContext.HttpContext.Session.GetString("UserRole");
                    Organisation org = filterContext.HttpContext.Session.GetObject<Organisation>("Org");

                    if (userRole.ToLower().Equals(adminRole.ToLower()))
                    {
                        if (org.EndDate < DateTime.Now || org.LicenseId == 0)
                        {
                            filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                            {
                                controller = "License",
                                action = "ChooseLicense"
                            }));
                        }
                    }
                    else if (userRole.ToLower().Equals(profileRole.ToLower()) || userRole.ToLower().Equals(adminAssistantRole.ToLower()))
                    {
                        //this code will never execute as we are restricting the profile at login action itself
                        if (org.EndDate < DateTime.Now)
                        {
                            filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                            {
                                controller = "Account",
                                action = "AccessDenied"
                            }));
                        }
                    }
                }
            }
        }
    }
}
