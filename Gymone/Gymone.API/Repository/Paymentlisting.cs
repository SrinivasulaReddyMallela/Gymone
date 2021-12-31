using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Configuration;
using System.Data.SqlClient;
using Gymone.Entities;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace Gymone.API.Repository
{
    public class Paymentlisting : IPaymentlisting
    {
        private readonly IConfiguration _config;
        private string Connectionstring = "GymoneDatabase";

        public Paymentlisting(IConfiguration config)
        {
            _config = config;
        }
        public IEnumerable<PaymentlistingDTO> AllPaymentDetails(string MemberID)
        {
            using (SqlConnection con = new SqlConnection(Convert.ToString(_config.GetConnectionString(Connectionstring))))
            {
                var param = new  DynamicParameters();
                param.Add("@MemberID", MemberID);
                return con.Query<PaymentlistingDTO>("Usp_PaymentDetailinfo", param, null, true, 0, commandType: CommandType.StoredProcedure);
            }

        }


        public IEnumerable<PaymentlistingDTO> AllPaymentDetails()
        {
            using (SqlConnection con = new SqlConnection(Convert.ToString(_config.GetConnectionString(Connectionstring))))
            {
                return con.Query<PaymentlistingDTO>("Usp_ALLPaymentDetailinfo", null, null, true, 0, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<PaymentAutocompDTO> ListofMemberNo(string Memberno)
        {
            using (SqlConnection con = new SqlConnection(Convert.ToString(_config.GetConnectionString(Connectionstring))))
            {
                var param = new DynamicParameters();
                param.Add("@MemberID", Memberno);
                return con.Query<PaymentAutocompDTO>("USP_listofMemberno", param, null, true, 0, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<PaymentAutocompDTO> ListofMemberName(string Membername)
        {
            using (SqlConnection con = new SqlConnection(Convert.ToString(_config.GetConnectionString(Connectionstring))))
            {
                var param = new DynamicParameters();
                param.Add("@MemberFName", Membername);
                return con.Query<PaymentAutocompDTO>("USP_listofMemberName", param, null, true, 0, commandType: CommandType.StoredProcedure);
            }
        }


    }
}