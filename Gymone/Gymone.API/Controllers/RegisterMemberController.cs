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
    [Route("api/[controller]")]

    public class RegisterMemberController : BaseController
    {
        private readonly ILogger<RegisterMemberController> _logger;
        private readonly IRegisterMember RegisterMember;
        public RegisterMemberController(IRegisterMember _IRegisterMember, ILogger<RegisterMemberController> logger)
        {
            RegisterMember = _IRegisterMember;
            _logger = logger;
        }
        [HttpPost]
        [Route("InsertMember")]
        public int InsertMember(MemberRegistrationDTO objMRDTO)
        {
            try
            {
                return RegisterMember.InsertMember(objMRDTO);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "InsertMember", 1);
                return 0;
            }
        }

        [HttpGet]
        [Route("GetMember")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<MemberRegistrationDTO> GetMember()
        {
            try
            {
                return RegisterMember.GetMember();
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "GetMember", 1);
                return new List<MemberRegistrationDTO>();
            }
        }
        [HttpGet]
        [Route("GetMemberbyID/{MemID}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public MemberRegistrationDTO GetMemberbyID(string MemID)
        {
            try
            {
                return RegisterMember.GetMemberbyID(MemID);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "GetMemberbyID", 1);
                return new MemberRegistrationDTO();
            }
        }
        [HttpPost]
        [Route("UpdateMember")]
      
        public int UpdateMember(MemberRegistrationDTO MemID)
        {
            try
            {
                return RegisterMember.UpdateMember(MemID);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "UpdateMember", 1);
                return 0;
            }
        }

        [HttpGet]
        [Route("DeleteMember/{MemID}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void DeleteMember(string MemID)
        {
            try
            {
                RegisterMember.DeleteMember(MemID);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "DeleteMember", 1);
            }
        }
        [HttpGet]
        [Route("GetAmount/{MemID}/{WorkTypeID}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public string GetAmount(string MemID, string WorkTypeID)
        {
            try
            {
                return RegisterMember.GetAmount(MemID,WorkTypeID);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "GetAmount", 1);
                return string.Empty;
            }
        }
    }
}
