using KalyanamMatrimony.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalyanamMatrimony.Controllers
{
    public class BaseController: Controller
    {
        protected void ToasterService(string toastType)
        {
            if (TempData["Message"] != null)
            {
                Toaster t = new Toaster();
                t.Type = toastType;
                t.Message = TempData["Message"].ToString();
                ViewBag.Message = t;
            }
        }
    }
}
