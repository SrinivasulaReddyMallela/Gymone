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
    public class PaymentController : BaseController
    {
        private readonly ILogger<PaymentController> _logger;
        private readonly IPaymentDetails iPaymentDetails;
        public PaymentController(IPaymentDetails _IPaymentDetails, ILogger<PaymentController> logger)
        {
            iPaymentDetails = _IPaymentDetails;
            _logger = logger;
        }

        [HttpPost]
        public int InsertPaymentDetails(PaymentDetailsDTO objPD)
        {
            try
            {
                return iPaymentDetails.InsertPaymentDetails(objPD);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "InsertPaymentDetails", 1);
                return 0;
            }
        }
        [HttpPost]
        public int UpdatePaymentDetails(PaymentDetailsDTO objPD)
        {
            try
            {
                return iPaymentDetails.UpdatePaymentDetails(objPD);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "UpdatePaymentDetails", 1);
                return 0;
            }
        }

    }
}
