using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymone.Web.Controllers
{
    public class AdminController : BaseController
    {
        public IActionResult GetUsers()
        {
            return PartialView();
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
