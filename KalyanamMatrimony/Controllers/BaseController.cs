using KalyanamMatrimony.Models;
using Microsoft.AspNetCore.Mvc;

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
    }
}
