using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gymone.Entities;

namespace Gymone.API.Repository
{
    interface IRenewal
    {
        RenewalDATA GetDataofMember(string MemberID);
        string Get_PeriodID_byPlan(string PlanID);
    }
}
