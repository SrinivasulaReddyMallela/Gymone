using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Gymone.Entities
{
    // Add profile data for application users by adding properties to the ApplicationWebUser class
    public class ApplicationWebUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
      //  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // [Key]
        // public int TempUserID { get; set; }

    }

}
