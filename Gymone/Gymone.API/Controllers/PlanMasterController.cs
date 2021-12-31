using Gymone.API.Repository;
using Gymone.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymone.API.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class PlanMasterController : BaseController
    {
        private readonly ILogger<PlanMasterController> _logger;
        private readonly IPlanMaster planMaster;
        public PlanMasterController(IPlanMaster _IPlanMaster, ILogger<PlanMasterController> logger)
        {
            planMaster = _IPlanMaster;
            _logger = logger;
        }
        [HttpPost]
        public void InsertPlan(PlanMasterDTO Plan)
        {
            try
            {
                planMaster.InsertPlan(Plan);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "InsertPlan", 1);
            }
        }
        [HttpGet]
        public IEnumerable<PlanMasterDTO> GetPlan()
        {
            try
            {
                return planMaster.GetPlan();
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "GetPlan", 1);
                return new List<PlanMasterDTO>();
            }
        }
        [HttpGet]
        public PlanMasterDTO GetPlanByID(string PlanID)
        {
            try
            {
                return planMaster.GetPlanByID(PlanID);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "GetPlanByID", 1);
                return new PlanMasterDTO();
            }
        }
        [HttpPost]
        public void UpdatePlan(PlanMasterDTO Plan)
        {
            try
            {
                planMaster.UpdatePlan(Plan);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "UpdatePlan", 1);

            }
        }
        [HttpPost]
        public void DeletePlan(string PlanID)
        {
            try
            {
                planMaster.DeletePlan(PlanID);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "DeletePlan", 1);

            }
        }
        [HttpGet]
        public bool PlannameExists(string Planname)
        {
            try
            {
                return planMaster.PlannameExists(Planname);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "PlannameExists", 1);
                return false;
            }
        }
        [HttpGet]
        public IEnumerable<PlanMasterDTO> GetPlanByWorkTypeID(string SchemeID)
        {
            try
            {
                return planMaster.GetPlanByWorkTypeID(SchemeID);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "GetPlanByWorkTypeID", 1);
                return new List<PlanMasterDTO>();
            }
        }
    }
}
