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
    public class PaymentlistingController : BaseController
    {

        private readonly ILogger<PaymentlistingController> _logger;
        private readonly IPaymentlisting ipaymentlisting;
        public PaymentlistingController(IPaymentlisting _IPaymentlisting, ILogger<PaymentlistingController> logger)
        {
            ipaymentlisting = _IPaymentlisting;
            _logger = logger;
        }
        [HttpGet]
        public IEnumerable<PaymentlistingDTO> AllPaymentDetails(string MemberID)
        {
            try
            {
                return ipaymentlisting.AllPaymentDetails(MemberID);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "AllPaymentDetails", 1);
                return new List<PaymentlistingDTO>();
            }
        }
        [HttpGet]
        public IEnumerable<PaymentlistingDTO> AllPaymentDetails()
        {
            try
            {
                return ipaymentlisting.AllPaymentDetails();
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "AllPaymentDetails", 1);
                return new List<PaymentlistingDTO>();
            }
        }
        [HttpGet]
        public IEnumerable<PaymentAutocompDTO> ListofMemberNo(string Memberno)
        {
            try
            {
                return ipaymentlisting.ListofMemberNo(Memberno);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "ListofMemberNo", 1);
                return new List<PaymentAutocompDTO>();
            }
        }
        [HttpGet]
        public IEnumerable<PaymentAutocompDTO> ListofMemberName(string Membername)
        {
            try
            {
                return ipaymentlisting.ListofMemberName(Membername);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "ListofMemberName", 1);
                return new List<PaymentAutocompDTO>();
            }
        }

    }
}
