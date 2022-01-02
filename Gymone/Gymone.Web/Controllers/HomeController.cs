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
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.Get<string>("UserID") == ""|| HttpContext.Session.Get<string>("UserID")==null)
                return RedirectToAction("Login", "Account");
            else
                return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
        public IActionResult UserDashboard()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
