using Gymone.API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace Gymone.API.Controllers
{
    [Route("api/[controller]")]

    public class ReceiptController : BaseController
    {

        private readonly ILogger<ReceiptController> _logger;
        private readonly IReceipt ireceipt;
        public ReceiptController(IReceipt _IReceipt, ILogger<ReceiptController> logger)
        {
            ireceipt = _IReceipt;
            _logger = logger;
        }
        [HttpGet]
        [Route("GenerateRecepitDataset/{MemberID}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public DataSet GenerateRecepitDataset(string MemberID)
        {
            try
            {
                return ireceipt.GenerateRecepitDataset(MemberID);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "GenerateRecepitDataset", 1);
                return new DataSet();
            }
        }
        [HttpGet]
        [Route("GenerateDeclarationDataset/{MemberID}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public DataSet GenerateDeclarationDataset(string MemberID)
        {
            try
            {
                return ireceipt.GenerateDeclarationDataset(MemberID);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "GenerateDeclarationDataset", 1);
                return new DataSet();
            }
        }
    }
}
