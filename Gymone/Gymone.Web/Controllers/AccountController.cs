using Gymone.Entities;
using Gymone.Web.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace Gymone.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _Configure;
        public AccountController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _Configure = configuration;
            ApplicationSettings.WebApiUrl = _Configure.GetValue<string>("WebAPIBaseUrl");
        }
        [HttpGet]
        [AllowAnonymous]

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        //[ValidateAntiForgeryToken]

        public async Task<IActionResult> Login(Login login)
        {
            if (ModelState.IsValid)
            {
                var success = await ApiClientFactory.Instance.ReturnQueryStringValues<bool>($"Account/Login/{login.username}/{login.password}/{login.RememberMe}");
                var UserID = await ApiClientFactory.Instance.ReturnQueryStringValues($"Account/GetUserID_By_UserName/{login.username}");
                var LoginType = await ApiClientFactory.Instance.ReturnQueryStringValues($"Account/GetRoleByUserID/{UserID}");
                if (success == true)
                {
                    if (string.IsNullOrEmpty(Convert.ToString(LoginType)))
                    {
                        ModelState.AddModelError("Error", "Rights to User are not Provide Contact to Admin");
                        return View(login);
                    }
                    else
                    {

                        HttpContext.Session.Set<string>("Name", login.username);
                        HttpContext.Session.Set<string>("UserID", UserID);
                        HttpContext.Session.Set<string>("LoginType", LoginType);

                        if (LoginType.ToLower() == "Admin".ToLower())
                        {
                            return RedirectToAction("Dashboard", "Home");
                        }
                        else
                        {
                            return RedirectToAction("UserDashboard", "Home");
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("Error", "Please enter valid Username and Password");
                    return View(login);
                }
            }
            else
            {
                ModelState.AddModelError("Error", "Please enter Username and Password");
            }
            return View(login);
        }
        public IActionResult Logout()
        {
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        public IActionResult RegisterUser()
        {
            return View();
        }

        public IActionResult TermsAndConditions()
        {
            return View();
        }

    }
}
