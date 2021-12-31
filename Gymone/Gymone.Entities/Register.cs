using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace Gymone.Entities
{
    public class Register
    {
        public string FullName { get; set; }
        
        public string username { get; set; }
       
        public string EmailID { get; set; }
        
        public string password { get; set; }
        
        public string Confirmpassword { get; set; }



    }
    public class RenewalDTO
    {
        public string SearchButton { get; set; }
        public string PaymentSearch { get; set; }
        public string MembernoSearch { get; set; }
        public string MemberName { get; set; }

        public RenewalDATA RenewalDATA { get; set; }
    }
    public class RenewalSearch
    {
        public string SearchButton { get; set; }
        public string RenewalSearchID { get; set; }
        public string Fromdate { get; set; }
        public string Todate { get; set; }
        public string Exactdate { get; set; }
    }
    public class RenewalDATA
    {
        public string PaymentAmount { get; set; }
        public string RenwalDate { get; set; }
        public string NewDate { get; set; }
        public string ContinuesDate { get; set; }
        public string Name { get; set; }
        public string MemberNo { get; set; }
        public string MainMemberID { get; set; }
        public string WorkouttypeID { get; set; }
        public string PlantypeID { get; set; }
        public string DrpRenewal { get; set; }
        public string MemberID { get; set; }
        public string PaymentID { get; set; }
        
        public IEnumerable<SchemeMasterDTO> ListScheme { get; set; }
         
        public IEnumerable<PlanMasterDTO> ListPlan { get; set; }
        
        public IEnumerable<SelectListItem> ListRenewaltype { get; set; }
    }

    public class Role
    {
        
        public int RoleId { get; set; }
        
        public string RoleName { get; set; }
    }
    public class Users
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public string FullName { get; set; }

        public string EmailID { get; set; }
    }
    public class SchemeMasterDTO
    {
        public int SchemeID { get; set; }
        
        public string SchemeName { get; set; }
        public string Createdby { get; set; }
        public DateTime Createddate { get; set; }
    }

    public class YearwiseModel
    {
        public string YearID { get; set; }
        public IEnumerable<SelectListItem> YearNameList { get; set; }
    }
}
