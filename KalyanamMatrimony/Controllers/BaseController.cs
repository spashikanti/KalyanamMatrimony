using KalyanamMatrimony.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        protected string GetSessionUserRole()
        {
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
    }
}
