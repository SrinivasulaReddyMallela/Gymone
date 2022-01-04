using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gymone.Entities
{
    public class Login
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string password { get; set; }

        [Required(ErrorMessage = "Enter User name")]
        public string username { get; set; }
        public bool RememberMe { get; set; }
        public bool IsLoginSucess { get; set; }
        public string LoginType { get; set; }
        public string UserID { get; set; }

    }
}
