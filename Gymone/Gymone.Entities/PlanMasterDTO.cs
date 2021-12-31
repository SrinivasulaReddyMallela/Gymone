using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Web.Mvc;

namespace Gymone.Entities
{

    public class PlanMasterDTO
    {
        public int PlanID { get; set; }
       
        public string PlanName { get; set; }
       
        public Double? PlanAmount { get; set; }
       
        public Double ServicetaxAmout { get; set; }
      
        public Double? ServiceTax { get; set; }
        public int CreateUserID { get; set; }
        public int ModifyUserID { get; set; }
        public string RecStatus { get; set; }
       
        public int? SchemeID { get; set; }
        
        public int? PeriodID { get; set; }

        public int? TotalAmout { get; set; }
        public string ServicetaxNo { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
         
        public IEnumerable<SchemeMasterDTO> ListScheme { get; set; }
         
        public IEnumerable<SelectListItem> ListofPeriod { get; set; }



    }
    public class RecepitDTO
    {
        public string SearchButton { get; set; }
        public string PaymentSearch { get; set; }
        public string MembernoSearch { get; set; }
        public string MemberName { get; set; }
    }
    public class ValidateScheme_Plan : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (Convert.ToInt32(value) == 0 || Convert.ToInt32(value) == null)
                return false;
            else
                return true;
        }
    }

    public class ValidatePeriod : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (Convert.ToInt32(value) == 0 || Convert.ToInt32(value) == null)
                return false;
            else
                return true;
        }

    }


}
