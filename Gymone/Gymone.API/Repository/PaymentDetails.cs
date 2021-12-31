using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;
using Gymone.Entities;
using Microsoft.Extensions.Configuration;

namespace Gymone.API.Repository
{
    public class PaymentDetails : IPaymentDetails
    {
        private readonly IConfiguration _config;
        private string Connectionstring = "GymoneDatabase";

        public PaymentDetails(IConfiguration config)
        {
            _config = config;
        }
        public int InsertPaymentDetails(PaymentDetailsDTO objPD)
        {
            using (SqlConnection con = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                var paramater = new DynamicParameters();
                paramater.Add("@PaymentID", objPD.PaymentID);
                paramater.Add("@PlanID", objPD.PlanID);
                paramater.Add("@WorkouttypeID", objPD.WorkouttypeID);
                paramater.Add("@Paymenttype", "Cash");
                paramater.Add("@PaymentFromdt", objPD.PaymentFromdt);
                paramater.Add("@PaymentAmount", objPD.PaymentAmount);
                paramater.Add("@CreateUserID", objPD.CreateUserID);
                paramater.Add("@ModifyUserID", objPD.ModifyUserID);
                paramater.Add("@RecStatus", "A");
                paramater.Add("@MemberID", objPD.MemberID);
                paramater.Add("@PaymentIDOUT", dbType: DbType.Int32, direction: ParameterDirection.Output);
                con.Execute("sprocPaymentDetailsInsertUpdateSingleItem", paramater, null, 0, CommandType.StoredProcedure);
                int PaymentID = paramater.Get<int>("PaymentIDOUT");
                return PaymentID;
            }
        }

        public int UpdatePaymentDetails(PaymentDetailsDTO objPD)
        {
            using (SqlConnection con = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                var paramater = new DynamicParameters();
                paramater.Add("@PaymentID", objPD.PaymentID);
                paramater.Add("@PlanID", objPD.PlanID);
                paramater.Add("@WorkouttypeID", objPD.WorkouttypeID);
                paramater.Add("@Paymenttype", "Cash");
                paramater.Add("@PaymentFromdt", objPD.PaymentFromdt);
                paramater.Add("@PaymentAmount", objPD.PaymentAmount);
                paramater.Add("@ModifyUserID", objPD.ModifyUserID);
                paramater.Add("@RecStatus", "A");
                paramater.Add("@MemberID", objPD.MemberID);
                paramater.Add("@PaymentIDOUT", dbType: DbType.Int32, direction: ParameterDirection.Output);
                con.Execute("sprocMemberRegistrationUpdateSingleItem", paramater, null, 0, CommandType.StoredProcedure);
                int PaymentID = paramater.Get<int>("PaymentIDOUT");
                return PaymentID;
            }

        }
    }
}