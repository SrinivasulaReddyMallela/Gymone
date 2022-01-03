using Gymone.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Gymone.Web.Common;

namespace Gymone.Web.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return PartialView("Error", new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult AccessDenied()
        {
            return PartialView("AccessDenied");
        }
        public IActionResult UserDashboard()
        {
            return View("UserDashboard");
        }
        public IActionResult Dashboard()
        {
            return  View("Dashboard");
        }
    }
}
