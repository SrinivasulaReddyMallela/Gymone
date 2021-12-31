using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace Gymone.Entities
{
    public class AssignRoleVM
    {
        public string RoleName { get; set; }
        public string UserName { get; set; }
        public List<SelectListItem> Userlist { get; set; }
        public List<SelectListItem> RolesList { get; set; }
    }

    public class AllroleandUser
    {
        public string RoleName { get; set; }
        public string UserName { get; set; }

        public IEnumerable<AllroleandUser> AllDetailsUserlist { get; set; }
    }
}
