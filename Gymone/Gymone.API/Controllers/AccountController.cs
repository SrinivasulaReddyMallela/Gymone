using Gymone.API.Repository;
using Gymone.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace Gymone.API.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : BaseController
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IAccountData accountdata;
        private readonly SignInManager<ApplicationWebUser> _signInManager;
        private readonly IUserRepository<ApplicationWebUser> UserRepository;
        private readonly UserManager<ApplicationWebUser> _userManager;
        public AccountController(SignInManager<ApplicationWebUser> signInManager, IAccountData _accountData, ILogger<AccountController> logger,
            IUserRepository<ApplicationWebUser> userRepository,
            UserManager<ApplicationWebUser> userManager)
        {
            _signInManager = signInManager;
            accountdata = _accountData;
            _logger = logger;
            UserRepository = userRepository;
            _userManager = userManager;
        }
        [HttpGet]
        [Route("Login/{Login}/{Password}/{persistCookie:bool}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Login(string Login, string Password, bool persistCookie = false)
        {
            try
            {
                return _signInManager.PasswordSignInAsync(Login, Password, persistCookie, true).GetAwaiter().GetResult().Succeeded;
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "Login", 1);
                return false;
            }
        }
        [HttpGet]
        [Route("GetLoginUser/{UserID}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ApplicationWebUser GetLoginUser(string UserID)
        {
            try
            {
                return _userManager.FindByIdAsync(UserID).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "ChangePassword", 1);
                return new ApplicationWebUser();
            }
        }
        [HttpGet]
        [Route("ChangePassword/{UserID}/{OLDPassword}/{NewPassword}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<bool> ChangePassword(string UserID, string OLDPassword, string NewPassword)
        {
            try
            {
                var user = _userManager.FindByIdAsync(UserID).GetAwaiter().GetResult();
                return await UserRepository.SetPasswordHashAsync(user, new PasswordHasher<ApplicationWebUser>().HashPassword(user, NewPassword));
                // return _userManager.UpdatePasswordHash(user, NewPassword, false).GetAwaiter().GetResult();
                // return _userManager.ChangePasswordAsync(user, OLDPassword, NewPassword).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "ChangePassword", 1);
                return false;
            }
        }

        [HttpGet]
        [Route("GetRoles")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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
        [Route("GetAllUsers")]

        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<ApplicationWebUser> GetAllUsers()
        {
            try
            {
                return UserRepository.GetAllUsersData();
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "GetAllUsers", 1);
                return new List<ApplicationWebUser>();
            }
        }
        [HttpGet]
        [Route("GetRoleByUserID/{UserId}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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
        [Route("GetUserID_By_UserName/{UserName}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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
        [Route("Get_checkUsernameExits/{UserName}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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
        [Route("Get_checkUsernameExits/{UserId:int}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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
        [Route("GetUserName_BY_UserID/{UserId:int}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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
        [Route("DisplayAllUser_And_Roles")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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

        [HttpGet]
        [Route("GetLoginData")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Login GetLoginData(string Login, string Password, bool persistCookie = false)
        {
            try
            {
                return accountdata.GetLoginData(Login, )
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "GetLoginData", 1);
                return new Login();
            }
        }
    }
}
