using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Gymone.Entities;

namespace Gymone.API.Repository
{
    public interface IlReports
    {
        DataSet Generate_AllMemberDetailsReport();
        DataSet Get_MonthwisePayment_details(string MonthID);
        DataSet Get_YearwisePayment_details(string YearID);
        DataSet Get_RenewalReport(RenewalSearch objRS);
    }
}
