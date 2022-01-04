using Gymone.Web.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gymone.Web.Models;
using Gymone.Entities;

namespace Gymone.Web.Controllers
{
    public class AdminController : BaseController
    {
        private readonly ILogger<AdminController> _logger;
        private readonly IConfiguration _Configure;
        public AdminController(ILogger<AdminController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _Configure = configuration;
            ApplicationSettings.WebApiUrl = _Configure.GetValue<string>("WebAPIBaseUrl");
        }
        public async Task<IActionResult> GetUsers(
            string sortOrder,
            string currentFilter,
            string searchString,
            int? pageNumber)
        {
            var UserData = await ApiClientFactory.Instance.ReturnQueryStringValues<List<ApplicationWebUser>>($"Account/GetAllUsers");
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "firstname_desc" : "";
            ViewData["EmailSortParm"] = sortOrder == "Email" ? "email_desc" : "Email";
            if (searchString != null)
                pageNumber = 1;
            else
                searchString = currentFilter;
            ViewData["CurrentFilter"] = searchString;
            if (!String.IsNullOrEmpty(searchString))
                UserData = UserData.Where(s => s.FirstName.Contains(searchString, StringComparison.CurrentCultureIgnoreCase) 
                || s.LastName.Contains(searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();
            switch (sortOrder)
            {
                case "firstname_desc":
                    UserData = UserData.OrderByDescending(s => s.FirstName).ToList();
                    break;
                case "Email":
                    UserData = UserData.OrderBy(s => s.Email).ToList();
                    break;
                case "email_desc":
                    UserData = UserData.OrderByDescending(s => s.Email).ToList();
                    break;
                default:
                    UserData = UserData.OrderBy(s => s.FirstName).ToList();
                    break;
            }
            int pageSize = 10;
            return PartialView("GetUsers", PaginatedList<ApplicationWebUser>.CreateAsync(UserData, pageNumber ?? 1, pageSize));
        }



        public IActionResult Schemes()
        {
            return PartialView();
        }

        public IActionResult Plans()
        {
            return PartialView();
        }
        public IActionResult RolesAssignedtoUsers()
        {
            return PartialView();
        }
        public IActionResult Users()
        {
            return PartialView();
        }

        public IActionResult YearwiseReport()
        {
            return PartialView();
        }
        public IActionResult MonthwiseReport()
        {
            return PartialView();
        }

        public IActionResult MemberDetailsReport()
        {
            return PartialView();
        }


    }
}
