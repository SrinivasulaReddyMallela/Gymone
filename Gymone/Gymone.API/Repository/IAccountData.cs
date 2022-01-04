using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gymone.Entities;


namespace Gymone.API.Repository
{
    public interface IAccountData
    {
        bool Login(string Login,string Password, bool persistCookie = false);
        IEnumerable<Role> GetRoles();
        IEnumerable<Users> GetAllUsers();
        string GetRoleByUserID(string UserId);
        string GetUserID_By_UserName(string UserName);
        string Get_checkUsernameExits(string username);
        bool Get_CheckUserRoles(string UserId);
        string GetUserName_BY_UserID(string UserId);
        IEnumerable<AllroleandUser> DisplayAllUser_And_Roles();
        Login GetLoginData(string Login, string Password);
        
    }
}
