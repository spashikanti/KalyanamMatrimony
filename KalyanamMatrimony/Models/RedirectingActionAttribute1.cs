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
    //public class RedirectingActionAttribute: ActionFilterAttribute
    //{
    //    public override void OnActionExecuting(ActionExecutingContext filterContext)
    //    {
    //        base.OnActionExecuting(filterContext);

    //        BaseController baseController = new BaseController();

    //        //if orgtype is shared and licenseid is 0, then admin cannot create a profile
    //        //string orgType = configuration.GetSection("OrgConfiguration").GetSection("OrgType").Value;

    //        //loggedin user admin or profile
    //        string adminRole = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.Admin);
    //        string adminAssistantRole = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.AdminAssistant);
    //        string profileRole = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.Profile);

    //        if (baseController.GetSessionUserRole() == null)
    //        {
    //            filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
    //            {
    //                controller = "Account",
    //                action = "Logout"
    //            }));
    //        }
    //        else
    //        {
    //            string userRole = baseController.GetSessionUserRole();
    //            Organisation org = baseController.GetSessionOrgDetails();

    //            if (userRole.ToLower().Equals(adminRole.ToLower()))
    //            {
    //                if (org.EndDate < DateTime.Now || org.LicenseId == 0)
    //                {
    //                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
    //                    {
    //                        controller = "License",
    //                        action = "UpdateLicense"
    //                    }));
    //                }
    //            }
    //            else if (userRole.ToLower().Equals(profileRole.ToLower()) || userRole.ToLower().Equals(adminAssistantRole.ToLower()))
    //            {
    //                //this code will never execute as we are restricting the profile at login action itself
    //                if (org.EndDate < DateTime.Now)
    //                {
    //                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
    //                    {
    //                        controller = "Account",
    //                        action = "AccessDenied"
    //                    }));
    //                }
    //            }
    //        }

    //        baseController = null;
    //    }
    //}
}
