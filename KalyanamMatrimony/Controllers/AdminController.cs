using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KalyanamMatrimony.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KalyanamMatrimony.Controllers
{
    [Authorize(Roles ="SuperAdmin, Admin")]
    public class AdminController : Controller
    {
        private readonly IEmployeeRepository employeeRepository;

        public AdminController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
