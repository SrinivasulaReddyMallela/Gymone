using Dapper;
using Gymone.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
 

namespace Gymone.API.Repository
{
    public class AccountData: IAccountData
    {
        private readonly IConfiguration _config;
        private string Connectionstring = "GymoneDatabase";

        public AccountData(IConfiguration config)
        {
            _config = config;
        }

        public bool Login(string Login, string Password, bool persistCookie = false)
        {
            return true;
           // return WebMatrix.WebData.WebSecurity.Login(Login, Password,persistCookie);
        }

        public IEnumerable<Role> GetRoles()
        {
            using (SqlConnection con = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                return con.Query<Role>("Usp_GetRoles", null, null, true, 0, CommandType.StoredProcedure).ToList();
            }
        }

        public IEnumerable<Users> GetAllUsers()
        {
            using (SqlConnection con = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                return con.Query<Users>("Usp_GetAllUsers", null, null, true, 0, CommandType.StoredProcedure).ToList();
            }
        }

        public string GetRoleByUserID(string UserId)
        {
            using (SqlConnection con = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                var para = new DynamicParameters();
                para.Add("@UserId", UserId);
                return con.Query<string>("Usp_getRoleByUserID", para, null, true, 0, CommandType.StoredProcedure).SingleOrDefault();
            }
        }

        public string GetUserID_By_UserName(string UserName)
        {
            using (SqlConnection con = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                var para = new DynamicParameters();
                para.Add("@UserName", UserName);
                return con.Query<string>("Usp_UserIDbyUserName", para, null, true, 0, CommandType.StoredProcedure).SingleOrDefault();
            }
        }

        public string Get_checkUsernameExits(string username)
        {
            using (SqlConnection con = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                var para = new DynamicParameters();
                para.Add("@UserName", username);
                return con.Query<string>("Usp_checkUsernameExits", para, null, true, 0, CommandType.StoredProcedure).SingleOrDefault();
            }
        }

        public bool Get_CheckUserRoles(string UserId)
        {
            using (SqlConnection con = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                var para = new DynamicParameters();
                para.Add("@UserId", UserId);
                return con.Query<bool>("Usp_CheckUserRoles", para, null, true, 0, CommandType.StoredProcedure).SingleOrDefault();
            }
        }

        public string GetUserName_BY_UserID(string UserId)
        {
            using (SqlConnection con = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                var para = new DynamicParameters();
                para.Add("@UserId", UserId);
                return con.Query<string>("Usp_UserNamebyUserID", para, null, true, 0, CommandType.StoredProcedure).SingleOrDefault();
            }
        }

        public IEnumerable<AllroleandUser> DisplayAllUser_And_Roles()
        {
            using (SqlConnection con = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                return con.Query<AllroleandUser>("Usp_DisplayAllUser_And_Roles", null, null, true, 0, CommandType.StoredProcedure).ToList();
            }
        }
    }
}
