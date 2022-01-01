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
    public class RenewalController : BaseController
    {
        private readonly ILogger<RenewalController> _logger;
        private readonly IRenewal renewal;
        public RenewalController(IRenewal _IRenewal, ILogger<RenewalController> logger)
        {
            renewal = _IRenewal;
            _logger = logger;
        }
        [HttpGet]
        [Route("GetDataofMember/{MemberID}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public RenewalDATA GetDataofMember(string MemberID)
        {
            try
            {
                return renewal.GetDataofMember(MemberID);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "GetDataofMember", 1);
                return new RenewalDATA();
            }
        }
        [HttpGet]
        [Route("Get_PeriodID_byPlan/{PlanID}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public string Get_PeriodID_byPlan(string PlanID)
        {
            try
            {
                return renewal.Get_PeriodID_byPlan(PlanID);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "Get_PeriodID_byPlan", 1);
                return string.Empty;
            }
        }
    }
}
