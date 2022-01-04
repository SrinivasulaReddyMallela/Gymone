using Gymone.Entities;
using Gymone.Web.Common;
using Microsoft.AspNet.Identity;
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
    public class AccountController : BaseController
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
            return View("Login");
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Login(Login login)
        {
            if (ModelState.IsValid)
            {
                var success = ApiClientFactory.Instance.ReturnQueryStringValues<bool>($"Account/Login/{login.username}/{login.password}/{login.RememberMe}").GetAwaiter().GetResult();
                if (success == true)
                {
                    var UserID = await ApiClientFactory.Instance.ReturnQueryStringValues($"Account/GetUserID_By_UserName/{login.username}");
                    var LoginType = await ApiClientFactory.Instance.ReturnQueryStringValues($"Account/GetRoleByUserID/{UserID}");
                    if (string.IsNullOrEmpty(Convert.ToString(LoginType)))
                    {
                        ModelState.AddModelError("Error", "Rights to User are not Provide Contact to Admin");
                        return View("Login", login);
                    }
                    else
                    {

                        HttpContext.Session.Set<string>("Name", login.username);
                        HttpContext.Session.Set<string>("UserID", UserID);
                        HttpContext.Session.Set<string>("LoginType", LoginType);

                        if (LoginType.ToLower() == "Admin".ToLower())
                        {
                            return RedirectToActionPermanent("Dashboard", "Home");
                        }
                        else
                        {
                            return RedirectToActionPermanent("UserDashboard", "Home");
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("Error", "Please enter valid Username and Password");
                    return View("Login", login);
                }
            }
            else
            {
                ModelState.AddModelError("Error", "Please enter Username and Password");
            }
           return View("Login", login);
        }
        public IActionResult Logout()
        {
            foreach (var cookie in Request.Cookies.Keys)
            {
                if (cookie == ".Gymone.Svr")
                    Response.Cookies.Delete(cookie);
            }
            HttpContext.Session.Clear();
            return PartialView("Logout");
        }
        public IActionResult ForgotPassword()
        {
            return PartialView("ForgotPassword");
        }
        public IActionResult RegisterUser()
        {
            return PartialView("RegisterUser");
        }

        public IActionResult TermsAndConditions()
        {
            return PartialView("TermsAndConditions");
        }
        public IActionResult ChangePassword()
        {
            return PartialView("ChangePassword", new ChangepasswordVM());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Changepassword(ChangepasswordVM VM)
        {
            if (ModelState.IsValid)
            {
                if (HttpContext.Session.Get<string>("UserID") == "" || HttpContext.Session.Get<string>("UserID") == null)
                {
                    ModelState.AddModelError("Error", "UserName Does not exists");
                }
                else
                {
                    if (VM.Newpassword == VM.OldPassword)
                    {
                        ModelState.AddModelError("Error", "Old password should not same with new password");
                    }
                    else
                    {
                        var changePasswordResult = await ApiClientFactory.Instance.ReturnQueryStringValues<bool>($"Account/ChangePassword/{HttpContext.Session.Get<string>("UserID")}/{VM.OldPassword}/{VM.Newpassword}");
                        if (!changePasswordResult)
                        {
                            ModelState.AddModelError("Error", "Please try one more time");
                        }
                        else
                        {
                            ViewBag.ResultMessage = "Password Changed Successfully";
                        }
                    }
                }
            }
            else
            {
                ModelState.AddModelError("Error", "Fill on Fields");
            }
            return PartialView("ChangePassword", VM);
        }

    }
}
