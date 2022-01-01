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
    public class SchemeMasterController : ControllerBase
    {
        private readonly ILogger<SchemeMasterController> _logger;
        private readonly ISchemeMaster schemeMaster;
        public SchemeMasterController(ISchemeMaster _ISchemeMaster, ILogger<SchemeMasterController> logger)
        {
            schemeMaster = _ISchemeMaster;
            _logger = logger;
        }
        [HttpPost]
        [Route("InsertScheme")]
        public void InsertScheme(SchemeMasterDTO Scheme)
        {
            try
            {
                schemeMaster.InsertScheme(Scheme);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "InsertScheme", 1);
            }
        }
        [HttpGet]
        [Route("GetSchemes")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<SchemeMasterDTO> GetSchemes()
        {
            try
            {
                return schemeMaster.GetSchemes();
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "GetSchemes", 1);
                return new List<SchemeMasterDTO>();
            }
        }
        [HttpGet]
        [Route("GetSchemeByID")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public SchemeMasterDTO GetSchemeByID(string SchemeID)
        {
            try
            {
                return schemeMaster.GetSchemeByID(SchemeID);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "GetSchemeByID", 1);
                return new SchemeMasterDTO();
            }
        }
        [HttpPost]
        [Route("UpdateScheme")]
        public void UpdateScheme(SchemeMasterDTO Scheme)
        {
            try
            {
                schemeMaster.UpdateScheme(Scheme);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "UpdateScheme", 1);
            }
        }
        [HttpGet]
        [Route("DeleteScheme")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void DeleteScheme(string SchemeId)
        {
            try
            {
                schemeMaster.DeleteScheme(SchemeId);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "DeleteScheme", 1);
            }
        }
        [HttpGet]
        [Route("SchemeNameExists/{SchemeName}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool SchemeNameExists(string SchemeName)
        {
            try
            {
                return schemeMaster.SchemeNameExists(SchemeName);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "SchemeNameExists", 1);
                return false;
            }
        }
    }
}
