using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;
using Gymone.Entities;
using Microsoft.Extensions.Configuration;

namespace Gymone.API.Repository
{
    public class Renewal : IRenewal
    {
        private readonly IConfiguration _config;
        private string Connectionstring = "GymoneDatabase";

        public Renewal(IConfiguration config)
        {
            _config = config;
        }
        public RenewalDATA GetDataofMember(string MemberID)
        {
            using (SqlConnection con = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                var para = new DynamicParameters();
                para.Add("@MainMemberID", MemberID);
                return con.Query<RenewalDATA>("Usp_GetDataofMemberbyID", para, null, true, 0, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }

        public string Get_PeriodID_byPlan(string PlanID)
        {
            using (SqlConnection con = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                var para = new DynamicParameters();
                para.Add("@PlanID", PlanID);
                return con.Query<string>("Usp_getPlanPeriodID", para, null, true, 0, commandType: CommandType.StoredProcedure).SingleOrDefault();
            }
        }


     
    }
}