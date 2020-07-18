using KalyanamMatrimony.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace KalyanamMatrimony.Controllers
{
    public class BaseController : Controller
    {
        protected void ToasterServiceDisplay()
        {
            if (TempData["Message"] != null)
            {
                ViewBag.Message = TempData["Message"];
            }
        }

        protected void ToasterServiceCreate(string message, CustomEnums.ToastType toastType)
        {
            Toaster t = new Toaster();
            t.Message = message;
            t.Type = toastType;
            TempData["Message"] = Newtonsoft.Json.JsonConvert.SerializeObject(t);
        }

        public string GetSessionUserRole()
        {
            if (HttpContext == null)
            {
                return null;
            }
            return HttpContext.Session.GetString("UserRole");
        }

        protected string GetSessionUserId()
        {
            return HttpContext.Session.GetString("UserId");
        }

        protected int GetSessionOrgId()
        {
            return Convert.ToInt32(HttpContext.Session.GetInt32("OrgId"));
        }

        protected int GetSessionLicenseId()
        {
            return Convert.ToInt32(HttpContext.Session.GetInt32("LicenseId"));
        }

        public Organisation GetSessionOrgDetails()
        {
            return HttpContext.Session.GetObject<Organisation>("Org");
        }

        protected void SetSessionUserRole(string userRole)
        {
            HttpContext.Session.SetString("UserRole", userRole);
        }

        protected void SetSessionUserId(string userId)
        {
            HttpContext.Session.SetString("UserId", userId);
        }

        protected void SetSessionOrgId(int orgId)
        {
            HttpContext.Session.SetInt32("OrgId", orgId);
        }

        protected void SetSessionOrgName(string orgName)
        {
            HttpContext.Session.SetString("OrgName", orgName);
        }

        protected void SetSessionLicenseId(int licenseId)
        {
            HttpContext.Session.SetInt32("LicenseId", licenseId);
        }

        protected void SetSessionOrgDetails(Organisation org)
        {
            HttpContext.Session.SetObject("Org", org);
        }

        public bool IsValidLicense()
        {
            bool result = true;
            //if orgtype is shared and licenseid is 0, then admin cannot create a profile
            //string orgType = configuration.GetSection("OrgConfiguration").GetSection("OrgType").Value;

            //loggedin user admin or profile
            string adminRole = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.Admin);
            string adminAssistantRole = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.AdminAssistant);
            string profileRole = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.Profile);
            string userRole = GetSessionUserRole();
            Organisation org = GetSessionOrgDetails();

            if (userRole.ToLower().Equals(adminRole.ToLower()))
            {
                if (org.EndDate < DateTime.Now || org.LicenseId == 0)
                {
                    result = false;
                }
            }
            else if (userRole.ToLower().Equals(profileRole.ToLower()) || userRole.ToLower().Equals(adminAssistantRole.ToLower()))
            {
                //this code will never execute as we are restricting the profile at login action itself
                if (org.EndDate < DateTime.Now)
                {
                    result = false;
                }
            }
            return result;
        }

        public IActionResult ValidateUser()
        {
            //loggedin user admin or profile
            string adminRole = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.Admin);
            string adminAssistantRole = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.AdminAssistant);
            string profileRole = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.Profile);

            if (GetSessionUserRole() == null)
            {
                return RedirectToAction("Logout", "Account");
            }
            else
            {
                string userRole = GetSessionUserRole();
                Organisation org = GetSessionOrgDetails();

                if (userRole.ToLower().Equals(adminRole.ToLower()))
                {
                    if (org.EndDate < DateTime.Now || org.LicenseId == 0)
                    {
                        return RedirectToAction("UpdateLicense", "License");
                    }
                }
                else if (userRole.ToLower().Equals(profileRole.ToLower()) || userRole.ToLower().Equals(adminAssistantRole.ToLower()))
                {
                    //this code will never execute as we are restricting the profile at login action itself
                    if (org.EndDate < DateTime.Now)
                    {
                        return RedirectToAction("AccessDenied", "Account");
                    }
                }
            }

            return RedirectToAction("AccessDenied", "Account");
        }

        //public class RedirectingActionAttribute : ActionFilterAttribute
        //{
        //    public override void OnActionExecuting(ActionExecutingContext filterContext)
        //    {
        //        base.OnActionExecuting(filterContext);

        //        //loggedin user admin or profile
        //        string adminRole = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.Admin);
        //        string adminAssistantRole = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.AdminAssistant);
        //        string profileRole = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.Profile);

        //        if (GetSessionUserRole() == null)
        //        {
        //            filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
        //            {
        //                controller = "Account",
        //                action = "Logout"
        //            }));
        //        }
        //        else
        //        {
        //            string userRole = GetSessionUserRole();
        //            Organisation org = GetSessionOrgDetails();

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

        //    }
        //}
    }
}
