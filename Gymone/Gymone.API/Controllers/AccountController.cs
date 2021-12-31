using Gymone.API.Repository;
using Gymone.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace Gymone.API.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class AccountController : BaseController
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IAccountData accountdata;
        public AccountController(IAccountData _accountData, ILogger<AccountController> logger)
        {
            accountdata = _accountData;
            _logger = logger;
        }
        [HttpGet]
        //[Consumes(MediaTypeNames.Application.Json)]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<Role> GetRoles()
        {
            try
            {
                return accountdata.GetRoles();
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "GetRoles", 1);
                //return StatusCode(StatusCodes.Status400BadRequest, new Response { Status = "Error", Message = "Internal Server Error" });
                return new List<Role>();
            }
        }
        [HttpGet]
        //[Consumes(MediaTypeNames.Application.Json)]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<Users> GetAllUsers()
        {
            try
            {
                return accountdata.GetAllUsers();
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "GetAllUsers", 1);
                //return StatusCode(StatusCodes.Status400BadRequest, new Response { Status = "Error", Message = "Internal Server Error" });
                return new List<Users>();
            }
        }
        [HttpGet]
        //[Consumes(MediaTypeNames.Application.Json)]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        public string GetRoleByUserID(string UserId)
        {
            try
            {
                return accountdata.GetRoleByUserID(UserId);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "GetRoleByUserID", 1);
                return string.Empty;
            }
        }
        [HttpGet]
        //[Consumes(MediaTypeNames.Application.Json)]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        public string GetUserID_By_UserName(string UserName)
        {
            try
            {
                return accountdata.GetUserID_By_UserName(UserName);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "GetUserID_By_UserName", 1);
                return string.Empty;
            }
        }
        [HttpGet]
        //[Consumes(MediaTypeNames.Application.Json)]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        public string Get_checkUsernameExits(string username)
        {
            try
            {
                return accountdata.Get_checkUsernameExits(username);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "Get_checkUsernameExits", 1);
                return string.Empty;
            }
        }
        [HttpGet]
        //[Consumes(MediaTypeNames.Application.Json)]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Get_CheckUserRoles(string UserId)
        {
            try
            {
                return accountdata.Get_CheckUserRoles(UserId);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "Get_CheckUserRoles", 1);
                return false;
            }
        }
        [HttpGet]
        //[Consumes(MediaTypeNames.Application.Json)]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        public string GetUserName_BY_UserID(string UserId)
        {
            try
            {
                return accountdata.GetUserName_BY_UserID(UserId);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "GetUserName_BY_UserID", 1);
                return string.Empty;
            }
        }
        [HttpGet]
        //[Consumes(MediaTypeNames.Application.Json)]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<AllroleandUser> DisplayAllUser_And_Roles()
        {
            try
            {
                return accountdata.DisplayAllUser_And_Roles();
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "DisplayAllUser_And_Roles", 1);
                return new List<AllroleandUser>();
            }
        }
    }
}
